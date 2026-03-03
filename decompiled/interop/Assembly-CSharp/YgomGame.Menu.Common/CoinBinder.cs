using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200145D")]
public class CoinBinder : ResourceBinderBase, IItemCoinBinder
{
	[Token(Token = "0x200145E")]
	public enum CoinMode
	{
		[Token(Token = "0x400C67F")]
		None,
		[Token(Token = "0x400C680")]
		Blue,
		[Token(Token = "0x400C681")]
		Red
	}

	[Token(Token = "0x200145F")]
	public enum CoinScale
	{
		[Token(Token = "0x400C683")]
		Large,
		[Token(Token = "0x400C684")]
		Medium,
		[Token(Token = "0x400C685")]
		Small
	}

	[Serializable]
	[Token(Token = "0x2001460")]
	public class CoinPathData
	{
		[Token(Token = "0x400C686")]
		[FieldOffset(Offset = "0x10")]
		public ResourceBindingPathSetting.ItemPathData m_CoinIconPath;

		[Token(Token = "0x400C687")]
		[FieldOffset(Offset = "0x18")]
		public string[] m_CoinMediumMaterials;

		[Token(Token = "0x400C688")]
		[FieldOffset(Offset = "0x20")]
		public string[] m_CoinSmallMaterials;

		[Token(Token = "0x400C689")]
		[FieldOffset(Offset = "0x28")]
		public string m_CoinTailMediumIconPath;

		[Token(Token = "0x400C68A")]
		[FieldOffset(Offset = "0x30")]
		public string m_CoinTailSmallIconPath;

		[Token(Token = "0x400C68B")]
		[FieldOffset(Offset = "0x38")]
		public string m_CoinSmallPath;

		[Token(Token = "0x6007EF1")]
		[Address(RVA = "0xC730D0", Offset = "0xC722D0", VA = "0x180C730D0")]
		public string GetCoinMaterialPath(CoinMode mode, CoinScale scale, bool isHead)
		{
			return null;
		}

		[Token(Token = "0x6007EF2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CoinPathData()
		{
		}
	}

	[Token(Token = "0x400C67D")]
	[FieldOffset(Offset = "0x10")]
	private CoinPathData m_PathData;

	[Token(Token = "0x6007EEB")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(CoinPathData data)
	{
	}

	[Token(Token = "0x6007EEC")]
	[Address(RVA = "0xC72D60", Offset = "0xC71F60", VA = "0x180C72D60")]
	public string GetCoinIconPath(int itemId, CoinScale scale, bool isHead)
	{
		return null;
	}

	[Token(Token = "0x6007EED")]
	[Address(RVA = "0xC72EC0", Offset = "0xC720C0", VA = "0x180C72EC0")]
	public string GetCoinMatPath(CoinMode mode, CoinScale scale, bool isHead)
	{
		return null;
	}

	[Token(Token = "0x6007EEE")]
	[Address(RVA = "0xC73020", Offset = "0xC72220", VA = "0x180C73020", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemCoinBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007EEF")]
	[Address(RVA = "0xC72FF0", Offset = "0xC721F0", VA = "0x180C72FF0", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemCoinBinder_002EBindItemLarge(GameObject target, int itemID)
	{
		return null;
	}

	[Token(Token = "0x6007EF0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CoinBinder()
	{
	}
}
