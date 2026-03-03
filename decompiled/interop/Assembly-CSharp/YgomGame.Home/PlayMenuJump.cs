using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Home.PlayMenuJumpInternal;

namespace YgomGame.Home;

[Token(Token = "0x2000D63")]
public class PlayMenuJump
{
	[Token(Token = "0x60050C3")]
	[Address(RVA = "0x977EA0", Offset = "0x9770A0", VA = "0x180977EA0")]
	public static void GotoStandardMenu([Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050C4")]
	[Address(RVA = "0x977DE0", Offset = "0x976FE0", VA = "0x180977DE0")]
	public static void GotoRateMenu([Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050C5")]
	[Address(RVA = "0x977D00", Offset = "0x976F00", VA = "0x180977D00")]
	public static void GotoExhibitionMenu(int id, [Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050C6")]
	[Address(RVA = "0x977F00", Offset = "0x977100", VA = "0x180977F00")]
	public static void GotoVersusMenu(int id, [Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050C7")]
	[Address(RVA = "0x977CA0", Offset = "0x976EA0", VA = "0x180977CA0")]
	public static void GotoDuelistCupMenu([Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050C8")]
	[Address(RVA = "0x977F70", Offset = "0x977170", VA = "0x180977F70")]
	public static void GotoWCSMenu([Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050C9")]
	[Address(RVA = "0x977C30", Offset = "0x976E30", VA = "0x180977C30")]
	public static void GotoDuelTrialMenu(int id, [Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050CA")]
	[Address(RVA = "0x977D70", Offset = "0x976F70", VA = "0x180977D70")]
	public static void GotoRankEventMenu(int id, [Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050CB")]
	[Address(RVA = "0x977E40", Offset = "0x977040", VA = "0x180977E40")]
	public static void GotoRdcMenu([Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050CC")]
	[Address(RVA = "0x977BC0", Offset = "0x976DC0", VA = "0x180977BC0")]
	public static void GotoDiceRallyMenu(int id, [Optional] Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x60050CD")]
	[Address(RVA = "0x977FD0", Offset = "0x9771D0", VA = "0x180977FD0")]
	private static void execute(PlayMenuJumperBase jumper, [Optional] Action<bool> onCheckedCallback, [Optional] Action onNgMultiPlayCallback)
	{
	}

	[Token(Token = "0x60050CE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PlayMenuJump()
	{
	}
}
