using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001B1")]
public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate>
{
	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x0")]
	private readonly EventDispatcher m_Dispatcher;

	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x2B157C0", Offset = "0x2B149C0", VA = "0x182B157C0")]
	public EventDispatcherGate(EventDispatcher d)
	{
	}

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x2B15710", Offset = "0x2B14910", VA = "0x182B15710", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x2A3ED20", Offset = "0x2A3DF20", VA = "0x182A3ED20", Slot = "5")]
	public bool Equals(EventDispatcherGate other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x2B15730", Offset = "0x2B14930", VA = "0x182B15730", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x29DC1C0", Offset = "0x29DB3C0", VA = "0x1829DC1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
