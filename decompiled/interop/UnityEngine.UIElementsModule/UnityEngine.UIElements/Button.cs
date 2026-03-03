using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000099")]
public class Button : TextElement
{
	[Token(Token = "0x200009A")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Button, UxmlTraits>
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2AB5AA0", Offset = "0x2AB4CA0", VA = "0x182AB5AA0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200009B")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextElement.UxmlTraits
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly UxmlImageAttributeDescription m_IconImage;

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2ABA2E0", Offset = "0x2AB94E0", VA = "0x182ABA2E0")]
		public UxmlTraits()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2AB64E0", Offset = "0x2AB56E0", VA = "0x182AB64E0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId iconImageProperty;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static readonly string iconUssClassName;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static readonly string iconOnlyUssClassName;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static readonly string imageUSSClassName;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
	private Clickable m_Clickable;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
	private TextElement m_TextElement;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
	private Image m_ImageElement;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
	private Background m_IconImage;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
	private string m_Text;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static readonly string NonEmptyString;

	[Token(Token = "0x170000DE")]
	public Clickable clickable
	{
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2AA9DB0", Offset = "0x2AA8FB0", VA = "0x182AA9DB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2AA9E00", Offset = "0x2AA9000", VA = "0x182AA9E00")]
		set
		{
		}
	}

	[Token(Token = "0x170000DF")]
	[CreateProperty]
	public Background iconImage
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2AA9DC0", Offset = "0x2AA8FC0", VA = "0x182AA9DC0")]
		get
		{
			return default(Background);
		}
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2AA9E80", Offset = "0x2AA9080", VA = "0x182AA9E80")]
		set
		{
		}
	}

	[Token(Token = "0x170000E0")]
	public override string text
	{
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2AA9DE0", Offset = "0x2AA8FE0", VA = "0x182AA9DE0", Slot = "201")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2AAA250", Offset = "0x2AA9450", VA = "0x182AAA250", Slot = "202")]
		set
		{
		}
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x2AA99B0", Offset = "0x2AA8BB0", VA = "0x182AA99B0")]
	public Button()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x2AA9BA0", Offset = "0x2AA8DA0", VA = "0x182AA9BA0")]
	public Button(Background iconImage, [Optional] Action clickEvent)
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x2AA97D0", Offset = "0x2AA89D0", VA = "0x182AA97D0")]
	public Button(Action clickEvent)
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x2AA9120", Offset = "0x2AA8320", VA = "0x182AA9120")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x2AA9040", Offset = "0x2AA8240", VA = "0x182AA9040", Slot = "135")]
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x2AA9290", Offset = "0x2AA8490", VA = "0x182AA9290")]
	private void UpdateButtonHierarchy()
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x2AA9160", Offset = "0x2AA8360", VA = "0x182AA9160")]
	private void ResetButtonHierarchy()
	{
	}
}
