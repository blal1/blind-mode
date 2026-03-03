using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CC8")]
public class MDMarkupIndentFactory
{
	[Token(Token = "0x4009C26")]
	internal const int k_EmptyIndent = -2;

	[Token(Token = "0x4009C27")]
	[FieldOffset(Offset = "0x10")]
	private readonly Transform[] m_IndentTemplates;

	[Token(Token = "0x6004D6A")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public MDMarkupIndentFactory(Transform[] indentTemplates)
	{
	}

	[Token(Token = "0x6004D6B")]
	[Address(RVA = "0x955A10", Offset = "0x954C10", VA = "0x180955A10")]
	public MDMarkupIndentWidget Create(int indent)
	{
		return null;
	}

	[Token(Token = "0x6004D6C")]
	[Address(RVA = "0x9559E0", Offset = "0x954BE0", VA = "0x1809559E0")]
	public MDMarkupIndentWidget Create(int indent, MDMarkupIndentWidget parent)
	{
		return null;
	}

	[Token(Token = "0x6004D6D")]
	[Address(RVA = "0x955A20", Offset = "0x954C20", VA = "0x180955A20")]
	public MDMarkupIndentWidget Create(int indent, Transform parent)
	{
		return null;
	}
}
