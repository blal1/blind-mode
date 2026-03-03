using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004EB")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class EventInterestAttribute : Attribute
{
	[Token(Token = "0x4001030")]
	[FieldOffset(Offset = "0x10")]
	internal Type[] eventTypes;

	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x18")]
	internal EventCategoryFlags categoryFlags;

	[Token(Token = "0x6002391")]
	[Address(RVA = "0x2A30DB0", Offset = "0x2A2FFB0", VA = "0x182A30DB0")]
	public EventInterestAttribute(params Type[] eventTypes)
	{
	}

	[Token(Token = "0x6002392")]
	[Address(RVA = "0x2A30D80", Offset = "0x2A2FF80", VA = "0x182A30D80")]
	public EventInterestAttribute(EventInterestOptions interests)
	{
	}

	[Token(Token = "0x6002393")]
	[Address(RVA = "0x2A30D80", Offset = "0x2A2FF80", VA = "0x182A30D80")]
	internal EventInterestAttribute(EventInterestOptionsInternal interests)
	{
	}
}
