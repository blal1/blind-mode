using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200145C")]
public class CardResourceBinder : ResourceBinderBase, IItemCardBinder, IItemProtectorBinder
{
	[Token(Token = "0x6007EE6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardResourceBinder()
	{
	}

	[Token(Token = "0x6007EE7")]
	[Address(RVA = "0xC710C0", Offset = "0xC702C0", VA = "0x180C710C0")]
	public BindingProtectorMaterial BindProtectorIcon(RawImage target, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007EE8")]
	[Address(RVA = "0xC710A0", Offset = "0xC702A0", VA = "0x180C710A0")]
	public BindingCardMaterial BindCardImage(RawImage target, int mrk, int prare = 1, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007EE9")]
	[Address(RVA = "0xC71190", Offset = "0xC70390", VA = "0x180C71190", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemCardBinder_002EBindItem(GameObject target, int itemID, int premiere)
	{
		return null;
	}

	[Token(Token = "0x6007EEA")]
	[Address(RVA = "0xC712A0", Offset = "0xC704A0", VA = "0x180C712A0", Slot = "5")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemProtectorBinder_002EBindItem(GameObject target, int itemID)
	{
		return null;
	}
}
