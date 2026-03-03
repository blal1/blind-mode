using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200124E")]
public interface IFadeSupported
{
	[Token(Token = "0x6007215")]
	Color FadeColor(ViewController.TransitionType type);

	[Token(Token = "0x6007216")]
	SystemProgress.ProgressType FadeType(ViewController.TransitionType type);
}
