using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002DF")]
public class EntryItem
{
	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0x10")]
	public bool isDir;

	[Token(Token = "0x4000FC4")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000FC5")]
	[FieldOffset(Offset = "0x20")]
	public string path;

	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x28")]
	public Storage storage;

	[Token(Token = "0x6001181")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public EntryItem()
	{
	}
}
