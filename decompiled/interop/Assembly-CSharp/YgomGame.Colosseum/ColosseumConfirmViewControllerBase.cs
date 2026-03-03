using System;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BBE")]
public abstract class ColosseumConfirmViewControllerBase : BaseMenuViewController, IDynamicHeaderCustomSupported, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x400FB15")]
	protected const string E_Image = "Image";

	[Token(Token = "0x400FB16")]
	protected const string E_TextTitle = "TextTitle";

	[Token(Token = "0x400FB17")]
	protected const string E_TextExplain = "TextExplain";

	[Token(Token = "0x400FB18")]
	protected const string E_TextAlert = "TextAlert";

	[Token(Token = "0x400FB19")]
	protected const string E_DescGroup = "DescGroup";

	[Token(Token = "0x400FB1A")]
	protected const string E_DescScrollRect = "DescScrollRect";

	[Token(Token = "0x400FB1B")]
	protected const string E_DescText = "DescText";

	[Token(Token = "0x400FB1C")]
	protected const string E_TemplateButtonInfo = "TemplateButtonInfo";

	[Token(Token = "0x400FB1D")]
	protected const string E_AgreementGroup = "AgreementGroup";

	[Token(Token = "0x400FB1E")]
	protected const string E_TemplateButtonGroup = "TemplateButtonGroup";

	[Token(Token = "0x400FB1F")]
	protected const string E_ConfirmGroup = "ConfirmGroup";

	[Token(Token = "0x400FB20")]
	protected const string E_TemplateButtonBottom = "TemplateButtonBottom";

	[Token(Token = "0x400FB21")]
	protected const string E_Button = "Button";

	[Token(Token = "0x400FB22")]
	protected const string E_Text = "Text";

	[Token(Token = "0x400FB23")]
	protected const string E_TextSelecting = "TextSelecting";

	[Token(Token = "0x400FB24")]
	protected const string ARGKEY_LOGO = "logoId";

	[Token(Token = "0x400FB25")]
	protected const string ARGKEY_ID = "identifier";

	[Token(Token = "0x400FB26")]
	protected const string ARGKEY_ONSUCCESS = "onSuccess";

	[Token(Token = "0x400FB27")]
	[FieldOffset(Offset = "0xD0")]
	protected int logoId;

	[Token(Token = "0x400FB28")]
	[FieldOffset(Offset = "0xD4")]
	protected int identifier;

	[Token(Token = "0x400FB29")]
	[FieldOffset(Offset = "0xD8")]
	protected Action onSuccess;

	[Token(Token = "0x600B49D")]
	protected abstract void UpdateView();

	[Token(Token = "0x600B49E")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B49F")]
	[Address(RVA = "0x4B8E20", Offset = "0x4B8020", VA = "0x1804B8E20", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B4A0")]
	[Address(RVA = "0x4B8EE0", Offset = "0x4B80E0", VA = "0x1804B8EE0")]
	private void UpdateLogo()
	{
	}

	[Token(Token = "0x600B4A1")]
	[Address(RVA = "0x4B8BA0", Offset = "0x4B7DA0", VA = "0x1804B8BA0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600B4A2")]
	[Address(RVA = "0x4B8B20", Offset = "0x4B7D20", VA = "0x1804B8B20")]
	private void CheckText()
	{
	}

	[Token(Token = "0x600B4A3")]
	[Address(RVA = "0x4B8A40", Offset = "0x4B7C40", VA = "0x1804B8A40")]
	private void CheckSetActiveText(string label)
	{
	}

	[Token(Token = "0x600B4A4")]
	[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x600B4A5")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	protected ColosseumConfirmViewControllerBase()
	{
	}
}
