using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000E8")]
internal class TextEditorEventHandler
{
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x10")]
	protected TextElement textElement;

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x18")]
	protected UnityEngine.TextEditingUtilities editingUtilities;

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
	protected TextEditorEventHandler(TextElement textElement, UnityEngine.TextEditingUtilities editingUtilities)
	{
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public virtual void RegisterCallbacksOnTarget(VisualElement target)
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public virtual void UnregisterCallbacksFromTarget(VisualElement target)
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public virtual void HandleEventBubbleUp(EventBase evt)
	{
	}
}
