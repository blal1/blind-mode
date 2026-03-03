using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20017A3")]
internal class ChainInfo
{
	[Token(Token = "0x20017A4")]
	public class ChainBlockData
	{
		[Token(Token = "0x400DD8C")]
		[FieldOffset(Offset = "0x10")]
		public int player;

		[Token(Token = "0x400DD8D")]
		[FieldOffset(Offset = "0x14")]
		public int cardID;

		[Token(Token = "0x400DD8E")]
		[FieldOffset(Offset = "0x18")]
		public int uniqueID;

		[Token(Token = "0x400DD8F")]
		[FieldOffset(Offset = "0x1C")]
		public bool step;

		[Token(Token = "0x400DD90")]
		[FieldOffset(Offset = "0x20")]
		public int effectNo;

		[Token(Token = "0x60094CA")]
		[Address(RVA = "0xDD8760", Offset = "0xDD7960", VA = "0x180DD8760")]
		public ChainBlockData(int player, int cardID, int uniqueID, int effectNo)
		{
		}
	}

	[Token(Token = "0x400DD8A")]
	[FieldOffset(Offset = "0x10")]
	private List<ChainBlockData> chainInfoList;

	[Token(Token = "0x400DD8B")]
	[FieldOffset(Offset = "0x18")]
	private int lastCardHappenEffectNo;

	[Token(Token = "0x60094C2")]
	[Address(RVA = "0xDD87B0", Offset = "0xDD79B0", VA = "0x180DD87B0")]
	public void AddChainBlockData(int player, int cardID, int uniqueID)
	{
	}

	[Token(Token = "0x60094C3")]
	[Address(RVA = "0xDD8A40", Offset = "0xDD7C40", VA = "0x180DD8A40")]
	public ChainBlockData GetCurrentChainBlockData()
	{
		return null;
	}

	[Token(Token = "0x60094C4")]
	[Address(RVA = "0xDD8B60", Offset = "0xDD7D60", VA = "0x180DD8B60")]
	public void SetCurrentChainBlockStep()
	{
	}

	[Token(Token = "0x60094C5")]
	[Address(RVA = "0xDD8AF0", Offset = "0xDD7CF0", VA = "0x180DD8AF0")]
	public void RemoveLastChainData()
	{
	}

	[Token(Token = "0x60094C6")]
	[Address(RVA = "0xDD8AB0", Offset = "0xDD7CB0", VA = "0x180DD8AB0")]
	public int GetCurrentChainNum()
	{
		return default(int);
	}

	[Token(Token = "0x60094C7")]
	[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
	public void SetLastCardHappenEffectNo(int effectNo)
	{
	}

	[Token(Token = "0x60094C8")]
	[Address(RVA = "0xDD88C0", Offset = "0xDD7AC0", VA = "0x180DD88C0")]
	public List<ChainBlockData> GetChainBlockDataListByPlayer(int player)
	{
		return null;
	}

	[Token(Token = "0x60094C9")]
	[Address(RVA = "0xDD8BD0", Offset = "0xDD7DD0", VA = "0x180DD8BD0")]
	public ChainInfo()
	{
	}
}
