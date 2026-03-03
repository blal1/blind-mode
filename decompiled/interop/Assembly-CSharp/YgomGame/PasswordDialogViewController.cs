using System;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI.ElementWidget;

namespace YgomGame;

[Token(Token = "0x20006C6")]
public class PasswordDialogViewController : DialogViewControllerBase
{
	[Token(Token = "0x40021FD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string argKeyCallback;

	[Token(Token = "0x40021FE")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string INPUT_LABEL;

	[Token(Token = "0x40021FF")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string BTN_OK_LABEL;

	[Token(Token = "0x4002200")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BTN_CANCEL_LABEL;

	[Token(Token = "0x4002201")]
	[FieldOffset(Offset = "0xF8")]
	private InputFieldWidget m_inputFieldWidget;

	[Token(Token = "0x4002202")]
	[FieldOffset(Offset = "0x100")]
	private string m_inputText;

	[Token(Token = "0x4002203")]
	[FieldOffset(Offset = "0x108")]
	private Action<string> m_callback;

	[Token(Token = "0x6002D29")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002D2A")]
	[Address(RVA = "0x706720", Offset = "0x705920", VA = "0x180706720", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002D2B")]
	[Address(RVA = "0x7066E0", Offset = "0x7058E0", VA = "0x1807066E0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002D2C")]
	[Address(RVA = "0x706BB0", Offset = "0x705DB0", VA = "0x180706BB0")]
	public PasswordDialogViewController()
	{
	}
}
