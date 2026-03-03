using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200016D")]
public class UnsignedIntegerField : TextValueField<uint>
{
	[Token(Token = "0x200016E")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<UnsignedIntegerField, UxmlTraits>
	{
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x2B0BF40", Offset = "0x2B0B140", VA = "0x182B0BF40")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200016F")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextValueFieldTraits<uint, UxmlUnsignedIntAttributeDescription>
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x2B0C9E0", Offset = "0x2B0BBE0", VA = "0x182B0C9E0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x2000170")]
	private class UnsignedIntegerInput : TextValueInput
	{
		[Token(Token = "0x170001EC")]
		private UnsignedIntegerField parentUnsignedIntegerField
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x2B0B070", Offset = "0x2B0A270", VA = "0x182B0B070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001ED")]
		protected override string allowedCharacters
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x2B0B020", Offset = "0x2B0A220", VA = "0x182B0B020", Slot = "139")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x2B0AF90", Offset = "0x2B0A190", VA = "0x182B0AF90")]
		internal UnsignedIntegerInput()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x2B0AD40", Offset = "0x2B09F40", VA = "0x182B0AD40", Slot = "140")]
		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue)
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x2B0AF40", Offset = "0x2B0A140", VA = "0x182B0AF40", Slot = "141")]
		protected override string ValueToString(uint v)
		{
			return null;
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x2B0AF00", Offset = "0x2B0A100", VA = "0x182B0AF00", Slot = "137")]
		protected override uint StringToValue(string str)
		{
			return default(uint);
		}
	}

	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170001EB")]
	private UnsignedIntegerInput integerInput
	{
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x2B0ACC0", Offset = "0x2B09EC0", VA = "0x182B0ACC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x2B0A720", Offset = "0x2B09920", VA = "0x182B0A720", Slot = "157")]
	protected override string ValueToString(uint v)
	{
		return null;
	}

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x2B0A600", Offset = "0x2B09800", VA = "0x182B0A600", Slot = "158")]
	protected override uint StringToValue(string str)
	{
		return default(uint);
	}

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x2B0AAE0", Offset = "0x2B09CE0", VA = "0x182B0AAE0")]
	public UnsignedIntegerField()
	{
	}

	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x2B0A8E0", Offset = "0x2B09AE0", VA = "0x182B0A8E0")]
	public UnsignedIntegerField(string label, int maxLength = 1000)
	{
	}

	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x2B0A5D0", Offset = "0x2B097D0", VA = "0x182B0A5D0", Slot = "167")]
	internal override bool CanTryParse(string textString)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x2B0A4F0", Offset = "0x2B096F0", VA = "0x182B0A4F0", Slot = "166")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue)
	{
	}
}
