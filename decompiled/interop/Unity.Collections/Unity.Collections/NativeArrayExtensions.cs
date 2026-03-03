using System;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2000033")]
[GenerateTestsForBurstCompatibility]
public static class NativeArrayExtensions
{
	[Token(Token = "0x60000CA")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this NativeArray<T> array, U value) where T : struct, IEquatable<U>
	{
		return default(bool);
	}

	[Token(Token = "0x60000CB")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this NativeArray<T>.ReadOnly array, U value) where T : struct, IEquatable<U>
	{
		return default(bool);
	}

	[Token(Token = "0x60000CC")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public unsafe static int IndexOf<T, U>(void* ptr, int length, U value) where T : struct, IEquatable<U>
	{
		return default(int);
	}
}
