using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000094")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsIntField : BaseField<BoundsInt>
{
	[Token(Token = "0x2000095")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<BoundsIntField, UxmlTraits>
	{
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2AB58A0", Offset = "0x2AB4AA0", VA = "0x182AB58A0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<BoundsInt>.UxmlTraits
	{
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x98")]
		private UxmlIntAttributeDescription m_PositionXValue;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlIntAttributeDescription m_PositionYValue;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlIntAttributeDescription m_PositionZValue;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlIntAttributeDescription m_SizeXValue;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0xB8")]
		private UxmlIntAttributeDescription m_SizeYValue;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0xC0")]
		private UxmlIntAttributeDescription m_SizeZValue;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2AB7000", Offset = "0x2AB6200", VA = "0x182AB7000", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2AB9550", Offset = "0x2AB8750", VA = "0x182AB9550")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x548")]
	private Vector3IntField m_PositionField;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x550")]
	private Vector3IntField m_SizeField;

	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string positionUssClassName;

	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string sizeUssClassName;

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x2AA8810", Offset = "0x2AA7A10", VA = "0x182AA8810")]
	public BoundsIntField()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x2AA8820", Offset = "0x2AA7A20", VA = "0x182AA8820")]
	public BoundsIntField(string label)
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x2AA8330", Offset = "0x2AA7530", VA = "0x182AA8330", Slot = "155")]
	public override void SetValueWithoutNotify(BoundsInt newValue)
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x2AA85C0", Offset = "0x2AA77C0", VA = "0x182AA85C0", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}
}
