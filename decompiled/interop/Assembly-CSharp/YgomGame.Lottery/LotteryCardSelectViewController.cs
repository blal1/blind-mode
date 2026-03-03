using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Card;
using YgomGame.CardPoolSelect;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Lottery;

[Token(Token = "0x20016FB")]
public class LotteryCardSelectViewController : BaseMenuViewController, ILotteryChildViewControllerGroup
{
	[Token(Token = "0x20016FC")]
	protected enum ViewType
	{
		[Token(Token = "0x400DA09")]
		None,
		[Token(Token = "0x400DA0A")]
		CardCollection,
		[Token(Token = "0x400DA0B")]
		Deck,
		[Token(Token = "0x400DA0C")]
		Unknown
	}

	[Token(Token = "0x20016FD")]
	protected enum SelectedCardType
	{
		[Token(Token = "0x400DA0E")]
		None,
		[Token(Token = "0x400DA0F")]
		CollectionCard,
		[Token(Token = "0x400DA10")]
		PikcupCard
	}

	[Token(Token = "0x20016FF")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass112_0
	{
		[Token(Token = "0x400DA1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int api_result;

		[Token(Token = "0x400DA1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action _003C_003E9__12;

		[Token(Token = "0x400DA1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<LotteryCode> _003C_003E9__13;

		[Token(Token = "0x6009075")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass112_0()
		{
		}

		[Token(Token = "0x6009076")]
		[Address(RVA = "0xDBA3D0", Offset = "0xDB95D0", VA = "0x180DBA3D0")]
		internal void _003CInitializeCardCollectionView_003Eb__11(Handle handle)
		{
		}

		[Token(Token = "0x6009077")]
		[Address(RVA = "0xB7F3E0", Offset = "0xB7E5E0", VA = "0x180B7F3E0")]
		internal void _003CInitializeCardCollectionView_003Eb__12()
		{
		}

		[Token(Token = "0x6009078")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CInitializeCardCollectionView_003Eb__13(LotteryCode code)
		{
		}
	}

	[Token(Token = "0x200170B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass160_0
	{
		[Token(Token = "0x400DA36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LotteryCardSelectViewController _003C_003E4__this;

		[Token(Token = "0x400DA37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SortComparer.Sorter sorter;

		[Token(Token = "0x400DA38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Comparison<CardBaseData> _003C_003E9__4;

		[Token(Token = "0x60090AE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass160_0()
		{
		}

		[Token(Token = "0x60090AF")]
		[Address(RVA = "0xDBD290", Offset = "0xDBC490", VA = "0x180DBD290")]
		internal void _003CAsyncFilterAndSort_003Eb__2()
		{
		}

		[Token(Token = "0x60090B0")]
		[Address(RVA = "0xDBD2D0", Offset = "0xDBC4D0", VA = "0x180DBD2D0")]
		internal void _003CAsyncFilterAndSort_003Eb__3()
		{
		}

		[Token(Token = "0x60090B1")]
		[Address(RVA = "0xDBD1D0", Offset = "0xDBC3D0", VA = "0x180DBD1D0")]
		internal void _003CAsyncFilterAndSort_003Eb__1()
		{
		}

		[Token(Token = "0x60090B2")]
		[Address(RVA = "0xDBD390", Offset = "0xDBC590", VA = "0x180DBD390")]
		internal int _003CAsyncFilterAndSort_003Eb__4(CardBaseData a, CardBaseData b)
		{
			return default(int);
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200170C")]
	[CompilerGenerated]
	private struct _003CAsyncFilterAndSort_003Ed__160 : IAsyncStateMachine
	{
		[Token(Token = "0x400DA39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400DA3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400DA3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LotteryCardSelectViewController _003C_003E4__this;

		[Token(Token = "0x400DA3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass160_0 _003C_003E8__1;

		[Token(Token = "0x400DA3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool setAll;

		[Token(Token = "0x400DA3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool filter;

		[Token(Token = "0x400DA3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onFinish;

		[Token(Token = "0x400DA40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60090B3")]
		[Address(RVA = "0xDB8880", Offset = "0xDB7A80", VA = "0x180DB8880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60090B4")]
		[Address(RVA = "0xDB90B0", Offset = "0xDB82B0", VA = "0x180DB90B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200170D")]
	[CompilerGenerated]
	private sealed class _003CInitializeCardCollectionView_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DA41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DA42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DA43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LotteryCardSelectViewController _003C_003E4__this;

		[Token(Token = "0x400DA44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass112_0 _003C_003E8__1;

		[Token(Token = "0x17001639")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60090B8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700163A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60090BA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60090B5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeCardCollectionView_003Ed__112(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60090B6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60090B7")]
		[Address(RVA = "0xDB9110", Offset = "0xDB8310", VA = "0x180DB9110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60090B9")]
		[Address(RVA = "0xDB9AE0", Offset = "0xDB8CE0", VA = "0x180DB9AE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200170E")]
	[CompilerGenerated]
	private sealed class _003CrandomPickupCards_003Ed__162 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DA45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DA46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DA47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LotteryCardSelectViewController _003C_003E4__this;

		[Token(Token = "0x400DA48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Clast_cursor_003E5__2;

		[Token(Token = "0x400DA49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int[] _003CpickupCardIDs_003E5__3;

		[Token(Token = "0x400DA4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x1700163B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60090BE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700163C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60090C0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60090BB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CrandomPickupCards_003Ed__162(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60090BC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60090BD")]
		[Address(RVA = "0xDBE660", Offset = "0xDBD860", VA = "0x180DBE660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60090BF")]
		[Address(RVA = "0xDBED80", Offset = "0xDBDF80", VA = "0x180DBED80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D9BA")]
	private const string k_prefabPath = "Lottery/LotteryCardSelect";

	[Token(Token = "0x400D9BB")]
	private const string k_argKeyLotteryID = "LotteryID";

	[Token(Token = "0x400D9BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int m_lotteryID;

	[Token(Token = "0x400D9BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private bool m_noHistory;

	[Token(Token = "0x400D9BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	private bool m_initialized;

	[Token(Token = "0x400D9BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
	private bool m_selectedResult;

	[Token(Token = "0x400D9C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ElementObjectManager m_UI;

	[Token(Token = "0x400D9C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static bool isRunningFilterAndSort;

	[Token(Token = "0x400D9C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool firstSort;

	[Token(Token = "0x400D9C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected Content m_cci;

	[Token(Token = "0x400D9C5")]
	private const string LABEL_HEADER = "Header";

	[Token(Token = "0x400D9C6")]
	private const string LABEL_PICKUPVIEW = "PickupView";

	[Token(Token = "0x400D9C7")]
	private const string LABEL_CARDACTIONMENU = "CardActionMenu";

	[Token(Token = "0x400D9C8")]
	private const string LABEL_DETAILVIEW = "DetailView";

	[Token(Token = "0x400D9C9")]
	private const string LABEL_COLLECTIONVIEW = "CollectionView";

	[Token(Token = "0x400D9CA")]
	private const string LABEL_TEMPLATEFOOTERDESC = "TemplateFooterDesc";

	[Token(Token = "0x400D9CB")]
	private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

	[Token(Token = "0x400D9CC")]
	private const string LABEL_DRAGCARD = "DragCard";

	[Token(Token = "0x400D9CD")]
	private const string LABEL_RT_FOOTER = "Footer";

	[Token(Token = "0x400D9CE")]
	private const string LABEL_SBN_DISPLAYMODE = "ButtonInfoSwitching";

	[Token(Token = "0x400D9CF")]
	private const string LABEL_RT_DISPLAYMODE0 = "ButtonInfoSwitching/IconInfoSwitching0";

	[Token(Token = "0x400D9D0")]
	private const string LABEL_RT_DISPLAYMODE1 = "ButtonInfoSwitching/IconInfoSwitching1";

	[Token(Token = "0x400D9D1")]
	private const string LABEL_RT_DISPLAYMODE2 = "ButtonInfoSwitching/IconInfoSwitching2";

	[Token(Token = "0x400D9D2")]
	private const string LABEL_SBN_HISTORYBUTTON = "ButtonHistory";

	[Token(Token = "0x400D9D3")]
	private const string LABEL_SBN_HELPBUTTON = "ButtonHelp";

	[Token(Token = "0x400D9D4")]
	private const string LABEL_SBN_BACKBUTTON = "Back";

	[Token(Token = "0x400D9D5")]
	private const string Label_BGM = "BGM_MENU_02";

	[Token(Token = "0x400D9D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ElementObjectManager m_HeaderEom;

	[Token(Token = "0x400D9D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ElementObjectManager m_PickupViewEom;

	[Token(Token = "0x400D9D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ElementObjectManager m_CardActionMenuEom;

	[Token(Token = "0x400D9D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ElementObjectManager m_DetailViewEom;

	[Token(Token = "0x400D9DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ElementObjectManager m_CollectionViewEom;

	[Token(Token = "0x400D9DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton m_DisplayModeButton;

	[Token(Token = "0x400D9DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private RectTransform m_DisplayMode0;

	[Token(Token = "0x400D9DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private RectTransform m_DisplayMode1;

	[Token(Token = "0x400D9DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private RectTransform m_DisplayMode2;

	[Token(Token = "0x400D9DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private SelectionButton m_HistoryButton;

	[Token(Token = "0x400D9E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private SelectionButton m_HelpButton;

	[Token(Token = "0x400D9E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private SelectionButton m_BackButton;

	[Token(Token = "0x400D9E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected ElementObjectManager m_templateFooterDesc;

	[Token(Token = "0x400D9E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private RectTransform m_Footer;

	[Token(Token = "0x400D9E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected AnalogDirectionListener m_AnalogManager;

	[Token(Token = "0x400D9E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private LotteryCardSelectPickupView m_PickupView;

	[Token(Token = "0x400D9E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private LotteryCardSelectCardActionMenu m_CardActionMenu;

	[Token(Token = "0x400D9E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private CpsCardCollectionView m_CollectionView;

	[Token(Token = "0x400D9E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private LotteryCardSelectCardDetailView m_DetailView;

	[Token(Token = "0x400D9E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool isCardActionMenuOpen;

	[Token(Token = "0x400D9ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private TransitionCard prefabTransitionCard;

	[Token(Token = "0x400D9EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private LotteryCardSelectFooter m_editFooter;

	[Token(Token = "0x400D9EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private string LABEL_DropArea_Collection;

	[Token(Token = "0x400D9F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private string LABEL_DropArea_Pickup;

	[Token(Token = "0x400D9F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	protected Dictionary<string, UnityAction> dropAreaActions;

	[Token(Token = "0x400D9F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	protected Dictionary<string, DropArea> dropAreas;

	[Token(Token = "0x400D9F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private Camera m_Camera;

	[Token(Token = "0x400D9F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private List<FilterDialog.FilterGroupType> m_FilterGroupTypes;

	[Token(Token = "0x400D9F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private SearchFilter.Setting m_FilterSettings;

	[Token(Token = "0x400D9F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private FilterDialog.OptionMask m_FilterOptionMask;

	[Token(Token = "0x400D9F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private SortComparer.Sorter m_Sorter;

	[Token(Token = "0x400D9F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private string m_CardListSearchKeyword;

	[Token(Token = "0x400D9F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private FilterDialogManager m_FilterDialogManager;

	[Token(Token = "0x400D9FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private float holdTime;

	[Token(Token = "0x400D9FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	protected ViewType currentView;

	[Token(Token = "0x400D9FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	protected SelectedCardType m_footerSelectingCardType;

	[Token(Token = "0x400D9FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private bool option1Activate;

	[Token(Token = "0x400D9FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x225")]
	private bool option2Activate;

	[Token(Token = "0x400D9FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x226")]
	private bool option1ActivateChecker;

	[Token(Token = "0x400DA00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x227")]
	private bool option2ActivateChecker;

	[Token(Token = "0x400DA01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private bool mainViewActivated;

	[Token(Token = "0x400DA02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	[SerializeField]
	protected KeyConfigContainer keyConfig;

	[Token(Token = "0x400DA03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private bool horizontalSwipe;

	[Token(Token = "0x400DA04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private Vector2 pressedPoint;

	[Token(Token = "0x400DA05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly SortComparer.METHOD[] s_sortMethodList;

	[Token(Token = "0x400DA06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private bool requestUpdateView;

	[Token(Token = "0x400DA07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x245")]
	private bool m_isRunningRandomPickup;

	[Token(Token = "0x17001630")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008FED")]
		[Address(RVA = "0xDA1B10", Offset = "0xDA0D10", VA = "0x180DA1B10", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001631")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6008FEE")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001632")]
	private DeckEditViewController2.DisplayMode m_DisplayMode
	{
		[Token(Token = "0x6008FEF")]
		[Address(RVA = "0x4226F0", Offset = "0x4218F0", VA = "0x1804226F0")]
		[CompilerGenerated]
		get
		{
			return default(DeckEditViewController2.DisplayMode);
		}
		[Token(Token = "0x6008FF0")]
		[Address(RVA = "0x422700", Offset = "0x421900", VA = "0x180422700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001633")]
	private DragCard dragCard
	{
		[Token(Token = "0x6008FF1")]
		[Address(RVA = "0xDA1A10", Offset = "0xDA0C10", VA = "0x180DA1A10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001634")]
	private List<CardBaseData> m_CardPool
	{
		[Token(Token = "0x6008FF3")]
		[Address(RVA = "0xAE41F0", Offset = "0xAE33F0", VA = "0x180AE41F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008FF4")]
		[Address(RVA = "0xA91060", Offset = "0xA90260", VA = "0x180A91060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001635")]
	private List<CardBaseData> m_CardCollection
	{
		[Token(Token = "0x6008FF5")]
		[Address(RVA = "0xAE41D0", Offset = "0xAE33D0", VA = "0x180AE41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008FF6")]
		[Address(RVA = "0xA91080", Offset = "0xA90280", VA = "0x180A91080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001636")]
	private List<CardBaseData> m_CardListBuff
	{
		[Token(Token = "0x6008FF7")]
		[Address(RVA = "0xD0CAE0", Offset = "0xD0BCE0", VA = "0x180D0CAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008FF8")]
		[Address(RVA = "0xA910A0", Offset = "0xA902A0", VA = "0x180A910A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001637")]
	protected string m_SearchKeyword
	{
		[Token(Token = "0x6008FFC")]
		[Address(RVA = "0xDA1AC0", Offset = "0xDA0CC0", VA = "0x180DA1AC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008FFD")]
		[Address(RVA = "0x49C500", Offset = "0x49B700", VA = "0x18049C500")]
		set
		{
		}
	}

	[Token(Token = "0x17001638")]
	protected bool isMobile
	{
		[Token(Token = "0x6008FFF")]
		[Address(RVA = "0xDA1A70", Offset = "0xDA0C70", VA = "0x180DA1A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008FEC")]
	[Address(RVA = "0xD9D0C0", Offset = "0xD9C2C0", VA = "0x180D9D0C0")]
	public static void Open(int id = 0)
	{
	}

	[Token(Token = "0x6008FF2")]
	[Address(RVA = "0xD9AB40", Offset = "0xD99D40", VA = "0x180D9AB40")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6008FF9")]
	[Address(RVA = "0xDA3410", Offset = "0xDA2610", VA = "0x180DA3410")]
	private static bool readFilterSettingFromCW(int id, out List<FilterDialog.FilterGroupType> groupTypes, out FilterDialog.OptionMask optionMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6008FFA")]
	[Address(RVA = "0xDA1960", Offset = "0xDA0B60", VA = "0x180DA1960")]
	private static SearchFilter.Setting createDefaultSearchFilterSetting()
	{
		return null;
	}

	[Token(Token = "0x6008FFB")]
	[Address(RVA = "0xDA2F80", Offset = "0xDA2180", VA = "0x180DA2F80")]
	private static bool isDefaultSearchFilterSetting(SearchFilter.Setting setting)
	{
		return default(bool);
	}

	[Token(Token = "0x6008FFE")]
	[Address(RVA = "0xDA26D0", Offset = "0xDA18D0", VA = "0x180DA26D0")]
	private void initializeFilterSort()
	{
	}

	[Token(Token = "0x6009000")]
	[Address(RVA = "0xDA1470", Offset = "0xDA0670", VA = "0x180DA1470")]
	private bool createCardPoolList()
	{
		return default(bool);
	}

	[Token(Token = "0x6009001")]
	[Address(RVA = "0xAE41F0", Offset = "0xAE33F0", VA = "0x180AE41F0")]
	private List<CardBaseData> getCardPoolList()
	{
		return null;
	}

	[Token(Token = "0x6009002")]
	[Address(RVA = "0xD9AFB0", Offset = "0xD9A1B0", VA = "0x180D9AFB0")]
	private void InitializeView()
	{
	}

	[Token(Token = "0x6009003")]
	[Address(RVA = "0xD9DB10", Offset = "0xD9CD10", VA = "0x180D9DB10")]
	private void SetShortcutSettings()
	{
	}

	[Token(Token = "0x6009004")]
	[Address(RVA = "0xD9C1C0", Offset = "0xD9B3C0", VA = "0x180D9C1C0")]
	protected void MainViewActivated()
	{
	}

	[Token(Token = "0x6009005")]
	[Address(RVA = "0xD9C1F0", Offset = "0xD9B3F0", VA = "0x180D9C1F0")]
	protected void MainViewDeactivated()
	{
	}

	[Token(Token = "0x6009006")]
	[Address(RVA = "0xD9AAD0", Offset = "0xD99CD0", VA = "0x180D9AAD0")]
	[IteratorStateMachine(typeof(_003CInitializeCardCollectionView_003Ed__112))]
	private IEnumerator InitializeCardCollectionView()
	{
		return null;
	}

	[Token(Token = "0x6009007")]
	[Address(RVA = "0xD9C220", Offset = "0xD9B420", VA = "0x180D9C220", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6009008")]
	[Address(RVA = "0xD9C580", Offset = "0xD9B780", VA = "0x180D9C580", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6009009")]
	[Address(RVA = "0xD9C670", Offset = "0xD9B870", VA = "0x180D9C670", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600900A")]
	[Address(RVA = "0xD9CC20", Offset = "0xD9BE20", VA = "0x180D9CC20", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x600900B")]
	[Address(RVA = "0xD9F670", Offset = "0xD9E870", VA = "0x180D9F670")]
	private void Start()
	{
	}

	[Token(Token = "0x600900C")]
	[Address(RVA = "0xD9C0B0", Offset = "0xD9B2B0", VA = "0x180D9C0B0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600900D")]
	[Address(RVA = "0xD9CCE0", Offset = "0xD9BEE0", VA = "0x180D9CCE0")]
	public void OnResetSearchButton()
	{
	}

	[Token(Token = "0x600900E")]
	[Address(RVA = "0xD9CF10", Offset = "0xD9C110", VA = "0x180D9CF10")]
	public void OnSubmitSearch(string text)
	{
	}

	[Token(Token = "0x600900F")]
	[Address(RVA = "0xD9C900", Offset = "0xD9BB00", VA = "0x180D9C900")]
	public void OnClickFilterButton()
	{
	}

	[Token(Token = "0x6009010")]
	[Address(RVA = "0xD9CA60", Offset = "0xD9BC60", VA = "0x180D9CA60")]
	public void OnClickSortButton()
	{
	}

	[Token(Token = "0x6009011")]
	[Address(RVA = "0xD9D080", Offset = "0xD9C280", VA = "0x180D9D080")]
	private void OpenPickupCardActionMenu(CardBaseData baseData, int pickUpSlot)
	{
	}

	[Token(Token = "0x6009012")]
	[Address(RVA = "0xD9D040", Offset = "0xD9C240", VA = "0x180D9D040")]
	private void OpenCollectionCardActionMenu(CardBaseData baseData)
	{
	}

	[Token(Token = "0x6009013")]
	[Address(RVA = "0xDA30E0", Offset = "0xDA22E0", VA = "0x180DA30E0")]
	private void openCardActionMenuCore(CardBaseData baseData, int pickUpSlot, bool fromPickupList)
	{
	}

	[Token(Token = "0x6009014")]
	[Address(RVA = "0xD9A8D0", Offset = "0xD99AD0", VA = "0x180D9A8D0")]
	private void CloseActionDialog()
	{
	}

	[Token(Token = "0x6009015")]
	[Address(RVA = "0xDA24B0", Offset = "0xDA16B0", VA = "0x180DA24B0")]
	private void initializeDetailView(CardBaseData baseData)
	{
	}

	[Token(Token = "0x6009016")]
	[Address(RVA = "0xDA27C0", Offset = "0xDA19C0", VA = "0x180DA27C0")]
	protected void initializePickupCard(DeckCard card, int slotIndex, bool setData)
	{
	}

	[Token(Token = "0x6009017")]
	[Address(RVA = "0xDA1D80", Offset = "0xDA0F80", VA = "0x180DA1D80")]
	private void initializeCollectionCard(CardStrip card)
	{
	}

	[Token(Token = "0x6009018")]
	[Address(RVA = "0xD9A5C0", Offset = "0xD997C0", VA = "0x180D9A5C0")]
	public (DeckCard, int) AddToPickupSlot(CardBaseData baseData)
	{
		return default((DeckCard, int));
	}

	[Token(Token = "0x6009019")]
	[Address(RVA = "0xD9A420", Offset = "0xD99620", VA = "0x180D9A420")]
	public DeckCard AddToPickupSlotWithTransition(CardBase card)
	{
		return null;
	}

	[Token(Token = "0x600901A")]
	[Address(RVA = "0xDA3990", Offset = "0xDA2B90", VA = "0x180DA3990")]
	private void showFullSlotMessage()
	{
	}

	[Token(Token = "0x600901B")]
	[Address(RVA = "0xD9D4B0", Offset = "0xD9C6B0", VA = "0x180D9D4B0")]
	public DeckCard RemoveFromPickupSlot(CardBaseData baseData)
	{
		return null;
	}

	[Token(Token = "0x600901C")]
	[Address(RVA = "0xD9D1B0", Offset = "0xD9C3B0", VA = "0x180D9D1B0")]
	public DeckCard RemoveFromPickupSlotByIndex(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x600901D")]
	[Address(RVA = "0xD9D2B0", Offset = "0xD9C4B0", VA = "0x180D9D2B0")]
	private void RemoveFromPickupSlotWithTransition(DeckCard card, int slotIndex)
	{
	}

	[Token(Token = "0x600901E")]
	[Address(RVA = "0xDA3CE0", Offset = "0xDA2EE0", VA = "0x180DA3CE0")]
	private void showRemoveErrorMessage()
	{
	}

	[Token(Token = "0x600901F")]
	[Address(RVA = "0xD9F3A0", Offset = "0xD9E5A0", VA = "0x180D9F3A0")]
	protected void StartCardTransition(CardBase baseCard, CardBase targetCard, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6009020")]
	[Address(RVA = "0xD9F190", Offset = "0xD9E390", VA = "0x180D9F190")]
	private void StartCardTransition(Vector3 baseCardPosition, CardBase targetCard, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6009021")]
	[Address(RVA = "0xD9F030", Offset = "0xD9E230", VA = "0x180D9F030")]
	protected void StartCardTransition(CardBase baseCard, Vector3 targetPosition, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6009022")]
	[Address(RVA = "0xD9F4C0", Offset = "0xD9E6C0", VA = "0x180D9F4C0")]
	private void StartCardTransition(CardBaseData cbd, Vector3 baseCardPosition, Vector3 targetPosition, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6009023")]
	[Address(RVA = "0xD9EC70", Offset = "0xD9DE70", VA = "0x180D9EC70")]
	private void StartCardTransitionForDrop(CardBaseData cbd, Vector3 position)
	{
	}

	[Token(Token = "0x6009024")]
	[Address(RVA = "0xD9EE00", Offset = "0xD9E000", VA = "0x180D9EE00")]
	private void StartCardTransitionForRandomRemove(CardBaseData cbd, Vector3 position)
	{
	}

	[Token(Token = "0x6009025")]
	[Address(RVA = "0xD9EA90", Offset = "0xD9DC90", VA = "0x180D9EA90")]
	protected void StartCardAddEffect(CardBase targetCard, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6009026")]
	[Address(RVA = "0xDA1110", Offset = "0xDA0310", VA = "0x180DA1110")]
	private void checkSetRound(Action onSucceeded)
	{
	}

	[Token(Token = "0x6009027")]
	[Address(RVA = "0xDA1220", Offset = "0xDA0420", VA = "0x180DA1220")]
	private void confirmSubmit()
	{
	}

	[Token(Token = "0x6009028")]
	[Address(RVA = "0xD9C880", Offset = "0xD9BA80", VA = "0x180D9C880")]
	private void OnClickBackButton()
	{
	}

	[Token(Token = "0x6009029")]
	[Address(RVA = "0xDA3A00", Offset = "0xDA2C00", VA = "0x180DA3A00")]
	private void showModifiedDialog(Action onAccept, Action onCancel)
	{
	}

	[Token(Token = "0x600902A")]
	[Address(RVA = "0xDA38D0", Offset = "0xDA2AD0", VA = "0x180DA38D0")]
	private void showErrorBackDialog(string message)
	{
	}

	[Token(Token = "0x600902B")]
	[Address(RVA = "0xD9A990", Offset = "0xD99B90", VA = "0x180D9A990")]
	protected void DeactivateDropAreas()
	{
	}

	[Token(Token = "0x600902C")]
	[Address(RVA = "0xD9D600", Offset = "0xD9C800", VA = "0x180D9D600")]
	private void SetActiveExclusiveDropAreas(string label, bool canDrop = true)
	{
	}

	[Token(Token = "0x600902D")]
	[Address(RVA = "0xD9D8C0", Offset = "0xD9CAC0", VA = "0x180D9D8C0")]
	private void SetDisplayMode(DeckEditViewController2.DisplayMode displayMode, bool updateView)
	{
	}

	[Token(Token = "0x600902E")]
	[Address(RVA = "0xDA3D50", Offset = "0xDA2F50", VA = "0x180DA3D50")]
	private void toggleDisplayMode()
	{
	}

	[Token(Token = "0x600902F")]
	[Address(RVA = "0xDA3D90", Offset = "0xDA2F90", VA = "0x180DA3D90")]
	private void toggleSelectedWindow(ViewType viewType, SelectedCardType selectingCard)
	{
	}

	[Token(Token = "0x6009030")]
	[Address(RVA = "0xDA0EB0", Offset = "0xDA00B0", VA = "0x180DA0EB0")]
	private void UpdateSelectedWindow()
	{
	}

	[Token(Token = "0x6009031")]
	[Address(RVA = "0xD9E590", Offset = "0xD9D790", VA = "0x180D9E590")]
	private void SetupFooter()
	{
	}

	[Token(Token = "0x6009032")]
	[Address(RVA = "0xD9A8A0", Offset = "0xD99AA0", VA = "0x180D9A8A0")]
	private void ClearFooterDescription()
	{
	}

	[Token(Token = "0x6009033")]
	[Address(RVA = "0xD9E970", Offset = "0xD9DB70", VA = "0x180D9E970")]
	private void ShowFooterDescription(SelectedCardType selectingCard)
	{
	}

	[Token(Token = "0x6009034")]
	[Address(RVA = "0xD9A780", Offset = "0xD99980", VA = "0x180D9A780")]
	[AsyncStateMachine(typeof(_003CAsyncFilterAndSort_003Ed__160))]
	private Task AsyncFilterAndSort(Action onFinish, bool setAll = true, bool filter = true)
	{
		return null;
	}

	[Token(Token = "0x6009035")]
	[Address(RVA = "0xDA33A0", Offset = "0xDA25A0", VA = "0x180DA33A0")]
	[IteratorStateMachine(typeof(_003CrandomPickupCards_003Ed__162))]
	private IEnumerator randomPickupCards()
	{
		return null;
	}

	[Token(Token = "0x6009036")]
	[Address(RVA = "0xD9CC30", Offset = "0xD9BE30", VA = "0x180D9CC30")]
	protected void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x6009037")]
	[Address(RVA = "0xDA1000", Offset = "0xDA0200", VA = "0x180DA1000")]
	public LotteryCardSelectViewController()
	{
	}
}
