using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Card;

[Token(Token = "0x2001622")]
[CreateAssetMenu(menuName = "Scriptable Object/CardPictureFontSetting")]
public class CardPictureFontSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001623")]
	public struct CardidFontSizePairData
	{
		[Token(Token = "0x400D4E2")]
		[FieldOffset(Offset = "0x0")]
		public short cardid;

		[Token(Token = "0x400D4E3")]
		[FieldOffset(Offset = "0x4")]
		public float fontsize;

		[Token(Token = "0x60089B4")]
		[Address(RVA = "0xD56940", Offset = "0xD55B40", VA = "0x180D56940")]
		public CardidFontSizePairData(short cardid, float fontsize)
		{
		}
	}

	[Token(Token = "0x400D4DF")]
	[FieldOffset(Offset = "0x18")]
	public string language;

	[Token(Token = "0x400D4E0")]
	[FieldOffset(Offset = "0x20")]
	public CardidFontSizePairData[] m_CardidNormalFontSizePairDatas;

	[Token(Token = "0x400D4E1")]
	[FieldOffset(Offset = "0x28")]
	public CardidFontSizePairData[] m_CardidPendulumFontSizePairDatas;

	[Token(Token = "0x60089B3")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CardPictureFontSetting()
	{
	}
}
