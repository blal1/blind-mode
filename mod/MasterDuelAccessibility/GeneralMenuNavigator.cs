using System;
using System.Reflection;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// Determines the 1-based position of a focused SelectionButton among its active
    /// SelectionButton siblings inside the same parent transform.
    ///
    /// Used by SelectionButtonPatch.OnSelected_Postfix to append "N sur M" (FR)
    /// or "N of M" (EN) to every button announcement automatically, with no
    /// menu-specific code required.
    ///
    /// Algorithm:
    ///   1. Walk to the focused transform's parent.
    ///   2. Iterate children: keep those that are activeInHierarchy AND have
    ///      a YgomSystem.UI.SelectionButton component.
    ///   3. The index of the focused transform in that list → position.
    ///   4. Return null when only 1 sibling found (no useful position info).
    ///
    /// Instance identity is compared via Unity's GetInstanceID() to avoid
    /// reference equality issues with IL2CPP proxy objects.
    /// </summary>
    internal static class GeneralMenuNavigator
    {
        private static readonly BindingFlags Pub = BindingFlags.Public | BindingFlags.Instance;

        // Cached type to avoid repeated AccessTools lookups on every call.
        private static Type? _selectionButtonType;

        private static Type? SelectionButtonType =>
            _selectionButtonType ??= AccessToolsHelper.FindType("YgomSystem.UI.SelectionButton");

        /// <summary>
        /// Returns (1-based index, total) of the given transform among its
        /// active SelectionButton siblings. Returns null if the position cannot
        /// be determined or if there is only one item.
        /// </summary>
        public static (int index, int total)? GetPosition(object? xform)
        {
            if (xform == null) return null;
            try
            {
                return Compute(xform);
            }
            catch { return null; }
        }

        // ── Core logic ────────────────────────────────────────────────────────

        private static (int index, int total)? Compute(object xform)
        {
            var parent = Prop(xform, "parent");
            if (parent == null) return null;

            int childCount = PropInt(parent, "childCount");
            if (childCount <= 1) return null;

            var sbType = SelectionButtonType;
            if (sbType == null) return null;

            var getChildM = parent.GetType().GetMethod(
                "GetChild", Pub, null, new[] { typeof(int) }, null);
            if (getChildM == null) return null;

            int xformId  = InstanceID(xform);
            int myIndex  = -1;
            int total    = 0;

            for (int i = 0; i < childCount; i++)
            {
                var child = getChildM.Invoke(parent, new object[] { i });
                if (child == null)        continue;
                if (!IsActive(child))     continue;
                if (!HasSB(child, sbType)) continue;

                total++;

                if (InstanceID(child) == xformId)
                    myIndex = total; // 1-based
            }

            if (myIndex <= 0 || total <= 1) return null;
            return (myIndex, total);
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static bool IsActive(object xform)
        {
            var go = Prop(xform, "gameObject");
            return Prop(go, "activeInHierarchy") is true;
        }

        private static bool HasSB(object xform, Type sbType)
        {
            var go = Prop(xform, "gameObject");
            if (go == null) return false;
            var getComp = go.GetType().GetMethod(
                "GetComponent", Pub, null, new[] { typeof(Type) }, null);
            return getComp?.Invoke(go, new object[] { sbType }) != null;
        }

        private static int InstanceID(object? unityObj)
        {
            if (unityObj == null) return 0;
            var m = unityObj.GetType().GetMethod(
                "GetInstanceID", Pub, null, Type.EmptyTypes, null);
            return m?.Invoke(unityObj, null) is int id ? id : 0;
        }

        private static object? Prop(object? obj, string name) =>
            obj?.GetType().GetProperty(name, Pub)?.GetValue(obj);

        private static int PropInt(object? obj, string name) =>
            Prop(obj, name) is int v ? v : 0;
    }
}
