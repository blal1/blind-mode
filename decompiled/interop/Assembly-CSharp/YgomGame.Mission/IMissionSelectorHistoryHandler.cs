using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000BFE")]
public interface IMissionSelectorHistoryHandler
{
	[Token(Token = "0x170009D7")]
	bool isSelected
	{
		[Token(Token = "0x6004911")]
		get;
	}

	[Token(Token = "0x6004912")]
	void SaveSelectorHistory();

	[Token(Token = "0x6004913")]
	bool TrySelectHistory();
}
