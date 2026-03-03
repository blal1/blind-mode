using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Regulation;

[Token(Token = "0x2000B3B")]
public static class RegulationUtil
{
	[Token(Token = "0x400961C")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, string> c_cacheRegIDtoNameDic;

	[Token(Token = "0x60044D5")]
	[Address(RVA = "0x8F0750", Offset = "0x8EF950", VA = "0x1808F0750")]
	public static string GetRegulationName(int regulationID)
	{
		return null;
	}

	[Token(Token = "0x60044D6")]
	[Address(RVA = "0x8F08E0", Offset = "0x8EFAE0", VA = "0x1808F08E0")]
	private static void LoadRegulationNames(object value)
	{
	}

	[Token(Token = "0x60044D7")]
	[Address(RVA = "0x8F0F60", Offset = "0x8F0160", VA = "0x1808F0F60")]
	public static void SetNotificator()
	{
	}
}
