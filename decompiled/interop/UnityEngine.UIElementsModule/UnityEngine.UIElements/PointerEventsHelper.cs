using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200020E")]
internal static class PointerEventsHelper
{
	[Token(Token = "0x6000E9C")]
	internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) where TLeaveEvent : PointerEventBase<TLeaveEvent>, new() where TEnterEvent : PointerEventBase<TEnterEvent>, new()
	{
	}

	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x2B21B00", Offset = "0x2B20D00", VA = "0x182B21B00")]
	internal static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
	{
	}
}
