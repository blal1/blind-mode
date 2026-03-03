using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200005D")]
public abstract class MultiColumnTreeViewController : BaseTreeViewController
{
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x68")]
	private MultiColumnController m_ColumnController;

	[Token(Token = "0x17000068")]
	public MultiColumnController columnController
	{
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x29AB7E0", Offset = "0x29AA9E0", VA = "0x1829AB7E0")]
	protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x29AB750", Offset = "0x29AA950", VA = "0x1829AB750", Slot = "19")]
	internal override void PreRefresh()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x29AB5F0", Offset = "0x29AA7F0", VA = "0x1829AB5F0", Slot = "14")]
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x29AB730", Offset = "0x29AA930", VA = "0x1829AB730", Slot = "20")]
	protected override VisualElement MakeItem()
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x29AB4C0", Offset = "0x29AA6C0", VA = "0x1829AB4C0", Slot = "21")]
	protected override void BindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x29AB7C0", Offset = "0x29AA9C0", VA = "0x1829AB7C0", Slot = "22")]
	protected override void UnbindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x29AB560", Offset = "0x29AA760", VA = "0x1829AB560", Slot = "23")]
	protected override void DestroyItem(VisualElement element)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x29AB790", Offset = "0x29AA990", VA = "0x1829AB790", Slot = "7")]
	protected override void PrepareView()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x29AB580", Offset = "0x29AA780", VA = "0x1829AB580", Slot = "8")]
	public override void Dispose()
	{
	}
}
