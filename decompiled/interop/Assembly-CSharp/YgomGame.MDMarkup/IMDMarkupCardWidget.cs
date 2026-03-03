using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D14")]
public interface IMDMarkupCardWidget : IMDMarkupButtonWidget, IMDMarkupButtonContainWidget
{
	[Token(Token = "0x17000B45")]
	int cardMrk
	{
		[Token(Token = "0x6004F01")]
		get;
	}

	[Token(Token = "0x17000B46")]
	int cardPremire
	{
		[Token(Token = "0x6004F02")]
		get;
	}

	[Token(Token = "0x17000B47")]
	int overrideRarity
	{
		[Token(Token = "0x6004F03")]
		get;
	}

	[Token(Token = "0x17000B48")]
	int overrideLimitState
	{
		[Token(Token = "0x6004F04")]
		get;
	}

	[Token(Token = "0x17000B49")]
	int overridePrevLimitState
	{
		[Token(Token = "0x6004F05")]
		get;
	}

	[Token(Token = "0x17000B4A")]
	bool showNoneLimitState
	{
		[Token(Token = "0x6004F06")]
		get;
	}

	[Token(Token = "0x17000B4B")]
	bool showPrevLimitState
	{
		[Token(Token = "0x6004F07")]
		get;
	}

	[Token(Token = "0x17000B4C")]
	string cardBottomText
	{
		[Token(Token = "0x6004F08")]
		get;
	}
}
