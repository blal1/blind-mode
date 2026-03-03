using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x200001B")]
[GenerateTestsForBurstCompatibility]
internal struct FixedList
{
	[MethodImpl(256)]
	[Token(Token = "0x6000044")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	internal static int PaddingBytes<T>() where T : struct
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000045")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal static int StorageBytes<BUFFER, T>() where BUFFER : struct where T : struct
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000046")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal static int Capacity<BUFFER, T>() where BUFFER : struct where T : struct
	{
		return default(int);
	}
}
