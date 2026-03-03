using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x20006D0")]
public class DeckBrowserForDuel : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x20006D6")]
	[CompilerGenerated]
	private sealed class _003CInitDeckCards_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002262")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0x20")]
		public List<CardBaseData> main;

		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x28")]
		public DeckBrowserForDuel _003C_003E4__this;

		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0x30")]
		public List<CardBaseData> extra;

		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0x38")]
		public Action onFinish;

		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0x40")]
		private int _003CprevDeckContent_003E5__2;

		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0x48")]
		private List<CardBaseData>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x170005A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DA2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DA4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D9D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitDeckCards_003Ed__95(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D9E")]
		[Address(RVA = "0x707870", Offset = "0x706A70", VA = "0x180707870", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x706FF0", Offset = "0x7061F0", VA = "0x180706FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x7079A0", Offset = "0x706BA0", VA = "0x1807079A0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x7079F0", Offset = "0x706BF0", VA = "0x1807079F0")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0x707830", Offset = "0x706A30", VA = "0x180707830", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002234")]
	private const string m_PrefPath = "Prefabs/Duel/UI/DeckBrowserUIForDuel";

	[Token(Token = "0x4002235")]
	private const string m_PrefPathMobile = "Prefabs/Duel/UI/DeckBrowserUIForDuel_Mobile";

	[Token(Token = "0x4002236")]
	[FieldOffset(Offset = "0x20")]
	private DuelClient m_Host;

	[Token(Token = "0x4002237")]
	[FieldOffset(Offset = "0x28")]
	protected ElementObjectManager m_Eom;

	[Token(Token = "0x4002238")]
	[FieldOffset(Offset = "0x30")]
	protected SelectionButton m_CloseButton;

	[Token(Token = "0x400223A")]
	[FieldOffset(Offset = "0x40")]
	private SelectionItem m_LastSelectedItem;

	[Token(Token = "0x400223B")]
	[FieldOffset(Offset = "0x48")]
	private int currentSelectIndex;

	[Token(Token = "0x400223C")]
	[FieldOffset(Offset = "0x50")]
	protected CardInfoForGenericCardListEx m_CardInfo;

	[Token(Token = "0x400223D")]
	private const int MAX_COL = 8;

	[Token(Token = "0x400223E")]
	private const int MAX_COL_MOBILE = 5;

	[Token(Token = "0x400223F")]
	[FieldOffset(Offset = "0x58")]
	public UnityAction onShow;

	[Token(Token = "0x4002240")]
	[FieldOffset(Offset = "0x60")]
	public UnityAction onClose;

	[Token(Token = "0x4002241")]
	[FieldOffset(Offset = "0x68")]
	private bool isInitialized;

	[Token(Token = "0x400224A")]
	[FieldOffset(Offset = "0xB0")]
	protected FullScreenUiBg m_FullScreenUiBg;

	[Token(Token = "0x400224B")]
	[FieldOffset(Offset = "0xB8")]
	protected UiSwitchTweenAnimationController m_UiSwitchTweenAnimationController;

	[Token(Token = "0x400224F")]
	[FieldOffset(Offset = "0xD8")]
	private SortComparer.Sorter m_DefaultSorter;

	[Token(Token = "0x4002251")]
	[FieldOffset(Offset = "0xE8")]
	private DeckView.DeckContentWidget deckContents;

	[Token(Token = "0x4002252")]
	[FieldOffset(Offset = "0xF0")]
	public List<CardBaseData> mainCardDataList;

	[Token(Token = "0x4002253")]
	[FieldOffset(Offset = "0xF8")]
	public List<CardBaseData> extraCardDataList;

	[Token(Token = "0x4002254")]
	[FieldOffset(Offset = "0x100")]
	private bool isShowing;

	[Token(Token = "0x4002255")]
	[FieldOffset(Offset = "0x101")]
	private bool isClosing;

	[Token(Token = "0x17000598")]
	public bool isTmpClose
	{
		[Token(Token = "0x6002D56")]
		[Address(RVA = "0x62F1A0", Offset = "0x62E3A0", VA = "0x18062F1A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000599")]
	private int tmpCloseCount
	{
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700059A")]
	private ElementObjectManager m_ScrollEom
	{
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700059B")]
	private ExtendedScrollRect m_Scroll
	{
		[Token(Token = "0x6002D5B")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700059C")]
	private InfinityScrollView m_InfinityScroll
	{
		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700059D")]
	private Selector m_ScrollSelector
	{
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700059E")]
	public RectTransform m_ScrollContent
	{
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700059F")]
	private GameObject m_ScrollBlocker
	{
		[Token(Token = "0x6002D63")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A0")]
	private GameObject m_Loading
	{
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A1")]
	private RectTransform m_Viewport
	{
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A2")]
	private ExtendedTextMeshProUGUI m_DeckName
	{
		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A3")]
	private ExtendedTextMeshProUGUI m_MainDeckNum
	{
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A4")]
	private ExtendedTextMeshProUGUI m_ExtraDeckNum
	{
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A5")]
	private EntityPoolController m_EntityPoolController
	{
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170005A6")]
	public string poolKey
	{
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x702EA0", Offset = "0x7020A0", VA = "0x180702EA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A7")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002D72")]
	[Address(RVA = "0x701AC0", Offset = "0x700CC0", VA = "0x180701AC0", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6002D74")]
	[Address(RVA = "0x7006A0", Offset = "0x6FF8A0", VA = "0x1807006A0")]
	public static void Create(DuelClient host, Transform parent, UnityAction<int, int> onClick, UnityAction<DeckBrowserForDuel> onFinish)
	{
	}

	[Token(Token = "0x6002D75")]
	[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
	public void SetFullScreenUiBg(FullScreenUiBg fullScreenUiBg)
	{
	}

	[Token(Token = "0x6002D76")]
	[Address(RVA = "0x700520", Offset = "0x6FF720", VA = "0x180700520")]
	public void Close(bool tmpClose = false, bool closebg = true)
	{
	}

	[Token(Token = "0x6002D77")]
	[Address(RVA = "0x7015D0", Offset = "0x7007D0", VA = "0x1807015D0")]
	protected void Initialize(UnityAction<int, int> onClick, DuelClient host, bool onCreated = true)
	{
	}

	[Token(Token = "0x6002D78")]
	[Address(RVA = "0x700F50", Offset = "0x700150", VA = "0x180700F50")]
	protected void InitializeOnCreated(UnityAction<int, int> onClick, DuelClient host)
	{
	}

	[Token(Token = "0x6002D79")]
	[Address(RVA = "0x700AE0", Offset = "0x6FFCE0", VA = "0x180700AE0")]
	private void InitScroll()
	{
	}

	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0x701830", Offset = "0x700A30", VA = "0x180701830")]
	public void OnCreateEntity(GameObject obj)
	{
	}

	[Token(Token = "0x6002D7B")]
	[Address(RVA = "0x701BA0", Offset = "0x700DA0", VA = "0x180701BA0")]
	public void OnUpdateEntity(GameObject obj, int idx)
	{
	}

	[Token(Token = "0x6002D7C")]
	[Address(RVA = "0x702D20", Offset = "0x701F20", VA = "0x180702D20")]
	public void UpdateView()
	{
	}

	[Token(Token = "0x6002D7D")]
	[Address(RVA = "0x700DE0", Offset = "0x6FFFE0", VA = "0x180700DE0")]
	public void InitializeDeckContents()
	{
	}

	[Token(Token = "0x6002D7E")]
	[Address(RVA = "0x700380", Offset = "0x6FF580", VA = "0x180700380")]
	private DeckCard AddCard(CardBaseData cbd, DeckCard.LocationInDeck loc, int reg)
	{
		return null;
	}

	[Token(Token = "0x6002D7F")]
	[Address(RVA = "0x7008B0", Offset = "0x6FFAB0", VA = "0x1807008B0")]
	private List<CardBaseData> GetDataList(DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x6002D80")]
	[Address(RVA = "0x702410", Offset = "0x701610", VA = "0x180702410")]
	public void Open()
	{
	}

	[Token(Token = "0x6002D81")]
	[Address(RVA = "0x702820", Offset = "0x701A20", VA = "0x180702820")]
	public void ResetTmpCloseCount()
	{
	}

	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x702660", Offset = "0x701860", VA = "0x180702660")]
	public void Open(List<CardBaseData> main, List<CardBaseData> extra)
	{
	}

	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x700A20", Offset = "0x6FFC20", VA = "0x180700A20")]
	[IteratorStateMachine(typeof(_003CInitDeckCards_003Ed__95))]
	private IEnumerator InitDeckCards(List<CardBaseData> main, List<CardBaseData> extra, Action onFinish)
	{
		return null;
	}

	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x7008D0", Offset = "0x6FFAD0", VA = "0x1807008D0")]
	private void InitCardInfo(UnityAction<int, int> onClick, bool ismobile, bool onCreated = true)
	{
	}

	[Token(Token = "0x6002D85")]
	[Address(RVA = "0x701B80", Offset = "0x700D80", VA = "0x180701B80")]
	private void OnShowEvent()
	{
	}

	[Token(Token = "0x6002D86")]
	[Address(RVA = "0x701810", Offset = "0x700A10", VA = "0x180701810")]
	private void OnCloseEvent()
	{
	}

	[Token(Token = "0x6002D87")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002D88")]
	[Address(RVA = "0x702D80", Offset = "0x701F80", VA = "0x180702D80")]
	public DeckBrowserForDuel()
	{
	}
}
