using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Card;

[Token(Token = "0x2001603")]
[CreateAssetMenu(menuName = "Scriptable Object/CardFinishSetting")]
public class CardFinishSetting : ScriptableObject
{
	[Token(Token = "0x2001604")]
	public enum FinishType
	{
		[Token(Token = "0x400D444")]
		Normal,
		[Token(Token = "0x400D445")]
		Shine,
		[Token(Token = "0x400D446")]
		Royal,
		[Token(Token = "0x400D447")]
		SP1,
		[Token(Token = "0x400D448")]
		SP2,
		[Token(Token = "0x400D449")]
		SP3
	}

	[Serializable]
	[Token(Token = "0x2001605")]
	public struct CardFinishData
	{
		[Token(Token = "0x400D44A")]
		[FieldOffset(Offset = "0x0")]
		public int cardid;

		[Token(Token = "0x400D44B")]
		[FieldOffset(Offset = "0x4")]
		public int finishid;

		[Token(Token = "0x400D44C")]
		[FieldOffset(Offset = "0x8")]
		public FinishType finsihtype;
	}

	[Token(Token = "0x400D440")]
	[FieldOffset(Offset = "0x0")]
	private static CardFinishSetting m_Instance;

	[Token(Token = "0x400D441")]
	private const string PATH = "Card/ScriptableObjects/CardFinishSetting";

	[Token(Token = "0x400D442")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CardFinishData[] cardFinishData;

	[Token(Token = "0x170014FF")]
	protected static CardFinishSetting Instance
	{
		[Token(Token = "0x6008906")]
		[Address(RVA = "0xD45F40", Offset = "0xD45140", VA = "0x180D45F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008907")]
	[Address(RVA = "0xD45E10", Offset = "0xD45010", VA = "0x180D45E10")]
	public static FinishType GetCardFisnishData(int cardid, int finishid)
	{
		return default(FinishType);
	}

	[Token(Token = "0x6008908")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CardFinishSetting()
	{
	}
}
