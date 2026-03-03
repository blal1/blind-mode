using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C53")]
public class JsonStructureFirstAnalyzer : JsonObjectAanalyzerBase
{
	[Token(Token = "0x6004AFB")]
	[Address(RVA = "0x934140", Offset = "0x933340", VA = "0x180934140")]
	public bool IsReceivable(object structureFirstData)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AFC")]
	[Address(RVA = "0x9340E0", Offset = "0x9332E0", VA = "0x1809340E0")]
	public IReadOnlyList<object> GetSelectIds(object structureFirstData)
	{
		return null;
	}

	[Token(Token = "0x6004AFD")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public JsonStructureFirstAnalyzer()
	{
	}
}
