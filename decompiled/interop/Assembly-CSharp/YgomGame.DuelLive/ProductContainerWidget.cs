using System;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F3C")]
public class ProductContainerWidget : ElementWidgetBase
{
	[Token(Token = "0x400A6D1")]
	[FieldOffset(Offset = "0x20")]
	public readonly ProductWidget[] productWidgets;

	[Token(Token = "0x400A6D2")]
	[FieldOffset(Offset = "0x28")]
	public Action<ProductContainerWidget, ProductWidget> onClickProductWidgetCallback;

	[Token(Token = "0x6005C5B")]
	[Address(RVA = "0xA203E0", Offset = "0xA1F5E0", VA = "0x180A203E0")]
	public ProductContainerWidget(ElementObjectManager eom, ElementObjectManager productPref, int contentLength)
	{
	}

	[Token(Token = "0x6005C5C")]
	[Address(RVA = "0xA203C0", Offset = "0xA1F5C0", VA = "0x180A203C0")]
	private void OnClick(ProductWidget clickedWidget)
	{
	}
}
