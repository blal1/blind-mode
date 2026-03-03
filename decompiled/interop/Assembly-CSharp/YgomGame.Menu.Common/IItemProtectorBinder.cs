using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001473")]
public interface IItemProtectorBinder
{
	[Token(Token = "0x6007F57")]
	Component BindItem(GameObject target, int itemID);
}
