using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000457")]
internal class TextEditingManipulator
{
	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x10")]
	private readonly TextElement m_TextElement;

	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x18")]
	private TextEditorEventHandler m_EditingEventHandler;

	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x20")]
	internal UnityEngine.TextEditingUtilities editingUtilities;

	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x28")]
	private bool m_TouchScreenTextFieldInitialized;

	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x30")]
	private IVisualElementScheduledItem m_HardwareKeyboardPoller;

	[Token(Token = "0x1700089C")]
	internal TextEditorEventHandler editingEventHandler
	{
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x29FD5B0", Offset = "0x29FC7B0", VA = "0x1829FD5B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700089D")]
	private bool touchScreenTextFieldChanged
	{
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x29FD510", Offset = "0x29FC710", VA = "0x1829FD510")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0x29FD400", Offset = "0x29FC600", VA = "0x1829FD400")]
	public TextEditingManipulator(TextElement textElement)
	{
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0x29FD340", Offset = "0x29FC540", VA = "0x1829FD340")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002035")]
	[Address(RVA = "0x29FCF90", Offset = "0x29FC190", VA = "0x1829FCF90")]
	private void InitTextEditorEventHandler()
	{
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0x29FCD20", Offset = "0x29FBF20", VA = "0x1829FCD20")]
	internal void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6002037")]
	[Address(RVA = "0x29FD060", Offset = "0x29FC260", VA = "0x1829FD060")]
	private void OnFocusInEvent()
	{
	}

	[Token(Token = "0x6002038")]
	[Address(RVA = "0x29FD2E0", Offset = "0x29FC4E0", VA = "0x1829FD2E0")]
	private void OnFocusOutEvent()
	{
	}
}
