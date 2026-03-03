using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Room;

namespace YgomGame.Home.RoomJumpInternal;

[Token(Token = "0x2000D6F")]
public class RoomSelectJumper : RoomJumperBase
{
	[Token(Token = "0x17000BAA")]
	protected RoomEntryViewController.Mode mode
	{
		[Token(Token = "0x60050E5")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(RoomEntryViewController.Mode);
		}
	}

	[Token(Token = "0x60050E6")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public RoomSelectJumper(RoomEntryViewController.Mode mode)
	{
	}

	[Token(Token = "0x60050E7")]
	[Address(RVA = "0x995ED0", Offset = "0x9950D0", VA = "0x180995ED0", Slot = "4")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050E8")]
	[Address(RVA = "0x996030", Offset = "0x995230", VA = "0x180996030", Slot = "5")]
	public override void Jump()
	{
	}
}
