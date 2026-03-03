using System;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x200004B")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeParallelMultiHashMapIterator<TKey> where TKey : struct
{
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x0")]
	internal TKey key;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x0")]
	internal int NextEntryIndex;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x0")]
	internal int EntryIndex;
}
