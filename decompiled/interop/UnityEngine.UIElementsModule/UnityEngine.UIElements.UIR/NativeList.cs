using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000552")]
internal class NativeList<T> : IDisposable where T : struct
{
	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x0")]
	private NativeArray<T> m_NativeArray;

	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x0")]
	private int m_Count;

	[Token(Token = "0x1700099B")]
	public int Count
	{
		[Token(Token = "0x60025BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700099C")]
	protected bool disposed
	{
		[Token(Token = "0x60025BD")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60025BE")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60025B7")]
	public NativeList(int initialCapacity)
	{
	}

	[Token(Token = "0x60025B8")]
	private void Expand(int newLength)
	{
	}

	[Token(Token = "0x60025B9")]
	public void Add(NativeSlice<T> src)
	{
	}

	[Token(Token = "0x60025BA")]
	public void Clear()
	{
	}

	[Token(Token = "0x60025BB")]
	public NativeSlice<T> GetSlice(int start, int length)
	{
		return default(NativeSlice<T>);
	}

	[Token(Token = "0x60025BF")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60025C0")]
	protected void Dispose(bool disposing)
	{
	}
}
