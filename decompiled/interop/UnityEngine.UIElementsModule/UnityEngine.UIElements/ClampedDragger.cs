using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200004C")]
internal class ClampedDragger<T> : Clickable where T : IComparable<T>
{
	[Token(Token = "0x200004D")]
	[Flags]
	public enum DragDirection
	{
		[Token(Token = "0x4000173")]
		None = 0,
		[Token(Token = "0x4000174")]
		LowToHigh = 1,
		[Token(Token = "0x4000175")]
		HighToLow = 2,
		[Token(Token = "0x4000176")]
		Free = 4
	}

	[Token(Token = "0x17000047")]
	public DragDirection dragDirection
	{
		[Token(Token = "0x6000231")]
		[CompilerGenerated]
		get
		{
			return default(DragDirection);
		}
		[Token(Token = "0x6000232")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	private BaseSlider<T> slider
	{
		[Token(Token = "0x6000233")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public Vector2 startMousePosition
	{
		[Token(Token = "0x6000234")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000235")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public Vector2 delta
	{
		[Token(Token = "0x6000236")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x14000002")]
	public event Action dragging
	{
		[Token(Token = "0x600022D")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600022E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action draggingEnded
	{
		[Token(Token = "0x600022F")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000237")]
	public ClampedDragger(BaseSlider<T> slider, Action clickHandler, Action dragHandler)
	{
	}

	[Token(Token = "0x6000238")]
	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x6000239")]
	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x600023A")]
	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
	{
	}
}
