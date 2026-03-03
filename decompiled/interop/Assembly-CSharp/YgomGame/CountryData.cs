using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x20006FB")]
public class CountryData
{
	[Token(Token = "0x400230A")]
	[FieldOffset(Offset = "0x10")]
	public int numeric;

	[Token(Token = "0x400230B")]
	[FieldOffset(Offset = "0x18")]
	public string alpha2;

	[Token(Token = "0x400230C")]
	[FieldOffset(Offset = "0x20")]
	public string alpha3;

	[Token(Token = "0x400230D")]
	[FieldOffset(Offset = "0x28")]
	public string displayName;

	[Token(Token = "0x400230E")]
	[FieldOffset(Offset = "0x30")]
	public PlatformTOSKind TOSKind;

	[Token(Token = "0x400230F")]
	[FieldOffset(Offset = "0x34")]
	public bool isGDPR;

	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CountryData()
	{
	}
}
