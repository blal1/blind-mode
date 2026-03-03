using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000242")]
[EventCategory(EventCategory.StyleTransition)]
public abstract class TransitionEventBase<T> : EventBase<T> where T : TransitionEventBase<T>, new()
{
	[Token(Token = "0x170002E3")]
	public StylePropertyNameCollection stylePropertyNames
	{
		[Token(Token = "0x6000FC6")]
		[CompilerGenerated]
		get
		{
			return default(StylePropertyNameCollection);
		}
	}

	[Token(Token = "0x170002E4")]
	protected double elapsedTime
	{
		[Token(Token = "0x6000FC7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000FC8")]
	protected TransitionEventBase()
	{
	}

	[Token(Token = "0x6000FC9")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000FCA")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000FCB")]
	public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime)
	{
		return null;
	}
}
