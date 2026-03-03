using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Deck;

[Token(Token = "0x20010A4")]
public class DeckCard : DeckEditCard
{
	[Token(Token = "0x20010A5")]
	public enum LocationInDeck
	{
		[Token(Token = "0x400B0FE")]
		NA,
		[Token(Token = "0x400B0FF")]
		M,
		[Token(Token = "0x400B100")]
		E,
		[Token(Token = "0x400B101")]
		S,
		[Token(Token = "0x400B102")]
		T,
		[Token(Token = "0x400B103")]
		D,
		[Token(Token = "0x400B104")]
		L
	}

	[Token(Token = "0x170010A2")]
	public LocationInDeck m_Location
	{
		[Token(Token = "0x6006713")]
		[Address(RVA = "0xABEAC0", Offset = "0xABDCC0", VA = "0x180ABEAC0")]
		[CompilerGenerated]
		get
		{
			return default(LocationInDeck);
		}
		[Token(Token = "0x6006714")]
		[Address(RVA = "0xABEAD0", Offset = "0xABDCD0", VA = "0x180ABEAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6006715")]
	[Address(RVA = "0xABE7A0", Offset = "0xABD9A0", VA = "0x180ABE7A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006716")]
	[Address(RVA = "0xABEA60", Offset = "0xABDC60", VA = "0x180ABEA60")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6006717")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x6006718")]
	[Address(RVA = "0xABE9A0", Offset = "0xABDBA0", VA = "0x180ABE9A0")]
	public static DeckCard Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6006719")]
	[Address(RVA = "0xABEA70", Offset = "0xABDC70", VA = "0x180ABEA70")]
	public void SetRarity(bool b)
	{
	}

	[Token(Token = "0x600671A")]
	[Address(RVA = "0xABEA80", Offset = "0xABDC80", VA = "0x180ABEA80")]
	public void SetRegulation(int regurationID)
	{
	}

	[Token(Token = "0x600671B")]
	[Address(RVA = "0xAB9B30", Offset = "0xAB8D30", VA = "0x180AB9B30")]
	public void SetRegulationVisible(bool b)
	{
	}

	[Token(Token = "0x600671C")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public DeckCard()
	{
	}
}
