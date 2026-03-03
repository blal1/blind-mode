using Il2CppDummyDll;

namespace YgomGame.Download;

[Token(Token = "0x2000F6F")]
public enum DownloadStep
{
	[Token(Token = "0x400A824")]
	None,
	[Token(Token = "0x400A825")]
	DataCheck,
	[Token(Token = "0x400A826")]
	Downloading,
	[Token(Token = "0x400A827")]
	Error,
	[Token(Token = "0x400A828")]
	End
}
