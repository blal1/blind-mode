using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200052A")]
internal class Page : IDisposable
{
	[Token(Token = "0x200052B")]
	public class DataSet<T> : IDisposable where T : struct
	{
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x0")]
		public Utility.GPUBuffer<T> gpuData;

		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<T> cpuData;

		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<GfxUpdateBufferRange> updateRanges;

		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x0")]
		public GPUBufferAllocator allocator;

		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x0")]
		private readonly uint m_UpdateRangePoolSize;

		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x0")]
		private uint m_ElemStride;

		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x0")]
		private uint m_UpdateRangeMin;

		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x0")]
		private uint m_UpdateRangeMax;

		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x0")]
		private uint m_UpdateRangesEnqueued;

		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x0")]
		private uint m_UpdateRangesBatchStart;

		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x0")]
		private bool m_UpdateRangesSaturated;

		[Token(Token = "0x17000985")]
		protected bool disposed
		{
			[Token(Token = "0x60024EE")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60024EF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60024ED")]
		public DataSet(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer)
		{
		}

		[Token(Token = "0x60024F0")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60024F1")]
		public void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60024F2")]
		public void RegisterUpdate(uint start, uint size)
		{
		}

		[Token(Token = "0x60024F3")]
		private bool HasMappedBufferRange()
		{
			return default(bool);
		}

		[Token(Token = "0x60024F4")]
		public void SendUpdates()
		{
		}

		[Token(Token = "0x60024F5")]
		public void SendFullRange()
		{
		}

		[Token(Token = "0x60024F6")]
		public void SendPartialRanges()
		{
		}

		[Token(Token = "0x60024F7")]
		private void ResetUpdateState()
		{
		}
	}

	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x18")]
	public DataSet<Vertex> vertices;

	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x20")]
	public DataSet<ushort> indices;

	[Token(Token = "0x4001137")]
	[FieldOffset(Offset = "0x28")]
	public Page next;

	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x30")]
	public int framesEmpty;

	[Token(Token = "0x17000983")]
	protected bool disposed
	{
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000984")]
	public bool isEmpty
	{
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x2A534C0", Offset = "0x2A526C0", VA = "0x182A534C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x2A53360", Offset = "0x2A52560", VA = "0x182A53360")]
	public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage)
	{
	}

	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x2A532F0", Offset = "0x2A524F0", VA = "0x182A532F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60024EB")]
	[Address(RVA = "0x2A53260", Offset = "0x2A52460", VA = "0x182A53260", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}
}
