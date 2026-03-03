using System;
using Il2CppDummyDll;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B8D")]
public interface IItemButtonWidget
{
	[Token(Token = "0x1400005F")]
	event Action<IWidgetSourceItemButton> onClickItemButton;
}
