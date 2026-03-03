using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000E4")]
public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType>, IEditableElement
{
	[Token(Token = "0x20000E5")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_Label;

		[Token(Token = "0x6000706")]
		public UxmlTraits()
		{
		}

		[Token(Token = "0x6000707")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId valueProperty;

	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId labelProperty;

	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId showMixedValueProperty;

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ussClassName;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string labelUssClassName;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string inputUssClassName;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string noLabelVariantUssClassName;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string labelDraggerVariantUssClassName;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string mixedValueLabelUssClassName;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string alignedFieldUssClassName;

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string inspectorFieldUssClassName;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x0")]
	protected internal static readonly string mixedValueString;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x0")]
	protected internal static readonly PropertyName serializedPropertyCopyName;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x0")]
	private static CustomStyleProperty<float> s_LabelWidthRatioProperty;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x0")]
	private static CustomStyleProperty<float> s_LabelExtraPaddingProperty;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x0")]
	private static CustomStyleProperty<float> s_LabelBaseMinWidthProperty;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x0")]
	private float m_LabelWidthRatio;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x0")]
	private float m_LabelExtraPadding;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x0")]
	private float m_LabelBaseMinWidth;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x0")]
	private VisualElement m_VisualInput;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x0")]
	internal Action<ExpressionEvaluator.Expression> expressionEvaluated;

	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x0")]
	[DontCreateProperty]
	[SerializeField]
	private TValueType m_Value;

	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x0")]
	private bool m_ShowMixedValue;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x0")]
	private Label m_MixedValueLabel;

	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x0")]
	private bool m_SkipValidation;

	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x0")]
	private VisualElement m_CachedContextWidthElement;

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x0")]
	private VisualElement m_CachedInspectorElement;

	[Token(Token = "0x17000102")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal VisualElement visualInput
	{
		[Token(Token = "0x60006DE")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006DF")]
		set
		{
		}
	}

	[Token(Token = "0x17000103")]
	protected TValueType rawValue
	{
		[Token(Token = "0x60006E0")]
		get
		{
			return (TValueType)null;
		}
		[Token(Token = "0x60006E1")]
		set
		{
		}
	}

	[Token(Token = "0x17000104")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal DispatchMode dispatchMode
	{
		[Token(Token = "0x60006E4")]
		[CompilerGenerated]
		get
		{
			return default(DispatchMode);
		}
		[Token(Token = "0x60006E5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000105")]
	[CreateProperty]
	public virtual TValueType value
	{
		[Token(Token = "0x60006E6")]
		get
		{
			return (TValueType)null;
		}
		[Token(Token = "0x60006E7")]
		set
		{
		}
	}

	[Token(Token = "0x17000106")]
	public Label labelElement
	{
		[Token(Token = "0x60006E8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E9")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000107")]
	[CreateProperty]
	public string label
	{
		[Token(Token = "0x60006EA")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006EB")]
		set
		{
		}
	}

	[Token(Token = "0x17000108")]
	[CreateProperty]
	public bool showMixedValue
	{
		[Token(Token = "0x60006EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006ED")]
		set
		{
		}
	}

	[Token(Token = "0x17000109")]
	private protected virtual bool canSwitchToMixedValue
	{
		[Token(Token = "0x60006EE")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010A")]
	protected Label mixedValueLabel
	{
		[Token(Token = "0x60006EF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010B")]
	private Action UnityEngine_002EUIElements_002EIEditableElement_002EeditingStarted
	{
		[Token(Token = "0x60006F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010C")]
	private Action UnityEngine_002EUIElements_002EIEditableElement_002EeditingEnded
	{
		[Token(Token = "0x60006F1")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000012")]
	internal event Action viewDataRestored
	{
		[Token(Token = "0x60006DC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60006DD")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	internal event Func<TValueType, TValueType> onValidateValue
	{
		[Token(Token = "0x60006E2")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60006E3")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60006F2")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal BaseField(string label)
	{
	}

	[Token(Token = "0x60006F3")]
	protected BaseField(string label, VisualElement visualInput)
	{
	}

	[Token(Token = "0x60006F4")]
	internal virtual bool EqualsCurrentValue(TValueType value)
	{
		return default(bool);
	}

	[Token(Token = "0x60006F5")]
	private void OnAttachToPanel(AttachToPanelEvent e)
	{
	}

	[Token(Token = "0x60006F6")]
	private void OnDetachFromPanel(DetachFromPanelEvent e)
	{
	}

	[Token(Token = "0x60006F7")]
	internal virtual void RegisterEditingCallbacks()
	{
	}

	[Token(Token = "0x60006F8")]
	internal virtual void UnregisterEditingCallbacks()
	{
	}

	[Token(Token = "0x60006F9")]
	internal void StartEditing(EventBase e)
	{
	}

	[Token(Token = "0x60006FA")]
	internal void EndEditing(EventBase e)
	{
	}

	[Token(Token = "0x60006FB")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt)
	{
	}

	[Token(Token = "0x60006FC")]
	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e)
	{
	}

	[Token(Token = "0x60006FD")]
	private void AlignLabel()
	{
	}

	[Token(Token = "0x60006FE")]
	private Rect ComputeTooltipRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x60006FF")]
	internal override Rect GetTooltipRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000700")]
	internal TValueType ValidatedValue(TValueType value)
	{
		return (TValueType)null;
	}

	[Token(Token = "0x6000701")]
	[EventInterest(new Type[] { typeof(TooltipEvent) })]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6000702")]
	protected virtual void UpdateMixedValueContent()
	{
	}

	[Token(Token = "0x6000703")]
	public virtual void SetValueWithoutNotify(TValueType newValue)
	{
	}

	[Token(Token = "0x6000704")]
	internal override void OnViewDataReady()
	{
	}
}
