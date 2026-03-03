using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200018F")]
internal static class DragAndDropUtility
{
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x0")]
	private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc;

	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x8")]
	private static IDragAndDrop s_DragAndDropEditor;

	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x10")]
	private static IDragAndDrop s_DragAndDropPlayMode;

	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x2AF6580", Offset = "0x2AF5780", VA = "0x182AF6580")]
	internal static IDragAndDrop GetDragAndDrop(IPanel panel)
	{
		return null;
	}
}
