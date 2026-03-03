using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F00")]
public class DuelLiveWCSTeamData
{
	[Token(Token = "0x400A5A5")]
	[FieldOffset(Offset = "0x10")]
	public int teamID;

	[Token(Token = "0x400A5A6")]
	[FieldOffset(Offset = "0x14")]
	public int iconID;

	[Token(Token = "0x400A5A7")]
	[FieldOffset(Offset = "0x18")]
	public int area;

	[Token(Token = "0x400A5A8")]
	[FieldOffset(Offset = "0x20")]
	public DuelLiveWCSLeaderData leader;

	[Token(Token = "0x400A5A9")]
	[FieldOffset(Offset = "0x28")]
	public string teamName;

	[Token(Token = "0x400A5AA")]
	[FieldOffset(Offset = "0x30")]
	public string areaName;

	[Token(Token = "0x6005AD0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveWCSTeamData()
	{
	}
}
