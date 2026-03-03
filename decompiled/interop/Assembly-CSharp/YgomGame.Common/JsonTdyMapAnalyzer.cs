using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C51")]
public class JsonTdyMapAnalyzer : JsonObjectAanalyzerBase
{
	[Token(Token = "0x4009AB2")]
	[FieldOffset(Offset = "0x10")]
	public readonly long? _refTotalDuelCount;

	[Token(Token = "0x4009AB3")]
	[FieldOffset(Offset = "0x20")]
	public readonly Dictionary<int, long> _duelCntsByArea;

	[Token(Token = "0x4009AB4")]
	[FieldOffset(Offset = "0x28")]
	public readonly Dictionary<int, int> _circleLevelsByArea;

	[Token(Token = "0x6004AF9")]
	[Address(RVA = "0x934300", Offset = "0x933500", VA = "0x180934300")]
	public JsonTdyMapAnalyzer(object map)
	{
	}
}
