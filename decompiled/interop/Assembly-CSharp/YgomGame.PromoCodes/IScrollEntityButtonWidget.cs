using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B8C")]
public interface IScrollEntityButtonWidget
{
	[Token(Token = "0x6004672")]
	IReadOnlyList<(SelectionItem, int, int)> CollectionSelectionItems();
}
