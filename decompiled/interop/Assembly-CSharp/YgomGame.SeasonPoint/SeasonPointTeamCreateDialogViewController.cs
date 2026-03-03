using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A36")]
public class SeasonPointTeamCreateDialogViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x2000A37")]
	private class TeamMeberData
	{
		[Token(Token = "0x40090A2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40090A3")]
		[FieldOffset(Offset = "0x18")]
		public string onlineId;

		[Token(Token = "0x40090A4")]
		[FieldOffset(Offset = "0x20")]
		public bool isSameOs;

		[Token(Token = "0x40090A5")]
		[FieldOffset(Offset = "0x28")]
		public long pcode;

		[Token(Token = "0x6003E9F")]
		[Address(RVA = "0x87A270", Offset = "0x879470", VA = "0x18087A270")]
		public TeamMeberData(string name, string onlineId, bool isSameOs, long pcode)
		{
		}
	}

	[Token(Token = "0x4009095")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string L_TextArea;

	[Token(Token = "0x4009096")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string L_ScrollText;

	[Token(Token = "0x4009097")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string L_PlayerBoard;

	[Token(Token = "0x4009098")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string L_HeaderText;

	[Token(Token = "0x4009099")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string L_ButtonGroup;

	[Token(Token = "0x400909A")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string L_ButtonCancel;

	[Token(Token = "0x400909B")]
	[FieldOffset(Offset = "0x100")]
	private readonly string L_ButtonPositive;

	[Token(Token = "0x400909C")]
	[FieldOffset(Offset = "0x108")]
	private readonly string L_PlatformPlayerNameGroup;

	[Token(Token = "0x400909D")]
	[FieldOffset(Offset = "0x110")]
	private readonly string L_PlayerNameGroup;

	[Token(Token = "0x400909E")]
	[FieldOffset(Offset = "0x118")]
	private Dictionary<int, TeamMemberData> teamMemberDatas;

	[Token(Token = "0x400909F")]
	[FieldOffset(Offset = "0x120")]
	private int regionIdx;

	[Token(Token = "0x40090A0")]
	[FieldOffset(Offset = "0x128")]
	private List<PlayerWidget> playerWidgets;

	[Token(Token = "0x40090A1")]
	[FieldOffset(Offset = "0x0")]
	private static ViewControllerManager swapVC;

	[Token(Token = "0x6003E95")]
	[Address(RVA = "0x86BCD0", Offset = "0x86AED0", VA = "0x18086BCD0")]
	public static void Open(ViewControllerManager vc, Dictionary<string, object> Args)
	{
	}

	[Token(Token = "0x6003E96")]
	[Address(RVA = "0x86B290", Offset = "0x86A490", VA = "0x18086B290", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003E97")]
	[Address(RVA = "0x86B450", Offset = "0x86A650", VA = "0x18086B450", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003E98")]
	[Address(RVA = "0x86B180", Offset = "0x86A380", VA = "0x18086B180")]
	private void OnClickOKBtn()
	{
	}

	[Token(Token = "0x6003E99")]
	[Address(RVA = "0x86B180", Offset = "0x86A380", VA = "0x18086B180")]
	private void CallAPITeamCreate()
	{
	}

	[Token(Token = "0x6003E9A")]
	[Address(RVA = "0x86BEB0", Offset = "0x86B0B0", VA = "0x18086BEB0")]
	public SeasonPointTeamCreateDialogViewController()
	{
	}
}
