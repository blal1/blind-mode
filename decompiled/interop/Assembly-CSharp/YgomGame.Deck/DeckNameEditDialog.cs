using System;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.Deck;

[Token(Token = "0x20010C6")]
public class DeckNameEditDialog : SelectDialogViewControllerBase<string>
{
	[Token(Token = "0x400B19F")]
	private const string LABEL_TXT_HEADLINE = "TextHeadline";

	[Token(Token = "0x400B1A0")]
	private const string LABEL_EIF_NAMEFIELD = "SearchField";

	[Token(Token = "0x400B1A1")]
	private const string LABEL_TXT_INPUTFIELD = "TextName";

	[Token(Token = "0x400B1A2")]
	private const string LABEL_SBN_CONFIRMBUTTON = "SearchButton";

	[Token(Token = "0x400B1A3")]
	private const string PREFAB_PATH = "DeckEdit/DeckNameEditDialog";

	[Token(Token = "0x6006877")]
	[Address(RVA = "0xAD6790", Offset = "0xAD5990", VA = "0x180AD6790")]
	public static void Open(Action<string> callback)
	{
	}

	[Token(Token = "0x6006878")]
	[Address(RVA = "0xAD66C0", Offset = "0xAD58C0", VA = "0x180AD66C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006879")]
	[Address(RVA = "0xAD67E0", Offset = "0xAD59E0", VA = "0x180AD67E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600687A")]
	[Address(RVA = "0xAD68F0", Offset = "0xAD5AF0", VA = "0x180AD68F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600687B")]
	[Address(RVA = "0xAD6950", Offset = "0xAD5B50", VA = "0x180AD6950")]
	public DeckNameEditDialog()
	{
	}
}
