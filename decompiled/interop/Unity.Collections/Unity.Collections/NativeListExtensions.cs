using System;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2000045")]
[GenerateTestsForBurstCompatibility]
public static class NativeListExtensions
{
	[Token(Token = "0x600010E")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this NativeList<T> list, U value) where T : struct, IEquatable<U>
	{
		return default(bool);
	}
}
