using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000558")]
[RequireComponent(typeof(Text))]
public class TextHyphenation : MonoBehaviour
{
	[Token(Token = "0x4001A00")]
	[FieldOffset(Offset = "0x20")]
	private bool doCallbackProc;

	[Token(Token = "0x4001A01")]
	[FieldOffset(Offset = "0x21")]
	private bool doFirstWrap;

	[Token(Token = "0x4001A02")]
	[FieldOffset(Offset = "0x28")]
	private Text _Text;

	[Token(Token = "0x4001A03")]
	[FieldOffset(Offset = "0x30")]
	private string proctext;

	[Token(Token = "0x4001A04")]
	[FieldOffset(Offset = "0x38")]
	private string orgtext;

	[Token(Token = "0x4001A05")]
	[FieldOffset(Offset = "0x0")]
	private static SortedDictionary<char, bool> frontmap;

	[Token(Token = "0x4001A06")]
	[FieldOffset(Offset = "0x8")]
	private static SortedDictionary<char, bool> backmap;

	[Token(Token = "0x4001A07")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string RITCH_TEXT_REPLACE;

	[Token(Token = "0x4001A08")]
	[FieldOffset(Offset = "0x18")]
	private static readonly char[] HYP_FRONT;

	[Token(Token = "0x4001A09")]
	[FieldOffset(Offset = "0x20")]
	private static readonly char[] HYP_BACK;

	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x652C60", Offset = "0x651E60", VA = "0x180652C60")]
	private void DirtyLayoutCallback()
	{
	}

	[Token(Token = "0x60022BE")]
	[Address(RVA = "0x652B70", Offset = "0x651D70", VA = "0x180652B70")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x653620", Offset = "0x652820", VA = "0x180653620")]
	private void Update()
	{
	}

	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x652E70", Offset = "0x652070", VA = "0x180652E70")]
	private List<string> SplitWrap(string txt)
	{
		return null;
	}

	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x653660", Offset = "0x652860", VA = "0x180653660")]
	private string WrapText(float rectwidth)
	{
		return null;
	}

	[Token(Token = "0x60022C2")]
	[Address(RVA = "0x653C50", Offset = "0x652E50", VA = "0x180653C50")]
	public TextHyphenation()
	{
	}
}
