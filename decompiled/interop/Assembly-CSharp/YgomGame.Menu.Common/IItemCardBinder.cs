using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200146D")]
public interface IItemCardBinder
{
	[Token(Token = "0x6007F4E")]
	Component BindItem(GameObject target, int itemID, int premiere = 1);
}
