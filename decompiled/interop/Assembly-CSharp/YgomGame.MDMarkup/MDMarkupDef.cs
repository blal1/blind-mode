using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C58")]
public static class MDMarkupDef
{
	[Token(Token = "0x2000C59")]
	public enum ContainerType
	{
		[Token(Token = "0x4009AC7")]
		Board = 1,
		[Token(Token = "0x4009AC8")]
		Pager,
		[Token(Token = "0x4009AC9")]
		Tabs,
		[Token(Token = "0x4009ACA")]
		Embed,
		[Token(Token = "0x4009ACB")]
		BoardPager
	}

	[Token(Token = "0x2000C5A")]
	public enum ModifierType
	{
		[Token(Token = "0x4009ACD")]
		None,
		[Token(Token = "0x4009ACE")]
		StrFormatByArgs,
		[Token(Token = "0x4009ACF")]
		WriteJson
	}

	[Token(Token = "0x2000C5B")]
	public enum IdMatchType
	{
		[Token(Token = "0x4009AD1")]
		Equal,
		[Token(Token = "0x4009AD2")]
		Contains,
		[Token(Token = "0x4009AD3")]
		Regex
	}

	[Token(Token = "0x2000C5C")]
	public enum CloseButtonType
	{
		[Token(Token = "0x4009AD5")]
		None,
		[Token(Token = "0x4009AD6")]
		Always,
		[Token(Token = "0x4009AD7")]
		ReachLast
	}

	[Token(Token = "0x2000C5D")]
	public enum MarkupType
	{
		[Token(Token = "0x4009AD9")]
		None = 0,
		[Token(Token = "0x4009ADA")]
		H1 = 1,
		[Token(Token = "0x4009ADB")]
		H2 = 2,
		[Token(Token = "0x4009ADC")]
		Text = 3,
		[Token(Token = "0x4009ADD")]
		Image = 4,
		[Token(Token = "0x4009ADE")]
		Table = 5,
		[Token(Token = "0x4009ADF")]
		Separator = 6,
		[Token(Token = "0x4009AE0")]
		Spacer = 7,
		[Token(Token = "0x4009AE1")]
		HalfImageTextPage = 8,
		[Token(Token = "0x4009AE2")]
		HalfImageMarkupPage = 9,
		[Token(Token = "0x4009AE3")]
		HalfBannerMarkupPage = 10,
		[Token(Token = "0x4009AE4")]
		FullImagePage = 11,
		[Token(Token = "0x4009AE5")]
		FullTextPage = 12,
		[Token(Token = "0x4009AE6")]
		EmbedContainerTab = 13,
		[Token(Token = "0x4009AE7")]
		RawContainerTab = 14,
		[Token(Token = "0x4009AE8")]
		Generator = 50,
		[Token(Token = "0x4009AE9")]
		Reference = 51,
		[Token(Token = "0x4009AEA")]
		CustomBoardPageHandler = 100
	}

	[Token(Token = "0x2000C5E")]
	public enum TableRowStyle
	{
		[Token(Token = "0x4009AEC")]
		Normal,
		[Token(Token = "0x4009AED")]
		Header
	}

	[Token(Token = "0x2000C5F")]
	public enum TableCellValueType
	{
		[Token(Token = "0x4009AEF")]
		Empty,
		[Token(Token = "0x4009AF0")]
		Text,
		[Token(Token = "0x4009AF1")]
		Image,
		[Token(Token = "0x4009AF2")]
		Card,
		[Token(Token = "0x4009AF3")]
		Item,
		[Token(Token = "0x4009AF4")]
		Banner,
		[Token(Token = "0x4009AF5")]
		Button,
		[Token(Token = "0x4009AF6")]
		Table
	}

	[Token(Token = "0x2000C60")]
	public enum CardSize
	{
		[Token(Token = "0x4009AF8")]
		S,
		[Token(Token = "0x4009AF9")]
		M,
		[Token(Token = "0x4009AFA")]
		L
	}

	[Token(Token = "0x2000C61")]
	public enum ItemSize
	{
		[Token(Token = "0x4009AFC")]
		S,
		[Token(Token = "0x4009AFD")]
		M,
		[Token(Token = "0x4009AFE")]
		L
	}

	[Token(Token = "0x2000C62")]
	public enum SpacerSize
	{
		[Token(Token = "0x4009B00")]
		S,
		[Token(Token = "0x4009B01")]
		M,
		[Token(Token = "0x4009B02")]
		L
	}

	[Token(Token = "0x2000C63")]
	public enum ButtonStyle
	{
		[Token(Token = "0x4009B04")]
		S,
		[Token(Token = "0x4009B05")]
		M,
		[Token(Token = "0x4009B06")]
		L
	}
}
