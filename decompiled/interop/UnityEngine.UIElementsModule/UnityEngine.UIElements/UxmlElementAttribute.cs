using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004AB")]
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class UxmlElementAttribute : Attribute
{
	[Token(Token = "0x4000F5D")]
	[FieldOffset(Offset = "0x10")]
	public readonly string name;

	[Token(Token = "0x4000F5E")]
	[FieldOffset(Offset = "0x18")]
	public LibraryVisibility visibility;

	[Token(Token = "0x4000F5F")]
	[FieldOffset(Offset = "0x20")]
	internal readonly Type[] supportedChildTypes;

	[Token(Token = "0x600229B")]
	[Address(RVA = "0x2A1CC30", Offset = "0x2A1BE30", VA = "0x182A1CC30")]
	public UxmlElementAttribute(string uxmlName)
	{
	}

	[Token(Token = "0x600229C")]
	[Address(RVA = "0x2A1CBD0", Offset = "0x2A1BDD0", VA = "0x182A1CBD0")]
	public UxmlElementAttribute(string uxmlName, params Type[] supportedTypes)
	{
	}
}
