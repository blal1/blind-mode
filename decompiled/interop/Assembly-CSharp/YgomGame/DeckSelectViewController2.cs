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
using YgomGame.Deck;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomGame;

[Token(Token = "0x2000695")]
public class DeckSelectViewController2 : BaseMenuViewController, IDynamicHeaderCustomSupported, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x2000696")]
	public enum DeckCondition
	{
		[Token(Token = "0x40020C9")]
		New,
		[Token(Token = "0x40020CA")]
		Existing
	}

	[Token(Token = "0x2000697")]
	public enum SelectMode
	{
		[Token(Token = "0x40020CC")]
		Default,
		[Token(Token = "0x40020CD")]
		Ranked,
		[Token(Token = "0x40020CE")]
		PVE,
		[Token(Token = "0x40020CF")]
		Tournament,
		[Token(Token = "0x40020D0")]
		Solo,
		[Token(Token = "0x40020D1")]
		Room,
		[Token(Token = "0x40020D2")]
		Exhibition,
		[Token(Token = "0x40020D3")]
		ExhibitionRental,
		[Token(Token = "0x40020D4")]
		Free,
		[Token(Token = "0x40020D5")]
		Cup,
		[Token(Token = "0x40020D6")]
		Wcs,
		[Token(Token = "0x40020D7")]
		WcsFinal,
		[Token(Token = "0x40020D8")]
		RankEvent,
		[Token(Token = "0x40020D9")]
		TeamMatch,
		[Token(Token = "0x40020DA")]
		BulkDecksDeletion,
		[Token(Token = "0x40020DB")]
		DuelTrial,
		[Token(Token = "0x40020DC")]
		DuelTrialRental,
		[Token(Token = "0x40020DD")]
		Versus,
		[Token(Token = "0x40020DE")]
		VersusRental,
		[Token(Token = "0x40020DF")]
		StandardRental,
		[Token(Token = "0x40020E0")]
		Rate,
		[Token(Token = "0x40020E1")]
		RateRental,
		[Token(Token = "0x40020E2")]
		Rdc,
		[Token(Token = "0x40020E3")]
		RdcRental,
		[Token(Token = "0x40020E4")]
		DiceRally,
		[Token(Token = "0x40020E5")]
		DiceRallyRental
	}

	[Token(Token = "0x2000698")]
	public enum DeckEventType
	{
		[Token(Token = "0x40020E7")]
		NewDeck,
		[Token(Token = "0x40020E8")]
		MyDeck,
		[Token(Token = "0x40020E9")]
		Neuron,
		[Token(Token = "0x40020EA")]
		TournamentDeck,
		[Token(Token = "0x40020EB")]
		ExhibitionDeck,
		[Token(Token = "0x40020EC")]
		ExhibitionRentalDeck,
		[Token(Token = "0x40020ED")]
		CupDeck,
		[Token(Token = "0x40020EE")]
		WcsDeck,
		[Token(Token = "0x40020EF")]
		WcsFinalDeck,
		[Token(Token = "0x40020F0")]
		RankEventDeck,
		[Token(Token = "0x40020F1")]
		DuelTrialDeck,
		[Token(Token = "0x40020F2")]
		DuelTrialRentalDeck,
		[Token(Token = "0x40020F3")]
		VersusDeck,
		[Token(Token = "0x40020F4")]
		VersusRentalDeck,
		[Token(Token = "0x40020F5")]
		StandardRentalDeck,
		[Token(Token = "0x40020F6")]
		RateRentalDeck,
		[Token(Token = "0x40020F7")]
		RdcDeck,
		[Token(Token = "0x40020F8")]
		RdcRentalDeck,
		[Token(Token = "0x40020F9")]
		DiceRallyDeck,
		[Token(Token = "0x40020FA")]
		DiceRallyRentalDeck
	}

	[Token(Token = "0x2000699")]
	private class TournamentReference
	{
		[Token(Token = "0x40020FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40020FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int logoId;

		[Token(Token = "0x40020FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int logoBgId;

		[Token(Token = "0x40020FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long end_ts;

		[Token(Token = "0x40020FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public long res_ts;

		[Token(Token = "0x4002100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool is_fixed_accessory;

		[Token(Token = "0x4002101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool is_fixed_pick_cards;

		[Token(Token = "0x4002102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int rentalPoolId;

		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TournamentReference()
		{
		}
	}

	[Token(Token = "0x200069A")]
	private enum ChildMenuAction
	{
		[Token(Token = "0x4002104")]
		None,
		[Token(Token = "0x4002105")]
		CreateDeck,
		[Token(Token = "0x4002106")]
		EditDeck,
		[Token(Token = "0x4002107")]
		DeckBrowser,
		[Token(Token = "0x4002108")]
		ModifyDeck,
		[Token(Token = "0x4002109")]
		RemoveDeck,
		[Token(Token = "0x400210A")]
		PublicDeckSearch,
		[Token(Token = "0x400210B")]
		StructureDeckCopy,
		[Token(Token = "0x400210C")]
		EditCopyDeck,
		[Token(Token = "0x400210D")]
		CardList,
		[Token(Token = "0x400210E")]
		NeuronMyDecks,
		[Token(Token = "0x400210F")]
		BulkDecksDeletion
	}

	[Token(Token = "0x200069B")]
	protected internal class DeckReference
	{
		[Token(Token = "0x4002110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int deckID;

		[Token(Token = "0x4002111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4002112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckEventType deckType;

		[Token(Token = "0x4002113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int caseID;

		[Token(Token = "0x4002114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int protectorID;

		[Token(Token = "0x4002115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int fieldID;

		[Token(Token = "0x4002116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int objectID;

		[Token(Token = "0x4002117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int mateBaseID;

		[Token(Token = "0x4002118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int avatarID;

		[Token(Token = "0x4002119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int coinID;

		[Token(Token = "0x400211A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] pickUpIDs;

		[Token(Token = "0x400211B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[] pickUpDecos;

		[Token(Token = "0x400211C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public long et;

		[Token(Token = "0x400211D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public long ct;

		[Token(Token = "0x400211E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long endTime;

		[Token(Token = "0x400211F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public long resTime;

		[Token(Token = "0x4002120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool isFixedAccessories;

		[Token(Token = "0x4002121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool isFixedPickCards;

		[Token(Token = "0x4002122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int logoID;

		[Token(Token = "0x4002123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int logoBgID;

		[Token(Token = "0x4002124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int regID;

		[Token(Token = "0x4002125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int stage;

		[Token(Token = "0x4002126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int eventID;

		[Token(Token = "0x4002127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int rentalPoolID;

		[Token(Token = "0x4002128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool isBadge;

		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x6E9EC0", Offset = "0x6E90C0", VA = "0x1806E9EC0")]
		public KeyValuePair<DeckEventType, int> GetUIKey()
		{
			return default(KeyValuePair<DeckEventType, int>);
		}

		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x6E9F20", Offset = "0x6E9120", VA = "0x1806E9F20")]
		public void SetAccessory(Dictionary<string, object> accessory)
		{
		}

		[Token(Token = "0x6002C1A")]
		[Address(RVA = "0x6EA230", Offset = "0x6E9430", VA = "0x1806EA230")]
		public void SetPickUp(int[] pickId, int[] pickDeco)
		{
		}

		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x6EA290", Offset = "0x6E9490", VA = "0x1806EA290")]
		public void SetPickUp(Dictionary<string, object> pickupDict)
		{
		}

		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x6EA5A0", Offset = "0x6E97A0", VA = "0x1806EA5A0")]
		public void SetTimes(long editTime, long createTime)
		{
		}

		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x6E9A80", Offset = "0x6E8C80", VA = "0x1806E9A80")]
		public Dictionary<string, object> GetAccessory()
		{
			return null;
		}

		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x6E9CB0", Offset = "0x6E8EB0", VA = "0x1806E9CB0")]
		public Dictionary<string, object> GetPickCards()
		{
			return null;
		}

		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x6EA5B0", Offset = "0x6E97B0", VA = "0x1806EA5B0")]
		public DeckReference()
		{
		}
	}

	[Token(Token = "0x20006A6")]
	[CompilerGenerated]
	private sealed class _003CDelayResetList_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckSelectViewController2 _003C_003E4__this;

		[Token(Token = "0x4002146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int deckId;

		[Token(Token = "0x1700057E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C57")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C59")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C54")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayResetList_003Ed__133(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C55")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C56")]
		[Address(RVA = "0x6FCA50", Offset = "0x6FBC50", VA = "0x1806FCA50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C58")]
		[Address(RVA = "0x6FCD80", Offset = "0x6FBF80", VA = "0x1806FCD80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected SelectMode m_SelectMode;

	[Token(Token = "0x4002058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int m_SeasonID;

	[Token(Token = "0x4002059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int m_StandardRentalID;

	[Token(Token = "0x400205A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int m_ExhibitionID;

	[Token(Token = "0x400205B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_ExhibitionRentalID;

	[Token(Token = "0x400205C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_CupID;

	[Token(Token = "0x400205D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int m_WcsID;

	[Token(Token = "0x400205E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int m_WcsFinalID;

	[Token(Token = "0x400205F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int m_RankEventID;

	[Token(Token = "0x4002060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int m_DuelTrialID;

	[Token(Token = "0x4002061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int m_DuelTrialRentalID;

	[Token(Token = "0x4002062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int m_VersusID;

	[Token(Token = "0x4002063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int m_VersusRentalID;

	[Token(Token = "0x4002064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private int m_RdcID;

	[Token(Token = "0x4002065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int m_RdcRentalID;

	[Token(Token = "0x4002066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private int m_DiceRallyID;

	[Token(Token = "0x4002067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int m_DiceRallyRentalID;

	[Token(Token = "0x4002068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private int m_RegulationID;

	[Token(Token = "0x4002069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int m_EventDeckID;

	[Token(Token = "0x400206A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400206B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_ELabelHederAreaMenu;

	[Token(Token = "0x400206C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelTextHeadline;

	[Token(Token = "0x400206D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string k_ELabelTextSub;

	[Token(Token = "0x400206E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string k_ELabelDeckNum;

	[Token(Token = "0x400206F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string k_ELabelTextDeckNum;

	[Token(Token = "0x4002070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string k_ELabelTounamentDeckNum;

	[Token(Token = "0x4002071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string k_ELabelTextTounamentDeckNum;

	[Token(Token = "0x4002072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string k_ELabelPickupCardButton;

	[Token(Token = "0x4002073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string k_ELabelBulkDecksDeletionButton;

	[Token(Token = "0x4002074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string k_ELabelBulkDecksDeletionTmp;

	[Token(Token = "0x4002075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string k_ELabelBulkDecksDeletionShortcut;

	[Token(Token = "0x4002076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string k_ELabelDeleteExecutionButton;

	[Token(Token = "0x4002077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string k_ELabelOpenNeuronDecksButton;

	[Token(Token = "0x4002078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string k_ELabelOpenNeuronDecksButtonIcon;

	[Token(Token = "0x4002079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string k_LabelJpLogoButton;

	[Token(Token = "0x400207A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly string k_LabelUniversalLogoButton;

	[Token(Token = "0x400207B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private readonly string k_LabelKoLogoButton;

	[Token(Token = "0x400207C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	protected Transform m_HeaderArea;

	[Token(Token = "0x400207D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected TextMeshProUGUI m_TextHeadline;

	[Token(Token = "0x400207E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	protected TextMeshProUGUI m_TextSub;

	[Token(Token = "0x400207F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Transform m_DeckNum;

	[Token(Token = "0x4002080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private TextMeshProUGUI m_TextDeckNum;

	[Token(Token = "0x4002081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Transform m_TounamentDeckNum;

	[Token(Token = "0x4002082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private TextMeshProUGUI m_TextTounamentDeckNum;

	[Token(Token = "0x4002083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private bool dispPickCards;

	[Token(Token = "0x4002084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	protected ElementObjectManager m_BulkDecksDeletionEom;

	[Token(Token = "0x4002085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	protected SelectionButton m_BulkDecksDeletionButton;

	[Token(Token = "0x4002086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private SelectionButton m_DeleteExecutionButton;

	[Token(Token = "0x4002087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	protected TextMeshProUGUI m_BulkDecksDeletionTmp;

	[Token(Token = "0x4002088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	[SerializeField]
	private SpriteContainer m_ButtonIconContainer;

	[Token(Token = "0x4002089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private Image m_NeuronLogoIconButton;

	[Token(Token = "0x400208A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private readonly string k_ELabelFooterMenu;

	[Token(Token = "0x400208B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private readonly string k_ELabelPublicDeckButton;

	[Token(Token = "0x400208C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private readonly string k_ELabelStructureDeckCopyButton;

	[Token(Token = "0x400208D")]
	public const string k_ArgKeyGameMode = "GameMode";

	[Token(Token = "0x400208E")]
	public const string k_ArgKeySeasonID = "StandardRentalID";

	[Token(Token = "0x400208F")]
	public const string k_ArgKeyExhibitionID = "ExhibitionID";

	[Token(Token = "0x4002090")]
	public const string k_ArgKeyExhibitionRentalID = "ExhibitionRentalID";

	[Token(Token = "0x4002091")]
	public const string k_ArgKeyCupID = "CupID";

	[Token(Token = "0x4002092")]
	public const string k_ArgKeyWcsID = "WcsID";

	[Token(Token = "0x4002093")]
	public const string k_ArgKeyWcsFinalID = "WcsFinalID";

	[Token(Token = "0x4002094")]
	public const string k_ArgKeyRankEventID = "RankEventID";

	[Token(Token = "0x4002095")]
	public const string k_ArgKeyDuelTrialID = "DuelTrialID";

	[Token(Token = "0x4002096")]
	public const string k_ArgKeyDuelTrialRentalID = "DuelTrialRentalID";

	[Token(Token = "0x4002097")]
	public const string k_ArgKeyVersusID = "VersusID";

	[Token(Token = "0x4002098")]
	public const string k_ArgKeyVersusRentalID = "VersusRentalID";

	[Token(Token = "0x4002099")]
	public const string k_ArgKeyRdcID = "RdcID";

	[Token(Token = "0x400209A")]
	public const string k_ArgKeyRdcRentalID = "RdcRentalID";

	[Token(Token = "0x400209B")]
	public const string k_ArgKeyDiceRallyID = "DicerallyID";

	[Token(Token = "0x400209C")]
	public const string k_ArgKeyDiceRallyRentalID = "DicerallyRentalID";

	[Token(Token = "0x400209D")]
	public const string k_ArgKeyEventDeckID = "EventDeckID";

	[Token(Token = "0x400209E")]
	public const string k_ArgKeyRegulationID = "RegulationID";

	[Token(Token = "0x400209F")]
	public const string k_ArgKeyBgmLabel = "BgmLabel";

	[Token(Token = "0x40020A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	protected Transform m_FooterArea;

	[Token(Token = "0x40020A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private SelectionButton m_PublicDeckButton;

	[Token(Token = "0x40020A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private SelectionButton m_StructureDeckCopyButton;

	[Token(Token = "0x40020A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private readonly string k_ELabelNewStructureBadge;

	[Token(Token = "0x40020A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private GameObject m_StructureBadge;

	[Token(Token = "0x40020A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private SelectionButton m_OpenNeuronDecksButton;

	[Token(Token = "0x40020A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private SelectionButton m_PickupCardButton;

	[Token(Token = "0x40020A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private ElementObjectManager m_PickupCardButtonEom;

	[Token(Token = "0x40020A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Transform m_PickupCardButtonOn;

	[Token(Token = "0x40020A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private Transform m_PickupCardButtonOff;

	[Token(Token = "0x40020AA")]
	public const string PREFAB_PATH_DECKEDIT_VC = "DeckEdit/DeckEdit";

	[Token(Token = "0x40020AB")]
	public const string PREFAB_PATH_CARDDIRECTORY_VC = "DeckEdit/CardDirectory";

	[Token(Token = "0x40020AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private string labelBgm;

	[Token(Token = "0x40020AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private readonly string k_ALabelOverview;

	[Token(Token = "0x40020AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private ElementObjectManager DeckOverviewPrefab;

	[Token(Token = "0x40020AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private List<string> m_DeckActionDialogButtonLabels;

	[Token(Token = "0x40020B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private Dictionary<string, UnityAction> m_DeckActionDialogCallBacks;

	[Token(Token = "0x40020B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private Action m_OnCompleteSelectDeckCallback;

	[Token(Token = "0x40020B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private Dictionary<int, TournamentReference> m_Exhibitions;

	[Token(Token = "0x40020B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private TournamentReference m_Cup;

	[Token(Token = "0x40020B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private TournamentReference m_Wcs;

	[Token(Token = "0x40020B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private TournamentReference m_Rdc;

	[Token(Token = "0x40020B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private TournamentReference m_DiceRally;

	[Token(Token = "0x40020B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private Dictionary<int, TournamentReference> m_RankEvents;

	[Token(Token = "0x40020B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private Dictionary<int, TournamentReference> m_DuelTrials;

	[Token(Token = "0x40020B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private Dictionary<KeyValuePair<int, int>, TournamentReference> m_VSs;

	[Token(Token = "0x40020BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	protected List<DeckReference> m_Decks;

	[Token(Token = "0x40020BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private List<int> m_TemplateList;

	[Token(Token = "0x40020BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	protected Dictionary<KeyValuePair<DeckEventType, int>, DeckBox> m_DeckUIs;

	[Token(Token = "0x40020BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private ChildMenuAction m_currentMenu;

	[Token(Token = "0x40020BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	private bool m_firstFocusPassed;

	[Token(Token = "0x40020BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private int lastSet;

	[Token(Token = "0x40020C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	private DeckEventType m_backupDeckType;

	[Token(Token = "0x40020C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private bool m_isLinkageCgdbDeck;

	[Token(Token = "0x40020C2")]
	private const int BulkDecksLimit = 10;

	[Token(Token = "0x40020C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private List<int> m_SelectedDecks;

	[Token(Token = "0x40020C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private Dictionary<string, List<Tween>> m_HeaderTweens;

	[Token(Token = "0x40020C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private Dictionary<string, List<Tween>> m_FooterTweens;

	[Token(Token = "0x40020C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private readonly string k_LabelHideTween;

	[Token(Token = "0x40020C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private readonly string k_LabelShowTween;

	[Token(Token = "0x1700057B")]
	private string Label_BGM
	{
		[Token(Token = "0x6002BB8")]
		[Address(RVA = "0x6FA7B0", Offset = "0x6F99B0", VA = "0x1806FA7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057C")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002BB9")]
		[Address(RVA = "0x6FA870", Offset = "0x6F9A70", VA = "0x1806FA870", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057D")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6002BBA")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002BBB")]
	[Address(RVA = "0x6F85B0", Offset = "0x6F77B0", VA = "0x1806F85B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002BBC")]
	[Address(RVA = "0x6F2B50", Offset = "0x6F1D50", VA = "0x1806F2B50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002BBD")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002BBE")]
	[Address(RVA = "0x6F7960", Offset = "0x6F6B60", VA = "0x1806F7960")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002BBF")]
	[Address(RVA = "0x6F3750", Offset = "0x6F2950", VA = "0x1806F3750", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002BC0")]
	[Address(RVA = "0x6F6460", Offset = "0x6F5660", VA = "0x1806F6460", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BC1")]
	[Address(RVA = "0x6F5420", Offset = "0x6F4620", VA = "0x1806F5420", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x6002BC2")]
	[Address(RVA = "0x6FA7A0", Offset = "0x6F99A0", VA = "0x1806FA7A0")]
	private void enterChildMenu(ChildMenuAction type)
	{
	}

	[Token(Token = "0x6002BC3")]
	[Address(RVA = "0x6F7B30", Offset = "0x6F6D30", VA = "0x1806F7B30")]
	private void ReturnFromChildMenu()
	{
	}

	[Token(Token = "0x6002BC4")]
	[Address(RVA = "0x6EB200", Offset = "0x6EA400", VA = "0x1806EB200")]
	[IteratorStateMachine(typeof(_003CDelayResetList_003Ed__133))]
	private IEnumerator DelayResetList(int deckId)
	{
		return null;
	}

	[Token(Token = "0x6002BC5")]
	[Address(RVA = "0x6F9F90", Offset = "0x6F9190", VA = "0x1806F9F90")]
	private void UpdateStructureBadge()
	{
	}

	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x6F79D0", Offset = "0x6F6BD0", VA = "0x1806F79D0")]
	private void ResetDeckList(int skipIndex)
	{
	}

	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x6F9AF0", Offset = "0x6F8CF0", VA = "0x1806F9AF0")]
	private void UpdateDeckList()
	{
	}

	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x6F7280", Offset = "0x6F6480", VA = "0x1806F7280")]
	private void OpenPublicDeckSearch()
	{
	}

	[Token(Token = "0x6002BC9")]
	[Address(RVA = "0x6EC010", Offset = "0x6EB210", VA = "0x1806EC010")]
	private void GetNeuronToken()
	{
	}

	[Token(Token = "0x6002BCA")]
	[Address(RVA = "0x6F6E30", Offset = "0x6F6030", VA = "0x1806F6E30")]
	private void OpenNeuronDeckSearch(bool isFirst = false)
	{
	}

	[Token(Token = "0x6002BCB")]
	[Address(RVA = "0x6F7900", Offset = "0x6F6B00", VA = "0x1806F7900")]
	private void OpenStructureDeckCopy()
	{
	}

	[Token(Token = "0x6002BCC")]
	[Address(RVA = "0x6EB010", Offset = "0x6EA210", VA = "0x1806EB010")]
	private void CreateNewDeck()
	{
	}

	[Token(Token = "0x6002BCD")]
	[Address(RVA = "0x6EB9D0", Offset = "0x6EABD0", VA = "0x1806EB9D0")]
	private void GetDeckList(DeckReference deckRef, Action<DeckReference> onCompleteAction)
	{
	}

	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x6F7160", Offset = "0x6F6360", VA = "0x1806F7160")]
	private void OpenOutOfTermDialog()
	{
	}

	[Token(Token = "0x6002BCF")]
	[Address(RVA = "0x6F6FB0", Offset = "0x6F61B0", VA = "0x1806F6FB0")]
	private void OpenOutOfTermDialog2(DeckEventType type)
	{
	}

	[Token(Token = "0x6002BD0")]
	[Address(RVA = "0x6F6DA0", Offset = "0x6F5FA0", VA = "0x1806F6DA0")]
	private void OpenEditDeck(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x6F6950", Offset = "0x6F5B50", VA = "0x1806F6950")]
	private void OpenDeckEditView(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x6F68C0", Offset = "0x6F5AC0", VA = "0x1806F68C0")]
	private void OpenConfirmDeckBrowser(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BD3")]
	[Address(RVA = "0x6F6500", Offset = "0x6F5700", VA = "0x1806F6500")]
	private void OpenConfirmBrowser(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BD4")]
	[Address(RVA = "0x6F7870", Offset = "0x6F6A70", VA = "0x1806F7870")]
	private void OpenSelectDeckBrowser(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BD5")]
	[Address(RVA = "0x6F7310", Offset = "0x6F6510", VA = "0x1806F7310")]
	private void OpenSelectBrowser(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BD6")]
	[Address(RVA = "0x6F64E0", Offset = "0x6F56E0", VA = "0x1806F64E0")]
	private void OpenAccessoryEdit(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002BD7")]
	[Address(RVA = "0x6EC0A0", Offset = "0x6EB2A0", VA = "0x1806EC0A0")]
	private Dictionary<string, object> GetProfileEditArgs(DeckReference deckRef)
	{
		return null;
	}

	[Token(Token = "0x6002BD8")]
	[Address(RVA = "0x6EC8F0", Offset = "0x6EBAF0", VA = "0x1806EC8F0")]
	private void InitializeDeckData()
	{
	}

	[Token(Token = "0x6002BD9")]
	[Address(RVA = "0x6EE8E0", Offset = "0x6EDAE0", VA = "0x1806EE8E0")]
	private void InitializeExhibitionInfo()
	{
	}

	[Token(Token = "0x6002BDA")]
	[Address(RVA = "0x6EE5A0", Offset = "0x6ED7A0", VA = "0x1806EE5A0")]
	private void InitializeExhibitionDeckData()
	{
	}

	[Token(Token = "0x6002BDB")]
	[Address(RVA = "0x6EC6D0", Offset = "0x6EB8D0", VA = "0x1806EC6D0")]
	private void InitializeCupInfo()
	{
	}

	[Token(Token = "0x6002BDC")]
	[Address(RVA = "0x6EC250", Offset = "0x6EB450", VA = "0x1806EC250")]
	private void InitializeCupDeckData()
	{
	}

	[Token(Token = "0x6002BDD")]
	[Address(RVA = "0x6F2650", Offset = "0x6F1850", VA = "0x1806F2650")]
	private void InitializeWcsInfo()
	{
	}

	[Token(Token = "0x6002BDE")]
	[Address(RVA = "0x6F21D0", Offset = "0x6F13D0", VA = "0x1806F21D0")]
	private void InitializeWcsDeckData()
	{
	}

	[Token(Token = "0x6002BDF")]
	[Address(RVA = "0x6EF9F0", Offset = "0x6EEBF0", VA = "0x1806EF9F0")]
	private void InitializeRankEventInfo()
	{
	}

	[Token(Token = "0x6002BE0")]
	[Address(RVA = "0x6EF6A0", Offset = "0x6EE8A0", VA = "0x1806EF6A0")]
	private void InitializeRankEventDeckData()
	{
	}

	[Token(Token = "0x6002BE1")]
	[Address(RVA = "0x6EDCC0", Offset = "0x6ECEC0", VA = "0x1806EDCC0")]
	private void InitializeDuelTrialInfo()
	{
	}

	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x6ED8D0", Offset = "0x6ECAD0", VA = "0x1806ED8D0")]
	private void InitializeDuelTrialDeckData()
	{
	}

	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x6F1750", Offset = "0x6F0950", VA = "0x1806F1750")]
	private void InitializeVersusInfo()
	{
	}

	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x6F12F0", Offset = "0x6F04F0", VA = "0x1806F12F0")]
	private void InitializeVersusDeckData()
	{
	}

	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x6F0720", Offset = "0x6EF920", VA = "0x1806F0720")]
	private void InitializeRdcInfo()
	{
	}

	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x6F02A0", Offset = "0x6EF4A0", VA = "0x1806F02A0")]
	private void InitializeRdcDeckData()
	{
	}

	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x6ED080", Offset = "0x6EC280", VA = "0x1806ED080")]
	private void InitializeDiceRallyInfo()
	{
	}

	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x6ECC30", Offset = "0x6EBE30", VA = "0x1806ECC30")]
	private void InitializeDiceRallyDeckData()
	{
	}

	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x6EF160", Offset = "0x6EE360", VA = "0x1806EF160")]
	private void InitializeMyDeckData()
	{
	}

	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x6F0E20", Offset = "0x6F0020", VA = "0x1806F0E20")]
	private void InitializeStandardRentalDeckData()
	{
	}

	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x6EFDA0", Offset = "0x6EEFA0", VA = "0x1806EFDA0")]
	private void InitializeRateRentalDeckData()
	{
	}

	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x6EEC90", Offset = "0x6EDE90", VA = "0x1806EEC90")]
	private void InitializeExhibitionRentalDeckData()
	{
	}

	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x6EE0D0", Offset = "0x6ED2D0", VA = "0x1806EE0D0")]
	private void InitializeDuelTrialRentalDeckData()
	{
	}

	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x6F1CE0", Offset = "0x6F0EE0", VA = "0x1806F1CE0")]
	private void InitializeVersusRentalDeckData()
	{
	}

	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x6F0940", Offset = "0x6EFB40", VA = "0x1806F0940")]
	private void InitializeRdcRentalDeckData()
	{
	}

	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x6ED400", Offset = "0x6EC600", VA = "0x1806ED400")]
	private void InitializeDiceRallyRentalDeckData()
	{
	}

	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x6F9B70", Offset = "0x6F8D70", VA = "0x1806F9B70")]
	private void UpdateDeckNum()
	{
	}

	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x6F9C90", Offset = "0x6F8E90", VA = "0x1806F9C90")]
	private void UpdateEventDeckNum()
	{
	}

	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x6EB510", Offset = "0x6EA710", VA = "0x1806EB510")]
	private void DispPickupCards()
	{
	}

	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x6F8290", Offset = "0x6F7490", VA = "0x1806F8290")]
	private void SetActionLabels(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x6F7D70", Offset = "0x6F6F70", VA = "0x1806F7D70")]
	private void SetActionCallBacks()
	{
	}

	[Token(Token = "0x6002BF6")]
	[Address(RVA = "0x6FA050", Offset = "0x6F9250", VA = "0x1806FA050")]
	private void UpdateTemplateList()
	{
	}

	[Token(Token = "0x6002BF7")]
	[Address(RVA = "0x6F55A0", Offset = "0x6F47A0", VA = "0x1806F55A0")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6002BF8")]
	[Address(RVA = "0x6F5520", Offset = "0x6F4720", VA = "0x1806F5520")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6002BF9")]
	[Address(RVA = "0x6F56A0", Offset = "0x6F48A0", VA = "0x1806F56A0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6002BFA")]
	[Address(RVA = "0x6F2C30", Offset = "0x6F1E30", VA = "0x1806F2C30")]
	private void OnClick(DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002BFB")]
	[Address(RVA = "0x6EA600", Offset = "0x6E9800", VA = "0x1806EA600")]
	private void BulkDecksDeletion()
	{
	}

	[Token(Token = "0x6002BFC")]
	[Address(RVA = "0x6EB900", Offset = "0x6EAB00", VA = "0x1806EB900")]
	private UnityAction GetDeckActionCallBack(int i)
	{
		return null;
	}

	[Token(Token = "0x6002BFD")]
	[Address(RVA = "0x6EABC0", Offset = "0x6E9DC0", VA = "0x1806EABC0")]
	private GameObject CreateEmbedObj(DeckReference deckRef)
	{
		return null;
	}

	[Token(Token = "0x6002BFE")]
	[Address(RVA = "0x6EB280", Offset = "0x6EA480", VA = "0x1806EB280")]
	private void DeleteDecks()
	{
	}

	[Token(Token = "0x6002BFF")]
	[Address(RVA = "0x6F2870", Offset = "0x6F1A70", VA = "0x1806F2870", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x6FA280", Offset = "0x6F9480", VA = "0x1806FA280")]
	public DeckSelectViewController2()
	{
	}
}
