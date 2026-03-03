using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.Room;

[Token(Token = "0x2000AF9")]
public class RoomInfoViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000AFA")]
	private class Data
	{
		[Token(Token = "0x40094CB")]
		[FieldOffset(Offset = "0x10")]
		internal string label;

		[Token(Token = "0x40094CC")]
		[FieldOffset(Offset = "0x18")]
		internal string value;

		[Token(Token = "0x6004381")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public Data(string label, string value)
		{
		}
	}

	[Token(Token = "0x40094A0")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string BTN_ROOM_COPY_LABEL;

	[Token(Token = "0x40094A1")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_SPECTOR_COPY_LABEL;

	[Token(Token = "0x40094A2")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TXT_TITLE_LABEL;

	[Token(Token = "0x40094A3")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TXT_ROOM_LABEL;

	[Token(Token = "0x40094A4")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string TXT_ROOM_MEMBER_LABEL;

	[Token(Token = "0x40094A5")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string TXT_SPECTOR_LABEL;

	[Token(Token = "0x40094A6")]
	[FieldOffset(Offset = "0x100")]
	private readonly string TXT_SPECTOR_MEMBER_LABEL;

	[Token(Token = "0x40094A7")]
	[FieldOffset(Offset = "0x108")]
	private readonly string TXT_ITEM_LABEL;

	[Token(Token = "0x40094A8")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TXT_VALUE_LABEL;

	[Token(Token = "0x40094A9")]
	[FieldOffset(Offset = "0x118")]
	private readonly string ROOT_NORMAL_LABEL;

	[Token(Token = "0x40094AA")]
	[FieldOffset(Offset = "0x120")]
	private readonly string ROOT_SPECTOR_LABEL;

	[Token(Token = "0x40094AB")]
	[FieldOffset(Offset = "0x128")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40094AC")]
	[FieldOffset(Offset = "0x130")]
	private readonly string IMG_LINE_LABEL;

	[Token(Token = "0x40094AD")]
	[FieldOffset(Offset = "0x138")]
	private readonly string TXT_REGULATION_LABEL;

	[Token(Token = "0x40094AE")]
	[FieldOffset(Offset = "0x140")]
	private readonly string ICON_REGULATION_LABEL;

	[Token(Token = "0x40094AF")]
	[FieldOffset(Offset = "0x148")]
	private readonly string TXT_ROOM_DEADLINE;

	[Token(Token = "0x40094B0")]
	private const string KEY_ENTRY_MODE = "EntryMode";

	[Token(Token = "0x40094B1")]
	private const string KEY_ROOM_NAME = "RoomName";

	[Token(Token = "0x40094B2")]
	private const string KEY_ROOM_ID = "RoomID";

	[Token(Token = "0x40094B3")]
	private const string KEY_SPECTOR_ID = "SpectorID";

	[Token(Token = "0x40094B4")]
	private const string KEY_ROOM_MEMBER_CURRENT = "RoomMemberCurrent";

	[Token(Token = "0x40094B5")]
	private const string KEY_SPECTOR_MEMBER_CURRENT = "RoomSpectorCurrent";

	[Token(Token = "0x40094B6")]
	private const string KEY_ROOM_MEMBER_MAX = "RoomMemberMax";

	[Token(Token = "0x40094B7")]
	private const string KEY_PUBLIC = "IsPublic";

	[Token(Token = "0x40094B8")]
	private const string KEY_SPECTRAL = "IsSpectral";

	[Token(Token = "0x40094B9")]
	private const string KEY_SPECTER = "IsSpecter";

	[Token(Token = "0x40094BA")]
	private const string KEY_ROOM_COMMENT = "RoomComment";

	[Token(Token = "0x40094BB")]
	private const string KEY_BATTLE_TIME_ID = "BattleTimeId";

	[Token(Token = "0x40094BC")]
	private const string KEY_BATTLE_LP = "BattleLP";

	[Token(Token = "0x40094BD")]
	private const string KEY_REPLAY = "IsReplay";

	[Token(Token = "0x40094BE")]
	private const string KEY_REGNAME = "RegName";

	[Token(Token = "0x40094BF")]
	private const string KEY_REGID = "RegID";

	[Token(Token = "0x40094C0")]
	[FieldOffset(Offset = "0x150")]
	private List<Data> roomSettings;

	[Token(Token = "0x40094C1")]
	[FieldOffset(Offset = "0x158")]
	private RoomEntryViewController.Mode mode;

	[Token(Token = "0x40094C2")]
	[FieldOffset(Offset = "0x160")]
	private string roomName;

	[Token(Token = "0x40094C3")]
	[FieldOffset(Offset = "0x168")]
	private int roomID;

	[Token(Token = "0x40094C4")]
	[FieldOffset(Offset = "0x16C")]
	private int roomMemberCurrent;

	[Token(Token = "0x40094C5")]
	[FieldOffset(Offset = "0x170")]
	private int roomMemberMax;

	[Token(Token = "0x40094C6")]
	[FieldOffset(Offset = "0x174")]
	private int spectorID;

	[Token(Token = "0x40094C7")]
	[FieldOffset(Offset = "0x178")]
	private int spectorMemberCurrent;

	[Token(Token = "0x40094C8")]
	[FieldOffset(Offset = "0x180")]
	private string regulationName;

	[Token(Token = "0x40094C9")]
	[FieldOffset(Offset = "0x188")]
	private int regulationID;

	[Token(Token = "0x40094CA")]
	[FieldOffset(Offset = "0x190")]
	private string roomDeadlineDate;

	[Token(Token = "0x17000906")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x8D3F00", Offset = "0x8D3100", VA = "0x1808D3F00", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600437D")]
	[Address(RVA = "0x8D22F0", Offset = "0x8D14F0", VA = "0x1808D22F0")]
	public static Dictionary<string, object> GetArgs(RoomEntryViewController.Mode mode, string roomName, int roomID, int roomMemberCurrent, int roomMemberMax, string isPublic, string isSpectral, string isSpecter, string roomComment, int battleTimeId, string battleLP, string isReplay, int spectorID, int spectorMemberCurrent, int regulationID, string regulationName)
	{
		return null;
	}

	[Token(Token = "0x600437E")]
	[Address(RVA = "0x8D26E0", Offset = "0x8D18E0", VA = "0x1808D26E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600437F")]
	[Address(RVA = "0x8D3350", Offset = "0x8D2550", VA = "0x1808D3350", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004380")]
	[Address(RVA = "0x8D3B80", Offset = "0x8D2D80", VA = "0x1808D3B80")]
	public RoomInfoViewController()
	{
	}
}
