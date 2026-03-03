using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001A3")]
internal class ListViewDraggerAnimated : ListViewDragger
{
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x80")]
	private int m_DragStartIndex;

	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x84")]
	private int m_CurrentIndex;

	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x88")]
	private float m_SelectionHeight;

	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x8C")]
	private float m_LocalOffsetOnStart;

	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_CurrentPointerPosition;

	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0xA0")]
	private ReusableCollectionItem m_Item;

	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0xA8")]
	private ReusableCollectionItem m_OffsetItem;

	[Token(Token = "0x17000237")]
	public bool isDragging
	{
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x150BFE0", Offset = "0x150B1E0", VA = "0x18150BFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x2583430", Offset = "0x2582630", VA = "0x182583430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000238")]
	public ReusableCollectionItem draggedItem
	{
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000239")]
	protected override bool supportsDragEvents
	{
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x2B19E20", Offset = "0x2B19020", VA = "0x182B19E20")]
	public ListViewDraggerAnimated(BaseVerticalCollectionView listView)
	{
	}

	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x2B18BD0", Offset = "0x2B17DD0", VA = "0x182B18BD0", Slot = "7")]
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition)
	{
		return default(StartDragArgs);
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x2B195E0", Offset = "0x2B187E0", VA = "0x182B195E0", Slot = "8")]
	protected internal override void UpdateDrag(Vector3 pointerPosition)
	{
	}

	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x2B18410", Offset = "0x2B17610", VA = "0x182B18410")]
	private void Animate(ReusableCollectionItem element, float paddingTop)
	{
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x2B187E0", Offset = "0x2B179E0", VA = "0x182B187E0", Slot = "9")]
	protected internal override void OnDrop(Vector3 pointerPosition)
	{
	}

	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	protected override void ClearDragAndDropUI(bool dragCancelled)
	{
	}

	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x2B195A0", Offset = "0x2B187A0", VA = "0x182B195A0", Slot = "11")]
	protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition)
	{
		return default(bool);
	}
}
