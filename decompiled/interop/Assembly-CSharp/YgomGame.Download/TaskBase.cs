using Il2CppDummyDll;

namespace YgomGame.Download;

[Token(Token = "0x2000F80")]
public interface TaskBase
{
	[Token(Token = "0x6005E04")]
	bool IsDone();

	[Token(Token = "0x6005E05")]
	bool IsSuccess();

	[Token(Token = "0x6005E06")]
	bool IsError();

	[Token(Token = "0x6005E07")]
	void Exec();
}
