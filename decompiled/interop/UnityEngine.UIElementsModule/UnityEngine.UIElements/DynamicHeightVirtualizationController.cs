using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000061")]
internal class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
{
	[Token(Token = "0x2000062")]
	private readonly struct ContentHeightCacheInfo
	{
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		public readonly float sum;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x0")]
		public readonly int count;

		[Token(Token = "0x600037E")]
		public ContentHeightCacheInfo(float sum, int count)
		{
		}
	}

	[Token(Token = "0x2000063")]
	private enum VirtualizationChange
	{
		[Token(Token = "0x40001DC")]
		None,
		[Token(Token = "0x40001DD")]
		Resize,
		[Token(Token = "0x40001DE")]
		Scroll,
		[Token(Token = "0x40001DF")]
		ForcedScroll
	}

	[Token(Token = "0x2000064")]
	private enum ScrollDirection
	{
		[Token(Token = "0x40001E1")]
		Idle,
		[Token(Token = "0x40001E2")]
		Up,
		[Token(Token = "0x40001E3")]
		Down
	}

	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x0")]
	private int m_HighestCachedIndex;

	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x0")]
	private readonly Dictionary<int, float> m_ItemHeightCache;

	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x0")]
	private readonly Dictionary<int, ContentHeightCacheInfo> m_ContentHeightCache;

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x0")]
	private readonly HashSet<int> m_WaitingCache;

	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x0")]
	private int? m_ScrolledToItemIndex;

	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x0")]
	private int m_ForcedFirstVisibleItem;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x0")]
	private int m_ForcedLastVisibleItem;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x0")]
	private bool m_StickToBottom;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x0")]
	private VirtualizationChange m_LastChange;

	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x0")]
	private ScrollDirection m_ScrollDirection;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x0")]
	private Vector2 m_DelayedScrollOffset;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x0")]
	private float m_AccumulatedHeight;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x0")]
	private float m_MinimumItemHeight;

	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x0")]
	private Action m_FillCallback;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x0")]
	private Action m_ScrollResetCallback;

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x0")]
	private Action<ReusableCollectionItem> m_GeometryChangedCallback;

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x0")]
	private IVisualElementScheduledItem m_ScheduledItem;

	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x0")]
	private IVisualElementScheduledItem m_ScrollResetScheduledItem;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x0")]
	private IVisualElementScheduledItem m_RefreshScrollOffsetScheduledItem;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x0")]
	private Predicate<int> m_IndexOutOfBoundsPredicate;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x0")]
	private bool m_FillExecuted;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x0")]
	private long m_TimeSinceFillScheduledMs;

	[Token(Token = "0x1700006D")]
	private float defaultExpectedHeight
	{
		[Token(Token = "0x600034E")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700006E")]
	private float contentPadding
	{
		[Token(Token = "0x600034F")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000350")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	private float contentHeight
	{
		[Token(Token = "0x6000351")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000352")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	private int anchoredIndex
	{
		[Token(Token = "0x6000353")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000354")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	private float anchorOffset
	{
		[Token(Token = "0x6000355")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000356")]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	private float viewportMaxOffset
	{
		[Token(Token = "0x6000357")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000073")]
	protected override bool alwaysRebindOnRefresh
	{
		[Token(Token = "0x6000358")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000359")]
	public DynamicHeightVirtualizationController(BaseVerticalCollectionView collectionView)
	{
	}

	[Token(Token = "0x600035A")]
	private void OnGeometryChangedEvent(GeometryChangedEvent _)
	{
	}

	[Token(Token = "0x600035B")]
	public override void Refresh(bool rebuild)
	{
	}

	[Token(Token = "0x600035C")]
	public override void ScrollToItem(int index)
	{
	}

	[Token(Token = "0x600035D")]
	public override void Resize(Vector2 size)
	{
	}

	[Token(Token = "0x600035E")]
	public override void OnScroll(Vector2 scrollOffset)
	{
	}

	[Token(Token = "0x600035F")]
	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x6000360")]
	protected override void OnScrollUpdate()
	{
	}

	[Token(Token = "0x6000361")]
	private void CycleItems(int firstIndex)
	{
	}

	[Token(Token = "0x6000362")]
	private bool NeedsFill()
	{
		return default(bool);
	}

	[Token(Token = "0x6000363")]
	private void Fill()
	{
	}

	[Token(Token = "0x6000364")]
	private void UpdateScrollViewContainer(float previousHeight, float newHeight)
	{
	}

	[Token(Token = "0x6000365")]
	private void ApplyScrollViewUpdate(bool dimensionsOnly = false)
	{
	}

	[Token(Token = "0x6000366")]
	private void UpdateAnchor()
	{
	}

	[Token(Token = "0x6000367")]
	private void ScheduleFill()
	{
	}

	[Token(Token = "0x6000368")]
	private void ScheduleScrollDirectionReset()
	{
	}

	[Token(Token = "0x6000369")]
	private void ResetScroll()
	{
	}

	[Token(Token = "0x600036A")]
	public override int GetIndexFromPosition(Vector2 position)
	{
		return default(int);
	}

	[Token(Token = "0x600036B")]
	public override float GetExpectedItemHeight(int index)
	{
		return default(float);
	}

	[Token(Token = "0x600036C")]
	private int GetFirstVisibleItem(float offset)
	{
		return default(int);
	}

	[Token(Token = "0x600036D")]
	public override float GetExpectedContentHeight()
	{
		return default(float);
	}

	[Token(Token = "0x600036E")]
	private float GetContentHeightForIndex(int lastIndex)
	{
		return default(float);
	}

	[Token(Token = "0x600036F")]
	private ContentHeightCacheInfo GetCachedContentHeight(int index)
	{
		return default(ContentHeightCacheInfo);
	}

	[Token(Token = "0x6000370")]
	private void RegisterItemHeight(int index, float height)
	{
	}

	[Token(Token = "0x6000371")]
	private void UnregisterItemHeight(int index)
	{
	}

	[Token(Token = "0x6000372")]
	private void CleanItemHeightCache()
	{
	}

	[Token(Token = "0x6000373")]
	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item)
	{
	}

	[Token(Token = "0x6000374")]
	private bool UpdateRegisteredHeight(ReusableCollectionItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000375")]
	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x6000376")]
	internal override void ReleaseItem(int activeItemsIndex)
	{
	}

	[Token(Token = "0x6000377")]
	internal override void StartDragItem(ReusableCollectionItem item)
	{
	}

	[Token(Token = "0x6000378")]
	internal override void EndDrag(int dropIndex)
	{
	}

	[Token(Token = "0x6000379")]
	private void HideItem(int activeItemsIndex)
	{
	}

	[Token(Token = "0x600037A")]
	private void MarkWaitingForLayout(T item)
	{
	}

	[Token(Token = "0x600037B")]
	private bool IsIndexOutOfBounds(int i)
	{
		return default(bool);
	}

	[Token(Token = "0x600037C")]
	private void RefreshScrollOffset()
	{
	}
}
