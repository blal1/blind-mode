using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200006E")]
public abstract class ContextualMenuManager
{
	[Token(Token = "0x17000089")]
	internal bool displayMenuHandledOSX
	{
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60003EE")]
	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x29A9170", Offset = "0x29A8370", VA = "0x1829A9170")]
	public void DisplayMenu(EventBase triggerEvent, IEventHandler target)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x29A8EE0", Offset = "0x29A80E0", VA = "0x1829A8EE0")]
	internal void DisplayMenu(EventBase triggerEvent, IEventHandler target, DropdownMenu menu)
	{
	}

	[Token(Token = "0x60003F1")]
	protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected ContextualMenuManager()
	{
	}
}
