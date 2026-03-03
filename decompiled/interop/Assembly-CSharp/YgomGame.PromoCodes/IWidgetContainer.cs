using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B8A")]
public interface IWidgetContainer
{
	[Token(Token = "0x6004670")]
	IEnumerable<IWidget> GetChildWidgets();
}
