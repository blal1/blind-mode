using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices;

[System.Serializable]
[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "ComInterfaceType")]
public enum ComInterfaceType
{
	InterfaceIsDual,
	InterfaceIsIUnknown,
	InterfaceIsIDispatch,
	InterfaceIsIInspectable
}
