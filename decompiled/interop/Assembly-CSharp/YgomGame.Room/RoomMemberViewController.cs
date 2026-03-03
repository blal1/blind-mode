using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room;

[Token(Token = "0x2000B00")]
public class RoomMemberViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000B01")]
	internal class Data
	{
		[Token(Token = "0x40094F1")]
		[FieldOffset(Offset = "0x10")]
		internal long pcode;

		[Token(Token = "0x40094F2")]
		[FieldOffset(Offset = "0x18")]
		internal string name;

		[Token(Token = "0x40094F3")]
		[FieldOffset(Offset = "0x20")]
		internal int win;

		[Token(Token = "0x40094F4")]
		[FieldOffset(Offset = "0x24")]
		internal int lose;

		[Token(Token = "0x40094F5")]
		[FieldOffset(Offset = "0x28")]
		internal int draw;

		[Token(Token = "0x40094F6")]
		[FieldOffset(Offset = "0x2C")]
		internal int iconID;

		[Token(Token = "0x40094F7")]
		[FieldOffset(Offset = "0x30")]
		internal int iconFrameID;

		[Token(Token = "0x40094F8")]
		[FieldOffset(Offset = "0x34")]
		internal bool isResistedPlatform;

		[Token(Token = "0x40094F9")]
		[FieldOffset(Offset = "0x35")]
		internal bool isSamePlatform;

		[Token(Token = "0x40094FA")]
		[FieldOffset(Offset = "0x38")]
		internal string platformName;

		[Token(Token = "0x60043AE")]
		[Address(RVA = "0x8C88B0", Offset = "0x8C7AB0", VA = "0x1808C88B0")]
		public Data(long pcode, string name, int win, int lose, int draw, int iconID, int iconFrameID, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
		{
		}
	}

	[Token(Token = "0x40094E6")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40094E7")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TXT_WIN_NUM_LABEL;

	[Token(Token = "0x40094E8")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TXT_LOSE_NUM_LABEL;

	[Token(Token = "0x40094E9")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TXT_DRAW_NUM_LABEL;

	[Token(Token = "0x40094EA")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x40094EB")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x40094EC")]
	[FieldOffset(Offset = "0x100")]
	private readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x40094ED")]
	[FieldOffset(Offset = "0x108")]
	private InfinityScrollView isv;

	[Token(Token = "0x40094EE")]
	[FieldOffset(Offset = "0x110")]
	private List<Data> dataList;

	[Token(Token = "0x40094EF")]
	[FieldOffset(Offset = "0x118")]
	private float pastSec;

	[Token(Token = "0x40094F0")]
	[FieldOffset(Offset = "0x11C")]
	private bool isCallingAPI;

	[Token(Token = "0x17000908")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x8D6DE0", Offset = "0x8D5FE0", VA = "0x1808D6DE0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60043A3")]
	[Address(RVA = "0x8D6AE0", Offset = "0x8D5CE0", VA = "0x1808D6AE0")]
	private void Update()
	{
	}

	[Token(Token = "0x60043A4")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60043A5")]
	[Address(RVA = "0x8D5D60", Offset = "0x8D4F60", VA = "0x1808D5D60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60043A6")]
	[Address(RVA = "0x8D6750", Offset = "0x8D5950", VA = "0x1808D6750")]
	private void UpdateEntity(GameObject gob, int index)
	{
	}

	[Token(Token = "0x60043A7")]
	[Address(RVA = "0x8D5EE0", Offset = "0x8D50E0", VA = "0x1808D5EE0")]
	private void SetData()
	{
	}

	[Token(Token = "0x60043A8")]
	[Address(RVA = "0x8D5CD0", Offset = "0x8D4ED0", VA = "0x1808D5CD0")]
	private void CallAPIRoomTablePoling()
	{
	}

	[Token(Token = "0x60043A9")]
	[Address(RVA = "0x8D5EC0", Offset = "0x8D50C0", VA = "0x1808D5EC0")]
	private void OnErrorCallAPI(RoomCode roomCode)
	{
	}

	[Token(Token = "0x60043AA")]
	[Address(RVA = "0x8D6C70", Offset = "0x8D5E70", VA = "0x1808D6C70")]
	public RoomMemberViewController()
	{
	}
}
