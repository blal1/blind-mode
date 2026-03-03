using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace Unity.Hierarchy;

public sealed class HierarchyCommandList : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyCommandList_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyCommandList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663429);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(HierarchyCommandList cmdList)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdList);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyCommandList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate int get_Size_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_Capacity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_IsEmpty_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_IsExecuting_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Clear_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool Reserve_InjectedDelegate(System.IntPtr _unity_self, int count);

	private delegate bool Remove_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate bool RemoveChildren_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate bool SetParent_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, [In] System.IntPtr parent);

	private delegate bool SetSortIndex_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, int sortIndex);

	private delegate bool SortChildren_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, bool recurse);

	private delegate bool SetName_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, System.IntPtr name);

	private delegate void Execute_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool ExecuteIncremental_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool ExecuteIncrementalTimed_InjectedDelegate(System.IntPtr _unity_self, double milliseconds);

	private delegate System.IntPtr Create_InjectedDelegate(System.IntPtr handlePtr, System.IntPtr hierarchy, [In] System.IntPtr nodeType, int initialCapacity);

	private delegate bool AddNode_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr parent, [Out] System.IntPtr node);

	private delegate bool AddNodeSpan_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr parent, System.IntPtr outNodes);

	private delegate bool SetNodePropertyRaw_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr property, [In] System.IntPtr node, System.IntPtr ptr, int size);

	private delegate bool SetNodePropertyString_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr property, [In] System.IntPtr node, System.IntPtr value);

	private delegate bool ClearNodeProperty_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr property, [In] System.IntPtr node);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsOwner;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyCommandList_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCommandList_Private_Static_IntPtr_IntPtr_0;

	private static readonly get_Size_InjectedDelegate get_Size_InjectedDelegateField;

	private static readonly get_Capacity_InjectedDelegate get_Capacity_InjectedDelegateField;

	private static readonly get_IsEmpty_InjectedDelegate get_IsEmpty_InjectedDelegateField;

	private static readonly get_IsExecuting_InjectedDelegate get_IsExecuting_InjectedDelegateField;

	private static readonly Clear_InjectedDelegate Clear_InjectedDelegateField;

	private static readonly Reserve_InjectedDelegate Reserve_InjectedDelegateField;

	private static readonly Remove_InjectedDelegate Remove_InjectedDelegateField;

	private static readonly RemoveChildren_InjectedDelegate RemoveChildren_InjectedDelegateField;

	private static readonly SetParent_InjectedDelegate SetParent_InjectedDelegateField;

	private static readonly SetSortIndex_InjectedDelegate SetSortIndex_InjectedDelegateField;

	private static readonly SortChildren_InjectedDelegate SortChildren_InjectedDelegateField;

	private static readonly SetName_InjectedDelegate SetName_InjectedDelegateField;

	private static readonly Execute_InjectedDelegate Execute_InjectedDelegateField;

	private static readonly ExecuteIncremental_InjectedDelegate ExecuteIncremental_InjectedDelegateField;

	private static readonly ExecuteIncrementalTimed_InjectedDelegate ExecuteIncrementalTimed_InjectedDelegateField;

	private static readonly Create_InjectedDelegate Create_InjectedDelegateField;

	private static readonly AddNode_InjectedDelegate AddNode_InjectedDelegateField;

	private static readonly AddNodeSpan_InjectedDelegate AddNodeSpan_InjectedDelegateField;

	private static readonly SetNodePropertyRaw_InjectedDelegate SetNodePropertyRaw_InjectedDelegateField;

	private static readonly SetNodePropertyString_InjectedDelegate SetNodePropertyString_InjectedDelegateField;

	private static readonly ClearNodeProperty_InjectedDelegate ClearNodeProperty_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe bool m_IsOwner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsOwner);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsOwner)) = value;
		}
	}

	public bool IsCreated => m_Ptr != Il2CppSystem.IntPtr.Zero;

	public int Size
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_Size_Injected(intPtr);
		}
	}

	public int Capacity
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_Capacity_Injected(intPtr);
		}
	}

	public bool IsEmpty
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_IsEmpty_Injected(intPtr);
		}
	}

	public bool IsExecuting
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_IsExecuting_Injected(intPtr);
		}
	}

	static HierarchyCommandList()
	{
		Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyCommandList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_IsOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, "m_IsOwner");
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyCommandList_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_CreateCommandList_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyCommandList>.NativeClassPtr, 100663428);
		get_Size_InjectedDelegateField = IL2CPP.ResolveICall<get_Size_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::get_Size_Injected");
		get_Capacity_InjectedDelegateField = IL2CPP.ResolveICall<get_Capacity_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::get_Capacity_Injected");
		get_IsEmpty_InjectedDelegateField = IL2CPP.ResolveICall<get_IsEmpty_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::get_IsEmpty_Injected");
		get_IsExecuting_InjectedDelegateField = IL2CPP.ResolveICall<get_IsExecuting_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::get_IsExecuting_Injected");
		Clear_InjectedDelegateField = IL2CPP.ResolveICall<Clear_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::Clear_Injected");
		Reserve_InjectedDelegateField = IL2CPP.ResolveICall<Reserve_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::Reserve_Injected");
		Remove_InjectedDelegateField = IL2CPP.ResolveICall<Remove_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::Remove_Injected");
		RemoveChildren_InjectedDelegateField = IL2CPP.ResolveICall<RemoveChildren_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::RemoveChildren_Injected");
		SetParent_InjectedDelegateField = IL2CPP.ResolveICall<SetParent_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::SetParent_Injected");
		SetSortIndex_InjectedDelegateField = IL2CPP.ResolveICall<SetSortIndex_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::SetSortIndex_Injected");
		SortChildren_InjectedDelegateField = IL2CPP.ResolveICall<SortChildren_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::SortChildren_Injected");
		SetName_InjectedDelegateField = IL2CPP.ResolveICall<SetName_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::SetName_Injected");
		Execute_InjectedDelegateField = IL2CPP.ResolveICall<Execute_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::Execute_Injected");
		ExecuteIncremental_InjectedDelegateField = IL2CPP.ResolveICall<ExecuteIncremental_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::ExecuteIncremental_Injected");
		ExecuteIncrementalTimed_InjectedDelegateField = IL2CPP.ResolveICall<ExecuteIncrementalTimed_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::ExecuteIncrementalTimed_Injected");
		Create_InjectedDelegateField = IL2CPP.ResolveICall<Create_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::Create_Injected");
		AddNode_InjectedDelegateField = IL2CPP.ResolveICall<AddNode_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::AddNode_Injected");
		AddNodeSpan_InjectedDelegateField = IL2CPP.ResolveICall<AddNodeSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::AddNodeSpan_Injected");
		SetNodePropertyRaw_InjectedDelegateField = IL2CPP.ResolveICall<SetNodePropertyRaw_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::SetNodePropertyRaw_Injected");
		SetNodePropertyString_InjectedDelegateField = IL2CPP.ResolveICall<SetNodePropertyString_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::SetNodePropertyString_Injected");
		ClearNodeProperty_InjectedDelegateField = IL2CPP.ResolveICall<ClearNodeProperty_InjectedDelegate>("Unity.Hierarchy.HierarchyCommandList::ClearNodeProperty_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243168, XrefRangeEnd = 1243173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243173, XrefRangeEnd = 1243179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243179, XrefRangeEnd = 1243181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243181, XrefRangeEnd = 1243188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HierarchyCommandList FromIntPtr(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyCommandList_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyCommandList>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243188, XrefRangeEnd = 1243190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(System.IntPtr nativePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243190, XrefRangeEnd = 1243196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateCommandList(System.IntPtr nativePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCommandList_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HierarchyCommandList(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Clear()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Clear_Injected(intPtr);
	}

	public bool Reserve(int count)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Reserve_Injected(intPtr, count);
	}

	public bool Add([In] ref HierarchyNode parent, out HierarchyNode node)
	{
		return AddNode(ref parent, out node);
	}

	public bool Add([In] ref HierarchyNode parent, int count, out Il2CppStructArray<HierarchyNode> nodes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool Add([In] ref HierarchyNode parent, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		return AddNodeSpan(ref parent, outNodes);
	}

	public bool Remove([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Remove_Injected(intPtr, ref node);
	}

	public bool RemoveChildren([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return RemoveChildren_Injected(intPtr, ref node);
	}

	public bool SetParent([In] ref HierarchyNode node, [In] ref HierarchyNode parent)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetParent_Injected(intPtr, ref node, ref parent);
	}

	public bool SetSortIndex([In] ref HierarchyNode node, int sortIndex)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetSortIndex_Injected(intPtr, ref node, sortIndex);
	}

	public bool SortChildren([In] ref HierarchyNode node, [Optional] bool recurse)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SortChildren_Injected(intPtr, ref node, recurse);
	}

	public bool SetProperty<T>([In] ref HierarchyPropertyUnmanaged<T> property, [In] ref HierarchyNode node, T value) where T : struct, Il2CppSystem.ValueType
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool ClearProperty<T>([In] ref HierarchyPropertyUnmanaged<T> property, [In] ref HierarchyNode node) where T : struct, Il2CppSystem.ValueType
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe bool SetName([In] ref HierarchyNode node, string name)
	{
		//IL_0029: Expected O, but got Ref
		//IL_0035: Expected O, but got Ref
		//The blocks IL_003a are reachable both inside and outside the pinned region starting at IL_0029. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return SetName_Injected(intPtr, ref node, ref managedSpanWrapper);
				}
			}
			return SetName_Injected(intPtr, ref node, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public void Execute()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Execute_Injected(intPtr);
	}

	public bool ExecuteIncremental()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return ExecuteIncremental_Injected(intPtr);
	}

	public bool ExecuteIncrementalTimed(double milliseconds)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return ExecuteIncrementalTimed_Injected(intPtr, milliseconds);
	}

	public static System.IntPtr Create(System.IntPtr handlePtr, Hierarchy hierarchy, HierarchyNodeType nodeType, int initialCapacity)
	{
		return Create_Injected(handlePtr, (hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy), ref nodeType, initialCapacity);
	}

	public bool AddNode([In] ref HierarchyNode parent, out HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return AddNode_Injected(intPtr, ref parent, out node);
	}

	public unsafe bool AddNodeSpan([In] ref HierarchyNode parent, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<HierarchyNode> span = outNodes;
		bool result;
		fixed (HierarchyNode* begin = &((Il2CppSystem.Span<HierarchyNode>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outNodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<HierarchyNode>)(&span)).Length);
			result = AddNodeSpan_Injected(intPtr, ref parent, ref outNodes2);
		}
		return result;
	}

	public unsafe bool SetNodePropertyRaw([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, void* ptr, int size)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetNodePropertyRaw_Injected(intPtr, ref property, ref node, ptr, size);
	}

	public unsafe bool SetNodePropertyString([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, string value)
	{
		//IL_002a: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//The blocks IL_003b are reachable both inside and outside the pinned region starting at IL_002a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return SetNodePropertyString_Injected(intPtr, ref property, ref node, ref managedSpanWrapper);
				}
			}
			return SetNodePropertyString_Injected(intPtr, ref property, ref node, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public bool ClearNodeProperty([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return ClearNodeProperty_Injected(intPtr, ref property, ref node);
	}

	public static int get_Size_Injected(System.IntPtr _unity_self)
	{
		return get_Size_InjectedDelegateField(_unity_self);
	}

	public static int get_Capacity_Injected(System.IntPtr _unity_self)
	{
		return get_Capacity_InjectedDelegateField(_unity_self);
	}

	public static bool get_IsEmpty_Injected(System.IntPtr _unity_self)
	{
		return get_IsEmpty_InjectedDelegateField(_unity_self);
	}

	public static bool get_IsExecuting_Injected(System.IntPtr _unity_self)
	{
		return get_IsExecuting_InjectedDelegateField(_unity_self);
	}

	public static void Clear_Injected(System.IntPtr _unity_self)
	{
		Clear_InjectedDelegateField(_unity_self);
	}

	public static bool Reserve_Injected(System.IntPtr _unity_self, int count)
	{
		return Reserve_InjectedDelegateField(_unity_self, count);
	}

	public unsafe static bool Remove_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return Remove_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static bool RemoveChildren_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return RemoveChildren_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static bool SetParent_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, [In] ref HierarchyNode parent)
	{
		return SetParent_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref parent));
	}

	public unsafe static bool SetSortIndex_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, int sortIndex)
	{
		return SetSortIndex_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), sortIndex);
	}

	public unsafe static bool SortChildren_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, bool recurse)
	{
		return SortChildren_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), recurse);
	}

	public unsafe static bool SetName_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, ref ManagedSpanWrapper name)
	{
		return SetName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref name));
	}

	public static void Execute_Injected(System.IntPtr _unity_self)
	{
		Execute_InjectedDelegateField(_unity_self);
	}

	public static bool ExecuteIncremental_Injected(System.IntPtr _unity_self)
	{
		return ExecuteIncremental_InjectedDelegateField(_unity_self);
	}

	public static bool ExecuteIncrementalTimed_Injected(System.IntPtr _unity_self, double milliseconds)
	{
		return ExecuteIncrementalTimed_InjectedDelegateField(_unity_self, milliseconds);
	}

	public unsafe static System.IntPtr Create_Injected(System.IntPtr handlePtr, System.IntPtr hierarchy, [In] ref HierarchyNodeType nodeType, int initialCapacity)
	{
		return Create_InjectedDelegateField(handlePtr, hierarchy, (nint)Unsafe.AsPointer(ref nodeType), initialCapacity);
	}

	public unsafe static bool AddNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode parent, out HierarchyNode node)
	{
		return AddNode_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref parent), (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static bool AddNodeSpan_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode parent, ref ManagedSpanWrapper outNodes)
	{
		return AddNodeSpan_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref parent), (nint)Unsafe.AsPointer(ref outNodes));
	}

	public unsafe static bool SetNodePropertyRaw_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, void* ptr, int size)
	{
		return SetNodePropertyRaw_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref property), (nint)Unsafe.AsPointer(ref node), (nint)ptr, size);
	}

	public unsafe static bool SetNodePropertyString_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, ref ManagedSpanWrapper value)
	{
		return SetNodePropertyString_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref property), (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool ClearNodeProperty_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node)
	{
		return ClearNodeProperty_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref property), (nint)Unsafe.AsPointer(ref node));
	}
}
