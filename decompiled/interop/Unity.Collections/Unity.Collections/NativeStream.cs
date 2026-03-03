using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x200005A")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
public struct NativeStream : IDisposable
{
	[Token(Token = "0x200005B")]
	[BurstCompile]
	private struct ConstructJobList : IJob
	{
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x0")]
		public NativeStream Container;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UntypedUnsafeList* List;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x22FC8B0", Offset = "0x22FBAB0", VA = "0x1822FC8B0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x200005C")]
	[BurstCompile]
	private struct ConstructJob : IJob
	{
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x0")]
		public NativeStream Container;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<int> Length;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x22FC8E0", Offset = "0x22FBAE0", VA = "0x1822FC8E0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x0")]
	private UnsafeStream m_Stream;

	[Token(Token = "0x1700003F")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x12CF0D0", Offset = "0x12CE2D0", VA = "0x1812CF0D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x22FCD50", Offset = "0x22FBF50", VA = "0x1822FCD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x22FCD60", Offset = "0x22FBF60", VA = "0x1822FCD60")]
	private void AllocateForEach(int forEachCount)
	{
	}
}
