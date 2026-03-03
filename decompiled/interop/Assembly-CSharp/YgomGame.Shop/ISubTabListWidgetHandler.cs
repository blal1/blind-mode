using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x200096B")]
public interface ISubTabListWidgetHandler
{
	[Token(Token = "0x17000788")]
	int currentIdx
	{
		[Token(Token = "0x6003972")]
		get;
	}

	[Token(Token = "0x17000789")]
	int currentSectionIdx
	{
		[Token(Token = "0x6003973")]
		get;
	}

	[Token(Token = "0x600396D")]
	(int, int) CategoryIdOfIndex(int dataIdx);

	[Token(Token = "0x600396E")]
	void OnUpdateSubTabWidget(List<int> templateIds);

	[Token(Token = "0x600396F")]
	void OnUpdateTabWidget(ShopTabWidget widget, int dataIdx);

	[Token(Token = "0x6003970")]
	void OnUpdateSectionFactory(ElementEntityFactory entityFactory, int dataIdx);

	[Token(Token = "0x6003971")]
	void OnUpdateSectionTabWidget(ShopTabWidget widget, int dataIdx, int sectionIdx);
}
