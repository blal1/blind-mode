using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200005C")]
public class MultiColumnListViewController : BaseListViewController
{
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x48")]
	private MultiColumnController m_ColumnController;

	[Token(Token = "0x17000067")]
	public MultiColumnController columnController
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x29AB340", Offset = "0x29AA540", VA = "0x1829AB340")]
	public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x29AB0B0", Offset = "0x29AA2B0", VA = "0x1829AB0B0", Slot = "19")]
	internal override void PreRefresh()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x29AB200", Offset = "0x29AA400", VA = "0x1829AB200")]
	private void SortIfNeeded()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x29AAE20", Offset = "0x29AA020", VA = "0x1829AAE20", Slot = "14")]
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x29AACB0", Offset = "0x29A9EB0", VA = "0x1829AACB0", Slot = "16")]
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x29AAC00", Offset = "0x29A9E00", VA = "0x1829AAC00", Slot = "13")]
	public override object GetItemForIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x29AABE0", Offset = "0x29A9DE0", VA = "0x1829AABE0", Slot = "11")]
	public override int GetIndexForId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x29AABC0", Offset = "0x29A9DC0", VA = "0x1829AABC0", Slot = "12")]
	public override int GetIdForIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x29AB090", Offset = "0x29AA290", VA = "0x1829AB090", Slot = "20")]
	protected override VisualElement MakeItem()
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x29AA990", Offset = "0x29A9B90", VA = "0x1829AA990", Slot = "21")]
	protected override void BindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x29AB250", Offset = "0x29AA450", VA = "0x1829AB250", Slot = "22")]
	protected override void UnbindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x29AAA30", Offset = "0x29A9C30", VA = "0x1829AAA30", Slot = "23")]
	protected override void DestroyItem(VisualElement element)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x29AB0D0", Offset = "0x29AA2D0", VA = "0x1829AB0D0", Slot = "7")]
	protected override void PrepareView()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x29AAA50", Offset = "0x29A9C50", VA = "0x1829AAA50", Slot = "8")]
	public override void Dispose()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x29AB270", Offset = "0x29AA470", VA = "0x1829AB270")]
	private void UpdateReorderClassList()
	{
	}
}
