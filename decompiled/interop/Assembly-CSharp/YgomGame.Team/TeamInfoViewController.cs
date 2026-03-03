using System;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x2001651")]
public class TeamInfoViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400D5D1")]
	private const string VC_PATH = "Team/TeamInfo";

	[Token(Token = "0x400D5D2")]
	[FieldOffset(Offset = "0xD0")]
	private SelectionButton _copyBtn;

	[Token(Token = "0x400D5D3")]
	[FieldOffset(Offset = "0xD8")]
	private int _joiningNum;

	[Token(Token = "0x400D5D4")]
	[FieldOffset(Offset = "0xDC")]
	private int _joiningMax;

	[Token(Token = "0x400D5D5")]
	[FieldOffset(Offset = "0xE0")]
	private int _teamId;

	[Token(Token = "0x400D5D6")]
	[FieldOffset(Offset = "0xE8")]
	private string _regulationSetName;

	[Token(Token = "0x400D5D7")]
	[FieldOffset(Offset = "0xF0")]
	private string[] _regulationNames;

	[Token(Token = "0x400D5D8")]
	[FieldOffset(Offset = "0xF8")]
	private int _mrk;

	[Token(Token = "0x17001535")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008ADD")]
		[Address(RVA = "0xD63550", Offset = "0xD62750", VA = "0x180D63550", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008ADE")]
	[Address(RVA = "0xD634C0", Offset = "0xD626C0", VA = "0x180D634C0")]
	public static void Open(ViewControllerManager manager)
	{
	}

	[Token(Token = "0x6008ADF")]
	[Address(RVA = "0xD62E70", Offset = "0xD62070", VA = "0x180D62E70", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008AE0")]
	[Address(RVA = "0xD62960", Offset = "0xD61B60", VA = "0x180D62960")]
	private void LoadData()
	{
	}

	[Token(Token = "0x6008AE1")]
	[Address(RVA = "0xD62EA0", Offset = "0xD620A0", VA = "0x180D62EA0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008AE2")]
	[Address(RVA = "0xD63510", Offset = "0xD62710", VA = "0x180D63510")]
	public TeamInfoViewController()
	{
	}
}
