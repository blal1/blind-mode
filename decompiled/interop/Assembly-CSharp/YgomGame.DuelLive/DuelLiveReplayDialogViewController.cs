using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F17")]
public class DuelLiveReplayDialogViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x400A601")]
	private const string PLAYER_NAME_A = "DUELIST A ";

	[Token(Token = "0x400A602")]
	private const string PLAYER_NAME_B = "DUELIST B ";

	[Token(Token = "0x400A603")]
	[FieldOffset(Offset = "0xD0")]
	private ProductWidget productWidget;

	[Token(Token = "0x400A604")]
	[FieldOffset(Offset = "0xD8")]
	private readonly int pickCardCount;

	[Token(Token = "0x6005B6C")]
	[Address(RVA = "0xA0A4D0", Offset = "0xA096D0", VA = "0x180A0A4D0")]
	public static void Open(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005B6D")]
	[Address(RVA = "0xA093B0", Offset = "0xA085B0", VA = "0x180A093B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005B6E")]
	[Address(RVA = "0xA099C0", Offset = "0xA08BC0", VA = "0x180A099C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005B6F")]
	[Address(RVA = "0xA09500", Offset = "0xA08700", VA = "0x180A09500")]
	private void OnClickDeck(bool isReverse)
	{
	}

	[Token(Token = "0x6005B70")]
	[Address(RVA = "0xA09630", Offset = "0xA08830", VA = "0x180A09630")]
	private void OnClickReplay(bool isReverse)
	{
	}

	[Token(Token = "0x6005B71")]
	[Address(RVA = "0xA0A540", Offset = "0xA09740", VA = "0x180A0A540")]
	public DuelLiveReplayDialogViewController()
	{
	}
}
