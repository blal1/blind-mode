using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002DC")]
public class StorageData
{
	[Token(Token = "0x4000FB6")]
	[FieldOffset(Offset = "0x10")]
	public Storage type;

	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000FB8")]
	[FieldOffset(Offset = "0x20")]
	public bool isWritable;

	[Token(Token = "0x6001179")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StorageData()
	{
	}
}
