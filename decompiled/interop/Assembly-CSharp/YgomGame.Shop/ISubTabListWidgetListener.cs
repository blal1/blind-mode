using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Shop;

[Token(Token = "0x200096A")]
public interface ISubTabListWidgetListener
{
	[Token(Token = "0x6003969")]
	bool OnInputDirectionSubCategory(PadInputDirection direction);

	[Token(Token = "0x600396A")]
	void OnClickSubCategory(int dataIdx);

	[Token(Token = "0x600396B")]
	void OnClickSubCategoryGroup(int dataIdx);

	[Token(Token = "0x600396C")]
	void OnClickSubCategorySection(int dataIdx, int sectionIdx);
}
