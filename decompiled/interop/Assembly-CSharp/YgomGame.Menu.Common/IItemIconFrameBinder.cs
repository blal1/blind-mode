using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001471")]
public interface IItemIconFrameBinder
{
	[Token(Token = "0x6007F54")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F55")]
	Component BindItemLarge(GameObject target, int itemID);
}
