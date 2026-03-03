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
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team;

[Token(Token = "0x200166B")]
public class TeamNameSelectViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IBokeSupported
{
	[Token(Token = "0x200166C")]
	private class CardListArea
	{
		[Token(Token = "0x400D678")]
		private const string LABEL_IMGCARD = "ImageCard";

		[Token(Token = "0x400D679")]
		private const string LABEL_SELECT_TOGGLE = "SelectedStateToggle";

		[Token(Token = "0x400D67B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TeamNameSelectViewController _vc;

		[Token(Token = "0x400D67C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly InfinityScrollView _infinityScroll;

		[Token(Token = "0x400D67D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Selector _selector;

		[Token(Token = "0x400D67E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly GridLayoutGroup _gridlayout;

		[Token(Token = "0x400D67F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _selectedCardObj;

		[Token(Token = "0x17001549")]
		internal List<CardBaseData> cardData
		{
			[Token(Token = "0x6008B8D")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008B8C")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6008B8E")]
		[Address(RVA = "0xD5D210", Offset = "0xD5C410", VA = "0x180D5D210")]
		internal CardListArea(TeamNameSelectViewController vc, InfinityScrollView v)
		{
		}

		[Token(Token = "0x6008B8F")]
		[Address(RVA = "0xD5CA00", Offset = "0xD5BC00", VA = "0x180D5CA00")]
		internal void Initialize(List<CardBaseData> data)
		{
		}

		[Token(Token = "0x6008B90")]
		[Address(RVA = "0xD5C980", Offset = "0xD5BB80", VA = "0x180D5C980")]
		internal void Disp(bool on)
		{
		}

		[Token(Token = "0x6008B91")]
		[Address(RVA = "0xD5CE80", Offset = "0xD5C080", VA = "0x180D5CE80")]
		internal void Refresh()
		{
		}

		[Token(Token = "0x6008B92")]
		[Address(RVA = "0xD5CB20", Offset = "0xD5BD20", VA = "0x180D5CB20")]
		private void OnEntityUpdate(GameObject obj, int index)
		{
		}

		[Token(Token = "0x6008B93")]
		[Address(RVA = "0xD5CAA0", Offset = "0xD5BCA0", VA = "0x180D5CAA0")]
		private void OnEntityDeactivate(GameObject obj)
		{
		}

		[Token(Token = "0x6008B94")]
		[Address(RVA = "0xD5CF10", Offset = "0xD5C110", VA = "0x180D5CF10")]
		private void SetupShortcuts()
		{
		}
	}

	[Token(Token = "0x2001670")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x400D688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6008B9E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6008B9F")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CStart_003Eb__0(CardIndividualSetting setting)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2001672")]
	[CompilerGenerated]
	private struct _003CFilter_003Ed__32 : IAsyncStateMachine
	{
		[Token(Token = "0x400D68B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400D68C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400D68D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TeamNameSelectViewController _003C_003E4__this;

		[Token(Token = "0x400D68E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string searchText;

		[Token(Token = "0x400D68F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<List<CardBaseData>> _003C_003Eu__1;

		[Token(Token = "0x400D690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6008BA2")]
		[Address(RVA = "0xD76950", Offset = "0xD75B50", VA = "0x180D76950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6008BA3")]
		[Address(RVA = "0x418110", Offset = "0x417310", VA = "0x180418110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2001673")]
	[CompilerGenerated]
	private sealed class _003CLoadAllCardIDs_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeamNameSelectViewController _003C_003E4__this;

		[Token(Token = "0x400D694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Ccount_003E5__2;

		[Token(Token = "0x400D695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, object>.KeyCollection.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x1700154A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008BA8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700154B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008BAA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008BA4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAllCardIDs_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008BA5")]
		[Address(RVA = "0xD77450", Offset = "0xD76650", VA = "0x180D77450", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008BA6")]
		[Address(RVA = "0xD76F80", Offset = "0xD76180", VA = "0x180D76F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008BA7")]
		[Address(RVA = "0xD774E0", Offset = "0xD766E0", VA = "0x180D774E0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6008BA9")]
		[Address(RVA = "0xD77410", Offset = "0xD76610", VA = "0x180D77410", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001674")]
	[CompilerGenerated]
	private sealed class _003CSortCardsFirst_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeamNameSelectViewController _003C_003E4__this;

		[Token(Token = "0x400D699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Random _003Crnd_003E5__2;

		[Token(Token = "0x400D69A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x400D69B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__4;

		[Token(Token = "0x1700154C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008BAE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700154D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008BB0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008BAB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSortCardsFirst_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008BAC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008BAD")]
		[Address(RVA = "0xD77530", Offset = "0xD76730", VA = "0x180D77530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008BAF")]
		[Address(RVA = "0xD77820", Offset = "0xD76A20", VA = "0x180D77820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001675")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D69C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D69D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D69E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		[Token(Token = "0x400D69F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TeamNameSelectViewController _003C_003E4__this;

		[Token(Token = "0x1700154E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008BB4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700154F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008BB6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008BB1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008BB2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008BB3")]
		[Address(RVA = "0xD77860", Offset = "0xD76A60", VA = "0x180D77860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008BB5")]
		[Address(RVA = "0xD77AE0", Offset = "0xD76CE0", VA = "0x180D77AE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string ARG_ONRESULT;

	[Token(Token = "0x400D667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private CardListArea _cardArea;

	[Token(Token = "0x400D668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Action<int> _onResult;

	[Token(Token = "0x400D669")]
	private const string LABEL_BTNCANCEL = "ButtonCancel";

	[Token(Token = "0x400D66A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private KeyConfigContainer _keyConfig;

	[Token(Token = "0x400D66B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ElementObjectManager _contentView;

	[Token(Token = "0x400D66C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ElementObjectManager _cardCollectionView;

	[Token(Token = "0x400D66D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ElementObjectManager _cardScrollTop;

	[Token(Token = "0x400D66E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private InputFieldWidget _cardSearchField;

	[Token(Token = "0x400D66F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ExtendedTextMeshProUGUI _teamName;

	[Token(Token = "0x400D670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private BindingTextMeshProUGUI _title;

	[Token(Token = "0x400D671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton _cancelBtn;

	[Token(Token = "0x400D672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SelectionButton _decideBtn;

	[Token(Token = "0x400D673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject _noCardMessageText;

	[Token(Token = "0x400D674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject _loadingIcon;

	[Token(Token = "0x400D675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<CardBaseData> _allCardData;

	[Token(Token = "0x400D676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int _selectedCardId;

	[Token(Token = "0x400D677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private bool _backSent;

	[Token(Token = "0x17001547")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008B7A")]
		[Address(RVA = "0xD6C170", Offset = "0xD6B370", VA = "0x180D6C170", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001548")]
	public bool initialized
	{
		[Token(Token = "0x6008B7C")]
		[Address(RVA = "0x49B9D0", Offset = "0x49ABD0", VA = "0x18049B9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008B7B")]
		[Address(RVA = "0x49C1C0", Offset = "0x49B3C0", VA = "0x18049C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6008B7D")]
	[Address(RVA = "0xD6B390", Offset = "0xD6A590", VA = "0x180D6B390")]
	[ContextMenu("初期化実行")]
	private void ExecInit()
	{
	}

	[Token(Token = "0x6008B7E")]
	[Address(RVA = "0xD6BEF0", Offset = "0xD6B0F0", VA = "0x180D6BEF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008B7F")]
	[Address(RVA = "0xD6B260", Offset = "0xD6A460", VA = "0x180D6B260")]
	private void Close()
	{
	}

	[Token(Token = "0x6008B80")]
	[Address(RVA = "0xD6B500", Offset = "0xD6A700", VA = "0x180D6B500", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008B81")]
	[Address(RVA = "0xD6B790", Offset = "0xD6A990", VA = "0x180D6B790", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008B82")]
	[Address(RVA = "0xD6BFB0", Offset = "0xD6B1B0", VA = "0x180D6BFB0")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__29))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6008B83")]
	[Address(RVA = "0xD6B490", Offset = "0xD6A690", VA = "0x180D6B490")]
	[IteratorStateMachine(typeof(_003CLoadAllCardIDs_003Ed__30))]
	private IEnumerator LoadAllCardIDs()
	{
		return null;
	}

	[Token(Token = "0x6008B84")]
	[Address(RVA = "0xD6BF40", Offset = "0xD6B140", VA = "0x180D6BF40")]
	[IteratorStateMachine(typeof(_003CSortCardsFirst_003Ed__31))]
	private IEnumerator SortCardsFirst()
	{
		return null;
	}

	[Token(Token = "0x6008B85")]
	[Address(RVA = "0xD6B3C0", Offset = "0xD6A5C0", VA = "0x180D6B3C0")]
	[AsyncStateMachine(typeof(_003CFilter_003Ed__32))]
	private void Filter(string searchText)
	{
	}

	[Token(Token = "0x6008B86")]
	[Address(RVA = "0xD6B2B0", Offset = "0xD6A4B0", VA = "0x180D6B2B0")]
	private void DispLoadingIcon(bool on)
	{
	}

	[Token(Token = "0x6008B87")]
	[Address(RVA = "0xD6B320", Offset = "0xD6A520", VA = "0x180D6B320")]
	private void DispNoCardMessage(bool on)
	{
	}

	[Token(Token = "0x6008B88")]
	[Address(RVA = "0xD6B5E0", Offset = "0xD6A7E0", VA = "0x180D6B5E0")]
	private bool OnCardSelected(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B89")]
	[Address(RVA = "0xD6C0E0", Offset = "0xD6B2E0", VA = "0x180D6C0E0")]
	public TeamNameSelectViewController()
	{
	}
}
