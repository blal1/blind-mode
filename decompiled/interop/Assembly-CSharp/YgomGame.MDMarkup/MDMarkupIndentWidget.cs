using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CFA")]
public class MDMarkupIndentWidget
{
	[Token(Token = "0x4009D07")]
	[FieldOffset(Offset = "0x10")]
	public readonly Transform transform;

	[Token(Token = "0x4009D08")]
	[FieldOffset(Offset = "0x18")]
	public readonly int indent;

	[Token(Token = "0x6004E58")]
	[Address(RVA = "0x955B70", Offset = "0x954D70", VA = "0x180955B70")]
	public MDMarkupIndentWidget(Transform transform, int indent)
	{
	}
}
