using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.WebHelp;

[Token(Token = "0x200071F")]
public class WebHelpViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400236F")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string TEXT_TOP_LABEL;

	[Token(Token = "0x4002370")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TEXT_DESC1_LABEL;

	[Token(Token = "0x4002371")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TEXT_DESC2_LABEL;

	[Token(Token = "0x4002372")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TEXT_BUTTON_LABEL;

	[Token(Token = "0x4002373")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BUTTON_LABEL;

	[Token(Token = "0x4002374")]
	[FieldOffset(Offset = "0xF8")]
	private ExtendedTextMeshProUGUI m_topText;

	[Token(Token = "0x4002375")]
	[FieldOffset(Offset = "0x100")]
	private ExtendedTextMeshProUGUI m_desc1Text;

	[Token(Token = "0x4002376")]
	[FieldOffset(Offset = "0x108")]
	private ExtendedTextMeshProUGUI m_desc2Text;

	[Token(Token = "0x4002377")]
	[FieldOffset(Offset = "0x110")]
	private ExtendedTextMeshProUGUI m_urlText;

	[Token(Token = "0x4002378")]
	[FieldOffset(Offset = "0x118")]
	private ExtendedTextMeshProUGUI m_buttonText;

	[Token(Token = "0x4002379")]
	[FieldOffset(Offset = "0x120")]
	private SelectionButton m_helpButton;

	[Token(Token = "0x400237A")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TEXT_URL_LABEL;

	[Token(Token = "0x400237B")]
	[FieldOffset(Offset = "0x130")]
	private string m_url;

	[Token(Token = "0x6002EDF")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002EE0")]
	[Address(RVA = "0x72AB70", Offset = "0x729D70", VA = "0x18072AB70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002EE1")]
	[Address(RVA = "0x72AEA0", Offset = "0x72A0A0", VA = "0x18072AEA0")]
	public static void Open()
	{
	}

	[Token(Token = "0x6002EE2")]
	[Address(RVA = "0x72AF00", Offset = "0x72A100", VA = "0x18072AF00")]
	private void SetUpView()
	{
	}

	[Token(Token = "0x6002EE3")]
	[Address(RVA = "0x72AB60", Offset = "0x729D60", VA = "0x18072AB60")]
	private void JumpToLink()
	{
	}

	[Token(Token = "0x6002EE4")]
	[Address(RVA = "0x72B190", Offset = "0x72A390", VA = "0x18072B190")]
	public WebHelpViewController()
	{
	}
}
