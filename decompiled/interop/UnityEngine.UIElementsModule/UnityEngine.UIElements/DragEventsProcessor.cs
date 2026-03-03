using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000191")]
internal abstract class DragEventsProcessor
{
	[Token(Token = "0x2000192")]
	internal enum DragState
	{
		[Token(Token = "0x400079F")]
		None,
		[Token(Token = "0x40007A0")]
		CanStartDrag,
		[Token(Token = "0x40007A1")]
		Dragging
	}

	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsRegistered;

	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x14")]
	private DragState m_DragState;

	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_Start;

	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x24")]
	private bool m_PendingPerformDrag;

	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x28")]
	protected readonly VisualElement m_Target;

	[Token(Token = "0x1700021B")]
	protected virtual bool supportsDragEvents
	{
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700021C")]
	private bool useDragEvents
	{
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x2AF7C40", Offset = "0x2AF6E40", VA = "0x182AF7C40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700021D")]
	protected IDragAndDrop dragAndDrop
	{
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x2AF7A00", Offset = "0x2AF6C00", VA = "0x182AF7A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021E")]
	internal virtual bool isEditorContext
	{
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x2AF7B70", Offset = "0x2AF6D70", VA = "0x182AF7B70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x2AF78D0", Offset = "0x2AF6AD0", VA = "0x182AF78D0")]
	internal DragEventsProcessor(VisualElement target)
	{
	}

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x2AF7430", Offset = "0x2AF6630", VA = "0x182AF7430")]
	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt)
	{
	}

	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x2AF7090", Offset = "0x2AF6290", VA = "0x182AF7090")]
	private void RegisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x2AF78C0", Offset = "0x2AF6AC0", VA = "0x182AF78C0")]
	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x2AF7440", Offset = "0x2AF6640", VA = "0x182AF7440")]
	internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false)
	{
	}

	[Token(Token = "0x6000BFC")]
	protected abstract bool CanStartDrag(Vector3 pointerPosition);

	[Token(Token = "0x6000BFD")]
	protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition);

	[Token(Token = "0x6000BFE")]
	protected internal abstract void UpdateDrag(Vector3 pointerPosition);

	[Token(Token = "0x6000BFF")]
	protected internal abstract void OnDrop(Vector3 pointerPosition);

	[Token(Token = "0x6000C00")]
	protected abstract void ClearDragAndDropUI(bool dragCancelled);

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x2AF6A00", Offset = "0x2AF5C00", VA = "0x182AF6A00")]
	private void OnPointerDownEvent(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x2AF6E00", Offset = "0x2AF6000", VA = "0x182AF6E00")]
	private void OnPointerOutEvent(PointerOutEvent evt)
	{
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x2AF6EB0", Offset = "0x2AF60B0", VA = "0x182AF6EB0")]
	internal void OnPointerUpEvent(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x6000C04")]
	[Address(RVA = "0x2AF6AC0", Offset = "0x2AF5CC0", VA = "0x182AF6AC0")]
	private void OnPointerLeaveEvent(PointerLeaveEvent evt)
	{
	}

	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x2AF6990", Offset = "0x2AF5B90", VA = "0x182AF6990")]
	private void OnPointerCancelEvent(PointerCancelEvent evt)
	{
	}

	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x2AF69F0", Offset = "0x2AF5BF0", VA = "0x182AF69F0")]
	private void OnPointerCapturedOut(PointerCaptureOutEvent evt)
	{
	}

	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x2AF6910", Offset = "0x2AF5B10", VA = "0x182AF6910")]
	private void OnGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x2AF66E0", Offset = "0x2AF58E0", VA = "0x182AF66E0")]
	private void CancelDragAndDrop(int releaseCapturePointerId = -1)
	{
	}

	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x2AF6AE0", Offset = "0x2AF5CE0", VA = "0x182AF6AE0")]
	private void OnPointerMoveEvent(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x2AF67E0", Offset = "0x2AF59E0", VA = "0x182AF67E0")]
	private DragEventsProcessor GetDropTarget(Vector2 position)
	{
		return null;
	}
}
