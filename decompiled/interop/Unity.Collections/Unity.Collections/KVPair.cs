using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000038")]
[DebuggerDisplay("Key = {Key}, Value = {Value}")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct KVPair<TKey, TValue> where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x0")]
	internal unsafe HashMapHelper<TKey>* m_Data;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Index;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Next;

	[Token(Token = "0x1700002C")]
	public unsafe ref TValue Value
	{
		[Token(Token = "0x60000D1")]
		get
		{
			return ref *(TValue*)null;
		}
	}
}
