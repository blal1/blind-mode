using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200001F")]
internal readonly struct PropertyMember : IMemberInfo
{
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x0")]
	internal readonly PropertyInfo m_PropertyInfo;

	[Token(Token = "0x1700001B")]
	public string Name
	{
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x28F19D0", Offset = "0x28F0BD0", VA = "0x1828F19D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public Type ValueType
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x28F1A00", Offset = "0x28F0C00", VA = "0x1828F1A00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x28D8810", Offset = "0x28D7A10", VA = "0x1828D8810")]
	public PropertyMember(PropertyInfo propertyInfo)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x28F1990", Offset = "0x28F0B90", VA = "0x1828F1990", Slot = "7")]
	public object GetValue(object obj)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x28F19B0", Offset = "0x28F0BB0", VA = "0x1828F19B0", Slot = "8")]
	public void SetValue(object obj, object value)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x28D87B0", Offset = "0x28D79B0", VA = "0x1828D87B0", Slot = "9")]
	public IEnumerable<Attribute> GetCustomAttributes()
	{
		return null;
	}
}
