using HarmonyLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans de loterie (ouverture de packs) :
    ///
    /// 1. LotteryRewardViewContorller.OnCreatedView() :
    ///    Annonce toutes les cartes obtenues à l'ouverture de l'écran de résultats.
    ///
    /// 2. SelectedCardsWidget.SetCardButtonAction(SelectionButton, ..., int mrk) :
    ///    Stocke un mapping bouton → cardId pour que SelectionButtonPatch puisse
    ///    annoncer le nom de la carte quand le joueur navigue dans les cartes obtenues
    ///    (écran de révélation drag-to-reveal).
    ///
    /// 3. LotteryRewardViewContorller.OnUpdateEntity(GameObject, int) :
    ///    Capture dataIndex → item name pour la navigation clavier dans l'ISV.
    ///
    /// 4. Compiler-generated focus callback b__34_1(int idx, int preIdx) :
    ///    Annonce l'item focalisé quand le joueur navigue dans la liste ISV.
    ///
    /// ## Données
    ///
    /// LotteryRewardViewContorller (écran résumé) :
    /// - m_RewardItemList = List&lt;EntryItemListData&gt;
    /// - Chaque EntryItemListData.contexts[i].itemId → Content.Instance.GetName()
    /// - m_Isv = InfinityScrollView, m_IsvSelector = Selector (keyboard nav)
    ///
    /// SelectedCardsWidget (widget cartes révélées) :
    /// - SetCardButtonAction(button, widgetCount, cardCount, allCards, numbers, mrk)
    /// - mrk = card ID → stocké dans _buttonCardMap[button.GetInstanceID()]
    ///
    /// ## Appel
    /// Appliqué par LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class LotteryRewardPatch
    {
        private static bool _applied = false;

        // Mapping button instance ID → card ID for lottery card buttons.
        // Consulted by SelectionButtonPatch to announce card names.
        private static readonly Dictionary<int, int> _buttonCardMap = new();

        // Mapping dataIndex → resolved item name for ISV keyboard navigation.
        // Populated by OnUpdateEntity, consumed by the focus callback.
        private static readonly Dictionary<int, string> _dataIndexNames = new();

        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[LotteryRewardPatch] Initialisation...");

            PatchOnCreatedView(harmony);
            PatchSetCardButtonAction(harmony);
            PatchOnUpdateEntity(harmony);
            PatchFocusCallback(harmony);

            _applied = true;
            Plugin.Instance?.LogMsg("[LotteryRewardPatch] Patches appliqués.");
        }

        // ── Public API for SelectionButtonPatch ──────────────────────────────

        /// <summary>
        /// If this button instance ID belongs to a lottery card, returns the card name.
        /// Called by SelectionButtonPatch.OnSelected_Postfix.
        /// </summary>
        internal static string? TryGetCardName(int buttonInstanceId)
        {
            if (!_buttonCardMap.TryGetValue(buttonInstanceId, out int cardId) || cardId <= 0)
                return null;
            return AccessToolsHelper.GetCardName(cardId);
        }

        // ── Patch OnCreatedView ────────────────────────────────────────────────

        private static void PatchOnCreatedView(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Lottery.LotteryRewardViewContorller");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] LotteryRewardViewContorller introuvable.");
                    return;
                }

                var method = type.GetMethod("OnCreatedView",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] OnCreatedView introuvable.");
                    return;
                }

                var postfix = typeof(LotteryRewardPatch).GetMethod(
                    nameof(OnCreatedView_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[LotteryRewardPatch] ✓ LotteryRewardViewContorller.OnCreatedView");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[LotteryRewardPatch] Erreur PatchOnCreatedView: {ex.Message}");
            }
        }

        // ── Patch SetCardButtonAction ──────────────────────────────────────────

        private static void PatchSetCardButtonAction(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Lottery.SelectedCardsWidget");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] SelectedCardsWidget introuvable.");
                    return;
                }

                // SetCardButtonAction(SelectionButton, int, int, List<int>, List<int>, int)
                // private instance method
                var method = type.GetMethod("SetCardButtonAction",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] SetCardButtonAction introuvable.");
                    return;
                }

                var postfix = typeof(LotteryRewardPatch).GetMethod(
                    nameof(SetCardButtonAction_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[LotteryRewardPatch] ✓ SelectedCardsWidget.SetCardButtonAction");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[LotteryRewardPatch] Erreur PatchSetCardButtonAction: {ex.Message}");
            }
        }

        // ── Patch OnUpdateEntity ─────────────────────────────────────────────

        private static void PatchOnUpdateEntity(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Lottery.LotteryRewardViewContorller");
                if (type == null) return;

                var method = type.GetMethod("OnUpdateEntity",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] OnUpdateEntity introuvable.");
                    return;
                }

                var postfix = typeof(LotteryRewardPatch).GetMethod(
                    nameof(OnUpdateEntity_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[LotteryRewardPatch] ✓ LotteryRewardViewContorller.OnUpdateEntity");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[LotteryRewardPatch] Erreur PatchOnUpdateEntity: {ex.Message}");
            }
        }

        // ── Patch focus callback (compiler-generated) ────────────────────────

        private static void PatchFocusCallback(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("YgomGame.Lottery.LotteryRewardViewContorller");
                if (type == null) return;

                // Find the compiler-generated callback <OnCreatedView>b__34_1(int idx, int preIdx)
                // which fires when the ISV scroll index changes.
                var method = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                    .FirstOrDefault(m => m.Name.Contains("b__34_1")
                        && m.GetParameters().Length == 2);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] Focus callback b__34_1 introuvable.");
                    return;
                }

                var postfix = typeof(LotteryRewardPatch).GetMethod(
                    nameof(FocusCallback_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg($"[LotteryRewardPatch] ✓ Focus callback {method.Name}");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[LotteryRewardPatch] Erreur PatchFocusCallback: {ex.Message}");
            }
        }

        // ── Postfix : OnCreatedView ────────────────────────────────────────────

        /// <summary>
        /// Announces all obtained card names when the reward summary screen opens.
        /// </summary>
        private static void OnCreatedView_Postfix(object __instance)
        {
            // Clear ISV navigation cache for this new reward screen
            _dataIndexNames.Clear();

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var rewardList = ReadRewardItemList(__instance);
                if (rewardList == null || rewardList.Count == 0)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] m_RewardItemList vide ou null.");
                    return;
                }

                var names = new List<string>();
                foreach (var entry in rewardList)
                {
                    var contexts = ReadContexts(entry);
                    if (contexts == null) continue;

                    foreach (var ctx in contexts)
                    {
                        string? name = ResolveItemName(ctx);
                        if (!string.IsNullOrWhiteSpace(name))
                            names.Add(name!);
                    }
                }

                if (names.Count == 0)
                {
                    Plugin.Instance?.LogWarn("[LotteryRewardPatch] Aucun item résolu dans RewardItemList.");
                    return;
                }

                string msg = Loc.Get("lottery_reward_open", string.Join(", ", names));
                Plugin.Instance?.LogMsg($"[LotteryRewardPatch] Annonce {names.Count} item(s).");
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[LotteryRewardPatch] OnCreatedView_Postfix: {ex.Message}");
            }
        }

        // ── Postfix : SetCardButtonAction ──────────────────────────────────────

        /// <summary>
        /// Postfix pour SelectedCardsWidget.SetCardButtonAction
        /// (SelectionButton button, int widgetCount, int cardCount,
        ///  List&lt;int&gt; allCards, List&lt;int&gt; numbers, int mrk).
        ///
        /// __0 = SelectionButton button  (the UI button for this card)
        /// __5 = int mrk                 (the card ID)
        ///
        /// Stores button.GetInstanceID() → mrk in _buttonCardMap so that
        /// SelectionButtonPatch can announce the card name on focus.
        /// </summary>
        private static void SetCardButtonAction_Postfix(object __0, int __5)
        {
            try
            {
                if (__0 == null || __5 <= 0) return;

                // __0 is a SelectionButton (MonoBehaviour → UnityEngine.Object)
                // Call GetInstanceID() via reflection to get a stable int key
                var getIdMethod = __0.GetType().GetMethod("GetInstanceID",
                    BindingFlags.Public | BindingFlags.Instance);
                if (getIdMethod?.Invoke(__0, null) is int instanceId)
                {
                    _buttonCardMap[instanceId] = __5;
                    Plugin.Instance?.LogMsg(
                        $"[LotteryRewardPatch] Mapped button {instanceId} → card {__5}");
                }
            }
            catch { /* silent — non-critical */ }
        }

        // ── Postfix : OnUpdateEntity ────────────────────────────────────────────

        /// <summary>
        /// Captures item name for each ISV cell as it gets bound to data.
        /// __instance = LotteryRewardViewContorller, __1 = dataIndex.
        /// Reads m_RewardItemList[dataIndex] to resolve the item name.
        /// </summary>
        private static void OnUpdateEntity_Postfix(object __instance, int __1)
        {
            try
            {
                int dataIndex = __1;
                var rewardList = ReadRewardItemList(__instance);
                if (rewardList == null || dataIndex < 0 || dataIndex >= rewardList.Count) return;

                var entry = rewardList[dataIndex];
                var contexts = ReadContexts(entry);
                if (contexts == null || contexts.Count == 0) return;

                // Use the first context's item name
                string? name = ResolveItemName(contexts[0]);
                if (!string.IsNullOrWhiteSpace(name))
                {
                    _dataIndexNames[dataIndex] = name!;
                }
            }
            catch { /* non-critical */ }
        }

        // ── Postfix : Focus callback ────────────────────────────────────────────

        /// <summary>
        /// Announces the item at the focused ISV index.
        /// __0 = idx (new focused index), __1 = preIdx (previous index).
        /// </summary>
        private static void FocusCallback_Postfix(int __0, int __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int idx = __0;
                if (idx == __1) return; // no change

                if (_dataIndexNames.TryGetValue(idx, out string? name)
                    && !string.IsNullOrWhiteSpace(name))
                {
                    // Announce: "CardName, N of M"
                    int total = _dataIndexNames.Count;
                    string msg = Loc.Get("lottery_reward_item", name!, idx + 1, total);
                    tts.Speak(msg, interrupt: true);
                }
            }
            catch { /* non-critical */ }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static System.Collections.IList? ReadRewardItemList(object instance)
        {
            try
            {
                var f = instance.GetType().GetField("m_RewardItemList",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                return f?.GetValue(instance) as System.Collections.IList;
            }
            catch { return null; }
        }

        private static System.Collections.IList? ReadContexts(object? entryItemListData)
        {
            if (entryItemListData == null) return null;
            try
            {
                var f = entryItemListData.GetType().GetField("contexts",
                    BindingFlags.Public | BindingFlags.Instance);
                return f?.GetValue(entryItemListData) as System.Collections.IList;
            }
            catch { return null; }
        }

        private static string? ResolveItemName(object? context)
        {
            if (context == null) return null;
            try
            {
                var type = context.GetType();

                int itemId = 0;
                if (type.GetField("itemId", BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(context) is int id)
                    itemId = id;

                if (itemId <= 0) return null;

                string? name = AccessToolsHelper.GetCardName(itemId);
                if (!string.IsNullOrWhiteSpace(name))
                    return name;

                // Fallback: generic label for non-card items (gems, CP, etc.)
                int cat = 0;
                if (type.GetField("itemCategory", BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(context) is int c)
                    cat = c;

                return Loc.Get("lottery_item_generic", cat, itemId);
            }
            catch { return null; }
        }
    }
}
