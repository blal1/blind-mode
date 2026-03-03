using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EFF")]
public class DuelLiveWCSLeaderData
{
	[Token(Token = "0x400A5A2")]
	[FieldOffset(Offset = "0x10")]
	public int leaderID;

	[Token(Token = "0x400A5A3")]
	[FieldOffset(Offset = "0x18")]
	public string displayName;

	[Token(Token = "0x400A5A4")]
	[FieldOffset(Offset = "0x20")]
	public int teamID;

	[Token(Token = "0x6005ACF")]
	[Address(RVA = "0xA11F00", Offset = "0xA11100", VA = "0x180A11F00")]
	public DuelLiveWCSLeaderData(int leaderID, string name)
	{
	}
}
