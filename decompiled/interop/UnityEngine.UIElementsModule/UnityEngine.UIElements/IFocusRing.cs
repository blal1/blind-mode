using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000251")]
public interface IFocusRing
{
	[Token(Token = "0x6001016")]
	FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);

	[Token(Token = "0x6001017")]
	Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);
}
