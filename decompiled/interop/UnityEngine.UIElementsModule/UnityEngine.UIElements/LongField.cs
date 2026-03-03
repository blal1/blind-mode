using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000FB")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class LongField : TextValueField<long>
{
	[Token(Token = "0x20000FC")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<LongField, UxmlTraits>
	{
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2AD8AD0", Offset = "0x2AD7CD0", VA = "0x182AD8AD0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000FD")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextValueFieldTraits<long, UxmlLongAttributeDescription>
	{
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2AD9F40", Offset = "0x2AD9140", VA = "0x182AD9F40")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x20000FE")]
	private class LongInput : TextValueInput
	{
		[Token(Token = "0x1700013E")]
		private LongField parentLongField
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x2ACF3B0", Offset = "0x2ACE5B0", VA = "0x182ACF3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		protected override string allowedCharacters
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x2ACF360", Offset = "0x2ACE560", VA = "0x182ACF360", Slot = "139")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2ACF2D0", Offset = "0x2ACE4D0", VA = "0x182ACF2D0")]
		internal LongInput()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x2ACEF50", Offset = "0x2ACE150", VA = "0x182ACEF50", Slot = "140")]
		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x2ACF190", Offset = "0x2ACE390", VA = "0x182ACF190")]
		private long ClampMinMaxLongValue(long niceDelta, long value)
		{
			return default(long);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x2ACF280", Offset = "0x2ACE480", VA = "0x182ACF280", Slot = "141")]
		protected override string ValueToString(long v)
		{
			return null;
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2ACF240", Offset = "0x2ACE440", VA = "0x182ACF240", Slot = "137")]
		protected override long StringToValue(string str)
		{
			return default(long);
		}
	}

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x1700013D")]
	private LongInput longInput
	{
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2ACEED0", Offset = "0x2ACE0D0", VA = "0x182ACEED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x2ACE930", Offset = "0x2ACDB30", VA = "0x182ACE930", Slot = "157")]
	protected override string ValueToString(long v)
	{
		return null;
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x2ACE810", Offset = "0x2ACDA10", VA = "0x182ACE810", Slot = "158")]
	protected override long StringToValue(string str)
	{
		return default(long);
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x2ACECF0", Offset = "0x2ACDEF0", VA = "0x182ACECF0")]
	public LongField()
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x2ACEAF0", Offset = "0x2ACDCF0", VA = "0x182ACEAF0")]
	public LongField(string label, int maxLength = 1000)
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x2ACE7E0", Offset = "0x2ACD9E0", VA = "0x182ACE7E0", Slot = "167")]
	internal override bool CanTryParse(string textString)
	{
		return default(bool);
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x2ACE700", Offset = "0x2ACD900", VA = "0x182ACE700", Slot = "166")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue)
	{
	}
}
