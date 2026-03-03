using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A2C")]
public class SeasonPointHistoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000A2D")]
	internal class TeamInfo
	{
		[Token(Token = "0x400905E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int totalSeasonPoint;

		[Token(Token = "0x400905F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ProfileInfo profileInfo;

		[Token(Token = "0x4009060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Dictionary<int, SeasonPointInfo> duelistCupInfo;

		[Token(Token = "0x4009061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal SeasonPointInfo wcsInfo;

		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x85BED0", Offset = "0x85B0D0", VA = "0x18085BED0")]
		public TeamInfo(ProfileInfo profileInfo, int totalSeasonPoint, Dictionary<int, SeasonPointInfo> duelistCupInfo, SeasonPointInfo wcsInfo)
		{
		}
	}

	[Token(Token = "0x2000A2E")]
	internal class SeasonPointInfo
	{
		[Token(Token = "0x4009062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string month;

		[Token(Token = "0x4009063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int dp;

		[Token(Token = "0x4009064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int ranking;

		[Token(Token = "0x4009065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int season_pt;

		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x84CA70", Offset = "0x84BC70", VA = "0x18084CA70")]
		public SeasonPointInfo(string month, int dp, int ranking, int season_pt)
		{
		}
	}

	[Token(Token = "0x2000A2F")]
	internal class TotalPointInfo
	{
		[Token(Token = "0x4009066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string month;

		[Token(Token = "0x4009067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int season_pt;

		[Token(Token = "0x4009068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int bonus;

		[Token(Token = "0x6003E80")]
		[Address(RVA = "0x85BF40", Offset = "0x85B140", VA = "0x18085BF40")]
		public TotalPointInfo(string month, int season_pt, int bonus)
		{
		}
	}

	[Token(Token = "0x2000A30")]
	internal class ProfileInfo
	{
		[Token(Token = "0x4009069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int index;

		[Token(Token = "0x400906A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal long pcode;

		[Token(Token = "0x400906B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string name;

		[Token(Token = "0x400906C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int icon_id;

		[Token(Token = "0x400906D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int icon_frame_id;

		[Token(Token = "0x400906E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal bool is_same_os;

		[Token(Token = "0x400906F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal string online_id;

		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x848C50", Offset = "0x847E50", VA = "0x180848C50")]
		public ProfileInfo(int index, long pcode, string name, int icon_id, int icon_frame_id, bool is_same_os, string online_id)
		{
		}
	}

	[Token(Token = "0x400903A")]
	private const string k_PREF_PATH = "SeasonPoint/SeasonPointHistory";

	[Token(Token = "0x400903B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BUTTON_DETAIL_LABEL;

	[Token(Token = "0x400903C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string TITLE_TEXT;

	[Token(Token = "0x400903D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string UPDATE_DATE_TEXT;

	[Token(Token = "0x400903E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400903F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string TEXT_TEAM_NAME_LABEL;

	[Token(Token = "0x4009040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TEXT_POINT_LABEL;

	[Token(Token = "0x4009041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string SEASON_POINT_ICON;

	[Token(Token = "0x4009042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string SEASON_POINT_WIDGET_ICON;

	[Token(Token = "0x4009043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string DUELIST_CUP_ICON;

	[Token(Token = "0x4009044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string TEAM_ICON;

	[Token(Token = "0x4009045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string WCS_ICON;

	[Token(Token = "0x4009046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string SEASON_GROUP_WIDGET_LABEL;

	[Token(Token = "0x4009047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string TEXT_SEASON_MY_TEXT;

	[Token(Token = "0x4009048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string TEXT_SEASON;

	[Token(Token = "0x4009049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string TEXT_RANK;

	[Token(Token = "0x400904A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string TEXT_BONUS;

	[Token(Token = "0x400904B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string TEXT_SEASONPOINT;

	[Token(Token = "0x400904C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string TEXT_DUELISTPOINT;

	[Token(Token = "0x400904D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string TEXT_LINEBOTTOM;

	[Token(Token = "0x400904E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400904F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x4009050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x4009051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string BUTTON_PROFILE_LABEL;

	[Token(Token = "0x4009052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string WCS_ICON_PATH;

	[Token(Token = "0x4009053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private TextMeshProUGUI titleText;

	[Token(Token = "0x4009054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x4009055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private FreeScrollView m_FreeScrollView;

	[Token(Token = "0x4009056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<TeamInfo> dataInfos;

	[Token(Token = "0x4009057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private List<TotalPointInfo> cupTotalPoint;

	[Token(Token = "0x4009058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private List<SelectionItem> profileButtons;

	[Token(Token = "0x4009059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private bool isOwn;

	[Token(Token = "0x400905A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private int uniqueId;

	[Token(Token = "0x400905B")]
	private const string defaultText = "-";

	[Token(Token = "0x400905C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private TeamInfo teamInfo;

	[Token(Token = "0x400905D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private TotalPointInfo wcsTotalPoint;

	[Token(Token = "0x6003E72")]
	[Address(RVA = "0x84A790", Offset = "0x849990", VA = "0x18084A790")]
	public static void Open(ViewControllerManager vcm, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003E73")]
	[Address(RVA = "0x848D80", Offset = "0x847F80", VA = "0x180848D80", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003E74")]
	[Address(RVA = "0x848F70", Offset = "0x848170", VA = "0x180848F70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003E75")]
	[Address(RVA = "0x84ACF0", Offset = "0x849EF0", VA = "0x18084ACF0")]
	private Dictionary<int, TeamInfo> UpdateView()
	{
		return null;
	}

	[Token(Token = "0x6003E76")]
	[Address(RVA = "0x84AA30", Offset = "0x849C30", VA = "0x18084AA30")]
	private void UpdateTeamData(Dictionary<int, TeamInfo> dic)
	{
	}

	[Token(Token = "0x6003E77")]
	[Address(RVA = "0x8491F0", Offset = "0x8483F0", VA = "0x1808491F0")]
	public void OnItemSetTeam()
	{
	}

	[Token(Token = "0x6003E78")]
	[Address(RVA = "0x848CD0", Offset = "0x847ED0", VA = "0x180848CD0")]
	public void CallGetRecordAPI(bool isOwn, int uniqueId)
	{
	}

	[Token(Token = "0x6003E79")]
	[Address(RVA = "0x84A7F0", Offset = "0x8499F0", VA = "0x18084A7F0")]
	private void SetScrollView()
	{
	}

	[Token(Token = "0x6003E7A")]
	[Address(RVA = "0x84C5B0", Offset = "0x84B7B0", VA = "0x18084C5B0")]
	public SeasonPointHistoryViewController()
	{
	}
}
