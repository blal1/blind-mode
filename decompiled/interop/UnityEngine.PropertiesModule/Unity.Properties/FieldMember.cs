using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200001E")]
internal readonly struct FieldMember : IMemberInfo
{
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x0")]
	internal readonly FieldInfo m_FieldInfo;

	[Token(Token = "0x17000018")]
	public string Name
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000019")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x28D8840", Offset = "0x28D7A40", VA = "0x1828D8840", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001A")]
	public Type ValueType
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x28D8860", Offset = "0x28D7A60", VA = "0x1828D8860", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x28D8810", Offset = "0x28D7A10", VA = "0x1828D8810")]
	public FieldMember(FieldInfo fieldInfo)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x28D87C0", Offset = "0x28D79C0", VA = "0x1828D87C0", Slot = "7")]
	public object GetValue(object obj)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x28D87F0", Offset = "0x28D79F0", VA = "0x1828D87F0", Slot = "8")]
	public void SetValue(object obj, object value)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x28D87B0", Offset = "0x28D79B0", VA = "0x1828D87B0", Slot = "9")]
	public IEnumerable<Attribute> GetCustomAttributes()
	{
		return null;
	}
}
