using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F07")]
public class DuelLiveWCSMenuData
{
	[Token(Token = "0x400A5C3")]
	[FieldOffset(Offset = "0x10")]
	public int menuID;

	[Token(Token = "0x400A5C4")]
	[FieldOffset(Offset = "0x18")]
	public string textIDs;

	[Token(Token = "0x400A5C5")]
	[FieldOffset(Offset = "0x20")]
	public int opt;

	[Token(Token = "0x400A5C6")]
	[FieldOffset(Offset = "0x24")]
	public bool liveActive;

	[Token(Token = "0x400A5C7")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, DuelLiveWCSSectionData> m_sections;

	[Token(Token = "0x400A5C8")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, DuelLiveWCSFilterItem> m_filters;

	[Token(Token = "0x400A5C9")]
	[FieldOffset(Offset = "0x38")]
	public int currentFilterNo;

	[Token(Token = "0x6005AE8")]
	[Address(RVA = "0xA128C0", Offset = "0xA11AC0", VA = "0x180A128C0")]
	public DuelLiveWCSMenuData(int menuID, string textIDs, int opt, bool liveActive)
	{
	}

	[Token(Token = "0x6005AE9")]
	[Address(RVA = "0xA12060", Offset = "0xA11260", VA = "0x180A12060")]
	public DuelLiveWCSSectionData AddSection(int sectionID, string labelTextID)
	{
		return null;
	}

	[Token(Token = "0x6005AEA")]
	[Address(RVA = "0xA12440", Offset = "0xA11640", VA = "0x180A12440")]
	public DuelLiveWCSSectionData GetSection(int sectionID)
	{
		return null;
	}

	[Token(Token = "0x6005AEB")]
	[Address(RVA = "0xA12690", Offset = "0xA11890", VA = "0x180A12690")]
	public IReadOnlyList<DuelLiveWCSSectionData> GetSortedSectionList()
	{
		return null;
	}

	[Token(Token = "0x6005AEC")]
	[Address(RVA = "0xA122F0", Offset = "0xA114F0", VA = "0x180A122F0")]
	public int GetReplayNum()
	{
		return default(int);
	}

	[Token(Token = "0x6005AED")]
	[Address(RVA = "0xA11F50", Offset = "0xA11150", VA = "0x180A11F50")]
	public void AddFilterItem(DuelLiveWCSFilterItem.Target target, int ID, string mainText, string subText, int teamIconID)
	{
	}

	[Token(Token = "0x6005AEE")]
	[Address(RVA = "0xA12850", Offset = "0xA11A50", VA = "0x180A12850")]
	public bool IsFilterEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005AEF")]
	[Address(RVA = "0xA12270", Offset = "0xA11470", VA = "0x180A12270")]
	public DuelLiveWCSFilterItem GetCurrentFilter()
	{
		return null;
	}

	[Token(Token = "0x6005AF0")]
	[Address(RVA = "0xA124D0", Offset = "0xA116D0", VA = "0x180A124D0")]
	public IReadOnlyList<DuelLiveWCSFilterItem> GetSortedFilterList()
	{
		return null;
	}
}
