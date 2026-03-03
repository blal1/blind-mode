using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C50")]
public class JsonShopAnalyzer : JsonObjectAanalyzerBase
{
	[Token(Token = "0x4009AB1")]
	[FieldOffset(Offset = "0x10")]
	public readonly JsonPackShopAnalyzer pack;

	[Token(Token = "0x6004AF8")]
	[Address(RVA = "0x933F80", Offset = "0x933180", VA = "0x180933F80")]
	public JsonShopAnalyzer()
	{
	}
}
