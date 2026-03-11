using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour l'écran de récompenses du Duel Pass :
    /// DuelPassRewardListViewController.
    ///
    /// ## Inspiré de AccessibleArena/RewardPopupNavigator
    ///
    /// Pattern identique : ItemContext (nested class) avec itemCategory, itemId, itemCount.
    /// Lecture via réflexion sur m_totalItemContexts (tous les items du Duel Pass).
    ///
    /// ## Ce qui est announcé :
    ///
    /// A) NotificationStackEntry()
    ///    → "Duel Pass — N récompenses disponibles."
    ///
    /// B) OnUpdateEntity(GameObject, int dataindex)
    ///    → Quand on navigue dans l'ISV, annonce l'item courant :
    ///      "[Nom], Grade [X], [Quantité]"
    ///
    /// ## Structure ItemContext
    ///
    ///   int grade       → niveau du Duel Pass (1..max)
    ///   bool isPeriod   → true si récompense premium (Period Pass)
    ///   int itemCategory → catégorie (0=carte, 1=gem, 2=déchet, etc.)
    ///   int itemId      → identifiant de l'item
    ///   int itemCount   → quantité reçue
    ///
    /// ## Catégories itemCategory (Master Duel)
    ///
    ///   0 = Carte (CardMrk)
    ///   1 = Gemstone (monnaie premium)
    ///   2 = N/A
    ///   3 = Deck (?)
    ///   10 = Protège-cartes
    ///   11 = Sleeve (protège-cartes)
    ///   ...
    ///
    /// On essaie GetCardName() en priorité, sinon on utilise le mapping catégorie.
    /// </summary>
    internal static class DuelPassRewardPatch
    {
        private static bool _applied = false;

        // Mapping dataIndex → nom résolu (pour navigation ISV)
        private static readonly Dictionary<int, string> _indexNames = new();

        // Cache type interne ItemContext (nested class)
        private static Type?   _itemContextType    = null;
        private static FieldInfo? _fGrade          = null;
        private static FieldInfo? _fIsPeriod        = null;
        private static FieldInfo? _fItemCategory   = null;
        private static FieldInfo? _fItemId         = null;
        private static FieldInfo? _fItemCount      = null;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.DuelPass.DuelPassRewardListViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[DuelPassRewardPatch] DuelPassRewardListViewController introuvable.");
                return;
            }

            // Localise le type interne ItemContext
            foreach (var nested in vcType.GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (nested.Name == "ItemContext")
                {
                    _itemContextType = nested;
                    _fGrade        = nested.GetField("grade",        BindingFlags.Public | BindingFlags.Instance);
                    _fIsPeriod     = nested.GetField("isPeriod",     BindingFlags.Public | BindingFlags.Instance);
                    _fItemCategory = nested.GetField("itemCategory", BindingFlags.Public | BindingFlags.Instance);
                    _fItemId       = nested.GetField("itemId",       BindingFlags.Public | BindingFlags.Instance);
                    _fItemCount    = nested.GetField("itemCount",    BindingFlags.Public | BindingFlags.Instance);
                    break;
                }
            }

            PatchStackEntry(harmony, vcType);
            PatchOnUpdateEntity(harmony, vcType);

            _applied = true;
            Plugin.Instance?.LogMsg("[DuelPassRewardPatch] Patches appliqués.");
        }

        // ── Patching ──────────────────────────────────────────────────────────

        private static void PatchStackEntry(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[DuelPassRewardPatch] NotificationStackEntry introuvable.");
                return;
            }
            h.Patch(m, postfix: new HarmonyMethod(
                typeof(DuelPassRewardPatch), nameof(StackEntry_Postfix)));
            Plugin.Instance?.LogMsg("[DuelPassRewardPatch] ✓ DuelPassRewardListViewController.NotificationStackEntry");
        }

        private static void PatchOnUpdateEntity(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OnUpdateEntity",
                BindingFlags.Public | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[DuelPassRewardPatch] OnUpdateEntity introuvable.");
                return;
            }
            h.Patch(m, postfix: new HarmonyMethod(
                typeof(DuelPassRewardPatch), nameof(OnUpdateEntity_Postfix)));
            Plugin.Instance?.LogMsg("[DuelPassRewardPatch] ✓ DuelPassRewardListViewController.OnUpdateEntity");
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        private static void StackEntry_Postfix(object __instance)
        {
            _indexNames.Clear();

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int count = CountTotalItems(__instance);
                string msg = count > 0
                    ? Loc.Get("duelpass_open_count", count)
                    : Loc.Get("duelpass_open");
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// OnUpdateEntity postfix.
        /// __1 = dataindex (index dans l'ISV)
        /// Résout le nom de l'item et annonce si c'est un nouvel index.
        /// </summary>
        private static void OnUpdateEntity_Postfix(object __instance, int __1)
        {
            int idx = __1;
            try
            {
                // Essaie de lire l'item correspondant à cet index dans m_totalItemContexts
                string? name = ResolveItemAtIndex(__instance, idx);
                if (string.IsNullOrEmpty(name)) return;

                _indexNames[idx] = name!;

                // Annonce seulement si c'est un nouvel index focalisé
                var tts = Plugin.Instance?.Tts;
                if (tts == null) return;

                int grade = ReadGradeAtIndex(__instance, idx);
                string msg = grade > 0
                    ? Loc.Get("duelpass_item_grade", name!, grade)
                    : name!;
                tts.Speak(msg, interrupt: true);
            }
            catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        /// <summary>
        /// Compte les ItemContexts dans m_totalItemContexts.
        /// </summary>
        private static int CountTotalItems(object instance)
        {
            try
            {
                var field = instance.GetType().GetField("m_totalItemContexts",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var list = field?.GetValue(instance) as System.Collections.IList;
                return list?.Count ?? 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Lit l'item à l'index dans m_totalItemContexts et le résout en nom lisible.
        /// </summary>
        private static string? ResolveItemAtIndex(object instance, int idx)
        {
            try
            {
                var field = instance.GetType().GetField("m_totalItemContexts",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var list = field?.GetValue(instance) as System.Collections.IList;
                if (list == null || idx < 0 || idx >= list.Count) return null;

                var ctx = list[idx];
                return ResolveItemContext(ctx);
            }
            catch { return null; }
        }

        private static int ReadGradeAtIndex(object instance, int idx)
        {
            try
            {
                var field = instance.GetType().GetField("m_totalItemContexts",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var list = field?.GetValue(instance) as System.Collections.IList;
                if (list == null || idx < 0 || idx >= list.Count) return 0;

                var ctx = list[idx];
                return (int?)_fGrade?.GetValue(ctx) ?? 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Résout un ItemContext en chaîne lisible.
        /// Inspiré de AccessibleArena/RewardPopupNavigator.ExtractRewardLabel().
        /// </summary>
        private static string? ResolveItemContext(object? ctx)
        {
            if (ctx == null) return null;
            try
            {
                int itemCategory = (int?)_fItemCategory?.GetValue(ctx) ?? 0;
                int itemId       = (int?)_fItemId?.GetValue(ctx)       ?? 0;
                int itemCount    = (int?)_fItemCount?.GetValue(ctx)     ?? 1;
                bool isPeriod    = (bool?)_fIsPeriod?.GetValue(ctx)    ?? false;

                string countStr = itemCount > 1 ? $" ×{itemCount}" : "";
                string periodStr = isPeriod ? Loc.Get("duelpass_period_tag") + " " : "";

                // Catégorie 0 : carte (tenter GetCardName)
                if (itemCategory == 0 && itemId > 0)
                {
                    string? cardName = AccessToolsHelper.GetCardName(itemId);
                    if (!string.IsNullOrWhiteSpace(cardName))
                        return periodStr + cardName! + countStr;
                }

                // Autres catégories : mapping par catégorie
                string catLabel = itemCategory switch {
                    1  => Loc.Get("item_cat_gems"),
                    10 => Loc.Get("item_cat_sleeve"),
                    11 => Loc.Get("item_cat_sleeve"),
                    _  => Loc.Get("item_cat_generic", itemCategory),
                };

                return periodStr + catLabel + countStr;
            }
            catch { return null; }
        }
    }
}
