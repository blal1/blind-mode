using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000F1")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class IntegerField : TextValueField<int>
{
	[Token(Token = "0x20000F2")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<IntegerField, UxmlTraits>
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x2AD8B10", Offset = "0x2AD7D10", VA = "0x182AD8B10")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000F3")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextValueFieldTraits<int, UxmlIntAttributeDescription>
	{
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2AD9DD0", Offset = "0x2AD8FD0", VA = "0x182AD9DD0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x20000F4")]
	private class IntegerInput : TextValueInput
	{
		[Token(Token = "0x17000136")]
		private IntegerField parentIntegerField
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x2ACC6C0", Offset = "0x2ACB8C0", VA = "0x182ACC6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		protected override string allowedCharacters
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x2ACC670", Offset = "0x2ACB870", VA = "0x182ACC670", Slot = "139")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x2ACC5E0", Offset = "0x2ACB7E0", VA = "0x182ACC5E0")]
		internal IntegerInput()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x2ACC380", Offset = "0x2ACB580", VA = "0x182ACC380", Slot = "140")]
		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2ACC590", Offset = "0x2ACB790", VA = "0x182ACC590", Slot = "141")]
		protected override string ValueToString(int v)
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2ACC550", Offset = "0x2ACB750", VA = "0x182ACC550", Slot = "137")]
		protected override int StringToValue(string str)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x17000135")]
	private IntegerInput integerInput
	{
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2ACC300", Offset = "0x2ACB500", VA = "0x182ACC300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x2ACBD60", Offset = "0x2ACAF60", VA = "0x182ACBD60", Slot = "157")]
	protected override string ValueToString(int v)
	{
		return null;
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x2ACBC40", Offset = "0x2ACAE40", VA = "0x182ACBC40", Slot = "158")]
	protected override int StringToValue(string str)
	{
		return default(int);
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0x2ACC120", Offset = "0x2ACB320", VA = "0x182ACC120")]
	public IntegerField()
	{
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x2ACBF20", Offset = "0x2ACB120", VA = "0x182ACBF20")]
	public IntegerField(string label, int maxLength = 1000)
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x2ACBC10", Offset = "0x2ACAE10", VA = "0x182ACBC10", Slot = "167")]
	internal override bool CanTryParse(string textString)
	{
		return default(bool);
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x2ACBB30", Offset = "0x2ACAD30", VA = "0x182ACBB30", Slot = "166")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue)
	{
	}
}
