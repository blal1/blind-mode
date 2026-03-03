using Il2CppDummyDll;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001415")]
public interface IBinding
{
	[Token(Token = "0x6007CD0")]
	bool IsDone();

	[Token(Token = "0x6007CD1")]
	void ProgressUpdate();

	[Token(Token = "0x6007CD2")]
	void ReleaseResources();

	[Token(Token = "0x6007CD3")]
	void SourceChanged();
}
