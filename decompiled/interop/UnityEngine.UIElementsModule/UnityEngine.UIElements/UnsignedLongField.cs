using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000171")]
public class UnsignedLongField : TextValueField<ulong>
{
	[Token(Token = "0x2000172")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<UnsignedLongField, UxmlTraits>
	{
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x2B0BEC0", Offset = "0x2B0B0C0", VA = "0x182B0BEC0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000173")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextValueFieldTraits<ulong, UxmlUnsignedLongAttributeDescription>
	{
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x2B0CA20", Offset = "0x2B0BC20", VA = "0x182B0CA20")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x2000174")]
	private class UnsignedLongInput : TextValueInput
	{
		[Token(Token = "0x170001EF")]
		private UnsignedLongField parentUnsignedLongField
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x2B0BD80", Offset = "0x2B0AF80", VA = "0x182B0BD80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F0")]
		protected override string allowedCharacters
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x2B0BD30", Offset = "0x2B0AF30", VA = "0x182B0BD30", Slot = "139")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x2B0BCA0", Offset = "0x2B0AEA0", VA = "0x182B0BCA0")]
		internal UnsignedLongInput()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x2B0B940", Offset = "0x2B0AB40", VA = "0x182B0B940", Slot = "140")]
		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue)
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x2B0BB70", Offset = "0x2B0AD70", VA = "0x182B0BB70")]
		private ulong ClampToMinMaxULongValue(long niceDelta, ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x2B0BC50", Offset = "0x2B0AE50", VA = "0x182B0BC50", Slot = "141")]
		protected override string ValueToString(ulong v)
		{
			return null;
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x2B0BC10", Offset = "0x2B0AE10", VA = "0x182B0BC10", Slot = "137")]
		protected override ulong StringToValue(string str)
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170001EE")]
	private UnsignedLongInput unsignedLongInput
	{
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x2B0B8C0", Offset = "0x2B0AAC0", VA = "0x182B0B8C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x2B0B320", Offset = "0x2B0A520", VA = "0x182B0B320", Slot = "157")]
	protected override string ValueToString(ulong v)
	{
		return null;
	}

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x2B0B200", Offset = "0x2B0A400", VA = "0x182B0B200", Slot = "158")]
	protected override ulong StringToValue(string str)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x2B0B6E0", Offset = "0x2B0A8E0", VA = "0x182B0B6E0")]
	public UnsignedLongField()
	{
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x2B0B4E0", Offset = "0x2B0A6E0", VA = "0x182B0B4E0")]
	public UnsignedLongField(string label, int maxLength = 1000)
	{
	}

	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x2B0B1D0", Offset = "0x2B0A3D0", VA = "0x182B0B1D0", Slot = "167")]
	internal override bool CanTryParse(string textString)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x2B0B0F0", Offset = "0x2B0A2F0", VA = "0x182B0B0F0", Slot = "166")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue)
	{
	}
}
