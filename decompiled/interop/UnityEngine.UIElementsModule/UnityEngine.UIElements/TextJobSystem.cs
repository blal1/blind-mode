using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000459")]
internal class TextJobSystem
{
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x10")]
	internal UITKTextJobSystem m_UITKTextJobSystem;

	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0x18")]
	private ATGTextJobSystem m_ATGTextJobSystem;

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x29FF570", Offset = "0x29FE770", VA = "0x1829FF570")]
	internal void GenerateText(MeshGenerationContext mgc, TextElement textElement)
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TextJobSystem()
	{
	}
}
