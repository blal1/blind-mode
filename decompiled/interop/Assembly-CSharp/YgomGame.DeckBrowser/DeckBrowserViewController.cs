using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.ActionSheet;
using YgomGame.Card;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2000FE3")]
public class DeckBrowserViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IBokeSupported
{
	[Token(Token = "0x2000FE4")]
	private enum BrowserType
	{
		[Token(Token = "0x400ABBA")]
		Solo,
		[Token(Token = "0x400ABBB")]
		SoloNPC,
		[Token(Token = "0x400ABBC")]
		StructureShop,
		[Token(Token = "0x400ABBD")]
		StructureCopy,
		[Token(Token = "0x400ABBE")]
		StructureFirst,
		[Token(Token = "0x400ABBF")]
		PublicDeck,
		[Token(Token = "0x400ABC0")]
		NeuronMyDeck,
		[Token(Token = "0x400ABC1")]
		SelectNeuronDeck,
		[Token(Token = "0x400ABC2")]
		Confirm,
		[Token(Token = "0x400ABC3")]
		ConfirmEvent,
		[Token(Token = "0x400ABC4")]
		Select,
		[Token(Token = "0x400ABC5")]
		SelectRental,
		[Token(Token = "0x400ABC6")]
		PickUpSelection,
		[Token(Token = "0x400ABC7")]
		HistoryMyDeck,
		[Token(Token = "0x400ABC8")]
		HistoryOpponentDeck,
		[Token(Token = "0x400ABC9")]
		TrialDraw,
		[Token(Token = "0x400ABCA")]
		SelectWCSFinal,
		[Token(Token = "0x400ABCB")]
		DuelLive,
		[Token(Token = "0x400ABCC")]
		BrowseWcsFinal,
		[Token(Token = "0x400ABCD")]
		ReplayMyDeck,
		[Token(Token = "0x400ABCE")]
		ReplayOpponentDeck
	}

	[Token(Token = "0x2000FE5")]
	private class DeckBrowserInfo
	{
		[Token(Token = "0x400ABCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string deckName;

		[Token(Token = "0x400ABD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int regulationID;

		[Token(Token = "0x400ABD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> mainCards;

		[Token(Token = "0x400ABD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, object> extraCards;

		[Token(Token = "0x400ABD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, object> accessory;

		[Token(Token = "0x400ABD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<string, object> pickCards;

		[Token(Token = "0x17000F2B")]
		public int box
		{
			[Token(Token = "0x6006085")]
			[Address(RVA = "0xA748E0", Offset = "0xA73AE0", VA = "0x180A748E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6006086")]
		[Address(RVA = "0xA72740", Offset = "0xA71940", VA = "0x180A72740")]
		public static DeckBrowserInfo GetInfo(DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, Dictionary<string, object> args)
		{
			return null;
		}

		[Token(Token = "0x6006087")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DeckBrowserInfo()
		{
		}
	}

	[Token(Token = "0x2001016")]
	[CompilerGenerated]
	private sealed class _003CDelayedInvokeCallback_003Ed__192 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AC75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AC76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AC77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x17000F2C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006124")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F2D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006126")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006121")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedInvokeCallback_003Ed__192(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006122")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006123")]
		[Address(RVA = "0xA7AB10", Offset = "0xA79D10", VA = "0x180A7AB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006125")]
		[Address(RVA = "0xA7AB80", Offset = "0xA79D80", VA = "0x180A7AB80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001017")]
	[CompilerGenerated]
	private sealed class _003CInitDeckCards_003Ed__174 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AC78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AC79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AC7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckBrowserViewController _003C_003E4__this;

		[Token(Token = "0x400AC7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<object> mainCardMrks;

		[Token(Token = "0x400AC7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<object> extraCardMrks;

		[Token(Token = "0x400AC7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<object> mainCardPremiums;

		[Token(Token = "0x400AC7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<object> extraCardPremiums;

		[Token(Token = "0x400AC7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action onFinish;

		[Token(Token = "0x400AC80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _003Ccount_003E5__2;

		[Token(Token = "0x400AC81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _003CisDefaultSelected_003E5__3;

		[Token(Token = "0x400AC82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UnityAction _003CblankCallback_003E5__4;

		[Token(Token = "0x400AC83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _003Ci_003E5__5;

		[Token(Token = "0x17000F2E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600612A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F2F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600612C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006127")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitDeckCards_003Ed__174(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006128")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006129")]
		[Address(RVA = "0xA7B830", Offset = "0xA7AA30", VA = "0x180A7B830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600612B")]
		[Address(RVA = "0xA7CE60", Offset = "0xA7C060", VA = "0x180A7CE60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001018")]
	[CompilerGenerated]
	private sealed class _003CInitDeckCardsMobile_003Ed__175 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AC84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AC85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AC86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckBrowserViewController _003C_003E4__this;

		[Token(Token = "0x400AC87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<object> mainCardMrks;

		[Token(Token = "0x400AC88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<object> mainCardPremiums;

		[Token(Token = "0x400AC89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<object> extraCardMrks;

		[Token(Token = "0x400AC8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<object> extraCardPremiums;

		[Token(Token = "0x400AC8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action onFinish;

		[Token(Token = "0x400AC8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<CardBaseData> _003Crentals_003E5__2;

		[Token(Token = "0x400AC8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x17000F30")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006130")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F31")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006132")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600612D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitDeckCardsMobile_003Ed__175(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600612E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600612F")]
		[Address(RVA = "0xA7ABC0", Offset = "0xA79DC0", VA = "0x180A7ABC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006131")]
		[Address(RVA = "0xA7B7F0", Offset = "0xA7A9F0", VA = "0x180A7B7F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001019")]
	[CompilerGenerated]
	private sealed class _003CInitPickupCards_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AC8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AC8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AC90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckBrowserViewController _003C_003E4__this;

		[Token(Token = "0x17000F32")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006136")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F33")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006138")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006133")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitPickupCards_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006134")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006135")]
		[Address(RVA = "0xA7CEA0", Offset = "0xA7C0A0", VA = "0x180A7CEA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006137")]
		[Address(RVA = "0xA7D060", Offset = "0xA7C260", VA = "0x180A7D060", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400AB44")]
	private const string k_ArgKeyName = "name";

	[Token(Token = "0x400AB45")]
	private const string k_ArgKeyMainCards = "mcards";

	[Token(Token = "0x400AB46")]
	private const string k_ArgKeyExtraCards = "ecards";

	[Token(Token = "0x400AB47")]
	public const string k_ArgKeyRegulationVisible = "regulationVisible";

	[Token(Token = "0x400AB48")]
	public const string k_ArgKeyRarityVisible = "rarityVisible";

	[Token(Token = "0x400AB49")]
	public const string k_ArgKeyMonochromeEnable = "regulationMonochromeEnable";

	[Token(Token = "0x400AB4A")]
	public const string k_ArgKeyPremiumCheckEnable = "premiumCheckEnable";

	[Token(Token = "0x400AB4B")]
	public const string k_ArgKeyOnStackEntryCallback = "onStackEntryCallback";

	[Token(Token = "0x400AB4C")]
	public const string k_ArgKeyShortcutSettings = "shortcutSettings";

	[Token(Token = "0x400AB4D")]
	public const string k_ArgKeyAccessories = "accessories";

	[Token(Token = "0x400AB4E")]
	public const string k_ArgKeyPickCards = "pickCards";

	[Token(Token = "0x400AB4F")]
	public const string k_ArgKeyNumMainCards = "numMainCards";

	[Token(Token = "0x400AB50")]
	public const string k_ArgKeyNumExtraCards = "numExtraCards";

	[Token(Token = "0x400AB51")]
	public const string k_ArgKeyIconDeckId = "iconDeckId";

	[Token(Token = "0x400AB52")]
	public const string k_ArgKeyPopViewEvent = "popViewEvent";

	[Token(Token = "0x400AB53")]
	public const string k_ArgKeyOnClickCopyCallback = "onClickCopyCallback";

	[Token(Token = "0x400AB54")]
	public const string k_ArgKeyOnClickSelectCallback = "onClickSelectCallback";

	[Token(Token = "0x400AB55")]
	public const string k_ArgKeyOnCompleteSelectDeckCallback = "onCompleteSelectDeckCallback";

	[Token(Token = "0x400AB56")]
	public const string k_ArgKeySortEnable = "sortEnable";

	[Token(Token = "0x400AB57")]
	public const string k_ArgKeyDeckNameInit = "deckNameInit";

	[Token(Token = "0x400AB58")]
	public const string k_ArgKeyRegulation = "regulationId";

	[Token(Token = "0x400AB59")]
	public const string k_ArgKeyOpenAsDialog = "openAsDialog";

	[Token(Token = "0x400AB5A")]
	public const string k_ArgKeyRarityToggleEnable = "rarityToggleEnable";

	[Token(Token = "0x400AB5B")]
	public const string k_ArgKeyRentalCardPool = "rentalCardPool";

	[Token(Token = "0x400AB5C")]
	public const string k_ArgKeyEventDeckID = "EventDeckID";

	[Token(Token = "0x400AB5D")]
	public const string k_ArgKeyNeuronMyDeck = "NeuronMyDeck";

	[Token(Token = "0x400AB5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelTitle;

	[Token(Token = "0x400AB5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelDeckView;

	[Token(Token = "0x400AB60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelDetailView;

	[Token(Token = "0x400AB61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelDetailViewMenuRoot;

	[Token(Token = "0x400AB62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelOptionalAreaLocator;

	[Token(Token = "0x400AB63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelIconDeck;

	[Token(Token = "0x400AB64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelNoItemButton;

	[Token(Token = "0x400AB65")]
	private const string k_ELabelGroupCardNum = "GroupCardNum";

	[Token(Token = "0x400AB66")]
	private const string k_ELabelTextCardNum = "TextCardNum";

	[Token(Token = "0x400AB67")]
	private const string k_ELabelDialogBG = "DialogBG";

	[Token(Token = "0x400AB68")]
	private const string k_ELabelDialogCloseButton = "DialogCloseButton";

	[Token(Token = "0x400AB69")]
	private const string k_ELabelRarityToggleButton = "RarityToggleButton";

	[Token(Token = "0x400AB6A")]
	private const string k_ELabelRegulationIcon = "RegulationIcon";

	[Token(Token = "0x400AB6B")]
	private const string k_ELabelMobileLoadingIcon = "Loading";

	[Token(Token = "0x400AB6C")]
	private const string k_ELabelMobileScroll = "Scroll";

	[Token(Token = "0x400AB6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject m_MobileLoading;

	[Token(Token = "0x400AB6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject m_MobileScroll;

	[Token(Token = "0x400AB6F")]
	public const string COPY_ENABLE = "copyEnable";

	[Token(Token = "0x400AB70")]
	public const string DELETE_ENABLE = "deleteEnable";

	[Token(Token = "0x400AB71")]
	public const string REGULATION_ENABLE = "regulationEnable";

	[Token(Token = "0x400AB72")]
	public const string REGULATION_ICON_ENABLE = "regulationIconEnable";

	[Token(Token = "0x400AB73")]
	public const string TRIAL_DRAW_ENABLE = "trialDrawEnable";

	[Token(Token = "0x400AB74")]
	public const string HAS_CARD_ENABLE = "hasCardEnable";

	[Token(Token = "0x400AB75")]
	public const string HAS_CARD_IS_ON = "hasCardIsOn";

	[Token(Token = "0x400AB76")]
	public const string FOOTER_MENU_ENABLE = "FooterMenuEnable";

	[Token(Token = "0x400AB77")]
	public const string FOOTER_MENU_EXPORT = "FooterMenuExport";

	[Token(Token = "0x400AB78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private ElementObjectManager m_UIPrefab;

	[Token(Token = "0x400AB79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private ElementObjectManager m_UIPrefabMobile;

	[Token(Token = "0x400AB7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ElementObjectManager m_UI;

	[Token(Token = "0x400AB7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private TextMeshProUGUI m_TitleText;

	[Token(Token = "0x400AB7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private DeckViewWidget m_DeckViewWidget;

	[Token(Token = "0x400AB7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private CardDetailWidget m_DetailWidget;

	[Token(Token = "0x400AB7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject m_NoItemButton;

	[Token(Token = "0x400AB7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject m_ScrollBlocker;

	[Token(Token = "0x400AB80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private string m_DeckName;

	[Token(Token = "0x400AB81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ElementObjectManager m_DeckViewEom;

	[Token(Token = "0x400AB82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private DeckView m_DeckView;

	[Token(Token = "0x400AB83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private TMP_Text m_DeckNameText;

	[Token(Token = "0x400AB84")]
	private const int MAX_COL = 8;

	[Token(Token = "0x400AB85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private int m_Regulation;

	[Token(Token = "0x400AB86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private int m_RentalPool;

	[Token(Token = "0x400AB87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private RegulationSelectSheet m_RegulationSelectSheet;

	[Token(Token = "0x400AB88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool m_MonochromeEnable;

	[Token(Token = "0x400AB89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool m_PremiumCheckEnable;

	[Token(Token = "0x400AB8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18A")]
	private bool m_RegulationVisible;

	[Token(Token = "0x400AB8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18B")]
	private bool m_RarityVisible;

	[Token(Token = "0x400AB8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private bool m_SortEnable;

	[Token(Token = "0x400AB8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private ShortcutKeySetter m_ShortCutSettings;

	[Token(Token = "0x400AB8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Dictionary<string, object> m_Accessories;

	[Token(Token = "0x400AB8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Dictionary<string, object> m_PickCards;

	[Token(Token = "0x400AB90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private int m_NumMainCards;

	[Token(Token = "0x400AB91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private int m_NumExtraCards;

	[Token(Token = "0x400AB92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private int m_NumMainCol;

	[Token(Token = "0x400AB93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private int m_UnimplementedMainNum;

	[Token(Token = "0x400AB94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool m_IsContainsUnimplemented;

	[Token(Token = "0x400AB95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<bool> m_InitCursorFlags;

	[Token(Token = "0x400AB96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private List<object> m_DeckCardMrks;

	[Token(Token = "0x400AB97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private List<object> m_DeckCardPremiums;

	[Token(Token = "0x400AB98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private List<object> m_MainCardMrks;

	[Token(Token = "0x400AB99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private List<object> m_MainCardPremiums;

	[Token(Token = "0x400AB9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private List<bool> m_MonochromeList;

	[Token(Token = "0x400AB9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private List<CardBaseData> m_MainCardBaseData;

	[Token(Token = "0x400AB9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private List<CardBaseData> m_ExtraCardBaseData;

	[Token(Token = "0x400AB9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public SelectionItem m_ExDeckSelector;

	[NonSerialized]
	[Token(Token = "0x400AB9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public GameObject optionalEmbedObj;

	[Token(Token = "0x400AB9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public Transform optionalAreaLocator;

	[Token(Token = "0x400ABA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	[SerializeField]
	private SpriteContainer m_IconCardDB;

	[Token(Token = "0x400ABA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private readonly string k_LabelIconJp;

	[Token(Token = "0x400ABA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private readonly string k_LabelIconUniversal;

	[Token(Token = "0x400ABA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private readonly string k_LabelIconKo;

	[Token(Token = "0x400ABA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[SerializeField]
	private DeckSelectViewController2.DeckEventType m_CopyType;

	[Token(Token = "0x400ABA5")]
	private const string k_ELabelCopyType = "copyType";

	[Token(Token = "0x400ABA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private GameObject m_UnCraftableIcon;

	[Token(Token = "0x400ABA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private Content cci;

	[Token(Token = "0x400ABA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private bool m_IsDialog;

	[Token(Token = "0x400ABA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private GameObject m_DialogBG;

	[Token(Token = "0x400ABAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private SelectionButton m_DialogCloseButton;

	[Token(Token = "0x400ABAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private GameObject m_RegulationGroup;

	[Token(Token = "0x400ABAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private Image m_RegulationIcon;

	[Token(Token = "0x400ABAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private ExtendedTextMeshProUGUI m_RegulationName;

	[Token(Token = "0x400ABAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private SelectionButton m_RarityToggleButton;

	[Token(Token = "0x400ABAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private GameObject m_RarityToggleOn;

	[Token(Token = "0x400ABB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private GameObject m_RarityToggleOff;

	[Token(Token = "0x400ABB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private BrowserType m_BrowserType;

	[Token(Token = "0x400ABB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public Action onPopViewCallback;

	[Token(Token = "0x400ABB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public Action onInitializePickupCardCallback;

	[Token(Token = "0x400ABB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public Action onInitializeTrialDrawCallback;

	[Token(Token = "0x400ABB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public Action<DeckCard, int> onCreatedCardCallback;

	[Token(Token = "0x400ABB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public Func<string, GameObject> createOptionalEmbedObjFunc;

	[Token(Token = "0x400ABB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public Action onCopySccessedCallback;

	[Token(Token = "0x400ABB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public Action onCompleteSelectDeckCallback;

	[Token(Token = "0x17000F24")]
	public bool monochromeEnable
	{
		[Token(Token = "0x6006048")]
		[Address(RVA = "0xA697C0", Offset = "0xA689C0", VA = "0x180A697C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006049")]
		[Address(RVA = "0xA69A60", Offset = "0xA68C60", VA = "0x180A69A60")]
		set
		{
		}
	}

	[Token(Token = "0x17000F25")]
	public bool premiumCheckEnable
	{
		[Token(Token = "0x600604A")]
		[Address(RVA = "0xA697D0", Offset = "0xA689D0", VA = "0x180A697D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600604B")]
		[Address(RVA = "0xA69A80", Offset = "0xA68C80", VA = "0x180A69A80")]
		set
		{
		}
	}

	[Token(Token = "0x17000F26")]
	public bool isMobile
	{
		[Token(Token = "0x600604C")]
		[Address(RVA = "0xA69770", Offset = "0xA68970", VA = "0x180A69770")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F27")]
	public bool isGamePad
	{
		[Token(Token = "0x600604D")]
		[Address(RVA = "0xA696E0", Offset = "0xA688E0", VA = "0x180A696E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F28")]
	public bool isDialog
	{
		[Token(Token = "0x600604E")]
		[Address(RVA = "0x49BBB0", Offset = "0x49ADB0", VA = "0x18049BBB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600604F")]
		[Address(RVA = "0x49C290", Offset = "0x49B490", VA = "0x18049C290")]
		set
		{
		}
	}

	[Token(Token = "0x17000F29")]
	private BrowserType browserType
	{
		[Token(Token = "0x6006050")]
		[Address(RVA = "0xA696D0", Offset = "0xA688D0", VA = "0x180A696D0")]
		get
		{
			return default(BrowserType);
		}
		[Token(Token = "0x6006051")]
		[Address(RVA = "0xA69A50", Offset = "0xA68C50", VA = "0x180A69A50")]
		set
		{
		}
	}

	[Token(Token = "0x17000F2A")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006052")]
		[Address(RVA = "0xA697E0", Offset = "0xA689E0", VA = "0x180A697E0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600602C")]
	[Address(RVA = "0xA60B20", Offset = "0xA5FD20", VA = "0x180A60B20")]
	public static void OpenAsHistoryDeckCheck(string deckName, object mainCards, object extraCards, bool isOwn, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600602D")]
	[Address(RVA = "0xA62CA0", Offset = "0xA61EA0", VA = "0x180A62CA0")]
	public static void OpenReplayDeckCheck(string deckName, object mainCards, object extraCards, [Optional] Dictionary<string, object> args, bool isMine = true)
	{
	}

	[Token(Token = "0x600602E")]
	[Address(RVA = "0xA5FE60", Offset = "0xA5F060", VA = "0x180A5FE60")]
	public static void OpenAsConfirmation(DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600602F")]
	[Address(RVA = "0xA60850", Offset = "0xA5FA50", VA = "0x180A60850")]
	public static void OpenAsDuelLiveDeckCheck(string deckName, object mainCards, object extraCards, List<int> shareCards, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006030")]
	[Address(RVA = "0xA60C90", Offset = "0xA5FE90", VA = "0x180A60C90")]
	public static void OpenAsPickupCardSelection(string name, object mainCards, object extraCards, int id, int eventId, int deckcaseId, ProfileEditViewController.EditType editType, [Optional] Action<DeckBrowserViewController> onStackEntryCallback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006031")]
	[Address(RVA = "0xA5CF20", Offset = "0xA5C120", VA = "0x180A5CF20")]
	[IteratorStateMachine(typeof(_003CInitPickupCards_003Ed__5))]
	private IEnumerator InitPickupCards()
	{
		return null;
	}

	[Token(Token = "0x6006032")]
	[Address(RVA = "0xA5CC80", Offset = "0xA5BE80", VA = "0x180A5CC80")]
	private void InitPickupCardsMobile(PickupCardSelectionWidget pickupCardSelectionWidget)
	{
	}

	[Token(Token = "0x6006033")]
	[Address(RVA = "0xA67E90", Offset = "0xA67090", VA = "0x180A67E90")]
	public void SetOnClickDetailViewCard(int cardId, int styleId)
	{
	}

	[Token(Token = "0x6006034")]
	[Address(RVA = "0xA60EF0", Offset = "0xA600F0", VA = "0x180A60EF0")]
	public static void OpenAsPublicDeck(string name, int pickCardId, object mainCards, object extraCards, object categories, object tags, [Optional] Transform transform, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006035")]
	[Address(RVA = "0xA61080", Offset = "0xA60280", VA = "0x180A61080")]
	public static void OpenAsSelect(DeckSelectViewController2.SelectMode mode, DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006036")]
	[Address(RVA = "0xA5F340", Offset = "0xA5E540", VA = "0x180A5F340")]
	private void OnClickSelectButton(DeckSelectViewController2.SelectMode mode, int deckID, int eventID)
	{
	}

	[Token(Token = "0x6006037")]
	[Address(RVA = "0xA5ABE0", Offset = "0xA59DE0", VA = "0x180A5ABE0")]
	private void DeckSetByGameMode(Util.GameMode gameMode, int deckID)
	{
	}

	[Token(Token = "0x6006038")]
	[Address(RVA = "0xA62910", Offset = "0xA61B10", VA = "0x180A62910")]
	private void OpenDeckSelectDialog(DeckSelectViewController2.SelectMode mode)
	{
	}

	[Token(Token = "0x6006039")]
	[Address(RVA = "0xA59550", Offset = "0xA58750", VA = "0x180A59550")]
	private Dictionary<string, object> CopyDeckData()
	{
		return null;
	}

	[Token(Token = "0x600603A")]
	[Address(RVA = "0xA66B50", Offset = "0xA65D50", VA = "0x180A66B50")]
	private void SelectDeck(DeckSelectViewController2.SelectMode mode, int deckID, int eventID)
	{
	}

	[Token(Token = "0x600603B")]
	[Address(RVA = "0xA62AF0", Offset = "0xA61CF0", VA = "0x180A62AF0")]
	private void OpenOutOfTermDialog(DeckSelectViewController2.SelectMode mode)
	{
	}

	[Token(Token = "0x600603C")]
	[Address(RVA = "0xA61AF0", Offset = "0xA60CF0", VA = "0x180A61AF0")]
	public static void OpenAsSolo(int chapterId, SoloDeckUtil.SoloDeckType soloDeckType, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600603D")]
	[Address(RVA = "0xA62E10", Offset = "0xA62010", VA = "0x180A62E10")]
	private static void OpenStructure(int structureId, Action<DeckBrowserViewController> onStackCallback, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600603E")]
	[Address(RVA = "0xA61D90", Offset = "0xA60F90", VA = "0x180A61D90")]
	public static void OpenAsStructure(int structureId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600603F")]
	[Address(RVA = "0xA60A00", Offset = "0xA5FC00", VA = "0x180A60A00")]
	public static void OpenAsFirstStructure(int structureId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006040")]
	[Address(RVA = "0xA61C70", Offset = "0xA60E70", VA = "0x180A61C70")]
	public static void OpenAsStructureDeckCopy(int structureId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006041")]
	[Address(RVA = "0xA5ADD0", Offset = "0xA59FD0", VA = "0x180A5ADD0")]
	private static void GetFirstStructure(int structureId, DeckBrowserViewController vc, Action completeCallback)
	{
	}

	[Token(Token = "0x6006042")]
	[Address(RVA = "0xA5B000", Offset = "0xA5A200", VA = "0x180A5B000")]
	private static Dictionary<string, object> GetPickupCardsByStructureMaster(object structureMaster)
	{
		return null;
	}

	[Token(Token = "0x6006043")]
	[Address(RVA = "0xA61EB0", Offset = "0xA610B0", VA = "0x180A61EB0")]
	public static void OpenAsTrialDraw(string deckName, int regulation, object mainCards, object extraCards, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006044")]
	[Address(RVA = "0xA62010", Offset = "0xA61210", VA = "0x180A62010")]
	public static void OpenAsTrialDraw(DeckSelectViewController2.DeckEventType deckType, int deckID, int eventID, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006045")]
	[Address(RVA = "0xA63420", Offset = "0xA62620", VA = "0x180A63420")]
	public static void OpenTrialDrawView(string name, int regulation, List<CardBaseData> main, List<CardBaseData> extra, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006046")]
	[Address(RVA = "0xA63240", Offset = "0xA62440", VA = "0x180A63240")]
	private void OpenTrialDrawView()
	{
	}

	[Token(Token = "0x6006047")]
	[Address(RVA = "0xA5ACF0", Offset = "0xA59EF0", VA = "0x180A5ACF0")]
	private void DispLoadingMobile(bool isLoading)
	{
	}

	[Token(Token = "0x6006053")]
	[Address(RVA = "0xA63480", Offset = "0xA62680", VA = "0x180A63480")]
	public static void Open(string name, object mainCards, object extraCards, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006054")]
	[Address(RVA = "0xA5B180", Offset = "0xA5A380", VA = "0x180A5B180")]
	private static List<CardBaseData> GetRentalCards(int rentalPoolID)
	{
		return null;
	}

	[Token(Token = "0x6006055")]
	[Address(RVA = "0xA58FD0", Offset = "0xA581D0", VA = "0x180A58FD0")]
	private static Dictionary<string, object> ConvertCBDtoDict(List<CardBaseData> cbd)
	{
		return null;
	}

	[Token(Token = "0x6006056")]
	[Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
	private static Dictionary<string, object> ConvertPickupCardsListToDict(List<object> ids, List<object> r)
	{
		return null;
	}

	[Token(Token = "0x6006057")]
	[Address(RVA = "0xA5CF90", Offset = "0xA5C190", VA = "0x180A5CF90")]
	private void InitializeView()
	{
	}

	[Token(Token = "0x6006058")]
	[Address(RVA = "0xA5ECA0", Offset = "0xA5DEA0", VA = "0x180A5ECA0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006059")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600605A")]
	[Address(RVA = "0xA5B400", Offset = "0xA5A600", VA = "0x180A5B400")]
	private string GetTitle()
	{
		return null;
	}

	[Token(Token = "0x600605B")]
	[Address(RVA = "0xA68310", Offset = "0xA67510", VA = "0x180A68310")]
	private void Start()
	{
	}

	[Token(Token = "0x600605C")]
	[Address(RVA = "0xA5BCC0", Offset = "0xA5AEC0", VA = "0x180A5BCC0")]
	[IteratorStateMachine(typeof(_003CInitDeckCards_003Ed__174))]
	private IEnumerator InitDeckCards(List<object> mainCardMrks, List<object> mainCardPremiums, List<object> extraCardMrks, List<object> extraCardPremiums, Action onFinish)
	{
		return null;
	}

	[Token(Token = "0x600605D")]
	[Address(RVA = "0xA5BBD0", Offset = "0xA5ADD0", VA = "0x180A5BBD0")]
	[IteratorStateMachine(typeof(_003CInitDeckCardsMobile_003Ed__175))]
	private IEnumerator InitDeckCardsMobile(List<object> mainCardMrks, List<object> mainCardPremiums, List<object> extraCardMrks, List<object> extraCardPremiums, Action onFinish)
	{
		return null;
	}

	[Token(Token = "0x600605E")]
	[Address(RVA = "0xA5F800", Offset = "0xA5EA00", VA = "0x180A5F800")]
	private void OnCreatedCardCallbackDefault(DeckCard deckCard, int idx)
	{
	}

	[Token(Token = "0x600605F")]
	[Address(RVA = "0xA68150", Offset = "0xA67350", VA = "0x180A68150")]
	private void SetRegulation(int eventID, int deckId, DeckSelectViewController2.DeckEventType regType = DeckSelectViewController2.DeckEventType.ExhibitionDeck)
	{
	}

	[Token(Token = "0x6006060")]
	[Address(RVA = "0xA67F80", Offset = "0xA67180", VA = "0x180A67F80")]
	private void SetRegulation(int eventID, DeckSelectViewController2.SelectMode mode = DeckSelectViewController2.SelectMode.Exhibition)
	{
	}

	[Token(Token = "0x6006061")]
	[Address(RVA = "0x49BFF0", Offset = "0x49B1F0", VA = "0x18049BFF0")]
	private void SetRegulation(int regulationId)
	{
	}

	[Token(Token = "0x6006062")]
	[Address(RVA = "0xA67A40", Offset = "0xA66C40", VA = "0x180A67A40")]
	public void SetDetailViewCard(CardBaseData cbd)
	{
	}

	[Token(Token = "0x6006063")]
	[Address(RVA = "0xA67960", Offset = "0xA66B60", VA = "0x180A67960")]
	public void SetDetailViewCard(int mrk, int premiumId, bool isRental = false)
	{
	}

	[Token(Token = "0x6006064")]
	[Address(RVA = "0xA67D80", Offset = "0xA66F80", VA = "0x180A67D80")]
	public void SetOnClickDetailViewCard(int idx)
	{
	}

	[Token(Token = "0x6006065")]
	[Address(RVA = "0xA67E60", Offset = "0xA67060", VA = "0x180A67E60")]
	public void SetOnClickDetailViewCard(UnityAction callback)
	{
	}

	[Token(Token = "0x6006066")]
	[Address(RVA = "0xA644E0", Offset = "0xA636E0", VA = "0x180A644E0")]
	public void RefreshRegulation()
	{
	}

	[Token(Token = "0x6006067")]
	[Address(RVA = "0xA64360", Offset = "0xA63560", VA = "0x180A64360")]
	private void RefreshRegulationIcon()
	{
	}

	[Token(Token = "0x6006068")]
	[Address(RVA = "0xA63B90", Offset = "0xA62D90", VA = "0x180A63B90")]
	public void RefreshRarity()
	{
	}

	[Token(Token = "0x6006069")]
	[Address(RVA = "0xA585C0", Offset = "0xA577C0", VA = "0x180A585C0")]
	private void ApplyHasCardDisplay()
	{
	}

	[Token(Token = "0x600606A")]
	[Address(RVA = "0xA5C6D0", Offset = "0xA5B8D0", VA = "0x180A5C6D0")]
	private void InitMonochromeList()
	{
	}

	[Token(Token = "0x600606B")]
	[Address(RVA = "0xA5CC50", Offset = "0xA5BE50", VA = "0x180A5CC50")]
	private int InitNumMainCol(int numMain)
	{
		return default(int);
	}

	[Token(Token = "0x600606C")]
	[Address(RVA = "0xA5EC80", Offset = "0xA5DE80", VA = "0x180A5EC80")]
	private bool IsBottomMainCard(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600606D")]
	[Address(RVA = "0xA67B10", Offset = "0xA66D10", VA = "0x180A67B10")]
	private void SetMainBottomKeyDownCallback(int mainIndex)
	{
	}

	[Token(Token = "0x600606E")]
	[Address(RVA = "0xA5AC80", Offset = "0xA59E80", VA = "0x180A5AC80")]
	[IteratorStateMachine(typeof(_003CDelayedInvokeCallback_003Ed__192))]
	private IEnumerator DelayedInvokeCallback(Action action)
	{
		return null;
	}

	[Token(Token = "0x600606F")]
	[Address(RVA = "0xA64CC0", Offset = "0xA63EC0", VA = "0x180A64CC0")]
	private bool RegulationCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6006070")]
	[Address(RVA = "0xA63960", Offset = "0xA62B60", VA = "0x180A63960")]
	private bool PossetionCheck(bool distinctPrem)
	{
		return default(bool);
	}

	[Token(Token = "0x6006071")]
	[Address(RVA = "0xA5B7F0", Offset = "0xA5A9F0", VA = "0x180A5B7F0")]
	private void InitCommonSettings(DeckBrowserOptionWidget optionWidget, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006072")]
	[Address(RVA = "0xA5BDB0", Offset = "0xA5AFB0", VA = "0x180A5BDB0")]
	private void InitEnableDeckBrowserOptions(DeckBrowserOptionWidget optionWidget, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006073")]
	[Address(RVA = "0xA5B830", Offset = "0xA5AA30", VA = "0x180A5B830")]
	private void InitDeckBrowserCallBacks(DeckBrowserOptionWidget optionWidget, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006074")]
	[Address(RVA = "0xA5EDA0", Offset = "0xA5DFA0", VA = "0x180A5EDA0")]
	private void OnClickCopyButton()
	{
	}

	[Token(Token = "0x6006075")]
	[Address(RVA = "0xA64EF0", Offset = "0xA640F0", VA = "0x180A64EF0")]
	private void SaveDeck()
	{
	}

	[Token(Token = "0x6006076")]
	[Address(RVA = "0xA5ED50", Offset = "0xA5DF50", VA = "0x180A5ED50", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006077")]
	[Address(RVA = "0xA69270", Offset = "0xA68470", VA = "0x180A69270")]
	public DeckBrowserViewController()
	{
	}
}
