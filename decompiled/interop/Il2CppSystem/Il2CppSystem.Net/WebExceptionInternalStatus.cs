using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net;

[OriginalName("System.dll", "System.Net", "WebExceptionInternalStatus")]
public enum WebExceptionInternalStatus
{
	RequestFatal,
	ServicePointFatal,
	Recoverable,
	Isolated
}
