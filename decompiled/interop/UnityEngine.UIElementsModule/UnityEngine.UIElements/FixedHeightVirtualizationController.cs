using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000066")]
internal class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
{
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x0")]
	private int? m_ScrolledToItemIndex;

	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x0")]
	private bool m_ForcedScroll;

	[Token(Token = "0x17000074")]
	private float resolvedItemHeight
	{
		[Token(Token = "0x600037F")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000380")]
	protected override bool VisibleItemPredicate(T i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000381")]
	public FixedHeightVirtualizationController(BaseVerticalCollectionView collectionView)
	{
	}

	[Token(Token = "0x6000382")]
	private void OnGeometryChangedEvent(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x6000383")]
	public override int GetIndexFromPosition(Vector2 position)
	{
		return default(int);
	}

	[Token(Token = "0x6000384")]
	public override float GetExpectedItemHeight(int index)
	{
		return default(float);
	}

	[Token(Token = "0x6000385")]
	public override float GetExpectedContentHeight()
	{
		return default(float);
	}

	[Token(Token = "0x6000386")]
	public override void ScrollToItem(int index)
	{
	}

	[Token(Token = "0x6000387")]
	public override void Resize(Vector2 size)
	{
	}

	[Token(Token = "0x6000388")]
	public override void OnScroll(Vector2 scrollOffset)
	{
	}

	[Token(Token = "0x6000389")]
	protected override void OnScrollUpdate()
	{
	}

	[Token(Token = "0x600038A")]
	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x600038B")]
	internal override void EndDrag(int dropIndex)
	{
	}
}
