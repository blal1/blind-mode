using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Home.RoomJumpInternal;
using YgomGame.Room;

namespace YgomGame.Home;

[Token(Token = "0x2000D65")]
public class RoomJump
{
	[Token(Token = "0x60050D1")]
	[Address(RVA = "0x978590", Offset = "0x977790", VA = "0x180978590")]
	public static void GotoRoomSelect(RoomEntryViewController.Mode mode, [Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050D2")]
	[Address(RVA = "0x978530", Offset = "0x977730", VA = "0x180978530")]
	public static void GotoCurrentRoom([Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050D3")]
	[Address(RVA = "0x978600", Offset = "0x977800", VA = "0x180978600")]
	private static void execute(RoomJumperBase jumper, [Optional] Action<bool> callback)
	{
	}

	[Token(Token = "0x60050D4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RoomJump()
	{
	}
}
