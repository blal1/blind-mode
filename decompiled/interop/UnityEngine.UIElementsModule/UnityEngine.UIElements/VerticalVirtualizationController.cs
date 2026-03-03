using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Pool;

namespace UnityEngine.UIElements;

[Token(Token = "0x200006C")]
internal abstract class VerticalVirtualizationController<T> : CollectionVirtualizationController where T : ReusableCollectionItem, new()
{
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x0")]
	private readonly UnityEngine.Pool.ObjectPool<T> m_Pool;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x0")]
	protected BaseVerticalCollectionView m_CollectionView;

	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x0")]
	protected List<T> m_ActiveItems;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x0")]
	protected T m_DraggedItem;

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x0")]
	private int? m_DeferredScrollToItemIndex;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x0")]
	private readonly Action m_PerformDeferredScrollToItem;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x0")]
	private IVisualElementScheduledItem m_ScheduleDeferredScrollToItem;

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x0")]
	private IVisualElementScheduledItem m_ScrollScheduledItem;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x0")]
	private Action m_ScrollCallback;

	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x0")]
	private int m_LastFocusedElementIndex;

	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x0")]
	private List<int> m_LastFocusedElementTreeChildIndexes;

	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x0")]
	protected readonly Func<T, bool> m_VisibleItemPredicateDelegate;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x0")]
	protected List<T> m_ScrollInsertionList;

	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x0")]
	private VisualElement m_EmptyRows;

	[Token(Token = "0x17000080")]
	public override IEnumerable<ReusableCollectionItem> activeItems
	{
		[Token(Token = "0x60003C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000081")]
	internal int itemsCount
	{
		[Token(Token = "0x60003C9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000082")]
	internal T firstVisibleItem
	{
		[Token(Token = "0x60003CB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000083")]
	internal T lastVisibleItem
	{
		[Token(Token = "0x60003CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000084")]
	public override int visibleItemCount
	{
		[Token(Token = "0x60003CD")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000085")]
	protected SerializedVirtualizationData serializedData
	{
		[Token(Token = "0x60003CE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000086")]
	public override int firstVisibleIndex
	{
		[Token(Token = "0x60003CF")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60003D0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000087")]
	protected float lastHeight
	{
		[Token(Token = "0x60003D1")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000088")]
	protected virtual bool alwaysRebindOnRefresh
	{
		[Token(Token = "0x60003D2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003CA")]
	protected virtual bool VisibleItemPredicate(T i)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D3")]
	protected VerticalVirtualizationController(BaseVerticalCollectionView collectionView)
	{
	}

	[Token(Token = "0x60003D4")]
	public override void Refresh(bool rebuild)
	{
	}

	[Token(Token = "0x60003D5")]
	public override void UnbindAll()
	{
	}

	[Token(Token = "0x60003D6")]
	protected void Setup(T recycledItem, int newIndex)
	{
	}

	[Token(Token = "0x60003D7")]
	protected bool ShouldDeferScrollToItem(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D8")]
	protected void ScheduleDeferredScrollToItem()
	{
	}

	[Token(Token = "0x60003D9")]
	private void PerformDeferredScrollToItem()
	{
	}

	[Token(Token = "0x60003DA")]
	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x60003DB")]
	public override void OnFocusIn(VisualElement leafTarget)
	{
	}

	[Token(Token = "0x60003DC")]
	public override void OnFocusOut(VisualElement willFocus)
	{
	}

	[Token(Token = "0x60003DD")]
	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex)
	{
	}

	[Token(Token = "0x60003DE")]
	public override void UpdateBackground()
	{
	}

	[Token(Token = "0x60003DF")]
	internal override void StartDragItem(ReusableCollectionItem item)
	{
	}

	[Token(Token = "0x60003E0")]
	internal override void EndDrag(int dropIndex)
	{
	}

	[Token(Token = "0x60003E1")]
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x60003E2")]
	internal virtual void ReleaseItem(int activeItemsIndex)
	{
	}

	[Token(Token = "0x60003E3")]
	private void OnDestroyItem(ReusableCollectionItem item)
	{
	}

	[Token(Token = "0x60003E4")]
	protected virtual void OnScrollUpdate()
	{
	}

	[Token(Token = "0x60003E5")]
	protected int GetDraggedIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60003E6")]
	protected void ScheduleScroll()
	{
	}
}
