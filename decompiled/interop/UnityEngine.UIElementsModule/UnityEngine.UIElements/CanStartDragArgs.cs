using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200019B")]
public readonly struct CanStartDragArgs
{
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x0")]
	public readonly VisualElement draggedElement;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x8")]
	public readonly int id;

	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x10")]
	public readonly IEnumerable<int> selectedIds;

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x2B0E1F0", Offset = "0x2B0D3F0", VA = "0x182B0E1F0")]
	internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<int> selectedIds)
	{
	}
}
