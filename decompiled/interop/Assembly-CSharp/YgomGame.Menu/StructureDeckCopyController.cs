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
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x200137C")]
public class StructureDeckCopyController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200137D")]
	private class DeckReference
	{
		[Token(Token = "0x400C228")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400C229")]
		[FieldOffset(Offset = "0x14")]
		public int structureId;

		[Token(Token = "0x400C22A")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400C22B")]
		[FieldOffset(Offset = "0x20")]
		public int caseID;

		[Token(Token = "0x400C22C")]
		[FieldOffset(Offset = "0x24")]
		public int protectorID;

		[Token(Token = "0x400C22D")]
		[FieldOffset(Offset = "0x28")]
		public int[] pickUpIDs;

		[Token(Token = "0x400C22E")]
		[FieldOffset(Offset = "0x30")]
		public int[] pickUpDecos;

		[Token(Token = "0x600790E")]
		[Address(RVA = "0xC18B60", Offset = "0xC17D60", VA = "0x180C18B60")]
		public DeckReference()
		{
		}
	}

	[Token(Token = "0x2001382")]
	[CompilerGenerated]
	private sealed class _003CInitialize_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C23A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C23B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C23C")]
		[FieldOffset(Offset = "0x20")]
		public StructureDeckCopyController _003C_003E4__this;

		[Token(Token = "0x170012B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600791E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007920")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600791B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialize_003Ed__50(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600791C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600791D")]
		[Address(RVA = "0xC27AF0", Offset = "0xC26CF0", VA = "0x180C27AF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600791F")]
		[Address(RVA = "0xC27CD0", Offset = "0xC26ED0", VA = "0x180C27CD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C202")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x400C203")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelDeckTemplate;

	[Token(Token = "0x400C204")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelTournamentDeckTemplate;

	[Token(Token = "0x400C205")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelHederArea;

	[Token(Token = "0x400C206")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelFooterArea;

	[Token(Token = "0x400C207")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelDeckNum;

	[Token(Token = "0x400C208")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelTournamentDeckNum;

	[Token(Token = "0x400C209")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelStructureDeckView;

	[Token(Token = "0x400C20A")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelTextHeadline;

	[Token(Token = "0x400C20B")]
	[FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelPickupCardButton;

	[Token(Token = "0x400C20C")]
	[FieldOffset(Offset = "0x120")]
	private Transform m_DeckNum;

	[Token(Token = "0x400C20D")]
	[FieldOffset(Offset = "0x128")]
	private Transform m_TournamentDeckNum;

	[Token(Token = "0x400C20E")]
	[FieldOffset(Offset = "0x130")]
	private Transform m_StructureDeckView;

	[Token(Token = "0x400C20F")]
	[FieldOffset(Offset = "0x138")]
	private ElementObjectManager m_StructureDeckViewEom;

	[Token(Token = "0x400C210")]
	[FieldOffset(Offset = "0x140")]
	private SelectionButton m_StructureDeckViewButton;

	[Token(Token = "0x400C211")]
	[FieldOffset(Offset = "0x148")]
	private Transform m_StructureDeckViewOn;

	[Token(Token = "0x400C212")]
	[FieldOffset(Offset = "0x150")]
	private Transform m_StructureDeckViewOff;

	[Token(Token = "0x400C213")]
	[FieldOffset(Offset = "0x158")]
	private TextMeshProUGUI m_TextHeadline;

	[Token(Token = "0x400C214")]
	[FieldOffset(Offset = "0x160")]
	private SelectionButton m_PickupCardButton;

	[Token(Token = "0x400C215")]
	[FieldOffset(Offset = "0x168")]
	private ElementObjectManager m_PickupCardButtonEom;

	[Token(Token = "0x400C216")]
	[FieldOffset(Offset = "0x170")]
	private Transform m_PickupCardButtonOn;

	[Token(Token = "0x400C217")]
	[FieldOffset(Offset = "0x178")]
	private Transform m_PickupCardButtonOff;

	[Token(Token = "0x400C218")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	private ElementObjectManager m_PrefabUI;

	[Token(Token = "0x400C219")]
	[FieldOffset(Offset = "0x188")]
	protected ElementObjectManager m_UI;

	[Token(Token = "0x400C21A")]
	[FieldOffset(Offset = "0x190")]
	private Transform m_HederArea;

	[Token(Token = "0x400C21B")]
	[FieldOffset(Offset = "0x198")]
	private Transform m_FooterArea;

	[Token(Token = "0x400C21C")]
	[FieldOffset(Offset = "0x1A0")]
	private ElementObjectManager m_DeckTemplate;

	[Token(Token = "0x400C21D")]
	[FieldOffset(Offset = "0x1A8")]
	private ElementObjectManager m_TournamentDeckTemplate;

	[Token(Token = "0x400C21E")]
	[FieldOffset(Offset = "0x1B0")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400C21F")]
	[FieldOffset(Offset = "0x1B8")]
	private ElementObjectManager m_ScrollViewEom;

	[Token(Token = "0x400C220")]
	private const string GROUP_LABEL = "StructureDeckCopy";

	[Token(Token = "0x400C221")]
	[FieldOffset(Offset = "0x1C0")]
	private bool m_OnlyHaving;

	[Token(Token = "0x400C222")]
	[FieldOffset(Offset = "0x1C1")]
	private bool dispPickCards;

	[Token(Token = "0x400C223")]
	[FieldOffset(Offset = "0x1C8")]
	private List<int> m_NewIconList;

	[Token(Token = "0x400C224")]
	[FieldOffset(Offset = "0x1D0")]
	private Dictionary<int, DeckBox> m_DeckUIs;

	[Token(Token = "0x400C225")]
	[FieldOffset(Offset = "0x1D8")]
	private List<DeckReference> m_Decks;

	[Token(Token = "0x400C226")]
	[FieldOffset(Offset = "0x1E0")]
	private List<DeckReference> m_hasDecks;

	[Token(Token = "0x400C227")]
	[FieldOffset(Offset = "0x1E8")]
	private List<DeckReference> m_notHasDecks;

	[Token(Token = "0x170012AF")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60078FD")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170012B0")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60078FE")]
		[Address(RVA = "0xC24310", Offset = "0xC23510", VA = "0x180C24310", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078FF")]
	[Address(RVA = "0xC22840", Offset = "0xC21A40", VA = "0x180C22840", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007900")]
	[Address(RVA = "0xC233D0", Offset = "0xC225D0", VA = "0x180C233D0")]
	private void OnClickOnlyHaving()
	{
	}

	[Token(Token = "0x6007901")]
	[Address(RVA = "0xC21C30", Offset = "0xC20E30", VA = "0x180C21C30")]
	private void DispPickupCards()
	{
	}

	[Token(Token = "0x6007902")]
	[Address(RVA = "0xC237E0", Offset = "0xC229E0", VA = "0x180C237E0")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6007903")]
	[Address(RVA = "0xC23760", Offset = "0xC22960", VA = "0x180C23760")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6007904")]
	[Address(RVA = "0xC23860", Offset = "0xC22A60", VA = "0x180C23860")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6007905")]
	[Address(RVA = "0xC235D0", Offset = "0xC227D0", VA = "0x180C235D0")]
	private void OnClickStuructureDeck(int structureId, ElementObjectManager body)
	{
	}

	[Token(Token = "0x6007906")]
	[Address(RVA = "0xC227D0", Offset = "0xC219D0", VA = "0x180C227D0")]
	[IteratorStateMachine(typeof(_003CInitialize_003Ed__50))]
	private IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x6007907")]
	[Address(RVA = "0xC21AC0", Offset = "0xC20CC0", VA = "0x180C21AC0")]
	private void CheckFirstStructure()
	{
	}

	[Token(Token = "0x6007908")]
	[Address(RVA = "0xC21FD0", Offset = "0xC211D0", VA = "0x180C21FD0")]
	private void GetStructureDecks()
	{
	}

	[Token(Token = "0x6007909")]
	[Address(RVA = "0xC23F00", Offset = "0xC23100", VA = "0x180C23F00")]
	private void UpdateStructureDecks()
	{
	}

	[Token(Token = "0x600790A")]
	[Address(RVA = "0xC23FC0", Offset = "0xC231C0", VA = "0x180C23FC0")]
	public StructureDeckCopyController()
	{
	}
}
