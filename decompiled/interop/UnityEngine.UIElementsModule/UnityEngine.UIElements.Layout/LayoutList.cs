using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005AC")]
internal struct LayoutList<T> : IDisposable where T : struct
{
	[Token(Token = "0x20005AD")]
	private struct Data
	{
		[Token(Token = "0x4001475")]
		[FieldOffset(Offset = "0x0")]
		public int Capacity;

		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0x0")]
		public unsafe T* Values;
	}

	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x0")]
	private readonly Allocator m_Allocator;

	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x0")]
	private unsafe Data* m_Data;

	[Token(Token = "0x17000A1F")]
	public int Count
	{
		[Token(Token = "0x60027A7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A20")]
	public bool IsCreated
	{
		[Token(Token = "0x60027A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A21")]
	public unsafe ref T this[int index]
	{
		[Token(Token = "0x60027A9")]
		get
		{
			return ref *(T*)null;
		}
	}

	[Token(Token = "0x60027AA")]
	public LayoutList()
	{
	}

	[Token(Token = "0x60027AB")]
	public LayoutList(int initialCapacity, Allocator allocator)
	{
	}

	[Token(Token = "0x60027AC")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60027AD")]
	public void Insert(int index, T value)
	{
	}

	[Token(Token = "0x60027AE")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x60027AF")]
	private void IncreaseCapacity()
	{
	}

	[Token(Token = "0x60027B0")]
	private void EnsureCapacity(int capacity)
	{
	}

	[Token(Token = "0x60027B1")]
	private void ResizeCapacity(int capacity)
	{
	}

	[Token(Token = "0x60027B2")]
	private unsafe static void* ResizeArray(void* fromPtr, long fromCount, long toCount, long size, int align, Allocator allocator)
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}
}
