using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F06")]
public class DuelLiveWCSSectionData
{
	[Token(Token = "0x400A5BF")]
	[FieldOffset(Offset = "0x10")]
	public int sectionID;

	[Token(Token = "0x400A5C0")]
	[FieldOffset(Offset = "0x18")]
	public string labelTextID;

	[Token(Token = "0x400A5C1")]
	[FieldOffset(Offset = "0x20")]
	public string displayText;

	[Token(Token = "0x400A5C2")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, DuelLiveWCSRoomData> m_rooms;

	[Token(Token = "0x6005AE3")]
	[Address(RVA = "0xA13720", Offset = "0xA12920", VA = "0x180A13720")]
	public DuelLiveWCSSectionData(int sectionID, string labelTextID)
	{
	}

	[Token(Token = "0x6005AE4")]
	[Address(RVA = "0xA130F0", Offset = "0xA122F0", VA = "0x180A130F0")]
	public DuelLiveWCSRoomData AddRoom(int roomID, DuelLiveWCSTeamData team1, DuelLiveWCSTeamData team2)
	{
		return null;
	}

	[Token(Token = "0x6005AE5")]
	[Address(RVA = "0xA134D0", Offset = "0xA126D0", VA = "0x180A134D0")]
	public DuelLiveWCSRoomData GetRoom(int roomID)
	{
		return null;
	}

	[Token(Token = "0x6005AE6")]
	[Address(RVA = "0xA13560", Offset = "0xA12760", VA = "0x180A13560")]
	public IReadOnlyList<DuelLiveWCSRoomData> GetSortedRoomList()
	{
		return null;
	}

	[Token(Token = "0x6005AE7")]
	[Address(RVA = "0xA13380", Offset = "0xA12580", VA = "0x180A13380")]
	public int GetReplayNum()
	{
		return default(int);
	}
}
