using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements;

[Token(Token = "0x200029F")]
internal class UIRAtlasAllocator : IDisposable
{
	[Token(Token = "0x20002A0")]
	private class Row
	{
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<Row> s_Pool;

		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x20")]
		public int Cursor;

		[Token(Token = "0x1700037D")]
		public int offsetX
		{
			[Token(Token = "0x6001250")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001251")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700037E")]
		public int offsetY
		{
			[Token(Token = "0x6001252")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001253")]
			[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700037F")]
		public int width
		{
			[Token(Token = "0x6001254")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001255")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000380")]
		private int height
		{
			[Token(Token = "0x6001256")]
			[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6001257")]
		[Address(RVA = "0x2B6C710", Offset = "0x2B6B910", VA = "0x182B6C710")]
		public static Row Acquire(int offsetX, int offsetY, int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6001258")]
		[Address(RVA = "0x2B6C7D0", Offset = "0x2B6B9D0", VA = "0x182B6C7D0")]
		public void Release()
		{
		}

		[Token(Token = "0x6001259")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Row()
		{
		}
	}

	[Token(Token = "0x20002A2")]
	private class AreaNode
	{
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<AreaNode> s_Pool;

		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x10")]
		public RectInt rect;

		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x20")]
		public AreaNode previous;

		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x28")]
		public AreaNode next;

		[Token(Token = "0x600125E")]
		[Address(RVA = "0x2B596F0", Offset = "0x2B588F0", VA = "0x182B596F0")]
		public static AreaNode Acquire(RectInt rect)
		{
			return null;
		}

		[Token(Token = "0x600125F")]
		[Address(RVA = "0x2B59890", Offset = "0x2B58A90", VA = "0x182B59890")]
		public void Release()
		{
		}

		[Token(Token = "0x6001260")]
		[Address(RVA = "0x2B59910", Offset = "0x2B58B10", VA = "0x182B59910")]
		public void RemoveFromChain()
		{
		}

		[Token(Token = "0x6001261")]
		[Address(RVA = "0x2B597B0", Offset = "0x2B589B0", VA = "0x182B597B0")]
		public void AddAfter(AreaNode previous)
		{
		}

		[Token(Token = "0x6001262")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AreaNode()
		{
		}
	}

	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x30")]
	private AreaNode m_FirstUnpartitionedArea;

	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x38")]
	private Row[] m_OpenRows;

	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x40")]
	private int m_1SidePadding;

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x44")]
	private int m_2SidePadding;

	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x0")]
	private static ProfilerMarker s_MarkerTryAllocate;

	[Token(Token = "0x17000375")]
	public int maxAtlasSize
	{
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000376")]
	public int maxImageWidth
	{
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000377")]
	public int maxImageHeight
	{
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000378")]
	public int virtualWidth
	{
		[Token(Token = "0x600123E")]
		[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000379")]
	public int virtualHeight
	{
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700037A")]
	public int physicalWidth
	{
		[Token(Token = "0x6001242")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001243")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700037B")]
	public int physicalHeight
	{
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700037C")]
	protected bool disposed
	{
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6001248")]
	[Address(RVA = "0x2B6F3F0", Offset = "0x2B6E5F0", VA = "0x182B6F3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6001249")]
	[Address(RVA = "0x2B6F2A0", Offset = "0x2B6E4A0", VA = "0x182B6F2A0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x600124A")]
	[Address(RVA = "0x2B6F460", Offset = "0x2B6E660", VA = "0x182B6F460")]
	private static int GetLog2OfNextPower(int n)
	{
		return default(int);
	}

	[Token(Token = "0x600124B")]
	[Address(RVA = "0x2B6FB50", Offset = "0x2B6ED50", VA = "0x182B6FB50")]
	public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1)
	{
	}

	[Token(Token = "0x600124C")]
	[Address(RVA = "0x2B6F4F0", Offset = "0x2B6E6F0", VA = "0x182B6F4F0")]
	public bool TryAllocate(int width, int height, out RectInt location)
	{
		return default(bool);
	}

	[Token(Token = "0x600124D")]
	[Address(RVA = "0x2B6F880", Offset = "0x2B6EA80", VA = "0x182B6F880")]
	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth)
	{
		return default(bool);
	}

	[Token(Token = "0x600124E")]
	[Address(RVA = "0x2B6F1C0", Offset = "0x2B6E3C0", VA = "0x182B6F1C0")]
	private void BuildAreas()
	{
	}
}
