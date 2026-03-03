using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x2000957")]
public interface IProductContainerWidgetHandler
{
	[Token(Token = "0x60038EE")]
	void OnClickContentRootButton(ProductContext productCtx);

	[Token(Token = "0x60038EF")]
	void UpdateProductWidget(ProductWidget productWidget, ProductContext productCtx);
}
