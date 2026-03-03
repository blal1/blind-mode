using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x2000953")]
public interface IMainTabListWidgetHandler
{
	[Token(Token = "0x17000769")]
	int currentIdx
	{
		[Token(Token = "0x60038DE")]
		get;
	}

	[Token(Token = "0x60038DC")]
	void OnUpdateMainTabDataCount(List<string> tabTemplateLabels);

	[Token(Token = "0x60038DD")]
	void OnUpdateMainTabData(ShopTabWidget tabWidget, int dataIndex, string label);
}
