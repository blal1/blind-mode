using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001C2")]
[EventCategory(EventCategory.Command)]
public abstract class CommandEventBase<T> : EventBase<T> where T : CommandEventBase<T>, new()
{
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x0")]
	private string m_CommandName;

	[Token(Token = "0x17000247")]
	public string commandName
	{
		[Token(Token = "0x6000CCD")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CCE")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000CCF")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000CD0")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000CD1")]
	public static T GetPooled(Event systemEvent)
	{
		return null;
	}

	[Token(Token = "0x6000CD2")]
	public static T GetPooled(string commandName)
	{
		return null;
	}

	[Token(Token = "0x6000CD3")]
	internal override void Dispatch(BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000CD4")]
	protected CommandEventBase()
	{
	}
}
