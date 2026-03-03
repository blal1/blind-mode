using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.YGomTMPro;

namespace YgomGame.ConsoleDataLink;

[Token(Token = "0x2001143")]
public class ConsoleDataLinkViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400B5C6")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string TEXT_TOP_LABEL;

	[Token(Token = "0x400B5C7")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TEXT_DESC1_LABEL;

	[Token(Token = "0x400B5C8")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TEXT_CAUTION_LABEL;

	[Token(Token = "0x400B5C9")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TEXT_CAUTION2_LABEL;

	[Token(Token = "0x400B5CA")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BUTTON_LINK_LABEL;

	[Token(Token = "0x400B5CB")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string TEXT_DESC3_LABEL;

	[Token(Token = "0x400B5CC")]
	[FieldOffset(Offset = "0x100")]
	private readonly string TEXT_DESC4_LABEL;

	[Token(Token = "0x400B5CD")]
	[FieldOffset(Offset = "0x108")]
	private readonly string IMAGE_ICON_LEFT;

	[Token(Token = "0x400B5CE")]
	[FieldOffset(Offset = "0x110")]
	private readonly string IMAGE_ICON_RIGHT;

	[Token(Token = "0x400B5CF")]
	[FieldOffset(Offset = "0x118")]
	private readonly string IMAGE_ICON_ARROW;

	[Token(Token = "0x400B5D0")]
	[FieldOffset(Offset = "0x120")]
	private readonly string IMAGE_TEXT_TOP_BG;

	[Token(Token = "0x400B5D1")]
	[FieldOffset(Offset = "0x128")]
	private Image m_imageIconLeft;

	[Token(Token = "0x400B5D2")]
	[FieldOffset(Offset = "0x130")]
	private Image m_imageIconRight;

	[Token(Token = "0x400B5D3")]
	[FieldOffset(Offset = "0x138")]
	private Image m_imageIconArrow;

	[Token(Token = "0x400B5D4")]
	[FieldOffset(Offset = "0x140")]
	private Image m_imageTextTopBG;

	[Token(Token = "0x400B5D5")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	protected Sprite iconCloud;

	[Token(Token = "0x400B5D6")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	protected Sprite iconUser;

	[Token(Token = "0x400B5D7")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	protected Sprite iconArrow;

	[Token(Token = "0x400B5D8")]
	[FieldOffset(Offset = "0x160")]
	private readonly List<string> m_labelList;

	[Token(Token = "0x400B5D9")]
	[FieldOffset(Offset = "0x168")]
	private List<ExtendedTextMeshProUGUI> m_textList;

	[Token(Token = "0x400B5DA")]
	[FieldOffset(Offset = "0x170")]
	private ExtendedTextMeshProUGUI m_urlText;

	[Token(Token = "0x400B5DB")]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_QRRootGO;

	[Token(Token = "0x400B5DC")]
	[FieldOffset(Offset = "0x180")]
	private GameObject m_ButtonRootGO;

	[Token(Token = "0x400B5DD")]
	[FieldOffset(Offset = "0x188")]
	private readonly string ROOT_QR_LABEL;

	[Token(Token = "0x400B5DE")]
	[FieldOffset(Offset = "0x190")]
	private readonly string RAWIMAGE_QRCODE_LABEL;

	[Token(Token = "0x400B5DF")]
	[FieldOffset(Offset = "0x198")]
	private readonly string TEXT_DESC4_TEXTID;

	[Token(Token = "0x400B5E0")]
	[FieldOffset(Offset = "0x1A0")]
	private string m_url;

	[Token(Token = "0x400B5E1")]
	[FieldOffset(Offset = "0x1A8")]
	private readonly string ROOT_ID_LABEL;

	[Token(Token = "0x400B5E2")]
	[FieldOffset(Offset = "0x1B0")]
	private readonly string BUTTON_KONAMIID_LABEL;

	[Token(Token = "0x400B5E3")]
	[FieldOffset(Offset = "0x1B8")]
	private readonly string BUTTON_GOOGLEPLAY_LABEL;

	[Token(Token = "0x400B5E4")]
	[FieldOffset(Offset = "0x1C0")]
	private readonly string TEXT_LABEL;

	[Token(Token = "0x400B5E5")]
	[FieldOffset(Offset = "0x1C8")]
	protected bool m_isMobile;

	[Token(Token = "0x6006C27")]
	[Address(RVA = "0xB25AD0", Offset = "0xB24CD0", VA = "0x180B25AD0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006C28")]
	[Address(RVA = "0xB26720", Offset = "0xB25920", VA = "0x180B26720")]
	private void SetUpView()
	{
	}

	[Token(Token = "0x6006C29")]
	[Address(RVA = "0xB262B0", Offset = "0xB254B0", VA = "0x180B262B0")]
	protected void SetIconArrow(Sprite arrow)
	{
	}

	[Token(Token = "0x6006C2A")]
	[Address(RVA = "0xB26330", Offset = "0xB25530", VA = "0x180B26330")]
	protected void SetIconLeft(Sprite leftIcon)
	{
	}

	[Token(Token = "0x6006C2B")]
	[Address(RVA = "0xB263B0", Offset = "0xB255B0", VA = "0x180B263B0")]
	protected void SetIconRight(Sprite rightIcon)
	{
	}

	[Token(Token = "0x6006C2C")]
	[Address(RVA = "0xB26430", Offset = "0xB25630", VA = "0x180B26430")]
	protected void SetImage(Sprite sprite, Image image)
	{
	}

	[Token(Token = "0x6006C2D")]
	[Address(RVA = "0xB26070", Offset = "0xB25270", VA = "0x180B26070")]
	protected void PlayColorTween(string label)
	{
	}

	[Token(Token = "0x6006C2E")]
	[Address(RVA = "0xB264E0", Offset = "0xB256E0", VA = "0x180B264E0")]
	private void SetText(int index, string text)
	{
	}

	[Token(Token = "0x6006C2F")]
	[Address(RVA = "0xB265F0", Offset = "0xB257F0", VA = "0x180B265F0")]
	protected void SetTopLabel(string text)
	{
	}

	[Token(Token = "0x6006C30")]
	[Address(RVA = "0xB26240", Offset = "0xB25440", VA = "0x180B26240")]
	protected void SetDesc1(string text)
	{
	}

	[Token(Token = "0x6006C31")]
	[Address(RVA = "0xB261D0", Offset = "0xB253D0", VA = "0x180B261D0")]
	protected void SetCaution(string text)
	{
	}

	[Token(Token = "0x6006C32")]
	[Address(RVA = "0xB26160", Offset = "0xB25360", VA = "0x180B26160")]
	protected void SetCaution2(string text)
	{
	}

	[Token(Token = "0x6006C33")]
	[Address(RVA = "0xB25A40", Offset = "0xB24C40", VA = "0x180B25A40")]
	private void HideText(int index)
	{
	}

	[Token(Token = "0x6006C34")]
	[Address(RVA = "0xB259E0", Offset = "0xB24BE0", VA = "0x180B259E0")]
	protected void HideCaution()
	{
	}

	[Token(Token = "0x6006C35")]
	[Address(RVA = "0xB25980", Offset = "0xB24B80", VA = "0x180B25980")]
	protected void HideCaution2()
	{
	}

	[Token(Token = "0x6006C36")]
	[Address(RVA = "0xB25AC0", Offset = "0xB24CC0", VA = "0x180B25AC0")]
	private void JumpToLink()
	{
	}

	[Token(Token = "0x6006C37")]
	[Address(RVA = "0xB26660", Offset = "0xB25860", VA = "0x180B26660")]
	protected void SetURL(string url)
	{
	}

	[Token(Token = "0x6006C38")]
	[Address(RVA = "0xB26480", Offset = "0xB25680", VA = "0x180B26480")]
	protected void SetKonamiIDButtonCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6006C39")]
	[Address(RVA = "0xB264B0", Offset = "0xB256B0", VA = "0x180B264B0")]
	protected void SetSocialPlatformButtonCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6006C3A")]
	[Address(RVA = "0xB25ED0", Offset = "0xB250D0", VA = "0x180B25ED0")]
	protected void OpenUnavailableDialog(string explanation)
	{
	}

	[Token(Token = "0x6006C3B")]
	[Address(RVA = "0xB25DC0", Offset = "0xB24FC0", VA = "0x180B25DC0")]
	protected void OpenFailureDialog(string explanation)
	{
	}

	[Token(Token = "0x6006C3C")]
	[Address(RVA = "0xB26DE0", Offset = "0xB25FE0", VA = "0x180B26DE0")]
	public ConsoleDataLinkViewController()
	{
	}
}
