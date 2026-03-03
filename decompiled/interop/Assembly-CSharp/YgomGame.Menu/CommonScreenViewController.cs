using System;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20011A5")]
public abstract class CommonScreenViewController : BaseMenuViewController
{
	[Token(Token = "0x400B858")]
	private const string DecisionButtonLabel = "ButtonNext";

	[Token(Token = "0x400B859")]
	private const string BackButtonLabel = "ButtonBack";

	[Token(Token = "0x400B85A")]
	[FieldOffset(Offset = "0xD0")]
	private SelectionButton m_decisionButton;

	[Token(Token = "0x400B85B")]
	[FieldOffset(Offset = "0xD8")]
	private SelectionButton m_backButton;

	[Token(Token = "0x400B85C")]
	[FieldOffset(Offset = "0xE0")]
	private Action m_decisionCallback;

	[Token(Token = "0x400B85D")]
	[FieldOffset(Offset = "0xE8")]
	private Action m_backCallback;

	[Token(Token = "0x400B85E")]
	[FieldOffset(Offset = "0xF0")]
	private Text m_decisionButtonText;

	[Token(Token = "0x400B85F")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_enabelBackConfirmDialog;

	[Token(Token = "0x400B860")]
	[FieldOffset(Offset = "0x100")]
	private string m_backConfirmDialogTitle;

	[Token(Token = "0x400B861")]
	[FieldOffset(Offset = "0x108")]
	private string m_backConfirmDialogMessage;

	[Token(Token = "0x400B862")]
	[FieldOffset(Offset = "0x110")]
	private string m_backConfirmDialogButtonLabel;

	[Token(Token = "0x6006EBF")]
	[Address(RVA = "0xB5A900", Offset = "0xB59B00", VA = "0x180B5A900")]
	protected void SetDecisionText(string text)
	{
	}

	[Token(Token = "0x6006EC0")]
	[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
	protected void SetDecisionCallback(Action callback)
	{
	}

	[Token(Token = "0x6006EC1")]
	[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
	protected void SetBackCallback(Action callback)
	{
	}

	[Token(Token = "0x6006EC2")]
	[Address(RVA = "0xB5A9A0", Offset = "0xB59BA0", VA = "0x180B5A9A0")]
	protected void SetEnableDecisionButton(bool enable)
	{
	}

	[Token(Token = "0x6006EC3")]
	[Address(RVA = "0xB5ABA0", Offset = "0xB59DA0", VA = "0x180B5ABA0")]
	protected void ShowDecisionButton(bool enable)
	{
	}

	[Token(Token = "0x6006EC4")]
	[Address(RVA = "0xB5AA50", Offset = "0xB59C50", VA = "0x180B5AA50")]
	protected void ShowBackButton(bool enable)
	{
	}

	[Token(Token = "0x6006EC5")]
	[Address(RVA = "0xB5A870", Offset = "0xB59A70", VA = "0x180B5A870")]
	protected void SetBackConfirmDialog(IntroductionBackDialogSetting setting)
	{
	}

	[Token(Token = "0x6006EC6")]
	[Address(RVA = "0xB5A610", Offset = "0xB59810", VA = "0x180B5A610")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006EC7")]
	[Address(RVA = "0xB5A6A0", Offset = "0xB598A0", VA = "0x180B5A6A0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006EC8")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	protected CommonScreenViewController()
	{
	}
}
