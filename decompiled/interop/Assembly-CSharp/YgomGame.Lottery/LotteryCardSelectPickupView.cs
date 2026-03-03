using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Lottery;

[Token(Token = "0x20016F4")]
public class LotteryCardSelectPickupView : MonoBehaviour
{
	[Token(Token = "0x20016F5")]
	private class CardSlot
	{
		[Token(Token = "0x17001629")]
		public int index
		{
			[Token(Token = "0x6008FD2")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008FD3")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700162A")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6008FD4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008FD5")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700162B")]
		public DeckCard deckCard
		{
			[Token(Token = "0x6008FD6")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008FD7")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700162C")]
		public bool isEmpty
		{
			[Token(Token = "0x6008FD8")]
			[Address(RVA = "0xD91560", Offset = "0xD90760", VA = "0x180D91560")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700162D")]
		public int mrk
		{
			[Token(Token = "0x6008FD9")]
			[Address(RVA = "0xD915B0", Offset = "0xD907B0", VA = "0x180D915B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6008FDA")]
		[Address(RVA = "0xD91500", Offset = "0xD90700", VA = "0x180D91500")]
		public CardSlot(int index, RectTransform rt)
		{
		}

		[Token(Token = "0x6008FDB")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		public void SetCard(DeckCard card)
		{
		}

		[Token(Token = "0x6008FDC")]
		[Address(RVA = "0x615660", Offset = "0x614860", VA = "0x180615660")]
		public void SetEmpty()
		{
		}
	}

	[Token(Token = "0x20016F6")]
	public enum AutoSearchType
	{
		[Token(Token = "0x400D9AC")]
		FromLeft,
		[Token(Token = "0x400D9AD")]
		FromRight,
		[Token(Token = "0x400D9AE")]
		LastCusror
	}

	[Token(Token = "0x400D989")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_slotsEom;

	[Token(Token = "0x400D98B")]
	[FieldOffset(Offset = "0x30")]
	private CardSlot[] m_slots;

	[Token(Token = "0x400D98C")]
	[FieldOffset(Offset = "0x38")]
	private int m_slotCursor;

	[Token(Token = "0x400D990")]
	[FieldOffset(Offset = "0x50")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400D991")]
	private const string k_ELabelHeaderArea = "HeaderArea";

	[Token(Token = "0x400D992")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_HeaderAreaEom;

	[Token(Token = "0x400D993")]
	private const string k_ElabelRandomButton = "RandomButton";

	[Token(Token = "0x400D994")]
	[FieldOffset(Offset = "0x60")]
	private SelectionButton m_randomButton;

	[Token(Token = "0x400D995")]
	[FieldOffset(Offset = "0x68")]
	private ShortcutIcon m_randomButtonShortcutIconGroup;

	[Token(Token = "0x400D996")]
	[FieldOffset(Offset = "0x70")]
	private Action m_randomButtonCallback;

	[Token(Token = "0x400D997")]
	private const string k_ElabelSubmitButton = "SubmitButton";

	[Token(Token = "0x400D998")]
	private const string k_ElabelSubmitButtonFull = "HeaderArea/SubmitButton";

	[Token(Token = "0x400D999")]
	[FieldOffset(Offset = "0x78")]
	private SelectionButton m_submitButton;

	[Token(Token = "0x400D99A")]
	[FieldOffset(Offset = "0x80")]
	private ShortcutIcon m_submitButtonShortcutIcon;

	[Token(Token = "0x400D99B")]
	[FieldOffset(Offset = "0x88")]
	private Action m_submitButtonCallback;

	[Token(Token = "0x400D99C")]
	private const string k_ElabelInfoText = "InfoText";

	[Token(Token = "0x400D99D")]
	[FieldOffset(Offset = "0x90")]
	private RectTransform m_SelectedWindowCursor;

	[Token(Token = "0x400D9A4")]
	[FieldOffset(Offset = "0xC8")]
	private DeckCard template_DeckCard;

	[Token(Token = "0x1700161C")]
	private RectTransform m_slotsContent
	{
		[Token(Token = "0x6008F83")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F84")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700161D")]
	private ExtendedTextMeshProUGUI m_cardSumText
	{
		[Token(Token = "0x6008F89")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F8A")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700161E")]
	public bool isLoading
	{
		[Token(Token = "0x6008F8B")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008F8C")]
		[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700161F")]
	public bool isSelected
	{
		[Token(Token = "0x6008F8D")]
		[Address(RVA = "0x7CE730", Offset = "0x7CD930", VA = "0x1807CE730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008F8E")]
		[Address(RVA = "0xD99E80", Offset = "0xD99080", VA = "0x180D99E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001620")]
	private SelectionButton m_NoItemButton
	{
		[Token(Token = "0x6008F91")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F92")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001621")]
	private ExtendedTextMeshProUGUI m_NoItemText
	{
		[Token(Token = "0x6008F93")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F94")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001622")]
	private RectTransform m_Loading
	{
		[Token(Token = "0x6008F95")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F96")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001623")]
	private RectTransform m_Viewport
	{
		[Token(Token = "0x6008F97")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F98")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001624")]
	public DropArea m_DropArea
	{
		[Token(Token = "0x6008F99")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F9A")]
		[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001625")]
	private RectTransform m_DropAreaOver
	{
		[Token(Token = "0x6008F9B")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F9C")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001626")]
	public Action<DeckCard, int, bool> onCreateDeckCard
	{
		[Token(Token = "0x6008F9D")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F9E")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001627")]
	public Action onNoItemButtonSelectedCallback
	{
		[Token(Token = "0x6008F9F")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008FA0")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001628")]
	public Action onNoItemButtonInputRightCallback
	{
		[Token(Token = "0x6008FA1")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008FA2")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6008F85")]
	[Address(RVA = "0xD99A00", Offset = "0xD98C00", VA = "0x180D99A00")]
	private CardSlot scanSlots(Predicate<CardSlot> predicator, int start, bool reverse)
	{
		return null;
	}

	[Token(Token = "0x6008F86")]
	[Address(RVA = "0xD99AE0", Offset = "0xD98CE0", VA = "0x180D99AE0")]
	private int searchEmptySlot()
	{
		return default(int);
	}

	[Token(Token = "0x6008F87")]
	[Address(RVA = "0xD99D60", Offset = "0xD98F60", VA = "0x180D99D60")]
	private int searchSlotByCardID(int cardID)
	{
		return default(int);
	}

	[Token(Token = "0x6008F88")]
	[Address(RVA = "0xD99BC0", Offset = "0xD98DC0", VA = "0x180D99BC0")]
	private int searchNearCardSlot(int current)
	{
		return default(int);
	}

	[Token(Token = "0x6008F8F")]
	[Address(RVA = "0x931650", Offset = "0x930850", VA = "0x180931650")]
	private void OnClickRandomButton()
	{
	}

	[Token(Token = "0x6008F90")]
	[Address(RVA = "0x812BF0", Offset = "0x811DF0", VA = "0x180812BF0")]
	private void OnClickSubmitButton()
	{
	}

	[Token(Token = "0x6008FA3")]
	[Address(RVA = "0xD978F0", Offset = "0xD96AF0", VA = "0x180D978F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008FA4")]
	[Address(RVA = "0xD97E80", Offset = "0xD97080", VA = "0x180D97E80")]
	private void InitilaizeElements()
	{
	}

	[Token(Token = "0x6008FA5")]
	[Address(RVA = "0xD99600", Offset = "0xD98800", VA = "0x180D99600")]
	private void Start()
	{
	}

	[Token(Token = "0x6008FA6")]
	[Address(RVA = "0xD98530", Offset = "0xD97730", VA = "0x180D98530")]
	private DeckCard InstantiateCardObject(CardBaseData data, RectTransform parent)
	{
		return null;
	}

	[Token(Token = "0x6008FA7")]
	[Address(RVA = "0xD99910", Offset = "0xD98B10", VA = "0x180D99910")]
	private int getCardSum()
	{
		return default(int);
	}

	[Token(Token = "0x6008FA8")]
	[Address(RVA = "0xD99E90", Offset = "0xD99090", VA = "0x180D99E90")]
	private void updateCardSumDisp()
	{
	}

	[Token(Token = "0x6008FA9")]
	[Address(RVA = "0xD97530", Offset = "0xD96730", VA = "0x180D97530")]
	private DeckCard AddCard(int cardID, int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6008FAA")]
	[Address(RVA = "0xD98B00", Offset = "0xD97D00", VA = "0x180D98B00")]
	private DeckCard RemoveCard(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6008FAB")]
	[Address(RVA = "0xD99590", Offset = "0xD98790", VA = "0x180D99590")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x6008FAC")]
	[Address(RVA = "0xD97E10", Offset = "0xD97010", VA = "0x180D97E10")]
	public void HideLoading()
	{
	}

	[Token(Token = "0x6008FAD")]
	[Address(RVA = "0xD99250", Offset = "0xD98450", VA = "0x180D99250")]
	public void SetCurrentView(bool current)
	{
	}

	[Token(Token = "0x6008FAE")]
	[Address(RVA = "0xD98830", Offset = "0xD97A30", VA = "0x180D98830")]
	public void RegisterRandomButtonCallback(Action callback)
	{
	}

	[Token(Token = "0x6008FAF")]
	[Address(RVA = "0xD988E0", Offset = "0xD97AE0", VA = "0x180D988E0")]
	public void RegisterRandomButtonKeyConfig(SelectorManager.KeyType keyMain)
	{
	}

	[Token(Token = "0x6008FB0")]
	[Address(RVA = "0xD98990", Offset = "0xD97B90", VA = "0x180D98990")]
	public void RegisterSubmitButtonCallback(Action callback)
	{
	}

	[Token(Token = "0x6008FB1")]
	[Address(RVA = "0xD98A50", Offset = "0xD97C50", VA = "0x180D98A50")]
	public void RegisterSubmitButtonKeyConfig(SelectorManager.KeyType keyMain)
	{
	}

	[Token(Token = "0x6008FB2")]
	[Address(RVA = "0xD99730", Offset = "0xD98930", VA = "0x180D99730")]
	public bool TryAddToSlot(int cardID, out DeckCard card, out int slotIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6008FB3")]
	[Address(RVA = "0xD978B0", Offset = "0xD96AB0", VA = "0x180D978B0")]
	public DeckCard AddToSlot(int cardID)
	{
		return null;
	}

	[Token(Token = "0x6008FB4")]
	[Address(RVA = "0xD98D60", Offset = "0xD97F60", VA = "0x180D98D60")]
	public DeckCard RemoveFromSlot(int cardID)
	{
		return null;
	}

	[Token(Token = "0x6008FB5")]
	[Address(RVA = "0xD98D90", Offset = "0xD97F90", VA = "0x180D98D90")]
	public DeckCard RemoveSlotIndex(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6008FB6")]
	[Address(RVA = "0xD986D0", Offset = "0xD978D0", VA = "0x180D986D0")]
	public bool IsEmptySlot(int slotIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6008FB7")]
	[Address(RVA = "0xD98750", Offset = "0xD97950", VA = "0x180D98750")]
	public bool IsFullAllSlots()
	{
		return default(bool);
	}

	[Token(Token = "0x6008FB8")]
	[Address(RVA = "0xD98E50", Offset = "0xD98050", VA = "0x180D98E50")]
	public int SearchCardSlot(int cardID)
	{
		return default(int);
	}

	[Token(Token = "0x6008FB9")]
	[Address(RVA = "0xD98E60", Offset = "0xD98060", VA = "0x180D98E60")]
	public int SearchNearestCardSlot(int slotIndex, int dir)
	{
		return default(int);
	}

	[Token(Token = "0x6008FBA")]
	[Address(RVA = "0xD97A50", Offset = "0xD96C50", VA = "0x180D97A50")]
	public CardBaseData GetCardData(int slotIndex)
	{
		return default(CardBaseData);
	}

	[Token(Token = "0x6008FBB")]
	[Address(RVA = "0xD97C40", Offset = "0xD96E40", VA = "0x180D97C40")]
	public int GetCardNum()
	{
		return default(int);
	}

	[Token(Token = "0x6008FBC")]
	[Address(RVA = "0xD97C50", Offset = "0xD96E50", VA = "0x180D97C50")]
	public int[] GetResultCardIDs()
	{
		return null;
	}

	[Token(Token = "0x6008FBD")]
	[Address(RVA = "0xD99200", Offset = "0xD98400", VA = "0x180D99200")]
	public void SetCardCursorByCardID(int cardID)
	{
	}

	[Token(Token = "0x6008FBE")]
	[Address(RVA = "0xD99220", Offset = "0xD98420", VA = "0x180D99220")]
	public void SetCardCursor(int cursor)
	{
	}

	[Token(Token = "0x6008FBF")]
	[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
	public int GetCardCursor()
	{
		return default(int);
	}

	[Token(Token = "0x6008FC0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void UpdateDisplayMode(DeckEditViewController2.DisplayMode mode, bool updateScroll = true)
	{
	}

	[Token(Token = "0x6008FC1")]
	[Address(RVA = "0xD99330", Offset = "0xD98530", VA = "0x180D99330")]
	public void SetDispDropAreaOver(bool disp)
	{
	}

	[Token(Token = "0x6008FC2")]
	[Address(RVA = "0xD99370", Offset = "0xD98570", VA = "0x180D99370")]
	public void SetDispNoItemButton(bool disp)
	{
	}

	[Token(Token = "0x6008FC3")]
	[Address(RVA = "0xD99170", Offset = "0xD98370", VA = "0x180D99170")]
	public bool SelectNoItemButton()
	{
		return default(bool);
	}

	[Token(Token = "0x6008FC4")]
	[Address(RVA = "0xD994D0", Offset = "0xD986D0", VA = "0x180D994D0")]
	public void SetNoItemTextVisible(bool visible)
	{
	}

	[Token(Token = "0x6008FC5")]
	[Address(RVA = "0xD98F60", Offset = "0xD98160", VA = "0x180D98F60")]
	public bool SelectItemAuto(AutoSearchType search)
	{
		return default(bool);
	}

	[Token(Token = "0x6008FC6")]
	[Address(RVA = "0xD99410", Offset = "0xD98610", VA = "0x180D99410")]
	public void SetInfoText(string txt)
	{
	}

	[Token(Token = "0x6008FC7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void CursorJumpUp()
	{
	}

	[Token(Token = "0x6008FC8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void CursorJumpDown()
	{
	}

	[Token(Token = "0x6008FC9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void CursorJumpLeft()
	{
	}

	[Token(Token = "0x6008FCA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void CursorJumpRight()
	{
	}

	[Token(Token = "0x6008FCB")]
	[Address(RVA = "0xD99900", Offset = "0xD98B00", VA = "0x180D99900")]
	public LotteryCardSelectPickupView()
	{
	}
}
