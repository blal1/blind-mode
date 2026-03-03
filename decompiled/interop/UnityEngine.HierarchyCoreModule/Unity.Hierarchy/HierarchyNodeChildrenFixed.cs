using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Hierarchy;

[StructLayout(LayoutKind.Explicit)]
public struct HierarchyNodeChildrenFixed
{
	public const int Capacity = 4;

	public HierarchyNode m_Node1;

	public HierarchyNode m_Node2;

	public HierarchyNode m_Node3;

	public HierarchyNode m_Node4;

	public unsafe HierarchyNode* Ptr => (HierarchyNode*)UnsafeUtility.AddressOf(ref m_Node1);
}
