using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x20005EF")]
public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent>
{
	[Token(Token = "0x17000A90")]
	private string linkID
	{
		[Token(Token = "0x6002934")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000A91")]
	private string linkText
	{
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x2A83E70", Offset = "0x2A83070", VA = "0x182A83E70")]
	static PointerUpLinkTagEvent()
	{
	}

	[Token(Token = "0x6002936")]
	[Address(RVA = "0x2A83E20", Offset = "0x2A83020", VA = "0x182A83E20", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6002937")]
	[Address(RVA = "0xF66140", Offset = "0xF65340", VA = "0x180F66140")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x2A83D90", Offset = "0x2A82F90", VA = "0x182A83D90")]
	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
	{
		return null;
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x2A83F50", Offset = "0x2A83150", VA = "0x182A83F50")]
	public PointerUpLinkTagEvent()
	{
	}
}
