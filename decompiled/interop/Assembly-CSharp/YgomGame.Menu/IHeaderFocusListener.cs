using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20012BC")]
public interface IHeaderFocusListener
{
	[Token(Token = "0x6007449")]
	void OnHeaderFocusChanged(bool setfocus, ViewController focusVc, ViewController prevVc);
}
