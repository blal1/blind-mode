using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x200095F")]
public interface IProductListWidgetHandler : IProductContainerWidgetHandler
{
	[Token(Token = "0x17000777")]
	ProductWidgetController productWidgetController
	{
		[Token(Token = "0x6003911")]
		get;
	}

	[Token(Token = "0x17000778")]
	int showcaseUnloadUnusedCnt
	{
		[Token(Token = "0x6003912")]
		get;
	}

	[Token(Token = "0x600390F")]
	bool EqualCurrentCategoryId(int chkCategoryId, int chkSubCategoryId, int chkSectionId);

	[Token(Token = "0x6003910")]
	void OnUpdateDataCount(List<int> templateIdxList, List<ProductGroupHeaderWidget.Context> headerCtxs, Dictionary<int, Dictionary<int, Dictionary<int, int>>> headerDataIdxMap, List<ProductContainerWidget.Context> productContainerCtxs);
}
