using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001474")]
public interface IItemDeckCaseBinder
{
	[Token(Token = "0x6007F58")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F59")]
	Component BindItemLarge(GameObject target, int itemID);
}
