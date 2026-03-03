using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour CardBrowserViewController :
    ///   - Start        : capture le SnapContentManager (pagination du scroll view)
    ///   - OnPageChanged: annonce automatiquement la carte courante lors d'un changement de page
    ///
    /// SnapContentManager.currentPage indique l'index de la page courante.
    /// Le navigateur utilise 3 slots de template recyclés (index 0–2) :
    ///   Template(Clone){currentPage % 3}/CardInfoDetail_Browser(Clone)
    ///
    /// IsActive() vérifie que le navigateur est encore affiché dans la scène.
    /// </summary>
    internal static class CardBrowserPatch
    {
        private static readonly BindingFlags Pub =
            BindingFlags.Public | BindingFlags.Instance;

        /// <summary>Instance SnapContentManager capturée, ou null hors navigateur.</summary>
        internal static object? SnapManager = null;

        // ── Postfix CardBrowserViewController.OnPageChanged ──────────────────

        /// <summary>
        /// Fires when the user scrolls to a new card page in the browser.
        /// Schedules a delayed card read so the card info panel has time to settle.
        /// Delay of 0.3 s is enough for the template slot to be updated.
        /// </summary>
        public static void OnPageChanged_Postfix(object __instance)
        {
            // Schedule a delayed card read — 0.3 s lets the template slot update
            KeyboardShortcuts.PendingCardReadAt = DateTime.Now.AddSeconds(0.3);
        }

        // ── Postfix CardBrowserViewController.Start ───────────────────────────

        public static void Start_Postfix(object __instance)
        {
            try
            {
                var snapType = AccessToolsHelper.FindType("SnapContentManager");
                if (snapType == null) return;

                var getComp = __instance.GetType().GetMethod(
                    "GetComponentInChildren", Pub, null,
                    new[] { typeof(System.Type), typeof(bool) }, null);
                SnapManager = getComp?.Invoke(__instance, new object[] { snapType, false });
            }
            catch { }

            // Schedule an initial read — 0.8 s gives the browser time to populate the first slot
            KeyboardShortcuts.PendingCardReadAt = DateTime.Now.AddSeconds(0.8);
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        /// <summary>Retourne currentPage depuis le SnapContentManager capturé.</summary>
        internal static int GetCurrentPage()
        {
            if (SnapManager == null) return 0;
            try
            {
                var f = SnapManager.GetType()
                    .GetField("currentPage", BindingFlags.Public | BindingFlags.Instance);
                return f?.GetValue(SnapManager) is int p ? p : 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Vérifie si le navigateur est encore actif (non fermé/détruit).
        /// Retourne false si SnapManager est null ou si le GO est inactif.
        /// </summary>
        internal static bool IsActive()
        {
            if (SnapManager == null) return false;
            try
            {
                var t  = SnapManager.GetType().GetProperty("transform", Pub)?.GetValue(SnapManager);
                var go = t?.GetType().GetProperty("gameObject", Pub)?.GetValue(t);
                return go?.GetType().GetProperty("activeInHierarchy", Pub)?.GetValue(go) is true;
            }
            catch { return false; }
        }
    }
}
