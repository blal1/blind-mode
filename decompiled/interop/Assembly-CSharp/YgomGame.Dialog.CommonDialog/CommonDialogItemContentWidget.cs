using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FCE")]
public class CommonDialogItemContentWidget : ContentWidgetBase<CommonDialogItemContentWidget, EntryItemContentData>, IContentWidgetAsyncLoader
{
	[Token(Token = "0x400AAFD")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelNameText;

	[Token(Token = "0x400AAFE")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelCategoryText;

	[Token(Token = "0x400AAFF")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelNumText;

	[Token(Token = "0x400AB00")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelThumbHolder;

	[Token(Token = "0x400AB01")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelBadgeLocator;

	[Token(Token = "0x400AB02")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x400AB03")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelEffectRawImage;

	[Token(Token = "0x400AB04")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelAdditionalButton;

	[Token(Token = "0x400AB05")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelAdditionalButtonLabel;

	[Token(Token = "0x400AB06")]
	[FieldOffset(Offset = "0x78")]
	private readonly string k_ALabelItemObtainEffect;

	[Token(Token = "0x400AB07")]
	[FieldOffset(Offset = "0x80")]
	private readonly string k_OGLabel_Button_Default;

	[Token(Token = "0x400AB08")]
	[FieldOffset(Offset = "0x88")]
	private readonly string k_OGLabel_Button_Structure;

	[Token(Token = "0x400AB09")]
	[FieldOffset(Offset = "0x90")]
	private TMP_Text m_NameText;

	[Token(Token = "0x400AB0A")]
	[FieldOffset(Offset = "0x98")]
	private TMP_Text m_CategoryText;

	[Token(Token = "0x400AB0B")]
	[FieldOffset(Offset = "0xA0")]
	private TMP_Text m_Text;

	[Token(Token = "0x400AB0C")]
	[FieldOffset(Offset = "0xA8")]
	private RawImage m_EffectRawImage;

	[Token(Token = "0x400AB0D")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_RenderTarget;

	[Token(Token = "0x400AB0E")]
	[FieldOffset(Offset = "0xB8")]
	private int m_RtId;

	[Token(Token = "0x6005FC8")]
	[Address(RVA = "0xA54E00", Offset = "0xA54000", VA = "0x180A54E00")]
	private string GetButtonOGLabel(int itemCategory)
	{
		return null;
	}

	[Token(Token = "0x6005FC9")]
	[Address(RVA = "0xA54DC0", Offset = "0xA53FC0", VA = "0x180A54DC0")]
	public static CommonDialogItemContentWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FCA")]
	[Address(RVA = "0xA54900", Offset = "0xA53B00", VA = "0x180A54900", Slot = "25")]
	public void AsyncBinding(IEntryData entryData, Action onComplete)
	{
	}

	[Token(Token = "0x6005FCB")]
	[Address(RVA = "0xA54C70", Offset = "0xA53E70", VA = "0x180A54C70", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FCC")]
	[Address(RVA = "0xA54E20", Offset = "0xA54020", VA = "0x180A54E20", Slot = "24")]
	protected override void InnerBinding(EntryItemContentData entryData)
	{
	}

	[Token(Token = "0x6005FCD")]
	[Address(RVA = "0xA558F0", Offset = "0xA54AF0", VA = "0x180A558F0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6005FCE")]
	[Address(RVA = "0xA558A0", Offset = "0xA54AA0", VA = "0x180A558A0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6005FCF")]
	[Address(RVA = "0xA55AC0", Offset = "0xA54CC0", VA = "0x180A55AC0")]
	public CommonDialogItemContentWidget()
	{
	}
}
