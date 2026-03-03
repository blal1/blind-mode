using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public sealed class SortingGroup : Behaviour
{
	private delegate void UpdateAllSortingGroupsDelegate();

	private delegate void get_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void set_sortingLayerID_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_sortAtRoot_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sortAtRoot_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate int get_sortingGroupID_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_sortingGroupOrder_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_index_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint get_sortingKey_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSortingGroupByIndex_Injected_Private_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly UpdateAllSortingGroupsDelegate UpdateAllSortingGroupsDelegateField;

	private static readonly get_sortingLayerName_InjectedDelegate get_sortingLayerName_InjectedDelegateField;

	private static readonly set_sortingLayerName_InjectedDelegate set_sortingLayerName_InjectedDelegateField;

	private static readonly set_sortingLayerID_InjectedDelegate set_sortingLayerID_InjectedDelegateField;

	private static readonly get_sortAtRoot_InjectedDelegate get_sortAtRoot_InjectedDelegateField;

	private static readonly set_sortAtRoot_InjectedDelegate set_sortAtRoot_InjectedDelegateField;

	private static readonly get_sortingGroupID_InjectedDelegate get_sortingGroupID_InjectedDelegateField;

	private static readonly get_sortingGroupOrder_InjectedDelegate get_sortingGroupOrder_InjectedDelegateField;

	private static readonly get_index_InjectedDelegate get_index_InjectedDelegateField;

	private static readonly get_sortingKey_InjectedDelegate get_sortingKey_InjectedDelegateField;

	public unsafe static int invalidSortingGroupID
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1231701, RefRangeEnd = 1231705, XrefRangeStart = 1231699, XrefRangeEnd = 1231701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int sortingLayerID
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1231716, RefRangeEnd = 1231723, XrefRangeStart = 1231711, XrefRangeEnd = 1231716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sortingLayerID_Injected(intPtr, value);
		}
	}

	public unsafe int sortingOrder
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1231728, RefRangeEnd = 1231735, XrefRangeStart = 1231723, XrefRangeEnd = 1231728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231740, RefRangeEnd = 1231741, XrefRangeStart = 1231735, XrefRangeEnd = 1231740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string sortingLayerName
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_sortingLayerName_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0028: Expected O, but got Ref
			//IL_0034: Expected O, but got Ref
			//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
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
						set_sortingLayerName_Injected(intPtr, ref managedSpanWrapper);
						return;
					}
				}
				set_sortingLayerName_Injected(intPtr, ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public bool sortAtRoot
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortAtRoot_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sortAtRoot_Injected(intPtr, value);
		}
	}

	public int sortingGroupID
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortingGroupID_Injected(intPtr);
		}
	}

	public int sortingGroupOrder
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortingGroupOrder_Injected(intPtr);
		}
	}

	public int index
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_index_Injected(intPtr);
		}
	}

	public uint sortingKey
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortingKey_Injected(intPtr);
		}
	}

	static SortingGroup()
	{
		Il2CppClassPointerStore<SortingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr);
		NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667632);
		NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667633);
		NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667634);
		NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667635);
		NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667636);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667637);
		NativeMethodInfoPtr_GetSortingGroupByIndex_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667638);
		NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667639);
		NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667640);
		NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667641);
		UpdateAllSortingGroupsDelegateField = IL2CPP.ResolveICall<UpdateAllSortingGroupsDelegate>("UnityEngine.Rendering.SortingGroup::UpdateAllSortingGroups");
		get_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingLayerName_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingLayerName_Injected");
		set_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<set_sortingLayerName_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerName_Injected");
		set_sortingLayerID_InjectedDelegateField = IL2CPP.ResolveICall<set_sortingLayerID_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerID_Injected");
		get_sortAtRoot_InjectedDelegateField = IL2CPP.ResolveICall<get_sortAtRoot_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortAtRoot_Injected");
		set_sortAtRoot_InjectedDelegateField = IL2CPP.ResolveICall<set_sortAtRoot_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::set_sortAtRoot_Injected");
		get_sortingGroupID_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingGroupID_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupID_Injected");
		get_sortingGroupOrder_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingGroupOrder_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupOrder_Injected");
		get_index_InjectedDelegateField = IL2CPP.ResolveICall<get_index_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_index_Injected");
		get_sortingKey_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingKey_InjectedDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingKey_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231710, RefRangeEnd = 1231711, XrefRangeStart = 1231705, XrefRangeEnd = 1231710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SortingGroup GetSortingGroupByIndex(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SortingGroup>(intPtr2) : null;
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SortingGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231741, XrefRangeEnd = 1231743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSortingGroupByIndex_Injected(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSortingGroupByIndex_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231743, XrefRangeEnd = 1231745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingLayerID_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231745, XrefRangeEnd = 1231747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingOrder_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231747, XrefRangeEnd = 1231749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sortingOrder_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SortingGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void UpdateAllSortingGroups()
	{
		UpdateAllSortingGroupsDelegateField();
	}

	public unsafe static void get_sortingLayerName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_sortingLayerName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_sortingLayerName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_sortingLayerName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void set_sortingLayerID_Injected(System.IntPtr _unity_self, int value)
	{
		set_sortingLayerID_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_sortAtRoot_Injected(System.IntPtr _unity_self)
	{
		return get_sortAtRoot_InjectedDelegateField(_unity_self);
	}

	public static void set_sortAtRoot_Injected(System.IntPtr _unity_self, bool value)
	{
		set_sortAtRoot_InjectedDelegateField(_unity_self, value);
	}

	public static int get_sortingGroupID_Injected(System.IntPtr _unity_self)
	{
		return get_sortingGroupID_InjectedDelegateField(_unity_self);
	}

	public static int get_sortingGroupOrder_Injected(System.IntPtr _unity_self)
	{
		return get_sortingGroupOrder_InjectedDelegateField(_unity_self);
	}

	public static int get_index_Injected(System.IntPtr _unity_self)
	{
		return get_index_InjectedDelegateField(_unity_self);
	}

	public static uint get_sortingKey_Injected(System.IntPtr _unity_self)
	{
		return get_sortingKey_InjectedDelegateField(_unity_self);
	}
}
