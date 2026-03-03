using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200013E")]
public class ScrollView : VisualElement
{
	[Token(Token = "0x200013F")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
	{
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x2AEF5B0", Offset = "0x2AEE7B0", VA = "0x182AEF5B0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000140")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x88")]
		private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode;

		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x90")]
		private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind;

		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x98")]
		private UxmlBoolAttributeDescription m_ShowHorizontal;

		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlBoolAttributeDescription m_ShowVertical;

		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility;

		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility;

		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0xB8")]
		private UxmlFloatAttributeDescription m_HorizontalPageSize;

		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0xC0")]
		private UxmlFloatAttributeDescription m_VerticalPageSize;

		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0xC8")]
		private UxmlFloatAttributeDescription m_MouseWheelScrollSize;

		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0xD0")]
		private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior;

		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0xD8")]
		private UxmlFloatAttributeDescription m_ScrollDecelerationRate;

		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0xE0")]
		private UxmlFloatAttributeDescription m_Elasticity;

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x2AF0BD0", Offset = "0x2AEFDD0", VA = "0x182AF0BD0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x2AF1F10", Offset = "0x2AF1110", VA = "0x182AF1F10")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x2000141")]
	public enum TouchScrollBehavior
	{
		[Token(Token = "0x4000664")]
		Unrestricted,
		[Token(Token = "0x4000665")]
		Elastic,
		[Token(Token = "0x4000666")]
		Clamped
	}

	[Token(Token = "0x2000142")]
	public enum NestedInteractionKind
	{
		[Token(Token = "0x4000668")]
		Default,
		[Token(Token = "0x4000669")]
		StopScrolling,
		[Token(Token = "0x400066A")]
		ForwardScrolling
	}

	[Token(Token = "0x2000143")]
	internal enum TouchScrollingResult
	{
		[Token(Token = "0x400066C")]
		Apply,
		[Token(Token = "0x400066D")]
		Forward,
		[Token(Token = "0x400066E")]
		Block
	}

	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId horizontalScrollerVisibilityProperty;

	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId verticalScrollerVisibilityProperty;

	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId scrollOffsetProperty;

	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId horizontalPageSizeProperty;

	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x260")]
	internal static readonly BindingId verticalPageSizeProperty;

	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x2F8")]
	internal static readonly BindingId mouseWheelScrollSizeProperty;

	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x390")]
	internal static readonly BindingId scrollDecelerationRateProperty;

	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x428")]
	internal static readonly BindingId elasticityProperty;

	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x4C0")]
	internal static readonly BindingId touchScrollBehaviorProperty;

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x558")]
	internal static readonly BindingId nestedInteractionKindProperty;

	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x5F0")]
	internal static readonly BindingId modeProperty;

	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x688")]
	internal static readonly BindingId elasticAnimationIntervalMsProperty;

	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x4A8")]
	private int m_FirstLayoutPass;

	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x4AC")]
	private ScrollerVisibility m_HorizontalScrollerVisibility;

	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x4B0")]
	private ScrollerVisibility m_VerticalScrollerVisibility;

	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0x4B8")]
	private long m_ElasticAnimationIntervalMs;

	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0x4C0")]
	private VisualElement m_AttachedRootVisualContainer;

	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0x4C8")]
	private float m_SingleLineHeight;

	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x4CC")]
	private bool m_SingleLineHeightDirtyFlag;

	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x4CD")]
	internal bool m_MouseWheelScrollSizeIsInline;

	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x4D0")]
	[SerializeField]
	[DontCreateProperty]
	private Vector2 m_ScrollOffset;

	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0x4D8")]
	private float m_HorizontalPageSize;

	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x4DC")]
	private float m_VerticalPageSize;

	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x4E0")]
	private float m_MouseWheelScrollSize;

	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x720")]
	private static readonly float k_DefaultScrollDecelerationRate;

	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x4E4")]
	private float m_ScrollDecelerationRate;

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x4E8")]
	private float k_ScaledPixelsPerPointMultiplier;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x4EC")]
	private float k_TouchScrollInertiaBaseTimeInterval;

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x724")]
	private static readonly float k_DefaultElasticity;

	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x4F0")]
	private float m_Elasticity;

	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x4F4")]
	private TouchScrollBehavior m_TouchScrollBehavior;

	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x4F8")]
	private NestedInteractionKind m_NestedInteractionKind;

	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0x518")]
	private VisualElement m_ContentContainer;

	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x520")]
	private VisualElement m_ContentAndVerticalScrollContainer;

	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x528")]
	private float previousVerticalTouchScrollTimeStamp;

	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x52C")]
	private float previousHorizontalTouchScrollTimeStamp;

	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x530")]
	private float elapsedTimeSinceLastVerticalTouchScroll;

	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x534")]
	private float elapsedTimeSinceLastHorizontalTouchScroll;

	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x728")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x730")]
	public static readonly string viewportUssClassName;

	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x738")]
	public static readonly string horizontalVariantViewportUssClassName;

	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x740")]
	public static readonly string verticalVariantViewportUssClassName;

	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x748")]
	public static readonly string verticalHorizontalVariantViewportUssClassName;

	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x750")]
	public static readonly string contentAndVerticalScrollUssClassName;

	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x758")]
	public static readonly string contentUssClassName;

	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x760")]
	public static readonly string horizontalVariantContentUssClassName;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x768")]
	public static readonly string verticalVariantContentUssClassName;

	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x770")]
	public static readonly string verticalHorizontalVariantContentUssClassName;

	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x778")]
	public static readonly string hScrollerUssClassName;

	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x780")]
	public static readonly string vScrollerUssClassName;

	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x788")]
	public static readonly string horizontalVariantUssClassName;

	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x790")]
	public static readonly string verticalVariantUssClassName;

	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x798")]
	public static readonly string verticalHorizontalVariantUssClassName;

	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x7A0")]
	public static readonly string scrollVariantUssClassName;

	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x538")]
	private ScrollViewMode m_Mode;

	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x540")]
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem;

	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x548")]
	private Vector2 m_StartPosition;

	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x550")]
	private Vector2 m_PointerStartPosition;

	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x558")]
	private Vector2 m_Velocity;

	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x560")]
	private Vector2 m_SpringBackVelocity;

	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x568")]
	private Vector2 m_LowBounds;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x570")]
	private Vector2 m_HighBounds;

	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x578")]
	private float m_LastVelocityLerpTime;

	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x57C")]
	private bool m_StartedMoving;

	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x57D")]
	private bool m_TouchPointerMoveAllowed;

	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x57E")]
	private bool m_TouchStoppedVelocity;

	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x580")]
	private VisualElement m_CapturedTarget;

	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x588")]
	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback;

	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x590")]
	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback;

	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x598")]
	internal IVisualElementScheduledItem m_PostPointerUpAnimation;

	[Token(Token = "0x1700019D")]
	[CreateProperty]
	public ScrollerVisibility horizontalScrollerVisibility
	{
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x2AE7210", Offset = "0x2AE6410", VA = "0x182AE7210")]
		get
		{
			return default(ScrollerVisibility);
		}
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x2AE7800", Offset = "0x2AE6A00", VA = "0x182AE7800")]
		set
		{
		}
	}

	[Token(Token = "0x1700019E")]
	[CreateProperty]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x2AE74E0", Offset = "0x2AE66E0", VA = "0x182AE74E0")]
		get
		{
			return default(ScrollerVisibility);
		}
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x2AE8040", Offset = "0x2AE7240", VA = "0x182AE8040")]
		set
		{
		}
	}

	[Token(Token = "0x1700019F")]
	[CreateProperty]
	public long elasticAnimationIntervalMs
	{
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x2AE71D0", Offset = "0x2AE63D0", VA = "0x182AE71D0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x2AE74F0", Offset = "0x2AE66F0", VA = "0x182AE74F0")]
		set
		{
		}
	}

	[Token(Token = "0x170001A0")]
	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	public bool showHorizontal
	{
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x2AE7E40", Offset = "0x2AE7040", VA = "0x182AE7E40")]
		set
		{
		}
	}

	[Token(Token = "0x170001A1")]
	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	public bool showVertical
	{
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x2AE7E60", Offset = "0x2AE7060", VA = "0x182AE7E60")]
		set
		{
		}
	}

	[Token(Token = "0x170001A2")]
	internal bool needsHorizontal
	{
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x2AE7310", Offset = "0x2AE6510", VA = "0x182AE7310")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A3")]
	internal bool needsVertical
	{
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2AE7360", Offset = "0x2AE6560", VA = "0x182AE7360")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A4")]
	internal bool isVerticalScrollDisplayed
	{
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x2AE7290", Offset = "0x2AE6490", VA = "0x182AE7290")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A5")]
	internal bool isHorizontalScrollDisplayed
	{
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x2AE7220", Offset = "0x2AE6420", VA = "0x182AE7220")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A6")]
	[CreateProperty]
	public Vector2 scrollOffset
	{
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x2AE73C0", Offset = "0x2AE65C0", VA = "0x182AE73C0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x2AE7C10", Offset = "0x2AE6E10", VA = "0x182AE7C10")]
		set
		{
		}
	}

	[Token(Token = "0x170001A7")]
	[CreateProperty]
	public float horizontalPageSize
	{
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x2ADAD30", Offset = "0x2AD9F30", VA = "0x182ADAD30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x2AE7750", Offset = "0x2AE6950", VA = "0x182AE7750")]
		set
		{
		}
	}

	[Token(Token = "0x170001A8")]
	[CreateProperty]
	public float verticalPageSize
	{
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x2AE74D0", Offset = "0x2AE66D0", VA = "0x182AE74D0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x2AE7F90", Offset = "0x2AE7190", VA = "0x182AE7F90")]
		set
		{
		}
	}

	[Token(Token = "0x170001A9")]
	[CreateProperty]
	public float mouseWheelScrollSize
	{
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x141F2C0", Offset = "0x141E4C0", VA = "0x18141F2C0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2AE79B0", Offset = "0x2AE6BB0", VA = "0x182AE79B0")]
		set
		{
		}
	}

	[Token(Token = "0x170001AA")]
	internal float scrollableWidth
	{
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2AE7450", Offset = "0x2AE6650", VA = "0x182AE7450")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001AB")]
	internal float scrollableHeight
	{
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x2AE73E0", Offset = "0x2AE65E0", VA = "0x182AE73E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001AC")]
	private bool hasInertia
	{
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x2AE71F0", Offset = "0x2AE63F0", VA = "0x182AE71F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001AD")]
	[CreateProperty]
	public float scrollDecelerationRate
	{
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x2AE73B0", Offset = "0x2AE65B0", VA = "0x182AE73B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x2AE7B00", Offset = "0x2AE6D00", VA = "0x182AE7B00")]
		set
		{
		}
	}

	[Token(Token = "0x170001AE")]
	[CreateProperty]
	public float elasticity
	{
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x2AE71E0", Offset = "0x2AE63E0", VA = "0x182AE71E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x2AE7640", Offset = "0x2AE6840", VA = "0x182AE7640")]
		set
		{
		}
	}

	[Token(Token = "0x170001AF")]
	[CreateProperty]
	public TouchScrollBehavior touchScrollBehavior
	{
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x2AE74C0", Offset = "0x2AE66C0", VA = "0x182AE74C0")]
		get
		{
			return default(TouchScrollBehavior);
		}
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2AE7E80", Offset = "0x2AE7080", VA = "0x182AE7E80")]
		set
		{
		}
	}

	[Token(Token = "0x170001B0")]
	[CreateProperty]
	public NestedInteractionKind nestedInteractionKind
	{
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x141E0B0", Offset = "0x141D2B0", VA = "0x18141E0B0")]
		get
		{
			return default(NestedInteractionKind);
		}
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x2AE7A80", Offset = "0x2AE6C80", VA = "0x182AE7A80")]
		set
		{
		}
	}

	[Token(Token = "0x170001B1")]
	public VisualElement contentViewport
	{
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x141E0C0", Offset = "0x141D2C0", VA = "0x18141E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B2")]
	public Scroller horizontalScroller
	{
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x137AB50", Offset = "0x1379D50", VA = "0x18137AB50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B3")]
	public Scroller verticalScroller
	{
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x2A0DF40", Offset = "0x2A0D140", VA = "0x182A0DF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B4")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x2AE71C0", Offset = "0x2AE63C0", VA = "0x182AE71C0", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B5")]
	[CreateProperty]
	public ScrollViewMode mode
	{
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2AE7300", Offset = "0x2AE6500", VA = "0x182AE7300")]
		get
		{
			return default(ScrollViewMode);
		}
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2AE7910", Offset = "0x2AE6B10", VA = "0x182AE7910")]
		set
		{
		}
	}

	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x2AE2080", Offset = "0x2AE1280", VA = "0x182AE2080")]
	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x2AE3040", Offset = "0x2AE2240", VA = "0x182AE3040")]
	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x2AE49F0", Offset = "0x2AE3BF0", VA = "0x182AE49F0")]
	private void UpdateHorizontalSliderPageSize()
	{
	}

	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x2AE51C0", Offset = "0x2AE43C0", VA = "0x182AE51C0")]
	private void UpdateVerticalSliderPageSize()
	{
	}

	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x2AE4440", Offset = "0x2AE3640", VA = "0x182AE4440")]
	internal void UpdateContentViewTransform()
	{
	}

	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x2AE3A50", Offset = "0x2AE2C50", VA = "0x182AE3A50")]
	public void ScrollTo(VisualElement child)
	{
	}

	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x2AE0AA0", Offset = "0x2ADFCA0", VA = "0x182AE0AA0")]
	private float GetXDeltaOffset(VisualElement child)
	{
		return default(float);
	}

	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x2AE0D70", Offset = "0x2ADFF70", VA = "0x182AE0D70")]
	private float GetYDeltaOffset(VisualElement child)
	{
		return default(float);
	}

	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x2AE0A30", Offset = "0x2ADFC30", VA = "0x182AE0A30")]
	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax)
	{
		return default(float);
	}

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x2AE71B0", Offset = "0x2AE63B0", VA = "0x182AE71B0")]
	public ScrollView()
	{
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x2AE6280", Offset = "0x2AE5480", VA = "0x182AE6280")]
	public ScrollView(ScrollViewMode scrollViewMode)
	{
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x2AE3D60", Offset = "0x2AE2F60", VA = "0x182AE3D60")]
	private void SetScrollViewMode(ScrollViewMode mode)
	{
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x2AE13B0", Offset = "0x2AE05B0", VA = "0x182AE13B0")]
	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x2AE18A0", Offset = "0x2AE0AA0", VA = "0x182AE18A0")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x2AE2370", Offset = "0x2AE1570", VA = "0x182AE2370")]
	private void OnPointerCapture(PointerCaptureEvent evt)
	{
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x2AE2280", Offset = "0x2AE1480", VA = "0x182AE2280")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
	{
	}

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x2AE1D80", Offset = "0x2AE0F80", VA = "0x182AE1D80")]
	private void OnGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x2AE30C0", Offset = "0x2AE22C0", VA = "0x182AE30C0")]
	private void OnVerticalSliderViewDataRestored()
	{
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x2AE2100", Offset = "0x2AE1300", VA = "0x182AE2100")]
	private void OnHorizontalSliderViewDataRestored()
	{
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x2AE30A0", Offset = "0x2AE22A0", VA = "0x182AE30A0")]
	private void OnVerticalScrollerSetValueWithoutNotify(float value)
	{
	}

	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x2AE20E0", Offset = "0x2AE12E0", VA = "0x182AE20E0")]
	private void OnHorizontalScrollerSetValueWithoutNotify(float value)
	{
	}

	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x2AE3930", Offset = "0x2AE2B30", VA = "0x182AE3930")]
	private void ScheduleResetLayoutPass()
	{
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x2AE3920", Offset = "0x2AE2B20", VA = "0x182AE3920")]
	private void ResetLayoutPass()
	{
	}

	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x2AE01E0", Offset = "0x2ADF3E0", VA = "0x182AE01E0")]
	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit)
	{
		return default(float);
	}

	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x2AE0360", Offset = "0x2ADF560", VA = "0x182AE0360")]
	private void ComputeInitialSpringBackVelocity()
	{
	}

	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x2AE41F0", Offset = "0x2AE33F0", VA = "0x182AE41F0")]
	private void SpringBack()
	{
	}

	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x2ADFB90", Offset = "0x2ADED90", VA = "0x182ADFB90")]
	internal void ApplyScrollInertia()
	{
	}

	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x2AE32B0", Offset = "0x2AE24B0", VA = "0x182AE32B0")]
	private void PostPointerUpAnimation()
	{
	}

	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x2AE2430", Offset = "0x2AE1630", VA = "0x182AE2430")]
	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x2AE2660", Offset = "0x2AE1860", VA = "0x182AE2660")]
	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x2AE2210", Offset = "0x2AE1410", VA = "0x182AE2210")]
	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x2AE28C0", Offset = "0x2AE1AC0", VA = "0x182AE28C0")]
	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x2AE1050", Offset = "0x2AE0250", VA = "0x182AE1050")]
	internal void InitTouchScrolling(Vector2 position)
	{
	}

	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x2AE0460", Offset = "0x2ADF660", VA = "0x182AE0460")]
	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position)
	{
		return default(TouchScrollingResult);
	}

	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x2ADFEF0", Offset = "0x2ADF0F0", VA = "0x182ADFEF0")]
	private bool ApplyTouchScrolling(Vector2 newScrollOffset)
	{
		return default(bool);
	}

	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x2AE3820", Offset = "0x2AE2A20", VA = "0x182AE3820")]
	private bool ReleaseScrolling(int pointerId, IEventHandler target)
	{
		return default(bool);
	}

	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x2AE0840", Offset = "0x2ADFA40", VA = "0x182AE0840")]
	private void ExecuteElasticSpringAnimation()
	{
	}

	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x2ADFA00", Offset = "0x2ADEC00", VA = "0x182ADFA00")]
	private void AdjustScrollers()
	{
	}

	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x2AE4B30", Offset = "0x2AE3D30", VA = "0x182AE4B30")]
	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical)
	{
	}

	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x2AE2E60", Offset = "0x2AE2060", VA = "0x182AE2E60")]
	private void OnScrollersGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x2AE2980", Offset = "0x2AE1B80", VA = "0x182AE2980")]
	private void OnScrollWheel(WheelEvent evt)
	{
	}

	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x2AE13A0", Offset = "0x2AE05A0", VA = "0x182AE13A0")]
	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt)
	{
	}

	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x2AE13A0", Offset = "0x2AE05A0", VA = "0x182AE13A0")]
	private void MarkSingleLineHeightDirty()
	{
	}

	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x2AE2970", Offset = "0x2AE1B70", VA = "0x182AE2970")]
	private void OnRootPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x2AE3460", Offset = "0x2AE2660", VA = "0x182AE3460")]
	private void ReadSingleLineHeight()
	{
	}

	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x2AE4730", Offset = "0x2AE3930", VA = "0x182AE4730")]
	private void UpdateElasticBehaviour()
	{
	}

	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x2AE3C50", Offset = "0x2AE2E50", VA = "0x182AE3C50")]
	internal void SetScrollOffsetWithoutNotify(Vector2 value)
	{
	}

	[Token(Token = "0x60009EA")]
	[Address(RVA = "0x2AE31D0", Offset = "0x2AE23D0", VA = "0x182AE31D0", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}
}
