using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002D2")]
public class NetworkChecker : BaseChecker
{
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "9")]
	public override ResTypeData GetResType(string path)
	{
		return null;
	}

	[Token(Token = "0x6001145")]
	[Address(RVA = "0xE6FF90", Offset = "0xE6F190", VA = "0x180E6FF90", Slot = "10")]
	public override ResTypeData GetResTypeSimpleCheck(string path)
	{
		return null;
	}

	[Token(Token = "0x6001146")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public NetworkChecker()
	{
	}
}
