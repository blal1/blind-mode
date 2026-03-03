using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001F4")]
[EventCategory(EventCategory.Pointer)]
public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal, IPointerOrMouseEvent where T : MouseEventBase<T>, new()
{
	[Token(Token = "0x17000284")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000E0D")]
		[CompilerGenerated]
		get
		{
			return default(EventModifiers);
		}
		[Token(Token = "0x6000E0E")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000285")]
	public Vector2 mousePosition
	{
		[Token(Token = "0x6000E0F")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000E10")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000286")]
	public Vector2 localMousePosition
	{
		[Token(Token = "0x6000E11")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000E12")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000287")]
	public Vector2 mouseDelta
	{
		[Token(Token = "0x6000E13")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000E14")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000288")]
	public int clickCount
	{
		[Token(Token = "0x6000E15")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E16")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000289")]
	public int button
	{
		[Token(Token = "0x6000E17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E18")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700028A")]
	public int pressedButtons
	{
		[Token(Token = "0x6000E19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E1A")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700028B")]
	private bool UnityEngine_002EUIElements_002EIMouseEventInternal_002EtriggeredByOS
	{
		[Token(Token = "0x6000E1B")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E1C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700028C")]
	private IPointerEvent UnityEngine_002EUIElements_002EIMouseEventInternal_002EsourcePointerEvent
	{
		[Token(Token = "0x6000E1D")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E1E")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700028D")]
	private int UnityEngine_002EUIElements_002EIPointerOrMouseEvent_002EpointerId
	{
		[Token(Token = "0x6000E1F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700028E")]
	private Vector3 UnityEngine_002EUIElements_002EIPointerOrMouseEvent_002Eposition
	{
		[Token(Token = "0x6000E20")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700028F")]
	public override IEventHandler currentTarget
	{
		[Token(Token = "0x6000E23")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E24")]
		internal set
		{
		}
	}

	[Token(Token = "0x6000E21")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000E22")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000E25")]
	protected internal override void PreDispatch(IPanel panel)
	{
	}

	[Token(Token = "0x6000E26")]
	protected internal override void PostDispatch(IPanel panel)
	{
	}

	[Token(Token = "0x6000E27")]
	internal override void Dispatch(BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000E28")]
	public static T GetPooled(Event systemEvent)
	{
		return null;
	}

	[Token(Token = "0x6000E29")]
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition)
	{
		return null;
	}

	[Token(Token = "0x6000E2A")]
	public static T GetPooled(IMouseEvent triggerEvent)
	{
		return null;
	}

	[Token(Token = "0x6000E2B")]
	protected static T GetPooled(IPointerEvent pointerEvent)
	{
		return null;
	}

	[Token(Token = "0x6000E2C")]
	protected MouseEventBase()
	{
	}
}
