using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001472")]
public interface IItemWallpaperBinder
{
	[Token(Token = "0x6007F56")]
	Component BindItem(GameObject target, int itemID);
}
