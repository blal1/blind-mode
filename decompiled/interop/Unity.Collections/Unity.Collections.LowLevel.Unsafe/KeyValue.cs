using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200007A")]
[DebuggerDisplay("Key = {Key}, Value = {Value}")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct KeyValue<TKey, TValue> where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x0")]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Index;

	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Next;

	[Token(Token = "0x1700004E")]
	public TKey Key
	{
		[Token(Token = "0x60001D8")]
		get
		{
			return (TKey)null;
		}
	}

	[Token(Token = "0x1700004F")]
	public unsafe ref TValue Value
	{
		[Token(Token = "0x60001D9")]
		get
		{
			return ref *(TValue*)null;
		}
	}
}
