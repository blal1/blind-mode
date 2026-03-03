using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Home;
using YgomGame.MDMarkup;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu;

[Token(Token = "0x20012C7")]
public class HomeViewController : BaseMenuViewController, ICommonHeaderSupported, IGemSupported, IConfigButtonSupported, IFadeSupported, IHeaderFocusListener, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x20012C8")]
	private class TopicsContext
	{
		[Token(Token = "0x400BD91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<MDMarkupBannerContext> m_MMABannerContexts;

		[Token(Token = "0x400BD92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<string> m_MMAPageBodies;

		[Token(Token = "0x400BD93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MDMarkupPagerContainer m_MMAPagerContainer;

		[Token(Token = "0x400BD94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_MMAPagerDirty;

		[Token(Token = "0x17001262")]
		public List<MDMarkupBannerContext> mmaBannerContexts
		{
			[Token(Token = "0x60074F8")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60074F9")]
		[Address(RVA = "0xBCC600", Offset = "0xBCB800", VA = "0x180BCC600")]
		public void Import(List<object> topicList)
		{
		}

		[Token(Token = "0x60074FA")]
		[Address(RVA = "0xBCC170", Offset = "0xBCB370", VA = "0x180BCC170")]
		public MDMarkupPagerContainer CreateOrReuseMMAPagerContainer()
		{
			return null;
		}

		[Token(Token = "0x60074FB")]
		[Address(RVA = "0xBCC460", Offset = "0xBCB660", VA = "0x180BCC460")]
		public string GetButtonUrl(int index)
		{
			return null;
		}

		[Token(Token = "0x60074FC")]
		[Address(RVA = "0xBCC8C0", Offset = "0xBCBAC0", VA = "0x180BCC8C0")]
		public TopicsContext()
		{
		}
	}

	[Token(Token = "0x400BD53")]
	public const string PREFAB_PATH = "Home/Home";

	[Token(Token = "0x400BD54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BANNER_LABEL;

	[Token(Token = "0x400BD55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BTN_BANNER_LABEL;

	[Token(Token = "0x400BD56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string BTN_NEXT_LABEL;

	[Token(Token = "0x400BD57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string BTN_PREV_LABEL;

	[Token(Token = "0x400BD58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400BD59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TEMPLATE_LABEL;

	[Token(Token = "0x400BD5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string BTN_QUEST_LABEL;

	[Token(Token = "0x400BD5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string BTN_SHOP_LABEL;

	[Token(Token = "0x400BD5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string BTN_DECK_LABEL;

	[Token(Token = "0x400BD5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string BTN_DUEL_LABEL;

	[Token(Token = "0x400BD5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string BTN_PLAYER_LABEL;

	[Token(Token = "0x400BD5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string IMG_LEVEL_LABEL;

	[Token(Token = "0x400BD60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string IMG_RANK_LABEL;

	[Token(Token = "0x400BD61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string IMG_CERTIFICATION_LABEL;

	[Token(Token = "0x400BD62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400BD63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x400BD64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string TXT_LEVEL_LABEL;

	[Token(Token = "0x400BD65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string ROOT_MENU_LABEL;

	[Token(Token = "0x400BD66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string ROOT_WALLPAPER_LABEL;

	[Token(Token = "0x400BD67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string WALLPAPER_LABEL;

	[Token(Token = "0x400BD68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string ROOT_PAGE_LABEL;

	[Token(Token = "0x400BD69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string ROOT_INDICATOR_LABEL;

	[Token(Token = "0x400BD6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string BTN_BACKKEYSHORTCUT_LABEL;

	[Token(Token = "0x400BD6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string E_SpecialBanner;

	[Token(Token = "0x400BD6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string E_TdyBanner;

	[Token(Token = "0x400BD6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string E_Image;

	[Token(Token = "0x400BD6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly string k_EDuelShortcut;

	[Token(Token = "0x400BD6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private readonly string k_EMissionBanner;

	[Token(Token = "0x400BD70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private readonly string k_EIconGroup;

	[Token(Token = "0x400BD71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private readonly string k_ETextTitle;

	[Token(Token = "0x400BD72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private readonly string k_ETextBody;

	[Token(Token = "0x400BD73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private readonly string k_EImageMission;

	[Token(Token = "0x400BD74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private readonly string k_EImagePanelMission;

	[Token(Token = "0x400BD75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private bool shouldCallAPIHome;

	[Token(Token = "0x400BD76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
	private bool isDirtyPlayHomeAction;

	[Token(Token = "0x400BD77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private readonly string homeBGMLabel;

	[Token(Token = "0x400BD78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private List<GameObject> topicPages;

	[Token(Token = "0x400BD79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private float pastSecTopics;

	[Token(Token = "0x400BD7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float pastSecEventNotify;

	[Token(Token = "0x400BD7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private int currentWallpaperID;

	[Token(Token = "0x400BD7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private GameObject currentWallpaperGo;

	[Token(Token = "0x400BD7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private bool isFirstFade;

	[Token(Token = "0x400BD7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x209")]
	private bool calledDispProgress;

	[Token(Token = "0x400BD7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private HomeBadge homeBadge;

	[Token(Token = "0x400BD80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private readonly HomePopIconWidget popIconWidget;

	[Token(Token = "0x400BD81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private ElementObjectManager menuBtnEom;

	[Token(Token = "0x400BD82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	[SerializeField]
	private float shortcutBtnTweenStartTime;

	[Token(Token = "0x400BD83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private float pastShortcutBtn;

	[Token(Token = "0x400BD84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private GameObject bannerGroup;

	[Token(Token = "0x400BD85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private TweenAlphaTo alphaToShowBannerGroup;

	[Token(Token = "0x400BD86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private TweenAlphaTo alphaToHideBannerGroup;

	[Token(Token = "0x400BD87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private List<SelectionItem> bannerGroupBtns;

	[Token(Token = "0x400BD88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private SelectionButton duelShortcutBtn;

	[Token(Token = "0x400BD89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private bool isHideDuelSCBtn;

	[Token(Token = "0x400BD8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private SlidePagerWidget slidePagerWidget;

	[Token(Token = "0x400BD8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private List<HomeAction> actionList;

	[Token(Token = "0x400BD8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private TopicsContext m_TopicsContext;

	[Token(Token = "0x400BD8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private int roomId;

	[Token(Token = "0x400BD8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	private bool isInviteRoom;

	[Token(Token = "0x400BD8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private int teamId;

	[Token(Token = "0x400BD90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private bool isInviteTeam;

	[Token(Token = "0x1700125E")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60074A4")]
		[Address(RVA = "0xBB32A0", Offset = "0xBB24A0", VA = "0x180BB32A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700125F")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60074A5")]
		[Address(RVA = "0xBB31D0", Offset = "0xBB23D0", VA = "0x180BB31D0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001260")]
	public bool ShouldCallAPIHome
	{
		[Token(Token = "0x60074A6")]
		[Address(RVA = "0x6B8890", Offset = "0x6B7A90", VA = "0x1806B8890")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60074A7")]
		[Address(RVA = "0x6B8B70", Offset = "0x6B7D70", VA = "0x1806B8B70")]
		private set
		{
		}
	}

	[Token(Token = "0x17001261")]
	public bool IsDirtyPlayHomeAction
	{
		[Token(Token = "0x60074A8")]
		[Address(RVA = "0xBB31C0", Offset = "0xBB23C0", VA = "0x180BB31C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60074A9")]
		[Address(RVA = "0xBB3670", Offset = "0xBB2870", VA = "0x180BB3670")]
		private set
		{
		}
	}

	[Token(Token = "0x60074AA")]
	public static bool PushOnHomeViewControlerParam<T>(string prefabname, T parameter) where T : class
	{
		return default(bool);
	}

	[Token(Token = "0x60074AB")]
	[Address(RVA = "0xBAB640", Offset = "0xBAA840", VA = "0x180BAB640")]
	public static bool PushOnHomeViewControler(string prefabname, [Optional] Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x60074AC")]
	[Address(RVA = "0xBAB960", Offset = "0xBAAB60", VA = "0x180BAB960")]
	public static void SetIsDirtyHomeUpdate(bool shouldCallAPIHome = false)
	{
	}

	[Token(Token = "0x60074AD")]
	[Address(RVA = "0xBA8F60", Offset = "0xBA8160", VA = "0x180BA8F60", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60074AE")]
	[Address(RVA = "0xBA8BD0", Offset = "0xBA7DD0", VA = "0x180BA8BD0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60074AF")]
	[Address(RVA = "0xBA8DF0", Offset = "0xBA7FF0", VA = "0x180BA8DF0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60074B0")]
	[Address(RVA = "0xBAD190", Offset = "0xBAC390", VA = "0x180BAD190", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60074B1")]
	[Address(RVA = "0xBAADE0", Offset = "0xBA9FE0", VA = "0x180BAADE0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60074B2")]
	[Address(RVA = "0xBAAD80", Offset = "0xBA9F80", VA = "0x180BAAD80", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x60074B3")]
	[Address(RVA = "0xBAD2A0", Offset = "0xBAC4A0", VA = "0x180BAD2A0", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60074B4")]
	[Address(RVA = "0xBAAAA0", Offset = "0xBA9CA0", VA = "0x180BAAAA0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x60074B5")]
	[Address(RVA = "0xBAAC10", Offset = "0xBA9E10", VA = "0x180BAAC10", Slot = "30")]
	public void OnHeaderFocusChanged(bool setfocus, ViewController focusVc, ViewController prevVc)
	{
	}

	[Token(Token = "0x60074B6")]
	[Address(RVA = "0xBA77F0", Offset = "0xBA69F0", VA = "0x180BA77F0", Slot = "28")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x60074B7")]
	[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "29")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x60074B8")]
	[Address(RVA = "0xBAD0E0", Offset = "0xBAC2E0", VA = "0x180BAD0E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60074B9")]
	[Address(RVA = "0xBB24D0", Offset = "0xBB16D0", VA = "0x180BB24D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60074BA")]
	[Address(RVA = "0xBA8B30", Offset = "0xBA7D30", VA = "0x180BA8B30")]
	private bool IsReadyPlayHomeAction()
	{
		return default(bool);
	}

	[Token(Token = "0x60074BB")]
	[Address(RVA = "0xBAB3B0", Offset = "0xBAA5B0", VA = "0x180BAB3B0")]
	private void PlayHomeAction()
	{
	}

	[Token(Token = "0x60074BC")]
	[Address(RVA = "0xBA9800", Offset = "0xBA8A00", VA = "0x180BA9800", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60074BD")]
	[Address(RVA = "0xBAB7A0", Offset = "0xBAA9A0", VA = "0x180BAB7A0")]
	private void SetHeaderTransition(SelectionButton btn, SelectionButton targetBtn, SelectionButton failedBtn)
	{
	}

	[Token(Token = "0x60074BE")]
	[Address(RVA = "0xBB03E0", Offset = "0xBAF5E0", VA = "0x180BB03E0")]
	private void UpdateGamePadTransition()
	{
	}

	[Token(Token = "0x60074BF")]
	[Address(RVA = "0xBA5BC0", Offset = "0xBA4DC0", VA = "0x180BA5BC0")]
	private void AddInputCallback(SelectionButton button, PadInputDirection direction, SelectionButton target, [Optional] SelectionButton failedTarget)
	{
	}

	[Token(Token = "0x60074C0")]
	[Address(RVA = "0xBA9150", Offset = "0xBA8350", VA = "0x180BA9150")]
	private void OnCreatedAction()
	{
	}

	[Token(Token = "0x60074C1")]
	[Address(RVA = "0xBA8510", Offset = "0xBA7710", VA = "0x180BA8510")]
	private void InvitePlatform()
	{
	}

	[Token(Token = "0x60074C2")]
	[Address(RVA = "0xBA87E0", Offset = "0xBA79E0", VA = "0x180BA87E0")]
	private void InviteRoomNotificator(object mes)
	{
	}

	[Token(Token = "0x60074C3")]
	[Address(RVA = "0xBA8840", Offset = "0xBA7A40", VA = "0x180BA8840")]
	private void InviteTeamNotificator(object mes)
	{
	}

	[Token(Token = "0x60074C4")]
	[Address(RVA = "0xBA7090", Offset = "0xBA6290", VA = "0x180BA7090")]
	private void CheckParticipationConfirm()
	{
	}

	[Token(Token = "0x60074C5")]
	[Address(RVA = "0xBA7500", Offset = "0xBA6700", VA = "0x180BA7500")]
	private void CheckWcsRightsHolderRemind()
	{
	}

	[Token(Token = "0x60074C6")]
	[Address(RVA = "0xBA7350", Offset = "0xBA6550", VA = "0x180BA7350")]
	private void CheckWcsDeckRegistRemind()
	{
	}

	[Token(Token = "0x60074C7")]
	[Address(RVA = "0xBA6C00", Offset = "0xBA5E00", VA = "0x180BA6C00")]
	private void CheckLotteryResult()
	{
	}

	[Token(Token = "0x60074C8")]
	[Address(RVA = "0xBACD20", Offset = "0xBABF20", VA = "0x180BACD20")]
	private void ShouldCallAPILoginBonus([Optional] Action onFinish)
	{
	}

	[Token(Token = "0x60074C9")]
	[Address(RVA = "0xBA6990", Offset = "0xBA5B90", VA = "0x180BA6990")]
	private void CheckLoginBonus()
	{
	}

	[Token(Token = "0x60074CA")]
	[Address(RVA = "0xBA6460", Offset = "0xBA5660", VA = "0x180BA6460")]
	private void CheckAnnounce()
	{
	}

	[Token(Token = "0x60074CB")]
	[Address(RVA = "0xBA71C0", Offset = "0xBA63C0", VA = "0x180BA71C0")]
	private void CheckTdyChainEffect()
	{
	}

	[Token(Token = "0x60074CC")]
	[Address(RVA = "0xBA6620", Offset = "0xBA5820", VA = "0x180BA6620")]
	private void CheckForcePanelMission()
	{
	}

	[Token(Token = "0x60074CD")]
	[Address(RVA = "0xBB0BE0", Offset = "0xBAFDE0", VA = "0x180BB0BE0")]
	private void UpdateHome()
	{
	}

	[Token(Token = "0x60074CE")]
	[Address(RVA = "0xBAE400", Offset = "0xBAD600", VA = "0x180BAE400")]
	private void UpdateDuelShortcut()
	{
	}

	[Token(Token = "0x60074CF")]
	[Address(RVA = "0xBAE480", Offset = "0xBAD680", VA = "0x180BAE480")]
	private void UpdateDuelpass()
	{
	}

	[Token(Token = "0x60074D0")]
	[Address(RVA = "0xBB21B0", Offset = "0xBB13B0", VA = "0x180BB21B0")]
	private bool UpdateWcsf()
	{
		return default(bool);
	}

	[Token(Token = "0x60074D1")]
	[Address(RVA = "0xBB1B10", Offset = "0xBB0D10", VA = "0x180BB1B10")]
	private void UpdateTdy()
	{
	}

	[Token(Token = "0x60074D2")]
	[Address(RVA = "0xBB00C0", Offset = "0xBAF2C0", VA = "0x180BB00C0")]
	private bool UpdateEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x60074D3")]
	[Address(RVA = "0xBA83C0", Offset = "0xBA75C0", VA = "0x180BA83C0")]
	private void InitPopIcons()
	{
	}

	[Token(Token = "0x60074D4")]
	[Address(RVA = "0xBB1750", Offset = "0xBB0950", VA = "0x180BB1750")]
	private void UpdatePopIcons()
	{
	}

	[Token(Token = "0x60074D5")]
	[Address(RVA = "0xBB1F70", Offset = "0xBB1170", VA = "0x180BB1F70")]
	private void UpdateWallpaper()
	{
	}

	[Token(Token = "0x60074D6")]
	[Address(RVA = "0xBACC10", Offset = "0xBABE10", VA = "0x180BACC10")]
	private void SetupWCSFinalWallpaper()
	{
	}

	[Token(Token = "0x60074D7")]
	[Address(RVA = "0xBB3510", Offset = "0xBB2710", VA = "0x180BB3510")]
	private void onWallPaperCreated(GameObject go)
	{
	}

	[Token(Token = "0x60074D8")]
	[Address(RVA = "0xBAFBD0", Offset = "0xBAEDD0", VA = "0x180BAFBD0")]
	private void UpdateEventNotify()
	{
	}

	[Token(Token = "0x60074D9")]
	[Address(RVA = "0xBA7810", Offset = "0xBA6A10", VA = "0x180BA7810")]
	private void InitBadgeSettings()
	{
	}

	[Token(Token = "0x60074DA")]
	[Address(RVA = "0xBADD40", Offset = "0xBACF40", VA = "0x180BADD40")]
	private void UpdateBadge()
	{
	}

	[Token(Token = "0x60074DB")]
	[Address(RVA = "0xBACEC0", Offset = "0xBAC0C0", VA = "0x180BACEC0")]
	private void ShowShortcutGroup()
	{
	}

	[Token(Token = "0x60074DC")]
	[Address(RVA = "0xBAB130", Offset = "0xBAA330", VA = "0x180BAB130")]
	private void OpenTopicsList()
	{
	}

	[Token(Token = "0x60074DD")]
	[Address(RVA = "0xBB1F10", Offset = "0xBB1110", VA = "0x180BB1F10")]
	private void UpdateTopics()
	{
	}

	[Token(Token = "0x60074DE")]
	[Address(RVA = "0xBABD70", Offset = "0xBAAF70", VA = "0x180BABD70")]
	private void SetTopicsData(List<object> topicsList)
	{
	}

	[Token(Token = "0x60074DF")]
	[Address(RVA = "0xBABA20", Offset = "0xBAAC20", VA = "0x180BABA20")]
	private void SetTopicsButton()
	{
	}

	[Token(Token = "0x60074E0")]
	[Address(RVA = "0xBA7660", Offset = "0xBA6860", VA = "0x180BA7660")]
	private GameObject CreateTopics(MDMarkupBannerContext context)
	{
		return null;
	}

	[Token(Token = "0x60074E1")]
	[Address(RVA = "0xBA6240", Offset = "0xBA5440", VA = "0x180BA6240")]
	private void CallAPIUserHome([Optional] Action onSuccessed)
	{
	}

	[Token(Token = "0x60074E2")]
	[Address(RVA = "0xBA5D00", Offset = "0xBA4F00", VA = "0x180BA5D00")]
	private void CallAPIEventNotifyGetList([Optional] Action onFinished)
	{
	}

	[Token(Token = "0x60074E3")]
	[Address(RVA = "0xBA5F90", Offset = "0xBA5190", VA = "0x180BA5F90")]
	private void CallAPIRoomEntry(int invitedRoomId, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x60074E4")]
	[Address(RVA = "0x8D0040", Offset = "0x8CF240", VA = "0x1808D0040")]
	private Handle APIRoomEntry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
	{
		return null;
	}

	[Token(Token = "0x60074E5")]
	[Address(RVA = "0xBA5E50", Offset = "0xBA5050", VA = "0x180BA5E50")]
	private void CallAPILoginBonusGetList([Optional] Action onFinish)
	{
	}

	[Token(Token = "0x60074E6")]
	[Address(RVA = "0xBA6370", Offset = "0xBA5570", VA = "0x180BA6370")]
	private void CallAPIWcsGetParticipation([Optional] Action onFinished)
	{
	}

	[Token(Token = "0x60074E7")]
	[Address(RVA = "0xBA6140", Offset = "0xBA5340", VA = "0x180BA6140")]
	private void CallAPIUpdateDemandStatus(int id, [Optional] Action onFinished)
	{
	}

	[Token(Token = "0x60074E8")]
	[Address(RVA = "0xBA88A0", Offset = "0xBA7AA0", VA = "0x180BA88A0", Slot = "31")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x60074E9")]
	[Address(RVA = "0xBB2AB0", Offset = "0xBB1CB0", VA = "0x180BB2AB0")]
	public HomeViewController()
	{
	}
}
