using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000489")]
[Obsolete("UxmlTemplateTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public class UxmlTemplateTraits : UxmlTraits
{
	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x18")]
	private UxmlStringAttributeDescription m_Name;

	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x20")]
	private UxmlStringAttributeDescription m_Path;

	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x28")]
	private UxmlStringAttributeDescription m_Src;

	[Token(Token = "0x600222F")]
	[Address(RVA = "0x2A1F350", Offset = "0x2A1E550", VA = "0x182A1F350")]
	public UxmlTemplateTraits()
	{
	}
}
