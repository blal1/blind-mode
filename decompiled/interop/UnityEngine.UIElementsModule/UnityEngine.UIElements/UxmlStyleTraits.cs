using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000487")]
[Obsolete("UxmlStyleTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public class UxmlStyleTraits : UxmlTraits
{
	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x18")]
	private UxmlStringAttributeDescription m_Name;

	[Token(Token = "0x4000F24")]
	[FieldOffset(Offset = "0x20")]
	private UxmlStringAttributeDescription m_Path;

	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0x28")]
	private UxmlStringAttributeDescription m_Src;

	[Token(Token = "0x600222A")]
	[Address(RVA = "0x2A1F120", Offset = "0x2A1E320", VA = "0x182A1F120")]
	public UxmlStyleTraits()
	{
	}
}
