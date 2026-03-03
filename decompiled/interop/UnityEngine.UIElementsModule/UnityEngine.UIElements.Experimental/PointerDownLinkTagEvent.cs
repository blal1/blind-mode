using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x20005ED")]
public sealed class PointerDownLinkTagEvent : PointerEventBase<PointerDownLinkTagEvent>
{
	[Token(Token = "0x17000A8E")]
	private string linkID
	{
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000A8F")]
	private string linkText
	{
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6002929")]
	[Address(RVA = "0x2A83680", Offset = "0x2A82880", VA = "0x182A83680")]
	static PointerDownLinkTagEvent()
	{
	}

	[Token(Token = "0x600292C")]
	[Address(RVA = "0x2A83630", Offset = "0x2A82830", VA = "0x182A83630", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x600292D")]
	[Address(RVA = "0xF66140", Offset = "0xF65340", VA = "0x180F66140")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x600292E")]
	[Address(RVA = "0x2A835A0", Offset = "0x2A827A0", VA = "0x182A835A0")]
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
	{
		return null;
	}

	[Token(Token = "0x600292F")]
	[Address(RVA = "0x2A83760", Offset = "0x2A82960", VA = "0x182A83760")]
	public PointerDownLinkTagEvent()
	{
	}
}
