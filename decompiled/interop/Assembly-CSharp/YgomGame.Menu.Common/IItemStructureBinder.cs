using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001475")]
public interface IItemStructureBinder
{
	[Token(Token = "0x6007F5A")]
	Component BindItem(GameObject target, int itemID);
}
