using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000A7")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector2Field : BaseCompositeField<Vector2, FloatField, float>
{
	[Token(Token = "0x20000A8")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Vector2Field, UxmlTraits>
	{
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2AB5920", Offset = "0x2AB4B20", VA = "0x182AB5920")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000A9")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
	{
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x98")]
		private UxmlFloatAttributeDescription m_XValue;

		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_YValue;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2AB8020", Offset = "0x2AB7220", VA = "0x182AB8020", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2AB9FF0", Offset = "0x2AB91F0", VA = "0x182AB9FF0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x2ABA3E0", Offset = "0x2AB95E0", VA = "0x182ABA3E0", Slot = "156")]
	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x2ABA960", Offset = "0x2AB9B60", VA = "0x182ABA960")]
	public Vector2Field()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x2ABAA80", Offset = "0x2AB9C80", VA = "0x182ABAA80")]
	public Vector2Field(string label)
	{
	}
}
