using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000544")]
internal class LinkedPool<T> where T : LinkedPoolItem<T>
{
	[Token(Token = "0x4001216")]
	[FieldOffset(Offset = "0x0")]
	private readonly Func<T> m_CreateFunc;

	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x0")]
	private readonly Action<T> m_ResetAction;

	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_Limit;

	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x0")]
	private T m_PoolFirst;

	[Token(Token = "0x17000994")]
	public int Count
	{
		[Token(Token = "0x600256F")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600256E")]
	public LinkedPool(Func<T> createFunc, Action<T> resetAction, int limit = 10000)
	{
	}

	[Token(Token = "0x6002571")]
	public void Clear()
	{
	}

	[Token(Token = "0x6002572")]
	public T Get()
	{
		return null;
	}

	[Token(Token = "0x6002573")]
	public void Return(T item)
	{
	}
}
