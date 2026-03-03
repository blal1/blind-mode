using System;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x20013D5")]
public class TitleDataLinkDialogViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x400C3EF")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string content_LABEL;

	[Token(Token = "0x400C3F0")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string button1_LABEL;

	[Token(Token = "0x400C3F1")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string button0_LABEL;

	[Token(Token = "0x400C3F2")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string title_LABEL;

	[Token(Token = "0x400C3F3")]
	[FieldOffset(Offset = "0xF0")]
	private ElementObject content;

	[Token(Token = "0x400C3F4")]
	[FieldOffset(Offset = "0xF8")]
	private ElementObject buttonGrp0;

	[Token(Token = "0x400C3F5")]
	[FieldOffset(Offset = "0x100")]
	private ElementObject buttonGrp1;

	[Token(Token = "0x400C3F6")]
	[FieldOffset(Offset = "0x108")]
	private ElementObject titleGrp;

	[Token(Token = "0x400C3F7")]
	[FieldOffset(Offset = "0x110")]
	private ExtendedTextMeshProUGUI MainText;

	[Token(Token = "0x170012F5")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007B52")]
		[Address(RVA = "0xC4A0F0", Offset = "0xC492F0", VA = "0x180C4A0F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007B53")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007B54")]
	[Address(RVA = "0xC49940", Offset = "0xC48B40", VA = "0x180C49940", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007B55")]
	[Address(RVA = "0x578EC0", Offset = "0x5780C0", VA = "0x180578EC0")]
	private void OnBsck()
	{
	}

	[Token(Token = "0x6007B56")]
	[Address(RVA = "0xC49D70", Offset = "0xC48F70", VA = "0x180C49D70")]
	private void Start()
	{
	}

	[Token(Token = "0x6007B57")]
	[Address(RVA = "0xC4A010", Offset = "0xC49210", VA = "0x180C4A010")]
	public TitleDataLinkDialogViewController()
	{
	}
}
