using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200007B")]
internal struct UnsafeParallelHashMapDataEnumerator
{
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x8")]
	internal int m_Index;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0xC")]
	internal int m_BucketIndex;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x10")]
	internal int m_NextIndex;

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1997470", Offset = "0x1996670", VA = "0x181997470")]
	internal unsafe UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x22FD740", Offset = "0x22FC940", VA = "0x1822FD740")]
	internal bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1994990", Offset = "0x1993B90", VA = "0x181994990")]
	internal void Reset()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60001DD")]
	internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>() where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(KeyValue<TKey, TValue>);
	}
}
