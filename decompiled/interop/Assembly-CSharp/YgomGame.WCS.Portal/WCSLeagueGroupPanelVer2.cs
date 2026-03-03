using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x2000771")]
public class WCSLeagueGroupPanelVer2 : WCSLeagueGroupPanel
{
	[Token(Token = "0x4002549")]
	[FieldOffset(Offset = "0x50")]
	protected ElementObjectManager _tableRoot2_Eom;

	[Token(Token = "0x400254A")]
	[FieldOffset(Offset = "0x58")]
	protected ElementObjectManager _tableHeader2_Eom;

	[Token(Token = "0x400254B")]
	[FieldOffset(Offset = "0x60")]
	protected ElementObjectManager[] _teamRow2_Eom;

	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x73AB10", Offset = "0x739D10", VA = "0x18073AB10")]
	public WCSLeagueGroupPanelVer2(ElementObjectManager scrollviewEom, int tableIndex, int teamMax)
	{
	}

	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x73A450", Offset = "0x739650", VA = "0x18073A450", Slot = "4")]
	public override void Setup()
	{
	}

	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public override void SetHeaderGroupName(string name)
	{
	}

	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x73A2D0", Offset = "0x7394D0", VA = "0x18073A2D0", Slot = "8")]
	public override void SetTeamInfo(int rowIndex, string areaName, string name, string iconSpritePath)
	{
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x73A360", Offset = "0x739560", VA = "0x18073A360", Slot = "9")]
	public override void SetTeamWinCount(int rowIndex, int winCount)
	{
	}

	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x739C00", Offset = "0x738E00", VA = "0x180739C00", Slot = "10")]
	public override void HideTeamWinCount(int rowIndex)
	{
	}

	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x739DA0", Offset = "0x738FA0", VA = "0x180739DA0", Slot = "11")]
	public override void SetIndivisualWinDiff(int rowIndex, int deltaNum)
	{
	}

	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x739970", Offset = "0x738B70", VA = "0x180739970", Slot = "12")]
	public override void HideIndivisualWinDiff(int rowIndex)
	{
	}

	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x739E90", Offset = "0x739090", VA = "0x180739E90", Slot = "13")]
	public override void SetLeaderWinCount(int rowIndex, int winCount)
	{
	}

	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x739A10", Offset = "0x738C10", VA = "0x180739A10", Slot = "14")]
	public override void HideLeaderWinCount(int rowIndex)
	{
	}

	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x739F80", Offset = "0x739180", VA = "0x180739F80", Slot = "15")]
	public override void SetRank(int rowIndex, int rank, bool top2Fixed)
	{
	}

	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x739AD0", Offset = "0x738CD0", VA = "0x180739AD0", Slot = "16")]
	public override void HideRank(int rowIndex)
	{
	}

	[Token(Token = "0x60030D6")]
	[Address(RVA = "0x739CA0", Offset = "0x738EA0", VA = "0x180739CA0", Slot = "17")]
	public override void SetBattleRecord(int rowIndex, int columnIndex, Def.BattleResult? result, int myWinCount, int oppWinCount)
	{
	}

	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x73A0B0", Offset = "0x7392B0", VA = "0x18073A0B0", Slot = "18")]
	public override void SetStatusBattleRecord(int rowIndex, int columnIndex, bool inDuel)
	{
	}
}
