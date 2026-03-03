using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC5")]
public class CommonDialogButtonGroupWidget : ElementWidgetBehaviourBase<CommonDialogButtonGroupWidget>
{
	[Token(Token = "0x2000FC6")]
	public enum ButtonType
	{
		[Token(Token = "0x400AAAD")]
		Positive,
		[Token(Token = "0x400AAAE")]
		Destructive,
		[Token(Token = "0x400AAAF")]
		Disable,
		[Token(Token = "0x400AAB0")]
		Highlight
	}

	[Token(Token = "0x400AAA2")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelButtonPositive;

	[Token(Token = "0x400AAA3")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelButtonDestructive;

	[Token(Token = "0x400AAA4")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelButtonDisable;

	[Token(Token = "0x400AAA5")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelButtonHighlight;

	[Token(Token = "0x400AAA6")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelSpace;

	[Token(Token = "0x400AAA7")]
	[FieldOffset(Offset = "0x50")]
	private CommonDialogButtonWidget m_ButtonPositive;

	[Token(Token = "0x400AAA8")]
	[FieldOffset(Offset = "0x58")]
	private CommonDialogButtonWidget m_ButtonDestructive;

	[Token(Token = "0x400AAA9")]
	[FieldOffset(Offset = "0x60")]
	private CommonDialogButtonWidget m_ButtonDisable;

	[Token(Token = "0x400AAAA")]
	[FieldOffset(Offset = "0x68")]
	private CommonDialogButtonWidget m_ButtonHighlight;

	[Token(Token = "0x17000F10")]
	public bool endDefault
	{
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0x49BE90", Offset = "0x49B090", VA = "0x18049BE90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0x49C580", Offset = "0x49B780", VA = "0x18049C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005F88")]
	[Address(RVA = "0xA4F510", Offset = "0xA4E710", VA = "0x180A4F510")]
	public static CommonDialogButtonGroupWidget Create(ElementObjectManager eom, bool endDefault)
	{
		return null;
	}

	[Token(Token = "0x6005F89")]
	[Address(RVA = "0xA4F290", Offset = "0xA4E490", VA = "0x180A4F290", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005F8A")]
	[Address(RVA = "0xA4F570", Offset = "0xA4E770", VA = "0x180A4F570")]
	public CommonDialogButtonWidget GetButtonWidget(ButtonType buttonType)
	{
		return null;
	}

	[Token(Token = "0x6005F8B")]
	[Address(RVA = "0xA4F5A0", Offset = "0xA4E7A0", VA = "0x180A4F5A0")]
	public void SetSpace()
	{
	}

	[Token(Token = "0x6005F8C")]
	[Address(RVA = "0xA4F660", Offset = "0xA4E860", VA = "0x180A4F660")]
	public CommonDialogButtonGroupWidget()
	{
	}
}
