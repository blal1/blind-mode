using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20013D3")]
public class PrivacySettingsViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400C3DE")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string LABEL_BUTTONOK;

	[Token(Token = "0x400C3DF")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string LABEL_BUTTONCANCEL;

	[Token(Token = "0x400C3E0")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string LABEL_BUTTON_1;

	[Token(Token = "0x400C3E1")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string LABEL_BUTTON_2;

	[Token(Token = "0x400C3E2")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public int dataCount;

	[Token(Token = "0x400C3E3")]
	[FieldOffset(Offset = "0xF4")]
	private bool optOutBool;

	[Token(Token = "0x400C3E4")]
	[FieldOffset(Offset = "0xF8")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x400C3E5")]
	[FieldOffset(Offset = "0x100")]
	private SelectionButton m_OKButton;

	[Token(Token = "0x400C3E6")]
	[FieldOffset(Offset = "0x108")]
	private ElementObject subTitleText1;

	[Token(Token = "0x400C3E7")]
	[FieldOffset(Offset = "0x110")]
	private ElementObject subTitleText2;

	[Token(Token = "0x400C3E8")]
	[FieldOffset(Offset = "0x118")]
	private ElementObjectManager button1;

	[Token(Token = "0x400C3E9")]
	[FieldOffset(Offset = "0x120")]
	private ElementObjectManager button2;

	[Token(Token = "0x400C3EA")]
	[FieldOffset(Offset = "0x128")]
	private SelectionButton leftButton;

	[Token(Token = "0x400C3EB")]
	[FieldOffset(Offset = "0x130")]
	private SelectionButton rightButton;

	[Token(Token = "0x400C3EC")]
	[FieldOffset(Offset = "0x138")]
	private bool leftselect;

	[Token(Token = "0x6007B41")]
	[Address(RVA = "0xC42B60", Offset = "0xC41D60", VA = "0x180C42B60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007B42")]
	[Address(RVA = "0xC429F0", Offset = "0xC41BF0", VA = "0x180C429F0")]
	private void InitializeOptOut()
	{
	}

	[Token(Token = "0x6007B43")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007B44")]
	[Address(RVA = "0xC42A60", Offset = "0xC41C60", VA = "0x180C42A60")]
	private void OnClickOKButton()
	{
	}

	[Token(Token = "0x6007B45")]
	[Address(RVA = "0x6F9740", Offset = "0x6F8940", VA = "0x1806F9740")]
	private void OnClickButtonCancel()
	{
	}

	[Token(Token = "0x6007B46")]
	[Address(RVA = "0xC42FF0", Offset = "0xC421F0", VA = "0x180C42FF0")]
	private void SetActiveOKButton(bool flag)
	{
	}

	[Token(Token = "0x6007B47")]
	[Address(RVA = "0xC43380", Offset = "0xC42580", VA = "0x180C43380")]
	private void setButton()
	{
	}

	[Token(Token = "0x6007B48")]
	[Address(RVA = "0xC436D0", Offset = "0xC428D0", VA = "0x180C436D0")]
	private void setUnChangeAble()
	{
	}

	[Token(Token = "0x6007B49")]
	[Address(RVA = "0xC43290", Offset = "0xC42490", VA = "0x180C43290")]
	public PrivacySettingsViewController()
	{
	}
}
