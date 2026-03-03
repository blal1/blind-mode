using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000BB")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class DoubleField : TextValueField<double>
{
	[Token(Token = "0x20000BC")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<DoubleField, UxmlTraits>
	{
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2AB5B20", Offset = "0x2AB4D20", VA = "0x182AB5B20")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000BD")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextValueFieldTraits<double, UxmlDoubleAttributeDescription>
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2AB9B70", Offset = "0x2AB8D70", VA = "0x182AB9B70")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x20000BE")]
	private class DoubleInput : TextValueInput
	{
		[Token(Token = "0x170000E2")]
		private DoubleField parentDoubleField
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x2AAAF30", Offset = "0x2AAA130", VA = "0x182AAAF30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		protected override string allowedCharacters
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x2AAAEE0", Offset = "0x2AAA0E0", VA = "0x182AAAEE0", Slot = "139")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2AAAE50", Offset = "0x2AAA050", VA = "0x182AAAE50")]
		internal DoubleInput()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x2AAAC30", Offset = "0x2AA9E30", VA = "0x182AAAC30", Slot = "140")]
		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2AAAE00", Offset = "0x2AAA000", VA = "0x182AAAE00", Slot = "141")]
		protected override string ValueToString(double v)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2AAADC0", Offset = "0x2AA9FC0", VA = "0x182AAADC0", Slot = "137")]
		protected override double StringToValue(string str)
		{
			return default(double);
		}
	}

	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170000E1")]
	private DoubleInput doubleInput
	{
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2AAABB0", Offset = "0x2AA9DB0", VA = "0x182AAABB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x2AAA610", Offset = "0x2AA9810", VA = "0x182AAA610", Slot = "157")]
	protected override string ValueToString(double v)
	{
		return null;
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x2AAA4F0", Offset = "0x2AA96F0", VA = "0x182AAA4F0", Slot = "158")]
	protected override double StringToValue(string str)
	{
		return default(double);
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x2AAA9D0", Offset = "0x2AA9BD0", VA = "0x182AAA9D0")]
	public DoubleField()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x2AAA7D0", Offset = "0x2AA99D0", VA = "0x182AAA7D0")]
	public DoubleField(string label, int maxLength = 1000)
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x2AAA4C0", Offset = "0x2AA96C0", VA = "0x182AAA4C0", Slot = "167")]
	internal override bool CanTryParse(string textString)
	{
		return default(bool);
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x2AAA3E0", Offset = "0x2AA95E0", VA = "0x182AAA3E0", Slot = "166")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue)
	{
	}
}
