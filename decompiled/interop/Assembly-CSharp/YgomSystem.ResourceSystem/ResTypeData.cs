using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002CF")]
public class ResTypeData
{
	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x10")]
	public Resource.Type resType;

	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x18")]
	public string crcPath;

	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0x20")]
	public string resourcePath;

	[Token(Token = "0x170001B9")]
	public uint crc
	{
		[Token(Token = "0x6001131")]
		[Address(RVA = "0xE76430", Offset = "0xE75630", VA = "0x180E76430")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6001132")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ResTypeData()
	{
	}
}
