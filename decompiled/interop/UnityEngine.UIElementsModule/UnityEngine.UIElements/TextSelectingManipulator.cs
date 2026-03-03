using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200045A")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class TextSelectingManipulator
{
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x10")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal UnityEngine.TextSelectingUtilities m_SelectingUtilities;

	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x18")]
	private bool selectAllOnMouseUp;

	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x20")]
	private TextElement m_TextElement;

	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 m_ClickStartPosition;

	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Dragged;

	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsClicking;

	[Token(Token = "0x4000E71")]
	private const int k_DragThresholdSqr = 16;

	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x34")]
	private int m_ConsecutiveMouseDownCount;

	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x38")]
	private long m_LastMouseDownTimeStamp;

	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x40")]
	private readonly Event m_ImguiEvent;

	[Token(Token = "0x1700089F")]
	internal bool isClicking
	{
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x2A01160", Offset = "0x2A00360", VA = "0x182A01160")]
		private set
		{
		}
	}

	[Token(Token = "0x170008A0")]
	internal int cursorIndex
	{
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x2A01100", Offset = "0x2A00300", VA = "0x182A01100")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x2A01140", Offset = "0x2A00340", VA = "0x182A01140")]
		set
		{
		}
	}

	[Token(Token = "0x170008A1")]
	internal int selectIndex
	{
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x2A01120", Offset = "0x2A00320", VA = "0x182A01120")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x2A01170", Offset = "0x2A00370", VA = "0x182A01170")]
		set
		{
		}
	}

	[Token(Token = "0x6002050")]
	[Address(RVA = "0x2A00DF0", Offset = "0x29FFFF0", VA = "0x182A00DF0")]
	public TextSelectingManipulator(TextElement textElement)
	{
	}

	[Token(Token = "0x6002055")]
	[Address(RVA = "0x2A00B10", Offset = "0x29FFD10", VA = "0x182A00B10")]
	private void OnRevealCursor()
	{
	}

	[Token(Token = "0x6002056")]
	[Address(RVA = "0x2A00B40", Offset = "0x29FFD40", VA = "0x182A00B40")]
	private void OnSelectIndexChange()
	{
	}

	[Token(Token = "0x6002057")]
	[Address(RVA = "0x2A00160", Offset = "0x29FF360", VA = "0x182A00160")]
	private void OnCursorIndexChange()
	{
	}

	[Token(Token = "0x6002058")]
	[Address(RVA = "0x2A00DD0", Offset = "0x29FFFD0", VA = "0x182A00DD0")]
	internal bool RevealCursor()
	{
		return default(bool);
	}

	[Token(Token = "0x6002059")]
	[Address(RVA = "0x2A000A0", Offset = "0x29FF2A0", VA = "0x182A000A0")]
	internal bool HasSelection()
	{
		return default(bool);
	}

	[Token(Token = "0x600205A")]
	[Address(RVA = "0x2A00080", Offset = "0x29FF280", VA = "0x182A00080")]
	internal bool HasFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x600205B")]
	[Address(RVA = "0x29FF900", Offset = "0x29FEB00", VA = "0x1829FF900")]
	internal void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x600205C")]
	[Address(RVA = "0x2A00380", Offset = "0x29FF580", VA = "0x182A00380")]
	private void OnFocusEvent()
	{
	}

	[Token(Token = "0x600205D")]
	[Address(RVA = "0x2A00100", Offset = "0x29FF300", VA = "0x182A00100")]
	private void OnBlurEvent()
	{
	}

	[Token(Token = "0x600205E")]
	[Address(RVA = "0x2A004D0", Offset = "0x29FF6D0", VA = "0x182A004D0")]
	private void OnKeyDown(KeyDownEvent evt)
	{
	}

	[Token(Token = "0x600205F")]
	[Address(RVA = "0x2A00540", Offset = "0x29FF740", VA = "0x182A00540")]
	private void OnPointerDownEvent(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x6002060")]
	[Address(RVA = "0x2A008C0", Offset = "0x29FFAC0", VA = "0x182A008C0")]
	private void OnPointerMoveEvent(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x6002061")]
	[Address(RVA = "0x2A00A60", Offset = "0x29FFC60", VA = "0x182A00A60")]
	private void OnPointerUpEvent(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x6002062")]
	[Address(RVA = "0x2A00C50", Offset = "0x29FFE50", VA = "0x182A00C50")]
	private void OnValidateCommandEvent(ValidateCommandEvent evt)
	{
	}

	[Token(Token = "0x6002063")]
	[Address(RVA = "0x2A00270", Offset = "0x29FF470", VA = "0x182A00270")]
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt)
	{
	}

	[Token(Token = "0x6002064")]
	[Address(RVA = "0x2A000C0", Offset = "0x29FF2C0", VA = "0x182A000C0")]
	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current)
	{
		return default(bool);
	}
}
