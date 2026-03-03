using Il2CppDummyDll;

namespace System.Threading;

[Token(Token = "0x2000042")]
internal class ReaderWriterCount
{
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x10")]
	public long lockID;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x18")]
	public int readercount;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x1C")]
	public int writercount;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x20")]
	public int upgradecount;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x28")]
	public ReaderWriterCount next;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ReaderWriterCount()
	{
	}
}
