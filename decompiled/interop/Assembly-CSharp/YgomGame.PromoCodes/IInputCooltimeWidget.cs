using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B8B")]
public interface IInputCooltimeWidget
{
	[Token(Token = "0x6004671")]
	void GetCooltimeWidgets(List<InputFieldWidget> res);
}
