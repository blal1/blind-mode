using Il2CppDummyDll;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B87")]
public interface IWidgetSourceSelectable : IWidgetSource
{
	[Token(Token = "0x17000974")]
	bool isSelectable
	{
		[Token(Token = "0x6004667")]
		get;
	}
}
