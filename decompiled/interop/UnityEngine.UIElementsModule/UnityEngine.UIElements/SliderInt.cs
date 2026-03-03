using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000148")]
public class SliderInt : BaseSlider<int>
{
	[Token(Token = "0x2000149")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits>
	{
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x2AEF670", Offset = "0x2AEE870", VA = "0x182AEF670")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200014A")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : UxmlTraits<UxmlIntAttributeDescription>
	{
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlIntAttributeDescription m_LowValue;

		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlIntAttributeDescription m_HighValue;

		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlIntAttributeDescription m_PageSize;

		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0xB8")]
		private UxmlBoolAttributeDescription m_ShowInputField;

		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0xC0")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0xC8")]
		private UxmlBoolAttributeDescription m_Inverted;

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x2AEF8F0", Offset = "0x2AEEAF0", VA = "0x182AEF8F0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x2AF3070", Offset = "0x2AF2270", VA = "0x182AF3070")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170001B6")]
	public override float pageSize
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x2AEA6D0", Offset = "0x2AE98D0", VA = "0x182AEA6D0", Slot = "161")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x2AEA710", Offset = "0x2AE9910", VA = "0x182AEA710", Slot = "162")]
		set
		{
		}
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x2AEA440", Offset = "0x2AE9640", VA = "0x182AEA440")]
	public SliderInt()
	{
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x2AEA570", Offset = "0x2AE9770", VA = "0x182AEA570")]
	public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
	{
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x2AE9A70", Offset = "0x2AE8C70", VA = "0x182AE9A70", Slot = "165")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue)
	{
	}

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x2AEA1E0", Offset = "0x2AE93E0", VA = "0x182AEA1E0", Slot = "166")]
	internal override int SliderLerpUnclamped(int a, int b, float interpolant)
	{
		return default(int);
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x2AEA250", Offset = "0x2AE9450", VA = "0x182AEA250", Slot = "167")]
	internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue)
	{
		return default(float);
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x2AEA290", Offset = "0x2AE9490", VA = "0x182AEA290", Slot = "168")]
	internal override int SliderRange()
	{
		return default(int);
	}

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x2AEA130", Offset = "0x2AE9330", VA = "0x182AEA130", Slot = "169")]
	internal override int ParseStringToValue(string previousValue, string newValue)
	{
		return default(int);
	}

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x2AE9BD0", Offset = "0x2AE8DD0", VA = "0x182AE9BD0", Slot = "171")]
	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
	{
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x2AE9EF0", Offset = "0x2AE90F0", VA = "0x182AE9EF0", Slot = "170")]
	internal override void ComputeValueFromKey(SliderKey sliderKey, bool isShift)
	{
	}
}
