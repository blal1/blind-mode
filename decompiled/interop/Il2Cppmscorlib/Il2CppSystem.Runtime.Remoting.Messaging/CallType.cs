using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

[OriginalName("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallType")]
public enum CallType
{
	Sync,
	BeginInvoke,
	EndInvoke,
	OneWay
}
