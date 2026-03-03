using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D18")]
public interface IMDMarkupAsyncWidget
{
	[Token(Token = "0x17000B50")]
	bool isReady
	{
		[Token(Token = "0x6004F0C")]
		get;
	}

	[Token(Token = "0x6004F0D")]
	void OnReady();
}
