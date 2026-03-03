using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200018E")]
internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController<IListDragAndDropArgs>, IReorderable
{
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x10")]
	protected readonly BaseVerticalCollectionView m_View;

	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x18")]
	protected List<int> m_SortedSelectedIds;

	[Token(Token = "0x17000218")]
	public virtual bool enableReordering
	{
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "10")]
	public IEnumerable<int> GetSortedSelectedIds()
	{
		return null;
	}

	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x2AF3FB0", Offset = "0x2AF31B0", VA = "0x182AF3FB0")]
	protected BaseReorderableDragAndDropController(BaseVerticalCollectionView view)
	{
	}

	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x1521C70", Offset = "0x1520E70", VA = "0x181521C70", Slot = "15")]
	public virtual bool CanStartDrag(IEnumerable<int> itemIds)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x1521C70", Offset = "0x1520E70", VA = "0x181521C70", Slot = "16")]
	public virtual bool CanDrop()
	{
		return default(bool);
	}

	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x2AF3B10", Offset = "0x2AF2D10", VA = "0x182AF3B10", Slot = "17")]
	public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
	{
		return default(StartDragArgs);
	}

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x2AF3AF0", Offset = "0x2AF2CF0", VA = "0x182AF3AF0", Slot = "18")]
	protected virtual int CompareId(int id1, int id2)
	{
		return default(int);
	}

	[Token(Token = "0x6000BE5")]
	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);

	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "20")]
	public virtual void OnDrop(IListDragAndDropArgs args)
	{
	}

	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "21")]
	public virtual void DragCleanup()
	{
	}

	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "22")]
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
	{
	}
}
