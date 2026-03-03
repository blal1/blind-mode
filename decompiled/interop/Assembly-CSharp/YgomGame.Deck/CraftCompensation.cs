using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Deck;

[Token(Token = "0x2001055")]
public class CraftCompensation
{
	[Token(Token = "0x400AE3C")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x400AE3D")]
	[FieldOffset(Offset = "0x14")]
	public int cardId;

	[Token(Token = "0x400AE3E")]
	[FieldOffset(Offset = "0x18")]
	public int point;

	[Token(Token = "0x400AE3F")]
	[FieldOffset(Offset = "0x1C")]
	public int maxNum;

	[Token(Token = "0x400AE40")]
	[FieldOffset(Offset = "0x20")]
	public string openDate;

	[Token(Token = "0x400AE41")]
	[FieldOffset(Offset = "0x28")]
	public string endDate;

	[Token(Token = "0x400AE42")]
	[FieldOffset(Offset = "0x30")]
	public long openTime;

	[Token(Token = "0x400AE43")]
	[FieldOffset(Offset = "0x38")]
	public long endTime;

	[Token(Token = "0x400AE44")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<int, AlterCompensation> specialExchange;

	[Token(Token = "0x60062F6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CraftCompensation()
	{
	}
}
