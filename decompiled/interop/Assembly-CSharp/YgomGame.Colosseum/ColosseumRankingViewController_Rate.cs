using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CA0")]
public class ColosseumRankingViewController_Rate : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001CA1")]
	internal class SeasonPlayerList
	{
		[Token(Token = "0x400FFF4")]
		[FieldOffset(Offset = "0x10")]
		internal string aggregate_time;

		[Token(Token = "0x400FFF5")]
		[FieldOffset(Offset = "0x18")]
		internal MyRateInfo myRateInfos;

		[Token(Token = "0x400FFF6")]
		[FieldOffset(Offset = "0x20")]
		internal List<ProfileInfo> profileInfos;

		[Token(Token = "0x600B983")]
		[Address(RVA = "0x5484C0", Offset = "0x5476C0", VA = "0x1805484C0")]
		public SeasonPlayerList(string aggregate_time, MyRateInfo myRateInfos, List<ProfileInfo> profileInfos)
		{
		}
	}

	[Token(Token = "0x2001CA2")]
	internal class MyRateInfo
	{
		[Token(Token = "0x400FFF7")]
		[FieldOffset(Offset = "0x10")]
		internal bool attendStatus;

		[Token(Token = "0x400FFF8")]
		[FieldOffset(Offset = "0x18")]
		internal string myRate;

		[Token(Token = "0x400FFF9")]
		[FieldOffset(Offset = "0x20")]
		internal string myDistribution;

		[Token(Token = "0x600B984")]
		[Address(RVA = "0x5465E0", Offset = "0x5457E0", VA = "0x1805465E0")]
		public MyRateInfo(bool attendStatus, string myRate, string myDistribution)
		{
		}
	}

	[Token(Token = "0x2001CA3")]
	internal class ProfileInfo
	{
		[Token(Token = "0x400FFFA")]
		[FieldOffset(Offset = "0x10")]
		internal long pcode;

		[Token(Token = "0x400FFFB")]
		[FieldOffset(Offset = "0x18")]
		internal int ranking;

		[Token(Token = "0x400FFFC")]
		[FieldOffset(Offset = "0x20")]
		internal string rate;

		[Token(Token = "0x400FFFD")]
		[FieldOffset(Offset = "0x28")]
		internal int icon_id;

		[Token(Token = "0x400FFFE")]
		[FieldOffset(Offset = "0x2C")]
		internal int icon_frame_id;

		[Token(Token = "0x400FFFF")]
		[FieldOffset(Offset = "0x30")]
		internal bool is_same_os;

		[Token(Token = "0x4010000")]
		[FieldOffset(Offset = "0x38")]
		internal string name;

		[Token(Token = "0x4010001")]
		[FieldOffset(Offset = "0x40")]
		internal string online_id;

		[Token(Token = "0x600B985")]
		[Address(RVA = "0x548100", Offset = "0x547300", VA = "0x180548100")]
		public ProfileInfo(long pcode, int ranking, string rate, int icon_id, int icon_frame_id, bool is_same_os, string name, string online_id)
		{
		}
	}

	[Token(Token = "0x400FFD2")]
	private const string k_PREF_PATH = "Colosseum/ColosseumRanking_Rate";

	[Token(Token = "0x400FFD3")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelTabGroup;

	[Token(Token = "0x400FFD4")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelSeasonTabs;

	[Token(Token = "0x400FFD5")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelRankingGroup;

	[Token(Token = "0x400FFD6")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelTemplateTab;

	[Token(Token = "0x400FFD7")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelTemplateRateData;

	[Token(Token = "0x400FFD8")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelTextDate;

	[Token(Token = "0x400FFD9")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelShortcutButtonRarityBack;

	[Token(Token = "0x400FFDA")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelShortcutButtonRarityNext;

	[Token(Token = "0x400FFDB")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelSubTitleArea;

	[Token(Token = "0x400FFDC")]
	[FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelMyDataArea;

	[Token(Token = "0x400FFDD")]
	[FieldOffset(Offset = "0x120")]
	private readonly string k_ELabelRankingArea;

	[Token(Token = "0x400FFDE")]
	[FieldOffset(Offset = "0x128")]
	private readonly string k_ELabelTabPrefabsTextOn;

	[Token(Token = "0x400FFDF")]
	[FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelTabPrefabsTextOff;

	[Token(Token = "0x400FFE0")]
	[FieldOffset(Offset = "0x138")]
	private readonly string k_ELabelTabPrefabsTextOrder;

	[Token(Token = "0x400FFE1")]
	[FieldOffset(Offset = "0x140")]
	private readonly string k_ELabelTabPrefabsTextScore;

	[Token(Token = "0x400FFE2")]
	[FieldOffset(Offset = "0x148")]
	private readonly string k_ELabelMyDataTextRate;

	[Token(Token = "0x400FFE3")]
	[FieldOffset(Offset = "0x150")]
	private readonly string k_ELabelMyDataTextTop;

	[Token(Token = "0x400FFE4")]
	[FieldOffset(Offset = "0x158")]
	private readonly string k_ELabelMyDataTopGroup;

	[Token(Token = "0x400FFE5")]
	[FieldOffset(Offset = "0x160")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400FFE6")]
	[FieldOffset(Offset = "0x168")]
	private readonly string TMP_BTN_LABEL;

	[Token(Token = "0x400FFE7")]
	[FieldOffset(Offset = "0x170")]
	private readonly string IMG_ARROW_LABEL;

	[Token(Token = "0x400FFE8")]
	[FieldOffset(Offset = "0x178")]
	private readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x400FFE9")]
	[FieldOffset(Offset = "0x180")]
	private readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x400FFEA")]
	[FieldOffset(Offset = "0x188")]
	private DirectionalTabGroup m_TabGroup;

	[Token(Token = "0x400FFEB")]
	[FieldOffset(Offset = "0x190")]
	private MyRateInfo myRateInfos;

	[Token(Token = "0x400FFEC")]
	[FieldOffset(Offset = "0x198")]
	private List<ProfileInfo> profileList;

	[Token(Token = "0x400FFED")]
	[FieldOffset(Offset = "0x1A0")]
	private GameObject[] templatePlayers;

	[Token(Token = "0x400FFEE")]
	[FieldOffset(Offset = "0x1A8")]
	private List<SeasonPlayerList> seasonPlayerList;

	[Token(Token = "0x400FFEF")]
	[FieldOffset(Offset = "0x1B0")]
	private int tabCount;

	[Token(Token = "0x400FFF0")]
	[FieldOffset(Offset = "0x1B4")]
	private int initMember;

	[Token(Token = "0x400FFF1")]
	[FieldOffset(Offset = "0x1B8")]
	private int seasonId;

	[Token(Token = "0x400FFF2")]
	[FieldOffset(Offset = "0x1C0")]
	private readonly string rateHyphen;

	[Token(Token = "0x400FFF3")]
	[FieldOffset(Offset = "0x1C8")]
	private readonly string topHyphen;

	[Token(Token = "0x17001BE4")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600B975")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600B976")]
	[Address(RVA = "0x53FFF0", Offset = "0x53F1F0", VA = "0x18053FFF0")]
	public static void Open(ViewControllerManager vcm, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600B977")]
	[Address(RVA = "0x53F880", Offset = "0x53EA80", VA = "0x18053F880", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B978")]
	[Address(RVA = "0x53F970", Offset = "0x53EB70", VA = "0x18053F970", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B979")]
	[Address(RVA = "0x540200", Offset = "0x53F400", VA = "0x180540200")]
	private void Start()
	{
	}

	[Token(Token = "0x600B97A")]
	[Address(RVA = "0x540560", Offset = "0x53F760", VA = "0x180540560")]
	private void UpdateListDisplay()
	{
	}

	[Token(Token = "0x600B97B")]
	[Address(RVA = "0x53F3F0", Offset = "0x53E5F0", VA = "0x18053F3F0")]
	private void CreateTab(ElementObjectManager eom, Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x600B97C")]
	[Address(RVA = "0x53E4D0", Offset = "0x53D6D0", VA = "0x18053E4D0")]
	private void CreatePlayerList(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x600B97D")]
	[Address(RVA = "0x540050", Offset = "0x53F250", VA = "0x180540050")]
	private void SetMyIcon()
	{
	}

	[Token(Token = "0x600B97E")]
	[Address(RVA = "0x53E430", Offset = "0x53D630", VA = "0x18053E430")]
	private void CallGetRankingAPI()
	{
	}

	[Token(Token = "0x600B97F")]
	[Address(RVA = "0x540F30", Offset = "0x540130", VA = "0x180540F30")]
	public ColosseumRankingViewController_Rate()
	{
	}
}
