using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.CardFile;

[Token(Token = "0x20015B8")]
public class CardFileViewController : BaseMenuViewController, IDynamicHeaderCustomSupported, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x400CE86")]
	public const string k_PREF_PATH = "CardFile/CardFile";

	[Token(Token = "0x400CE87")]
	public const string k_SEND_LABEL = "CardFileToShopBuy";

	[Token(Token = "0x400CE88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelNumArea;

	[Token(Token = "0x400CE89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelNum;

	[Token(Token = "0x400CE8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelNumComplete;

	[Token(Token = "0x400CE8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelButtonGroup;

	[Token(Token = "0x400CE8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelTextName;

	[Token(Token = "0x400CE8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelTextNum;

	[Token(Token = "0x400CE8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelTextNotice;

	[Token(Token = "0x400CE8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelPrevButton;

	[Token(Token = "0x400CE90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelNextButton;

	[Token(Token = "0x400CE91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelFlickButton;

	[Token(Token = "0x400CE92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string k_ELabelIndicatorTemplate;

	[Token(Token = "0x400CE93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_TweenLabelShow;

	[Token(Token = "0x400CE94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_TweenLabelHide;

	[Token(Token = "0x400CE95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string k_TweenLabelIndicatorOn;

	[Token(Token = "0x400CE96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string k_TweenLabelIndicatorOff;

	[Token(Token = "0x400CE97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private bool m_PushShopBuyVC;

	[Token(Token = "0x400CE98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private long m_Pcode;

	[Token(Token = "0x400CE99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private int m_ItemId;

	[Token(Token = "0x400CE9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private int m_IsNewCardNum;

	[Token(Token = "0x400CE9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int m_BeforeHaveNum;

	[Token(Token = "0x400CE9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private int m_AfterHaveNum;

	[Token(Token = "0x400CE9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private int m_MaxNum;

	[Token(Token = "0x400CE9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private int m_CurrentIndicatorNum;

	[Token(Token = "0x400CE9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int m_MaxIndicatorNum;

	[Token(Token = "0x400CEA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private int m_IsPlayCompEffect;

	[Token(Token = "0x400CEA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private int m_IsExchange;

	[Token(Token = "0x400CEA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private int m_IsUpdateMaster;

	[Token(Token = "0x400CEA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<GameObject> m_Indicators;

	[Token(Token = "0x400CEA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GameObject m_NumArea;

	[Token(Token = "0x400CEA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x400CEA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x400CEA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private SelectionButton m_FlickButton;

	[Token(Token = "0x400CEA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private CardFileDefinition.OpenType m_OpenType;

	[Token(Token = "0x400CEAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private readonly string k_ELabelSecretPackButton;

	[Token(Token = "0x400CEAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private readonly string k_ELabelNumBadge;

	[Token(Token = "0x400CEAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private GameObject m_BadgeSecretPack;

	[Token(Token = "0x400CEAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private SelectionButton m_SecretPackButton;

	[Token(Token = "0x400CEB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private SecretPackEffect secretPackEffect;

	[Token(Token = "0x400CEB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Dictionary<int, CardCollectionInfo.SecretPackInfo> m_SecretPacks;

	[Token(Token = "0x400CEB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private readonly string k_ELabelSortButton;

	[Token(Token = "0x400CEB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private readonly string k_ELabelSortIconAsc;

	[Token(Token = "0x400CEB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private readonly string k_ELabelSortIconDesc;

	[Token(Token = "0x400CEB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private readonly string k_ELabelSortText;

	[Token(Token = "0x400CEB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private bool m_RefreshSortFlag;

	[Token(Token = "0x400CEB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private GameObject m_SortIconAsc;

	[Token(Token = "0x400CEB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private GameObject m_SortIconDesc;

	[Token(Token = "0x400CEB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private ExtendedTextMeshProUGUI m_SortText;

	[Token(Token = "0x400CEBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private SelectionButton m_SortButton;

	[Token(Token = "0x400CEBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private SortComparer.Sorter m_SortType;

	[Token(Token = "0x400CEBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private Dictionary<string, object> m_SortedDict;

	[Token(Token = "0x400CEBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private Dictionary<string, object> m_OldSortedDict;

	[Token(Token = "0x170014AB")]
	private bool isMobile
	{
		[Token(Token = "0x6008693")]
		[Address(RVA = "0xCF99D0", Offset = "0xCF8BD0", VA = "0x180CF99D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014AC")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6008694")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014AD")]
	public int currentPage
	{
		[Token(Token = "0x6008695")]
		[Address(RVA = "0x49B830", Offset = "0x49AA30", VA = "0x18049B830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008696")]
		[Address(RVA = "0x49C0B0", Offset = "0x49B2B0", VA = "0x18049C0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170014AE")]
	public int currentIndicator
	{
		[Token(Token = "0x6008697")]
		[Address(RVA = "0x49B810", Offset = "0x49AA10", VA = "0x18049B810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008698")]
		[Address(RVA = "0x49C090", Offset = "0x49B290", VA = "0x18049C090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170014AF")]
	public CardFileManager cfManager
	{
		[Token(Token = "0x6008699")]
		[Address(RVA = "0x49BEC0", Offset = "0x49B0C0", VA = "0x18049BEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600869A")]
		[Address(RVA = "0x49C5B0", Offset = "0x49B7B0", VA = "0x18049C5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170014B0")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600869B")]
		[Address(RVA = "0xCF9A20", Offset = "0xCF8C20", VA = "0x180CF9A20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600869C")]
	[Address(RVA = "0xCF5EE0", Offset = "0xCF50E0", VA = "0x180CF5EE0")]
	public static void Open(long pcode, int itemId, CardFileDefinition.OpenType openType)
	{
	}

	[Token(Token = "0x600869D")]
	[Address(RVA = "0xCF5D60", Offset = "0xCF4F60", VA = "0x180CF5D60")]
	public static void OpenFromShop(int itemId)
	{
	}

	[Token(Token = "0x600869E")]
	[Address(RVA = "0xCF53F0", Offset = "0xCF45F0", VA = "0x180CF53F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600869F")]
	[Address(RVA = "0xCF54F0", Offset = "0xCF46F0", VA = "0x180CF54F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60086A0")]
	[Address(RVA = "0xCF56F0", Offset = "0xCF48F0", VA = "0x180CF56F0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60086A1")]
	[Address(RVA = "0xCF5C50", Offset = "0xCF4E50", VA = "0x180CF5C50", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60086A2")]
	[Address(RVA = "0xCF5C10", Offset = "0xCF4E10", VA = "0x180CF5C10", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x60086A3")]
	[Address(RVA = "0xCF74E0", Offset = "0xCF66E0", VA = "0x180CF74E0", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60086A4")]
	[Address(RVA = "0xCF75D0", Offset = "0xCF67D0", VA = "0x180CF75D0", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60086A5")]
	[Address(RVA = "0xCF5B30", Offset = "0xCF4D30", VA = "0x180CF5B30", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60086A6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x60086A7")]
	[Address(RVA = "0xCF5820", Offset = "0xCF4A20", VA = "0x180CF5820", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60086A8")]
	[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x60086A9")]
	[Address(RVA = "0xCF3770", Offset = "0xCF2970", VA = "0x180CF3770")]
	private void CallApi(bool isCraftRefresh = true, [Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x60086AA")]
	[Address(RVA = "0xCF3880", Offset = "0xCF2A80", VA = "0x180CF3880")]
	private void CallSortApi([Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x60086AB")]
	[Address(RVA = "0xCF44B0", Offset = "0xCF36B0", VA = "0x180CF44B0")]
	private void InitializedElement()
	{
	}

	[Token(Token = "0x60086AC")]
	[Address(RVA = "0xCF47A0", Offset = "0xCF39A0", VA = "0x180CF47A0")]
	private void InitislizeSetting()
	{
	}

	[Token(Token = "0x60086AD")]
	[Address(RVA = "0xCF8A40", Offset = "0xCF7C40", VA = "0x180CF8A40")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x60086AE")]
	[Address(RVA = "0xCF6DD0", Offset = "0xCF5FD0", VA = "0x180CF6DD0")]
	private void ShowCollectDialog(Action onFinished)
	{
	}

	[Token(Token = "0x60086AF")]
	[Address(RVA = "0xCF6F20", Offset = "0xCF6120", VA = "0x180CF6F20")]
	private void ShowGuideDialog(Action onFinished)
	{
	}

	[Token(Token = "0x60086B0")]
	[Address(RVA = "0xCF7340", Offset = "0xCF6540", VA = "0x180CF7340")]
	private void ShowUI()
	{
	}

	[Token(Token = "0x60086B1")]
	[Address(RVA = "0xCF3FB0", Offset = "0xCF31B0", VA = "0x180CF3FB0")]
	private void HideUI()
	{
	}

	[Token(Token = "0x60086B2")]
	[Address(RVA = "0xCF6070", Offset = "0xCF5270", VA = "0x180CF6070")]
	private void PlayCompleteAnim(Action onFinished)
	{
	}

	[Token(Token = "0x60086B3")]
	[Address(RVA = "0xCF52A0", Offset = "0xCF44A0", VA = "0x180CF52A0")]
	private bool NeedSave()
	{
		return default(bool);
	}

	[Token(Token = "0x60086B4")]
	[Address(RVA = "0xCF3B40", Offset = "0xCF2D40", VA = "0x180CF3B40")]
	private void CreateCardFile()
	{
	}

	[Token(Token = "0x60086B5")]
	[Address(RVA = "0xCF93D0", Offset = "0xCF85D0", VA = "0x180CF93D0")]
	private void ViewCardFile()
	{
	}

	[Token(Token = "0x60086B6")]
	[Address(RVA = "0xCF67F0", Offset = "0xCF59F0", VA = "0x180CF67F0")]
	private void SetButtonSetting()
	{
	}

	[Token(Token = "0x60086B7")]
	[Address(RVA = "0xCF6AB0", Offset = "0xCF5CB0", VA = "0x180CF6AB0")]
	private void SetIndicator()
	{
	}

	[Token(Token = "0x60086B8")]
	[Address(RVA = "0xCF6150", Offset = "0xCF5350", VA = "0x180CF6150")]
	private void PlayIndicatorTween(bool immediate = false)
	{
	}

	[Token(Token = "0x60086B9")]
	[Address(RVA = "0xCF42B0", Offset = "0xCF34B0", VA = "0x180CF42B0")]
	private void InitializeElementSecretPack()
	{
	}

	[Token(Token = "0x60086BA")]
	[Address(RVA = "0xCF4DE0", Offset = "0xCF3FE0", VA = "0x180CF4DE0")]
	private void IsShowSecretPack()
	{
	}

	[Token(Token = "0x60086BB")]
	[Address(RVA = "0xCF7220", Offset = "0xCF6420", VA = "0x180CF7220")]
	private void ShowSecretPackActivateEffect()
	{
	}

	[Token(Token = "0x60086BC")]
	[Address(RVA = "0xCF3E20", Offset = "0xCF3020", VA = "0x180CF3E20")]
	private void DispSecretPackButton(bool disp)
	{
	}

	[Token(Token = "0x60086BD")]
	[Address(RVA = "0xCF3F20", Offset = "0xCF3120", VA = "0x180CF3F20")]
	private bool GetSecretPackButtonAcitve()
	{
		return default(bool);
	}

	[Token(Token = "0x60086BE")]
	[Address(RVA = "0xCF5910", Offset = "0xCF4B10", VA = "0x180CF5910")]
	private void OnClickSecretPack()
	{
	}

	[Token(Token = "0x60086BF")]
	[Address(RVA = "0xCF6C60", Offset = "0xCF5E60", VA = "0x180CF6C60")]
	private void SetShopTransitionCallback()
	{
	}

	[Token(Token = "0x60086C0")]
	[Address(RVA = "0xCF6A10", Offset = "0xCF5C10", VA = "0x180CF6A10")]
	private void SetCraftResultCallback()
	{
	}

	[Token(Token = "0x60086C1")]
	[Address(RVA = "0xCF4380", Offset = "0xCF3580", VA = "0x180CF4380")]
	private void InitializeElementSortButton()
	{
	}

	[Token(Token = "0x60086C2")]
	[Address(RVA = "0xCF3EA0", Offset = "0xCF30A0", VA = "0x180CF3EA0")]
	private void DispSortButton(bool disp)
	{
	}

	[Token(Token = "0x60086C3")]
	[Address(RVA = "0xCF6D00", Offset = "0xCF5F00", VA = "0x180CF6D00")]
	private void SetSortIcon(SortComparer.Sorter sort)
	{
	}

	[Token(Token = "0x60086C4")]
	[Address(RVA = "0xCF5A40", Offset = "0xCF4C40", VA = "0x180CF5A40")]
	private void OnClickSortButton()
	{
	}

	[Token(Token = "0x60086C5")]
	[Address(RVA = "0xCF6330", Offset = "0xCF5530", VA = "0x180CF6330")]
	private void RefreshSortCallback([Optional] Action onFinished)
	{
	}

	[Token(Token = "0x60086C6")]
	[Address(RVA = "0xCF4A90", Offset = "0xCF3C90", VA = "0x180CF4A90")]
	private bool IsDifferentSortDict(Dictionary<string, object> dict1, Dictionary<string, object> dict2)
	{
		return default(bool);
	}

	[Token(Token = "0x60086C7")]
	[Address(RVA = "0xCF9490", Offset = "0xCF8690", VA = "0x180CF9490")]
	public CardFileViewController()
	{
	}
}
