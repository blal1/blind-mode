using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000F5")]
public class Label : TextElement
{
	[Token(Token = "0x20000F6")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Label, UxmlTraits>
	{
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2AD8B90", Offset = "0x2AD7D90", VA = "0x182AD8B90")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000F7")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextElement.UxmlTraits
	{
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2AD9980", Offset = "0x2AD8B80", VA = "0x182AD9980")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x2ACDBC0", Offset = "0x2ACCDC0", VA = "0x182ACDBC0")]
	public Label()
	{
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x2ACDB10", Offset = "0x2ACCD10", VA = "0x182ACDB10")]
	public Label(string text)
	{
	}
}
