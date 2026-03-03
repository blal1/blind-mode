using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Properties.Internal;

namespace Unity.Properties;

[Token(Token = "0x200000F")]
public readonly struct AttributesScope : IDisposable
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x0")]
	private readonly IAttributes m_Target;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x8")]
	private readonly List<Attribute> m_Previous;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x28D7AC0", Offset = "0x28D6CC0", VA = "0x1828D7AC0")]
	public AttributesScope(IProperty target, IProperty source)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x28D7A20", Offset = "0x28D6C20", VA = "0x1828D7A20")]
	internal AttributesScope(IAttributes target, List<Attribute> attributes)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x28D79D0", Offset = "0x28D6BD0", VA = "0x1828D79D0", Slot = "4")]
	public void Dispose()
	{
	}
}
