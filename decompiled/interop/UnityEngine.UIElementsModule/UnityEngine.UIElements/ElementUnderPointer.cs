using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001C7")]
internal class ElementUnderPointer
{
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x10")]
	private VisualElement[] m_PendingTopElementUnderPointer;

	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x18")]
	private VisualElement[] m_TopElementUnderPointer;

	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x20")]
	private IPointerOrMouseEvent[] m_TriggerEvent;

	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x28")]
	private Vector2[] m_PickingPointerPositions;

	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x30")]
	private bool[] m_IsPickingPointerTemporaries;

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x2B11330", Offset = "0x2B10530", VA = "0x182B11330")]
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary)
	{
		return null;
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x4179D0", Offset = "0x416BD0", VA = "0x1804179D0")]
	internal VisualElement GetTopElementUnderPointer(int pointerId)
	{
		return null;
	}

	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x2B11680", Offset = "0x2B10880", VA = "0x182B11680")]
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
	{
	}

	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x2B11230", Offset = "0x2B10430", VA = "0x182B11230")]
	private Vector2 GetEventPointerPosition(EventBase triggerEvent)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x2B11800", Offset = "0x2B10A00", VA = "0x182B11800")]
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
	{
	}

	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x2B11660", Offset = "0x2B10860", VA = "0x182B11660")]
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
	{
	}

	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x2B113A0", Offset = "0x2B105A0", VA = "0x182B113A0")]
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary)
	{
	}

	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x2B10460", Offset = "0x2B0F660", VA = "0x182B10460")]
	internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType)
	{
	}

	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x2B11820", Offset = "0x2B10A20", VA = "0x182B11820")]
	public ElementUnderPointer()
	{
	}
}
