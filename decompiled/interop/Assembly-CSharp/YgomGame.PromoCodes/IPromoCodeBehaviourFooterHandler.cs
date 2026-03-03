using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B42")]
public interface IPromoCodeBehaviourFooterHandler
{
	[Token(Token = "0x60044EE")]
	bool InsertFooter(ElementObjectManager footerEom, string footerLabel, Action buttonAction, bool mute = false, SelectorManager.KeyType shortcutKey = SelectorManager.KeyType.None, [Optional] string footerName);
}
