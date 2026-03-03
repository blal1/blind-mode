using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices;

[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "GCHandleType")]
public enum GCHandleType
{
	Weak,
	WeakTrackResurrection,
	Normal,
	Pinned
}
