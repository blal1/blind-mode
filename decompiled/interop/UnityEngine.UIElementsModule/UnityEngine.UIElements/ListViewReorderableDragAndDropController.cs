using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001A4")]
internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x28")]
	protected readonly BaseListView m_ListView;

	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x2B1E400", Offset = "0x2B1D600", VA = "0x182B1E400")]
	public ListViewReorderableDragAndDropController(BaseListView view)
	{
	}

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x2B1E070", Offset = "0x2B1D270", VA = "0x182B1E070", Slot = "19")]
	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
	{
		return default(DragVisualMode);
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x2B1E140", Offset = "0x2B1D340", VA = "0x182B1E140", Slot = "20")]
	public override void OnDrop(IListDragAndDropArgs args)
	{
	}
}
