using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000284")]
internal class ObjectPool<T> where T : new()
{
	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x0")]
	private readonly Stack<T> m_Stack;

	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x0")]
	private int m_MaxSize;

	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x0")]
	internal Func<T> CreateFunc;

	[Token(Token = "0x17000335")]
	public int maxSize
	{
		[Token(Token = "0x6001156")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001157")]
		set
		{
		}
	}

	[Token(Token = "0x6001158")]
	public ObjectPool(Func<T> CreateFunc, int maxSize = 100)
	{
	}

	[Token(Token = "0x6001159")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x600115A")]
	public T Get()
	{
		return (T)null;
	}

	[Token(Token = "0x600115B")]
	public void Release(T element)
	{
	}
}
