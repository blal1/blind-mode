using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001470")]
public interface IItemProfileTagBinder
{
	[Token(Token = "0x6007F52")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F53")]
	Component BindItemLarge(GameObject target, int itemID);
}
