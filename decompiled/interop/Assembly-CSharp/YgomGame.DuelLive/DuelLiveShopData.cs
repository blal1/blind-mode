using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EF7")]
public class DuelLiveShopData
{
	[Token(Token = "0x400A589")]
	[FieldOffset(Offset = "0x10")]
	private List<DuelLiveCardPackData> m_packDataList;

	[Token(Token = "0x400A58A")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, DuelLiveShopHighlightItem> m_ReplayMenuMap;

	[Token(Token = "0x17000E08")]
	public List<DuelLiveCardPackData> packDataList
	{
		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E09")]
	public Dictionary<int, DuelLiveShopHighlightItem> replayMenuMap
	{
		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005AB5")]
	[Address(RVA = "0xA0BEC0", Offset = "0xA0B0C0", VA = "0x180A0BEC0")]
	public DuelLiveShopHighlightItem AddReplayMenu(int menuID, List<int> list, int selectedMrk = -1)
	{
		return null;
	}

	[Token(Token = "0x6005AB6")]
	[Address(RVA = "0xA0C030", Offset = "0xA0B230", VA = "0x180A0C030")]
	public DuelLiveShopHighlightItem GetMenu(int menuId)
	{
		return null;
	}

	[Token(Token = "0x6005AB7")]
	[Address(RVA = "0xA0C0C0", Offset = "0xA0B2C0", VA = "0x180A0C0C0")]
	public DuelLiveShopData()
	{
	}
}
