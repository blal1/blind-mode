using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003BC")]
internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData>
{
	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x0")]
	public Color color;

	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x10")]
	public Length fontSize;

	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x18")]
	public Length letterSpacing;

	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x20")]
	public TextShadow textShadow;

	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x3C")]
	public EditorTextRenderingMode unityEditorTextRenderingMode;

	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x40")]
	public Font unityFont;

	[Token(Token = "0x4000C48")]
	[FieldOffset(Offset = "0x48")]
	public FontDefinition unityFontDefinition;

	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x58")]
	public FontStyle unityFontStyleAndWeight;

	[Token(Token = "0x4000C4A")]
	[FieldOffset(Offset = "0x5C")]
	public Length unityParagraphSpacing;

	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x64")]
	public TextAnchor unityTextAlign;

	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x68")]
	public TextGeneratorType unityTextGenerator;

	[Token(Token = "0x4000C4D")]
	[FieldOffset(Offset = "0x6C")]
	public Color unityTextOutlineColor;

	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x7C")]
	public float unityTextOutlineWidth;

	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x80")]
	public Visibility visibility;

	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x84")]
	public WhiteSpace whiteSpace;

	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0x88")]
	public Length wordSpacing;

	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x29DD230", Offset = "0x29DC430", VA = "0x1829DD230", Slot = "4")]
	public InheritedData Copy()
	{
		return default(InheritedData);
	}

	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x29DD1A0", Offset = "0x29DC3A0", VA = "0x1829DD1A0", Slot = "5")]
	public void CopyFrom(ref InheritedData other)
	{
	}

	[Token(Token = "0x6001C76")]
	[Address(RVA = "0x29DD610", Offset = "0x29DC810", VA = "0x1829DD610")]
	public static bool operator ==(InheritedData lhs, InheritedData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x29DD280", Offset = "0x29DC480", VA = "0x1829DD280", Slot = "6")]
	public bool Equals(InheritedData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x29DD350", Offset = "0x29DC550", VA = "0x1829DD350", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x29DD450", Offset = "0x29DC650", VA = "0x1829DD450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
