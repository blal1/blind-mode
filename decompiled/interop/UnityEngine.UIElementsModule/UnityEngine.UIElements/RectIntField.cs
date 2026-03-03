using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000A3")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class RectIntField : BaseCompositeField<RectInt, IntegerField, int>
{
	[Token(Token = "0x20000A4")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<RectIntField, UxmlTraits>
	{
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2AB58E0", Offset = "0x2AB4AE0", VA = "0x182AB58E0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000A5")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<RectInt>.UxmlTraits
	{
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x98")]
		private UxmlIntAttributeDescription m_XValue;

		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlIntAttributeDescription m_YValue;

		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlIntAttributeDescription m_WValue;

		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlIntAttributeDescription m_HValue;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2AB6650", Offset = "0x2AB5850", VA = "0x182AB6650", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2AB9910", Offset = "0x2AB8B10", VA = "0x182AB9910")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x2AB3820", Offset = "0x2AB2A20", VA = "0x182AB3820", Slot = "156")]
	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x2AB4140", Offset = "0x2AB3340", VA = "0x182AB4140")]
	public RectIntField()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x2AB4280", Offset = "0x2AB3480", VA = "0x182AB4280")]
	public RectIntField(string label)
	{
	}
}
