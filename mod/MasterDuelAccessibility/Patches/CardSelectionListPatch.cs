using HarmonyLib;

using System;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Duel.CardSelectionList :
    ///   - SetList(ListType, ...)   : annonce le titre et le type de la liste quand elle s'ouvre
    ///   - SetCursor(int dataindex) : annonce la carte survolée dans la liste
    ///
    /// En duel, le joueur est souvent invité à sélectionner une carte dans une liste déroulante
    /// (ex : choisir une cible, sélectionner pour la Fusion, choisir l'ordre de la chaîne…).
    /// Sans cette annonce, un joueur non-voyant ne sait pas qu'une liste est ouverte ni combien
    /// de cartes sont disponibles.
    ///
    /// ## APIs ciblées
    ///
    /// ```
    /// public void SetList(ListType type, Action onFinished, string title, bool nocancel, ...)
    /// ```
    ///   type  = CardSelectionList.ListType (enum : Summon=0, Chain=6, Selection=10, ...)
    ///   title = texte d'en-tête affiché dans la liste (déjà localisé par le jeu)
    ///
    /// ```
    /// private void SetCursor(int dataindex)
    /// ```
    ///   dataindex = index de la carte survolée dans m_GroupedDataList
    ///
    /// ## Appel
    /// Appliqué par LatePatches.ApplyDuelScenePatches().
    /// </summary>
    internal static class CardSelectionListPatch
    {
        private static bool _applied = false;

        // Déduplication : évite de ré-annoncer SetList si appelée plusieurs fois de suite
        // avec les mêmes paramètres (bug défensif — peut arriver lors de listes chaînées).
        private static string _lastSetListKey = "";

        // Mémorise le nom de la dernière carte annoncée dans SetCursor pour éviter les
        // répétitions si SetCursor est appelé plusieurs fois sur la même carte.
        private static string _lastCursorCard = "";

        // Instance active de CardSelectionList — mise à jour par SetList_Postfix.
        // Utilisée par TryMoveNext() pour naviguer via Tab (modèle MTGA Tab = cycle targets).
        private static object? _activeInstance;
        private static MethodInfo? _setCursorMethod;

        /// <summary>
        /// When true, SetCursor_Postfix ignores dedup for one call.
        /// Set before programmatic cursor moves to ensure the card is always announced.
        /// </summary>
        internal static bool ForceNextAnnounce { get; set; }

        internal static void Reset()
        {
            _applied = false;
            _lastSetListKey = "";
            _lastCursorCard = "";
            _activeInstance  = null;
            _setCursorMethod = null;
            ForceNextAnnounce = false;
        }

        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[CardSelectionListPatch] Initialisation...");

            PatchSetList(harmony);
            PatchSetCursor(harmony);

            _applied = true;
            Plugin.Instance?.LogMsg("[CardSelectionListPatch] Patches appliqués.");
        }

        // ── Patch SetList ──────────────────────────────────────────────────────

        private static void PatchSetList(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Duel.CardSelectionList");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[CardSelectionListPatch] CardSelectionList introuvable.");
                    return;
                }

                // SetList(ListType type, Action onFinished, string title, bool nocancel, ...)
                // Paramètre 0 = ListType (int enum), Paramètre 2 = string title
                var method = type.GetMethod("SetList",
                    BindingFlags.Public | BindingFlags.Instance);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[CardSelectionListPatch] SetList introuvable.");
                    return;
                }

                var postfix = typeof(CardSelectionListPatch).GetMethod(
                    nameof(SetList_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[CardSelectionListPatch] ✓ CardSelectionList.SetList");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[CardSelectionListPatch] Erreur PatchSetList: {ex.Message}");
            }
        }

        // ── Patch SetCursor ────────────────────────────────────────────────────

        private static void PatchSetCursor(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Duel.CardSelectionList");
                if (type == null) return;

                // SetCursor est private — chercher par nom exact
                var method = type.GetMethod("SetCursor",
                    BindingFlags.NonPublic | BindingFlags.Instance);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[CardSelectionListPatch] SetCursor introuvable.");
                    return;
                }

                var postfix = typeof(CardSelectionListPatch).GetMethod(
                    nameof(SetCursor_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[CardSelectionListPatch] ✓ CardSelectionList.SetCursor");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[CardSelectionListPatch] Erreur PatchSetCursor: {ex.Message}");
            }
        }

        // ── Postfix : SetList ──────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour CardSelectionList.SetList(ListType type, Action, string title, ...).
        ///
        /// __instance = l'instance CardSelectionList
        /// __0        = ListType (int) — ex: 0=Summon, 6=Chain, 10=Selection
        /// __2        = string title — texte d'en-tête déjà localisé par le jeu
        ///
        /// Annonce : "{type localisé} : {titre}" + nombre de cartes disponibles
        /// </summary>
        private static void SetList_Postfix(object __instance, int __0, string __2)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Stocker l'instance active et mettre en cache la méthode SetCursor pour Tab
                _activeInstance = __instance;
                if (_setCursorMethod == null)
                    _setCursorMethod = __instance.GetType()
                        .GetMethod("SetCursor", BindingFlags.NonPublic | BindingFlags.Instance);

                // Construire la clé de déduplication
                string dedupKey = $"{__0}:{__2}";
                if (dedupKey == _lastSetListKey) return;
                _lastSetListKey = dedupKey;
                _lastCursorCard = ""; // reset navigation dans la liste

                string typeLabel = GetListTypeLabel(__0);
                string title     = string.IsNullOrWhiteSpace(__2) ? typeLabel : __2;

                // Compter les cartes dans m_GroupedDataList via réflexion
                int count = CountGroupedData(__instance);

                string msg = count > 0
                    ? Loc.Get("card_sel_list_open", title, count, count > 1 ? "s" : "")
                    : Loc.Get("card_sel_list_open_nocount", title);

                Plugin.Instance?.LogMsg($"[CardSelectionListPatch] SetList type={__0} title={__2} count={count}");

                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        // ── Postfix : SetCursor ────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour CardSelectionList.SetCursor(int dataindex).
        ///
        /// __instance = l'instance CardSelectionList
        /// __0        = index de la carte survolée dans m_GroupedDataList
        ///
        /// Annonce le nom de la carte + sa position dans la liste.
        /// </summary>
        private static void SetCursor_Postfix(object __instance, int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (__0 < 0) return;

                // Récupérer m_GroupedDataList via réflexion
                var listField = __instance.GetType().GetField("m_GroupedDataList",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var list = listField?.GetValue(__instance) as System.Collections.IList;
                if (list == null || __0 >= list.Count) return;

                var item   = list[__0];
                int total  = list.Count;
                string? cardName = GetCardDataName(item);
                if (string.IsNullOrWhiteSpace(cardName)) return;

                // Éviter de répéter si on re-lit la même carte.
                // Exception : ForceNextAnnounce=true (déplacement programmatique via Tab)
                // garantit que le joueur entend toujours la carte naviguée.
                bool forced = ForceNextAnnounce;
                ForceNextAnnounce = false;
                if (cardName == _lastCursorCard && !forced) return;
                _lastCursorCard = cardName!;

                string msg = Loc.Get("card_sel_cursor", cardName!, __0 + 1, total);
                tts.Speak(msg, interrupt: false, addToHistory: false);
            }
            catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        /// <summary>
        /// Traduit l'enum ListType (int) en label localisé.
        /// Les valeurs correspondent à CardSelectionList.ListType dans Assembly-CSharp.
        /// </summary>
        private static string GetListTypeLabel(int listType) => listType switch
        {
            0  => Loc.Get("sel_type_summon"),
            1  => Loc.Get("sel_type_spsummon"),
            2  => Loc.Get("sel_type_monster_effect"),
            3  => Loc.Get("sel_type_magic_trap"),
            4  => Loc.Get("sel_type_flip"),
            5  => Loc.Get("sel_type_attack"),
            6  => Loc.Get("sel_type_chain"),
            7  => Loc.Get("sel_type_check_timing"),
            8  => Loc.Get("sel_type_normal"),
            10 => Loc.Get("sel_type_selection"),
            11 => Loc.Get("sel_type_grave"),
            12 => Loc.Get("sel_type_extra"),
            13 => Loc.Get("sel_type_deck"),
            14 => Loc.Get("sel_type_opp_hand"),
            _  => Loc.Get("sel_type_generic"),
        };

        /// <summary>
        /// Compte les entrées dans m_GroupedDataList via réflexion.
        /// </summary>
        private static int CountGroupedData(object instance)
        {
            try
            {
                var f = instance.GetType().GetField("m_GroupedDataList",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var list = f?.GetValue(instance) as System.Collections.IList;
                return list?.Count ?? 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Avance le curseur de la liste de sélection active d'une position (wrap-around).
        ///
        /// Implémente le pattern MTGA Tab = "Cycle targets or highlighted elements" :
        /// si une CardSelectionList est ouverte, Tab navigue dedans au lieu d'avancer la phase.
        ///
        /// Retourne true si le curseur a été déplacé (la liste est active et non vide).
        /// SetCursor_Postfix annonce automatiquement la carte via ForceNextAnnounce=true.
        /// </summary>
        internal static bool TryMoveNext()
        {
            if (_activeInstance == null || _setCursorMethod == null) return false;
            try
            {
                var type = _activeInstance.GetType();

                // Vérifier que la liste est ouverte (IsActive = public bool property)
                var isActiveProp = type.GetProperty("IsActive",
                    BindingFlags.Public | BindingFlags.Instance);
                if (isActiveProp?.GetValue(_activeInstance) is not true) return false;

                // Lire l'index courant (CurrentCursoredDataIndex = public int field)
                var cursorField = type.GetField("CurrentCursoredDataIndex",
                    BindingFlags.Public | BindingFlags.Instance);
                int current = cursorField?.GetValue(_activeInstance) is int c ? c : 0;

                // Compter les cartes disponibles
                var listField = type.GetField("m_GroupedDataList",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var list = listField?.GetValue(_activeInstance) as System.Collections.IList;
                if (list == null || list.Count == 0) return false;

                int next = (current + 1) % list.Count;

                // Forcer l'annonce même si c'est la même carte (wrap-around)
                ForceNextAnnounce = true;
                _setCursorMethod.Invoke(_activeInstance, new object[] { next });
                return true;
            }
            catch { ForceNextAnnounce = false; return false; }
        }

        /// <summary>
        /// Lit le cardId depuis un ListCardData, puis résout le nom via Content.Instance.GetName().
        /// </summary>
        private static string? GetCardDataName(object? item)
        {
            if (item == null) return null;
            try
            {
                // ListCardData.cardId (public int)
                var cardIdProp = item.GetType().GetProperty("cardId",
                    BindingFlags.Public | BindingFlags.Instance)
                    ?? item.GetType().GetField("cardId",
                    BindingFlags.Public | BindingFlags.Instance) as MemberInfo;

                int cardId = 0;
                if (item.GetType().GetProperty("cardId",
                    BindingFlags.Public | BindingFlags.Instance)?.GetValue(item) is int id)
                    cardId = id;
                else if (item.GetType().GetField("cardId",
                    BindingFlags.Public | BindingFlags.Instance)?.GetValue(item) is int fid)
                    cardId = fid;

                if (cardId <= 0) return null;

                var contentType = AccessToolsHelper.FindType("Content");
                if (contentType == null) return null;
                var inst = contentType.GetProperty("Instance",
                    BindingFlags.Public | BindingFlags.Static)?.GetValue(null);
                if (inst == null) return null;
                var getName = contentType.GetMethod("GetName",
                    BindingFlags.Public | BindingFlags.Instance,
                    null, new[] { typeof(int), typeof(bool) }, null);
                return getName?.Invoke(inst, new object[] { cardId, false }) as string;
            }
            catch { return null; }
        }
    }
}
