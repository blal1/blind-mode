using Il2CppDummyDll;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B88")]
public interface IWidgetSourceItemButton
{
	[Token(Token = "0x17000975")]
	bool isPeriod
	{
		[Token(Token = "0x6004668")]
		get;
	}

	[Token(Token = "0x17000976")]
	int itemCategory
	{
		[Token(Token = "0x6004669")]
		get;
	}

	[Token(Token = "0x17000977")]
	int itemId
	{
		[Token(Token = "0x600466A")]
		get;
	}

	[Token(Token = "0x17000978")]
	int itemNum
	{
		[Token(Token = "0x600466B")]
		get;
	}
}
