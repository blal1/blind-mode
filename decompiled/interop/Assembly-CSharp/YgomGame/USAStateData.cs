using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x200070A")]
public class USAStateData
{
	[Token(Token = "0x400232F")]
	[FieldOffset(Offset = "0x10")]
	public int numeric;

	[Token(Token = "0x4002330")]
	[FieldOffset(Offset = "0x18")]
	public string displayName;

	[Token(Token = "0x4002331")]
	[FieldOffset(Offset = "0x20")]
	public bool isCCPA;

	[Token(Token = "0x4002332")]
	[FieldOffset(Offset = "0x28")]
	public string isoCode;

	[Token(Token = "0x6002E94")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public USAStateData()
	{
	}
}
