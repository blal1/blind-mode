using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x200009F")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class RectField : BaseCompositeField<Rect, FloatField, float>
{
	[Token(Token = "0x20000A0")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<RectField, UxmlTraits>
	{
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2AB5960", Offset = "0x2AB4B60", VA = "0x182AB5960")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000A1")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Rect>.UxmlTraits
	{
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x98")]
		private UxmlFloatAttributeDescription m_XValue;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_YValue;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlFloatAttributeDescription m_WValue;

		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlFloatAttributeDescription m_HValue;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2AB7330", Offset = "0x2AB6530", VA = "0x182AB7330", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2ABA0F0", Offset = "0x2AB92F0", VA = "0x182ABA0F0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x2AB2C70", Offset = "0x2AB1E70", VA = "0x182AB2C70", Slot = "156")]
	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x2AB3590", Offset = "0x2AB2790", VA = "0x182AB3590")]
	public RectField()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x2AB36D0", Offset = "0x2AB28D0", VA = "0x182AB36D0")]
	public RectField(string label)
	{
	}
}
