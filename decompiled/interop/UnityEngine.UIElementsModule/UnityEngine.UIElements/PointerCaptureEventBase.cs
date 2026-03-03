using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001B6")]
[EventCategory(EventCategory.Pointer)]
public abstract class PointerCaptureEventBase<T> : EventBase<T> where T : PointerCaptureEventBase<T>, new()
{
	[Token(Token = "0x17000243")]
	private IEventHandler relatedTarget
	{
		[Token(Token = "0x6000CA2")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000244")]
	public int pointerId
	{
		[Token(Token = "0x6000CA3")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CA4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000CA5")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000CA6")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000CA7")]
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId)
	{
		return null;
	}

	[Token(Token = "0x6000CA8")]
	protected PointerCaptureEventBase()
	{
	}
}
