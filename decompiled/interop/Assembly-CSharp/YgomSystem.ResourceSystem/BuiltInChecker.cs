using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002CE")]
public class BuiltInChecker : BaseChecker
{
	[Token(Token = "0x4000F8A")]
	[FieldOffset(Offset = "0x10")]
	private ResourceExistsConvertData existsConvertData;

	[Token(Token = "0x6001128")]
	[Address(RVA = "0xE6BEB0", Offset = "0xE6B0B0", VA = "0x180E6BEB0", Slot = "9")]
	public override ResTypeData GetResType(string path)
	{
		return null;
	}

	[Token(Token = "0x6001129")]
	[Address(RVA = "0xE6BEB0", Offset = "0xE6B0B0", VA = "0x180E6BEB0", Slot = "10")]
	public override ResTypeData GetResTypeSimpleCheck(string path)
	{
		return null;
	}

	[Token(Token = "0x600112A")]
	[Address(RVA = "0xE6BE10", Offset = "0xE6B010", VA = "0x180E6BE10")]
	protected ResTypeData GetData(string path)
	{
		return null;
	}

	[Token(Token = "0x600112B")]
	[Address(RVA = "0xE6BEC0", Offset = "0xE6B0C0", VA = "0x180E6BEC0")]
	protected string GetResourcePath(string path)
	{
		return null;
	}

	[Token(Token = "0x600112C")]
	[Address(RVA = "0xE6BD70", Offset = "0xE6AF70", VA = "0x180E6BD70")]
	private bool ExistsConvertFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600112D")]
	[Address(RVA = "0xE6BDE0", Offset = "0xE6AFE0", VA = "0x180E6BDE0")]
	protected bool ExistsFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600112E")]
	[Address(RVA = "0xE6C1F0", Offset = "0xE6B3F0", VA = "0x180E6C1F0", Slot = "11")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600112F")]
	[Address(RVA = "0xE6BCE0", Offset = "0xE6AEE0", VA = "0x180E6BCE0", Slot = "12")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x6001130")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BuiltInChecker()
	{
	}
}
