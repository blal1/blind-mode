using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000485")]
[Obsolete("UxmlRootElementTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public class UxmlRootElementTraits : UxmlTraits
{
	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x18")]
	protected UxmlStringAttributeDescription m_Name;

	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x20")]
	private UxmlStringAttributeDescription m_Class;

	[Token(Token = "0x6002225")]
	[Address(RVA = "0x2A1EB40", Offset = "0x2A1DD40", VA = "0x182A1EB40")]
	public UxmlRootElementTraits()
	{
	}
}
