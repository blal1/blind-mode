using Il2CppDummyDll;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000458")]
internal class TextEventHandler
{
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x10")]
	private TextElement m_TextElement;

	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x18")]
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown;

	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x20")]
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp;

	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x28")]
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove;

	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x30")]
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut;

	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x38")]
	private EventCallback<PointerUpEvent> m_ATagOnPointerUp;

	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x40")]
	private EventCallback<PointerMoveEvent> m_ATagOnPointerMove;

	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x48")]
	private EventCallback<PointerOverEvent> m_ATagOnPointerOver;

	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x50")]
	private EventCallback<PointerOutEvent> m_ATagOnPointerOut;

	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x58")]
	internal bool isOverridingCursor;

	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x5C")]
	internal int currentLinkIDHash;

	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0x60")]
	internal bool hasLinkTag;

	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0x61")]
	internal bool hasATag;

	[Token(Token = "0x1700089E")]
	private UnityEngine.TextCore.Text.TextInfo textInfo
	{
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x29FF540", Offset = "0x29FE740", VA = "0x1829FF540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600203B")]
	[Address(RVA = "0x29FF500", Offset = "0x29FE700", VA = "0x1829FF500")]
	public TextEventHandler(TextElement textElement)
	{
	}

	[Token(Token = "0x600203C")]
	[Address(RVA = "0x29FF370", Offset = "0x29FE570", VA = "0x1829FF370")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600203D")]
	[Address(RVA = "0x29F4770", Offset = "0x29F3970", VA = "0x1829F4770")]
	private bool HasAllocatedLinkCallbacks()
	{
		return default(bool);
	}

	[Token(Token = "0x600203E")]
	[Address(RVA = "0x29FDC70", Offset = "0x29FCE70", VA = "0x1829FDC70")]
	private void AllocateLinkCallbacks()
	{
	}

	[Token(Token = "0x600203F")]
	[Address(RVA = "0x29F4760", Offset = "0x29F3960", VA = "0x1829F4760")]
	private bool HasAllocatedATagCallbacks()
	{
		return default(bool);
	}

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x29FDB00", Offset = "0x29FCD00", VA = "0x1829FDB00")]
	private void AllocateATagCallbacks()
	{
	}

	[Token(Token = "0x6002041")]
	[Address(RVA = "0x29FD8E0", Offset = "0x29FCAE0", VA = "0x1829FD8E0")]
	private void ATagOnPointerUp(PointerUpEvent pue)
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0x29F49C0", Offset = "0x29F3BC0", VA = "0x1829F49C0")]
	private void ATagOnPointerOver(PointerOverEvent _)
	{
	}

	[Token(Token = "0x6002043")]
	[Address(RVA = "0x29FD630", Offset = "0x29FC830", VA = "0x1829FD630")]
	private void ATagOnPointerMove(PointerMoveEvent pme)
	{
	}

	[Token(Token = "0x6002044")]
	[Address(RVA = "0x29F49C0", Offset = "0x29F3BC0", VA = "0x1829F49C0")]
	private void ATagOnPointerOut(PointerOutEvent evt)
	{
	}

	[Token(Token = "0x6002045")]
	[Address(RVA = "0x29FE680", Offset = "0x29FD880", VA = "0x1829FE680")]
	private void LinkTagOnPointerDown(PointerDownEvent pde)
	{
	}

	[Token(Token = "0x6002046")]
	[Address(RVA = "0x29FF050", Offset = "0x29FE250", VA = "0x1829FF050")]
	private void LinkTagOnPointerUp(PointerUpEvent pue)
	{
	}

	[Token(Token = "0x6002047")]
	[Address(RVA = "0x29FE9A0", Offset = "0x29FDBA0", VA = "0x1829FE9A0")]
	private void LinkTagOnPointerMove(PointerMoveEvent pme)
	{
	}

	[Token(Token = "0x6002048")]
	[Address(RVA = "0x29FEF00", Offset = "0x29FE100", VA = "0x1829FEF00")]
	private void LinkTagOnPointerOut(PointerOutEvent poe)
	{
	}

	[Token(Token = "0x6002049")]
	[Address(RVA = "0x29FDF10", Offset = "0x29FD110", VA = "0x1829FDF10")]
	internal void HandleLinkAndATagCallbacks()
	{
	}

	[Token(Token = "0x600204A")]
	[Address(RVA = "0x29FE550", Offset = "0x29FD750", VA = "0x1829FE550")]
	internal void HandleLinkTag()
	{
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0x29FDDE0", Offset = "0x29FCFE0", VA = "0x1829FDDE0")]
	internal void HandleATag()
	{
	}
}
