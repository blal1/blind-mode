using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200005A")]
public class DefaultTreeViewController<T> : TreeViewController
{
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x0")]
	private TreeDataController<T> m_TreeDataController;

	[Token(Token = "0x17000064")]
	private TreeDataController<T> treeDataController
	{
		[Token(Token = "0x6000309")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000065")]
	public override IList itemsSource
	{
		[Token(Token = "0x600030A")]
		get
		{
			return null;
		}
		[Token(Token = "0x600030B")]
		set
		{
		}
	}

	[Token(Token = "0x600030C")]
	public void SetRootItems(IList<TreeViewItemData<T>> items)
	{
	}

	[Token(Token = "0x600030D")]
	public override object GetItemForIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600030E")]
	public DefaultTreeViewController()
	{
	}
}
