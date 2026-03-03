using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.ActionSheet;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.CardBrowser;

[Token(Token = "0x20015D8")]
public class CardListBrowserViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20015D9")]
	private class CardFilter
	{
		[Token(Token = "0x400CFD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_TextFilter;

		[Token(Token = "0x400CFD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_RarityFilter;

		[Token(Token = "0x400CFD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> m_SourceMrks;

		[Token(Token = "0x400CFD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IReadOnlyList<int> m_SourceStyles;

		[Token(Token = "0x400CFD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<int> m_TextResultCache;

		[Token(Token = "0x400CFD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> m_RarityResultCache;

		[Token(Token = "0x400CFDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<int> m_Result;

		[Token(Token = "0x400CFDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<int> m_StyleResult;

		[Token(Token = "0x400CFDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_SourceDirty;

		[Token(Token = "0x400CFDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool m_TextDirty;

		[Token(Token = "0x400CFDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool m_RarityDirty;

		[Token(Token = "0x170014CC")]
		public bool isFilteredText
		{
			[Token(Token = "0x600879F")]
			[Address(RVA = "0xD09500", Offset = "0xD08700", VA = "0x180D09500")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170014CD")]
		public List<int> sourceMrks
		{
			[Token(Token = "0x60087A0")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
			[Token(Token = "0x60087A1")]
			[Address(RVA = "0xD09540", Offset = "0xD08740", VA = "0x180D09540")]
			set
			{
			}
		}

		[Token(Token = "0x170014CE")]
		public IReadOnlyList<int> sourceStyles
		{
			[Token(Token = "0x60087A2")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60087A3")]
			[Address(RVA = "0xD09560", Offset = "0xD08760", VA = "0x180D09560")]
			set
			{
			}
		}

		[Token(Token = "0x170014CF")]
		public string textFilter
		{
			[Token(Token = "0x60087A4")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x60087A5")]
			[Address(RVA = "0xD09580", Offset = "0xD08780", VA = "0x180D09580")]
			set
			{
			}
		}

		[Token(Token = "0x170014D0")]
		public bool isFilteredRarity
		{
			[Token(Token = "0x60087A6")]
			[Address(RVA = "0xD094F0", Offset = "0xD086F0", VA = "0x180D094F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170014D1")]
		public int rarityFilter
		{
			[Token(Token = "0x60087A7")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60087A8")]
			[Address(RVA = "0xD09520", Offset = "0xD08720", VA = "0x180D09520")]
			set
			{
			}
		}

		[Token(Token = "0x170014D2")]
		public bool isAnyFiltered
		{
			[Token(Token = "0x60087A9")]
			[Address(RVA = "0xD094C0", Offset = "0xD086C0", VA = "0x180D094C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170014D3")]
		public bool dependencieCardContentFilter
		{
			[Token(Token = "0x60087AA")]
			[Address(RVA = "0xD09490", Offset = "0xD08690", VA = "0x180D09490")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170014D4")]
		public IReadOnlyList<int> result
		{
			[Token(Token = "0x60087AB")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014D5")]
		public IReadOnlyList<int> styleResult
		{
			[Token(Token = "0x60087AC")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60087AD")]
		[Address(RVA = "0xD08EC0", Offset = "0xD080C0", VA = "0x180D08EC0")]
		public void Execute()
		{
		}

		[Token(Token = "0x60087AE")]
		[Address(RVA = "0xD092C0", Offset = "0xD084C0", VA = "0x180D092C0")]
		private void RefreshStyleResult()
		{
		}

		[Token(Token = "0x60087AF")]
		[Address(RVA = "0xD09240", Offset = "0xD08440", VA = "0x180D09240")]
		private static void FilterByText(string filterText, List<int> source, List<int> result)
		{
		}

		[Token(Token = "0x60087B0")]
		[Address(RVA = "0xD090A0", Offset = "0xD082A0", VA = "0x180D090A0")]
		private static void FilterByRarity(int filterRarity, List<int> source, List<int> result)
		{
		}

		[Token(Token = "0x60087B1")]
		[Address(RVA = "0xD09470", Offset = "0xD08670", VA = "0x180D09470")]
		public CardFilter()
		{
		}
	}

	[Token(Token = "0x20015DA")]
	private class CardWidget : ElementWidgetBase
	{
		[Token(Token = "0x400CFDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string k_ECardLabelButton;

		[Token(Token = "0x400CFE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string k_ECardLabelNoCard;

		[Token(Token = "0x400CFE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string k_ECardLabelHighlight;

		[Token(Token = "0x400CFE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string k_ECardLabelIconRarity;

		[Token(Token = "0x400CFE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string k_ECardLabelLimitIcon;

		[Token(Token = "0x400CFE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string k_ECardLabelNumTextArea;

		[Token(Token = "0x400CFE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string k_ECardLabelNumText;

		[Token(Token = "0x400CFE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string k_ECardLabelNewIcon;

		[Token(Token = "0x400CFE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_Idx;

		[Token(Token = "0x400CFE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_Mrk;

		[Token(Token = "0x400CFE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_StyleId;

		[Token(Token = "0x400CFEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly RawImage m_CardRawImage;

		[Token(Token = "0x400CFEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private BindingCardMaterial m_BindingCardMaterial;

		[Token(Token = "0x400CFEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int regurationId;

		[Token(Token = "0x170014D6")]
		public int idx
		{
			[Token(Token = "0x60087B2")]
			[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170014D7")]
		public bool highlightVisible
		{
			[Token(Token = "0x60087B3")]
			[Address(RVA = "0xD0DB30", Offset = "0xD0CD30", VA = "0x180D0DB30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60087B4")]
			[Address(RVA = "0xD0DD50", Offset = "0xD0CF50", VA = "0x180D0DD50")]
			set
			{
			}
		}

		[Token(Token = "0x170014D8")]
		public bool newIconVisible
		{
			[Token(Token = "0x60087B5")]
			[Address(RVA = "0xD0DC50", Offset = "0xD0CE50", VA = "0x180D0DC50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60087B6")]
			[Address(RVA = "0xD0DDD0", Offset = "0xD0CFD0", VA = "0x180D0DDD0")]
			set
			{
			}
		}

		[Token(Token = "0x170014D9")]
		public bool limitIconVisible
		{
			[Token(Token = "0x60087B7")]
			[Address(RVA = "0x8E5280", Offset = "0x8E4480", VA = "0x1808E5280")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60087B8")]
			[Address(RVA = "0x8E54E0", Offset = "0x8E46E0", VA = "0x1808E54E0")]
			set
			{
			}
		}

		[Token(Token = "0x170014DA")]
		public Image limitIconImage
		{
			[Token(Token = "0x60087B9")]
			[Address(RVA = "0xD0DC00", Offset = "0xD0CE00", VA = "0x180D0DC00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014DB")]
		public bool innerTextVisible
		{
			[Token(Token = "0x60087BA")]
			[Address(RVA = "0xD0DB70", Offset = "0xD0CD70", VA = "0x180D0DB70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60087BB")]
			[Address(RVA = "0xD0DD90", Offset = "0xD0CF90", VA = "0x180D0DD90")]
			set
			{
			}
		}

		[Token(Token = "0x170014DC")]
		public TMP_Text innerText
		{
			[Token(Token = "0x60087BC")]
			[Address(RVA = "0xD0DBB0", Offset = "0xD0CDB0", VA = "0x180D0DBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014DD")]
		public SelectionButton button
		{
			[Token(Token = "0x60087BD")]
			[Address(RVA = "0xD0DAE0", Offset = "0xD0CCE0", VA = "0x180D0DAE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014DE")]
		public GameObject noCard
		{
			[Token(Token = "0x60087BE")]
			[Address(RVA = "0x88DAB0", Offset = "0x88CCB0", VA = "0x18088DAB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014DF")]
		public BindingCardMaterial bindingCardMaterial
		{
			[Token(Token = "0x60087BF")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000B9")]
		public event Action<CardWidget> onClickEvent
		{
			[Token(Token = "0x60087C0")]
			[Address(RVA = "0xD0DA20", Offset = "0xD0CC20", VA = "0x180D0DA20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60087C1")]
			[Address(RVA = "0xD0DC90", Offset = "0xD0CE90", VA = "0x180D0DC90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60087C2")]
		[Address(RVA = "0xD0D680", Offset = "0xD0C880", VA = "0x180D0D680")]
		public static CardWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		[Token(Token = "0x60087C3")]
		[Address(RVA = "0xD0D6E0", Offset = "0xD0C8E0", VA = "0x180D0D6E0")]
		public CardWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x60087C4")]
		[Address(RVA = "0xD0D430", Offset = "0xD0C630", VA = "0x180D0D430", Slot = "10")]
		public virtual void Binding(int idx, int mrk, int styleId = 1)
		{
		}

		[Token(Token = "0x60087C5")]
		[Address(RVA = "0xCBC950", Offset = "0xCBBB50", VA = "0x180CBC950", Slot = "11")]
		protected virtual void OnClick()
		{
		}
	}

	[Token(Token = "0x20015DB")]
	private class FilterFormWidget : ElementWidgetBase
	{
		[Token(Token = "0x400CFEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelDisplayInFilterText;

		[Token(Token = "0x400CFEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelFilterRarityTabs;

		[Token(Token = "0x400CFF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string k_ELabelNumGroup;

		[Token(Token = "0x400CFF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string k_ELabelNumText;

		[Token(Token = "0x400CFF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DirectionalTabGroup rarityTabGroup;

		[Token(Token = "0x400CFF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InputFieldWidget nameInputWidget;

		[Token(Token = "0x400CFF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TMP_Text displayInFilterText;

		[Token(Token = "0x170014E0")]
		public GameObject filterResultRoot
		{
			[Token(Token = "0x60087C6")]
			[Address(RVA = "0xD178C0", Offset = "0xD16AC0", VA = "0x180D178C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014E1")]
		public GameObject numGroup
		{
			[Token(Token = "0x60087C7")]
			[Address(RVA = "0x995700", Offset = "0x994900", VA = "0x180995700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014E2")]
		public TMP_Text numText
		{
			[Token(Token = "0x60087C8")]
			[Address(RVA = "0xD17910", Offset = "0xD16B10", VA = "0x180D17910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60087C9")]
		[Address(RVA = "0xD17760", Offset = "0xD16960", VA = "0x180D17760")]
		public FilterFormWidget(ElementObjectManager filterFormEom, InputFieldWidget filterInputField)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20015DF")]
	[CompilerGenerated]
	private struct _003CUpdateListDisplay_003Ed__95 : IAsyncStateMachine
	{
		[Token(Token = "0x400CFFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400CFFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400CFFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CardListBrowserViewController _003C_003E4__this;

		[Token(Token = "0x400CFFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60087D1")]
		[Address(RVA = "0xD19F20", Offset = "0xD19120", VA = "0x180D19F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60087D2")]
		[Address(RVA = "0x418110", Offset = "0x417310", VA = "0x180418110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400CF89")]
	public const string k_ArgOpenOnHome = "onHome";

	[Token(Token = "0x400CF8A")]
	public const string k_ArgTitle = "title";

	[Token(Token = "0x400CF8B")]
	public const string k_ArgMessageText = "MessageText";

	[Token(Token = "0x400CF8C")]
	private const string k_ArgCardMrks = "cardMrks";

	[Token(Token = "0x400CF8D")]
	private const string k_ArgStyleIds = "styleIds";

	[Token(Token = "0x400CF8E")]
	public const string k_ArgRegulationVisible = "regulationVisible";

	[Token(Token = "0x400CF8F")]
	public const string k_ArgRegulationId = "regulationId";

	[Token(Token = "0x400CF90")]
	public const string k_ArgRegulationSelectorVisible = "regulationSelectorVisible";

	[Token(Token = "0x400CF91")]
	public const string k_ArgShowOwnedNumToggleVisible = "showOwnedNumToggleVisible";

	[Token(Token = "0x400CF92")]
	public const string k_ArgRequestCardTermData = "requestCardInfo";

	[Token(Token = "0x400CF93")]
	public const string k_ArgShowHighlightReleasedCardsToggleVisible = "showHighlightReleasedCardsToggleVisible";

	[Token(Token = "0x400CF94")]
	public const string k_ArgOptionalButtonLabel = "OptionalButtonLabel";

	[Token(Token = "0x400CF95")]
	public const string k_ArgOptionalButtonCallback = "OptionalButtonCallback";

	[Token(Token = "0x400CF96")]
	public const string k_ArgHasNumVisible = "hasNumVisible";

	[Token(Token = "0x400CF97")]
	public const string k_ArgHasNumMonochrome = "hasNumMonochrome";

	[Token(Token = "0x400CF98")]
	public const string k_ArgHasNumAtPremium = "hasNumAtPremium";

	[Token(Token = "0x400CF99")]
	public const string k_ArgHighlightReleasedCards = "HighlightReleasedCards";

	[Token(Token = "0x400CF9A")]
	public const string k_ArgEnableFilterForm = "EnablefilterForm";

	[Token(Token = "0x400CF9B")]
	public const string k_ArgEnableDisplayFilterNum = "DisplayFilterNum";

	[Token(Token = "0x400CF9C")]
	public const string k_ArgBgId = "bgId";

	[Token(Token = "0x400CF9D")]
	public const string k_ArgCustomOnClickCardCallback = "CustomOnClickCardCallback";

	[Token(Token = "0x400CF9E")]
	private const int k_DisplayIdx_All = 0;

	[Token(Token = "0x400CF9F")]
	private const int k_DisplayIdx_HasNum = 1;

	[Token(Token = "0x400CFA0")]
	private const int k_DisplayIdx_HighlightReleasedCards = 2;

	[Token(Token = "0x400CFA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private string m_ELabelRegulationButton;

	[Token(Token = "0x400CFA2")]
	private const string k_ELabelRegulationIcon = "RegulationIcon";

	[Token(Token = "0x400CFA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_VLabelDefault;

	[Token(Token = "0x400CFA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_VLabelMessageDefault;

	[Token(Token = "0x400CFA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_VLabelFiltered;

	[Token(Token = "0x400CFA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_TLabelCards_OnLoadingBegin;

	[Token(Token = "0x400CFA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_TLabelCards_OnLoadingEnd;

	[Token(Token = "0x400CFA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x400CFA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x400CFAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelMessageText;

	[Token(Token = "0x400CFAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelCardList;

	[Token(Token = "0x400CFAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string k_ELabelEmptyText;

	[Token(Token = "0x400CFAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_ELabelCardsLoadingIcon;

	[Token(Token = "0x400CFAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelRegulationButtonRoot;

	[Token(Token = "0x400CFAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string k_ELabelShowOwnedNumToggleRoot;

	[Token(Token = "0x400CFB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string k_ELabelShowOwnedNumToggle;

	[Token(Token = "0x400CFB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string k_ELabelDisplaySelectButtonRoot;

	[Token(Token = "0x400CFB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string k_ELabelDisplaySelectButton;

	[Token(Token = "0x400CFB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string k_ELabelDisplaySelectText;

	[Token(Token = "0x400CFB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string k_ELabelOptionalButtonRoot;

	[Token(Token = "0x400CFB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string k_ELabelOptionalButton;

	[Token(Token = "0x400CFB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string k_ELabelOptionalButtonText;

	[Token(Token = "0x400CFB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string k_ELabelFilterInputFieldRoot;

	[Token(Token = "0x400CFB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string k_ELabelFilterForm;

	[Token(Token = "0x400CFB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string k_ELabelFilterInputField;

	[Token(Token = "0x400CFBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private string m_MessageTextStr;

	[Token(Token = "0x400CFBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private List<int> m_CardMrks;

	[Token(Token = "0x400CFBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private IReadOnlyList<int> m_StyleIds;

	[Token(Token = "0x400CFBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private IReadOnlyList<int> m_DisplayCardMrks;

	[Token(Token = "0x400CFBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private IReadOnlyList<int> m_DisplayStyleIds;

	[Token(Token = "0x400CFBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool m_RegulationVisible;

	[Token(Token = "0x400CFC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
	private bool m_HasNumVisible;

	[Token(Token = "0x400CFC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
	private bool m_HasNumMonochrome;

	[Token(Token = "0x400CFC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
	private bool m_HighlightReleasedCards;

	[Token(Token = "0x400CFC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private int m_RegulationId;

	[Token(Token = "0x400CFC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private int m_CurrentDisplayIdx;

	[Token(Token = "0x400CFC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private bool m_RequestedLoadRegulationIcon;

	[Token(Token = "0x400CFC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private ActionSheetViewController.EntryData[] m_DisplaySheetEntries;

	[Token(Token = "0x400CFC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private ToggleWidget m_ShowOwnedNumToggle;

	[Token(Token = "0x400CFC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private SelectionButton m_DisplaySelectButton;

	[Token(Token = "0x400CFC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private TMP_Text m_DisplaySelectText;

	[Token(Token = "0x400CFCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400CFCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private TMP_Text m_EmptyText;

	[Token(Token = "0x400CFCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private RegulationSelectSheet m_RegulationSelectSheet;

	[Token(Token = "0x400CFCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private FilterFormWidget m_FilterFormWidget;

	[Token(Token = "0x400CFCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Dictionary<GameObject, CardWidget> m_CardWidgetDic;

	[Token(Token = "0x400CFCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private CardFilter m_CardFilter;

	[Token(Token = "0x400CFD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private int m_BgId;

	[Token(Token = "0x400CFD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private bool m_UpdateCardListBlocker;

	[Token(Token = "0x400CFD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21D")]
	private bool m_UpdateCardListRequestOnBlock;

	[Token(Token = "0x400CFD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21E")]
	private bool m_IsPlayingLoadingIcon;

	[Token(Token = "0x170014C7")]
	private GameObject cardsLoadingIcon
	{
		[Token(Token = "0x600877D")]
		[Address(RVA = "0xD0CAB0", Offset = "0xD0BCB0", VA = "0x180D0CAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014C8")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600877E")]
		[Address(RVA = "0xD0CAF0", Offset = "0xD0BCF0", VA = "0x180D0CAF0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014C9")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600877F")]
		[Address(RVA = "0x3F2290", Offset = "0x3F1490", VA = "0x1803F2290", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014CA")]
	public IReadOnlyList<int> displayCardMrks
	{
		[Token(Token = "0x6008780")]
		[Address(RVA = "0xD0CAE0", Offset = "0xD0BCE0", VA = "0x180D0CAE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014CB")]
	public IReadOnlyList<int> displayStyleIds
	{
		[Token(Token = "0x6008781")]
		[Address(RVA = "0xA8F0E0", Offset = "0xA8E2E0", VA = "0x180A8F0E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008782")]
	[Address(RVA = "0xD0AA00", Offset = "0xD09C00", VA = "0x180D0AA00")]
	public static void OpenByConfig(string configPath, IReadOnlyList<int> cardMrks, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008783")]
	[Address(RVA = "0xD0AD20", Offset = "0xD09F20", VA = "0x180D0AD20")]
	public static void Open(string title, IReadOnlyList<int> cardMrks, [Optional] ViewControllerManager manager, [Optional] Dictionary<string, object> args, [Optional] IReadOnlyList<int> cardStyles)
	{
	}

	[Token(Token = "0x6008784")]
	[Address(RVA = "0xD0AC10", Offset = "0xD09E10", VA = "0x180D0AC10")]
	public static void Open([Optional] ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008785")]
	[Address(RVA = "0xD096C0", Offset = "0xD088C0", VA = "0x180D096C0")]
	private string GetViewPrefLabel()
	{
		return null;
	}

	[Token(Token = "0x6008786")]
	[Address(RVA = "0xD09770", Offset = "0xD08970", VA = "0x180D09770", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008787")]
	[Address(RVA = "0xD099F0", Offset = "0xD08BF0", VA = "0x180D099F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008788")]
	[Address(RVA = "0xD09CD0", Offset = "0xD08ED0", VA = "0x180D09CD0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008789")]
	[Address(RVA = "0xD0AFD0", Offset = "0xD0A1D0", VA = "0x180D0AFD0")]
	private void Start()
	{
	}

	[Token(Token = "0x600878A")]
	[Address(RVA = "0xD0C420", Offset = "0xD0B620", VA = "0x180D0C420")]
	[AsyncStateMachine(typeof(_003CUpdateListDisplay_003Ed__95))]
	private void UpdateListDisplay()
	{
	}

	[Token(Token = "0x600878B")]
	[Address(RVA = "0xD0C030", Offset = "0xD0B230", VA = "0x180D0C030")]
	private void UpdateCardlistInfos()
	{
	}

	[Token(Token = "0x600878C")]
	[Address(RVA = "0xD0AE40", Offset = "0xD0A040", VA = "0x180D0AE40")]
	private void PlayLoadingList()
	{
	}

	[Token(Token = "0x600878D")]
	[Address(RVA = "0xD0BD60", Offset = "0xD0AF60", VA = "0x180D0BD60")]
	private void StopLoadingList()
	{
	}

	[Token(Token = "0x600878E")]
	[Address(RVA = "0xD0AF40", Offset = "0xD0A140", VA = "0x180D0AF40")]
	private void PlayLoadingTween(GameObject target, string label)
	{
	}

	[Token(Token = "0x600878F")]
	[Address(RVA = "0xD09600", Offset = "0xD08800", VA = "0x180D09600")]
	private void ApplyCurrentDisplay()
	{
	}

	[Token(Token = "0x6008790")]
	[Address(RVA = "0xD0C4D0", Offset = "0xD0B6D0", VA = "0x180D0C4D0")]
	private void UpdateRegulationIcon()
	{
	}

	[Token(Token = "0x6008791")]
	[Address(RVA = "0xD0A3B0", Offset = "0xD095B0", VA = "0x180D0A3B0")]
	public void OnEntityCreated(GameObject gob)
	{
	}

	[Token(Token = "0x6008792")]
	[Address(RVA = "0xD0A610", Offset = "0xD09810", VA = "0x180D0A610")]
	public void OnEntityUpdate(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6008793")]
	[Address(RVA = "0xD09A50", Offset = "0xD08C50", VA = "0x180D09A50")]
	private void OnClickEntity(CardWidget clickedWidget)
	{
	}

	[Token(Token = "0x6008794")]
	[Address(RVA = "0xD0A9C0", Offset = "0xD09BC0", VA = "0x180D0A9C0")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x6008795")]
	[Address(RVA = "0xD0AB70", Offset = "0xD09D70", VA = "0x180D0AB70")]
	private void OpenRegurationSelectSheet()
	{
	}

	[Token(Token = "0x6008796")]
	[Address(RVA = "0xD0C5A0", Offset = "0xD0B7A0", VA = "0x180D0C5A0")]
	public CardListBrowserViewController()
	{
	}
}
