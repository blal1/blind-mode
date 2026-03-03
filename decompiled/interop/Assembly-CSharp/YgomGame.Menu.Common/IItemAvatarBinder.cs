using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200146E")]
public interface IItemAvatarBinder
{
	[Token(Token = "0x6007F4F")]
	Component BindItem(GameObject target, int itemID);
}
