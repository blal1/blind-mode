using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001EA")]
[EventCategory(EventCategory.Keyboard)]
public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent where T : KeyboardEventBase<T>, new()
{
	[Token(Token = "0x1700026F")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000DD3")]
		[CompilerGenerated]
		get
		{
			return default(EventModifiers);
		}
		[Token(Token = "0x6000DD4")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000270")]
	public char character
	{
		[Token(Token = "0x6000DD5")]
		[CompilerGenerated]
		get
		{
			return default(char);
		}
		[Token(Token = "0x6000DD6")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000271")]
	public KeyCode keyCode
	{
		[Token(Token = "0x6000DD7")]
		[CompilerGenerated]
		get
		{
			return default(KeyCode);
		}
		[Token(Token = "0x6000DD8")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000272")]
	public bool shiftKey
	{
		[Token(Token = "0x6000DD9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000273")]
	public bool ctrlKey
	{
		[Token(Token = "0x6000DDA")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000274")]
	public bool commandKey
	{
		[Token(Token = "0x6000DDB")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000275")]
	public bool altKey
	{
		[Token(Token = "0x6000DDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000276")]
	internal bool functionKey
	{
		[Token(Token = "0x6000DDD")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000277")]
	public bool actionKey
	{
		[Token(Token = "0x6000DDE")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000DDF")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000DE0")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000DE1")]
	public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers)
	{
		return null;
	}

	[Token(Token = "0x6000DE2")]
	public static T GetPooled(Event systemEvent)
	{
		return null;
	}

	[Token(Token = "0x6000DE3")]
	internal override void Dispatch(BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000DE4")]
	protected KeyboardEventBase()
	{
	}
}
