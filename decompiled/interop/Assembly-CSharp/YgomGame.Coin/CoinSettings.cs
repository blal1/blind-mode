using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Coin;

[Token(Token = "0x20014AD")]
[CreateAssetMenu(fileName = "CoinSettings", menuName = "Scriptable Objects/CoinSettings")]
public class CoinSettings : ScriptableObject
{
	[Token(Token = "0x20014AE")]
	public enum ColorMaterial
	{
		[Token(Token = "0x400C772")]
		Normal,
		[Token(Token = "0x400C773")]
		silver
	}

	[Serializable]
	[Token(Token = "0x20014AF")]
	public class CoinInfoList
	{
		[Token(Token = "0x400C774")]
		[FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x400C775")]
		[FieldOffset(Offset = "0x14")]
		public int coinId;

		[Token(Token = "0x400C776")]
		[FieldOffset(Offset = "0x18")]
		public ColorMaterial colorMaterial;

		[Token(Token = "0x400C777")]
		[FieldOffset(Offset = "0x1C")]
		public bool ex;

		[Token(Token = "0x6008037")]
		[Address(RVA = "0xC73050", Offset = "0xC72250", VA = "0x180C73050")]
		public CoinInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x6008038")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CoinInfoList()
		{
		}
	}

	[Token(Token = "0x400C770")]
	[FieldOffset(Offset = "0x18")]
	public List<CoinInfoList> coinInfoList;

	[Token(Token = "0x6008035")]
	[Address(RVA = "0xC73200", Offset = "0xC72400", VA = "0x180C73200")]
	public CoinInfoList GetInfoByCoinId(int coinid)
	{
		return null;
	}

	[Token(Token = "0x6008036")]
	[Address(RVA = "0xC73330", Offset = "0xC72530", VA = "0x180C73330")]
	public CoinSettings()
	{
	}
}
