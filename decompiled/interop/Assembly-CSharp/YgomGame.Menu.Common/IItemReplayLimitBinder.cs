using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200147B")]
public interface IItemReplayLimitBinder
{
	[Token(Token = "0x6007F64")]
	Component BindItem(GameObject target, int itemID);

	[Token(Token = "0x6007F65")]
	Component BindItemLarge(GameObject target, int itemID);
}
