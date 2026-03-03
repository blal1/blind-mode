using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200145B")]
public class CardPackResourceBinder : ResourceBinderBase, IItemCardTicketBinder
{
	[Token(Token = "0x400C67B")]
	[FieldOffset(Offset = "0x10")]
	public readonly string m_PackTicketPath;

	[Token(Token = "0x400C67C")]
	[FieldOffset(Offset = "0x18")]
	public readonly string m_PackTexPath;

	[Token(Token = "0x6007EE0")]
	[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
	public CardPackResourceBinder(string packTicket, string packTexPath)
	{
	}

	[Token(Token = "0x6007EE1")]
	[Address(RVA = "0xC71060", Offset = "0xC70260", VA = "0x180C71060")]
	public string GetPackTicketPath(int itemId = 0)
	{
		return null;
	}

	[Token(Token = "0x6007EE2")]
	[Address(RVA = "0xC70FE0", Offset = "0xC701E0", VA = "0x180C70FE0")]
	public BindingImageEx BindPackTicket(Image target, int packTicketId = 0, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x6007EE3")]
	[Address(RVA = "0xC71050", Offset = "0xC70250", VA = "0x180C71050")]
	public string GetPackTexPath(string packImageName)
	{
		return null;
	}

	[Token(Token = "0x6007EE4")]
	[Address(RVA = "0xC70EE0", Offset = "0xC700E0", VA = "0x180C70EE0")]
	public BindingImageDX BindCardPackImage(Image target, string packImageName)
	{
		return null;
	}

	[Token(Token = "0x6007EE5")]
	[Address(RVA = "0xC70F20", Offset = "0xC70120", VA = "0x180C70F20", Slot = "4")]
	public Component BindItem(GameObject target, int itemID)
	{
		return null;
	}
}
