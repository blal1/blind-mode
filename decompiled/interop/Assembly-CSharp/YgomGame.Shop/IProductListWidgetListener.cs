using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Token(Token = "0x2000960")]
public interface IProductListWidgetListener
{
	[Token(Token = "0x6003913")]
	void OnProductListScrolled(Vector2 value);

	[Token(Token = "0x6003914")]
	void OnFocusProductLine(int categoryId, int subCategoryId, int sectionId);

	[Token(Token = "0x6003915")]
	void OnClickProduct(ProductWidget productWidget);
}
