using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x20005E7")]
[EventCategory(EventCategory.EnterLeave)]
public class PointerOverLinkTagEvent : PointerEventBase<PointerOverLinkTagEvent>
{
	[Token(Token = "0x17000A8A")]
	private string linkID
	{
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000A8B")]
	private string linkText
	{
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600290D")]
	[Address(RVA = "0x2A83C60", Offset = "0x2A82E60", VA = "0x182A83C60")]
	static PointerOverLinkTagEvent()
	{
	}

	[Token(Token = "0x6002910")]
	[Address(RVA = "0x2A83C10", Offset = "0x2A82E10", VA = "0x182A83C10", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6002911")]
	[Address(RVA = "0xF66140", Offset = "0xF65340", VA = "0x180F66140")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6002912")]
	[Address(RVA = "0x2A83B80", Offset = "0x2A82D80", VA = "0x182A83B80")]
	public static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
	{
		return null;
	}

	[Token(Token = "0x6002913")]
	[Address(RVA = "0x2A83D40", Offset = "0x2A82F40", VA = "0x182A83D40")]
	public PointerOverLinkTagEvent()
	{
	}
}
