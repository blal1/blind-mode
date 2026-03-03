using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001458")]
public class CardFileBinder : ResourceBinderBase, IItemCardFileBinder
{
	[Token(Token = "0x2001459")]
	public enum CardFileType
	{
		[Token(Token = "0x400C676")]
		Icon,
		[Token(Token = "0x400C677")]
		Thumb
	}

	[Serializable]
	[Token(Token = "0x200145A")]
	public class CardFilePathData
	{
		[Token(Token = "0x400C678")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_Icon;

		[Token(Token = "0x400C679")]
		[FieldOffset(Offset = "0x18")]
		public string m_Thumb;

		[Token(Token = "0x400C67A")]
		[FieldOffset(Offset = "0x20")]
		public string m_ThumbMat;

		[Token(Token = "0x6007EDF")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CardFilePathData()
		{
		}
	}

	[Token(Token = "0x400C674")]
	[FieldOffset(Offset = "0x10")]
	private CardFilePathData m_PathData;

	[Token(Token = "0x6007ED5")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(CardFilePathData data)
	{
	}

	[Token(Token = "0x6007ED6")]
	[Address(RVA = "0xC70BD0", Offset = "0xC6FDD0", VA = "0x180C70BD0")]
	public string GetCardFilePath(CardFileType cardFileType, int itemId, int completeStatus, bool isLarge)
	{
		return null;
	}

	[Token(Token = "0x6007ED7")]
	[Address(RVA = "0xC70B10", Offset = "0xC6FD10", VA = "0x180C70B10")]
	public string GetCardFileMatPath(CardFileType cardFileType, int itemId, int completeStatus, bool isLarge)
	{
		return null;
	}

	[Token(Token = "0x6007ED8")]
	[Address(RVA = "0xC70DE0", Offset = "0xC6FFE0", VA = "0x180C70DE0")]
	private string TryGetThumbMatPath(int itemId, int completeStatus)
	{
		return null;
	}

	[Token(Token = "0x6007ED9")]
	[Address(RVA = "0xC70C90", Offset = "0xC6FE90", VA = "0x180C70C90")]
	private string GetIconPath(int itemId, int completeStatus, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007EDA")]
	[Address(RVA = "0xC70D30", Offset = "0xC6FF30", VA = "0x180C70D30")]
	private string GetThumbPath(int itemId, int completeStatus)
	{
		return null;
	}

	[Token(Token = "0x6007EDB")]
	[Address(RVA = "0xC70DC0", Offset = "0xC6FFC0", VA = "0x180C70DC0")]
	private int ItemIdToResourceId(int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x6007EDC")]
	[Address(RVA = "0xC70EB0", Offset = "0xC700B0", VA = "0x180C70EB0", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemCardFileBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007EDD")]
	[Address(RVA = "0xC70E80", Offset = "0xC70080", VA = "0x180C70E80", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemCardFileBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007EDE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardFileBinder()
	{
	}
}
