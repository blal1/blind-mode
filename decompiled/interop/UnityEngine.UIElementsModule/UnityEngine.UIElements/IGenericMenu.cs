using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000CE")]
internal interface IGenericMenu
{
	[Token(Token = "0x600066A")]
	void AddItem(string itemName, bool isChecked, Action action);

	[Token(Token = "0x600066B")]
	void AddItem(string itemName, bool isChecked, Action<object> action, object data);

	[Token(Token = "0x600066C")]
	void DropDown(Rect position, [Optional] VisualElement targetElement, bool anchored = false);
}
