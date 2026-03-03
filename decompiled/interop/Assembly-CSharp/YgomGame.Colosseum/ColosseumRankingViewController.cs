using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001C9B")]
public class ColosseumRankingViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001C9C")]
	protected class RankingTemplate
	{
		[Token(Token = "0x400FFBB")]
		[FieldOffset(Offset = "0x10")]
		public readonly long pcode;

		[Token(Token = "0x400FFBC")]
		[FieldOffset(Offset = "0x18")]
		public readonly string name;

		[Token(Token = "0x400FFBD")]
		[FieldOffset(Offset = "0x20")]
		public readonly int order;

		[Token(Token = "0x400FFBE")]
		[FieldOffset(Offset = "0x24")]
		public readonly int iconID;

		[Token(Token = "0x400FFBF")]
		[FieldOffset(Offset = "0x28")]
		public readonly int frameID;

		[Token(Token = "0x400FFC0")]
		[FieldOffset(Offset = "0x2C")]
		public readonly int rank;

		[Token(Token = "0x400FFC1")]
		[FieldOffset(Offset = "0x30")]
		public readonly int tier;

		[Token(Token = "0x400FFC2")]
		[FieldOffset(Offset = "0x34")]
		public readonly int score;

		[Token(Token = "0x400FFC3")]
		[FieldOffset(Offset = "0x38")]
		public readonly int win;

		[Token(Token = "0x400FFC4")]
		[FieldOffset(Offset = "0x3C")]
		public readonly int lose;

		[Token(Token = "0x400FFC5")]
		[FieldOffset(Offset = "0x40")]
		public readonly int draw;

		[Token(Token = "0x400FFC6")]
		[FieldOffset(Offset = "0x44")]
		public readonly bool isResistedPlatform;

		[Token(Token = "0x400FFC7")]
		[FieldOffset(Offset = "0x45")]
		public readonly bool isSamePlatform;

		[Token(Token = "0x400FFC8")]
		[FieldOffset(Offset = "0x48")]
		public readonly string platformName;

		[Token(Token = "0x600B96A")]
		[Address(RVA = "0x548380", Offset = "0x547580", VA = "0x180548380")]
		private RankingTemplate(long pcode, string name, int order, int iconID, int frameID, int rank, int tier, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
		{
		}

		[Token(Token = "0x600B96B")]
		[Address(RVA = "0x548420", Offset = "0x547620", VA = "0x180548420")]
		public RankingTemplate(long pcode, string name, int order, int iconID, int frameID, int rank, int tier, int score, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
		{
		}

		[Token(Token = "0x600B96C")]
		[Address(RVA = "0x5482C0", Offset = "0x5474C0", VA = "0x1805482C0")]
		public RankingTemplate(long pcode, string name, int order, int iconID, int frameID, int rank, int tier, int win, int lose, int draw, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
		{
		}
	}

	[Token(Token = "0x400FFA2")]
	[FieldOffset(Offset = "0xD0")]
	protected readonly string ROOT_MYORDER_LABEL;

	[Token(Token = "0x400FFA3")]
	[FieldOffset(Offset = "0xD8")]
	protected readonly string ROOT_RANK1_LABEL;

	[Token(Token = "0x400FFA4")]
	[FieldOffset(Offset = "0xE0")]
	protected readonly string ROOT_RANK2_LABEL;

	[Token(Token = "0x400FFA5")]
	[FieldOffset(Offset = "0xE8")]
	protected readonly string ROOT_RANK3_LABEL;

	[Token(Token = "0x400FFA6")]
	[FieldOffset(Offset = "0xF0")]
	protected readonly string SCROLL_RANKING_LABEL;

	[Token(Token = "0x400FFA7")]
	[FieldOffset(Offset = "0xF8")]
	protected readonly string BUTTON_LABEL;

	[Token(Token = "0x400FFA8")]
	[FieldOffset(Offset = "0x100")]
	protected readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400FFA9")]
	[FieldOffset(Offset = "0x108")]
	protected readonly string IMG_RANK_LABEL;

	[Token(Token = "0x400FFAA")]
	[FieldOffset(Offset = "0x110")]
	protected readonly string IMG_ARROW_LABEL;

	[Token(Token = "0x400FFAB")]
	[FieldOffset(Offset = "0x118")]
	protected readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x400FFAC")]
	[FieldOffset(Offset = "0x120")]
	protected readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x400FFAD")]
	[FieldOffset(Offset = "0x128")]
	protected readonly string TXT_ORDER_LABEL;

	[Token(Token = "0x400FFAE")]
	[FieldOffset(Offset = "0x130")]
	protected readonly string TXT_SCORE_LABEL;

	[Token(Token = "0x400FFAF")]
	[FieldOffset(Offset = "0x138")]
	protected readonly string TXT_LOW_RANK_LABEL;

	[Token(Token = "0x400FFB0")]
	[FieldOffset(Offset = "0x140")]
	protected int TOP_RANK;

	[Token(Token = "0x400FFB1")]
	[FieldOffset(Offset = "0x148")]
	protected InfinityScrollView isv;

	[Token(Token = "0x400FFB2")]
	[FieldOffset(Offset = "0x150")]
	protected ElementObjectManager rootMyOrder;

	[Token(Token = "0x400FFB3")]
	[FieldOffset(Offset = "0x158")]
	protected List<ElementObjectManager> rootRanks;

	[Token(Token = "0x400FFB4")]
	[FieldOffset(Offset = "0x160")]
	protected int tid;

	[Token(Token = "0x400FFB5")]
	[FieldOffset(Offset = "0x164")]
	protected ColosseumUtil.RankingType type;

	[Token(Token = "0x400FFB6")]
	[FieldOffset(Offset = "0x168")]
	protected Util.GameMode mode;

	[Token(Token = "0x400FFB7")]
	[FieldOffset(Offset = "0x170")]
	protected List<RankingTemplate> rankingTemplates;

	[Token(Token = "0x400FFB8")]
	[FieldOffset(Offset = "0x178")]
	private long myPcode;

	[Token(Token = "0x400FFB9")]
	[FieldOffset(Offset = "0x180")]
	private int myIconId;

	[Token(Token = "0x400FFBA")]
	[FieldOffset(Offset = "0x184")]
	private int myFrameId;

	[Token(Token = "0x17001BE3")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B959")]
		[Address(RVA = "0x543460", Offset = "0x542660", VA = "0x180543460", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B95A")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B95B")]
	[Address(RVA = "0x53D470", Offset = "0x53C670", VA = "0x18053D470", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B95C")]
	[Address(RVA = "0x53CCB0", Offset = "0x53BEB0", VA = "0x18053CCB0")]
	private void CallAPIChallengeRanking()
	{
	}

	[Token(Token = "0x600B95D")]
	[Address(RVA = "0x53CD80", Offset = "0x53BF80", VA = "0x18053CD80")]
	private void CallAPITournamentRanking()
	{
	}

	[Token(Token = "0x600B95E")]
	[Address(RVA = "0x53D1E0", Offset = "0x53C3E0", VA = "0x18053D1E0")]
	private void InitRanking()
	{
	}

	[Token(Token = "0x600B95F")]
	[Address(RVA = "0x541790", Offset = "0x540990", VA = "0x180541790")]
	private void UpdateRanking(List<object> rankingList)
	{
	}

	[Token(Token = "0x600B960")]
	[Address(RVA = "0x53DCC0", Offset = "0x53CEC0", VA = "0x18053DCC0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B961")]
	[Address(RVA = "0x53DC50", Offset = "0x53CE50", VA = "0x18053DC50")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x600B962")]
	[Address(RVA = "0x53D020", Offset = "0x53C220", VA = "0x18053D020")]
	protected string GetWinLoseText(Dictionary<string, object> dic)
	{
		return null;
	}

	[Token(Token = "0x600B963")]
	[Address(RVA = "0x53CE90", Offset = "0x53C090", VA = "0x18053CE90")]
	protected string GetWinLoseText(string win, string lose, string draw)
	{
		return null;
	}

	[Token(Token = "0x600B964")]
	[Address(RVA = "0x53CE20", Offset = "0x53C020", VA = "0x18053CE20")]
	protected string GetWinLoseTextFromNum(int win, int lose, int draw)
	{
		return null;
	}

	[Token(Token = "0x600B965")]
	[Address(RVA = "0x5431A0", Offset = "0x5423A0", VA = "0x1805431A0")]
	public ColosseumRankingViewController()
	{
	}
}
