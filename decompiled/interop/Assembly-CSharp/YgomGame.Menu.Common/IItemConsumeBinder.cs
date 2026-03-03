using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200146C")]
public interface IItemConsumeBinder
{
	[Token(Token = "0x6007F4C")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F4D")]
	Component BindItemLarge(GameObject target, int itemID);
}
