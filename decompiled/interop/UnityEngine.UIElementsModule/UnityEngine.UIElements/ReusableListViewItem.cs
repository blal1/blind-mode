using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000068")]
internal class ReusableListViewItem : ReusableCollectionItem
{
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string k_SortingDisablesReorderingTooltip;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x48")]
	private VisualElement m_Container;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x50")]
	private VisualElement m_DragHandle;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x58")]
	private VisualElement m_ItemContainer;

	[Token(Token = "0x1700007B")]
	public override VisualElement rootElement
	{
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x29AD090", Offset = "0x29AC290", VA = "0x1829AD090", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x29AC870", Offset = "0x29ABA70", VA = "0x1829AC870")]
	public void Init(VisualElement item, bool usesAnimatedDragger)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x29ACCF0", Offset = "0x29ABEF0", VA = "0x1829ACCF0")]
	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x29ACB80", Offset = "0x29ABD80", VA = "0x1829ACB80")]
	public void UpdateDragHandle(bool needsDragHandle)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x29ACAE0", Offset = "0x29ABCE0", VA = "0x1829ACAE0")]
	public void SetDragHandleEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x29AC9E0", Offset = "0x29ABBE0", VA = "0x1829AC9E0", Slot = "6")]
	public override void PreAttachElement()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x29AC7E0", Offset = "0x29AB9E0", VA = "0x1829AC7E0", Slot = "7")]
	public override void DetachElement()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x29ACA70", Offset = "0x29ABC70", VA = "0x1829ACA70", Slot = "10")]
	public override void SetDragGhost(bool dragGhost)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x29AC950", Offset = "0x29ABB50", VA = "0x1829AC950", Slot = "11")]
	protected override void OnGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x29AD080", Offset = "0x29AC280", VA = "0x1829AD080")]
	public ReusableListViewItem()
	{
	}
}
