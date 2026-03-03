using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200053D")]
internal class ImplicitPool<T> where T : class
{
	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_StartCapacity;

	[Token(Token = "0x40011E5")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_MaxCapacity;

	[Token(Token = "0x40011E6")]
	[FieldOffset(Offset = "0x0")]
	private Func<T> m_CreateAction;

	[Token(Token = "0x40011E7")]
	[FieldOffset(Offset = "0x0")]
	private Action<T> m_ResetAction;

	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_List;

	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0x0")]
	private int m_UsedCount;

	[Token(Token = "0x6002558")]
	public ImplicitPool(Func<T> createAction, Action<T> resetAction, int startCapacity, int maxCapacity)
	{
	}

	[Token(Token = "0x6002559")]
	public T Get()
	{
		return null;
	}

	[Token(Token = "0x600255A")]
	public void ReturnAll()
	{
	}
}
