using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.FreeScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x20006AF")]
public class WCSEntry : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20006B0")]
	private class DeckInfo
	{
		[Token(Token = "0x400219F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DeckSelectViewController2.DeckReference deckRef;

		[Token(Token = "0x40021A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int playerIndex;

		[Token(Token = "0x40021A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int deckIndex;

		[Token(Token = "0x40021A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool valid;

		[Token(Token = "0x40021A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<int> cardIDs;

		[Token(Token = "0x6002CD1")]
		[Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public DeckInfo(DeckSelectViewController2.DeckReference reference, int deckIndex, int playerIndex)
		{
		}

		[Token(Token = "0x6002CD2")]
		[Address(RVA = "0x7030B0", Offset = "0x7022B0", VA = "0x1807030B0")]
		public void UpdateDeckData()
		{
		}

		[Token(Token = "0x6002CD3")]
		[Address(RVA = "0x7034C0", Offset = "0x7026C0", VA = "0x1807034C0")]
		public void UpdateValid()
		{
		}

		[Token(Token = "0x6002CD4")]
		[Address(RVA = "0x702ED0", Offset = "0x7020D0", VA = "0x180702ED0")]
		public bool IsContainCard(int shareCardId)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006B1")]
	private class PlayerInfo
	{
		[Token(Token = "0x40021A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x40021A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int iconId;

		[Token(Token = "0x40021A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int frameId;

		[Token(Token = "0x40021A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x40021A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string pcode;

		[Token(Token = "0x40021A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string onlineId;

		[Token(Token = "0x40021AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isSameOs;

		[Token(Token = "0x40021AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DeckInfo[] decks;

		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x706E70", Offset = "0x706070", VA = "0x180706E70")]
		public bool IsContainInDecks(int cardID)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x706EF0", Offset = "0x7060F0", VA = "0x180706EF0")]
		public PlayerInfo()
		{
		}
	}

	[Token(Token = "0x20006B2")]
	public class ShareCard
	{
		[Token(Token = "0x40021AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x40021AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int cardID;

		[Token(Token = "0x40021AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RawImage imageCard;

		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x706F50", Offset = "0x706150", VA = "0x180706F50")]
		public void SetShareCard(int id)
		{
		}

		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ShareCard()
		{
		}
	}

	[Token(Token = "0x4002173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string k_ELabelButtonCaution;

	[Token(Token = "0x4002174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string k_ELabelTextDate;

	[Token(Token = "0x4002175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string k_ELabelButtonCheckRegulation;

	[Token(Token = "0x4002176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string k_ELabelButtonRegisterDeck;

	[Token(Token = "0x4002177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string k_ELabelButtonRegisterTeam;

	[Token(Token = "0x4002178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string k_ELabelShareCards;

	[Token(Token = "0x4002179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static string k_ELabelImageCard;

	[Token(Token = "0x400217A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static string k_ScrollView;

	[Token(Token = "0x400217B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string k_InputField;

	[Token(Token = "0x400217C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly int maxPlayerNumber;

	[Token(Token = "0x400217D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private readonly int maxDeckNumber;

	[Token(Token = "0x400217E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int m_wcsId;

	[Token(Token = "0x400217F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private bool m_IsRegistered;

	[Token(Token = "0x4002180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
	private bool m_CanRegisterAsMember;

	[Token(Token = "0x4002181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
	private bool m_CanRegisterAsLeader;

	[Token(Token = "0x4002182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string m_TeamName;

	[Token(Token = "0x4002183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool isReader;

	[Token(Token = "0x4002184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool isPassRegulation;

	[Token(Token = "0x4002185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	private bool isDeckChanged;

	[Token(Token = "0x4002186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SelectionButton m_ButtonCaution;

	[Token(Token = "0x4002187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ExtendedTextMeshProUGUI m_DateText;

	[Token(Token = "0x4002188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject buttonResetArea;

	[Token(Token = "0x4002189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ElementObjectManager m_ShareCardEom;

	[Token(Token = "0x400218A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private InputFieldWidget inputFieldWidget;

	[Token(Token = "0x400218B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private SelectionButton m_ButtonResetShareCards;

	[Token(Token = "0x400218C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private List<PlayerInfo> m_Players;

	[Token(Token = "0x400218D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<ShareCard> m_ShareCards;

	[Token(Token = "0x400218E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<GameObject> playerObjects;

	[Token(Token = "0x400218F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string actionSheetName;

	[Token(Token = "0x4002190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<string> m_DeckActionDialogButtonLabels;

	[Token(Token = "0x4002191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Dictionary<string, Action<int, int>> m_DeckActionDialogCallBacks;

	[Token(Token = "0x4002192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<Tween> m_HideTween;

	[Token(Token = "0x4002193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<Tween> m_ShowTween;

	[Token(Token = "0x4002194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private SelectionButton m_ButtonCheckRegulation;

	[Token(Token = "0x4002195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private SelectionButton m_ButtonRegisterDeck;

	[Token(Token = "0x4002196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private SelectionButton m_ButtonRegisterTeam;

	[Token(Token = "0x4002197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private ExtendedTextMeshProUGUI m_ButtonRegisterDeckText;

	[Token(Token = "0x4002198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ExtendedTextMeshProUGUI m_ButtonRegisterTeamText;

	[Token(Token = "0x4002199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x400219A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private FreeScrollView m_FreeScrollView;

	[Token(Token = "0x400219B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private List<SelectionItem> upEdgeButtons;

	[Token(Token = "0x400219C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<SelectionItem> rightEdgeButtons;

	[Token(Token = "0x400219D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<int> indexOrder;

	[Token(Token = "0x400219E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private StringBuilder stringBuilder;

	[Token(Token = "0x17000587")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002C83")]
		[Address(RVA = "0x716580", Offset = "0x715780", VA = "0x180716580", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000588")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6002C84")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002C85")]
	[Address(RVA = "0x711800", Offset = "0x710A00", VA = "0x180711800")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002C86")]
	[Address(RVA = "0x70FDA0", Offset = "0x70EFA0", VA = "0x18070FDA0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002C87")]
	[Address(RVA = "0x70FDD0", Offset = "0x70EFD0", VA = "0x18070FDD0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6002C88")]
	[Address(RVA = "0x710F00", Offset = "0x710100", VA = "0x180710F00", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002C89")]
	[Address(RVA = "0x713040", Offset = "0x712240", VA = "0x180713040")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C8A")]
	[Address(RVA = "0x712C80", Offset = "0x711E80", VA = "0x180712C80")]
	private void SetScrollView()
	{
	}

	[Token(Token = "0x6002C8B")]
	[Address(RVA = "0x70C340", Offset = "0x70B540", VA = "0x18070C340")]
	private bool CustomTransition(SelectionItem selectedItem, PadInputDirection direction, Vector2 dir, bool byAnalog)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C8C")]
	[Address(RVA = "0x711030", Offset = "0x710230", VA = "0x180711030")]
	private bool OnSelectorSelected(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C8D")]
	[Address(RVA = "0x714840", Offset = "0x713A40", VA = "0x180714840")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6002C8E")]
	[Address(RVA = "0x70DED0", Offset = "0x70D0D0", VA = "0x18070DED0")]
	private void InitializePlayer()
	{
	}

	[Token(Token = "0x6002C8F")]
	[Address(RVA = "0x70C7F0", Offset = "0x70B9F0", VA = "0x18070C7F0")]
	private void GetClientWorkData()
	{
	}

	[Token(Token = "0x6002C90")]
	[Address(RVA = "0x70CD90", Offset = "0x70BF90", VA = "0x18070CD90")]
	private void InitializeElement()
	{
	}

	[Token(Token = "0x6002C91")]
	[Address(RVA = "0x70F420", Offset = "0x70E620", VA = "0x18070F420")]
	private void InitializeShareCards()
	{
	}

	[Token(Token = "0x6002C92")]
	[Address(RVA = "0x70BA30", Offset = "0x70AC30", VA = "0x18070BA30")]
	private bool CheckMyDeck()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C93")]
	[Address(RVA = "0x70CC30", Offset = "0x70BE30", VA = "0x18070CC30")]
	private Dictionary<string, object> GetMemberProfile(int index)
	{
		return null;
	}

	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x70CD20", Offset = "0x70BF20", VA = "0x18070CD20")]
	private string GetTeamName()
	{
		return null;
	}

	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x70CAC0", Offset = "0x70BCC0", VA = "0x18070CAC0")]
	private DeckSelectViewController2.DeckReference GetDeckReference(int deckIndex)
	{
		return null;
	}

	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x70CCC0", Offset = "0x70BEC0", VA = "0x18070CCC0")]
	private int GetMyIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002C97")]
	[Address(RVA = "0x7129C0", Offset = "0x711BC0", VA = "0x1807129C0")]
	private void SetFieldBase(ElementObjectManager eom, int playerIndex)
	{
	}

	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x712BC0", Offset = "0x711DC0", VA = "0x180712BC0")]
	private void SetMemberIndexTexture(ElementObjectManager conditionEom, int playerIndex)
	{
	}

	[Token(Token = "0x6002C99")]
	[Address(RVA = "0x70FCA0", Offset = "0x70EEA0", VA = "0x18070FCA0")]
	private bool IsMemberRegistered(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C9A")]
	[Address(RVA = "0x70FBA0", Offset = "0x70EDA0", VA = "0x18070FBA0")]
	private bool IsAllMemberRegistered()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x70FD30", Offset = "0x70EF30", VA = "0x18070FD30")]
	private bool IsMine(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C9C")]
	[Address(RVA = "0x711060", Offset = "0x710260", VA = "0x180711060")]
	private void OnValueChanged(string input)
	{
	}

	[Token(Token = "0x6002C9D")]
	[Address(RVA = "0x7109E0", Offset = "0x70FBE0", VA = "0x1807109E0")]
	private void OnClickOK(string name)
	{
	}

	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x711250", Offset = "0x710450", VA = "0x180711250")]
	private void OpenCaution()
	{
	}

	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x7100C0", Offset = "0x70F2C0", VA = "0x1807100C0")]
	private void OnClickDeck(int playerIndex, int deckIndex, DeckSelectViewController2.DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x710C50", Offset = "0x70FE50", VA = "0x180710C50")]
	private void OnClickShareCard(int index)
	{
	}

	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x7112A0", Offset = "0x7104A0", VA = "0x1807112A0")]
	private void OpenConfirmBrowser(int index, int slot, DeckSelectViewController2.DeckReference deckRef)
	{
	}

	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x712030", Offset = "0x711230", VA = "0x180712030")]
	private void SaveShareCard(int index, int cardID)
	{
	}

	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x712F00", Offset = "0x712100", VA = "0x180712F00")]
	private void SetShareCard(Dictionary<string, int> shareCardIds, Dictionary<string, int> shareCardPrems, int index, int cardID)
	{
	}

	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x711BF0", Offset = "0x710DF0", VA = "0x180711BF0")]
	private void ResetShareCards()
	{
	}

	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x70C0D0", Offset = "0x70B2D0", VA = "0x18070C0D0")]
	private bool CheckShareCard(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x70BBF0", Offset = "0x70ADF0", VA = "0x18070BBF0")]
	public void CheckRegulation()
	{
	}

	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0x711870", Offset = "0x710A70", VA = "0x180711870")]
	private void RegisterDeck()
	{
	}

	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0x7119B0", Offset = "0x710BB0", VA = "0x1807119B0")]
	private void RegisterTeam()
	{
	}

	[Token(Token = "0x6002CA9")]
	[Address(RVA = "0x70B7F0", Offset = "0x70A9F0", VA = "0x18070B7F0")]
	private void CancelDeckRegister()
	{
	}

	[Token(Token = "0x6002CAA")]
	[Address(RVA = "0x70B910", Offset = "0x70AB10", VA = "0x18070B910")]
	private void CancelTeamRegister()
	{
	}

	[Token(Token = "0x6002CAB")]
	[Address(RVA = "0x70C610", Offset = "0x70B810", VA = "0x18070C610")]
	private Dictionary<string, object> GetArgs(int index, int slot)
	{
		return null;
	}

	[Token(Token = "0x6002CAC")]
	[Address(RVA = "0x711570", Offset = "0x710770", VA = "0x180711570")]
	private void OpenDeckEdit(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002CAD")]
	[Address(RVA = "0x70C260", Offset = "0x70B460", VA = "0x18070C260")]
	private void CreateNewDeck(int index, int slot)
	{
	}

	[Token(Token = "0x6002CAE")]
	[Address(RVA = "0x7115D0", Offset = "0x7107D0", VA = "0x1807115D0")]
	private void OpenMyDeck(int index, int slot)
	{
	}

	[Token(Token = "0x6002CAF")]
	[Address(RVA = "0x711660", Offset = "0x710860", VA = "0x180711660")]
	private void OpenNeuronDeckSearch(int index, int slot, bool isFirst = false)
	{
	}

	[Token(Token = "0x6002CB0")]
	[Address(RVA = "0x70B0F0", Offset = "0x70A2F0", VA = "0x18070B0F0")]
	public void CallAccountKidGetNeuronTokenAPI(int index, int slot)
	{
	}

	[Token(Token = "0x6002CB1")]
	[Address(RVA = "0x70B380", Offset = "0x70A580", VA = "0x18070B380")]
	private void CallGetFinalDeckInfoAPI(bool isEntry)
	{
	}

	[Token(Token = "0x6002CB2")]
	[Address(RVA = "0x70B1E0", Offset = "0x70A3E0", VA = "0x18070B1E0")]
	private void CallCheckFinalDeckRegulation(string message)
	{
	}

	[Token(Token = "0x6002CB3")]
	[Address(RVA = "0x70B550", Offset = "0x70A750", VA = "0x18070B550")]
	private void CallSetFinalShareCard(int index, int cardID, Dictionary<string, object> shareCards, bool isReset = false)
	{
	}

	[Token(Token = "0x6002CB4")]
	[Address(RVA = "0x70B460", Offset = "0x70A660", VA = "0x18070B460")]
	private void CallSetFinalMemberStatus(bool isRegistered)
	{
	}

	[Token(Token = "0x6002CB5")]
	[Address(RVA = "0x70B2E0", Offset = "0x70A4E0", VA = "0x18070B2E0")]
	private void CallCompleteFinalDeck()
	{
	}

	[Token(Token = "0x6002CB6")]
	[Address(RVA = "0x70B750", Offset = "0x70A950", VA = "0x18070B750")]
	private void CallUnRegisterFinalDeck()
	{
	}

	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0x70B6A0", Offset = "0x70A8A0", VA = "0x18070B6A0")]
	private void CallSetFinalTeamName(string name)
	{
	}

	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0x716290", Offset = "0x715490", VA = "0x180716290")]
	public WCSEntry()
	{
	}
}
