using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001479")]
public interface IItemCardTicketBinder
{
	[Token(Token = "0x6007F61")]
	Component BindItem(GameObject target, int itemID);
}
