using System;

namespace UnityEngine.Accessibility;

[Flags]
public enum AccessibilityState : ushort
{
	None = 0,
	Disabled = 1,
	Selected = 2
}
