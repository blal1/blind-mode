using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Accessibility;

public class AccessibilityHierarchy : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_RootNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Nodes;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNode_Public_Boolean_Int32_byref_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeNative_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNodeAt_Public_Boolean_Single_Single_byref_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_AccessibilityNode_IList_1_AccessibilityNode_Vector2_0;

	public unsafe List<AccessibilityNode> m_RootNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootNodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AccessibilityNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IDictionary<int, AccessibilityNode> m_Nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Nodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<int, AccessibilityNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Nodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public IReadOnlyList<AccessibilityNode> rootNodes => (IReadOnlyList<AccessibilityNode>)(object)m_RootNodes;

	static AccessibilityHierarchy()
	{
		Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilityHierarchy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr);
		NativeFieldInfoPtr_m_RootNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr, "m_RootNodes");
		NativeFieldInfoPtr_m_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr, "m_Nodes");
		NativeMethodInfoPtr_TryGetNode_Public_Boolean_Int32_byref_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_FreeNative_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_TryGetNodeAt_Public_Boolean_Single_Single_byref_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_Method_Internal_Static_AccessibilityNode_IList_1_AccessibilityNode_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchy>.NativeClassPtr, 100663394);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1147970, RefRangeEnd = 1147978, XrefRangeStart = 1147965, XrefRangeEnd = 1147970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetNode(int id, out AccessibilityNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetNode_Public_Boolean_Int32_byref_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		node = ((num3 == 0) ? null : new AccessibilityNode(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1147993, RefRangeEnd = 1147995, XrefRangeStart = 1147978, XrefRangeEnd = 1147993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeNative()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeNative_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147995, XrefRangeEnd = 1147997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetNodeAt(float horizontalPosition, float verticalPosition, out AccessibilityNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&horizontalPosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &verticalPosition;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetNodeAt_Public_Boolean_Single_Single_byref_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		node = ((num3 == 0) ? null : new AccessibilityNode(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1148005, RefRangeEnd = 1148009, XrefRangeStart = 1147997, XrefRangeEnd = 1148005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AccessibilityNode Method_Internal_Static_AccessibilityNode_IList_1_AccessibilityNode_Vector2_0(IList<AccessibilityNode> nodes, Vector2 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_AccessibilityNode_IList_1_AccessibilityNode_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityNode>(intPtr2) : null;
	}

	public AccessibilityHierarchy(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public void add_m_Changed(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_m_Changed(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_changed(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		add_m_Changed(value);
	}

	[SpecialName]
	public void remove_changed(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		remove_m_Changed(value);
	}

	public void NotifyHierarchyChanged()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Clear()
	{
		for (int num = m_RootNodes.Count - 1; num >= 0; num--)
		{
			RemoveNode(m_RootNodes[num], removeChildren: true);
		}
	}

	public AccessibilityNode AddNode([Optional] string label, [Optional] AccessibilityNode parent)
	{
		return InsertNode(-1, label, parent);
	}

	public AccessibilityNode InsertNode(int childIndex, [Optional] string label, [Optional] AccessibilityNode parent)
	{
		if (parent != null)
		{
			ValidateNodeInHierarchy(parent);
		}
		AccessibilityNode accessibilityNode = GenerateNewNode();
		m_Nodes[accessibilityNode.id] = accessibilityNode;
		if (label != null)
		{
			accessibilityNode.label = label;
		}
		IList<AccessibilityNode> newParentChildren;
		if (parent != null)
		{
			newParentChildren = parent.childList;
		}
		else
		{
			IList<AccessibilityNode> list = (IList<AccessibilityNode>)(object)m_RootNodes;
			newParentChildren = list;
		}
		SetParent(accessibilityNode, parent, null, newParentChildren, childIndex);
		NotifyHierarchyChanged();
		return accessibilityNode;
	}

	public bool MoveNode(AccessibilityNode node, AccessibilityNode newParent, [Optional] int newChildIndex)
	{
		ValidateNodeInHierarchy(node);
		if (node == newParent)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Attempting to move the node {0} under itself.", (Il2CppSystem.Object)node));
		}
		if (node.parent == newParent)
		{
			IList<AccessibilityNode> list;
			if (newParent != null)
			{
				list = newParent.childList;
			}
			else
			{
				IList<AccessibilityNode> list2 = (IList<AccessibilityNode>)(object)m_RootNodes;
				list = list2;
			}
			IList<AccessibilityNode> list3 = list;
			if (newChildIndex == list3.IndexOf(node))
			{
				return false;
			}
			CheckForLoopsAndSetParent(node, newParent, newChildIndex);
			return true;
		}
		if (newParent == null)
		{
			if (node.parent == null)
			{
				return false;
			}
			CheckForLoopsAndSetParent(node, null, newChildIndex);
			return true;
		}
		ValidateNodeInHierarchy(newParent);
		CheckForLoopsAndSetParent(node, newParent, newChildIndex);
		NotifyHierarchyChanged();
		return true;
	}

	public void RemoveNode(AccessibilityNode node, [Optional] bool removeChildren)
	{
		ValidateNodeInHierarchy(node);
		if (removeChildren)
		{
			_003CRemoveNode_003Eg__removeFromNodes_007C20_0(node);
		}
		else
		{
			m_Nodes.Remove(node.id);
		}
		if (m_RootNodes.Contains(node))
		{
			m_RootNodes.Remove(node);
			if (!removeChildren)
			{
				m_RootNodes.AddRange((IEnumerable<AccessibilityNode>)(object)node.childList);
			}
		}
		node.Destroy(removeChildren);
		NotifyHierarchyChanged();
	}

	public bool ContainsNode(AccessibilityNode node)
	{
		return node != null && m_Nodes.ContainsKey(node.id) && m_Nodes[node.id] == node;
	}

	public void CheckForLoopsAndSetParent(AccessibilityNode node, AccessibilityNode parent, [Optional] int newChildIndex)
	{
		if (parent == null)
		{
			SetParent(node, null, (IList<AccessibilityNode>)(((object)node.parent?.childList) ?? ((object)m_RootNodes)), (IList<AccessibilityNode>)(object)m_RootNodes, newChildIndex);
			return;
		}
		if (node.parent == parent)
		{
			SetParent(node, parent, parent.childList, parent.childList, newChildIndex);
			return;
		}
		if (node.parent == null && parent.parent == null)
		{
			SetParent(node, parent, (IList<AccessibilityNode>)(object)m_RootNodes, parent.childList, newChildIndex);
			return;
		}
		for (AccessibilityNode parent2 = parent.parent; parent2 != null; parent2 = parent2.parent)
		{
			if (parent2 == node)
			{
				throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Trying to set the node {0} to have parent {1}, but this would create a loop.", node, parent));
			}
		}
		SetParent(node, parent, (IList<AccessibilityNode>)(((object)node.parent?.childList) ?? ((object)m_RootNodes)), parent.childList, newChildIndex);
	}

	public void SetParent(AccessibilityNode node, AccessibilityNode parent, IList<AccessibilityNode> previousParentChildren, IList<AccessibilityNode> newParentChildren, [Optional] int newChildIndex)
	{
		((ICollection<AccessibilityNode>)(object)previousParentChildren)?.Remove(node);
		node.SetParent(parent, newChildIndex);
		if (newChildIndex < 0 || newChildIndex > ((ICollection<AccessibilityNode>)(object)newParentChildren).Count)
		{
			((ICollection<AccessibilityNode>)(object)newParentChildren).Add(node);
		}
		else
		{
			newParentChildren.Insert(newChildIndex, node);
		}
	}

	public unsafe void AllocateNative()
	{
		//IL_0039: Expected O, but got Ref
		//IL_0028: Expected O, but got Ref
		//IL_0017: Expected O, but got Ref
		List<AccessibilityNode>.Enumerator enumerator = m_RootNodes.GetEnumerator();
		try
		{
			while (((List<AccessibilityNode>.Enumerator)(&enumerator)).MoveNext())
			{
				AccessibilityNode current = ((List<AccessibilityNode>.Enumerator)(&enumerator)).Current;
				current.AllocateNative();
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(List<AccessibilityNode>.Enumerator)(&enumerator)).Dispose();
		}
	}

	public void RefreshNodeFrames()
	{
		IEnumerator<AccessibilityNode> enumerator = ((IEnumerable<AccessibilityNode>)(object)m_Nodes.Values).GetEnumerator();
		try
		{
			while (((IEnumerator)(object)enumerator).MoveNext())
			{
				AccessibilityNode current = enumerator.Current;
				current.CalculateFrame();
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)enumerator)?.Dispose();
		}
		AssistiveSupport.OnHierarchyNodeFramesRefreshed(this);
	}

	public AccessibilityNode GetLowestCommonAncestor(AccessibilityNode firstNode, AccessibilityNode secondNode)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public AccessibilityNode GenerateNewNode()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ValidateNodeInHierarchy(AccessibilityNode node)
	{
		if (node != null)
		{
			if (ContainsNode(node))
			{
				return;
			}
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Trying to use an AccessibilityNode with ID {0} that is not part of this hierarchy.", (Il2CppSystem.Object)(object)node.id));
		}
		throw new Il2CppSystem.ArgumentNullException("node");
	}

	public void _003CRemoveNode_003Eg__removeFromNodes_007C20_0(AccessibilityNode child)
	{
		m_Nodes.Remove(child.id);
		for (int i = 0; i < ((ICollection<AccessibilityNode>)(object)child.childList).Count; i++)
		{
			_003CRemoveNode_003Eg__removeFromNodes_007C20_0(child.childList[i]);
		}
	}

	public void _003CGetLowestCommonAncestor_003Eg__buildNodeIdStack_007C28_0(AccessibilityNode node, ref Stack<AccessibilityNode> nodeStack)
	{
		while (node != null)
		{
			nodeStack.Push(node);
			node = m_Nodes[node.id].parent;
		}
	}
}
