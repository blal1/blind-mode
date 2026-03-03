using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x20005FE")]
internal class ColumnMover : PointerManipulator
{
	[Token(Token = "0x4001601")]
	[FieldOffset(Offset = "0x28")]
	private float m_StartPos;

	[Token(Token = "0x4001602")]
	[FieldOffset(Offset = "0x2C")]
	private float m_LastPos;

	[Token(Token = "0x4001603")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Active;

	[Token(Token = "0x4001604")]
	[FieldOffset(Offset = "0x31")]
	private bool m_Moving;

	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0x32")]
	private bool m_Cancelled;

	[Token(Token = "0x4001606")]
	[FieldOffset(Offset = "0x38")]
	private MultiColumnCollectionHeader m_Header;

	[Token(Token = "0x4001607")]
	[FieldOffset(Offset = "0x40")]
	private VisualElement m_PreviewElement;

	[Token(Token = "0x4001608")]
	[FieldOffset(Offset = "0x48")]
	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement;

	[Token(Token = "0x4001609")]
	[FieldOffset(Offset = "0x50")]
	private Column m_ColumnToMove;

	[Token(Token = "0x400160A")]
	[FieldOffset(Offset = "0x58")]
	private float m_ColumnToMovePos;

	[Token(Token = "0x400160B")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ColumnToMoveWidth;

	[Token(Token = "0x400160C")]
	[FieldOffset(Offset = "0x60")]
	private Column m_DestinationColumn;

	[Token(Token = "0x400160D")]
	[FieldOffset(Offset = "0x68")]
	private bool m_MoveBeforeDestination;

	[Token(Token = "0x17000AC3")]
	public ColumnLayout columnLayout
	{
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000AC4")]
	public bool active
	{
		[Token(Token = "0x60029B3")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x2A93DE0", Offset = "0x2A92FE0", VA = "0x182A93DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC5")]
	public bool moving
	{
		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x2A93E10", Offset = "0x2A93010", VA = "0x182A93E10")]
		set
		{
		}
	}

	[Token(Token = "0x14000034")]
	public event Action<ColumnMover> activeChanged
	{
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x2A93B00", Offset = "0x2A92D00", VA = "0x182A93B00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60029B8")]
		[Address(RVA = "0x2A93C70", Offset = "0x2A92E70", VA = "0x182A93C70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000035")]
	public event Action<ColumnMover> movingChanged
	{
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x2A93BB0", Offset = "0x2A92DB0", VA = "0x182A93BB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x2A93D20", Offset = "0x2A92F20", VA = "0x182A93D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x2A93A10", Offset = "0x2A92C10", VA = "0x182A93A10")]
	public ColumnMover()
	{
	}

	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x2A92F60", Offset = "0x2A92160", VA = "0x182A92F60", Slot = "5")]
	protected override void RegisterCallbacksOnTarget()
	{
	}

	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x2A93250", Offset = "0x2A92450", VA = "0x182A93250", Slot = "6")]
	protected override void UnregisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x2A92630", Offset = "0x2A91830", VA = "0x182A92630")]
	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x2A926D0", Offset = "0x2A918D0", VA = "0x182A926D0")]
	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x2A92850", Offset = "0x2A91A50", VA = "0x182A92850")]
	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x2A92560", Offset = "0x2A91760", VA = "0x182A92560")]
	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x2A925D0", Offset = "0x2A917D0", VA = "0x182A925D0")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
	{
	}

	[Token(Token = "0x60029C3")]
	[Address(RVA = "0x2A929B0", Offset = "0x2A91BB0", VA = "0x182A929B0")]
	protected void ProcessCancelEvent(EventBase evt, int pointerId)
	{
	}

	[Token(Token = "0x60029C4")]
	[Address(RVA = "0x2A92480", Offset = "0x2A91680", VA = "0x182A92480")]
	private void OnKeyDown(KeyDownEvent e)
	{
	}

	[Token(Token = "0x60029C5")]
	[Address(RVA = "0x2A92B10", Offset = "0x2A91D10", VA = "0x182A92B10")]
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x60029C6")]
	[Address(RVA = "0x2A92D10", Offset = "0x2A91F10", VA = "0x182A92D10")]
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition)
	{
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x2A92E50", Offset = "0x2A92050", VA = "0x182A92E50")]
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x2A91E00", Offset = "0x2A91000", VA = "0x182A91E00")]
	private void BeginDragMove(float pos)
	{
	}

	[Token(Token = "0x60029C9")]
	[Address(RVA = "0x2A92320", Offset = "0x2A91520", VA = "0x182A92320")]
	internal void DragMove(float pos)
	{
	}

	[Token(Token = "0x60029CA")]
	[Address(RVA = "0x2A93720", Offset = "0x2A92920", VA = "0x182A93720")]
	private void UpdatePreviewPosition()
	{
	}

	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x2A93540", Offset = "0x2A92740", VA = "0x182A93540")]
	private void UpdateMoveLocation()
	{
	}

	[Token(Token = "0x60029CC")]
	[Address(RVA = "0x2A92330", Offset = "0x2A91530", VA = "0x182A92330")]
	private void EndDragMove(bool cancelled)
	{
	}
}
