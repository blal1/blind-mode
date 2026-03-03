using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000F0")]
internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
{
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x20")]
	private IVisualElementScheduledItem m_TouchKeyboardPoller;

	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x28")]
	private bool m_TouchKeyboardAllowsInPlaceEditing;

	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsClicking;

	[Token(Token = "0x17000133")]
	internal static long Frame
	{
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2AD87D0", Offset = "0x2AD79D0", VA = "0x182AD87D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2AD8810", Offset = "0x2AD7A10", VA = "0x182AD8810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000134")]
	private static TouchScreenKeyboard activeTouchScreenKeyboard
	{
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2AD8850", Offset = "0x2AD7A50", VA = "0x182AD8850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0x2AD8760", Offset = "0x2AD7960", VA = "0x182AD8760")]
	public TouchScreenTextEditorEventHandler(TextElement textElement, UnityEngine.TextEditingUtilities editingUtilities)
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0x2AD83F0", Offset = "0x2AD75F0", VA = "0x182AD83F0")]
	private void PollTouchScreenKeyboard()
	{
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0x2AD72E0", Offset = "0x2AD64E0", VA = "0x182AD72E0")]
	private void DoPollTouchScreenKeyboard()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0x2AD8610", Offset = "0x2AD7810", VA = "0x182AD8610")]
	private void UpdateStringPositionFromKeyboard()
	{
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0x2AD71F0", Offset = "0x2AD63F0", VA = "0x182AD71F0")]
	private void CloseTouchScreenKeyboard()
	{
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0x2AD80E0", Offset = "0x2AD72E0", VA = "0x182AD80E0")]
	private void OpenTouchScreenKeyboard()
	{
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0x2AD7830", Offset = "0x2AD6A30", VA = "0x182AD7830", Slot = "6")]
	public override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0x2AD7F70", Offset = "0x2AD7170", VA = "0x182AD7F70")]
	private void OnPointerDownEvent()
	{
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x2AD80B0", Offset = "0x2AD72B0", VA = "0x182AD80B0")]
	private void OnPointerUpEvent(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x2AD7BF0", Offset = "0x2AD6DF0", VA = "0x182AD7BF0")]
	private void OnFocusInEvent()
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0x2AD7CE0", Offset = "0x2AD6EE0", VA = "0x182AD7CE0")]
	private void OnFocusOutEvent(FocusOutEvent evt)
	{
	}
}
