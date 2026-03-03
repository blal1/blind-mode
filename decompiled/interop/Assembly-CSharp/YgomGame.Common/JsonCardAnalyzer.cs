using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C4B")]
public class JsonCardAnalyzer : JsonObjectAanalyzerBase
{
	[Token(Token = "0x6004AE9")]
	[Address(RVA = "0x933450", Offset = "0x932650", VA = "0x180933450")]
	public (List<object>, List<object>) ObjectToCardsData(object cardsData)
	{
		return default((List<object>, List<object>));
	}

	[Token(Token = "0x6004AEA")]
	[Address(RVA = "0x933350", Offset = "0x932550", VA = "0x180933350")]
	public (List<object>, List<object>) GetCardsData(object cardsData, string jsonPath)
	{
		return default((List<object>, List<object>));
	}

	[Token(Token = "0x6004AEB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public JsonCardAnalyzer()
	{
	}
}
