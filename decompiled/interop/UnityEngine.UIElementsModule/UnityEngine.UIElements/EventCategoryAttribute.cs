using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004EC")]
[AttributeUsage(AttributeTargets.Class)]
internal class EventCategoryAttribute : Attribute
{
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x10")]
	internal EventCategory category;

	[Token(Token = "0x6002394")]
	[Address(RVA = "0x65C4A0", Offset = "0x65B6A0", VA = "0x18065C4A0")]
	public EventCategoryAttribute(EventCategory category)
	{
	}
}
