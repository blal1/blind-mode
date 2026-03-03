using Il2CppDummyDll;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200140B")]
public interface IAsyncProgressContent
{
	[Token(Token = "0x6007CA7")]
	bool IsDone();

	[Token(Token = "0x6007CA8")]
	void ProgressUpdate();
}
