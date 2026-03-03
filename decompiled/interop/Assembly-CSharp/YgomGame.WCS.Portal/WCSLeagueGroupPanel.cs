using Il2CppDummyDll;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x2000770")]
public class WCSLeagueGroupPanel
{
	[Token(Token = "0x4002540")]
	protected const string LABEL_DUELICON = "DuelIcon";

	[Token(Token = "0x4002541")]
	[FieldOffset(Offset = "0x10")]
	protected readonly int _teamMax;

	[Token(Token = "0x4002542")]
	[FieldOffset(Offset = "0x18")]
	protected ElementObjectManager _scrollViewEom;

	[Token(Token = "0x4002543")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager _tableRootEom;

	[Token(Token = "0x4002544")]
	[FieldOffset(Offset = "0x28")]
	protected ElementObjectManager _tableHeaderEom;

	[Token(Token = "0x4002545")]
	[FieldOffset(Offset = "0x30")]
	protected ElementObjectManager[] _teamRowEom;

	[Token(Token = "0x4002546")]
	[FieldOffset(Offset = "0x38")]
	protected ElementObjectManager[,] _eachBattleRecordsEom;

	[Token(Token = "0x4002547")]
	[FieldOffset(Offset = "0x40")]
	protected SelectionButton[] _teamSituationButtons;

	[Token(Token = "0x4002548")]
	[FieldOffset(Offset = "0x48")]
	public readonly int _index;

	[Token(Token = "0x17000606")]
	public int teamMax
	{
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000607")]
	public int rowNum
	{
		[Token(Token = "0x60030B4")]
		[Address(RVA = "0x73C800", Offset = "0x73BA00", VA = "0x18073C800")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000608")]
	public int colNum
	{
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x73C7D0", Offset = "0x73B9D0", VA = "0x18073C7D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60030B6")]
	[Address(RVA = "0x73C620", Offset = "0x73B820", VA = "0x18073C620")]
	public WCSLeagueGroupPanel(ElementObjectManager scrollviewEom, int tableIndex, int teamMax)
	{
	}

	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x73BEE0", Offset = "0x73B0E0", VA = "0x18073BEE0", Slot = "4")]
	public virtual void Setup()
	{
	}

	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x73C560", Offset = "0x73B760", VA = "0x18073C560", Slot = "5")]
	public virtual void Terminate()
	{
	}

	[Token(Token = "0x60030B9")]
	[Address(RVA = "0x73B5A0", Offset = "0x73A7A0", VA = "0x18073B5A0", Slot = "6")]
	public virtual void SetHeaderGroupName(string name)
	{
	}

	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x73BB70", Offset = "0x73AD70", VA = "0x18073BB70", Slot = "7")]
	public virtual void SetTeamIconOnHeader(int colIndex, string spritePath)
	{
	}

	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x73BC30", Offset = "0x73AE30", VA = "0x18073BC30", Slot = "8")]
	public virtual void SetTeamInfo(int rowIndex, string areaName, string name, string iconSpritePath)
	{
	}

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x73BC60", Offset = "0x73AE60", VA = "0x18073BC60")]
	protected void SetTeamInfo(ElementObjectManager[] target, int rowIndex, string areaName, string name, string iconSpritePath)
	{
	}

	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x73BDF0", Offset = "0x73AFF0", VA = "0x18073BDF0", Slot = "9")]
	public virtual void SetTeamWinCount(int rowIndex, int winCount)
	{
	}

	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x73AE30", Offset = "0x73A030", VA = "0x18073AE30", Slot = "10")]
	public virtual void HideTeamWinCount(int rowIndex)
	{
	}

	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x73B630", Offset = "0x73A830", VA = "0x18073B630", Slot = "11")]
	public virtual void SetIndivisualWinDiff(int rowIndex, int deltaNum)
	{
	}

	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x73ACF0", Offset = "0x739EF0", VA = "0x18073ACF0", Slot = "12")]
	public virtual void HideIndivisualWinDiff(int rowIndex)
	{
	}

	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	public virtual void SetLeaderWinCount(int rowIndex, int winCount)
	{
	}

	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public virtual void HideLeaderWinCount(int rowIndex)
	{
	}

	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x73B720", Offset = "0x73A920", VA = "0x18073B720", Slot = "15")]
	public virtual void SetRank(int rowIndex, int rank, bool top2Fixed)
	{
	}

	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x73B7D0", Offset = "0x73A9D0", VA = "0x18073B7D0")]
	protected void SetRank(ExtendedTextMeshProUGUI target, int rank, bool top2Fixed)
	{
	}

	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x73AD90", Offset = "0x739F90", VA = "0x18073AD90", Slot = "16")]
	public virtual void HideRank(int rowIndex)
	{
	}

	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x73B0C0", Offset = "0x73A2C0", VA = "0x18073B0C0", Slot = "17")]
	public virtual void SetBattleRecord(int rowIndex, int columnIndex, Def.BattleResult? result, int myWinCount, int oppWinCount)
	{
	}

	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x73B9F0", Offset = "0x73ABF0", VA = "0x18073B9F0", Slot = "18")]
	public virtual void SetStatusBattleRecord(int rowIndex, int columnIndex, bool inDuel)
	{
	}

	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x73AED0", Offset = "0x73A0D0", VA = "0x18073AED0", Slot = "19")]
	public virtual void RegisterTeamSituationBtnAction(int rowIndex, int columnIndex, UnityAction callback, out bool cursorMoving)
	{
	}

	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x73AC50", Offset = "0x739E50", VA = "0x18073AC50", Slot = "20")]
	public virtual bool FocusButtonCursor()
	{
		return default(bool);
	}
}
