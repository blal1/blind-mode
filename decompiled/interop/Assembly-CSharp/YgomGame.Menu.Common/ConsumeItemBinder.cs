using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001463")]
public class ConsumeItemBinder : ResourceBinderBase, IItemConsumeBinder
{
	[Serializable]
	[Token(Token = "0x2001464")]
	public class ConsumeItemPathData
	{
		[Token(Token = "0x400C696")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_ConsumeItemPath;

		[Token(Token = "0x6007F07")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ConsumeItemPathData()
		{
		}
	}

	[Token(Token = "0x400C695")]
	[FieldOffset(Offset = "0x10")]
	private ConsumeItemPathData m_Data;

	[Token(Token = "0x6007F01")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(ConsumeItemPathData data)
	{
	}

	[Token(Token = "0x6007F02")]
	[Address(RVA = "0xC73850", Offset = "0xC72A50", VA = "0x180C73850")]
	public string GetIconPath(int consumeId, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007F03")]
	[Address(RVA = "0xC737B0", Offset = "0xC729B0", VA = "0x180C737B0")]
	public BindingImageEx BindIcon(Image target, int consumeId, bool async = true, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007F04")]
	[Address(RVA = "0xC73950", Offset = "0xC72B50", VA = "0x180C73950", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemConsumeBinder_002EBindItem(GameObject target, int consumeId)
	{
		return null;
	}

	[Token(Token = "0x6007F05")]
	[Address(RVA = "0xC738C0", Offset = "0xC72AC0", VA = "0x180C738C0", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemConsumeBinder_002EBindItemLarge(GameObject target, int consumeId)
	{
		return null;
	}

	[Token(Token = "0x6007F06")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ConsumeItemBinder()
	{
	}
}
