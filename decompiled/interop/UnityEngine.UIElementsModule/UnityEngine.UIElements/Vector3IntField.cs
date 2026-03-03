using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000B7")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector3IntField : BaseCompositeField<Vector3Int, IntegerField, int>
{
	[Token(Token = "0x20000B8")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Vector3IntField, UxmlTraits>
	{
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x2AB5A20", Offset = "0x2AB4C20", VA = "0x182AB5A20")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000B9")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Vector3Int>.UxmlTraits
	{
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x98")]
		private UxmlIntAttributeDescription m_XValue;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlIntAttributeDescription m_YValue;

		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlIntAttributeDescription m_ZValue;

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2AB83C0", Offset = "0x2AB75C0", VA = "0x182AB83C0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2AB97B0", Offset = "0x2AB89B0", VA = "0x182AB97B0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x2ABBC10", Offset = "0x2ABAE10", VA = "0x182ABBC10", Slot = "156")]
	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x2ABC360", Offset = "0x2ABB560", VA = "0x182ABC360")]
	public Vector3IntField()
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x2ABC370", Offset = "0x2ABB570", VA = "0x182ABC370")]
	public Vector3IntField(string label)
	{
	}
}
