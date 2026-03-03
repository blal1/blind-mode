using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001C0")]
[EventCategory(EventCategory.ChangeValue)]
public class ChangeEvent<T> : EventBase<ChangeEvent<T>>
{
	[Token(Token = "0x17000245")]
	public T previousValue
	{
		[Token(Token = "0x6000CC2")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000CC3")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000246")]
	public T newValue
	{
		[Token(Token = "0x6000CC4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000CC5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6000CC1")]
	static ChangeEvent()
	{
	}

	[Token(Token = "0x6000CC6")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000CC7")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000CC8")]
	public static ChangeEvent<T> GetPooled(T previousValue, T newValue)
	{
		return null;
	}

	[Token(Token = "0x6000CC9")]
	public ChangeEvent()
	{
	}
}
