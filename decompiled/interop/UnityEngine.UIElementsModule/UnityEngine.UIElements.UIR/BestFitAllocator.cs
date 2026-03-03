using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000526")]
internal class BestFitAllocator
{
	[Token(Token = "0x2000527")]
	private class BlockPool : LinkedPool<Block>
	{
		[MethodImpl(256)]
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x2A460F0", Offset = "0x2A452F0", VA = "0x182A460F0")]
		private static Block CreateBlock()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private static void ResetBlock(Block block)
		{
		}

		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x2A46160", Offset = "0x2A45360", VA = "0x182A46160")]
		public BlockPool()
		{
		}
	}

	[Token(Token = "0x2000528")]
	private class Block : LinkedPoolItem<Block>
	{
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x18")]
		public uint start;

		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x1C")]
		public uint end;

		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x20")]
		public Block prev;

		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x28")]
		public Block next;

		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x30")]
		public Block prevAvailable;

		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x38")]
		public Block nextAvailable;

		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x40")]
		public bool allocated;

		[Token(Token = "0x17000981")]
		public uint size
		{
			[Token(Token = "0x60024E0")]
			[Address(RVA = "0x2A46280", Offset = "0x2A45480", VA = "0x182A46280")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x2A46240", Offset = "0x2A45440", VA = "0x182A46240")]
		public Block()
		{
		}
	}

	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x18")]
	private Block m_FirstBlock;

	[Token(Token = "0x4001128")]
	[FieldOffset(Offset = "0x20")]
	private Block m_FirstAvailableBlock;

	[Token(Token = "0x4001129")]
	[FieldOffset(Offset = "0x28")]
	private BlockPool m_BlockPool;

	[Token(Token = "0x400112A")]
	[FieldOffset(Offset = "0x30")]
	private uint m_HighWatermark;

	[Token(Token = "0x1700097F")]
	public uint totalSize
	{
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000980")]
	public uint highWatermark
	{
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x285E140", Offset = "0x285D340", VA = "0x18285E140")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x2A45F60", Offset = "0x2A45160", VA = "0x182A45F60")]
	public BestFitAllocator(uint size)
	{
	}

	[Token(Token = "0x60024D8")]
	[Address(RVA = "0x2A456E0", Offset = "0x2A448E0", VA = "0x182A456E0")]
	public Alloc Allocate(uint size)
	{
		return default(Alloc);
	}

	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x2A45B90", Offset = "0x2A44D90", VA = "0x182A45B90")]
	public void Free(Alloc alloc)
	{
	}

	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x2A45A50", Offset = "0x2A44C50", VA = "0x182A45A50")]
	private Block CoalesceBlockWithPrevious(Block block)
	{
		return null;
	}

	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x2A45A10", Offset = "0x2A44C10", VA = "0x182A45A10")]
	private Block BestFitFindAvailableBlock(uint size)
	{
		return null;
	}

	[Token(Token = "0x60024DC")]
	[Address(RVA = "0x2A45DF0", Offset = "0x2A44FF0", VA = "0x182A45DF0")]
	private void SplitBlock(Block block, uint size)
	{
	}
}
