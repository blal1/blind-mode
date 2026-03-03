using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F05")]
public class DuelLiveWCSRoomData
{
	[Token(Token = "0x400A5BC")]
	[FieldOffset(Offset = "0x10")]
	public int roomID;

	[Token(Token = "0x400A5BD")]
	[FieldOffset(Offset = "0x18")]
	public DuelLiveWCSTeamData[] teams;

	[Token(Token = "0x400A5BE")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, DuelLiveWCSSetData> m_sets;

	[Token(Token = "0x6005ADE")]
	[Address(RVA = "0xA12F70", Offset = "0xA12170", VA = "0x180A12F70")]
	public DuelLiveWCSRoomData(int roomID, DuelLiveWCSTeamData team1, DuelLiveWCSTeamData team2)
	{
	}

	[Token(Token = "0x6005ADF")]
	[Address(RVA = "0xA129D0", Offset = "0xA11BD0", VA = "0x180A129D0")]
	public DuelLiveWCSSetData AddSet(int setID, string displayText)
	{
		return null;
	}

	[Token(Token = "0x6005AE0")]
	[Address(RVA = "0xA12D20", Offset = "0xA11F20", VA = "0x180A12D20")]
	public DuelLiveWCSSetData GetSet(int setID)
	{
		return null;
	}

	[Token(Token = "0x6005AE1")]
	[Address(RVA = "0xA12DB0", Offset = "0xA11FB0", VA = "0x180A12DB0")]
	public IReadOnlyList<DuelLiveWCSSetData> GetSortedSetList()
	{
		return null;
	}

	[Token(Token = "0x6005AE2")]
	[Address(RVA = "0xA12B70", Offset = "0xA11D70", VA = "0x180A12B70")]
	public int GetReplayNum()
	{
		return default(int);
	}
}
