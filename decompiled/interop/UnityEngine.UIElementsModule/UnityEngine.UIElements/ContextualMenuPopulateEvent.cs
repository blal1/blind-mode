using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200020B")]
public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
{
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0xB0")]
	private ContextualMenuManager m_ContextualMenuManager;

	[Token(Token = "0x17000291")]
	public DropdownMenu menu
	{
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000292")]
	public EventBase triggerEvent
	{
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x2B0E960", Offset = "0x2B0DB60", VA = "0x182B0E960")]
	static ContextualMenuPopulateEvent()
	{
	}

	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x2B0E360", Offset = "0x2B0D560", VA = "0x182B0E360")]
	public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager)
	{
		return null;
	}

	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x2B0E790", Offset = "0x2B0D990", VA = "0x182B0E790", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x2B0E7E0", Offset = "0x2B0D9E0", VA = "0x182B0E7E0")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x2B0EA40", Offset = "0x2B0DC40", VA = "0x182B0EA40")]
	public ContextualMenuPopulateEvent()
	{
	}

	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x2B0E870", Offset = "0x2B0DA70", VA = "0x182B0E870", Slot = "9")]
	protected internal override void PostDispatch(IPanel panel)
	{
	}
}
