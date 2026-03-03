using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Duel;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x2001379")]
public class ReplayUtil
{
	[Token(Token = "0x400C1FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool lastIsOpenCache;

	[Token(Token = "0x400C1FB")]
	private const string KEY_IS_REPLAY_OPEN = "IsReplayOpen";

	[Token(Token = "0x60078EF")]
	[Address(RVA = "0xC21000", Offset = "0xC20200", VA = "0x180C21000")]
	public static void GoToReplayList(ViewControllerManager manager, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60078F0")]
	[Address(RVA = "0xC21590", Offset = "0xC20790", VA = "0x180C21590")]
	public static void OpenSaveReplayDialog(Util.GameMode mode, long did, int eventID, [Optional] SelectionButton button)
	{
	}

	[Token(Token = "0x60078F1")]
	[Address(RVA = "0xC21060", Offset = "0xC20260", VA = "0x180C21060")]
	private static void HandleSaveReplayResponse(Handle response, bool? isPublic, SelectionButton button)
	{
	}

	[Token(Token = "0x60078F2")]
	[Address(RVA = "0xC21480", Offset = "0xC20680", VA = "0x180C21480")]
	private static void LocalSaveIsOpen(bool isOpen)
	{
	}

	[Token(Token = "0x60078F3")]
	[Address(RVA = "0xC212A0", Offset = "0xC204A0", VA = "0x180C212A0")]
	private static bool LocalLoadIsOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x60078F4")]
	[Address(RVA = "0xC21290", Offset = "0xC20490", VA = "0x180C21290")]
	public static bool IsFace(int id, int choice)
	{
		return default(bool);
	}

	[Token(Token = "0x60078F5")]
	[Address(RVA = "0xC21290", Offset = "0xC20490", VA = "0x180C21290")]
	public static bool IsFirstPlayer(int id, int first_player)
	{
		return default(bool);
	}

	[Token(Token = "0x60078F6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ReplayUtil()
	{
	}
}
