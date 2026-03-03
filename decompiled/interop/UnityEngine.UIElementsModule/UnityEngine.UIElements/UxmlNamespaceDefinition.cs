using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004BA")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct UxmlNamespaceDefinition : IEquatable<UxmlNamespaceDefinition>
{
	[Token(Token = "0x4000F65")]
	[FieldOffset(Offset = "0x0")]
	public string prefix;

	[Token(Token = "0x4000F66")]
	[FieldOffset(Offset = "0x8")]
	public string resolvedNamespace;

	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x2A1DF20", Offset = "0x2A1D120", VA = "0x182A1DF20")]
	public static bool operator ==(UxmlNamespaceDefinition lhs, UxmlNamespaceDefinition rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x2A1DDC0", Offset = "0x2A1CFC0", VA = "0x182A1DDC0", Slot = "4")]
	public bool Equals(UxmlNamespaceDefinition other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x2A1DC90", Offset = "0x2A1CE90", VA = "0x182A1DC90", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x2A1DE70", Offset = "0x2A1D070", VA = "0x182A1DE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
