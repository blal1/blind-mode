using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C4F")]
public class JsonPackShopAnalyzer : JsonObjectAanalyzerBase
{
	[Token(Token = "0x4009AB0")]
	[FieldOffset(Offset = "0x10")]
	public readonly JsonPackDrawAnalyzer draw;

	[Token(Token = "0x6004AF7")]
	[Address(RVA = "0x933F10", Offset = "0x933110", VA = "0x180933F10")]
	public JsonPackShopAnalyzer()
	{
	}
}
