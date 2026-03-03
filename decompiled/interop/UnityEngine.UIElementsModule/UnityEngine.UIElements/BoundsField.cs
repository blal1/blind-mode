using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000091")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsField : BaseField<Bounds>
{
	[Token(Token = "0x2000092")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<BoundsField, UxmlTraits>
	{
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2AB57A0", Offset = "0x2AB49A0", VA = "0x182AB57A0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Bounds>.UxmlTraits
	{
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x98")]
		private UxmlFloatAttributeDescription m_CenterXValue;

		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_CenterYValue;

		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlFloatAttributeDescription m_CenterZValue;

		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlFloatAttributeDescription m_ExtentsXValue;

		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0xB8")]
		private UxmlFloatAttributeDescription m_ExtentsYValue;

		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0xC0")]
		private UxmlFloatAttributeDescription m_ExtentsZValue;

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2AB68D0", Offset = "0x2AB5AD0", VA = "0x182AB68D0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2AB9BB0", Offset = "0x2AB8DB0", VA = "0x182AB9BB0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string centerFieldUssClassName;

	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string extentsFieldUssClassName;

	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x548")]
	private Vector3Field m_CenterField;

	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x550")]
	private Vector3Field m_ExtentsField;

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x2AA8320", Offset = "0x2AA7520", VA = "0x182AA8320")]
	public BoundsField()
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x2AA7F20", Offset = "0x2AA7120", VA = "0x182AA7F20")]
	public BoundsField(string label)
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x2AA7A40", Offset = "0x2AA6C40", VA = "0x182AA7A40", Slot = "155")]
	public override void SetValueWithoutNotify(Bounds newValue)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x2AA7CD0", Offset = "0x2AA6ED0", VA = "0x182AA7CD0", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}
}
