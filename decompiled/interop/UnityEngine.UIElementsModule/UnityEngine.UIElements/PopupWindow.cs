using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000127")]
public class PopupWindow : TextElement
{
	[Token(Token = "0x2000128")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits>
	{
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x2AEF570", Offset = "0x2AEE770", VA = "0x182AEF570")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000129")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextElement.UxmlTraits
	{
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x2AD9980", Offset = "0x2AD8B80", VA = "0x182AD9980")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x5A8")]
	private VisualElement m_ContentContainer;

	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string contentUssClassName;

	[Token(Token = "0x1700018A")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x2AA9DB0", Offset = "0x2AA8FB0", VA = "0x182AA9DB0", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600092B")]
	[Address(RVA = "0x2ADCDB0", Offset = "0x2ADBFB0", VA = "0x182ADCDB0")]
	public PopupWindow()
	{
	}
}
