using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001A0")]
internal class ListViewDragger : DragEventsProcessor
{
	[Token(Token = "0x20001A1")]
	internal struct DragPosition : IEquatable<DragPosition>
	{
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x0")]
		public int insertAtIndex;

		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x4")]
		public int parentId;

		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x8")]
		public int childIndex;

		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x10")]
		public ReusableCollectionItem recycledItem;

		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x18")]
		public DragAndDropPosition dropPosition;

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x2B0EC90", Offset = "0x2B0DE90", VA = "0x182B0EC90", Slot = "4")]
		public bool Equals(DragPosition other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x2B0EBB0", Offset = "0x2B0DDB0", VA = "0x182B0EBB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x2B0ECF0", Offset = "0x2B0DEF0", VA = "0x182B0ECF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x30")]
	private DragPosition m_LastDragPosition;

	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x50")]
	private VisualElement m_DragHoverBar;

	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x58")]
	private VisualElement m_DragHoverItemMarker;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x60")]
	private VisualElement m_DragHoverSiblingMarker;

	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x68")]
	private float m_LeftIndentation;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x6C")]
	private float m_SiblingBottom;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x70")]
	private bool m_Enabled;

	[Token(Token = "0x17000233")]
	protected BaseVerticalCollectionView targetView
	{
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x2B1DD00", Offset = "0x2B1CF00", VA = "0x182B1DD00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000234")]
	protected ScrollView targetScrollView
	{
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x2B1DCD0", Offset = "0x2B1CED0", VA = "0x182B1DCD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000235")]
	public ICollectionDragAndDropController dragAndDropController
	{
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000236")]
	internal bool enabled
	{
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x49BE90", Offset = "0x49B090", VA = "0x18049BE90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x2B1DD80", Offset = "0x2B1CF80", VA = "0x182B1DD80")]
		set
		{
		}
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x2B19E20", Offset = "0x2B19020", VA = "0x182B19E20")]
	public ListViewDragger(BaseVerticalCollectionView listView)
	{
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x2B1A950", Offset = "0x2B19B50", VA = "0x182B1A950", Slot = "6")]
	protected override bool CanStartDrag(Vector3 pointerPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x2B1CF70", Offset = "0x2B1C170", VA = "0x182B1CF70", Slot = "7")]
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition)
	{
		return default(StartDragArgs);
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x2B1D840", Offset = "0x2B1CA40", VA = "0x182B1D840", Slot = "8")]
	protected internal override void UpdateDrag(Vector3 pointerPosition)
	{
	}

	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x2B1B4E0", Offset = "0x2B1A6E0", VA = "0x182B1B4E0")]
	private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition)
	{
		return default(DragVisualMode);
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x2B1C4D0", Offset = "0x2B1B6D0", VA = "0x182B1C4D0", Slot = "9")]
	protected internal override void OnDrop(Vector3 pointerPosition)
	{
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x2B1B770", Offset = "0x2B1A970", VA = "0x182B1B770")]
	internal void HandleDragAndScroll(Vector2 pointerPosition)
	{
	}

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x2B1B660", Offset = "0x2B1A860", VA = "0x182B1B660")]
	private void HandleAutoExpansion(Vector2 pointerPosition)
	{
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x2B1A160", Offset = "0x2B19360", VA = "0x182B1A160")]
	private void ApplyDragAndDropUI(DragPosition dragPosition)
	{
	}

	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x2B1D350", Offset = "0x2B1C550", VA = "0x182B1D350", Slot = "11")]
	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x2B1C1C0", Offset = "0x2B1B3C0", VA = "0x182B1C1C0")]
	private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition)
	{
	}

	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x2B1BA10", Offset = "0x2B1AC10", VA = "0x182B1BA10")]
	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition)
	{
	}

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x2B1B100", Offset = "0x2B1A300", VA = "0x182B1B100")]
	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId)
	{
	}

	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x2B1C380", Offset = "0x2B1B580", VA = "0x182B1C380")]
	protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition)
	{
		return default(DragAndDropArgs);
	}

	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x2B1B010", Offset = "0x2B1A210", VA = "0x182B1B010")]
	private float GetHoverBarTopPosition(ReusableCollectionItem item)
	{
		return default(float);
	}

	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x2B1C710", Offset = "0x2B1B910", VA = "0x182B1C710")]
	private void PlaceHoverBarAtElement(ReusableCollectionItem item)
	{
	}

	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x2B1C830", Offset = "0x2B1BA30", VA = "0x182B1C830")]
	private void PlaceHoverBarAt(float top, float indentationPadding = -1f, float siblingBottom = -1f)
	{
	}

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x2B1AC50", Offset = "0x2B19E50", VA = "0x182B1AC50", Slot = "10")]
	protected override void ClearDragAndDropUI(bool dragCancelled)
	{
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x2B1B2D0", Offset = "0x2B1A4D0", VA = "0x182B1B2D0")]
	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition)
	{
		return null;
	}

	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x2B1C2E0", Offset = "0x2B1B4E0", VA = "0x182B1C2E0")]
	private bool IsDraggingDisabled()
	{
		return default(bool);
	}
}
