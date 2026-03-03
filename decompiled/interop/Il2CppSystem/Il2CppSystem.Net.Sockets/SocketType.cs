using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets;

[OriginalName("System.dll", "System.Net.Sockets", "SocketType")]
public enum SocketType
{
	Stream = 1,
	Dgram = 2,
	Raw = 3,
	Rdm = 4,
	Seqpacket = 5,
	Unknown = -1
}
