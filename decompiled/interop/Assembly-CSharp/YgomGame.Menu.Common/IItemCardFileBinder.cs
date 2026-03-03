using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200147E")]
public interface IItemCardFileBinder
{
	[Token(Token = "0x6007F6A")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F6B")]
	Component BindItemLarge(GameObject target, int itemID);
}
