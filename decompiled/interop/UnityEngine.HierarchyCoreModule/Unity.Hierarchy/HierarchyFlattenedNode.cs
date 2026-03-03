using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.Hierarchy;

[StructLayout(LayoutKind.Explicit)]
public struct HierarchyFlattenedNode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Null;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Node;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ParentOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NextSiblingOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildrenCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Depth;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_byref_HierarchyFlattenedNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Node_Public_get_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NextSiblingOffset_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ChildrenCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_HierarchyFlattenedNode_byref_HierarchyFlattenedNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyFlattenedNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeByRef_Internal_Static_byref_HierarchyNode_byref_HierarchyFlattenedNode_0;

	[FieldOffset(0)]
	public readonly HierarchyNode m_Node;

	[FieldOffset(8)]
	public readonly HierarchyNodeType m_Type;

	[FieldOffset(12)]
	public readonly int m_ParentOffset;

	[FieldOffset(16)]
	public readonly int m_NextSiblingOffset;

	[FieldOffset(20)]
	public readonly int m_ChildrenCount;

	[FieldOffset(24)]
	public readonly int m_Depth;

	public unsafe static HierarchyFlattenedNode s_Null
	{
		get
		{
			Unsafe.SkipInit(out HierarchyFlattenedNode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Null, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Null, (void*)(&value));
		}
	}

	public unsafe static ref HierarchyFlattenedNode Null
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243295, XrefRangeEnd = 1243297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_byref_HierarchyFlattenedNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(HierarchyFlattenedNode*)intPtr2;
		}
	}

	public unsafe HierarchyNode Node
	{
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Node_Public_get_HierarchyNode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HierarchyNode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int NextSiblingOffset
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NextSiblingOffset_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int ChildrenCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ChildrenCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public HierarchyNodeType Type => m_Type;

	public int ParentOffset => m_ParentOffset;

	public int Depth => m_Depth;

	static HierarchyFlattenedNode()
	{
		Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyFlattenedNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr);
		NativeFieldInfoPtr_s_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, "s_Null");
		NativeFieldInfoPtr_m_Node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, "m_Node");
		NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, "m_Type");
		NativeFieldInfoPtr_m_ParentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, "m_ParentOffset");
		NativeFieldInfoPtr_m_NextSiblingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, "m_NextSiblingOffset");
		NativeFieldInfoPtr_m_ChildrenCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, "m_ChildrenCount");
		NativeFieldInfoPtr_m_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, "m_Depth");
		NativeMethodInfoPtr_get_Null_Public_Static_get_byref_HierarchyFlattenedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_get_Node_Public_get_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_get_NextSiblingOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_get_ChildrenCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_HierarchyFlattenedNode_byref_HierarchyFlattenedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyFlattenedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_GetNodeByRef_Internal_Static_byref_HierarchyNode_byref_HierarchyFlattenedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, 100663472);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==([In] ref HierarchyFlattenedNode lhs, [In] ref HierarchyFlattenedNode rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref lhs);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_HierarchyFlattenedNode_byref_HierarchyFlattenedNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(HierarchyFlattenedNode other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyFlattenedNode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243297, XrefRangeEnd = 1243315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243315, XrefRangeEnd = 1243318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243318, XrefRangeEnd = 1243324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref HierarchyNode GetNodeByRef([In] ref HierarchyFlattenedNode hierarchyFlattenedNode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref hierarchyFlattenedNode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeByRef_Internal_Static_byref_HierarchyNode_byref_HierarchyFlattenedNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(HierarchyNode*)intPtr2;
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HierarchyFlattenedNode>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=([In] ref HierarchyFlattenedNode lhs, [In] ref HierarchyFlattenedNode rhs)
	{
		return !((ref lhs) == (ref rhs));
	}
}
