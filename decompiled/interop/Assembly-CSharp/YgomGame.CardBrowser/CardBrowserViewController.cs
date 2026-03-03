using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardBrowser;

[Token(Token = "0x20015C9")]
public class CardBrowserViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x20015CA")]
	private class CardContext
	{
		[Token(Token = "0x400CF24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int mrk;

		[Token(Token = "0x400CF25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly int styleId;

		[Token(Token = "0x400CF26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string cardBottomText;

		[Token(Token = "0x400CF27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string appendBottomText;

		[Token(Token = "0x400CF28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int overrideRarity;

		[Token(Token = "0x400CF29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int overrideLimitState;

		[Token(Token = "0x400CF2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int overridePrevLimitState;

		[Token(Token = "0x400CF2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool showNoneLimitState;

		[Token(Token = "0x400CF2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool showPrevLimitState;

		[Token(Token = "0x400CF2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool showExpandState;

		[Token(Token = "0x400CF2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool monochromeState;

		[Token(Token = "0x400CF2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool createState;

		[Token(Token = "0x400CF30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool howToGetState;

		[Token(Token = "0x400CF31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool playState;

		[Token(Token = "0x6008747")]
		[Address(RVA = "0xD07DE0", Offset = "0xD06FE0", VA = "0x180D07DE0")]
		public CardContext(int mrk, int styleId)
		{
		}
	}

	[Token(Token = "0x20015CB")]
	private class CardDetailWidget
	{
		[Token(Token = "0x400CF32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string k_ELabelBackButton;

		[Token(Token = "0x400CF33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string k_ELabelCardNameText;

		[Token(Token = "0x400CF34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelDescText;

		[Token(Token = "0x400CF35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelPendulumDescText;

		[Token(Token = "0x400CF36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string k_ELabelCardNameScroll;

		[Token(Token = "0x400CF37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string k_ELabelDescScroll;

		[Token(Token = "0x400CF38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string k_ELabelDescPendulumScroll;

		[Token(Token = "0x400CF39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string k_ELabelRarityIcon;

		[Token(Token = "0x400CF3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string k_ELabelLimitIcon;

		[Token(Token = "0x400CF3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string k_ELabelLimitFromToGroup;

		[Token(Token = "0x400CF3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly string k_ELabelRelativeCardButton;

		[Token(Token = "0x400CF3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string k_ELabelCardBottomText;

		[Token(Token = "0x400CF3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string k_ELabelImageCard;

		[Token(Token = "0x400CF3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly string k_ELabelCPGroup;

		[Token(Token = "0x400CF40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly string k_ELabelCPText;

		[Token(Token = "0x400CF41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly string k_ELabelCPIcon;

		[Token(Token = "0x400CF42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly string k_ELabelCreateText;

		[Token(Token = "0x400CF43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly string k_ELabelCreateEnabledIcon;

		[Token(Token = "0x400CF44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly string k_ELabelCreateDisabledIcon;

		[Token(Token = "0x400CF45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly string k_ELabelCreateButtonConsole;

		[Token(Token = "0x400CF46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly string k_ELabelCreateButtonMobile;

		[Token(Token = "0x400CF47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly string k_ELabelHowToGetButton;

		[Token(Token = "0x400CF48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly string k_ELabelPlayButton;

		[Token(Token = "0x400CF49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly string k_ELabelStatusArea;

		[Token(Token = "0x400CF4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly string k_ELabelViewerArea;

		[Token(Token = "0x400CF4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public readonly ElementObjectManager eom;

		[Token(Token = "0x400CF4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public readonly ElementObjectManager createEom;

		[Token(Token = "0x400CF4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public readonly CardInfoDetail cardInfoDetail;

		[Token(Token = "0x400CF4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public readonly RubyTextGX cardNameText;

		[Token(Token = "0x400CF4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly TextMeshProUGUI descText;

		[Token(Token = "0x400CF50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public readonly TextMeshProUGUI pendulumDescText;

		[Token(Token = "0x400CF51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public readonly TextMeshProUGUI cpText;

		[Token(Token = "0x400CF52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public readonly TextMeshProUGUI createText;

		[Token(Token = "0x400CF53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public readonly Image cpIcon;

		[Token(Token = "0x400CF54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public readonly ScrollRect nameScrollRect;

		[Token(Token = "0x400CF55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public readonly ScrollRect descScrollRect;

		[Token(Token = "0x400CF56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public readonly ScrollRect pendulumDescScrollRect;

		[Token(Token = "0x400CF57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public readonly GameObject createCPGroup;

		[Token(Token = "0x400CF58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public readonly GameObject iconCreateEnabled;

		[Token(Token = "0x400CF59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public readonly GameObject iconCreateDisabled;

		[Token(Token = "0x400CF5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public readonly TMP_Text cardBottomText;

		[Token(Token = "0x400CF5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public readonly SelectionButton relativeCardButton;

		[Token(Token = "0x400CF5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public readonly SelectionButton createButton;

		[Token(Token = "0x400CF5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public readonly SelectionButton howToGetButton;

		[Token(Token = "0x400CF5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public readonly SelectionButton playButton;

		[Token(Token = "0x400CF5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCardExpand;

		[Token(Token = "0x400CF60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public int idx;

		[Token(Token = "0x170014BA")]
		private static bool isMobile
		{
			[Token(Token = "0x6008748")]
			[Address(RVA = "0xD08D10", Offset = "0xD07F10", VA = "0x180D08D10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170014BB")]
		public GameObject rarityIcon
		{
			[Token(Token = "0x6008749")]
			[Address(RVA = "0xD08DE0", Offset = "0xD07FE0", VA = "0x180D08DE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014BC")]
		public GameObject limitIcon
		{
			[Token(Token = "0x600874A")]
			[Address(RVA = "0xD08DB0", Offset = "0xD07FB0", VA = "0x180D08DB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014BD")]
		public GameObject imageCard
		{
			[Token(Token = "0x600874B")]
			[Address(RVA = "0xD08CE0", Offset = "0xD07EE0", VA = "0x180D08CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014BE")]
		public ElementObjectManager limitFromToGroupEom
		{
			[Token(Token = "0x600874C")]
			[Address(RVA = "0xD08D60", Offset = "0xD07F60", VA = "0x180D08D60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014BF")]
		public Selector selector
		{
			[Token(Token = "0x600874D")]
			[Address(RVA = "0xD08E10", Offset = "0xD08010", VA = "0x180D08E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014C0")]
		public GameObject bg
		{
			[Token(Token = "0x600874E")]
			[Address(RVA = "0xD08C00", Offset = "0xD07E00", VA = "0x180D08C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014C1")]
		public GameObject headerArea
		{
			[Token(Token = "0x600874F")]
			[Address(RVA = "0xD08C70", Offset = "0xD07E70", VA = "0x180D08C70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014C2")]
		public GameObject statusArea
		{
			[Token(Token = "0x6008750")]
			[Address(RVA = "0xD08E60", Offset = "0xD08060", VA = "0x180D08E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014C3")]
		public GameObject viewerArea
		{
			[Token(Token = "0x6008751")]
			[Address(RVA = "0xD08E90", Offset = "0xD08090", VA = "0x180D08E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014C4")]
		public GameObject backButton
		{
			[Token(Token = "0x6008752")]
			[Address(RVA = "0xD08BD0", Offset = "0xD07DD0", VA = "0x180D08BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008753")]
		[Address(RVA = "0xD07EF0", Offset = "0xD070F0", VA = "0x180D07EF0")]
		public CardDetailWidget(CardInfoDetail cardInfoDetail)
		{
		}

		[Token(Token = "0x6008754")]
		[Address(RVA = "0xD07E30", Offset = "0xD07030", VA = "0x180D07E30")]
		public void ResetScrollPos()
		{
		}
	}

	[Token(Token = "0x20015CC")]
	private delegate void craftCallBack(string message = "");

	[Token(Token = "0x20015CE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		[Token(Token = "0x400CF65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isInitedSnapContent;

		[Token(Token = "0x600875E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass61_0()
		{
		}

		[Token(Token = "0x600875F")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CInitializeContent_003Eb__0()
		{
		}

		[Token(Token = "0x6008760")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		internal bool _003CInitializeContent_003Eb__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20015D7")]
	[CompilerGenerated]
	private sealed class _003CInitializeContent_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CF82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CF83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CF84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardBrowserViewController _003C_003E4__this;

		[Token(Token = "0x400CF85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass61_0 _003C_003E8__1;

		[Token(Token = "0x400CF86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x400CF87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003CreserveNeedCnt_003E5__2;

		[Token(Token = "0x400CF88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x170014C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600877A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600877C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008777")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeContent_003Ed__61(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008778")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008779")]
		[Address(RVA = "0xD17990", Offset = "0xD16B90", VA = "0x180D17990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600877B")]
		[Address(RVA = "0xD17D00", Offset = "0xD16F00", VA = "0x180D17D00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CEF2")]
	private const string k_ArgKeyStartIdx = "startIdx";

	[Token(Token = "0x400CEF3")]
	private const string k_ArgKeyMrks = "mrks";

	[Token(Token = "0x400CEF4")]
	private const string k_ArgKeyStyleIds = "styleIds";

	[Token(Token = "0x400CEF5")]
	internal const string k_ArgKeyRegulationId = "regulationId";

	[Token(Token = "0x400CEF6")]
	private const string k_ArgKeyPrefab = "prefab";

	[Token(Token = "0x400CEF7")]
	private const string k_ArgKeyOpenOnContent = "openContent";

	[Token(Token = "0x400CEF8")]
	private const string k_ArgKeyOnCreatedViewCallBack = "DownloadCallBack";

	[Token(Token = "0x400CEF9")]
	internal const string k_ArgKeySwap = "swap";

	[Token(Token = "0x400CEFA")]
	internal const string k_ArgKey_SkipSwapTransition = "SkipSwapTransition";

	[Token(Token = "0x400CEFB")]
	internal const string k_ArgRequestCardInfo = "requestCardInfo";

	[Token(Token = "0x400CEFC")]
	internal const string k_ArgShowReleasedDate = "showReleasedDate";

	[Token(Token = "0x400CEFD")]
	internal const string k_ArgShowRelativeCard = "showRelativeCard";

	[Token(Token = "0x400CEFE")]
	internal const string k_ArgKeyShowPrevLimitIcon = "showPrevLimitIcon";

	[Token(Token = "0x400CEFF")]
	internal const string k_ArgKeyOverrideRarities = "overrideRarities";

	[Token(Token = "0x400CF00")]
	internal const string k_ArgKeyOverrideLimitStates = "overrideLimitStates";

	[Token(Token = "0x400CF01")]
	internal const string k_ArgKeyOverridePrevLimitStates = "overridePrevLimitStates";

	[Token(Token = "0x400CF02")]
	internal const string k_ArgKeyShowNoneLimitStates = "showNoneLimitStates";

	[Token(Token = "0x400CF03")]
	internal const string k_ArgKeyShowPrevLimitStates = "showPrevLimitStates";

	[Token(Token = "0x400CF04")]
	internal const string k_ArgKeyShowExpandStates = "showExpandStates";

	[Token(Token = "0x400CF05")]
	internal const string k_ArgKeyMonochromeStates = "monochromeState";

	[Token(Token = "0x400CF06")]
	internal const string k_ArgKeyAppendCardBottomTexts = "appendCardBottomTexts";

	[Token(Token = "0x400CF07")]
	internal const string k_ArgKeyCreateStates = "createState";

	[Token(Token = "0x400CF08")]
	internal const string k_ArgKeyPlayStates = "playState";

	[Token(Token = "0x400CF09")]
	internal const string k_ArgKeyHowToGetStates = "howToGetState";

	[Token(Token = "0x400CF0A")]
	internal const string k_ArgKeyUpdateSecretPackCallback = "UpdateSecretPackCallback";

	[Token(Token = "0x400CF0B")]
	internal const string k_ArgKeyShopTransitionCallback = "ShopTransitionCallback";

	[Token(Token = "0x400CF0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelCloseButton;

	[Token(Token = "0x400CF0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelPrevButton;

	[Token(Token = "0x400CF0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelNextButton;

	[Token(Token = "0x400CF0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x400CF10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelFullScreenUIBg;

	[Token(Token = "0x400CF11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelShortCut1;

	[Token(Token = "0x400CF12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<CardContext> m_CardContexts;

	[Token(Token = "0x400CF13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool m_AsMultiScrollItemEnabled;

	[Token(Token = "0x400CF14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private int m_RegulationId;

	[Token(Token = "0x400CF15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x400CF16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x400CF17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject m_ExpandUI;

	[Token(Token = "0x400CF18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool m_IsReady;

	[Token(Token = "0x400CF19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool m_Aborted;

	[Token(Token = "0x400CF1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
	private bool downloadPrefab;

	[Token(Token = "0x400CF1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Action<Dictionary<int, Dictionary<int, int>>> m_CraftResultParamsCallback;

	[Token(Token = "0x400CF1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Action<int, List<int>> m_ShopTransitionCallback;

	[Token(Token = "0x400CF1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private SnapContentManager m_SnapContentManager;

	[Token(Token = "0x400CF1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Dictionary<GameObject, CardDetailWidget> m_EntityMap;

	[Token(Token = "0x400CF1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<CardInfoDetail> m_RentedCardInfoDetails;

	[Token(Token = "0x400CF20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private CardExpand m_CardExpand;

	[Token(Token = "0x400CF21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private CardBrowserDuelPreviewPlayer m_DuelPreviewPlayer;

	[Token(Token = "0x400CF22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool m_Dirty;

	[Token(Token = "0x400CF23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
	private bool m_UpdateViewDirty;

	[Token(Token = "0x170014B9")]
	private bool IsPlayingDuelPreview
	{
		[Token(Token = "0x600873C")]
		[Address(RVA = "0xCEA650", Offset = "0xCE9850", VA = "0x180CEA650")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008724")]
	[Address(RVA = "0xCE5570", Offset = "0xCE4770", VA = "0x180CE5570")]
	private bool IsValidIdx(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6008725")]
	[Address(RVA = "0xCE5500", Offset = "0xCE4700", VA = "0x180CE5500")]
	private bool IsEnablePrev()
	{
		return default(bool);
	}

	[Token(Token = "0x6008726")]
	[Address(RVA = "0xCE5490", Offset = "0xCE4690", VA = "0x180CE5490")]
	private bool IsEnableNext()
	{
		return default(bool);
	}

	[Token(Token = "0x6008727")]
	[Address(RVA = "0xCE8E90", Offset = "0xCE8090", VA = "0x180CE8E90")]
	public static void OpenDL(int mrk, int styleid = 1, int regulationId = -1, [Optional] Action action)
	{
	}

	[Token(Token = "0x6008728")]
	[Address(RVA = "0xCE9190", Offset = "0xCE8390", VA = "0x180CE9190")]
	public static void Open(int mrk, int styleid = 1, int regulationId = -1, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008729")]
	[Address(RVA = "0xCE9310", Offset = "0xCE8510", VA = "0x180CE9310")]
	public static void Open(int idx, IReadOnlyList<int> mrks, [Optional] IReadOnlyList<int> styleIds, int regulationId = -1, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600872A")]
	[Address(RVA = "0xCE9700", Offset = "0xCE8900", VA = "0x180CE9700")]
	public static void Open(int idx, List<object> mrks, [Optional] List<object> styleIds, int regulationId = -1, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600872B")]
	[Address(RVA = "0xCE8C20", Offset = "0xCE7E20", VA = "0x180CE8C20")]
	public static void OpenAsDecoStyle(int idx, IReadOnlyList<int> mrks, int regulationId = -1, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600872C")]
	[Address(RVA = "0xCE8A80", Offset = "0xCE7C80", VA = "0x180CE8A80")]
	public static void Open2DL(int idx, List<object> mrks, [Optional] List<object> styleIds, int regulationId = -1, [Optional] Action action)
	{
	}

	[Token(Token = "0x600872D")]
	[Address(RVA = "0xCE5A90", Offset = "0xCE4C90", VA = "0x180CE5A90", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600872E")]
	[Address(RVA = "0xCE6D80", Offset = "0xCE5F80", VA = "0x180CE6D80", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600872F")]
	[Address(RVA = "0xCE5400", Offset = "0xCE4600", VA = "0x180CE5400")]
	[IteratorStateMachine(typeof(_003CInitializeContent_003Ed__61))]
	private IEnumerator InitializeContent(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008730")]
	[Address(RVA = "0xCE9FF0", Offset = "0xCE91F0", VA = "0x180CE9FF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6008731")]
	[Address(RVA = "0xCE8800", Offset = "0xCE7A00", VA = "0x180CE8800", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6008732")]
	[Address(RVA = "0xCE55D0", Offset = "0xCE47D0", VA = "0x180CE55D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6008733")]
	[Address(RVA = "0xCE6C70", Offset = "0xCE5E70", VA = "0x180CE6C70")]
	private void OnCreatedEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6008734")]
	[Address(RVA = "0xCE7680", Offset = "0xCE6880", VA = "0x180CE7680")]
	private void OnSetEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x6008735")]
	[Address(RVA = "0xCE7510", Offset = "0xCE6710", VA = "0x180CE7510")]
	private void OnScrollValueChanged(Vector2 normalize)
	{
	}

	[Token(Token = "0x6008736")]
	[Address(RVA = "0xCEA2F0", Offset = "0xCE94F0", VA = "0x180CEA2F0")]
	private bool ToNextPage()
	{
		return default(bool);
	}

	[Token(Token = "0x6008737")]
	[Address(RVA = "0xCEA380", Offset = "0xCE9580", VA = "0x180CEA380")]
	private bool ToPrevPage()
	{
		return default(bool);
	}

	[Token(Token = "0x6008738")]
	[Address(RVA = "0xCE6B70", Offset = "0xCE5D70", VA = "0x180CE6B70")]
	private void OnClickNext()
	{
	}

	[Token(Token = "0x6008739")]
	[Address(RVA = "0xCE6BF0", Offset = "0xCE5DF0", VA = "0x180CE6BF0")]
	private void OnClickPrev()
	{
	}

	[Token(Token = "0x600873A")]
	[Address(RVA = "0xCE72F0", Offset = "0xCE64F0", VA = "0x180CE72F0")]
	private void OnPageChanged()
	{
	}

	[Token(Token = "0x600873B")]
	[Address(RVA = "0xCE6820", Offset = "0xCE5A20", VA = "0x180CE6820")]
	private void OnClickCard(CardDetailWidget clickedWidget)
	{
	}

	[Token(Token = "0x600873D")]
	[Address(RVA = "0xCE9940", Offset = "0xCE8B40", VA = "0x180CE9940")]
	private void PlayDuelPreview(CardDetailWidget entityWidget, CardContext context)
	{
	}

	[Token(Token = "0x600873E")]
	[Address(RVA = "0xCE7500", Offset = "0xCE6700", VA = "0x180CE7500")]
	private void OnPlayPreviewStart()
	{
	}

	[Token(Token = "0x600873F")]
	[Address(RVA = "0xCE7500", Offset = "0xCE6700", VA = "0x180CE7500")]
	private void OnPlayPreviewEnd()
	{
	}

	[Token(Token = "0x6008740")]
	[Address(RVA = "0xCE9D30", Offset = "0xCE8F30", VA = "0x180CE9D30")]
	private void SetCraftable(bool craftable, int rarityID, CardDetailWidget entityWidget)
	{
	}

	[Token(Token = "0x6008741")]
	[Address(RVA = "0xCE4EC0", Offset = "0xCE40C0", VA = "0x180CE4EC0")]
	private void CraftCreate(CardBaseData baseData)
	{
	}

	[Token(Token = "0x6008742")]
	[Address(RVA = "0xCEA6B0", Offset = "0xCE98B0", VA = "0x180CEA6B0")]
	private void onCraftCreateCard(CardBaseData cbd, int craftNum, bool isBoost, (CardCollectionInfo.Premium, int) boostParam, craftCallBack callback, int compensationId, bool check)
	{
	}

	[Token(Token = "0x6008743")]
	[Address(RVA = "0xCE52A0", Offset = "0xCE44A0", VA = "0x180CE52A0")]
	private string GetCraftCreateResultMessage(CardBaseData cbd, int numNormal, int numShine, int numRoyal)
	{
		return null;
	}

	[Token(Token = "0x6008744")]
	[Address(RVA = "0xCE6A40", Offset = "0xCE5C40", VA = "0x180CE6A40")]
	public void OnClickLootSourceButton(int mrk)
	{
	}

	[Token(Token = "0x6008745")]
	[Address(RVA = "0xCEA410", Offset = "0xCE9610", VA = "0x180CEA410")]
	public CardBrowserViewController()
	{
	}
}
