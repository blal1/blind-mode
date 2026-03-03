using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FB2")]
public static class CommonDialogDef
{
	[Token(Token = "0x2000FB3")]
	public enum ContentType
	{
		[Token(Token = "0x400AA56")]
		Title,
		[Token(Token = "0x400AA57")]
		Text,
		[Token(Token = "0x400AA58")]
		TextReplay,
		[Token(Token = "0x400AA59")]
		Image,
		[Token(Token = "0x400AA5A")]
		IconText,
		[Token(Token = "0x400AA5B")]
		ItemContent,
		[Token(Token = "0x400AA5C")]
		ItemList,
		[Token(Token = "0x400AA5D")]
		Button,
		[Token(Token = "0x400AA5E")]
		CheckBox,
		[Token(Token = "0x400AA5F")]
		ScrollText,
		[Token(Token = "0x400AA60")]
		Maintenance,
		[Token(Token = "0x400AA61")]
		InsertWidget
	}

	[Token(Token = "0x2000FB4")]
	public enum TitleIconType
	{
		[Token(Token = "0x400AA63")]
		Notice,
		[Token(Token = "0x400AA64")]
		Alert
	}
}
