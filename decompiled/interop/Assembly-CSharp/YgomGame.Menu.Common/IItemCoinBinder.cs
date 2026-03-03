using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200147D")]
public interface IItemCoinBinder
{
	[Token(Token = "0x6007F68")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F69")]
	Component BindItemLarge(GameObject target, int itemID);
}
