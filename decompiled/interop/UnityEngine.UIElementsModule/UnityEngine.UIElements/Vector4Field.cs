using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000AF")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector4Field : BaseCompositeField<Vector4, FloatField, float>
{
	[Token(Token = "0x20000B0")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Vector4Field, UxmlTraits>
	{
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2AB5760", Offset = "0x2AB4960", VA = "0x182AB5760")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000B1")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Vector4>.UxmlTraits
	{
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x98")]
		private UxmlFloatAttributeDescription m_XValue;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_YValue;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlFloatAttributeDescription m_ZValue;

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlFloatAttributeDescription m_WValue;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2AB5B60", Offset = "0x2AB4D60", VA = "0x182AB5B60", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2AB8830", Offset = "0x2AB7A30", VA = "0x182AB8830")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x2ABC4A0", Offset = "0x2ABB6A0", VA = "0x182ABC4A0", Slot = "156")]
	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x2ABCDC0", Offset = "0x2ABBFC0", VA = "0x182ABCDC0")]
	public Vector4Field()
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x2ABCEE0", Offset = "0x2ABC0E0", VA = "0x182ABCEE0")]
	public Vector4Field(string label)
	{
	}
}
