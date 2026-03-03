using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200029E")]
internal struct SafeHandleAccess
{
	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x0")]
	private IntPtr m_Handle;

	[Token(Token = "0x6001238")]
	[Address(RVA = "0xF789F0", Offset = "0xF77BF0", VA = "0x180F789F0")]
	public SafeHandleAccess(IntPtr ptr)
	{
	}

	[Token(Token = "0x6001239")]
	[Address(RVA = "0x2B6C980", Offset = "0x2B6BB80", VA = "0x182B6C980")]
	public bool IsNull()
	{
		return default(bool);
	}

	[Token(Token = "0x600123A")]
	[Address(RVA = "0x2B6C990", Offset = "0x2B6BB90", VA = "0x182B6C990")]
	public static implicit operator IntPtr(SafeHandleAccess a)
	{
		return default(IntPtr);
	}
}
