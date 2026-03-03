using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001476")]
public interface IItemFieldBinder
{
	[Token(Token = "0x6007F5B")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F5C")]
	Component BindItemLarge(GameObject target, int itemID);
}
