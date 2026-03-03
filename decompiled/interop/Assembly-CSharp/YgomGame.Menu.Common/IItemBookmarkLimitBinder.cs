using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200147C")]
public interface IItemBookmarkLimitBinder
{
	[Token(Token = "0x6007F66")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F67")]
	Component BindItemLarge(GameObject target, int itemID);
}
