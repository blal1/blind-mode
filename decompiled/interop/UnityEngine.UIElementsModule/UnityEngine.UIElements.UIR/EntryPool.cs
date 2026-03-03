using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000531")]
internal class EntryPool
{
	[Token(Token = "0x4001172")]
	private const int k_StackSize = 128;

	[Token(Token = "0x4001173")]
	[FieldOffset(Offset = "0x10")]
	private Stack<Entry>[] m_ThreadEntries;

	[Token(Token = "0x4001174")]
	[FieldOffset(Offset = "0x18")]
	private ImplicitPool<Entry> m_SharedPool;

	[Token(Token = "0x4001175")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Func<Entry> k_CreateAction;

	[Token(Token = "0x4001176")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Action<Entry> k_ResetAction;

	[Token(Token = "0x6002504")]
	[Address(RVA = "0x2A46E30", Offset = "0x2A46030", VA = "0x182A46E30")]
	public EntryPool(int maxCapacity = 1024)
	{
	}

	[Token(Token = "0x6002505")]
	[Address(RVA = "0x2A46990", Offset = "0x2A45B90", VA = "0x182A46990")]
	public Entry Get()
	{
		return null;
	}

	[Token(Token = "0x6002506")]
	[Address(RVA = "0x2A46C10", Offset = "0x2A45E10", VA = "0x182A46C10")]
	public void ReturnAll()
	{
	}
}
