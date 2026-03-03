using System;
using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC7")]
public class CommonDialogButtonWidget : ContentWidgetBase<CommonDialogButtonWidget, EntryButtonData>, IConentWidgetSendableClose
{
	[Token(Token = "0x400AAB1")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLabel;

	[Token(Token = "0x400AAB2")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton m_Button;

	[Token(Token = "0x400AAB3")]
	[FieldOffset(Offset = "0x40")]
	private TMP_Text m_Text;

	[Token(Token = "0x400AAB4")]
	[FieldOffset(Offset = "0x48")]
	private Action m_OnClickCallback;

	[Token(Token = "0x400AAB5")]
	[FieldOffset(Offset = "0x50")]
	private Action<CommonDialogButtonWidget> m_OnClickWidgetCallback;

	[Token(Token = "0x400AAB6")]
	[FieldOffset(Offset = "0x58")]
	private string m_OnClickUrlScheme;

	[Token(Token = "0x400AAB7")]
	[FieldOffset(Offset = "0x60")]
	private bool m_CloseOnClick;

	[Token(Token = "0x400AAB8")]
	[FieldOffset(Offset = "0x68")]
	public Action onSendCloseCallback;

	[Token(Token = "0x17000F11")]
	public SelectionButton button
	{
		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F12")]
	private Action YgomGame_002EDialog_002ECommonDialog_002EIConentWidgetSendableClose_002EonSendCloseCallback
	{
		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0", Slot = "25")]
		set
		{
		}
	}

	[Token(Token = "0x6005F8F")]
	[Address(RVA = "0xA4F890", Offset = "0xA4EA90", VA = "0x180A4F890")]
	public static CommonDialogButtonWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005F90")]
	[Address(RVA = "0xA4F760", Offset = "0xA4E960", VA = "0x180A4F760", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005F91")]
	[Address(RVA = "0xA4F8D0", Offset = "0xA4EAD0", VA = "0x180A4F8D0", Slot = "24")]
	protected override void InnerBinding(EntryButtonData entryData)
	{
	}

	[Token(Token = "0x6005F92")]
	[Address(RVA = "0xA4FB70", Offset = "0xA4ED70", VA = "0x180A4FB70")]
	public void SetAsDefault(bool isDefault = true)
	{
	}

	[Token(Token = "0x6005F93")]
	[Address(RVA = "0xA4FAA0", Offset = "0xA4ECA0", VA = "0x180A4FAA0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6005F94")]
	[Address(RVA = "0xA4FB90", Offset = "0xA4ED90", VA = "0x180A4FB90")]
	public CommonDialogButtonWidget()
	{
	}
}
