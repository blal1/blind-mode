using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000145")]
public class Slider : BaseSlider<float>
{
	[Token(Token = "0x2000146")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Slider, UxmlTraits>
	{
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x2AEF6B0", Offset = "0x2AEE8B0", VA = "0x182AEF6B0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000147")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : UxmlTraits<UxmlFloatAttributeDescription>
	{
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_LowValue;

		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlFloatAttributeDescription m_HighValue;

		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlFloatAttributeDescription m_PageSize;

		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0xB8")]
		private UxmlBoolAttributeDescription m_ShowInputField;

		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0xC0")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0xC8")]
		private UxmlBoolAttributeDescription m_Inverted;

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x2AF0110", Offset = "0x2AEF310", VA = "0x182AF0110", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x2AF2A50", Offset = "0x2AF1C50", VA = "0x182AF2A50")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000671")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x2AEB1F0", Offset = "0x2AEA3F0", VA = "0x182AEB1F0")]
	public Slider()
	{
	}

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x2AEB220", Offset = "0x2AEA420", VA = "0x182AEB220")]
	public Slider(float start, float end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
	{
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x2AEB090", Offset = "0x2AEA290", VA = "0x182AEB090")]
	public Slider(string label, float start = 0f, float end = 10f, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
	{
	}

	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x2AEA7A0", Offset = "0x2AE99A0", VA = "0x182AEA7A0", Slot = "165")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
	{
	}

	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x2AEABF0", Offset = "0x2AE9DF0", VA = "0x182AEABF0", Slot = "166")]
	internal override float SliderLerpUnclamped(float a, float b, float interpolant)
	{
		return default(float);
	}

	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x2AEAE10", Offset = "0x2AEA010", VA = "0x182AEAE10", Slot = "167")]
	internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
	{
		return default(float);
	}

	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x2AEAED0", Offset = "0x2AEA0D0", VA = "0x182AEAED0", Slot = "168")]
	internal override float SliderRange()
	{
		return default(float);
	}

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x2AEAB20", Offset = "0x2AE9D20", VA = "0x182AEAB20", Slot = "169")]
	internal override float ParseStringToValue(string previousValue, string newValue)
	{
		return default(float);
	}

	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x2AEA8E0", Offset = "0x2AE9AE0", VA = "0x182AEA8E0", Slot = "170")]
	internal override void ComputeValueFromKey(SliderKey sliderKey, bool isShift)
	{
	}
}
