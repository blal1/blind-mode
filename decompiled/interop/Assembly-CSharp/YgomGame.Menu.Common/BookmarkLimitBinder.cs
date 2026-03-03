using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001456")]
public class BookmarkLimitBinder : ResourceBinderBase, IItemBookmarkLimitBinder
{
	[Serializable]
	[Token(Token = "0x2001457")]
	public class BookmarkPathData
	{
		[Token(Token = "0x400C673")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_BookmarkLimitPath;

		[Token(Token = "0x6007ED4")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BookmarkPathData()
		{
		}
	}

	[Token(Token = "0x400C672")]
	[FieldOffset(Offset = "0x10")]
	private BookmarkPathData m_Data;

	[Token(Token = "0x6007ED0")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(BookmarkPathData data)
	{
	}

	[Token(Token = "0x6007ED1")]
	[Address(RVA = "0xC707E0", Offset = "0xC6F9E0", VA = "0x180C707E0", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemBookmarkLimitBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007ED2")]
	[Address(RVA = "0xC70720", Offset = "0xC6F920", VA = "0x180C70720", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemBookmarkLimitBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007ED3")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BookmarkLimitBinder()
	{
	}
}
