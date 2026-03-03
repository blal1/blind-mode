using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D12")]
public interface IMDMarkupItemWidget : IMDMarkupButtonWidget, IMDMarkupButtonContainWidget
{
	[Token(Token = "0x17000B41")]
	bool itemIsPeriod
	{
		[Token(Token = "0x6004EFD")]
		get;
	}

	[Token(Token = "0x17000B42")]
	int itemCategory
	{
		[Token(Token = "0x6004EFE")]
		get;
	}

	[Token(Token = "0x17000B43")]
	int itemId
	{
		[Token(Token = "0x6004EFF")]
		get;
	}
}
