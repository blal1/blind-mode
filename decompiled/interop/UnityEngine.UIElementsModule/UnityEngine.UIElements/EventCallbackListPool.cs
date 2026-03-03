using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001D4")]
internal class EventCallbackListPool
{
	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0x10")]
	private readonly Stack<EventCallbackList> m_Stack;

	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x2B12180", Offset = "0x2B11380", VA = "0x182B12180")]
	public EventCallbackList Get(EventCallbackList initializer)
	{
		return null;
	}

	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x2B12350", Offset = "0x2B11550", VA = "0x182B12350")]
	public void Release(EventCallbackList element)
	{
	}

	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x2B123D0", Offset = "0x2B115D0", VA = "0x182B123D0")]
	public EventCallbackListPool()
	{
	}
}
