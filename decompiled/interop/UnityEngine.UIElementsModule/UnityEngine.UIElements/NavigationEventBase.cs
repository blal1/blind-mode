using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000211")]
[EventCategory(EventCategory.Navigation)]
public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent where T : NavigationEventBase<T>, new()
{
	[Token(Token = "0x17000295")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000EA0")]
		[CompilerGenerated]
		get
		{
			return default(EventModifiers);
		}
		[Token(Token = "0x6000EA1")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000296")]
	public bool shiftKey
	{
		[Token(Token = "0x6000EA2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000297")]
	public bool altKey
	{
		[Token(Token = "0x6000EA3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000298")]
	internal NavigationDeviceType deviceType
	{
		[Token(Token = "0x6000EA4")]
		[CompilerGenerated]
		get
		{
			return default(NavigationDeviceType);
		}
		[Token(Token = "0x6000EA5")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000EA6")]
	protected NavigationEventBase()
	{
	}

	[Token(Token = "0x6000EA7")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000EA8")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000EA9")]
	public static T GetPooled(EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	[Token(Token = "0x6000EAA")]
	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	[Token(Token = "0x6000EAB")]
	internal override void Dispatch(BaseVisualElementPanel panel)
	{
	}
}
