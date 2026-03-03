using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000019")]
[GenerateTestsForBurstCompatibility]
public static class CollectionHelper
{
	[Token(Token = "0x200001A")]
	[BurstCompile]
	public struct DummyJob : IJob
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x22FC840", Offset = "0x22FBA40", VA = "0x1822FC840")]
	public static int Log2Floor(int value)
	{
		return default(int);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x22FC7F0", Offset = "0x22FB9F0", VA = "0x1822FC7F0")]
	public static int Align(int size, int alignmentPowerOfTwo)
	{
		return default(int);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x22FC810", Offset = "0x22FBA10", VA = "0x1822FC810")]
	public unsafe static uint Hash(void* ptr, int bytes)
	{
		return default(uint);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x22FC890", Offset = "0x22FBA90", VA = "0x1822FC890")]
	internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8FDA80", Offset = "0x8FCC80", VA = "0x1808FDA80")]
	internal static int AssumePositive(int value)
	{
		return default(int);
	}
}
