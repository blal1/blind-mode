using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000C7")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FloatField : TextValueField<float>
{
	[Token(Token = "0x20000C8")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<FloatField, UxmlTraits>
	{
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2AB57E0", Offset = "0x2AB49E0", VA = "0x182AB57E0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000C9")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextValueFieldTraits<float, UxmlFloatAttributeDescription>
	{
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2ABA3A0", Offset = "0x2AB95A0", VA = "0x182ABA3A0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x20000CA")]
	private class FloatInput : TextValueInput
	{
		[Token(Token = "0x170000E7")]
		private FloatField parentFloatField
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x2AAD620", Offset = "0x2AAC820", VA = "0x182AAD620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		protected override string allowedCharacters
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x2AAD5D0", Offset = "0x2AAC7D0", VA = "0x182AAD5D0", Slot = "139")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2AAD540", Offset = "0x2AAC740", VA = "0x182AAD540")]
		internal FloatInput()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2AAD300", Offset = "0x2AAC500", VA = "0x182AAD300", Slot = "140")]
		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2AAD4F0", Offset = "0x2AAC6F0", VA = "0x182AAD4F0", Slot = "141")]
		protected override string ValueToString(float v)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2AAD4B0", Offset = "0x2AAC6B0", VA = "0x182AAD4B0", Slot = "137")]
		protected override float StringToValue(string str)
		{
			return default(float);
		}
	}

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170000E6")]
	private FloatInput floatInput
	{
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2AAD280", Offset = "0x2AAC480", VA = "0x182AAD280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x2AACCE0", Offset = "0x2AABEE0", VA = "0x182AACCE0", Slot = "157")]
	protected override string ValueToString(float v)
	{
		return null;
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x2AACB10", Offset = "0x2AABD10", VA = "0x182AACB10", Slot = "158")]
	protected override float StringToValue(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x2AACC30", Offset = "0x2AABE30", VA = "0x182AACC30", Slot = "159")]
	internal override void UpdateValueFromText()
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x2AACEA0", Offset = "0x2AAC0A0", VA = "0x182AACEA0")]
	public FloatField()
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x2AAD080", Offset = "0x2AAC280", VA = "0x182AAD080")]
	public FloatField(string label, int maxLength = 1000)
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x2AACAE0", Offset = "0x2AABCE0", VA = "0x182AACAE0", Slot = "167")]
	internal override bool CanTryParse(string textString)
	{
		return default(bool);
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x2AACA00", Offset = "0x2AABC00", VA = "0x182AACA00", Slot = "166")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
	{
	}
}
