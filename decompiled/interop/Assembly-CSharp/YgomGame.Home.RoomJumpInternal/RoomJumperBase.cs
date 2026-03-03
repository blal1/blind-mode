using System;
using Il2CppDummyDll;

namespace YgomGame.Home.RoomJumpInternal;

[Token(Token = "0x2000D6E")]
public abstract class RoomJumperBase
{
	[Token(Token = "0x60050E2")]
	public abstract void Check(Action<bool> resultCallback);

	[Token(Token = "0x60050E3")]
	public abstract void Jump();

	[Token(Token = "0x60050E4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected RoomJumperBase()
	{
	}
}
