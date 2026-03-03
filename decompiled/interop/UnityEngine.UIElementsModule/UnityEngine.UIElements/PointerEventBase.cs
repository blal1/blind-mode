using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputForUI;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000227")]
[EventCategory(EventCategory.Pointer)]
public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal, IPointerOrMouseEvent where T : PointerEventBase<T>, new()
{
	[Token(Token = "0x40008C2")]
	private const float k_DefaultButtonPressure = 0.5f;

	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0x0")]
	private bool m_AltitudeNeedsConversion;

	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0x0")]
	private bool m_AzimuthNeedsConversion;

	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0x0")]
	private float m_AltitudeAngle;

	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x0")]
	private float m_AzimuthAngle;

	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x0")]
	private bool m_TiltNeeded;

	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x0")]
	private Vector2 m_Tilt;

	[Token(Token = "0x170002BE")]
	public int pointerId
	{
		[Token(Token = "0x6000F12")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F13")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002BF")]
	public string pointerType
	{
		[Token(Token = "0x6000F14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F15")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C0")]
	public bool isPrimary
	{
		[Token(Token = "0x6000F16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F17")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C1")]
	public int button
	{
		[Token(Token = "0x6000F18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F19")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C2")]
	public int pressedButtons
	{
		[Token(Token = "0x6000F1A")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F1B")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C3")]
	public Vector3 position
	{
		[Token(Token = "0x6000F1C")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000F1D")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C4")]
	public Vector3 localPosition
	{
		[Token(Token = "0x6000F1E")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000F1F")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C5")]
	public Vector3 deltaPosition
	{
		[Token(Token = "0x6000F20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000F21")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C6")]
	public float deltaTime
	{
		[Token(Token = "0x6000F22")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000F23")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C7")]
	public int clickCount
	{
		[Token(Token = "0x6000F24")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F25")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C8")]
	public float pressure
	{
		[Token(Token = "0x6000F26")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000F27")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002C9")]
	public float tangentialPressure
	{
		[Token(Token = "0x6000F28")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000F29")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002CA")]
	public float altitudeAngle
	{
		[Token(Token = "0x6000F2A")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000F2B")]
		protected set
		{
		}
	}

	[Token(Token = "0x170002CB")]
	public float azimuthAngle
	{
		[Token(Token = "0x6000F2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000F2D")]
		protected set
		{
		}
	}

	[Token(Token = "0x170002CC")]
	public float twist
	{
		[Token(Token = "0x6000F2E")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000F2F")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002CD")]
	public Vector2 tilt
	{
		[Token(Token = "0x6000F30")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000F31")]
		protected set
		{
		}
	}

	[Token(Token = "0x170002CE")]
	public PenStatus penStatus
	{
		[Token(Token = "0x6000F32")]
		[CompilerGenerated]
		get
		{
			return default(PenStatus);
		}
		[Token(Token = "0x6000F33")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002CF")]
	public Vector2 radius
	{
		[Token(Token = "0x6000F34")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000F35")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002D0")]
	public Vector2 radiusVariance
	{
		[Token(Token = "0x6000F36")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000F37")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002D1")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000F38")]
		[CompilerGenerated]
		get
		{
			return default(EventModifiers);
		}
		[Token(Token = "0x6000F39")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170002D2")]
	public bool shiftKey
	{
		[Token(Token = "0x6000F3A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D3")]
	public bool ctrlKey
	{
		[Token(Token = "0x6000F3B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D4")]
	public bool commandKey
	{
		[Token(Token = "0x6000F3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D5")]
	public bool altKey
	{
		[Token(Token = "0x6000F3D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D6")]
	public bool actionKey
	{
		[Token(Token = "0x6000F3E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D7")]
	private bool UnityEngine_002EUIElements_002EIPointerEventInternal_002EtriggeredByOS
	{
		[Token(Token = "0x6000F3F")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002D8")]
	private IMouseEvent UnityEngine_002EUIElements_002EIPointerEventInternal_002EcompatibilityMouseEvent
	{
		[Token(Token = "0x6000F41")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F42")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002D9")]
	private int UnityEngine_002EUIElements_002EIPointerEventInternal_002EdisplayIndex
	{
		[Token(Token = "0x6000F43")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002DA")]
	public override IEventHandler currentTarget
	{
		[Token(Token = "0x6000F46")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F47")]
		internal set
		{
		}
	}

	[Token(Token = "0x6000F44")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000F45")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000F48")]
	private static bool IsMouse(Event systemEvent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F49")]
	private static bool IsTouch(Event systemEvent)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F4A")]
	private static float TiltToAzimuth(Vector2 tilt)
	{
		return default(float);
	}

	[Token(Token = "0x6000F4B")]
	private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000F4C")]
	private static float TiltToAltitude(Vector2 tilt)
	{
		return default(float);
	}

	[Token(Token = "0x6000F4D")]
	public static T GetPooled(Event systemEvent)
	{
		return null;
	}

	[Token(Token = "0x6000F4E")]
	internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers, int displayIndex)
	{
		return null;
	}

	[Token(Token = "0x6000F4F")]
	internal static T GetPooled(Touch touch, EventModifiers modifiers, int displayIndex)
	{
		return null;
	}

	[Token(Token = "0x6000F50")]
	internal static T GetPooled(PenData pen, EventModifiers modifiers, int displayIndex)
	{
		return null;
	}

	[Token(Token = "0x6000F51")]
	internal static T GetPooled(UnityEngine.InputForUI.PointerEvent pointerEvent, Vector2 position, Vector2 deltaPosition, int pointerId, float deltaTime)
	{
		return null;
	}

	[Token(Token = "0x6000F52")]
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId)
	{
		return null;
	}

	[Token(Token = "0x6000F53")]
	public static T GetPooled(IPointerEvent triggerEvent)
	{
		return null;
	}

	[Token(Token = "0x6000F54")]
	protected internal override void PreDispatch(IPanel panel)
	{
	}

	[Token(Token = "0x6000F55")]
	protected internal override void PostDispatch(IPanel panel)
	{
	}

	[Token(Token = "0x6000F56")]
	internal override void Dispatch(BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000F57")]
	protected PointerEventBase()
	{
	}
}
