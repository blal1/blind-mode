using System;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F3F")]
public class ProductGroupShopAreaHeaderWidget : ElementWidgetBase, IProductWidget
{
	[Token(Token = "0x400A6D7")]
	[FieldOffset(Offset = "0x20")]
	private string label_ButtonInfo;

	[Token(Token = "0x400A6D8")]
	[FieldOffset(Offset = "0x28")]
	private string label_ButtonShop;

	[Token(Token = "0x400A6D9")]
	[FieldOffset(Offset = "0x30")]
	private string label_GroupSelectCard;

	[Token(Token = "0x400A6DA")]
	[FieldOffset(Offset = "0x38")]
	private string label_TextName;

	[Token(Token = "0x400A6DB")]
	[FieldOffset(Offset = "0x40")]
	private string label_TextTitle;

	[Token(Token = "0x400A6DC")]
	[FieldOffset(Offset = "0x48")]
	private string label_Button;

	[Token(Token = "0x400A6DD")]
	[FieldOffset(Offset = "0x50")]
	private string label_PickImage;

	[Token(Token = "0x400A6DE")]
	[FieldOffset(Offset = "0x58")]
	private string label_PickPackImage;

	[Token(Token = "0x400A6DF")]
	[FieldOffset(Offset = "0x60")]
	private string label_CardImage;

	[Token(Token = "0x400A6E0")]
	[FieldOffset(Offset = "0x68")]
	private string label_PackImage;

	[Token(Token = "0x400A6E1")]
	[FieldOffset(Offset = "0x70")]
	private string label_ThumbButton;

	[Token(Token = "0x400A6E2")]
	[FieldOffset(Offset = "0x78")]
	private SelectionButton m_infoButton;

	[Token(Token = "0x400A6E3")]
	[FieldOffset(Offset = "0x80")]
	private SelectionButton m_shopButton;

	[Token(Token = "0x400A6E4")]
	[FieldOffset(Offset = "0x88")]
	private SelectionButton m_selectCardButton;

	[Token(Token = "0x400A6E5")]
	[FieldOffset(Offset = "0x90")]
	private SelectionButton m_thumbButton;

	[Token(Token = "0x400A6E6")]
	[FieldOffset(Offset = "0x98")]
	private ExtendedTextMeshProUGUI textName;

	[Token(Token = "0x400A6E7")]
	[FieldOffset(Offset = "0xA0")]
	private ExtendedTextMeshProUGUI textTitle;

	[Token(Token = "0x400A6E8")]
	[FieldOffset(Offset = "0xA8")]
	private ElementObjectManager m_pickImageEom;

	[Token(Token = "0x400A6E9")]
	[FieldOffset(Offset = "0xB0")]
	private ElementObjectManager m_pickPackImageEom;

	[Token(Token = "0x400A6EA")]
	[FieldOffset(Offset = "0xB8")]
	private string m_InfoText;

	[Token(Token = "0x400A6EB")]
	[FieldOffset(Offset = "0xC0")]
	private string m_PackNameIds;

	[Token(Token = "0x400A6EC")]
	[FieldOffset(Offset = "0xC8")]
	private string m_Url;

	[Token(Token = "0x400A6ED")]
	[FieldOffset(Offset = "0xD0")]
	public Action<string> onClickShopCallback;

	[Token(Token = "0x400A6EE")]
	[FieldOffset(Offset = "0xD8")]
	public Action<string> onClickInfoCallback;

	[Token(Token = "0x400A6EF")]
	[FieldOffset(Offset = "0xE0")]
	public Action onClickSelectCardCallback;

	[Token(Token = "0x17000E7E")]
	public SelectionButton infoButton
	{
		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7F")]
	public SelectionButton shopButton
	{
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E80")]
	public SelectionButton selectCardButton
	{
		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E81")]
	public SelectionButton thumbButton
	{
		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E82")]
	public ElementObjectManager pickImageEom
	{
		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E83")]
	public ElementObjectManager pickPackImageEom
	{
		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E84")]
	public SelectionButton currentActiveImageButton
	{
		[Token(Token = "0x6005C66")]
		[Address(RVA = "0xA21450", Offset = "0xA20650", VA = "0x180A21450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005C67")]
	[Address(RVA = "0xA20E60", Offset = "0xA20060", VA = "0x180A20E60")]
	public ProductGroupShopAreaHeaderWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005C68")]
	[Address(RVA = "0xA20B80", Offset = "0xA1FD80", VA = "0x180A20B80")]
	public void SetView(DuelLiveCardPackData packData, int filterMrk)
	{
	}

	[Token(Token = "0x6005C69")]
	[Address(RVA = "0xA20740", Offset = "0xA1F940", VA = "0x180A20740")]
	public void BindImage(int mrk)
	{
	}

	[Token(Token = "0x6005C6A")]
	[Address(RVA = "0xA20940", Offset = "0xA1FB40", VA = "0x180A20940")]
	public void BindPackImage(int id)
	{
	}
}
