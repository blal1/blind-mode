using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.GetHistory;

[Token(Token = "0x2000D9D")]
public class GetHistoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x4009F7A")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string BTN_BTNL_LABEL;

	[Token(Token = "0x4009F7B")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_BTNR_LABEL;

	[Token(Token = "0x4009F7C")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TEXT_TITLE_LABEL;

	[Token(Token = "0x4009F7D")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string CONTENT_LABEL;

	[Token(Token = "0x4009F7E")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string TEXT_PAGEINDEX_LABEL;

	[Token(Token = "0x4009F7F")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string TEXT_CAUTION_LABEL;

	[Token(Token = "0x4009F80")]
	[FieldOffset(Offset = "0x100")]
	private readonly string TEMPLATE_LABEL;

	[Token(Token = "0x4009F81")]
	[FieldOffset(Offset = "0x108")]
	private readonly string TEMPLATE_CONS_LABEL;

	[Token(Token = "0x4009F82")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TEMPLATE_ADD_LABEL;

	[Token(Token = "0x4009F83")]
	[FieldOffset(Offset = "0x118")]
	private readonly string TEMPLATE_EXPIRE_LABEL;

	[Token(Token = "0x4009F84")]
	[FieldOffset(Offset = "0x120")]
	private readonly string TEMPLATE_COLLECT_LABEL;

	[Token(Token = "0x4009F85")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TEXTS_LIMITEDPAID_LABEL;

	[Token(Token = "0x4009F86")]
	[FieldOffset(Offset = "0x130")]
	private readonly string TEXTS_LIMITEDFREE_LABEL;

	[Token(Token = "0x4009F87")]
	[FieldOffset(Offset = "0x138")]
	private readonly string TEXTS_HAVEFREE_LABEL;

	[Token(Token = "0x4009F88")]
	[FieldOffset(Offset = "0x140")]
	private readonly string TEXTS_HAVEPAID_LABEL;

	[Token(Token = "0x4009F89")]
	[FieldOffset(Offset = "0x148")]
	private readonly string TEXT_EMPTYHISTORY_LABEL;

	[Token(Token = "0x4009F8A")]
	[FieldOffset(Offset = "0x150")]
	protected ElementObjectManager m_templateEOM;

	[Token(Token = "0x4009F8B")]
	[FieldOffset(Offset = "0x158")]
	protected ElementObjectManager m_templateConsEOM;

	[Token(Token = "0x4009F8C")]
	[FieldOffset(Offset = "0x160")]
	protected ElementObjectManager m_templateAddEOM;

	[Token(Token = "0x4009F8D")]
	[FieldOffset(Offset = "0x168")]
	protected ElementObjectManager m_templateExpireEOM;

	[Token(Token = "0x4009F8E")]
	[FieldOffset(Offset = "0x170")]
	protected ElementObjectManager m_templateCollectEOM;

	[Token(Token = "0x4009F8F")]
	[FieldOffset(Offset = "0x178")]
	protected ElementObjectManager m_textsHaveFreeEOM;

	[Token(Token = "0x4009F90")]
	[FieldOffset(Offset = "0x180")]
	protected ElementObjectManager m_textsHavePaidEOM;

	[Token(Token = "0x4009F91")]
	[FieldOffset(Offset = "0x188")]
	protected ElementObjectManager m_textsLimitedFreeEOM;

	[Token(Token = "0x4009F92")]
	[FieldOffset(Offset = "0x190")]
	protected ElementObjectManager m_textsLimitedPaidEOM;

	[Token(Token = "0x4009F93")]
	[FieldOffset(Offset = "0x198")]
	private ExtendedTextMeshProUGUI m_titleText;

	[Token(Token = "0x4009F94")]
	[FieldOffset(Offset = "0x1A0")]
	private ExtendedTextMeshProUGUI m_cautionText;

	[Token(Token = "0x4009F95")]
	[FieldOffset(Offset = "0x1A8")]
	private ExtendedTextMeshProUGUI m_emptyText;

	[Token(Token = "0x4009F96")]
	[FieldOffset(Offset = "0x1B0")]
	private ExtendedTextMeshProUGUI m_pageText;

	[Token(Token = "0x4009F97")]
	[FieldOffset(Offset = "0x1B8")]
	protected SelectionButton m_buttonL;

	[Token(Token = "0x4009F98")]
	[FieldOffset(Offset = "0x1C0")]
	protected SelectionButton m_buttonR;

	[Token(Token = "0x4009F99")]
	[FieldOffset(Offset = "0x1C8")]
	protected int m_maxTemplatesInContent;

	[Token(Token = "0x4009F9A")]
	[FieldOffset(Offset = "0x1D0")]
	protected GameObject m_contentGO;

	[Token(Token = "0x4009F9B")]
	[FieldOffset(Offset = "0x1D8")]
	protected bool m_isMobile;

	[Token(Token = "0x4009F9C")]
	[FieldOffset(Offset = "0x1DC")]
	protected int m_pageIndex;

	[Token(Token = "0x4009F9D")]
	[FieldOffset(Offset = "0x1E0")]
	protected int m_maxPageIndex;

	[Token(Token = "0x60051C7")]
	[Address(RVA = "0x98EF90", Offset = "0x98E190", VA = "0x18098EF90", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60051C8")]
	[Address(RVA = "0x98F5F0", Offset = "0x98E7F0", VA = "0x18098F5F0")]
	protected void SetTitleText(string title)
	{
	}

	[Token(Token = "0x60051C9")]
	[Address(RVA = "0x98F490", Offset = "0x98E690", VA = "0x18098F490")]
	protected void SetEmptyText(string emptyText)
	{
	}

	[Token(Token = "0x60051CA")]
	[Address(RVA = "0x98F420", Offset = "0x98E620", VA = "0x18098F420")]
	protected void SetCautionText(string cautionText)
	{
	}

	[Token(Token = "0x60051CB")]
	[Address(RVA = "0x98F3F0", Offset = "0x98E5F0", VA = "0x18098F3F0")]
	protected void SetButtonRCallBack(UnityAction ButtonRCallBack)
	{
	}

	[Token(Token = "0x60051CC")]
	[Address(RVA = "0x98F3C0", Offset = "0x98E5C0", VA = "0x18098F3C0")]
	protected void SetButtonLCallBack(UnityAction ButtonLCallBack)
	{
	}

	[Token(Token = "0x60051CD")]
	[Address(RVA = "0x98F6C0", Offset = "0x98E8C0", VA = "0x18098F6C0")]
	protected void UpdateFooter()
	{
	}

	[Token(Token = "0x60051CE")]
	[Address(RVA = "0x98F620", Offset = "0x98E820", VA = "0x18098F620")]
	private void UpdateButtonStatus()
	{
	}

	[Token(Token = "0x60051CF")]
	[Address(RVA = "0x98F500", Offset = "0x98E700", VA = "0x18098F500")]
	protected void SetPageIndexText()
	{
	}

	[Token(Token = "0x60051D0")]
	[Address(RVA = "0x98ECE0", Offset = "0x98DEE0", VA = "0x18098ECE0")]
	private void CleanView()
	{
	}

	[Token(Token = "0x60051D1")]
	[Address(RVA = "0x98F850", Offset = "0x98EA50", VA = "0x18098F850")]
	public GetHistoryViewController()
	{
	}
}
