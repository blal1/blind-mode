using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000587")]
internal class ManagedObjectStore<T> where T : class
{
	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0x0")]
	private int m_Length;

	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<T[]> m_Chunks;

	[Token(Token = "0x40013CD")]
	[FieldOffset(Offset = "0x0")]
	private readonly Queue<int> m_Free;

	[Token(Token = "0x60026F0")]
	public ManagedObjectStore()
	{
	}

	[Token(Token = "0x60026F1")]
	public T GetValue(int index)
	{
		return null;
	}

	[Token(Token = "0x60026F2")]
	public void UpdateValue(ref int index, T value)
	{
	}
}
