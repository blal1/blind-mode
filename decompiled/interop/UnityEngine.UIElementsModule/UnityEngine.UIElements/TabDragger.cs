using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000152")]
internal class TabDragger : PointerManipulator
{
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x28")]
	private float m_StartPos;

	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x2C")]
	private float m_LastPos;

	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Moving;

	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x31")]
	private bool m_Cancelled;

	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x38")]
	private VisualElement m_Header;

	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x40")]
	private TabView m_TabView;

	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x48")]
	private VisualElement m_PreviewElement;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x50")]
	private TabDragLocationPreview m_LocationPreviewElement;

	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x58")]
	private VisualElement m_TabToMove;

	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x60")]
	private float m_TabToMovePos;

	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x68")]
	private VisualElement m_DestinationTab;

	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x70")]
	private bool m_MoveBeforeDestination;

	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x74")]
	private int m_DraggingPointerId;

	[Token(Token = "0x170001BE")]
	private TabLayout tabLayout
	{
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170001BF")]
	internal bool active
	{
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x449850", Offset = "0x448A50", VA = "0x180449850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170001C0")]
	internal bool isVertical
	{
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x4497F0", Offset = "0x4489F0", VA = "0x1804497F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x449840", Offset = "0x448A40", VA = "0x180449840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170001C1")]
	internal bool moving
	{
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x2AFF130", Offset = "0x2AFE330", VA = "0x182AFF130")]
		private set
		{
		}
	}

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x2AFF000", Offset = "0x2AFE200", VA = "0x182AFF000")]
	public TabDragger()
	{
	}

	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x2AFE0E0", Offset = "0x2AFD2E0", VA = "0x182AFE0E0", Slot = "5")]
	protected override void RegisterCallbacksOnTarget()
	{
	}

	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x2AFE3D0", Offset = "0x2AFD5D0", VA = "0x182AFE3D0", Slot = "6")]
	protected override void UnregisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x2AFD840", Offset = "0x2AFCA40", VA = "0x182AFD840")]
	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x2AFD8F0", Offset = "0x2AFCAF0", VA = "0x182AFD8F0")]
	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x2AFDA80", Offset = "0x2AFCC80", VA = "0x182AFDA80")]
	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x2AFD760", Offset = "0x2AFC960", VA = "0x182AFD760")]
	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x2AFD7E0", Offset = "0x2AFC9E0", VA = "0x182AFD7E0")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
	{
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x2AFDB90", Offset = "0x2AFCD90", VA = "0x182AFDB90")]
	private void ProcessCancelEvent(EventBase evt, int pointerId)
	{
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x2AFD690", Offset = "0x2AFC890", VA = "0x182AFD690")]
	private void OnKeyDown(KeyDownEvent e)
	{
	}

	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x2AFDC50", Offset = "0x2AFCE50", VA = "0x182AFDC50")]
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x2AFDED0", Offset = "0x2AFD0D0", VA = "0x182AFDED0")]
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition)
	{
	}

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x2AFE020", Offset = "0x2AFD220", VA = "0x182AFE020")]
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x2AFD070", Offset = "0x2AFC270", VA = "0x182AFD070")]
	private void BeginDragMove(float pos)
	{
	}

	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x2AFD450", Offset = "0x2AFC650", VA = "0x182AFD450")]
	private void DragMove(float pos)
	{
	}

	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x2AFE8A0", Offset = "0x2AFDAA0", VA = "0x182AFE8A0")]
	private void UpdatePreviewPosition()
	{
	}

	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x2AFE6C0", Offset = "0x2AFD8C0", VA = "0x182AFE6C0")]
	private void UpdateMoveLocation()
	{
	}

	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x2AFD460", Offset = "0x2AFC660", VA = "0x182AFD460")]
	private void EndDragMove(bool cancelled)
	{
	}
}
