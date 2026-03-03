using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001477")]
public interface IItemFieldObjBinder
{
	[Token(Token = "0x6007F5D")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F5E")]
	Component BindItemLarge(GameObject target, int itemID);
}
