using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000199")]
internal interface IDragAndDropController<in TArgs>
{
	[Token(Token = "0x6000C25")]
	bool CanStartDrag(IEnumerable<int> itemIds);

	[Token(Token = "0x6000C26")]
	StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false);

	[Token(Token = "0x6000C27")]
	DragVisualMode HandleDragAndDrop(TArgs args);

	[Token(Token = "0x6000C28")]
	void OnDrop(TArgs args);

	[Token(Token = "0x6000C29")]
	void DragCleanup()
	{
	}

	[Token(Token = "0x6000C2A")]
	void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
	{
	}

	[Token(Token = "0x6000C2B")]
	IEnumerable<int> GetSortedSelectedIds()
	{
		return null;
	}
}
