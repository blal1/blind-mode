using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200020D")]
internal static class MouseEventsHelper
{
	[Token(Token = "0x6000E9A")]
	internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) where TLeaveEvent : MouseEventBase<TLeaveEvent>, new() where TEnterEvent : MouseEventBase<TEnterEvent>, new()
	{
	}

	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x2B1EE50", Offset = "0x2B1E050", VA = "0x182B1EE50")]
	internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
	{
	}
}
