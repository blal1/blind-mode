using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200019C")]
public readonly struct SetupDragAndDropArgs
{
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x0")]
	public readonly VisualElement draggedElement;

	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x8")]
	public readonly IEnumerable<int> selectedIds;

	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x10")]
	public readonly StartDragArgs startDragArgs;

	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x2B227F0", Offset = "0x2B219F0", VA = "0x182B227F0")]
	internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<int> selectedIds, StartDragArgs startDragArgs)
	{
	}
}
