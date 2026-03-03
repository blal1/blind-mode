using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20018BB")]
public struct SelectionItemGroup
{
	[Token(Token = "0x400E7F3")]
	[FieldOffset(Offset = "0x0")]
	public SelectionItem sbtn0;

	[Token(Token = "0x400E7F4")]
	[FieldOffset(Offset = "0x8")]
	public SelectionItem sbtn1;

	[Token(Token = "0x400E7F5")]
	[FieldOffset(Offset = "0x10")]
	public SelectionItem sbtn2;

	[Token(Token = "0x400E7F6")]
	[FieldOffset(Offset = "0x18")]
	public SelectionItem sbtn3;

	[Token(Token = "0x400E7F7")]
	[FieldOffset(Offset = "0x20")]
	public SelectionItem sbtn4;

	[Token(Token = "0x400E7F8")]
	private const int numMax = 5;

	[Token(Token = "0x400E7F9")]
	[FieldOffset(Offset = "0x28")]
	public List<SelectionItem> items;

	[Token(Token = "0x400E7FA")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, List<int>> table;

	[Token(Token = "0x1700182B")]
	public SelectionItem sbtnl
	{
		[Token(Token = "0x6009F1D")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700182C")]
	public SelectionItem sbtnr
	{
		[Token(Token = "0x6009F1E")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009F1F")]
	[Address(RVA = "0xECB520", Offset = "0xECA720", VA = "0x180ECB520")]
	public SelectionItemGroup(LogItemBase itemBase)
	{
	}

	[Token(Token = "0x6009F20")]
	[Address(RVA = "0xECA800", Offset = "0xEC9A00", VA = "0x180ECA800")]
	public void SetUpTransition(SelectionItemGroup upperGroup)
	{
	}

	[Token(Token = "0x6009F21")]
	[Address(RVA = "0xECA490", Offset = "0xEC9690", VA = "0x180ECA490")]
	public void SetDownTransition(SelectionItemGroup lowerGroup)
	{
	}

	[Token(Token = "0x6009F22")]
	[Address(RVA = "0xECA770", Offset = "0xEC9970", VA = "0x180ECA770")]
	public void SetTransitionMode(PadInputDirection direction, SelectionItem.TransitionMode mode)
	{
	}

	[Token(Token = "0x6009F23")]
	[Address(RVA = "0xECA300", Offset = "0xEC9500", VA = "0x180ECA300")]
	public bool IsSelected()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F24")]
	[Address(RVA = "0xEC9FF0", Offset = "0xEC91F0", VA = "0x180EC9FF0")]
	public SelectionItem GetClosestItem(SelectionItemGroup targetGroup)
	{
		return null;
	}

	[Token(Token = "0x6009F25")]
	[Address(RVA = "0xECA230", Offset = "0xEC9430", VA = "0x180ECA230")]
	private int GetSelectedItemIndex()
	{
		return default(int);
	}
}
