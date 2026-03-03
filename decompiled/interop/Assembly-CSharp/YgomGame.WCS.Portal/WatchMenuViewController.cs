using Il2CppDummyDll;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x2000779")]
public class WatchMenuViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200077A")]
	private class LinkEntry
	{
		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x10")]
		public int textID;

		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x14")]
		public int prio;

		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x18")]
		public string url;

		[Token(Token = "0x600310C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public LinkEntry()
		{
		}
	}

	[Token(Token = "0x4002576")]
	private const string LABEL_SCROLLVIEW = "ScrollView";

	[Token(Token = "0x4002577")]
	private const string LABEL_SV_ITEMTEMPLATE = "template";

	[Token(Token = "0x4002578")]
	private const string LABEL_SV_CONTENT = "content";

	[Token(Token = "0x4002579")]
	private const string LABEL_ITEM_TITLE_TEXT = "TextTitle";

	[Token(Token = "0x400257A")]
	private const string LABEL_ITEM_QR_ROOT = "QRGroup";

	[Token(Token = "0x400257B")]
	private const string LABEL_ITEM_QR_IMAGE = "ImageQRCode";

	[Token(Token = "0x400257C")]
	private const string LABEL_ITEM_QR_URLTEXT = "TextURL";

	[Token(Token = "0x400257D")]
	private const string LABEL_ITEM_QR_CLICKBTN = "ButtonClick";

	[Token(Token = "0x400257E")]
	private const string LABEL_ITEM_JUMP_BTN = "ButtonJump";

	[Token(Token = "0x400257F")]
	private const string LABEL_ITEM_NOTICE_TEXT = "TextNotice";

	[Token(Token = "0x4002580")]
	[FieldOffset(Offset = "0xD0")]
	private ScrollRect m_scrollRect;

	[Token(Token = "0x4002581")]
	[FieldOffset(Offset = "0xD8")]
	private FreeScrollView m_freeScrollView;

	[Token(Token = "0x4002582")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_viewInit;

	[Token(Token = "0x4002583")]
	[FieldOffset(Offset = "0xE1")]
	private bool m_isPC;

	[Token(Token = "0x4002584")]
	[FieldOffset(Offset = "0xE2")]
	private bool m_isMobile;

	[Token(Token = "0x1700060D")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60030FF")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003100")]
	[Address(RVA = "0x764520", Offset = "0x763720", VA = "0x180764520", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003101")]
	[Address(RVA = "0x7645A0", Offset = "0x7637A0", VA = "0x1807645A0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003102")]
	[Address(RVA = "0x765240", Offset = "0x764440", VA = "0x180765240")]
	private void Start()
	{
	}

	[Token(Token = "0x6003103")]
	[Address(RVA = "0x765C90", Offset = "0x764E90", VA = "0x180765C90")]
	private void setupItemsScroll()
	{
	}

	[Token(Token = "0x6003104")]
	[Address(RVA = "0x7655D0", Offset = "0x7647D0", VA = "0x1807655D0")]
	private void setupItemAsDuelLiveLink(ElementObjectManager rootEOM, string titleText, string buttonText)
	{
	}

	[Token(Token = "0x6003105")]
	[Address(RVA = "0x765750", Offset = "0x764950", VA = "0x180765750")]
	private void setupItemAsExternalLink(ElementObjectManager rootEOM, string url, string titleText, string buttonText)
	{
	}

	[Token(Token = "0x6003106")]
	[Address(RVA = "0x765AC0", Offset = "0x764CC0", VA = "0x180765AC0")]
	private void setupItemAsInternalLink(ElementObjectManager rootEOM, string url, string titleText, string buttonText)
	{
	}

	[Token(Token = "0x6003107")]
	[Address(RVA = "0x7653E0", Offset = "0x7645E0", VA = "0x1807653E0")]
	private void setItemHeaderText(ElementObjectManager rootEOM, string titleText)
	{
	}

	[Token(Token = "0x6003108")]
	[Address(RVA = "0x7654A0", Offset = "0x7646A0", VA = "0x1807654A0")]
	private void setItemJumpButtonText(ElementObjectManager rootEOM, string buttonText)
	{
	}

	[Token(Token = "0x6003109")]
	[Address(RVA = "0x765260", Offset = "0x764460", VA = "0x180765260")]
	private void jumpToDuelLive()
	{
	}

	[Token(Token = "0x600310A")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public WatchMenuViewController()
	{
	}
}
