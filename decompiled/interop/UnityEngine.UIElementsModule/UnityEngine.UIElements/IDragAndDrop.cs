using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000194")]
internal interface IDragAndDrop
{
	[Token(Token = "0x1700021F")]
	DragAndDropData data
	{
		[Token(Token = "0x6000C10")]
		get;
	}

	[Token(Token = "0x6000C0B")]
	void StartDrag(StartDragArgs args, Vector3 pointerPosition);

	[Token(Token = "0x6000C0C")]
	void UpdateDrag(Vector3 pointerPosition);

	[Token(Token = "0x6000C0D")]
	void AcceptDrag();

	[Token(Token = "0x6000C0E")]
	void DragCleanup();

	[Token(Token = "0x6000C0F")]
	void SetVisualMode(DragVisualMode visualMode);
}
