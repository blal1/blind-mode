using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C52")]
public class JsonStructureAnalyzer : JsonObjectAanalyzerBase
{
	[Token(Token = "0x4009AB5")]
	[FieldOffset(Offset = "0x10")]
	public readonly JsonStructureMasterAnalyzer master;

	[Token(Token = "0x4009AB6")]
	[FieldOffset(Offset = "0x18")]
	public readonly JsonStructureFirstAnalyzer first;

	[Token(Token = "0x6004AFA")]
	[Address(RVA = "0x934040", Offset = "0x933240", VA = "0x180934040")]
	public JsonStructureAnalyzer()
	{
	}
}
