using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001DC")]
[EventCategory(EventCategory.Focus)]
public abstract class FocusEventBase<T> : EventBase<T> where T : FocusEventBase<T>, new()
{
	[Token(Token = "0x17000265")]
	public Focusable relatedTarget
	{
		[Token(Token = "0x6000D97")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D98")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000266")]
	public FocusChangeDirection direction
	{
		[Token(Token = "0x6000D99")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D9A")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000267")]
	protected FocusController focusController
	{
		[Token(Token = "0x6000D9B")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D9C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000268")]
	internal bool IsFocusDelegated
	{
		[Token(Token = "0x6000D9D")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D9E")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000D9F")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000DA0")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000DA1")]
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false)
	{
		return null;
	}

	[Token(Token = "0x6000DA2")]
	protected FocusEventBase()
	{
	}
}
