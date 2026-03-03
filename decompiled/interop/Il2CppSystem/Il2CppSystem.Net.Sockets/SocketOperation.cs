using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets;

[OriginalName("System.dll", "System.Net.Sockets", "SocketOperation")]
public enum SocketOperation
{
	Accept,
	Connect,
	Receive,
	ReceiveFrom,
	Send,
	SendTo,
	RecvJustCallback,
	SendJustCallback,
	Disconnect,
	AcceptReceive,
	ReceiveGeneric,
	SendGeneric
}
