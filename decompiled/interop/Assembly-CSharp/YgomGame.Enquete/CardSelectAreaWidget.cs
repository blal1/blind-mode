using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E00")]
public class CardSelectAreaWidget : ElementWidgetBase
{
	[Token(Token = "0x2000E01")]
	private class CardListArea
	{
		[Token(Token = "0x400A1A7")]
		private const string LABEL_IMGCARD = "ImageCard";

		[Token(Token = "0x400A1A8")]
		private const string LABEL_SELECT_TOGGLE = "SelectedStateToggle";

		[Token(Token = "0x400A1A9")]
		private const string LABEL_CHECK_ICON = "IconCheck";

		[Token(Token = "0x400A1AA")]
		private const string LABEL_TEXT_NOITEM = "NoItemText";

		[Token(Token = "0x400A1AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly EnqueteCardSelectViewController _vc;

		[Token(Token = "0x400A1AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly InfinityScrollView _infinityScroll;

		[Token(Token = "0x400A1AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Selector _selector;

		[Token(Token = "0x400A1AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly GridLayoutGroup _gridlayout;

		[Token(Token = "0x400A1B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<int> currentSelectedList;

		[Token(Token = "0x400A1B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onFailedSelectionCallback;

		[Token(Token = "0x17000C6D")]
		internal List<CardBaseData> cardData
		{
			[Token(Token = "0x600547A")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005479")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000C6E")]
		public InfinityScrollView infinityScrollView
		{
			[Token(Token = "0x600547B")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600547C")]
		[Address(RVA = "0x99CCF0", Offset = "0x99BEF0", VA = "0x18099CCF0")]
		internal CardListArea(EnqueteCardSelectViewController vc, InfinityScrollView v)
		{
		}

		[Token(Token = "0x600547D")]
		[Address(RVA = "0x99C3B0", Offset = "0x99B5B0", VA = "0x18099C3B0")]
		internal void Initialize(List<CardBaseData> data, [Optional] Action onCompleted)
		{
		}

		[Token(Token = "0x600547E")]
		[Address(RVA = "0x99C330", Offset = "0x99B530", VA = "0x18099C330")]
		internal void Disp(bool on)
		{
		}

		[Token(Token = "0x600547F")]
		[Address(RVA = "0x99C9D0", Offset = "0x99BBD0", VA = "0x18099C9D0")]
		internal void SetSurfaceDisp(bool on)
		{
		}

		[Token(Token = "0x6005480")]
		[Address(RVA = "0x99C940", Offset = "0x99BB40", VA = "0x18099C940")]
		internal void Refresh()
		{
		}

		[Token(Token = "0x6005481")]
		[Address(RVA = "0x99CCA0", Offset = "0x99BEA0", VA = "0x18099CCA0")]
		internal void UpdateDataCount()
		{
		}

		[Token(Token = "0x6005482")]
		[Address(RVA = "0x99C4B0", Offset = "0x99B6B0", VA = "0x18099C4B0")]
		private void OnEntityCreate(GameObject entity)
		{
		}

		[Token(Token = "0x6005483")]
		[Address(RVA = "0x99C910", Offset = "0x99BB10", VA = "0x18099C910")]
		private bool OnInputDirection(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x6005484")]
		[Address(RVA = "0x99C5F0", Offset = "0x99B7F0", VA = "0x18099C5F0")]
		private void OnEntityUpdate(GameObject obj, int index)
		{
		}

		[Token(Token = "0x6005485")]
		[Address(RVA = "0x99CA40", Offset = "0x99BC40", VA = "0x18099CA40")]
		private void SetupShortcuts()
		{
		}
	}

	[Token(Token = "0x2000E06")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x400A1BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x400A1BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CardSelectAreaWidget _003C_003E4__this;

		[Token(Token = "0x6005492")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6005493")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CInitCardSetting_003Eb__0(CardIndividualSetting setting)
		{
		}

		[Token(Token = "0x6005494")]
		[Address(RVA = "0x9AF190", Offset = "0x9AE390", VA = "0x1809AF190")]
		internal void _003CInitCardSetting_003Eb__1()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000E08")]
	[CompilerGenerated]
	private struct _003CFilter_003Ed__36 : IAsyncStateMachine
	{
		[Token(Token = "0x400A1BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400A1BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400A1C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CardSelectAreaWidget _003C_003E4__this;

		[Token(Token = "0x400A1C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string searchText;

		[Token(Token = "0x400A1C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<List<CardBaseData>> _003C_003Eu__1;

		[Token(Token = "0x400A1C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6005497")]
		[Address(RVA = "0x9ACE10", Offset = "0x9AC010", VA = "0x1809ACE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6005498")]
		[Address(RVA = "0x418110", Offset = "0x417310", VA = "0x180418110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000E09")]
	[CompilerGenerated]
	private sealed class _003CInitCardSetting_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A1C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A1C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A1C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardSelectAreaWidget _003C_003E4__this;

		[Token(Token = "0x400A1C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		[Token(Token = "0x400A1C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<Either<string, bool>> onCompleted;

		[Token(Token = "0x17000C6F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600549C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C70")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600549E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005499")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitCardSetting_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600549A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600549B")]
		[Address(RVA = "0x9AD420", Offset = "0x9AC620", VA = "0x1809AD420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600549D")]
		[Address(RVA = "0x9AD6E0", Offset = "0x9AC8E0", VA = "0x1809AD6E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E0A")]
	[CompilerGenerated]
	private sealed class _003CLoadAllCardIDs_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A1C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A1CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A1CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardSelectAreaWidget _003C_003E4__this;

		[Token(Token = "0x400A1CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Either<string, bool>> onCompleted;

		[Token(Token = "0x400A1CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003Ccount_003E5__2;

		[Token(Token = "0x400A1CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<object>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x17000C71")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60054A3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C72")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60054A5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600549F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAllCardIDs_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60054A0")]
		[Address(RVA = "0x9ADC10", Offset = "0x9ACE10", VA = "0x1809ADC10", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60054A1")]
		[Address(RVA = "0x9AD720", Offset = "0x9AC920", VA = "0x1809AD720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60054A2")]
		[Address(RVA = "0x9ADCA0", Offset = "0x9ACEA0", VA = "0x1809ADCA0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60054A4")]
		[Address(RVA = "0x9ADBD0", Offset = "0x9ACDD0", VA = "0x1809ADBD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E0B")]
	[CompilerGenerated]
	private sealed class _003CSortCardsFirst_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A1CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A1D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A1D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardSelectAreaWidget _003C_003E4__this;

		[Token(Token = "0x400A1D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Random _003Crnd_003E5__2;

		[Token(Token = "0x400A1D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x400A1D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__4;

		[Token(Token = "0x17000C73")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60054A9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C74")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60054AB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSortCardsFirst_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60054A7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x9AE110", Offset = "0x9AD310", VA = "0x1809AE110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x9AE3F0", Offset = "0x9AD5F0", VA = "0x1809AE3F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A195")]
	private const string k_PrefPath = "CardSelect/CardSelect";

	[Token(Token = "0x400A196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string ARG_ONRESULT;

	[Token(Token = "0x400A197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string ARG_MIN;

	[Token(Token = "0x400A198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string ARG_MAX;

	[Token(Token = "0x400A199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string ARG_SELECTED_MRKS;

	[Token(Token = "0x400A19B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CardListArea _cardArea;

	[Token(Token = "0x400A19C")]
	private const string LABEL_TextCardName = "TextCardName";

	[Token(Token = "0x400A19D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private KeyConfigContainer _keyConfig;

	[Token(Token = "0x400A19E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ElementObjectManager _cardCollectionView;

	[Token(Token = "0x400A19F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ElementObjectManager _cardScrollTop;

	[Token(Token = "0x400A1A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private InputFieldWidget _cardSearchField;

	[Token(Token = "0x400A1A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ExtendedTextMeshProUGUI _cardName;

	[Token(Token = "0x400A1A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject _noCardMessageText;

	[Token(Token = "0x400A1A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject _loadingIcon;

	[Token(Token = "0x400A1A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<CardBaseData> _allCardData;

	[Token(Token = "0x400A1A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _cardpoolId;

	[Token(Token = "0x400A1A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool isSuccessLoadCardIDs;

	[Token(Token = "0x17000C6A")]
	public bool initialized
	{
		[Token(Token = "0x6005466")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005465")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C6B")]
	public ExtendedTextMeshProUGUI cardName
	{
		[Token(Token = "0x6005467")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C6C")]
	public int cardpoolId
	{
		[Token(Token = "0x6005468")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005469")]
		[Address(RVA = "0x99DB50", Offset = "0x99CD50", VA = "0x18099DB50")]
		set
		{
		}
	}

	[Token(Token = "0x600546A")]
	[Address(RVA = "0x99D000", Offset = "0x99C200", VA = "0x18099D000")]
	[ContextMenu("初期化実行")]
	private void ExecInit()
	{
	}

	[Token(Token = "0x600546B")]
	[Address(RVA = "0x99DAC0", Offset = "0x99CCC0", VA = "0x18099DAC0")]
	public CardSelectAreaWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600546C")]
	[Address(RVA = "0x99D220", Offset = "0x99C420", VA = "0x18099D220")]
	public void Initialize(EnqueteCardSelectViewController parent, [Optional] Action<Either<string, bool>> onFinished)
	{
	}

	[Token(Token = "0x600546D")]
	[Address(RVA = "0x99D7E0", Offset = "0x99C9E0", VA = "0x18099D7E0")]
	protected void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x600546E")]
	[Address(RVA = "0x99D190", Offset = "0x99C390", VA = "0x18099D190")]
	[IteratorStateMachine(typeof(_003CInitCardSetting_003Ed__31))]
	private IEnumerator InitCardSetting(Action<Either<string, bool>> onCompleted)
	{
		return null;
	}

	[Token(Token = "0x600546F")]
	[Address(RVA = "0x99D7A0", Offset = "0x99C9A0", VA = "0x18099D7A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005470")]
	[Address(RVA = "0x99D100", Offset = "0x99C300", VA = "0x18099D100")]
	private List<object> GetCardIds(int id)
	{
		return null;
	}

	[Token(Token = "0x6005471")]
	[Address(RVA = "0x99D710", Offset = "0x99C910", VA = "0x18099D710")]
	[IteratorStateMachine(typeof(_003CLoadAllCardIDs_003Ed__34))]
	private IEnumerator LoadAllCardIDs(Action<Either<string, bool>> onCompleted)
	{
		return null;
	}

	[Token(Token = "0x6005472")]
	[Address(RVA = "0x99D8B0", Offset = "0x99CAB0", VA = "0x18099D8B0")]
	[IteratorStateMachine(typeof(_003CSortCardsFirst_003Ed__35))]
	private IEnumerator SortCardsFirst()
	{
		return null;
	}

	[Token(Token = "0x6005473")]
	[Address(RVA = "0x99D030", Offset = "0x99C230", VA = "0x18099D030")]
	[AsyncStateMachine(typeof(_003CFilter_003Ed__36))]
	private void Filter(string searchText)
	{
	}

	[Token(Token = "0x6005474")]
	[Address(RVA = "0x99CF40", Offset = "0x99C140", VA = "0x18099CF40")]
	private void DispLoadingIcon(bool on)
	{
	}

	[Token(Token = "0x6005475")]
	[Address(RVA = "0x99CFA0", Offset = "0x99C1A0", VA = "0x18099CFA0")]
	private void DispNoCardMessage(bool on)
	{
	}

	[Token(Token = "0x6005476")]
	[Address(RVA = "0x99D920", Offset = "0x99CB20", VA = "0x18099D920")]
	public void UpdateView()
	{
	}

	[Token(Token = "0x6005477")]
	[Address(RVA = "0x99D880", Offset = "0x99CA80", VA = "0x18099D880")]
	public void SetSelectionFailedCallback(Action action)
	{
	}
}
