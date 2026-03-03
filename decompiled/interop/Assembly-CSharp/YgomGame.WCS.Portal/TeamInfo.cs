using Il2CppDummyDll;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x200078B")]
public class TeamInfo
{
	[Token(Token = "0x40025D4")]
	[FieldOffset(Offset = "0x10")]
	public int teamID;

	[Token(Token = "0x40025D5")]
	[FieldOffset(Offset = "0x18")]
	public string teamName;

	[Token(Token = "0x40025D6")]
	[FieldOffset(Offset = "0x20")]
	public int teamIconID;

	[Token(Token = "0x40025D7")]
	[FieldOffset(Offset = "0x24")]
	public int area;

	[Token(Token = "0x40025D8")]
	[FieldOffset(Offset = "0x28")]
	public int order;

	[Token(Token = "0x6003159")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TeamInfo()
	{
	}
}
