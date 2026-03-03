using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x200045B")]
public abstract class UIObjectPool<T> : IObjectPool<T>
{
	[Token(Token = "0x400154A")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<T> m_ActiveObjects;

	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x0")]
	private readonly Stack<T> m_UsableStack;

	[Token(Token = "0x6001C2A")]
	public void CreateReserve(int cnt)
	{
	}

	[Token(Token = "0x6001C2B")]
	public T Rent()
	{
		return (T)null;
	}

	[Token(Token = "0x6001C2C")]
	protected abstract T Create();

	[Token(Token = "0x6001C2D")]
	protected virtual void OnAfterCreate(T obj)
	{
	}

	[Token(Token = "0x6001C2E")]
	protected virtual void OnBeforeRent(T obj)
	{
	}

	[Token(Token = "0x6001C2F")]
	public void Return(T obj)
	{
	}

	[Token(Token = "0x6001C30")]
	protected virtual void OnBeforeReturn(T obj)
	{
	}

	[Token(Token = "0x6001C31")]
	public void ReturnAll()
	{
	}

	[Token(Token = "0x6001C32")]
	protected UIObjectPool()
	{
	}
}
