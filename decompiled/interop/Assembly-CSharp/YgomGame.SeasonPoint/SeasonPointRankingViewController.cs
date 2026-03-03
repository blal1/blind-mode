using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A32")]
public class SeasonPointRankingViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000A33")]
	internal class TeamInfo
	{
		[Token(Token = "0x400908D")]
		[FieldOffset(Offset = "0x10")]
		internal int uniqueId;

		[Token(Token = "0x400908E")]
		[FieldOffset(Offset = "0x18")]
		internal string leaderName;

		[Token(Token = "0x400908F")]
		[FieldOffset(Offset = "0x20")]
		internal int seasonPoint;

		[Token(Token = "0x4009090")]
		[FieldOffset(Offset = "0x24")]
		internal int ranking;

		[Token(Token = "0x6003E90")]
		[Address(RVA = "0x87A210", Offset = "0x879410", VA = "0x18087A210")]
		public TeamInfo(int uniqueId, string leaderName, int seasonPoint, int ranking)
		{
		}
	}

	[Token(Token = "0x4009073")]
	private const string k_PREF_PATH = "SeasonPoint/SeasonPointRanking";

	[Token(Token = "0x4009074")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string BUTTON_DETAIL_LABEL;

	[Token(Token = "0x4009075")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TITLE_TEXT;

	[Token(Token = "0x4009076")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string UPDATE_DATE_TEXT;

	[Token(Token = "0x4009077")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string BUTTON_LABEL;

	[Token(Token = "0x4009078")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x4009079")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string TEXT_TEAM_NAME_LABEL;

	[Token(Token = "0x400907A")]
	[FieldOffset(Offset = "0x100")]
	private readonly string TEXT_POINT_LABEL;

	[Token(Token = "0x400907B")]
	[FieldOffset(Offset = "0x108")]
	private readonly string TEXT_NOT_ENTRY_TEAM;

	[Token(Token = "0x400907C")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TEXT_NO_TEAM;

	[Token(Token = "0x400907D")]
	[FieldOffset(Offset = "0x118")]
	private readonly string TEXT_CAUTION;

	[Token(Token = "0x400907E")]
	[FieldOffset(Offset = "0x120")]
	private readonly string SEASON_POINT_ICON;

	[Token(Token = "0x400907F")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TEAM_ICON;

	[Token(Token = "0x4009080")]
	[FieldOffset(Offset = "0x130")]
	private readonly string TEXT_RANK;

	[Token(Token = "0x4009081")]
	[FieldOffset(Offset = "0x138")]
	private TextMeshProUGUI titleText;

	[Token(Token = "0x4009082")]
	[FieldOffset(Offset = "0x140")]
	private TextMeshProUGUI updateDateText;

	[Token(Token = "0x4009083")]
	[FieldOffset(Offset = "0x148")]
	private TextMeshProUGUI notEntryText;

	[Token(Token = "0x4009084")]
	[FieldOffset(Offset = "0x150")]
	private TextMeshProUGUI noTeamText;

	[Token(Token = "0x4009085")]
	[FieldOffset(Offset = "0x158")]
	private TextMeshProUGUI cautionText;

	[Token(Token = "0x4009086")]
	[FieldOffset(Offset = "0x160")]
	private TextMeshProUGUI rankText;

	[Token(Token = "0x4009087")]
	[FieldOffset(Offset = "0x168")]
	private InfinityScrollView isvOtherTeam;

	[Token(Token = "0x4009088")]
	[FieldOffset(Offset = "0x170")]
	private List<TeamInfo> dataInfos;

	[Token(Token = "0x4009089")]
	[FieldOffset(Offset = "0x178")]
	private bool isEntryTeam;

	[Token(Token = "0x400908A")]
	[FieldOffset(Offset = "0x179")]
	private bool isNoTeam;

	[Token(Token = "0x400908B")]
	[FieldOffset(Offset = "0x0")]
	private static int seasonId;

	[Token(Token = "0x400908C")]
	[FieldOffset(Offset = "0x4")]
	private static bool isResult;

	[Token(Token = "0x6003E84")]
	[Address(RVA = "0x84D670", Offset = "0x84C870", VA = "0x18084D670")]
	public static void Open(ViewControllerManager vcm, int id = 0, bool isresult = false)
	{
	}

	[Token(Token = "0x6003E85")]
	[Address(RVA = "0x84CC30", Offset = "0x84BE30", VA = "0x18084CC30", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6003E86")]
	[Address(RVA = "0x84CB90", Offset = "0x84BD90", VA = "0x18084CB90", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003E87")]
	[Address(RVA = "0x84CD40", Offset = "0x84BF40", VA = "0x18084CD40", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003E88")]
	[Address(RVA = "0x84E210", Offset = "0x84D410", VA = "0x18084E210")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6003E89")]
	[Address(RVA = "0x84D7A0", Offset = "0x84C9A0", VA = "0x18084D7A0")]
	private void UpdateMyTeam()
	{
	}

	[Token(Token = "0x6003E8A")]
	[Address(RVA = "0x84DF90", Offset = "0x84D190", VA = "0x18084DF90")]
	private void UpdateOtherTeam(Dictionary<int, TeamInfo> dict)
	{
	}

	[Token(Token = "0x6003E8B")]
	[Address(RVA = "0x84D050", Offset = "0x84C250", VA = "0x18084D050")]
	public void OnItemSetOtherTeam(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6003E8C")]
	[Address(RVA = "0x84CAF0", Offset = "0x84BCF0", VA = "0x18084CAF0")]
	public void CallGetRankingAPI()
	{
	}

	[Token(Token = "0x6003E8D")]
	[Address(RVA = "0x84E830", Offset = "0x84DA30", VA = "0x18084E830")]
	public SeasonPointRankingViewController()
	{
	}
}
