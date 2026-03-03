using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000AB")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector3Field : BaseCompositeField<Vector3, FloatField, float>
{
	[Token(Token = "0x20000AC")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Vector3Field, UxmlTraits>
	{
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2AB5720", Offset = "0x2AB4920", VA = "0x182AB5720")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000AD")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Vector3>.UxmlTraits
	{
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x98")]
		private UxmlFloatAttributeDescription m_XValue;

		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_YValue;

		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlFloatAttributeDescription m_ZValue;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2AB85F0", Offset = "0x2AB77F0", VA = "0x182AB85F0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2AB8DC0", Offset = "0x2AB7FC0", VA = "0x182AB8DC0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x2ABB380", Offset = "0x2ABA580", VA = "0x182ABB380", Slot = "156")]
	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x2ABBC00", Offset = "0x2ABAE00", VA = "0x182ABBC00")]
	public Vector3Field()
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x2ABBAD0", Offset = "0x2ABACD0", VA = "0x182ABBAD0")]
	public Vector3Field(string label)
	{
	}
}
