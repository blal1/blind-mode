using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x2000714")]
public static class TitleDemoInfo
{
	[Token(Token = "0x400235A")]
	[FieldOffset(Offset = "0x0")]
	private static int s_index;

	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0x723030", Offset = "0x722230", VA = "0x180723030")]
	private static List<string> readFromCleintWork()
	{
		return null;
	}

	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x722F90", Offset = "0x722190", VA = "0x180722F90")]
	public static bool IsExistsScenarioData()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x722DE0", Offset = "0x721FE0", VA = "0x180722DE0")]
	public static string FetchScenarioID()
	{
		return null;
	}
}
