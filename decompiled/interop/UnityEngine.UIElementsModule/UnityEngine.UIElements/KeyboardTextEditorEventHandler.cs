using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000E7")]
internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
{
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x20")]
	private readonly Event m_ImguiEvent;

	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x28")]
	internal bool m_Changed;

	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x29")]
	internal bool m_ShouldInvokeUpdateValue;

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x2ACD9C0", Offset = "0x2ACCBC0", VA = "0x182ACD9C0")]
	public KeyboardTextEditorEventHandler(TextElement textElement, UnityEngine.TextEditingUtilities editingUtilities)
	{
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0x2ACC7C0", Offset = "0x2ACB9C0", VA = "0x182ACC7C0", Slot = "6")]
	public override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0x2ACCDD0", Offset = "0x2ACBFD0", VA = "0x182ACCDD0")]
	private void OnFocus(FocusEvent _)
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x2ACCB90", Offset = "0x2ACBD90", VA = "0x182ACCB90")]
	private void OnBlur(BlurEvent _)
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x2ACCE60", Offset = "0x2ACC060", VA = "0x182ACCE60")]
	private void OnIMEInput(IMEEvent _)
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x2ACCEC0", Offset = "0x2ACC0C0", VA = "0x182ACCEC0")]
	private void OnKeyDown(KeyDownEvent evt)
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x2ACC740", Offset = "0x2ACB940", VA = "0x182ACC740")]
	private void ApplyTextIfNeeded()
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x2ACD780", Offset = "0x2ACC980", VA = "0x182ACD780")]
	private void UpdateLabel(bool generatePreview)
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x2ACD5C0", Offset = "0x2ACC7C0", VA = "0x182ACD5C0")]
	private void OnValidateCommandEvent(ValidateCommandEvent evt)
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x2ACCBE0", Offset = "0x2ACBDE0", VA = "0x182ACCBE0")]
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt)
	{
	}

	[Token(Token = "0x6000714")]
	private void OnNavigationEvent<TEvent>(NavigationEventBase<TEvent> evt) where TEvent : NavigationEventBase<TEvent>, new()
	{
	}
}
