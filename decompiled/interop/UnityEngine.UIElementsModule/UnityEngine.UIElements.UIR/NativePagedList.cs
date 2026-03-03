using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000553")]
internal class NativePagedList<T> : IDisposable where T : struct
{
	[Token(Token = "0x2000554")]
	public struct Enumerator
	{
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x0")]
		private NativePagedList<T> m_NativePagedList;

		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x0")]
		private NativeArray<T> m_CurrentPage;

		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x0")]
		private int m_IndexInCurrentPage;

		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x0")]
		private int m_IndexOfCurrentPage;

		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x0")]
		private int m_CountInCurrentPage;

		[Token(Token = "0x60025CB")]
		public Enumerator(NativePagedList<T> nativePagedList, int offset)
		{
		}

		[Token(Token = "0x60025CC")]
		public bool HasNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60025CD")]
		public T GetNext()
		{
			return (T)null;
		}
	}

	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x0")]
	private readonly int k_PoolCapacity;

	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x0")]
	private List<NativeArray<T>> m_Pages;

	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x0")]
	private NativeArray<T> m_LastPage;

	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0x0")]
	private int m_CountInLastPage;

	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x0")]
	private Allocator m_FirstPageAllocator;

	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x0")]
	private Allocator m_OtherPagesAllocator;

	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x0")]
	private List<NativeSlice<T>> m_Enumerator;

	[Token(Token = "0x1700099D")]
	protected bool disposed
	{
		[Token(Token = "0x60025C7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60025C8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60025C1")]
	public NativePagedList(int poolCapacity, Allocator firstPageAllocator = Allocator.Persistent, Allocator otherPagesAllocator = Allocator.Persistent)
	{
	}

	[Token(Token = "0x60025C2")]
	public void Add(ref T data)
	{
	}

	[Token(Token = "0x60025C3")]
	public void Add(T data)
	{
	}

	[Token(Token = "0x60025C4")]
	public List<NativeSlice<T>> GetPages()
	{
		return null;
	}

	[Token(Token = "0x60025C5")]
	public int GetCount()
	{
		return default(int);
	}

	[Token(Token = "0x60025C6")]
	public void Reset()
	{
	}

	[Token(Token = "0x60025C9")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60025CA")]
	protected void Dispose(bool disposing)
	{
	}
}
