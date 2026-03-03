using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200008D")]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
public struct UnsafeText : IDisposable, IUTF8Bytes, INativeList<byte>, IIndexable<byte>
{
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x0")]
	internal UntypedUnsafeList m_UntypedListData;

	[Token(Token = "0x17000056")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x22FE000", Offset = "0x22FD200", VA = "0x1822FE000")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000057")]
	public readonly int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x22FE060", Offset = "0x22FD260", VA = "0x1822FE060", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x22FDE80", Offset = "0x22FD080", VA = "0x1822FDE80")]
	internal unsafe static void Free(UnsafeText* data)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x22FDE20", Offset = "0x22FD020", VA = "0x1822FDE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740", Slot = "5")]
	public unsafe byte* GetUnsafePtr()
	{
		//IL_0002: Expected I, but got O
		return (byte*)unchecked((nint)null);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x22FDF60", Offset = "0x22FD160", VA = "0x1822FDF60", Slot = "3")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public override string ToString()
	{
		return null;
	}
}
