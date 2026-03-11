using HarmonyLib;

using System;
using System.Linq;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch runtime interceptant la file d'effets de duel de Master Duel.
    ///
    /// Inspiré de MTGA AccessibleArena — UXEventQueuePatch.Initialize() :
    ///   - Chargement dynamique des types via FindType (types non disponibles au démarrage)
    ///   - Interception de la méthode clé du pipeline d'effets pour annoncer les événements
    ///
    /// ## Stratégie d'interception
    ///
    /// Dans Master Duel, les informations en cours de duel sont affichées via deux canaux :
    ///
    /// 1. **InstantMessage.ReqOpen(string message)**
    ///    Messages temporaires flash (ex: "Activation de l'effet de Pot of Greed").
    ///    → Patch postfix : lit le message à voix haute avec interruption.
    ///
    /// 2. **RunEffectWorker.infoMessage (setter de propriété)**
    ///    Barre d'info permanente en bas du champ (ex: "Veuillez sélectionner une cible").
    ///    → Patch postfix du setter : annonce le message quand il change.
    ///
    /// 3. **MessageDialog.Open(string message, ...)**
    ///    Dialogs de messages généraux pendant le duel (déjà couvert par DialogStatePatch).
    ///
    /// ## Appel
    /// Appelé par LatePatches.Initialize() lorsque la scène duel est chargée.
    ///
    /// ## Analogie MTGA
    /// UXEventQueuePatch.EnqueuePendingSinglePostfix → notre InstantMessage_ReqOpen_Postfix
    /// UXEventQueuePatch.EnqueuePendingMultiPostfix  → notre RunEffectWorker.infoMessage setter
    /// </summary>
    internal static class DuelEffectQueuePatch
    {
        private static bool _applied = false;
        private static int _messageCount = 0;

        /// <summary>
        /// Réinitialise l'état du patch pour permettre la ré-application lors d'une
        /// nouvelle entrée en scène duel (ex. après un second match).
        /// Les patches Harmony eux-mêmes persistent — seul le flag _applied est réinitialisé
        /// pour que Initialize() accepte de refaire la découverte des types si nécessaire.
        /// </summary>
        internal static void Reset() => _applied = false;

        // ── Déduplication des messages ─────────────────────────────────────────
        //
        // Problème : DuelEventPatch.RunEffect_Postfix annonce un événement (ex. "Synchro
        // Summon!") ET InstantMessage.ReqOpen peut aussi se déclencher au même moment
        // avec un texte équivalent affiché à l'écran → double annonce.
        //
        // Solution inspirée du pattern MTGA UXEventQueuePatch (comptage + logging) :
        //   ─ Pour InstantMessage : fenêtre de 300 ms. Si le même texte exact a déjà été
        //     prononcé dans cette fenêtre, on l'ignore.
        //   ─ Pour InfoMessage (setter) : dédup par contenu exact sans limite de temps.
        //     La barre d'info ne change d'instruction que quand le contexte change réellement.

        private static string   _lastInstantMsg     = "";
        private static DateTime _lastInstantMsgTime = DateTime.MinValue;
        private static readonly TimeSpan InstantDedupWindow = TimeSpan.FromMilliseconds(300);

        private static string _lastInfoMsg = "";

        /// <summary>
        /// Current game instruction displayed in the duel info bar (e.g. "Select a target").
        /// Used by the S shortcut to let the user re-read what action is required.
        /// </summary>
        internal static string LastInfoMsg => _lastInfoMsg;

        /// <summary>Last flash message (InstantMessage) announced during the duel.</summary>
        internal static string LastInstantMsg => _lastInstantMsg;

        /// <summary>
        /// Réinitialise l'état de déduplication entre deux duels.
        /// Appelé par DuelEventPatch.DuelStart_Postfix.
        /// </summary>
        internal static void ResetDuelState()
        {
            _lastInstantMsg     = "";
            _lastInstantMsgTime = DateTime.MinValue;
            _lastInfoMsg        = "";
            _messageCount       = 0;
        }

        /// <summary>
        /// Retourne true (et met à jour le cache) si ce message InstantMessage a déjà
        /// été prononcé dans la fenêtre de déduplication. Évite les doubles annonces
        /// lorsque RunEffect et InstantMessage se déclenchent pour le même événement.
        /// </summary>
        private static bool IsInstantDuplicate(string msg)
        {
            var now = DateTime.Now;
            if (msg == _lastInstantMsg && now - _lastInstantMsgTime < InstantDedupWindow)
                return true;

            _lastInstantMsg     = msg;
            _lastInstantMsgTime = now;
            return false;
        }

        /// <summary>
        /// Applique les patches de file d'effets duel.
        /// Doit être appelé depuis <see cref="LatePatches.Initialize"/> en scène duel.
        /// </summary>
        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[DuelEffectQueuePatch] Initialisation des patches de file d'effets...");

            // ── 1. InstantMessage.ReqOpen(string message, float showTime) ──────
            // C'est le point d'entrée principal des notifications flash en duel.
            // Patch postfix pour lire le message avec interruption (haute priorité).
            PatchInstantMessage(harmony);

            // ── 2. RunEffectWorker.infoMessage setter ─────────────────────────
            // Annonce les changements de la barre d'info (sélection de cible, etc.).
            PatchInfoMessageSetter(harmony);

            _applied = true;
            Plugin.Instance?.LogMsg("[DuelEffectQueuePatch] Patches de file d'effets appliqués.");

            // Découverte des types disponibles (debug uniquement)
            DiscoverDuelMessageTypes();
        }

        // ── Méthodes d'application de patches ────────────────────────────────

        private static void PatchInstantMessage(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Duel.InstantMessage");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[DuelEffectQueuePatch] Type 'InstantMessage' introuvable.");
                    return;
                }

                // Patch toutes les surcharges de ReqOpen — on veut celles avec string en premier param
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Where(m => m.Name == "ReqOpen"
                                && m.GetParameters().Length >= 1
                                && m.GetParameters()[0].ParameterType == typeof(string))
                    .ToArray();

                if (methods.Length == 0)
                {
                    Plugin.Instance?.LogWarn("[DuelEffectQueuePatch] Aucune surcharge ReqOpen(string,...) trouvée.");
                    return;
                }

                var postfix = typeof(DuelEffectQueuePatch).GetMethod(
                    nameof(InstantMessage_ReqOpen_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                foreach (var m in methods)
                {
                    try
                    {
                        harmony.Patch(m, postfix: new HarmonyMethod(postfix));
                        var paramStr = string.Join(", ", m.GetParameters().Select(p => p.ParameterType.Name));
                        Plugin.Instance?.LogMsg($"[DuelEffectQueuePatch] ✓ InstantMessage.ReqOpen({paramStr})");
                    }
                    catch (Exception ex)
                    {
                        Plugin.Instance?.LogErr($"[DuelEffectQueuePatch] Échec ReqOpen override: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelEffectQueuePatch] Erreur PatchInstantMessage: {ex.Message}");
            }
        }

        private static void PatchInfoMessageSetter(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Duel.RunEffectWorker");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[DuelEffectQueuePatch] Type 'RunEffectWorker' introuvable.");
                    return;
                }

                // infoMessage est une propriété privée — chercher le setter via reflection
                var prop = type.GetProperty("infoMessage",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                if (prop == null)
                {
                    Plugin.Instance?.LogWarn("[DuelEffectQueuePatch] Propriété 'infoMessage' introuvable.");
                    return;
                }

                var setter = prop.GetSetMethod(nonPublic: true);
                if (setter == null)
                {
                    Plugin.Instance?.LogWarn("[DuelEffectQueuePatch] Setter 'infoMessage' introuvable.");
                    return;
                }

                var postfix = typeof(DuelEffectQueuePatch).GetMethod(
                    nameof(InfoMessage_Setter_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(setter, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[DuelEffectQueuePatch] ✓ RunEffectWorker.infoMessage setter");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelEffectQueuePatch] Erreur PatchInfoMessageSetter: {ex.Message}");
            }
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour InstantMessage.ReqOpen(string message, ...).
        ///
        /// Analogue à UXEventQueuePatch.EnqueuePendingSinglePostfix :
        /// Lit chaque message flash à voix haute avec interruption.
        ///
        /// Déduplication (300 ms) : DuelEventPatch.RunEffect et ce patch peuvent
        /// se déclencher au même moment pour le même événement. Si le message est
        /// identique à ce qui vient d'être prononcé, on le saute pour éviter la
        /// double annonce. Inspiré du pattern de logging MTGA (compteur de messages)
        /// étendu avec une fenêtre temporelle de dédup.
        ///
        /// Le paramètre __0 est le 1er paramètre de ReqOpen (le message string).
        /// </summary>
        private static void InstantMessage_ReqOpen_Postfix(object __instance, string __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (string.IsNullOrWhiteSpace(__0)) return;

                _messageCount++;

                // Log uniquement à la 1ère réception et tous les 50 messages ensuite
                // pour diagnostiquer les événements sans inonder le log (pattern UXEventQueuePatch).
                if (_messageCount == 1 || _messageCount % 50 == 0)
                    Plugin.Instance?.LogMsg($"[DuelEffectQueuePatch] Flash #{_messageCount}: {__0}");

                // Dédup temporelle (300 ms) : si RunEffect a déjà émis ce même texte
                // juste avant, on évite la double annonce.
                if (IsInstantDuplicate(__0)) return;

                // Lire le message avec interruption — c'est une notification critique
                tts.Speak(__0, interrupt: true);
            }
            catch { }
        }

        /// <summary>
        /// Postfix pour le setter de RunEffectWorker.infoMessage.
        ///
        /// Annonce les messages de la barre d'info du bas (instructions de sélection).
        /// Utilise interrupt: false pour ne pas couper un message flash plus important.
        ///
        /// Déduplication par contenu exact : la barre d'info est souvent réécrite avec
        /// la même instruction (ex. "Choisissez une cible") plusieurs fois de suite.
        /// On ne relit que quand le texte change réellement.
        ///
        /// __instance = le RunEffectWorker
        /// value (__0) = la nouvelle valeur de infoMessage
        /// </summary>
        private static void InfoMessage_Setter_Postfix(object __instance, string __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (string.IsNullOrWhiteSpace(__0)) return;

                // Dédup exact : la barre d'info est souvent rafraîchie avec le même texte
                // lors de mises à jour UI. Ne parler que si le message a changé.
                if (__0 == _lastInfoMsg) return;
                _lastInfoMsg = __0;

                // Log uniquement quand le message change (évite de saturer le log)
                Plugin.Instance?.LogMsg($"[DuelEffectQueuePatch] InfoMsg (new): {__0}");

                // Faible priorité (interrupt: false) — la barre d'info est moins urgente
                // qu'un message flash. Ne coupe pas la lecture en cours.
                tts.Speak(__0, interrupt: false);
            }
            catch { }
        }

        // ── Découverte des types de messages duel ────────────────────────────────

        /// <summary>
        /// Découvre et journalise les types de classes duel susceptibles de transmettre
        /// des messages à l'écran. Inspiré de PanelStatePatch.DiscoverPanelTypes() de MTGA.
        /// Activé uniquement en mode debug (première initialisation en duel).
        /// Permet d'identifier de nouvelles cibles de patch dans les futures versions du jeu.
        /// </summary>
        private static void DiscoverDuelMessageTypes()
        {
            try
            {
                // Mots-clés caractéristiques des systèmes de message en duel
                var keywords = new[] { "Message", "Info", "Instant", "Popup", "Toast",
                                       "Notify", "Announce", "Notice", "Dialog", "Banner" };

                Plugin.Instance?.LogMsg("[DuelEffectQueuePatch] === Découverte des types de messages ===");

                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    try
                    {
                        if (assembly.FullName?.StartsWith("System") == true ||
                            assembly.FullName?.StartsWith("mscorlib") == true ||
                            assembly.FullName?.StartsWith("Unity") == true)
                            continue;

                        foreach (var type in assembly.GetTypes())
                        {
                            bool hasKeyword = false;
                            foreach (var kw in keywords)
                            {
                                if (type.Name.Contains(kw)) { hasKeyword = true; break; }
                            }
                            if (!hasKeyword) continue;

                            // Cherche une méthode ReqOpen ou Open avec un paramètre string
                            bool hasReqOpen = type.GetMethods(
                                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                                .Any(m => (m.Name == "ReqOpen" || m.Name == "Open" || m.Name == "Show")
                                         && m.GetParameters().Length >= 1
                                         && m.GetParameters()[0].ParameterType == typeof(string));

                            if (hasReqOpen)
                                Plugin.Instance?.LogMsg(
                                    $"[DuelEffectQueuePatch] Candidat trouvé : {type.FullName}");
                        }
                    }
                    catch { /* assembly partiellement chargé */ }
                }

                Plugin.Instance?.LogMsg("[DuelEffectQueuePatch] === Découverte terminée ===");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[DuelEffectQueuePatch] Erreur découverte : {ex.Message}");
            }
        }
    }
}
