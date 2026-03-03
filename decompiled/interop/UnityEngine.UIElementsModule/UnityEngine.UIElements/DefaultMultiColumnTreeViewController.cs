using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000059")]
public class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController
{
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x0")]
	private TreeDataController<T> m_TreeDataController;

	[Token(Token = "0x17000062")]
	private TreeDataController<T> treeDataController
	{
		[Token(Token = "0x6000301")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000063")]
	public override IList itemsSource
	{
		[Token(Token = "0x6000303")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000304")]
		set
		{
		}
	}

	[Token(Token = "0x6000302")]
	public DefaultMultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
	{
	}

	[Token(Token = "0x6000305")]
	public void SetRootItems(IList<TreeViewItemData<T>> items)
	{
	}

	[Token(Token = "0x6000306")]
	public override object GetItemForIndex(int index)
	{
		return null;
	}
}
