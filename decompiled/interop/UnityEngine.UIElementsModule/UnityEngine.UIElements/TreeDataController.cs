using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Hierarchy;

namespace UnityEngine.UIElements;

[Token(Token = "0x200005E")]
internal sealed class TreeDataController<T>
{
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<HierarchyNode, TreeViewItemData<T>> m_NodeToItemDataDictionary;

	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x0")]
	private Stack<IEnumerator<TreeViewItemData<T>>> m_ItemStack;

	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x0")]
	private Stack<HierarchyNode> m_NodeStack;

	[Token(Token = "0x6000331")]
	public T GetDataForNode(HierarchyNode node)
	{
		return (T)null;
	}

	[Token(Token = "0x6000332")]
	internal void ConvertTreeViewItemDataToHierarchy(IEnumerable<TreeViewItemData<T>> list, Func<HierarchyNode, HierarchyNode> createNode, Action<int, HierarchyNode> updateDictionary)
	{
	}

	[Token(Token = "0x6000333")]
	internal void UpdateNodeToDataDictionary(HierarchyNode node, TreeViewItemData<T> item)
	{
	}

	[Token(Token = "0x6000334")]
	internal void ClearNodeToDataDictionary()
	{
	}

	[Token(Token = "0x6000335")]
	public TreeDataController()
	{
	}
}
