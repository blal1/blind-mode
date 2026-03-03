using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000450")]
internal class ATGTextEventHandler
{
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x10")]
	private TextElement m_TextElement;

	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x18")]
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown;

	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x20")]
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp;

	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x28")]
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove;

	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x30")]
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut;

	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x38")]
	private EventCallback<PointerUpEvent> m_HyperlinkOnPointerUp;

	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x40")]
	private EventCallback<PointerMoveEvent> m_HyperlinkOnPointerMove;

	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x48")]
	private EventCallback<PointerOverEvent> m_HyperlinkOnPointerOver;

	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0x50")]
	private EventCallback<PointerOutEvent> m_HyperlinkOnPointerOut;

	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0x58")]
	internal bool isOverridingCursor;

	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0x5C")]
	internal int currentLinkIDHash;

	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x29F5C10", Offset = "0x29F4E10", VA = "0x1829F5C10")]
	public ATGTextEventHandler(TextElement textElement)
	{
	}

	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x29F54E0", Offset = "0x29F46E0", VA = "0x1829F54E0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x29F4770", Offset = "0x29F3970", VA = "0x1829F4770")]
	private bool HasAllocatedLinkCallbacks()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x29F45F0", Offset = "0x29F37F0", VA = "0x1829F45F0")]
	private void AllocateLinkCallbacks()
	{
	}

	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x29F4760", Offset = "0x29F3960", VA = "0x1829F4760")]
	private bool HasAllocatedHyperlinkCallbacks()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x29F4480", Offset = "0x29F3680", VA = "0x1829F4480")]
	private void AllocateHyperlinkCallbacks()
	{
	}

	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x29F49D0", Offset = "0x29F3BD0", VA = "0x1829F49D0")]
	private void HyperlinkOnPointerUp(PointerUpEvent pue)
	{
	}

	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x29F49C0", Offset = "0x29F3BC0", VA = "0x1829F49C0")]
	private void HyperlinkOnPointerOver(PointerOverEvent _)
	{
	}

	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x29F4780", Offset = "0x29F3980", VA = "0x1829F4780")]
	private void HyperlinkOnPointerMove(PointerMoveEvent pme)
	{
	}

	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x29F49C0", Offset = "0x29F3BC0", VA = "0x1829F49C0")]
	private void HyperlinkOnPointerOut(PointerOutEvent evt)
	{
	}

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x29F4B20", Offset = "0x29F3D20", VA = "0x1829F4B20")]
	private void LinkTagOnPointerDown(PointerDownEvent pde)
	{
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x29F52D0", Offset = "0x29F44D0", VA = "0x1829F52D0")]
	private void LinkTagOnPointerUp(PointerUpEvent pue)
	{
	}

	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x29F4D30", Offset = "0x29F3F30", VA = "0x1829F4D30")]
	private void LinkTagOnPointerMove(PointerMoveEvent pme)
	{
	}

	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x29F5180", Offset = "0x29F4380", VA = "0x1829F5180")]
	private void LinkTagOnPointerOut(PointerOutEvent poe)
	{
	}

	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x29F5790", Offset = "0x29F4990", VA = "0x1829F5790")]
	internal void RegisterLinkTagCallbacks()
	{
	}

	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x29F5B20", Offset = "0x29F4D20", VA = "0x1829F5B20")]
	internal void UnRegisterLinkTagCallbacks()
	{
	}

	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x29F5500", Offset = "0x29F4700", VA = "0x1829F5500")]
	internal void RegisterHyperlinkCallbacks()
	{
	}

	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x29F59E0", Offset = "0x29F4BE0", VA = "0x1829F59E0")]
	internal void UnRegisterHyperlinkCallbacks()
	{
	}
}
