using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets;

[OriginalName("System.dll", "System.Net.Sockets", "SocketAsyncOperation")]
public enum SocketAsyncOperation
{
	None,
	Accept,
	Connect,
	Disconnect,
	Receive,
	ReceiveFrom,
	ReceiveMessageFrom,
	Send,
	SendPackets,
	SendTo
}
