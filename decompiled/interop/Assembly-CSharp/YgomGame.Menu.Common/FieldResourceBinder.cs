using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200146A")]
public class FieldResourceBinder : ResourceBinderBase, IItemFieldBinder, IItemFieldObjBinder, IItemAvatarHomeBinder
{
	[Serializable]
	[Token(Token = "0x200146B")]
	public class FieldPathData
	{
		[Token(Token = "0x400C6A7")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_FieldIconPath;

		[Token(Token = "0x400C6A8")]
		[FieldOffset(Offset = "0x18")]
		public ResourceBindingPathSetting.ItemPathData m_FieldObjIconPath;

		[Token(Token = "0x400C6A9")]
		[FieldOffset(Offset = "0x20")]
		public ResourceBindingPathSetting.ItemPathData m_AvatarBaseIconPath;

		[Token(Token = "0x6007F4B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public FieldPathData()
		{
		}
	}

	[Token(Token = "0x400C6A6")]
	[FieldOffset(Offset = "0x10")]
	private FieldPathData m_PathData;

	[Token(Token = "0x6007F37")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(FieldPathData pathData)
	{
	}

	[Token(Token = "0x6007F38")]
	[Address(RVA = "0xC75E60", Offset = "0xC75060", VA = "0x180C75E60")]
	public string GetFieldIconPath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007F39")]
	[Address(RVA = "0xC75B80", Offset = "0xC74D80", VA = "0x180C75B80")]
	public BindingImageEx BindFieldIcon(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F3A")]
	[Address(RVA = "0xC75F30", Offset = "0xC75130", VA = "0x180C75F30")]
	public string GetFieldLargePath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007F3B")]
	[Address(RVA = "0xC75BD0", Offset = "0xC74DD0", VA = "0x180C75BD0")]
	public BindingImageEx BindFieldLarge(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F3C")]
	[Address(RVA = "0xC76000", Offset = "0xC75200", VA = "0x180C76000")]
	public string GetFieldObjIconPath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007F3D")]
	[Address(RVA = "0xC75C70", Offset = "0xC74E70", VA = "0x180C75C70")]
	public BindingImageEx BindFieldObjIcon(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F3E")]
	[Address(RVA = "0xC760D0", Offset = "0xC752D0", VA = "0x180C760D0")]
	public string GetFieldObjLargePath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007F3F")]
	[Address(RVA = "0xC75C20", Offset = "0xC74E20", VA = "0x180C75C20")]
	public BindingImageEx BindFieldObjIconLarge(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F40")]
	[Address(RVA = "0xC75D90", Offset = "0xC74F90", VA = "0x180C75D90")]
	public string GetFieldAvatarBaseIconPath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007F41")]
	[Address(RVA = "0xC75B30", Offset = "0xC74D30", VA = "0x180C75B30")]
	public BindingImageEx BindFieldAvatarBaseIcon(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F42")]
	[Address(RVA = "0xC75CC0", Offset = "0xC74EC0", VA = "0x180C75CC0")]
	public string GetFieldAvatarBaseIconLargePath(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007F43")]
	[Address(RVA = "0xC75AE0", Offset = "0xC74CE0", VA = "0x180C75AE0")]
	public BindingImageEx BindFieldAvatarBaseIconLarge(Image target, int itemId, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007F44")]
	[Address(RVA = "0xC76230", Offset = "0xC75430", VA = "0x180C76230", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemFieldBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F45")]
	[Address(RVA = "0xC76290", Offset = "0xC75490", VA = "0x180C76290", Slot = "6")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemFieldObjBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F46")]
	[Address(RVA = "0xC761D0", Offset = "0xC753D0", VA = "0x180C761D0", Slot = "8")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemAvatarHomeBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F47")]
	[Address(RVA = "0xC76200", Offset = "0xC75400", VA = "0x180C76200", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemFieldBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F48")]
	[Address(RVA = "0xC76260", Offset = "0xC75460", VA = "0x180C76260", Slot = "7")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemFieldObjBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F49")]
	[Address(RVA = "0xC761A0", Offset = "0xC753A0", VA = "0x180C761A0", Slot = "9")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemAvatarHomeBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007F4A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public FieldResourceBinder()
	{
	}
}
