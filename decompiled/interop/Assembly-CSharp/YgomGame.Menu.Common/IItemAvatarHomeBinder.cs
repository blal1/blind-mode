using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001478")]
public interface IItemAvatarHomeBinder
{
	[Token(Token = "0x6007F5F")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F60")]
	Component BindItemLarge(GameObject target, int itemID);
}
