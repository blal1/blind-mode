using System;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000069")]
[GenerateTestsForBurstCompatibility]
public static class NativeListUnsafeUtility
{
	[Token(Token = "0x600017B")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static T* GetUnsafePtr<T>(this NativeList<T> list) where T : struct
	{
		//IL_0002: Expected I, but got O
		return (T*)unchecked((nint)null);
	}

	[Token(Token = "0x600017C")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static T* GetUnsafeReadOnlyPtr<T>(this NativeList<T> list) where T : struct
	{
		//IL_0002: Expected I, but got O
		return (T*)unchecked((nint)null);
	}
}
