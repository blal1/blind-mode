using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056D")]
internal class TempAllocator<T> : IDisposable where T : struct
{
	[Token(Token = "0x200056E")]
	private struct Page
	{
		[Token(Token = "0x4001355")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<T> array;

		[Token(Token = "0x4001356")]
		[FieldOffset(Offset = "0x0")]
		public int used;
	}

	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_ExcessMinCapacity;

	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_ExcessMaxCapacity;

	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x0")]
	private Page m_Pool;

	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x0")]
	private List<Page> m_Excess;

	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x0")]
	private int m_NextExcessSize;

	[Token(Token = "0x170009C0")]
	protected bool disposed
	{
		[Token(Token = "0x6002674")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002675")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002673")]
	public TempAllocator(int poolCapacity, int excessMinCapacity, int excessMaxCapacity)
	{
	}

	[Token(Token = "0x6002676")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6002677")]
	protected void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6002678")]
	public NativeSlice<T> Alloc(int count)
	{
		return default(NativeSlice<T>);
	}

	[Token(Token = "0x6002679")]
	private NativeSlice<T> DoAlloc(int count)
	{
		return default(NativeSlice<T>);
	}

	[Token(Token = "0x600267A")]
	public void Reset()
	{
	}

	[Token(Token = "0x600267B")]
	private void ReleaseExcess()
	{
	}
}
