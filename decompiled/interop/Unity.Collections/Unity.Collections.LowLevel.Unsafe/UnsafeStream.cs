using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000088")]
[GenerateTestsForBurstCompatibility]
public struct UnsafeStream : IDisposable
{
	[Token(Token = "0x2000089")]
	[BurstCompile]
	private struct DisposeJob : IJob
	{
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x0")]
		public UnsafeStream Container;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x22FC8F0", Offset = "0x22FBAF0", VA = "0x1822FC8F0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[BurstCompile]
	private struct ConstructJobList : IJob
	{
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x0")]
		public UnsafeStream Container;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UntypedUnsafeList* List;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x22FC8B0", Offset = "0x22FBAB0", VA = "0x1822FC8B0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[BurstCompile]
	private struct ConstructJob : IJob
	{
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x0")]
		public UnsafeStream Container;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<int> Length;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x22FC8E0", Offset = "0x22FBAE0", VA = "0x1822FC8E0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal AllocatorManager.Block m_BlockData;

	[Token(Token = "0x17000055")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x12CF0D0", Offset = "0x12CE2D0", VA = "0x1812CF0D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x22FDB80", Offset = "0x22FCD80", VA = "0x1822FDB80")]
	internal void AllocateForEach(int forEachCount)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x22FDC60", Offset = "0x22FCE60", VA = "0x1822FDC60")]
	private void Deallocate()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x22FCD50", Offset = "0x22FBF50", VA = "0x1822FCD50", Slot = "4")]
	public void Dispose()
	{
	}
}
