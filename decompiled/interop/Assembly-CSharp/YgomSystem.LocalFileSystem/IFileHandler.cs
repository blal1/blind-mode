using System.IO;
using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002F6")]
public interface IFileHandler
{
	[Token(Token = "0x170001DB")]
	bool isValid
	{
		[Token(Token = "0x6001266")]
		get;
	}

	[Token(Token = "0x6001264")]
	bool Open(string nativePath, StreamOpenMode openMode);

	[Token(Token = "0x6001265")]
	void Close();

	[Token(Token = "0x6001267")]
	int Write(byte[] data, int offset, int count);

	[Token(Token = "0x6001268")]
	int Read(byte[] buffer, int offset, int count);

	[Token(Token = "0x6001269")]
	long Seek(long offset, SeekOrigin origin);

	[Token(Token = "0x600126A")]
	long GetSeek();

	[Token(Token = "0x600126B")]
	long GetSize();

	[Token(Token = "0x600126C")]
	long SetSize(long size);

	[Token(Token = "0x600126D")]
	bool Flush();
}
