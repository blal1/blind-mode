using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D16")]
public interface IMDMarkupLinkWidget : IMDMarkupButtonWidget, IMDMarkupButtonContainWidget
{
	[Token(Token = "0x17000B4E")]
	string link
	{
		[Token(Token = "0x6004F0A")]
		get;
	}
}
