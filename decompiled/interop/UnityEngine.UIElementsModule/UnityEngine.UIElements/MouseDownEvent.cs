using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001F5")]
[EventCategory(EventCategory.PointerDown)]
public class MouseDownEvent : MouseEventBase<MouseDownEvent>
{
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x2B1E860", Offset = "0x2B1DA60", VA = "0x182B1E860")]
	static MouseDownEvent()
	{
	}

	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x2B1E7C0", Offset = "0x2B1D9C0", VA = "0x182B1E7C0", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x2B1E810", Offset = "0x2B1DA10", VA = "0x182B1E810")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x2B1E940", Offset = "0x2B1DB40", VA = "0x182B1E940")]
	public MouseDownEvent()
	{
	}

	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x2B1E820", Offset = "0x2B1DA20", VA = "0x182B1E820")]
	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
	{
		return null;
	}

	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x2B1E6E0", Offset = "0x2B1D8E0", VA = "0x182B1E6E0")]
	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent)
	{
		return null;
	}

	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x2B1E750", Offset = "0x2B1D950", VA = "0x182B1E750")]
	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent)
	{
		return null;
	}
}
