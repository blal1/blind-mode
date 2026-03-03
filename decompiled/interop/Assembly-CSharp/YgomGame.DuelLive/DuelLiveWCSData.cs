using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F08")]
public class DuelLiveWCSData
{
	[Token(Token = "0x400A5CA")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, DuelLiveWCSLeaderData> m_leaders;

	[Token(Token = "0x400A5CB")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, DuelLiveWCSTeamData> m_teams;

	[Token(Token = "0x400A5CC")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, DuelLiveWCSMenuData> m_menus;

	[Token(Token = "0x6005AF1")]
	[Address(RVA = "0xA10030", Offset = "0xA0F230", VA = "0x180A10030")]
	public void AddLeader(int leaderID, string name)
	{
	}

	[Token(Token = "0x6005AF2")]
	[Address(RVA = "0xA106B0", Offset = "0xA0F8B0", VA = "0x180A106B0")]
	public DuelLiveWCSLeaderData GetLeader(int leaderID)
	{
		return null;
	}

	[Token(Token = "0x6005AF3")]
	[Address(RVA = "0xA10490", Offset = "0xA0F690", VA = "0x180A10490")]
	public void AddTeam(int teamID, int iconID, int area, string name, int leaderID)
	{
	}

	[Token(Token = "0x6005AF4")]
	[Address(RVA = "0xA107D0", Offset = "0xA0F9D0", VA = "0x180A107D0")]
	public DuelLiveWCSTeamData GetTeam(int teamID)
	{
		return null;
	}

	[Token(Token = "0x6005AF5")]
	[Address(RVA = "0xA10110", Offset = "0xA0F310", VA = "0x180A10110")]
	public DuelLiveWCSMenuData AddMenu(int menuID, string displayTextIDs, int opt, bool liveActive)
	{
		return null;
	}

	[Token(Token = "0x6005AF6")]
	[Address(RVA = "0xA10740", Offset = "0xA0F940", VA = "0x180A10740")]
	public DuelLiveWCSMenuData GetMenu(int menuID)
	{
		return null;
	}

	[Token(Token = "0x6005AF7")]
	[Address(RVA = "0xA0FDA0", Offset = "0xA0EFA0", VA = "0x180A0FDA0")]
	public void AddLeaderFilter(int menuID, int leaderID)
	{
	}

	[Token(Token = "0x6005AF8")]
	[Address(RVA = "0xA10320", Offset = "0xA0F520", VA = "0x180A10320")]
	public void AddTeamFilter(int menuID, int teamID)
	{
	}

	[Token(Token = "0x6005AF9")]
	[Address(RVA = "0xA10860", Offset = "0xA0FA60", VA = "0x180A10860")]
	public bool IsFilterEnable(int menuID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AFA")]
	[Address(RVA = "0xA108D0", Offset = "0xA0FAD0", VA = "0x180A108D0")]
	public bool IsFilterSelected(int menuID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AFB")]
	[Address(RVA = "0xA10650", Offset = "0xA0F850", VA = "0x180A10650")]
	public DuelLiveWCSFilterItem GetCurrentFilter(int menuID)
	{
		return null;
	}

	[Token(Token = "0x6005AFC")]
	[Address(RVA = "0xA10680", Offset = "0xA0F880", VA = "0x180A10680")]
	public IReadOnlyList<DuelLiveWCSFilterItem> GetFilterList(int menuID)
	{
		return null;
	}

	[Token(Token = "0x6005AFD")]
	[Address(RVA = "0xA10900", Offset = "0xA0FB00", VA = "0x180A10900")]
	public DuelLiveWCSData()
	{
	}
}
