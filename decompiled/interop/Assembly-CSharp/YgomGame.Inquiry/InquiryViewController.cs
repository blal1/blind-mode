using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Inquiry;

[Token(Token = "0x2000D3B")]
public class InquiryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x4009E31")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string TEXT_TOP_LABEL;

	[Token(Token = "0x4009E32")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TEXT_DESC1_LABEL;

	[Token(Token = "0x4009E33")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TEXT_DESC2_LABEL;

	[Token(Token = "0x4009E34")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TEXT_BUTTON_LABEL;

	[Token(Token = "0x4009E35")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BUTTON_LABEL;

	[Token(Token = "0x4009E36")]
	[FieldOffset(Offset = "0xF8")]
	private ExtendedTextMeshProUGUI m_topText;

	[Token(Token = "0x4009E37")]
	[FieldOffset(Offset = "0x100")]
	private ExtendedTextMeshProUGUI m_desc1Text;

	[Token(Token = "0x4009E38")]
	[FieldOffset(Offset = "0x108")]
	private ExtendedTextMeshProUGUI m_desc2Text;

	[Token(Token = "0x4009E39")]
	[FieldOffset(Offset = "0x110")]
	private ExtendedTextMeshProUGUI m_urlText;

	[Token(Token = "0x4009E3A")]
	[FieldOffset(Offset = "0x118")]
	private ExtendedTextMeshProUGUI m_buttonText;

	[Token(Token = "0x4009E3B")]
	[FieldOffset(Offset = "0x120")]
	private SelectionButton m_inquiryButton;

	[Token(Token = "0x4009E3C")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TEXT_URL_LABEL;

	[Token(Token = "0x4009E3D")]
	[FieldOffset(Offset = "0x130")]
	private string m_url;

	[Token(Token = "0x6005017")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005018")]
	[Address(RVA = "0x96F5B0", Offset = "0x96E7B0", VA = "0x18096F5B0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005019")]
	[Address(RVA = "0x96F8E0", Offset = "0x96EAE0", VA = "0x18096F8E0")]
	public static void Open()
	{
	}

	[Token(Token = "0x600501A")]
	[Address(RVA = "0x72AB60", Offset = "0x729D60", VA = "0x18072AB60")]
	private void JumpToLink()
	{
	}

	[Token(Token = "0x600501B")]
	[Address(RVA = "0x96F940", Offset = "0x96EB40", VA = "0x18096F940")]
	private void SetUpView()
	{
	}

	[Token(Token = "0x600501C")]
	[Address(RVA = "0x96FBD0", Offset = "0x96EDD0", VA = "0x18096FBD0")]
	public InquiryViewController()
	{
	}
}
