using Il2CppDummyDll;

namespace YgomGame.Deck;

[Token(Token = "0x2001104")]
internal class CategoryReference
{
	[Token(Token = "0x400B3D1")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x400B3D2")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x400B3D3")]
	[FieldOffset(Offset = "0x20")]
	public string kana;

	[Token(Token = "0x6006AF9")]
	[Address(RVA = "0xB245F0", Offset = "0xB237F0", VA = "0x180B245F0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AFA")]
	[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006AFB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CategoryReference()
	{
	}
}
