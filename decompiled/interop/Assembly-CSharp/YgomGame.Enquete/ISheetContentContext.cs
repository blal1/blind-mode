using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE4")]
public interface ISheetContentContext : IContext
{
	[Token(Token = "0x17000C46")]
	SheetContentType sheetContentType
	{
		[Token(Token = "0x60053B3")]
		get;
	}

	[Token(Token = "0x17000C47")]
	RootContext rootContext
	{
		[Token(Token = "0x60053B4")]
		get;
	}

	[Token(Token = "0x17000C48")]
	SheetContentGroupContext groupContext
	{
		[Token(Token = "0x60053B5")]
		get;
		[Token(Token = "0x60053B6")]
		set;
	}

	[Token(Token = "0x17000C49")]
	bool isInput
	{
		[Token(Token = "0x60053B7")]
		get;
	}
}
