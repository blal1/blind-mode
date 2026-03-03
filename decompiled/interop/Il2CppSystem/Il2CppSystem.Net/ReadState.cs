using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net;

[OriginalName("System.dll", "System.Net", "ReadState")]
public enum ReadState
{
	None,
	Status,
	Headers,
	Content,
	Aborted
}
