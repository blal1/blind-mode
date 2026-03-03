using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DiceRallyMapEditor;

[Token(Token = "0x2000141")]
public class DropOutStack<T>
{
	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x0")]
	private readonly LinkedList<T> _items;

	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x0")]
	private readonly int _capacity;

	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x0")]
	public Action<DropOutStack<T>> onChanged;

	[Token(Token = "0x170000E0")]
	public int Count
	{
		[Token(Token = "0x6000818")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000E1")]
	public int Capacity
	{
		[Token(Token = "0x6000819")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000814")]
	public DropOutStack(int capacity)
	{
	}

	[Token(Token = "0x6000815")]
	public void Push(T item)
	{
	}

	[Token(Token = "0x6000816")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x6000817")]
	public void Clear()
	{
	}
}
