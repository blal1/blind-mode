using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x2001302")]
public class PresentBoxViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001303")]
	internal class Data
	{
		[Token(Token = "0x400BEBE")]
		[FieldOffset(Offset = "0x10")]
		internal int pID;

		[Token(Token = "0x400BEBF")]
		[FieldOffset(Offset = "0x14")]
		internal int itemCategory;

		[Token(Token = "0x400BEC0")]
		[FieldOffset(Offset = "0x18")]
		internal int itemID;

		[Token(Token = "0x400BEC1")]
		[FieldOffset(Offset = "0x1C")]
		internal int quantity;

		[Token(Token = "0x400BEC2")]
		[FieldOffset(Offset = "0x20")]
		internal string message;

		[Token(Token = "0x400BEC3")]
		[FieldOffset(Offset = "0x28")]
		internal string limitDate;

		[Token(Token = "0x400BEC4")]
		[FieldOffset(Offset = "0x30")]
		internal bool isPeriod;

		[Token(Token = "0x6007619")]
		[Address(RVA = "0xBBA320", Offset = "0xBB9520", VA = "0x180BBA320")]
		public Data(int pID, int itemCategory, int itemID, int quantity, string message, string limitDate, bool isPeriod)
		{
		}
	}

	[Token(Token = "0x400BEB4")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400BEB5")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TXT_EMPTY_LABEL;

	[Token(Token = "0x400BEB6")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TXT_MESSAGE_LABEL;

	[Token(Token = "0x400BEB7")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TXT_NAME_LABEL;

	[Token(Token = "0x400BEB8")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BTN_ALL_LABEL;

	[Token(Token = "0x400BEB9")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x400BEBA")]
	[FieldOffset(Offset = "0x100")]
	private readonly string TXT_DATE_LABEL;

	[Token(Token = "0x400BEBB")]
	[FieldOffset(Offset = "0x108")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400BEBC")]
	[FieldOffset(Offset = "0x110")]
	private InfinityScrollView infinityScroll;

	[Token(Token = "0x400BEBD")]
	[FieldOffset(Offset = "0x118")]
	private List<Data> dataList;

	[Token(Token = "0x1700126F")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600760C")]
		[Address(RVA = "0xBC73A0", Offset = "0xBC65A0", VA = "0x180BC73A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600760D")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600760E")]
	[Address(RVA = "0xBC5DA0", Offset = "0xBC4FA0", VA = "0x180BC5DA0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600760F")]
	[Address(RVA = "0xBC5D00", Offset = "0xBC4F00", VA = "0x180BC5D00")]
	private void CallAPIPresentBoxReceive(int presentBoxID, int isAll)
	{
	}

	[Token(Token = "0x6007610")]
	[Address(RVA = "0xBC6330", Offset = "0xBC5530", VA = "0x180BC6330")]
	private string SetDialogMessage(string beforeStr, string addStr)
	{
		return null;
	}

	[Token(Token = "0x6007611")]
	[Address(RVA = "0xBC69D0", Offset = "0xBC5BD0", VA = "0x180BC69D0")]
	private void UpdateData()
	{
	}

	[Token(Token = "0x6007612")]
	[Address(RVA = "0xBC7140", Offset = "0xBC6340", VA = "0x180BC7140")]
	private void UpdateScrollDataCount(int count)
	{
	}

	[Token(Token = "0x6007613")]
	[Address(RVA = "0xBC5FA0", Offset = "0xBC51A0", VA = "0x180BC5FA0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6007614")]
	[Address(RVA = "0xBC7210", Offset = "0xBC6410", VA = "0x180BC7210")]
	public PresentBoxViewController()
	{
	}
}
