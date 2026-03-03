using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001C94")]
public class ColosseumRankingDuelistCupViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001C95")]
	public enum regionType
	{
		[Token(Token = "0x400FF82")]
		REGION_JAPAN = 1,
		[Token(Token = "0x400FF83")]
		REGION_ASIA,
		[Token(Token = "0x400FF84")]
		REGION_NORTH_AMERICA,
		[Token(Token = "0x400FF85")]
		REGION_LATIN_AMERICA,
		[Token(Token = "0x400FF86")]
		REGION_EUROPE_OTHER
	}

	[Token(Token = "0x2001C96")]
	protected class RankingDuelistCupTemplate
	{
		[Token(Token = "0x400FF87")]
		[FieldOffset(Offset = "0x10")]
		public readonly int dp;

		[Token(Token = "0x400FF88")]
		[FieldOffset(Offset = "0x18")]
		public readonly long pcode;

		[Token(Token = "0x400FF89")]
		[FieldOffset(Offset = "0x20")]
		public readonly string name;

		[Token(Token = "0x400FF8A")]
		[FieldOffset(Offset = "0x28")]
		public readonly string order;

		[Token(Token = "0x400FF8B")]
		[FieldOffset(Offset = "0x30")]
		public readonly int iconID;

		[Token(Token = "0x400FF8C")]
		[FieldOffset(Offset = "0x34")]
		public readonly int frameID;

		[Token(Token = "0x400FF8D")]
		[FieldOffset(Offset = "0x38")]
		public readonly int is_same_os;

		[Token(Token = "0x400FF8E")]
		[FieldOffset(Offset = "0x3C")]
		public readonly int online_id;

		[Token(Token = "0x400FF8F")]
		[FieldOffset(Offset = "0x40")]
		public readonly bool isResistedPlatform;

		[Token(Token = "0x400FF90")]
		[FieldOffset(Offset = "0x41")]
		public readonly bool isSamePlatform;

		[Token(Token = "0x400FF91")]
		[FieldOffset(Offset = "0x48")]
		public readonly string platformName;

		[Token(Token = "0x600B94B")]
		[Address(RVA = "0x548190", Offset = "0x547390", VA = "0x180548190")]
		private RankingDuelistCupTemplate(long pcode, string name, string order, int iconID, int frameID, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
		{
		}

		[Token(Token = "0x600B94C")]
		[Address(RVA = "0x548220", Offset = "0x547420", VA = "0x180548220")]
		public RankingDuelistCupTemplate(long pcode, string name, string order, int iconID, int frameID, int dp, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
		{
		}
	}

	[Token(Token = "0x400FF52")]
	[FieldOffset(Offset = "0xD0")]
	protected readonly string ROOT_MYORDER_LABEL;

	[Token(Token = "0x400FF53")]
	[FieldOffset(Offset = "0xD8")]
	protected readonly string ROOT_RANK1_LABEL;

	[Token(Token = "0x400FF54")]
	[FieldOffset(Offset = "0xE0")]
	protected readonly string ROOT_RANK2_LABEL;

	[Token(Token = "0x400FF55")]
	[FieldOffset(Offset = "0xE8")]
	protected readonly string ROOT_RANK3_LABEL;

	[Token(Token = "0x400FF56")]
	[FieldOffset(Offset = "0xF0")]
	protected readonly string SCROLL_RANKING_LABEL;

	[Token(Token = "0x400FF57")]
	[FieldOffset(Offset = "0xF8")]
	protected readonly string BUTTON_LABEL;

	[Token(Token = "0x400FF58")]
	[FieldOffset(Offset = "0x100")]
	protected readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400FF59")]
	[FieldOffset(Offset = "0x108")]
	protected readonly string IMG_RANK_LABEL;

	[Token(Token = "0x400FF5A")]
	[FieldOffset(Offset = "0x110")]
	protected readonly string IMG_ARROW_LABEL;

	[Token(Token = "0x400FF5B")]
	[FieldOffset(Offset = "0x118")]
	protected readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x400FF5C")]
	[FieldOffset(Offset = "0x120")]
	protected readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x400FF5D")]
	[FieldOffset(Offset = "0x128")]
	protected readonly string TXT_ORDER_LABEL;

	[Token(Token = "0x400FF5E")]
	[FieldOffset(Offset = "0x130")]
	protected readonly string TXT_SCORE_LABEL;

	[Token(Token = "0x400FF5F")]
	[FieldOffset(Offset = "0x138")]
	protected readonly string TXT_AGGREGATE_MY_TEXT;

	[Token(Token = "0x400FF60")]
	[FieldOffset(Offset = "0x140")]
	protected readonly string TXT_AGGREGATE_TEXT;

	[Token(Token = "0x400FF61")]
	[FieldOffset(Offset = "0x148")]
	protected readonly string TXT_CAUTION_TEXT;

	[Token(Token = "0x400FF62")]
	[FieldOffset(Offset = "0x150")]
	protected readonly string ROOT_WCS_MYORDER_LABEL;

	[Token(Token = "0x400FF63")]
	[FieldOffset(Offset = "0x158")]
	protected readonly string BUTTON_MYRESULT;

	[Token(Token = "0x400FF64")]
	[FieldOffset(Offset = "0x160")]
	protected readonly string TXT_WCS_SCORE_NAME_LABEL;

	[Token(Token = "0x400FF65")]
	[FieldOffset(Offset = "0x168")]
	protected readonly string TXT_WCS_SCORE_LABEL;

	[Token(Token = "0x400FF66")]
	[FieldOffset(Offset = "0x170")]
	protected readonly string TXT_WCS_ORDER_NAME_LABEL;

	[Token(Token = "0x400FF67")]
	[FieldOffset(Offset = "0x178")]
	protected readonly string TXT_WCS_REGION_ORDER_NAME_LABEL;

	[Token(Token = "0x400FF68")]
	[FieldOffset(Offset = "0x180")]
	protected readonly string TXT_WCS_ORDER_LABEL;

	[Token(Token = "0x400FF69")]
	[FieldOffset(Offset = "0x188")]
	protected readonly string TXT_WCS_REGION_ORDER_LABEL;

	[Token(Token = "0x400FF6A")]
	[FieldOffset(Offset = "0x190")]
	protected readonly string TXT_TITLE;

	[Token(Token = "0x400FF6B")]
	[FieldOffset(Offset = "0x198")]
	protected readonly string FOOTER_LABEL;

	[Token(Token = "0x400FF6C")]
	[FieldOffset(Offset = "0x1A0")]
	protected readonly string EOM_BUTTON_CAHNGE_AREA_LABEL;

	[Token(Token = "0x400FF6D")]
	[FieldOffset(Offset = "0x1A8")]
	protected int TOP_RANK;

	[Token(Token = "0x400FF6E")]
	[FieldOffset(Offset = "0x1B0")]
	protected InfinityScrollView isv;

	[Token(Token = "0x400FF6F")]
	[FieldOffset(Offset = "0x1B8")]
	protected ElementObjectManager rootMyOrder;

	[Token(Token = "0x400FF70")]
	[FieldOffset(Offset = "0x1C0")]
	protected ElementObjectManager wcsRootMyOrder;

	[Token(Token = "0x400FF71")]
	[FieldOffset(Offset = "0x1C8")]
	protected List<ElementObjectManager> rootRanks;

	[Token(Token = "0x400FF72")]
	[FieldOffset(Offset = "0x1D0")]
	protected int yearId;

	[Token(Token = "0x400FF73")]
	[FieldOffset(Offset = "0x1D4")]
	protected int monthId;

	[Token(Token = "0x400FF74")]
	[FieldOffset(Offset = "0x1D8")]
	protected int cid;

	[Token(Token = "0x400FF75")]
	[FieldOffset(Offset = "0x1DC")]
	protected ColosseumUtil.RankingType type;

	[Token(Token = "0x400FF76")]
	[FieldOffset(Offset = "0x1E0")]
	protected Util.GameMode mode;

	[Token(Token = "0x400FF77")]
	[FieldOffset(Offset = "0x1E8")]
	protected List<RankingDuelistCupTemplate> rankingTemplates;

	[Token(Token = "0x400FF78")]
	[FieldOffset(Offset = "0x1F0")]
	protected List<string> rankingAreaList;

	[Token(Token = "0x400FF79")]
	[FieldOffset(Offset = "0x1F8")]
	protected string currentArea;

	[Token(Token = "0x400FF7A")]
	[FieldOffset(Offset = "0x200")]
	protected int currentAreaIdx;

	[Token(Token = "0x400FF7B")]
	[FieldOffset(Offset = "0x208")]
	private ExtendedTextMeshProUGUI TitleText;

	[Token(Token = "0x400FF7C")]
	[FieldOffset(Offset = "0x210")]
	private long myPcode;

	[Token(Token = "0x400FF7D")]
	[FieldOffset(Offset = "0x218")]
	private int myIconId;

	[Token(Token = "0x400FF7E")]
	[FieldOffset(Offset = "0x21C")]
	private int myFrameId;

	[Token(Token = "0x400FF7F")]
	[FieldOffset(Offset = "0x220")]
	private int DefaultThresholdNum;

	[Token(Token = "0x400FF80")]
	[FieldOffset(Offset = "0x224")]
	private bool isResult;

	[Token(Token = "0x17001BE2")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B92F")]
		[Address(RVA = "0x53C590", Offset = "0x53B790", VA = "0x18053C590", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B930")]
	[Address(RVA = "0x5370A0", Offset = "0x5362A0", VA = "0x1805370A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B931")]
	[Address(RVA = "0x537290", Offset = "0x536490", VA = "0x180537290", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B932")]
	[Address(RVA = "0x536310", Offset = "0x535510", VA = "0x180536310")]
	private void CallAPIDuelistCupRanking(int cid)
	{
	}

	[Token(Token = "0x600B933")]
	[Address(RVA = "0x536450", Offset = "0x535650", VA = "0x180536450")]
	private void CallAPI_WCSRanking(int wcs_id)
	{
	}

	[Token(Token = "0x600B934")]
	[Address(RVA = "0x5363B0", Offset = "0x5355B0", VA = "0x1805363B0")]
	private void CallAPI_RDCRanking(int rid)
	{
	}

	[Token(Token = "0x600B935")]
	[Address(RVA = "0x537DD0", Offset = "0x536FD0", VA = "0x180537DD0")]
	private void SetActiveFooterArea(bool active)
	{
	}

	[Token(Token = "0x600B936")]
	[Address(RVA = "0x5368B0", Offset = "0x535AB0", VA = "0x1805368B0")]
	private void InitRanking()
	{
	}

	[Token(Token = "0x600B937")]
	[Address(RVA = "0x53C730", Offset = "0x53B930", VA = "0x18053C730")]
	private void setFooterAreaCallBack()
	{
	}

	[Token(Token = "0x600B938")]
	[Address(RVA = "0x537190", Offset = "0x536390", VA = "0x180537190")]
	private void OnClickChangeArea()
	{
	}

	[Token(Token = "0x600B939")]
	[Address(RVA = "0x538E70", Offset = "0x538070", VA = "0x180538E70")]
	private void UpdateMyRanking()
	{
	}

	[Token(Token = "0x600B93A")]
	[Address(RVA = "0x53AA00", Offset = "0x539C00", VA = "0x18053AA00")]
	private void UpdateRanking(Dictionary<string, object> rankingList, bool isChangeRegion = false)
	{
	}

	[Token(Token = "0x600B93B")]
	[Address(RVA = "0x5377C0", Offset = "0x5369C0", VA = "0x1805377C0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B93C")]
	[Address(RVA = "0x537750", Offset = "0x536950", VA = "0x180537750")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x600B93D")]
	[Address(RVA = "0x536560", Offset = "0x535760", VA = "0x180536560")]
	protected string GetWinLoseText(Dictionary<string, object> dic)
	{
		return null;
	}

	[Token(Token = "0x600B93E")]
	[Address(RVA = "0x536720", Offset = "0x535920", VA = "0x180536720")]
	protected string GetWinLoseText(string win, string lose, string draw)
	{
		return null;
	}

	[Token(Token = "0x600B93F")]
	[Address(RVA = "0x5364F0", Offset = "0x5356F0", VA = "0x1805364F0")]
	protected string GetWinLoseTextFromNum(int win, int lose, int draw)
	{
		return null;
	}

	[Token(Token = "0x600B940")]
	[Address(RVA = "0x53C010", Offset = "0x53B210", VA = "0x18053C010")]
	public ColosseumRankingDuelistCupViewController()
	{
	}
}
