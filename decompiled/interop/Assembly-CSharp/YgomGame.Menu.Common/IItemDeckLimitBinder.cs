using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200147A")]
public interface IItemDeckLimitBinder
{
	[Token(Token = "0x6007F62")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F63")]
	Component BindItemLarge(GameObject target, int itemID);
}
