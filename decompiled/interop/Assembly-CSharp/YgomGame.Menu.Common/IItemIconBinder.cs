using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200146F")]
public interface IItemIconBinder
{
	[Token(Token = "0x6007F50")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F51")]
	Component BindItemLarge(GameObject target, int itemID);
}
