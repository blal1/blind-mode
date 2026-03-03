using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000B3")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector2IntField : BaseCompositeField<Vector2Int, IntegerField, int>
{
	[Token(Token = "0x20000B4")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Vector2IntField, UxmlTraits>
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2AB5A60", Offset = "0x2AB4C60", VA = "0x182AB5A60")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000B5")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Vector2Int>.UxmlTraits
	{
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x98")]
		private UxmlIntAttributeDescription m_XValue;

		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlIntAttributeDescription m_YValue;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2AB7790", Offset = "0x2AB6990", VA = "0x182AB7790", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2AB9340", Offset = "0x2AB8540", VA = "0x182AB9340")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x2ABABB0", Offset = "0x2AB9DB0", VA = "0x182ABABB0", Slot = "156")]
	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x2ABB260", Offset = "0x2ABA460", VA = "0x182ABB260")]
	public Vector2IntField()
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x2ABB130", Offset = "0x2ABA330", VA = "0x182ABB130")]
	public Vector2IntField(string label)
	{
	}
}
