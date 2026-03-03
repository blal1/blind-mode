using System;
using Il2CppDummyDll;

namespace YgomGame.Home.RoomJumpInternal;

[Token(Token = "0x2000D71")]
public class CurrentRoomJumper : RoomJumperBase
{
	[Token(Token = "0x60050EB")]
	[Address(RVA = "0x97E560", Offset = "0x97D760", VA = "0x18097E560", Slot = "4")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050EC")]
	[Address(RVA = "0x97E6C0", Offset = "0x97D8C0", VA = "0x18097E6C0", Slot = "5")]
	public override void Jump()
	{
	}

	[Token(Token = "0x60050ED")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CurrentRoomJumper()
	{
	}
}
