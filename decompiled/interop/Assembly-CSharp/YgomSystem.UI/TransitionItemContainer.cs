using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004D8")]
public class TransitionItemContainer : MonoBehaviour
{
	[Token(Token = "0x40017DF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<SelectionItem> _itemListUp;

	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<SelectionItem> _itemListDown;

	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<SelectionItem> _itemListRight;

	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<SelectionItem> _itemListLeft;

	[Token(Token = "0x1700034A")]
	private List<SelectionItem> itemListUp
	{
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034B")]
	private List<SelectionItem> itemListDown
	{
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034C")]
	private List<SelectionItem> itemListRight
	{
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034D")]
	private List<SelectionItem> itemListLeft
	{
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002024")]
	[Address(RVA = "0x638FF0", Offset = "0x6381F0", VA = "0x180638FF0")]
	public SelectionItem GetItem(PadInputDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6002025")]
	[Address(RVA = "0x639120", Offset = "0x638320", VA = "0x180639120")]
	public TransitionItemContainer()
	{
	}
}
