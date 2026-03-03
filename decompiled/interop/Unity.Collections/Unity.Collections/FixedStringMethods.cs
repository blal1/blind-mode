using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x200002C")]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
public static class FixedStringMethods
{
	[Token(Token = "0x60000BD")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public static string ConvertToString<T>(this ref T fs) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return null;
	}
}
