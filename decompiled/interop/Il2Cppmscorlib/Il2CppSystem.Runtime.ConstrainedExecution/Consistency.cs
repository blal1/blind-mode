using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.ConstrainedExecution;

[OriginalName("mscorlib.dll", "System.Runtime.ConstrainedExecution", "Consistency")]
public enum Consistency
{
	MayCorruptProcess,
	MayCorruptAppDomain,
	MayCorruptInstance,
	WillNotCorruptState
}
