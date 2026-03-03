using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.SubMenu;

[Token(Token = "0x2001045")]
public abstract class SubMenuViewController : BaseBlurOverlayViewController
{
	[Token(Token = "0x2001046")]
	public enum Badge
	{
		[Token(Token = "0x400ADC5")]
		DEFAULT,
		[Token(Token = "0x400ADC6")]
		WCS_CONFIRM,
		[Token(Token = "0x400ADC7")]
		WCS_DECK_REGIST
	}

	[Token(Token = "0x400ADAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BTN_MASK_LABEL;

	[Token(Token = "0x400ADB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string TITLE_TEXT_LABEL;

	[Token(Token = "0x400ADB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string TITLE_TEMPLATE_LABEL;

	[Token(Token = "0x400ADB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string ITEM_TEMPLATE_LABEL;

	[Token(Token = "0x400ADB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string ITEM_TEXT_LABEL;

	[Token(Token = "0x400ADB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string MENU_LIST_LABEL;

	[Token(Token = "0x400ADB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string IMG_NUMBADGE_LABEL;

	[Token(Token = "0x400ADB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string IMG_NEWBADGE_LABEL;

	[Token(Token = "0x400ADB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string TXT_BADGE_LABEL;

	[Token(Token = "0x400ADB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Dictionary<Badge, int> badgeNumDic;

	[Token(Token = "0x400ADB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Dictionary<string, Badge> badgeTextDic;

	[Token(Token = "0x400ADBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Dictionary<int, string> menuMap;

	[Token(Token = "0x400ADBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private InfinityScrollView m_InfinityScrollView;

	[Token(Token = "0x400ADBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<int> m_Templates;

	[Token(Token = "0x400ADBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private List<string> m_Texts;

	[Token(Token = "0x400ADBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly int k_TitleTNo;

	[Token(Token = "0x400ADBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private readonly int k_ItemTNo;

	[Token(Token = "0x400ADC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly int k_SpacerNo;

	[Token(Token = "0x400ADC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<string> m_SoundLabelsClick;

	[Token(Token = "0x400ADC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<UnityAction> m_ClickCallBacks;

	[Token(Token = "0x400ADC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private float delayFactor;

	[Token(Token = "0x6006296")]
	[Address(RVA = "0xA98200", Offset = "0xA97400", VA = "0x180A98200", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006297")]
	[Address(RVA = "0xA98280", Offset = "0xA97480", VA = "0x180A98280", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6006298")]
	[Address(RVA = "0xA98330", Offset = "0xA97530", VA = "0x180A98330", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006299")]
	[Address(RVA = "0xA99AE0", Offset = "0xA98CE0", VA = "0x180A99AE0")]
	protected void SetBadgeData()
	{
	}

	[Token(Token = "0x600629A")]
	[Address(RVA = "0xA9A270", Offset = "0xA99470", VA = "0x180A9A270")]
	protected void SetTitleText(string str)
	{
	}

	[Token(Token = "0x600629B")]
	[Address(RVA = "0xA97E00", Offset = "0xA97000", VA = "0x180A97E00")]
	protected void AddTitleItem(string text)
	{
	}

	[Token(Token = "0x600629C")]
	[Address(RVA = "0xA97B80", Offset = "0xA96D80", VA = "0x180A97B80")]
	protected void AddMenuItem(string text, UnityAction clickCallback, [Optional] string onclickSL, Badge badgeType = Badge.DEFAULT)
	{
	}

	[Token(Token = "0x600629D")]
	[Address(RVA = "0xA98610", Offset = "0xA97810", VA = "0x180A98610")]
	private void OnMenuItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600629E")]
	[Address(RVA = "0xA9A050", Offset = "0xA99250", VA = "0x180A9A050")]
	public void SetBadge(GameObject gom, int count = 0)
	{
	}

	[Token(Token = "0x600629F")]
	[Address(RVA = "0xA981A0", Offset = "0xA973A0", VA = "0x180A981A0")]
	private bool IsSelectableDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60062A0")]
	[Address(RVA = "0xA98CF0", Offset = "0xA97EF0", VA = "0x180A98CF0")]
	public static void OpenLicense()
	{
	}

	[Token(Token = "0x60062A1")]
	[Address(RVA = "0xA978B0", Offset = "0xA96AB0", VA = "0x180A978B0")]
	public void AddHelpButton()
	{
	}

	[Token(Token = "0x60062A2")]
	[Address(RVA = "0xA97A40", Offset = "0xA96C40", VA = "0x180A97A40")]
	public void AddInquiryButton()
	{
	}

	[Token(Token = "0x60062A3")]
	[Address(RVA = "0xA98CE0", Offset = "0xA97EE0", VA = "0x180A98CE0")]
	private void OpenInquirySheet()
	{
	}

	[Token(Token = "0x60062A4")]
	[Address(RVA = "0xA98E30", Offset = "0xA98030", VA = "0x180A98E30")]
	public static void OpenUserRegulationSheet(string title, bool fromHome = false)
	{
	}

	[Token(Token = "0x60062A5")]
	[Address(RVA = "0xA9A3B0", Offset = "0xA995B0", VA = "0x180A9A3B0")]
	protected SubMenuViewController()
	{
	}
}
