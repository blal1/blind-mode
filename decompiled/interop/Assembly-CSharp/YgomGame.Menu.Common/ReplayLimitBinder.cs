using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200149B")]
public class ReplayLimitBinder : ResourceBinderBase, IItemReplayLimitBinder
{
	[Serializable]
	[Token(Token = "0x200149C")]
	public class ReplayPathData
	{
		[Token(Token = "0x400C706")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_ReplayLimitPath;

		[Token(Token = "0x6007FE2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ReplayPathData()
		{
		}
	}

	[Token(Token = "0x400C705")]
	[FieldOffset(Offset = "0x10")]
	private ReplayPathData m_Data;

	[Token(Token = "0x6007FDE")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(ReplayPathData data)
	{
	}

	[Token(Token = "0x6007FDF")]
	[Address(RVA = "0xC707E0", Offset = "0xC6F9E0", VA = "0x180C707E0", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemReplayLimitBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007FE0")]
	[Address(RVA = "0xC70720", Offset = "0xC6F920", VA = "0x180C70720", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemReplayLimitBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007FE1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ReplayLimitBinder()
	{
	}
}
