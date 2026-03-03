using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200007D")]
public abstract class BaseSlider<TValueType> : BaseField<TValueType>, IValueField<TValueType> where TValueType : IComparable<TValueType>
{
	[Token(Token = "0x200007E")]
	[Obsolete("UxmlTraits<TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits<TValueUxmlAttributeType> : BaseFieldTraits<TValueType, TValueUxmlAttributeType> where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		[Token(Token = "0x60004C7")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x200007F")]
	internal enum SliderKey
	{
		[Token(Token = "0x40002C0")]
		None,
		[Token(Token = "0x40002C1")]
		Lowest,
		[Token(Token = "0x40002C2")]
		LowerPage,
		[Token(Token = "0x40002C3")]
		Lower,
		[Token(Token = "0x40002C4")]
		Higher,
		[Token(Token = "0x40002C5")]
		HigherPage,
		[Token(Token = "0x40002C6")]
		Highest
	}

	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId lowValueProperty;

	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId highValueProperty;

	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId rangeProperty;

	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId pageSizeProperty;

	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId showInputFieldProperty;

	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId directionProperty;

	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId invertedProperty;

	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId fillProperty;

	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x0")]
	private float m_AdjustedPageSizeFromClick;

	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x0")]
	private bool m_IsEditingTextField;

	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x0")]
	private bool m_Fill;

	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x0")]
	[DontCreateProperty]
	[SerializeField]
	private TValueType m_LowValue;

	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x0")]
	[DontCreateProperty]
	[SerializeField]
	private TValueType m_HighValue;

	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x0")]
	private float m_PageSize;

	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x0")]
	private bool m_ShowInputField;

	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x0")]
	private Rect m_DragElementStartPos;

	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x0")]
	private SliderDirection m_Direction;

	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x0")]
	private bool m_Inverted;

	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string horizontalVariantUssClassName;

	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string verticalVariantUssClassName;

	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string dragContainerUssClassName;

	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string trackerUssClassName;

	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string draggerUssClassName;

	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string draggerBorderUssClassName;

	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string textFieldClassName;

	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string fillUssClassName;

	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string movableUssClassName;

	[Token(Token = "0x170000A5")]
	internal VisualElement dragContainer
	{
		[Token(Token = "0x6000478")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000479")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000A6")]
	internal VisualElement dragElement
	{
		[Token(Token = "0x600047A")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600047B")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000A7")]
	internal VisualElement trackElement
	{
		[Token(Token = "0x600047C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600047D")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000A8")]
	internal VisualElement dragBorderElement
	{
		[Token(Token = "0x600047E")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600047F")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000A9")]
	internal TextField inputTextField
	{
		[Token(Token = "0x6000480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000481")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000AA")]
	internal VisualElement fillElement
	{
		[Token(Token = "0x6000482")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000483")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000AB")]
	private protected override bool canSwitchToMixedValue
	{
		[Token(Token = "0x6000484")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000AC")]
	[CreateProperty]
	public TValueType lowValue
	{
		[Token(Token = "0x6000485")]
		get
		{
			return (TValueType)null;
		}
		[Token(Token = "0x6000486")]
		set
		{
		}
	}

	[Token(Token = "0x170000AD")]
	[CreateProperty]
	public TValueType highValue
	{
		[Token(Token = "0x6000487")]
		get
		{
			return (TValueType)null;
		}
		[Token(Token = "0x6000488")]
		set
		{
		}
	}

	[Token(Token = "0x170000AE")]
	[CreateProperty(ReadOnly = true)]
	public TValueType range
	{
		[Token(Token = "0x600048A")]
		get
		{
			return (TValueType)null;
		}
	}

	[Token(Token = "0x170000AF")]
	[CreateProperty]
	public virtual float pageSize
	{
		[Token(Token = "0x600048B")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600048C")]
		set
		{
		}
	}

	[Token(Token = "0x170000B0")]
	[CreateProperty]
	public virtual bool showInputField
	{
		[Token(Token = "0x600048D")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600048E")]
		set
		{
		}
	}

	[Token(Token = "0x170000B1")]
	[CreateProperty]
	public bool fill
	{
		[Token(Token = "0x600048F")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000490")]
		set
		{
		}
	}

	[Token(Token = "0x170000B2")]
	internal bool clamped
	{
		[Token(Token = "0x6000491")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000492")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000B3")]
	internal ClampedDragger<TValueType> clampedDragger
	{
		[Token(Token = "0x6000493")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000494")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000B4")]
	public override TValueType value
	{
		[Token(Token = "0x6000497")]
		get
		{
			return (TValueType)null;
		}
		[Token(Token = "0x6000498")]
		set
		{
		}
	}

	[Token(Token = "0x170000B5")]
	[CreateProperty]
	public SliderDirection direction
	{
		[Token(Token = "0x600049F")]
		get
		{
			return default(SliderDirection);
		}
		[Token(Token = "0x60004A0")]
		set
		{
		}
	}

	[Token(Token = "0x170000B6")]
	[CreateProperty]
	public bool inverted
	{
		[Token(Token = "0x60004A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004A2")]
		set
		{
		}
	}

	[Token(Token = "0x14000011")]
	internal event Action<TValueType> onSetValueWithoutNotify
	{
		[Token(Token = "0x600049C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600049D")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000489")]
	internal void SetHighValueWithoutNotify(TValueType newHighValue)
	{
	}

	[Token(Token = "0x6000495")]
	private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound)
	{
		return (TValueType)null;
	}

	[Token(Token = "0x6000496")]
	private TValueType GetClampedValue(TValueType newValue)
	{
		return (TValueType)null;
	}

	[Token(Token = "0x6000499")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue)
	{
	}

	[Token(Token = "0x600049A")]
	private void UnityEngine_002EUIElements_002EIValueField_003CTValueType_003E_002EStartDragging()
	{
	}

	[Token(Token = "0x600049B")]
	private void UnityEngine_002EUIElements_002EIValueField_003CTValueType_003E_002EStopDragging()
	{
	}

	[Token(Token = "0x600049E")]
	public override void SetValueWithoutNotify(TValueType newValue)
	{
	}

	[Token(Token = "0x60004A3")]
	internal BaseSlider(string label, TValueType start, TValueType end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
	{
	}

	[Token(Token = "0x60004A4")]
	protected internal static float GetClosestPowerOfTen(float positiveNumber)
	{
		return default(float);
	}

	[Token(Token = "0x60004A5")]
	protected internal static float RoundToMultipleOf(float value, float roundingValue)
	{
		return default(float);
	}

	[Token(Token = "0x60004A6")]
	private void ClampValue()
	{
	}

	[Token(Token = "0x60004A7")]
	internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);

	[Token(Token = "0x60004A8")]
	internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);

	[Token(Token = "0x60004A9")]
	internal abstract TValueType SliderRange();

	[Token(Token = "0x60004AA")]
	internal abstract TValueType ParseStringToValue(string previousValue, string newValue);

	[Token(Token = "0x60004AB")]
	internal abstract void ComputeValueFromKey(SliderKey sliderKey, bool isShift);

	[Token(Token = "0x60004AC")]
	private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant)
	{
		return (TValueType)null;
	}

	[Token(Token = "0x60004AD")]
	private void SetSliderValueFromDrag()
	{
	}

	[Token(Token = "0x60004AE")]
	private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos)
	{
	}

	[Token(Token = "0x60004AF")]
	private void SetSliderValueFromClick()
	{
	}

	[Token(Token = "0x60004B0")]
	private void OnKeyDown(KeyDownEvent evt)
	{
	}

	[Token(Token = "0x60004B1")]
	private void OnNavigationMove(NavigationMoveEvent evt)
	{
	}

	[Token(Token = "0x60004B2")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	[Token(Token = "0x60004B3")]
	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
	{
	}

	[Token(Token = "0x60004B4")]
	public void AdjustDragElement(float factor)
	{
	}

	[Token(Token = "0x60004B5")]
	private void UpdateDragElementPosition(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60004B6")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x60004B7")]
	private bool SameValues(float a, float b, float epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B8")]
	private void UpdateDragElementPosition()
	{
	}

	[Token(Token = "0x60004B9")]
	private void UpdateFill(float normalizedValue)
	{
	}

	[Token(Token = "0x60004BA")]
	[EventInterest(new Type[] { typeof(GeometryChangedEvent) })]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x60004BB")]
	[EventInterest(EventInterestOptions.Inherit)]
	[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", false)]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}

	[Token(Token = "0x60004BC")]
	private void UpdateTextFieldVisibility()
	{
	}

	[Token(Token = "0x60004BD")]
	private void UpdateTextFieldValue()
	{
	}

	[Token(Token = "0x60004BE")]
	private void OnFocusIn(FocusInEvent evt)
	{
	}

	[Token(Token = "0x60004BF")]
	private void OnFocusOut(FocusOutEvent evt)
	{
	}

	[Token(Token = "0x60004C0")]
	private void OnTextFieldFocusIn(FocusInEvent evt)
	{
	}

	[Token(Token = "0x60004C1")]
	private void OnTextFieldFocusOut(FocusOutEvent evt)
	{
	}

	[Token(Token = "0x60004C2")]
	private void OnTextFieldValueChange(ChangeEvent<string> evt)
	{
	}

	[Token(Token = "0x60004C3")]
	protected override void UpdateMixedValueContent()
	{
	}

	[Token(Token = "0x60004C4")]
	internal override void RegisterEditingCallbacks()
	{
	}

	[Token(Token = "0x60004C5")]
	internal override void UnregisterEditingCallbacks()
	{
	}
}
