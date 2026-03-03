using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x20005E9")]
[EventCategory(EventCategory.PointerMove)]
public class PointerMoveLinkTagEvent : PointerEventBase<PointerMoveLinkTagEvent>
{
	[Token(Token = "0x17000A8C")]
	private string linkID
	{
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000A8D")]
	private string linkText
	{
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6002917")]
	[Address(RVA = "0x2A83890", Offset = "0x2A82A90", VA = "0x182A83890")]
	static PointerMoveLinkTagEvent()
	{
	}

	[Token(Token = "0x600291A")]
	[Address(RVA = "0x2A83840", Offset = "0x2A82A40", VA = "0x182A83840", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x600291B")]
	[Address(RVA = "0xF66140", Offset = "0xF65340", VA = "0x180F66140")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x600291C")]
	[Address(RVA = "0x2A837B0", Offset = "0x2A829B0", VA = "0x182A837B0")]
	public static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
	{
		return null;
	}

	[Token(Token = "0x600291D")]
	[Address(RVA = "0x2A83970", Offset = "0x2A82B70", VA = "0x182A83970")]
	public PointerMoveLinkTagEvent()
	{
	}
}
