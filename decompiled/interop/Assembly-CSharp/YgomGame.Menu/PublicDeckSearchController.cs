using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x2001368")]
public class PublicDeckSearchController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001369")]
	protected class DeckReference
	{
		[Token(Token = "0x400C1A1")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400C1A2")]
		[FieldOffset(Offset = "0x14")]
		public int pickupId;

		[Token(Token = "0x400C1A3")]
		[FieldOffset(Offset = "0x18")]
		public string cardgameId;

		[Token(Token = "0x400C1A4")]
		[FieldOffset(Offset = "0x20")]
		public int deckNo;

		[Token(Token = "0x6007895")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DeckReference()
		{
		}
	}

	[Token(Token = "0x200136C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		[Token(Token = "0x400C1AB")]
		[FieldOffset(Offset = "0x10")]
		public bool completed;

		[Token(Token = "0x400C1AC")]
		[FieldOffset(Offset = "0x14")]
		public int requestPageNo;

		[Token(Token = "0x400C1AD")]
		[FieldOffset(Offset = "0x18")]
		public PublicDeckSearchController _003C_003E4__this;

		[Token(Token = "0x400C1AE")]
		[FieldOffset(Offset = "0x20")]
		public int sizePerPage;

		[Token(Token = "0x600789D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass69_0()
		{
		}

		[Token(Token = "0x600789E")]
		[Address(RVA = "0xC36210", Offset = "0xC35410", VA = "0x180C36210")]
		internal void _003CDeckSearch_Search_003Eb__0(Handle e)
		{
		}
	}

	[Token(Token = "0x200136E")]
	[CompilerGenerated]
	private sealed class _003CAdditionalDeckDataLoad_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C1B3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C1B4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C1B5")]
		[FieldOffset(Offset = "0x20")]
		public PublicDeckSearchController _003C_003E4__this;

		[Token(Token = "0x170012A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60078A4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60078A6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60078A1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAdditionalDeckDataLoad_003Ed__74(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60078A2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60078A3")]
		[Address(RVA = "0xC27070", Offset = "0xC26270", VA = "0x180C27070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60078A5")]
		[Address(RVA = "0xC27160", Offset = "0xC26360", VA = "0x180C27160", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200136F")]
	[CompilerGenerated]
	private sealed class _003CDeckSearchRequest_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C1B6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C1B7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C1B8")]
		[FieldOffset(Offset = "0x20")]
		public PublicDeckSearchController _003C_003E4__this;

		[Token(Token = "0x170012A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60078AA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60078AC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60078A7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDeckSearchRequest_003Ed__83(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60078A8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60078A9")]
		[Address(RVA = "0xC271A0", Offset = "0xC263A0", VA = "0x180C271A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60078AB")]
		[Address(RVA = "0xC274D0", Offset = "0xC266D0", VA = "0x180C274D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001370")]
	[CompilerGenerated]
	private sealed class _003CDeckSearch_Search_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C1B9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C1BA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C1BB")]
		[FieldOffset(Offset = "0x20")]
		public int requestPageNo;

		[Token(Token = "0x400C1BC")]
		[FieldOffset(Offset = "0x28")]
		public PublicDeckSearchController _003C_003E4__this;

		[Token(Token = "0x400C1BD")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass69_0 _003C_003E8__1;

		[Token(Token = "0x170012A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60078B0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60078B2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60078AD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDeckSearch_Search_003Ed__69(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60078AE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60078AF")]
		[Address(RVA = "0xC27510", Offset = "0xC26710", VA = "0x180C27510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60078B1")]
		[Address(RVA = "0xC27A70", Offset = "0xC26C70", VA = "0x180C27A70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001371")]
	[CompilerGenerated]
	private sealed class _003CInitialize_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C1BE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C1BF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C1C0")]
		[FieldOffset(Offset = "0x20")]
		public PublicDeckSearchController _003C_003E4__this;

		[Token(Token = "0x170012AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60078B6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60078B8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60078B3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialize_003Ed__73(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60078B4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60078B5")]
		[Address(RVA = "0xC27D10", Offset = "0xC26F10", VA = "0x180C27D10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60078B7")]
		[Address(RVA = "0xC27F30", Offset = "0xC27130", VA = "0x180C27F30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C167")]
	[FieldOffset(Offset = "0xD0")]
	protected readonly string k_ELabelScrollView;

	[Token(Token = "0x400C168")]
	[FieldOffset(Offset = "0xD8")]
	protected readonly string k_ELabelDeckTemplate;

	[Token(Token = "0x400C169")]
	[FieldOffset(Offset = "0xE0")]
	protected readonly string k_ELabelTournamentDeckTemplate;

	[Token(Token = "0x400C16A")]
	[FieldOffset(Offset = "0xE8")]
	protected readonly string k_ELabelPublicDeckTemplate;

	[Token(Token = "0x400C16B")]
	[FieldOffset(Offset = "0xF0")]
	protected readonly string k_ELabelHederArea;

	[Token(Token = "0x400C16C")]
	[FieldOffset(Offset = "0xF8")]
	protected readonly string k_ELabelFooterArea;

	[Token(Token = "0x400C16D")]
	[FieldOffset(Offset = "0x100")]
	protected readonly string k_ELabelTextHeadline;

	[Token(Token = "0x400C16E")]
	[FieldOffset(Offset = "0x108")]
	protected readonly string k_ELabelEmptyMessage;

	[Token(Token = "0x400C16F")]
	[FieldOffset(Offset = "0x110")]
	protected readonly string k_ELabelEmptyMessageText;

	[Token(Token = "0x400C170")]
	[FieldOffset(Offset = "0x118")]
	protected readonly string k_ELabelDeckNum;

	[Token(Token = "0x400C171")]
	[FieldOffset(Offset = "0x120")]
	protected readonly string k_ELabelTournamentDeckNum;

	[Token(Token = "0x400C172")]
	[FieldOffset(Offset = "0x128")]
	protected readonly string k_ELabelInputField;

	[Token(Token = "0x400C173")]
	[FieldOffset(Offset = "0x130")]
	protected readonly string k_ELabelPlaceholder;

	[Token(Token = "0x400C174")]
	[FieldOffset(Offset = "0x138")]
	protected readonly string k_ELabelButtonFilter;

	[Token(Token = "0x400C175")]
	[FieldOffset(Offset = "0x140")]
	protected readonly string k_ELabelButtonTrash;

	[Token(Token = "0x400C176")]
	[FieldOffset(Offset = "0x148")]
	protected readonly string k_ELabelButtonTrashSub;

	[Token(Token = "0x400C177")]
	[FieldOffset(Offset = "0x150")]
	protected readonly string k_ELabelButtonPageUp;

	[Token(Token = "0x400C178")]
	[FieldOffset(Offset = "0x158")]
	protected readonly string k_ELabelButtonPageDown;

	[Token(Token = "0x400C179")]
	[FieldOffset(Offset = "0x160")]
	protected readonly string k_ELabelButtonCaution;

	[Token(Token = "0x400C17A")]
	[FieldOffset(Offset = "0x168")]
	protected Transform m_DeckNum;

	[Token(Token = "0x400C17B")]
	[FieldOffset(Offset = "0x170")]
	protected Transform m_TournamentDeckNum;

	[Token(Token = "0x400C17C")]
	[FieldOffset(Offset = "0x178")]
	protected ElementObjectManager m_InputFieldEom;

	[Token(Token = "0x400C17D")]
	[FieldOffset(Offset = "0x180")]
	protected Transform m_ButtonFilter;

	[Token(Token = "0x400C17E")]
	[FieldOffset(Offset = "0x188")]
	protected ElementObjectManager m_FilterEom;

	[Token(Token = "0x400C17F")]
	[FieldOffset(Offset = "0x190")]
	protected Transform m_FileterOn;

	[Token(Token = "0x400C180")]
	[FieldOffset(Offset = "0x198")]
	protected Transform m_FileterOff;

	[Token(Token = "0x400C181")]
	[FieldOffset(Offset = "0x1A0")]
	protected SelectionButton m_ButtonTrash;

	[Token(Token = "0x400C182")]
	[FieldOffset(Offset = "0x1A8")]
	protected SelectionButton m_ButtonTrashSub;

	[Token(Token = "0x400C183")]
	[FieldOffset(Offset = "0x1B0")]
	protected TextMeshProUGUI m_TextHeadline;

	[Token(Token = "0x400C184")]
	[FieldOffset(Offset = "0x1B8")]
	private SelectionButton m_ButtonPageUp;

	[Token(Token = "0x400C185")]
	[FieldOffset(Offset = "0x1C0")]
	private SelectionButton m_ButtonPageDown;

	[Token(Token = "0x400C186")]
	[FieldOffset(Offset = "0x1C8")]
	protected SelectionButton m_ButtonCaution;

	[Token(Token = "0x400C187")]
	protected const int numRequestPerPage = 100;

	[Token(Token = "0x400C188")]
	[FieldOffset(Offset = "0x1D0")]
	protected int maxPageIdx;

	[Token(Token = "0x400C189")]
	[FieldOffset(Offset = "0x1D4")]
	protected int nextPageIdx;

	[Token(Token = "0x400C18A")]
	[FieldOffset(Offset = "0x1D8")]
	protected int totalDecks;

	[Token(Token = "0x400C18B")]
	[FieldOffset(Offset = "0x1DC")]
	protected bool isUpdating;

	[Token(Token = "0x400C18C")]
	[FieldOffset(Offset = "0x1E0")]
	protected Transform m_HederArea;

	[Token(Token = "0x400C18D")]
	[FieldOffset(Offset = "0x1E8")]
	protected Transform m_FooterArea;

	[Token(Token = "0x400C18E")]
	[FieldOffset(Offset = "0x1F0")]
	private ElementObjectManager m_DeckTemplate;

	[Token(Token = "0x400C18F")]
	[FieldOffset(Offset = "0x1F8")]
	private ElementObjectManager m_TournamentDeckTemplate;

	[Token(Token = "0x400C190")]
	[FieldOffset(Offset = "0x200")]
	private ElementObjectManager m_PublicDeckTemplate;

	[Token(Token = "0x400C191")]
	[FieldOffset(Offset = "0x208")]
	protected InfinityScrollView m_ScrollView;

	[Token(Token = "0x400C192")]
	[FieldOffset(Offset = "0x210")]
	protected ElementObjectManager m_ScrollViewEom;

	[Token(Token = "0x400C193")]
	[FieldOffset(Offset = "0x218")]
	private string m_Keyword;

	[Token(Token = "0x400C194")]
	[FieldOffset(Offset = "0x220")]
	private string m_DeckCode;

	[Token(Token = "0x400C195")]
	[FieldOffset(Offset = "0x228")]
	private int[] m_CardArray;

	[Token(Token = "0x400C196")]
	[FieldOffset(Offset = "0x230")]
	private List<CategoryReference> m_SelectedCategories;

	[Token(Token = "0x400C197")]
	[FieldOffset(Offset = "0x238")]
	private List<CategoryReference> m_SelectedTags;

	[Token(Token = "0x400C198")]
	private const string GROUP_LABEL = "PublicDeckSerach";

	[Token(Token = "0x400C199")]
	protected const int MAX_MAIN = 60;

	[Token(Token = "0x400C19A")]
	protected const int MAX_EX = 15;

	[Token(Token = "0x400C19B")]
	[FieldOffset(Offset = "0x240")]
	private GameObject m_EmptyMessage;

	[Token(Token = "0x400C19C")]
	[FieldOffset(Offset = "0x248")]
	private TextMeshProUGUI m_EmptyMessageText;

	[Token(Token = "0x400C19D")]
	[FieldOffset(Offset = "0x250")]
	protected Dictionary<int, PublicDeckBox> m_PublicDeckUIs;

	[Token(Token = "0x400C19E")]
	[FieldOffset(Offset = "0x258")]
	protected bool updateFlag;

	[Token(Token = "0x400C19F")]
	[FieldOffset(Offset = "0x260")]
	protected Dictionary<string, object> deckDict;

	[Token(Token = "0x400C1A0")]
	[FieldOffset(Offset = "0x268")]
	protected List<DeckReference> m_PublicDecks;

	[Token(Token = "0x170012A2")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6007870")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170012A3")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007871")]
		[Address(RVA = "0xC1CE00", Offset = "0xC1C000", VA = "0x180C1CE00", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007872")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007873")]
	[Address(RVA = "0xC195C0", Offset = "0xC187C0", VA = "0x180C195C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007874")]
	[Address(RVA = "0xC1A400", Offset = "0xC19600", VA = "0x180C1A400")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6007875")]
	[Address(RVA = "0xC1A380", Offset = "0xC19580", VA = "0x180C1A380")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6007876")]
	[Address(RVA = "0xC1A460", Offset = "0xC19660", VA = "0x180C1A460", Slot = "28")]
	public virtual void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6007877")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6007878")]
	[Address(RVA = "0xC19080", Offset = "0xC18280", VA = "0x180C19080", Slot = "29")]
	[IteratorStateMachine(typeof(_003CDeckSearch_Search_003Ed__69))]
	public virtual IEnumerator DeckSearch_Search(int requestPageNo = 0)
	{
		return null;
	}

	[Token(Token = "0x6007879")]
	[Address(RVA = "0xC18F70", Offset = "0xC18170", VA = "0x180C18F70", Slot = "30")]
	protected virtual void DeckSearch_Detail(string targetId, int deckNo, int pickCardId)
	{
	}

	[Token(Token = "0x600787A")]
	[Address(RVA = "0xC195A0", Offset = "0xC187A0", VA = "0x180C195A0", Slot = "31")]
	protected virtual void OnClickPublicDeck(string cardgameId, int deckNo, int pickCardId)
	{
	}

	[Token(Token = "0x600787B")]
	[Address(RVA = "0xC1AAB0", Offset = "0xC19CB0", VA = "0x180C1AAB0", Slot = "32")]
	public virtual void OpenDeckBrowser(string cardgameId, int deckNo, int pickCardId)
	{
	}

	[Token(Token = "0x600787C")]
	[Address(RVA = "0xC19400", Offset = "0xC18600", VA = "0x180C19400", Slot = "33")]
	[IteratorStateMachine(typeof(_003CInitialize_003Ed__73))]
	protected virtual IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x600787D")]
	[Address(RVA = "0xC18C30", Offset = "0xC17E30", VA = "0x180C18C30", Slot = "34")]
	[IteratorStateMachine(typeof(_003CAdditionalDeckDataLoad_003Ed__74))]
	protected virtual IEnumerator AdditionalDeckDataLoad()
	{
		return null;
	}

	[Token(Token = "0x600787E")]
	[Address(RVA = "0xC1BA10", Offset = "0xC1AC10", VA = "0x180C1BA10")]
	private void OpenFilterWindow()
	{
	}

	[Token(Token = "0x600787F")]
	[Address(RVA = "0xC1BD80", Offset = "0xC1AF80", VA = "0x180C1BD80")]
	private void SetKeyWord(string keyword)
	{
	}

	[Token(Token = "0x6007880")]
	[Address(RVA = "0xC18CA0", Offset = "0xC17EA0", VA = "0x180C18CA0")]
	private void ClearFilters()
	{
	}

	[Token(Token = "0x6007881")]
	[Address(RVA = "0xC19470", Offset = "0xC18670", VA = "0x180C19470")]
	private bool IsActiveFilter()
	{
		return default(bool);
	}

	[Token(Token = "0x6007882")]
	[Address(RVA = "0xC1AA60", Offset = "0xC19C60", VA = "0x180C1AA60")]
	private void OpenCautionMMA()
	{
	}

	[Token(Token = "0x6007883")]
	[Address(RVA = "0xC1C2D0", Offset = "0xC1B4D0", VA = "0x180C1C2D0", Slot = "35")]
	protected virtual void UpdateDecks()
	{
	}

	[Token(Token = "0x6007884")]
	[Address(RVA = "0xC1A660", Offset = "0xC19860", VA = "0x180C1A660", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6007885")]
	[Address(RVA = "0xC1C790", Offset = "0xC1B990", VA = "0x180C1C790")]
	private void UpdateFilter()
	{
	}

	[Token(Token = "0x6007886")]
	[Address(RVA = "0xC18F00", Offset = "0xC18100", VA = "0x180C18F00")]
	[IteratorStateMachine(typeof(_003CDeckSearchRequest_003Ed__83))]
	private IEnumerator DeckSearchRequest()
	{
		return null;
	}

	[Token(Token = "0x6007887")]
	[Address(RVA = "0xC1C0B0", Offset = "0xC1B2B0", VA = "0x180C1C0B0")]
	private void SortMRK(List<object> mrklist)
	{
	}

	[Token(Token = "0x6007888")]
	[Address(RVA = "0xC19100", Offset = "0xC18300", VA = "0x180C19100")]
	public static int[] GetCardArrayByKeyword(string keyword)
	{
		return null;
	}

	[Token(Token = "0x6007889")]
	[Address(RVA = "0xC194F0", Offset = "0xC186F0", VA = "0x180C194F0")]
	private void JumpScrollIdx(PadInputDirection direction)
	{
	}

	[Token(Token = "0x600788A")]
	[Address(RVA = "0xC1BB00", Offset = "0xC1AD00", VA = "0x180C1BB00", Slot = "36")]
	protected virtual void OpenMaintenanceDialog()
	{
	}

	[Token(Token = "0x600788B")]
	[Address(RVA = "0xC1A930", Offset = "0xC19B30", VA = "0x180C1A930")]
	protected void OpenAccessErrorDialog()
	{
	}

	[Token(Token = "0x600788C")]
	[Address(RVA = "0xC1C890", Offset = "0xC1BA90", VA = "0x180C1C890")]
	public PublicDeckSearchController()
	{
	}
}
