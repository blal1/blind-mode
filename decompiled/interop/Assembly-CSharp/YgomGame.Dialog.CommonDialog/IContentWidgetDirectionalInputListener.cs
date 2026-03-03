using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FE1")]
public interface IContentWidgetDirectionalInputListener
{
	[Token(Token = "0x6006025")]
	void OnMainAnalogInput(Vector2 dir);

	[Token(Token = "0x6006026")]
	void OnSubAnalogInput(Vector2 dir);

	[Token(Token = "0x6006027")]
	void OnLeftInput();

	[Token(Token = "0x6006028")]
	void OnRightInput();

	[Token(Token = "0x6006029")]
	void OnUpInput();

	[Token(Token = "0x600602A")]
	void OnDownInput();
}
