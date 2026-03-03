using System;
using Il2CppDummyDll;
using TMPro;
using YgomGame.Shop;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.OpenResult;

[Token(Token = "0x2001549")]
public class SecretPackWidget : ElementWidgetBehaviourBase<SecretPackWidget>
{
	[Token(Token = "0x400CC00")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x400CC01")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelNameText;

	[Token(Token = "0x400CC02")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelThumbHolder;

	[Token(Token = "0x400CC03")]
	[FieldOffset(Offset = "0x40")]
	private int m_ShopId;

	[Token(Token = "0x400CC04")]
	[FieldOffset(Offset = "0x48")]
	private SelectionButton m_SelectionButton;

	[Token(Token = "0x400CC05")]
	[FieldOffset(Offset = "0x50")]
	private TMP_Text m_NameText;

	[Token(Token = "0x400CC06")]
	[FieldOffset(Offset = "0x58")]
	private BindingShopProductThumb m_BindingShopProductThumb;

	[Token(Token = "0x400CC07")]
	[FieldOffset(Offset = "0x60")]
	public Action<SecretPackWidget> onClickCallback;

	[Token(Token = "0x1700140B")]
	public int shopId
	{
		[Token(Token = "0x6008389")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700140C")]
	public SelectionButton selectionButton
	{
		[Token(Token = "0x600838A")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700140D")]
	public TMP_Text nameText
	{
		[Token(Token = "0x600838B")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700140E")]
	public BindingShopProductThumb bindingShopProductThumb
	{
		[Token(Token = "0x600838C")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600838D")]
	[Address(RVA = "0xCC7260", Offset = "0xCC6460", VA = "0x180CC7260")]
	public static SecretPackWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x600838E")]
	[Address(RVA = "0xCC7170", Offset = "0xCC6370", VA = "0x180CC7170")]
	public void Binding(int shopId, string name, BindingShopProductThumb.Context thumbContext)
	{
	}

	[Token(Token = "0x600838F")]
	[Address(RVA = "0x91EA40", Offset = "0x91DC40", VA = "0x18091EA40")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6008390")]
	[Address(RVA = "0xCC73C0", Offset = "0xCC65C0", VA = "0x180CC73C0")]
	public SecretPackWidget()
	{
	}
}
