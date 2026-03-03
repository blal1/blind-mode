using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000FF")]
public class MinMaxSlider : BaseField<Vector2>
{
	[Token(Token = "0x2000100")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits>
	{
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x2AD8A90", Offset = "0x2AD7C90", VA = "0x182AD8A90")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000101")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
	{
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x98")]
		private UxmlFloatAttributeDescription m_MinValue;

		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlFloatAttributeDescription m_MaxValue;

		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlFloatAttributeDescription m_LowLimit;

		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlFloatAttributeDescription m_HighLimit;

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x2AD9B30", Offset = "0x2AD8D30", VA = "0x182AD9B30")]
		public UxmlTraits()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2AD8FC0", Offset = "0x2AD81C0", VA = "0x182AD8FC0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	[Token(Token = "0x2000102")]
	private enum DragState
	{
		[Token(Token = "0x40004EA")]
		MinThumb,
		[Token(Token = "0x40004EB")]
		MaxThumb,
		[Token(Token = "0x40004EC")]
		MiddleThumb,
		[Token(Token = "0x40004ED")]
		NoThumb
	}

	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId minValueProperty;

	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId maxValueProperty;

	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId rangeProperty;

	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId lowLimitProperty;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x260")]
	internal static readonly BindingId highLimitProperty;

	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x558")]
	private Vector2 m_DragElementStartPos;

	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x560")]
	private Vector2 m_ValueStartPos;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x568")]
	private DragState m_DragState;

	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x56C")]
	private float m_MinLimit;

	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x570")]
	private float m_MaxLimit;

	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x2F8")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x300")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x308")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x310")]
	public static readonly string trackerUssClassName;

	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x318")]
	public static readonly string draggerUssClassName;

	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x320")]
	public static readonly string minThumbUssClassName;

	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x328")]
	public static readonly string maxThumbUssClassName;

	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x330")]
	public static readonly string movableUssClassName;

	[Token(Token = "0x17000140")]
	internal VisualElement dragElement
	{
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1376BB0", Offset = "0x1375DB0", VA = "0x181376BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x14CA5C0", Offset = "0x14C97C0", VA = "0x1814CA5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000141")]
	internal VisualElement dragMinThumb
	{
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1376B90", Offset = "0x1375D90", VA = "0x181376B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x14CA5E0", Offset = "0x14C97E0", VA = "0x1814CA5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000142")]
	internal VisualElement dragMaxThumb
	{
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x14CA280", Offset = "0x14C9480", VA = "0x1814CA280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x14CABC0", Offset = "0x14C9DC0", VA = "0x1814CABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000143")]
	internal ClampedDragger<float> clampedDragger
	{
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x14CA1D0", Offset = "0x14C93D0", VA = "0x1814CA1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x14CA5A0", Offset = "0x14C97A0", VA = "0x1814CA5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000144")]
	[CreateProperty]
	public float minValue
	{
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2AD25A0", Offset = "0x2AD17A0", VA = "0x182AD25A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x2AD2A50", Offset = "0x2AD1C50", VA = "0x182AD2A50")]
		set
		{
		}
	}

	[Token(Token = "0x17000145")]
	[CreateProperty]
	public float maxValue
	{
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2AD2570", Offset = "0x2AD1770", VA = "0x182AD2570")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x2AD2930", Offset = "0x2AD1B30", VA = "0x182AD2930")]
		set
		{
		}
	}

	[Token(Token = "0x17000146")]
	public override Vector2 value
	{
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x2AD2650", Offset = "0x2AD1850", VA = "0x182AD2650", Slot = "144")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x2AD2B60", Offset = "0x2AD1D60", VA = "0x182AD2B60", Slot = "145")]
		set
		{
		}
	}

	[Token(Token = "0x17000147")]
	[CreateProperty(ReadOnly = true)]
	public float range
	{
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x2AD25D0", Offset = "0x2AD17D0", VA = "0x182AD25D0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000148")]
	[CreateProperty]
	public float lowLimit
	{
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x2AD2560", Offset = "0x2AD1760", VA = "0x182AD2560")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x2AD27E0", Offset = "0x2AD19E0", VA = "0x182AD27E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000149")]
	[CreateProperty]
	public float highLimit
	{
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x15200B0", Offset = "0x151F2B0", VA = "0x1815200B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2AD2690", Offset = "0x2AD1890", VA = "0x182AD2690")]
		set
		{
		}
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x2AD09C0", Offset = "0x2ACFBC0", VA = "0x182AD09C0", Slot = "155")]
	public override void SetValueWithoutNotify(Vector2 newValue)
	{
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x2AD1B40", Offset = "0x2AD0D40", VA = "0x182AD1B40")]
	public MinMaxSlider()
	{
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x2AD1B80", Offset = "0x2AD0D80", VA = "0x182AD1B80")]
	public MinMaxSlider(string label, float minValue = 0f, float maxValue = 10f, float minLimit = -3.4028235E+38f, float maxLimit = 3.4028235E+38f)
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x2ACF430", Offset = "0x2ACE630", VA = "0x182ACF430")]
	private Vector2 ClampValues(Vector2 valueToClamp)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x2AD13B0", Offset = "0x2AD05B0", VA = "0x182AD13B0")]
	private void UpdateDragElementPosition(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x2AD0BA0", Offset = "0x2ACFDA0", VA = "0x182AD0BA0")]
	private void UpdateDragElementPosition()
	{
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x2AD0A30", Offset = "0x2ACFC30", VA = "0x182AD0A30")]
	internal float SliderLerpUnclamped(float a, float b, float interpolant)
	{
		return default(float);
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x2AD0A50", Offset = "0x2ACFC50", VA = "0x182AD0A50")]
	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
	{
		return default(float);
	}

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x2ACFBC0", Offset = "0x2ACEDC0", VA = "0x182ACFBC0")]
	private float ComputeValueFromPosition(float positionToConvert)
	{
		return default(float);
	}

	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x2ACFD30", Offset = "0x2ACEF30", VA = "0x182ACFD30", Slot = "8")]
	[EventInterest(new Type[] { typeof(GeometryChangedEvent) })]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x2ACFC60", Offset = "0x2ACEE60", VA = "0x182ACFC60")]
	private DragState GetNavigationState()
	{
		return default(DragState);
	}

	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x2AD0300", Offset = "0x2ACF500", VA = "0x182AD0300")]
	private void SetNavigationState(DragState newState)
	{
	}

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x2ACFF90", Offset = "0x2ACF190", VA = "0x182ACFF90")]
	private void OnFocusIn(FocusInEvent evt)
	{
	}

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x2ACFE70", Offset = "0x2ACF070", VA = "0x182ACFE70")]
	private void OnBlur(BlurEvent evt)
	{
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x2AD01A0", Offset = "0x2ACF3A0", VA = "0x182AD01A0")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x2AD00C0", Offset = "0x2ACF2C0", VA = "0x182AD00C0")]
	private void OnNavigationMove(NavigationMoveEvent evt)
	{
	}

	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x2ACF6F0", Offset = "0x2ACE8F0", VA = "0x182ACF6F0")]
	private void ComputeValueFromKey(bool leftDirection, bool isShift, DragState moveState)
	{
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x2AD0930", Offset = "0x2ACFB30", VA = "0x182AD0930")]
	private void SetSliderValueFromDrag()
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x2AD0450", Offset = "0x2ACF650", VA = "0x182AD0450")]
	private void SetSliderValueFromClick()
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x2ACF4C0", Offset = "0x2ACE6C0", VA = "0x182ACF4C0")]
	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x2AD01D0", Offset = "0x2ACF3D0", VA = "0x182AD01D0", Slot = "152")]
	internal override void RegisterEditingCallbacks()
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x2AD0A70", Offset = "0x2ACFC70", VA = "0x182AD0A70", Slot = "153")]
	internal override void UnregisterEditingCallbacks()
	{
	}
}
