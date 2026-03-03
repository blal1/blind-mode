using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001A5")]
internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	[Token(Token = "0x20001A6")]
	protected class DropData
	{
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x10")]
		public int[] expandedIdsBeforeDrag;

		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x18")]
		public int[] draggedIds;

		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x20")]
		public int lastItemId;

		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x24")]
		public float expandItemBeginTimerMs;

		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 expandItemBeginPosition;

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x2B0ED70", Offset = "0x2B0DF70", VA = "0x182B0ED70")]
		public DropData()
		{
		}
	}

	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x28")]
	protected DropData m_DropData;

	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x30")]
	protected readonly BaseTreeView m_TreeView;

	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x38")]
	private IVisualElementScheduledItem m_ExpandDropItemScheduledItem;

	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x40")]
	private Action m_ExpandDropItemCallback;

	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x2B241F0", Offset = "0x2B233F0", VA = "0x182B241F0")]
	public TreeViewReorderableDragAndDropController(BaseTreeView view)
	{
	}

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x2B229B0", Offset = "0x2B21BB0", VA = "0x182B229B0", Slot = "18")]
	protected override int CompareId(int id1, int id2)
	{
		return default(int);
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x2B24050", Offset = "0x2B23250", VA = "0x182B24050", Slot = "17")]
	public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
	{
		return default(StartDragArgs);
	}

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x2B23730", Offset = "0x2B22930", VA = "0x182B23730", Slot = "19")]
	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
	{
		return default(DragVisualMode);
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x2B22970", Offset = "0x2B21B70", VA = "0x182B22970", Slot = "16")]
	public override bool CanDrop()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x2B237E0", Offset = "0x2B229E0", VA = "0x182B237E0", Slot = "20")]
	public override void OnDrop(IListDragAndDropArgs args)
	{
	}

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x2B23220", Offset = "0x2B22420", VA = "0x182B23220", Slot = "21")]
	public override void DragCleanup()
	{
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x2B23E10", Offset = "0x2B23010", VA = "0x182B23E10")]
	private void RestoreExpanded(List<int> ids)
	{
	}

	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x2B235B0", Offset = "0x2B227B0", VA = "0x182B235B0", Slot = "22")]
	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
	{
	}

	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x2B23040", Offset = "0x2B22240", VA = "0x182B23040")]
	private void DelayExpandDropItem()
	{
	}

	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x2B23330", Offset = "0x2B22530", VA = "0x182B23330")]
	private void ExpandDropItem()
	{
	}
}
