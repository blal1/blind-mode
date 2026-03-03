using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x2001052")]
public class BatchDismantleDialog : SelectDialogViewControllerBase<bool>, IBokeSupported
{
	[Token(Token = "0x400ADF5")]
	private const string PREFAB_PATH_BATCHDISMANTLEDIALOG = "DeckEdit/BatchDismantleDialog";

	[Token(Token = "0x400ADF6")]
	private const string LABEL_SBN_CANCELBUTTON = "ButtonFooter0";

	[Token(Token = "0x400ADF7")]
	private const string LABEL_SBN_DISMANTLEBUTTON = "ButtonFooter1";

	[Token(Token = "0x400ADF8")]
	private const string LABEL_EOM_TEMPLATE = "Template";

	[Token(Token = "0x400ADF9")]
	private const string LABEL_TXT_CANCELBUTTONLABEL = "TextButtonFooter0";

	[Token(Token = "0x400ADFA")]
	private const string LABEL_TXT_DISMANTLEBUTTONLABEL = "TextButtonFooter1";

	[Token(Token = "0x400ADFB")]
	private const string LABEL_TXT_POINTSGAINEDHEADER = "TextGetCP";

	[Token(Token = "0x400ADFC")]
	private const string LABEL_TXT_NPOINTSGAINED = "TextGetCPNum0";

	[Token(Token = "0x400ADFD")]
	private const string LABEL_TXT_RPOINTSGAINED = "TextGetCPNum1";

	[Token(Token = "0x400ADFE")]
	private const string LABEL_TXT_SRPOINTSGAINED = "TextGetCPNum2";

	[Token(Token = "0x400ADFF")]
	private const string LABEL_TXT_URPOINTSGAINED = "TextGetCPNum3";

	[Token(Token = "0x400AE00")]
	private const string LABEL_TXT_TOTALPOINTSHEADER = "TextCP";

	[Token(Token = "0x400AE01")]
	private const string LABEL_TXT_NTOTALPOINTS = "TextCPNum0";

	[Token(Token = "0x400AE02")]
	private const string LABEL_TXT_RTOTALPOINTS = "TextCPNum1";

	[Token(Token = "0x400AE03")]
	private const string LABEL_TXT_SRTOTALPOINTS = "TextCPNum2";

	[Token(Token = "0x400AE04")]
	private const string LABEL_TXT_URTOTALPOINTS = "TextCPNum3";

	[Token(Token = "0x400AE05")]
	private const string LABEL_TXT_DESC0 = "TextDescription0";

	[Token(Token = "0x400AE06")]
	private const string LABEL_TXT_DESC1 = "TextDescription1";

	[Token(Token = "0x400AE07")]
	private const string LABEL_TXT_DESC2 = "TextDescription2";

	[Token(Token = "0x400AE08")]
	private const string LABEL_TXT_DIALOGTITLE = "TextTitle";

	[Token(Token = "0x400AE09")]
	private const string LABEL_RT_LISTAREA = "ListArea";

	[Token(Token = "0x400AE0A")]
	private const string LABEL_TXT_TEXTNUM = "TextCardNum";

	[Token(Token = "0x400AE0B")]
	private const string LABEL_TXT_TEXTRARITY = "TextRarity";

	[Token(Token = "0x400AE0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI m_CancelButtonLabel;

	[Token(Token = "0x400AE0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ExtendedTextMeshProUGUI m_DismanlteButtonLabel;

	[Token(Token = "0x400AE0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ExtendedTextMeshProUGUI m_PointsGainedHeader;

	[Token(Token = "0x400AE0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ExtendedTextMeshProUGUI m_NPointsGained;

	[Token(Token = "0x400AE10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ExtendedTextMeshProUGUI m_RPointsGained;

	[Token(Token = "0x400AE11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ExtendedTextMeshProUGUI m_SRPointsGained;

	[Token(Token = "0x400AE12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ExtendedTextMeshProUGUI m_URPointsGained;

	[Token(Token = "0x400AE13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ExtendedTextMeshProUGUI m_TotalPointsHeader;

	[Token(Token = "0x400AE14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ExtendedTextMeshProUGUI m_NTotalPoints;

	[Token(Token = "0x400AE15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ExtendedTextMeshProUGUI m_RTotalPoints;

	[Token(Token = "0x400AE16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ExtendedTextMeshProUGUI m_SRTotalPoints;

	[Token(Token = "0x400AE17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private ExtendedTextMeshProUGUI m_URTotalPoints;

	[Token(Token = "0x400AE18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ExtendedTextMeshProUGUI m_Desc0;

	[Token(Token = "0x400AE19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ExtendedTextMeshProUGUI m_Desc1;

	[Token(Token = "0x400AE1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private ExtendedTextMeshProUGUI m_Desc2;

	[Token(Token = "0x400AE1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private ExtendedTextMeshProUGUI m_DialogTitle;

	[Token(Token = "0x400AE1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private SelectionButton m_DismantleButton;

	[Token(Token = "0x400AE1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x400AE1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private RectTransform m_ListArea;

	[Token(Token = "0x400AE1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Dictionary<int, CraftCompensation> m_CraftCompensations;

	[Token(Token = "0x400AE20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Dictionary<string, object> m_Compensations;

	[Token(Token = "0x400AE21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Dictionary<int, int> m_CompensationsRarities;

	[Token(Token = "0x400AE22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Dictionary<string, object> m_CompensationDic;

	[Token(Token = "0x400AE23")]
	public const string k_ArgKeyDialogTitle = "title";

	[Token(Token = "0x400AE24")]
	public const string k_ArgKeyDismantleCards = "dismantleCards";

	[Token(Token = "0x400AE25")]
	public const string k_ArgKeyOnCompleteCallback = "onCompleteCallback";

	[Token(Token = "0x400AE26")]
	public const string k_ArgKeyCreateCards = "createCards";

	[Token(Token = "0x400AE27")]
	public const string k_ArgKeyCreateCardsMessage = "createCardsMessage";

	[Token(Token = "0x400AE28")]
	public const string k_ArgKeyCompensationMasterDic = "compensationMasterDic";

	[Token(Token = "0x400AE29")]
	private const string CP_TEXT_MAX = "99999+";

	[Token(Token = "0x400AE2A")]
	private const string CP_TEXT_MIN = "0";

	[Token(Token = "0x400AE2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private string m_Title;

	[Token(Token = "0x400AE2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<CardBaseData> m_DismantleCards;

	[Token(Token = "0x400AE2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Action<bool> OnCompleteCallback;

	[Token(Token = "0x400AE2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Dictionary<int, int> m_CreateCards;

	[Token(Token = "0x400AE2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private string m_CreatedCardsMessage;

	[Token(Token = "0x400AE30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Dictionary<string, object> formatedCards;

	[Token(Token = "0x400AE31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private bool isSelectMode;

	[Token(Token = "0x400AE32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
	private bool isCreateMode;

	[Token(Token = "0x400AE33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
	private bool isCompensationCard;

	[Token(Token = "0x400AE34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Dictionary<CardCollectionInfo.Rarity, bool> SufficientCheck;

	[Token(Token = "0x60062DB")]
	[Address(RVA = "0xA87B60", Offset = "0xA86D60", VA = "0x180A87B60")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x60062DC")]
	[Address(RVA = "0xA8A290", Offset = "0xA89490", VA = "0x180A8A290")]
	public static void Open([Optional] Action<bool> callback)
	{
	}

	[Token(Token = "0x60062DD")]
	[Address(RVA = "0xA8A170", Offset = "0xA89370", VA = "0x180A8A170")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60062DE")]
	[Address(RVA = "0xA88A40", Offset = "0xA87C40", VA = "0x180A88A40", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60062DF")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void InitCompensation()
	{
	}

	[Token(Token = "0x60062E0")]
	[Address(RVA = "0xA88FB0", Offset = "0xA881B0", VA = "0x180A88FB0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60062E1")]
	[Address(RVA = "0xA88100", Offset = "0xA87300", VA = "0x180A88100")]
	private void InitilizeCreateMode()
	{
	}

	[Token(Token = "0x60062E2")]
	[Address(RVA = "0xA87890", Offset = "0xA86A90", VA = "0x180A87890")]
	private void Dismantle()
	{
	}

	[Token(Token = "0x60062E3")]
	[Address(RVA = "0xA86EE0", Offset = "0xA860E0", VA = "0x180A86EE0")]
	private void Create()
	{
	}

	[Token(Token = "0x60062E4")]
	[Address(RVA = "0xA87930", Offset = "0xA86B30", VA = "0x180A87930")]
	private List<CardBaseData> FormatCreateCards(Dictionary<int, int> lackCards)
	{
		return null;
	}

	[Token(Token = "0x60062E5")]
	[Address(RVA = "0xA86350", Offset = "0xA85550", VA = "0x180A86350")]
	private bool CompensationCheck(Dictionary<string, object> data)
	{
		return default(bool);
	}

	[Token(Token = "0x60062E6")]
	[Address(RVA = "0xA8AA80", Offset = "0xA89C80", VA = "0x180A8AA80")]
	public BatchDismantleDialog()
	{
	}
}
