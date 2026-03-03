using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Deck;

[Token(Token = "0x2001082")]
public class CardCraftDialog : SelectDialogViewControllerBase<CardCraftDialog.CraftMode, CardBaseData, Dictionary<int, CraftCompensation>, int>, IBokeSupported
{
	[Token(Token = "0x2001083")]
	public enum CraftMode
	{
		[Token(Token = "0x400AFFC")]
		Create,
		[Token(Token = "0x400AFFD")]
		BoostCreate,
		[Token(Token = "0x400AFFE")]
		Dismantle
	}

	[Token(Token = "0x2001084")]
	private class CraftGroup : ElementWidget
	{
		[Token(Token = "0x400AFFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ElementObjectManager m_OperationEom;

		[Token(Token = "0x400B00A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SelectionButton m_TargetButton;

		[Token(Token = "0x400B00C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ElementObjectManager m_ResultEom;

		[Token(Token = "0x17001007")]
		public RawImage m_CardImage
		{
			[Token(Token = "0x600654C")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600654D")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001008")]
		public Image m_Rarity
		{
			[Token(Token = "0x600654E")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600654F")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001009")]
		public SelectionButton m_IncrementButton
		{
			[Token(Token = "0x6006550")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006551")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700100A")]
		public SelectionButton m_DecrementButton
		{
			[Token(Token = "0x6006552")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006553")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700100B")]
		public SelectionButton m_BoostIncrementButton
		{
			[Token(Token = "0x6006554")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006555")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700100C")]
		public SelectionButton m_BoostDecrementButton
		{
			[Token(Token = "0x6006556")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006557")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700100D")]
		public TMP_Text m_TextNum
		{
			[Token(Token = "0x6006558")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006559")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700100E")]
		public TMP_Text m_TextBeforeNum
		{
			[Token(Token = "0x600655A")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600655B")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700100F")]
		public TMP_Text m_TextAfterNum
		{
			[Token(Token = "0x600655C")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600655D")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001010")]
		public TMP_Text m_TextPremiumNum
		{
			[Token(Token = "0x600655E")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600655F")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001011")]
		public TMP_Text m_TextSetting
		{
			[Token(Token = "0x6006560")]
			[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006561")]
			[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001012")]
		public Image m_CPIcon
		{
			[Token(Token = "0x6006563")]
			[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006564")]
			[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001013")]
		public TMP_Text m_TextBeforeCP
		{
			[Token(Token = "0x6006565")]
			[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006566")]
			[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001014")]
		public TMP_Text m_TextAfterCP
		{
			[Token(Token = "0x6006567")]
			[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006568")]
			[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001015")]
		public TMP_Text m_TextCompensation
		{
			[Token(Token = "0x6006569")]
			[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600656A")]
			[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001016")]
		public InputFieldWidget m_InputField
		{
			[Token(Token = "0x600656B")]
			[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600656C")]
			[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001017")]
		public SelectionButton m_ExchangeButton
		{
			[Token(Token = "0x600656D")]
			[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600656E")]
			[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006562")]
		[Address(RVA = "0xAAE0E0", Offset = "0xAAD2E0", VA = "0x180AAE0E0")]
		private void InitializeOperationUI()
		{
		}

		[Token(Token = "0x600656F")]
		[Address(RVA = "0xAAE460", Offset = "0xAAD660", VA = "0x180AAE460")]
		private void InitializeResultUI()
		{
		}

		[Token(Token = "0x6006570")]
		[Address(RVA = "0xAAE060", Offset = "0xAAD260", VA = "0x180AAE060", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006571")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public CraftGroup()
		{
		}
	}

	[Token(Token = "0x400AFCC")]
	private const string PREFAB_PATH_CARDCRAFTDIALOG = "DeckEdit/CraftDialog";

	[Token(Token = "0x400AFCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private CraftMode mode;

	[Token(Token = "0x400AFD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int currentCardNum;

	[Token(Token = "0x400AFD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int currentCraftPoint;

	[Token(Token = "0x400AFD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int createPoint;

	[Token(Token = "0x400AFD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int dismantlePoint;

	[Token(Token = "0x400AFD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int compensationPt;

	[Token(Token = "0x400AFD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int craftNum;

	[Token(Token = "0x400AFD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private int useCP;

	[Token(Token = "0x400AFD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private CardCollectionInfo.Premium targetPrem;

	[Token(Token = "0x400AFD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private bool isCompensation;

	[Token(Token = "0x400AFD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private (int, int, bool) compensationId;

	[Token(Token = "0x400AFDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private int compensationPoint;

	[Token(Token = "0x400AFDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int compensationNumMax;

	[Token(Token = "0x400AFDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private string strEndTime;

	[Token(Token = "0x400AFDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Dictionary<int, CraftCompensation> m_CraftCompensations;

	[Token(Token = "0x400AFDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Dictionary<string, object> m_Compensations;

	[Token(Token = "0x400AFDF")]
	private const string LABEL_SBN_BOOSTBUTTON = "ButtonSSS";

	[Token(Token = "0x400AFE0")]
	private const string LABEL_SBN_CANCELBUTTON = "ButtonFooter0";

	[Token(Token = "0x400AFE1")]
	private const string LABEL_SBN_CRAFTBUTTON = "ButtonFooter1";

	[Token(Token = "0x400AFE2")]
	private const string LABEL_SBN_DESTRUCTIVEBUTTON = "ButtonDestructive";

	[Token(Token = "0x400AFE3")]
	private const string LABEL_TXT_CRAFTBUTTONLABEL = "TextButtonFooter1";

	[Token(Token = "0x400AFE4")]
	private const string LABEL_TXT_CANCELBUTTONLABEL = "TextButtonFooter0";

	[Token(Token = "0x400AFE5")]
	private const string LABEL_TXT_CONFIRMATIONPROMPT = "TextDescription";

	[Token(Token = "0x400AFE6")]
	private const string LABEL_TXT_CONFIRMATIONMESSAGE1 = "TextMessage1";

	[Token(Token = "0x400AFE7")]
	private const string LABEL_TXT_CONFIRMATIONMESSAGE2 = "TextMessage2";

	[Token(Token = "0x400AFE8")]
	private const string LABEL_TXT_DIALOGTITLE = "TextTitle";

	[Token(Token = "0x400AFE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private TMP_Text m_Title;

	[Token(Token = "0x400AFEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private SelectionButton m_BoostButton;

	[Token(Token = "0x400AFEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private TMP_Text m_BoostButtonText;

	[Token(Token = "0x400AFEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private TMP_Text m_CraftPrompt;

	[Token(Token = "0x400AFED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private TMP_Text m_CraftMessage1;

	[Token(Token = "0x400AFEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private TMP_Text m_CraftMessage2;

	[Token(Token = "0x400AFEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private TMP_Text m_CraftButtonLabel;

	[Token(Token = "0x400AFF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private TMP_Text m_CancelButtonLabel;

	[Token(Token = "0x400AFF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private SelectionButton m_CraftButton;

	[Token(Token = "0x400AFF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x400AFF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private SelectionButton m_DestructiveButton;

	[Token(Token = "0x400AFF4")]
	private const int CREATE_NUM_MIN = 1;

	[Token(Token = "0x400AFF5")]
	private const int CREATE_NUM_MAX = 3;

	[Token(Token = "0x400AFF6")]
	private const int CREATE_BOOST_NUM_MAX = 99;

	[Token(Token = "0x400AFF7")]
	private const int DISMANTLE_NUM_MIN = 1;

	[Token(Token = "0x400AFF8")]
	private const int DISMANTLE_NUM_MAX = 99;

	[Token(Token = "0x400AFF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Action<int, (int, int, bool), bool, bool, (CardCollectionInfo.Premium, int), Action> OnDicidedCallback;

	[Token(Token = "0x400AFFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private CraftGroup m_CraftGroup;

	[Token(Token = "0x17001005")]
	private int m_CurrentCardID
	{
		[Token(Token = "0x6006537")]
		[Address(RVA = "0xA2A0E0", Offset = "0xA292E0", VA = "0x180A2A0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006538")]
		[Address(RVA = "0xA2A530", Offset = "0xA29730", VA = "0x180A2A530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001006")]
	private CardCollectionInfo.Premium m_CurrentPremium
	{
		[Token(Token = "0x6006539")]
		[Address(RVA = "0x62D9C0", Offset = "0x62CBC0", VA = "0x18062D9C0")]
		[CompilerGenerated]
		get
		{
			return default(CardCollectionInfo.Premium);
		}
		[Token(Token = "0x600653A")]
		[Address(RVA = "0x62DFB0", Offset = "0x62D1B0", VA = "0x18062DFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600653B")]
	[Address(RVA = "0xAA59D0", Offset = "0xAA4BD0", VA = "0x180AA59D0")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x600653C")]
	[Address(RVA = "0xAA82C0", Offset = "0xAA74C0", VA = "0x180AA82C0")]
	public static void Open(CraftMode mode, CardBaseData cbd, Dictionary<int, CraftCompensation> compDic, [Optional] Action<int, (int, int, bool), bool, bool, (CardCollectionInfo.Premium, int), Action> callback)
	{
	}

	[Token(Token = "0x600653D")]
	[Address(RVA = "0xAA8490", Offset = "0xAA7690", VA = "0x180AA8490")]
	public static void Open(ViewController manager, CraftMode mode, int cardID, CardCollectionInfo.Premium prem, [Optional] Action<int, (int, int), bool, bool, (CardCollectionInfo.Premium, int), Action> callback)
	{
	}

	[Token(Token = "0x600653E")]
	[Address(RVA = "0xAA5D30", Offset = "0xAA4F30", VA = "0x180AA5D30", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600653F")]
	[Address(RVA = "0xAA5E70", Offset = "0xAA5070", VA = "0x180AA5E70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006540")]
	[Address(RVA = "0xAA8780", Offset = "0xAA7980", VA = "0x180AA8780")]
	private void SetCraftNum(int craftNum)
	{
	}

	[Token(Token = "0x6006541")]
	[Address(RVA = "0xAA9230", Offset = "0xAA8430", VA = "0x180AA9230")]
	private void SetNumPremiums()
	{
	}

	[Token(Token = "0x6006542")]
	[Address(RVA = "0xAA52F0", Offset = "0xAA44F0", VA = "0x180AA52F0")]
	public static Dictionary<int, CraftCompensation> CreateCompensationDict()
	{
		return null;
	}

	[Token(Token = "0x6006543")]
	[Address(RVA = "0xAA5030", Offset = "0xAA4230", VA = "0x180AA5030")]
	private void CompensationCheck()
	{
	}

	[Token(Token = "0x6006544")]
	[Address(RVA = "0xAA94C0", Offset = "0xAA86C0", VA = "0x180AA94C0")]
	private void ToggleBoost()
	{
	}

	[Token(Token = "0x6006545")]
	[Address(RVA = "0xAA7E80", Offset = "0xAA7080", VA = "0x180AA7E80")]
	private void OnDicide()
	{
	}

	[Token(Token = "0x6006546")]
	[Address(RVA = "0xAA9990", Offset = "0xAA8B90", VA = "0x180AA9990")]
	public CardCraftDialog()
	{
	}
}
