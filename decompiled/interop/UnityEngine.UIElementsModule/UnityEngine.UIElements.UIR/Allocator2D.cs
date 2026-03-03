using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000512")]
internal class Allocator2D
{
	[Token(Token = "0x2000513")]
	public class Area
	{
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x10")]
		public RectInt rect;

		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x20")]
		public BestFitAllocator allocator;

		[Token(Token = "0x6002473")]
		[Address(RVA = "0x2A29700", Offset = "0x2A28900", VA = "0x182A29700")]
		public Area(RectInt rect)
		{
		}
	}

	[Token(Token = "0x2000514")]
	public class Row : LinkedPoolItem<Row>
	{
		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x18")]
		public RectInt rect;

		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x28")]
		public Area area;

		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x30")]
		public BestFitAllocator allocator;

		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x38")]
		public Alloc alloc;

		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x50")]
		public Row next;

		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LinkedPool<Row> pool;

		[MethodImpl(256)]
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x2A321D0", Offset = "0x2A313D0", VA = "0x182A321D0")]
		private static Row Create()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x2A32240", Offset = "0x2A31440", VA = "0x182A32240")]
		private static void Reset(Row row)
		{
		}

		[Token(Token = "0x6002476")]
		[Address(RVA = "0x2A323D0", Offset = "0x2A315D0", VA = "0x182A323D0")]
		public Row()
		{
		}
	}

	[Token(Token = "0x2000515")]
	public struct Alloc2D
	{
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x0")]
		public RectInt rect;

		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x10")]
		public Row row;

		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x18")]
		public Alloc alloc;

		[Token(Token = "0x6002478")]
		[Address(RVA = "0x2A28770", Offset = "0x2A27970", VA = "0x182A28770")]
		public Alloc2D(Row row, Alloc alloc, int width, int height)
		{
		}
	}

	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x10")]
	private readonly Vector2Int m_MinSize;

	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0x18")]
	private readonly Vector2Int m_MaxSize;

	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0x20")]
	private readonly Vector2Int m_MaxAllocSize;

	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0x28")]
	private readonly int m_RowHeightBias;

	[Token(Token = "0x40010AA")]
	[FieldOffset(Offset = "0x30")]
	private readonly Row[] m_Rows;

	[Token(Token = "0x40010AB")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<Area> m_Areas;

	[Token(Token = "0x600246D")]
	[Address(RVA = "0x2A293F0", Offset = "0x2A285F0", VA = "0x182A293F0")]
	public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias)
	{
	}

	[Token(Token = "0x600246E")]
	[Address(RVA = "0x2A28EB0", Offset = "0x2A280B0", VA = "0x182A28EB0")]
	public bool TryAllocate(int width, int height, out Alloc2D alloc2D)
	{
		return default(bool);
	}

	[Token(Token = "0x600246F")]
	[Address(RVA = "0x2A28C40", Offset = "0x2A27E40", VA = "0x182A28C40")]
	public void Free(Alloc2D alloc2D)
	{
	}

	[Token(Token = "0x6002470")]
	[Address(RVA = "0x2A288B0", Offset = "0x2A27AB0", VA = "0x182A288B0")]
	private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize)
	{
	}

	[Token(Token = "0x6002471")]
	[Address(RVA = "0x2A28B60", Offset = "0x2A27D60", VA = "0x182A28B60")]
	private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias)
	{
		return default(Vector2Int);
	}

	[Token(Token = "0x6002472")]
	[Address(RVA = "0x2A28AF0", Offset = "0x2A27CF0", VA = "0x182A28AF0")]
	private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias)
	{
		return null;
	}
}
