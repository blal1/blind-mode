using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Movie;

[Serializable]
[Token(Token = "0x20016D5")]
public struct SubtitleInfo
{
	[Token(Token = "0x400D8D6")]
	[FieldOffset(Offset = "0x0")]
	[TextArea]
	public string subtitle;

	[Token(Token = "0x400D8D7")]
	[FieldOffset(Offset = "0x8")]
	public string comment;

	[Token(Token = "0x400D8D8")]
	[FieldOffset(Offset = "0x10")]
	public TextType textType;

	[Token(Token = "0x6008E1B")]
	[Address(RVA = "0xDA55E0", Offset = "0xDA47E0", VA = "0x180DA55E0")]
	public SubtitleInfo(string subtitle, string comment, TextType textType)
	{
	}
}
