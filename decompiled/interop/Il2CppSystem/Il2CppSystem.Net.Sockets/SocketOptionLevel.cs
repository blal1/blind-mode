using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets;

[OriginalName("System.dll", "System.Net.Sockets", "SocketOptionLevel")]
public enum SocketOptionLevel
{
	Socket = 65535,
	IP = 0,
	IPv6 = 41,
	Tcp = 6,
	Udp = 17
}
