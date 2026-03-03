using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000138")]
public class Scroller : VisualElement
{
	[Token(Token = "0x2000139")]
	private class ScrollerSlider : Slider
	{
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2AE8230", Offset = "0x2AE7430", VA = "0x182AE8230")]
		public ScrollerSlider(float start, float end, SliderDirection direction, float pageSize)
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2AE8160", Offset = "0x2AE7360", VA = "0x182AE8160", Slot = "167")]
		internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return default(float);
		}
	}

	[Token(Token = "0x200013A")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Scroller, UxmlTraits>
	{
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x2AEF830", Offset = "0x2AEEA30", VA = "0x182AEF830")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200013B")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x88")]
		private UxmlFloatAttributeDescription m_LowValue;

		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x90")]
		private UxmlFloatAttributeDescription m_HighValue;

		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x98")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_Value;

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x2AF07F0", Offset = "0x2AEF9F0", VA = "0x182AF07F0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x2AF2DD0", Offset = "0x2AF1FD0", VA = "0x182AF2DD0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId valueProperty;

	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId lowValueProperty;

	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId highValueProperty;

	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId directionProperty;

	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x260")]
	public static readonly string ussClassName;

	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x268")]
	public static readonly string horizontalVariantUssClassName;

	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x270")]
	public static readonly string verticalVariantUssClassName;

	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x278")]
	public static readonly string sliderUssClassName;

	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x280")]
	public static readonly string lowButtonUssClassName;

	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x288")]
	public static readonly string highButtonUssClassName;

	[Token(Token = "0x17000196")]
	public Slider slider
	{
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2A999A0", Offset = "0x2A98BA0", VA = "0x182A999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000197")]
	public RepeatButton lowButton
	{
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000198")]
	public RepeatButton highButton
	{
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2AAE730", Offset = "0x2AAD930", VA = "0x182AAE730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000199")]
	[CreateProperty]
	public float value
	{
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2AE9430", Offset = "0x2AE8630", VA = "0x182AE9430")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2AE9970", Offset = "0x2AE8B70", VA = "0x182AE9970")]
		set
		{
		}
	}

	[Token(Token = "0x1700019A")]
	[CreateProperty]
	public float lowValue
	{
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2AE93E0", Offset = "0x2AE85E0", VA = "0x182AE93E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2AE9870", Offset = "0x2AE8A70", VA = "0x182AE9870")]
		set
		{
		}
	}

	[Token(Token = "0x1700019B")]
	[CreateProperty]
	public float highValue
	{
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2AE9390", Offset = "0x2AE8590", VA = "0x182AE9390")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x2AE9770", Offset = "0x2AE8970", VA = "0x182AE9770")]
		set
		{
		}
	}

	[Token(Token = "0x1700019C")]
	[CreateProperty]
	public SliderDirection direction
	{
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x2AE9330", Offset = "0x2AE8530", VA = "0x182AE9330")]
		get
		{
			return default(SliderDirection);
		}
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2AE9520", Offset = "0x2AE8720", VA = "0x182AE9520")]
		set
		{
		}
	}

	[Token(Token = "0x14000024")]
	public event Action<float> valueChanged
	{
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x2AE9270", Offset = "0x2AE8470", VA = "0x182AE9270")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2AE9460", Offset = "0x2AE8660", VA = "0x182AE9460")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000988")]
	[Address(RVA = "0x2AE8DF0", Offset = "0x2AE7FF0", VA = "0x182AE8DF0")]
	public Scroller()
	{
	}

	[Token(Token = "0x6000989")]
	[Address(RVA = "0x2AE8E20", Offset = "0x2AE8020", VA = "0x182AE8E20")]
	public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical)
	{
	}

	[Token(Token = "0x600098A")]
	[Address(RVA = "0x2AE82D0", Offset = "0x2AE74D0", VA = "0x182AE82D0")]
	public void Adjust(float factor)
	{
	}

	[Token(Token = "0x600098B")]
	[Address(RVA = "0x2AE8350", Offset = "0x2AE7550", VA = "0x182AE8350")]
	private void OnSliderValueChange(ChangeEvent<float> evt)
	{
	}

	[Token(Token = "0x600098C")]
	[Address(RVA = "0x2AE8740", Offset = "0x2AE7940", VA = "0x182AE8740")]
	public void ScrollPageUp()
	{
	}

	[Token(Token = "0x600098D")]
	[Address(RVA = "0x2AE8510", Offset = "0x2AE7710", VA = "0x182AE8510")]
	public void ScrollPageDown()
	{
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x2AE8620", Offset = "0x2AE7820", VA = "0x182AE8620")]
	public void ScrollPageUp(float factor)
	{
	}

	[Token(Token = "0x600098F")]
	[Address(RVA = "0x2AE83F0", Offset = "0x2AE75F0", VA = "0x182AE83F0")]
	public void ScrollPageDown(float factor)
	{
	}
}
