using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace Unity.Hierarchy;

public sealed class Hierarchy : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_Hierarchy_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_Hierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663421);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(Hierarchy hierarchy)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchy);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_Hierarchy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetOrCreatePropertyUnmanaged_Public_HierarchyPropertyUnmanaged_1_T_String_HierarchyPropertyStorageType_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetOrCreatePropertyUnmanaged_Public_HierarchyPropertyUnmanaged_1_T_String_HierarchyPropertyStorageType_0, Il2CppClassPointerStore<Hierarchy>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate int get_Count_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_Updating_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetNodeType_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, [Out] System.IntPtr ret);

	private delegate void Reserve_InjectedDelegate(System.IntPtr _unity_self, int count);

	private delegate void ReserveChildren_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, int count);

	private delegate void GetNextSibling_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, [Out] System.IntPtr ret);

	private delegate int GetDepth_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate bool Remove_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate void RemoveChildren_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate void Clear_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetChild_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, int index, [Out] System.IntPtr ret);

	private delegate int GetChildIndex_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate int GetChildrenCountRecursive_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate int GetSortIndex_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate bool DoesChildrenNeedsSorting_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate bool SetName_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, System.IntPtr name);

	private delegate void GetName_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, [Out] System.IntPtr ret);

	private delegate void GetPath_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, [Out] System.IntPtr ret);

	private delegate bool UpdateIncremental_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool UpdateIncrementalTimed_InjectedDelegate(System.IntPtr _unity_self, double milliseconds);

	private delegate System.IntPtr GetOrCreateNodeTypeHandler_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr type);

	private delegate System.IntPtr GetNodeTypeHandlerFromType_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr type);

	private delegate System.IntPtr GetNodeTypeHandlerFromNode_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate System.IntPtr GetNodeTypeHandlerFromName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr nodeTypeName);

	private delegate void GetNodeTypeFromType_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr type, [Out] System.IntPtr ret);

	private delegate void AddNodeSpan_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr parent, System.IntPtr nodes);

	private delegate int GetNodeChildrenSpan_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, System.IntPtr outChildren);

	private delegate void SetPropertyString_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr property, [In] System.IntPtr node, System.IntPtr value);

	private delegate void GetPropertyString_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr property, [In] System.IntPtr node, [Out] System.IntPtr ret);

	private delegate void ClearProperty_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr property, [In] System.IntPtr node);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RootPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VersionPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsOwner;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Root_Public_get_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdateNeeded_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateNodeTypeHandlersBase_Public_HierarchyNodeTypeHandlerBaseEnumerable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Public_Boolean_byref_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParent_Public_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildren_Public_Il2CppStructArray_1_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateChildren_Public_HierarchyNodeChildren_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildrenCount_Public_Int32_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSortIndex_Public_Void_byref_HierarchyNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortChildren_Public_Void_byref_HierarchyNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreatePropertyUnmanaged_Public_HierarchyPropertyUnmanaged_1_T_String_HierarchyPropertyStorageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIntPtr_Internal_Static_Hierarchy_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_IntPtr_byref_IntPtr_byref_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeTypeHandlersBaseCount_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeTypeHandlersBaseSpan_Internal_Int32_Span_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNode_Private_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateChildrenPtr_Private_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateProperty_Private_HierarchyPropertyId_String_byref_HierarchyPropertyDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPropertyRaw_Internal_Void_byref_HierarchyPropertyId_byref_HierarchyNode_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertyRaw_Internal_ptr_Void_byref_HierarchyPropertyId_byref_HierarchyNode_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHierarchy_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdateNeeded_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParent_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildren_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildrenCount_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSortIndex_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortChildren_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeTypeHandlersBaseCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeTypeHandlersBaseSpan_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateChildrenPtr_Injected_Private_Static_IntPtr_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateProperty_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_HierarchyPropertyDescriptor_byref_HierarchyPropertyId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPropertyRaw_Injected_Private_Static_Void_IntPtr_byref_HierarchyPropertyId_byref_HierarchyNode_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertyRaw_Injected_Private_Static_ptr_Void_IntPtr_byref_HierarchyPropertyId_byref_HierarchyNode_byref_Int32_0;

	private static readonly get_Count_InjectedDelegate get_Count_InjectedDelegateField;

	private static readonly get_Updating_InjectedDelegate get_Updating_InjectedDelegateField;

	private static readonly GetNodeType_InjectedDelegate GetNodeType_InjectedDelegateField;

	private static readonly Reserve_InjectedDelegate Reserve_InjectedDelegateField;

	private static readonly ReserveChildren_InjectedDelegate ReserveChildren_InjectedDelegateField;

	private static readonly GetNextSibling_InjectedDelegate GetNextSibling_InjectedDelegateField;

	private static readonly GetDepth_InjectedDelegate GetDepth_InjectedDelegateField;

	private static readonly Remove_InjectedDelegate Remove_InjectedDelegateField;

	private static readonly RemoveChildren_InjectedDelegate RemoveChildren_InjectedDelegateField;

	private static readonly Clear_InjectedDelegate Clear_InjectedDelegateField;

	private static readonly GetChild_InjectedDelegate GetChild_InjectedDelegateField;

	private static readonly GetChildIndex_InjectedDelegate GetChildIndex_InjectedDelegateField;

	private static readonly GetChildrenCountRecursive_InjectedDelegate GetChildrenCountRecursive_InjectedDelegateField;

	private static readonly GetSortIndex_InjectedDelegate GetSortIndex_InjectedDelegateField;

	private static readonly DoesChildrenNeedsSorting_InjectedDelegate DoesChildrenNeedsSorting_InjectedDelegateField;

	private static readonly SetName_InjectedDelegate SetName_InjectedDelegateField;

	private static readonly GetName_InjectedDelegate GetName_InjectedDelegateField;

	private static readonly GetPath_InjectedDelegate GetPath_InjectedDelegateField;

	private static readonly UpdateIncremental_InjectedDelegate UpdateIncremental_InjectedDelegateField;

	private static readonly UpdateIncrementalTimed_InjectedDelegate UpdateIncrementalTimed_InjectedDelegateField;

	private static readonly GetOrCreateNodeTypeHandler_InjectedDelegate GetOrCreateNodeTypeHandler_InjectedDelegateField;

	private static readonly GetNodeTypeHandlerFromType_InjectedDelegate GetNodeTypeHandlerFromType_InjectedDelegateField;

	private static readonly GetNodeTypeHandlerFromNode_InjectedDelegate GetNodeTypeHandlerFromNode_InjectedDelegateField;

	private static readonly GetNodeTypeHandlerFromName_InjectedDelegate GetNodeTypeHandlerFromName_InjectedDelegateField;

	private static readonly GetNodeTypeFromType_InjectedDelegate GetNodeTypeFromType_InjectedDelegateField;

	private static readonly AddNodeSpan_InjectedDelegate AddNodeSpan_InjectedDelegateField;

	private static readonly GetNodeChildrenSpan_InjectedDelegate GetNodeChildrenSpan_InjectedDelegateField;

	private static readonly SetPropertyString_InjectedDelegate SetPropertyString_InjectedDelegateField;

	private static readonly GetPropertyString_InjectedDelegate GetPropertyString_InjectedDelegateField;

	private static readonly ClearProperty_InjectedDelegate ClearProperty_InjectedDelegateField;

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

	public unsafe System.IntPtr m_RootPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootPtr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootPtr)) = value;
		}
	}

	public unsafe System.IntPtr m_VersionPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VersionPtr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VersionPtr)) = value;
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

	public unsafe bool IsCreated
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1242961, RefRangeEnd = 1242969, XrefRangeStart = 1242961, XrefRangeEnd = 1242961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ref HierarchyNode Root
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242969, XrefRangeEnd = 1242970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Root_Public_get_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(HierarchyNode*)intPtr2;
		}
	}

	public unsafe bool UpdateNeeded
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242974, RefRangeEnd = 1242977, XrefRangeStart = 1242970, XrefRangeEnd = 1242974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpdateNeeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242977, XrefRangeEnd = 1242978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public int Count
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_Count_Injected(intPtr);
		}
	}

	public bool Updating
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_Updating_Injected(intPtr);
		}
	}

	static Hierarchy()
	{
		Il2CppClassPointerStore<Hierarchy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "Hierarchy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_RootPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "m_RootPtr");
		NativeFieldInfoPtr_m_VersionPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "m_VersionPtr");
		NativeFieldInfoPtr_m_IsOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "m_IsOwner");
		NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_get_Root_Public_get_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_get_UpdateNeeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr__ctor_Private_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_EnumerateNodeTypeHandlersBase_Public_HierarchyNodeTypeHandlerBaseEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_Exists_Public_Boolean_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_Add_Public_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_SetParent_Public_Boolean_byref_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_GetParent_Public_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_GetChildren_Public_Il2CppStructArray_1_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_EnumerateChildren_Public_HierarchyNodeChildren_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_GetChildrenCount_Public_Int32_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_SetSortIndex_Public_Void_byref_HierarchyNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_SortChildren_Public_Void_byref_HierarchyNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_GetOrCreatePropertyUnmanaged_Public_HierarchyPropertyUnmanaged_1_T_String_HierarchyPropertyStorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_FromIntPtr_Internal_Static_Hierarchy_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_Create_Private_Static_IntPtr_IntPtr_byref_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_GetNodeTypeHandlersBaseCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_GetNodeTypeHandlersBaseSpan_Internal_Int32_Span_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_AddNode_Private_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_EnumerateChildrenPtr_Private_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_GetOrCreateProperty_Private_HierarchyPropertyId_String_byref_HierarchyPropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_SetPropertyRaw_Internal_Void_byref_HierarchyPropertyId_byref_HierarchyNode_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_GetPropertyRaw_Internal_ptr_Void_byref_HierarchyPropertyId_byref_HierarchyNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_CreateHierarchy_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_get_UpdateNeeded_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_Exists_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_SetParent_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_GetParent_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_GetChildren_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_GetChildrenCount_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_SetSortIndex_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_SortChildren_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_Update_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_GetNodeTypeHandlersBaseCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_GetNodeTypeHandlersBaseSpan_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_AddNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_EnumerateChildrenPtr_Injected_Private_Static_IntPtr_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_GetOrCreateProperty_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_HierarchyPropertyDescriptor_byref_HierarchyPropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_SetPropertyRaw_Injected_Private_Static_Void_IntPtr_byref_HierarchyPropertyId_byref_HierarchyNode_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_GetPropertyRaw_Injected_Private_Static_ptr_Void_IntPtr_byref_HierarchyPropertyId_byref_HierarchyNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100663420);
		get_Count_InjectedDelegateField = IL2CPP.ResolveICall<get_Count_InjectedDelegate>("Unity.Hierarchy.Hierarchy::get_Count_Injected");
		get_Updating_InjectedDelegateField = IL2CPP.ResolveICall<get_Updating_InjectedDelegate>("Unity.Hierarchy.Hierarchy::get_Updating_Injected");
		GetNodeType_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeType_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetNodeType_Injected");
		Reserve_InjectedDelegateField = IL2CPP.ResolveICall<Reserve_InjectedDelegate>("Unity.Hierarchy.Hierarchy::Reserve_Injected");
		ReserveChildren_InjectedDelegateField = IL2CPP.ResolveICall<ReserveChildren_InjectedDelegate>("Unity.Hierarchy.Hierarchy::ReserveChildren_Injected");
		GetNextSibling_InjectedDelegateField = IL2CPP.ResolveICall<GetNextSibling_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetNextSibling_Injected");
		GetDepth_InjectedDelegateField = IL2CPP.ResolveICall<GetDepth_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetDepth_Injected");
		Remove_InjectedDelegateField = IL2CPP.ResolveICall<Remove_InjectedDelegate>("Unity.Hierarchy.Hierarchy::Remove_Injected");
		RemoveChildren_InjectedDelegateField = IL2CPP.ResolveICall<RemoveChildren_InjectedDelegate>("Unity.Hierarchy.Hierarchy::RemoveChildren_Injected");
		Clear_InjectedDelegateField = IL2CPP.ResolveICall<Clear_InjectedDelegate>("Unity.Hierarchy.Hierarchy::Clear_Injected");
		GetChild_InjectedDelegateField = IL2CPP.ResolveICall<GetChild_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetChild_Injected");
		GetChildIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetChildIndex_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetChildIndex_Injected");
		GetChildrenCountRecursive_InjectedDelegateField = IL2CPP.ResolveICall<GetChildrenCountRecursive_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetChildrenCountRecursive_Injected");
		GetSortIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetSortIndex_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetSortIndex_Injected");
		DoesChildrenNeedsSorting_InjectedDelegateField = IL2CPP.ResolveICall<DoesChildrenNeedsSorting_InjectedDelegate>("Unity.Hierarchy.Hierarchy::DoesChildrenNeedsSorting_Injected");
		SetName_InjectedDelegateField = IL2CPP.ResolveICall<SetName_InjectedDelegate>("Unity.Hierarchy.Hierarchy::SetName_Injected");
		GetName_InjectedDelegateField = IL2CPP.ResolveICall<GetName_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetName_Injected");
		GetPath_InjectedDelegateField = IL2CPP.ResolveICall<GetPath_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetPath_Injected");
		UpdateIncremental_InjectedDelegateField = IL2CPP.ResolveICall<UpdateIncremental_InjectedDelegate>("Unity.Hierarchy.Hierarchy::UpdateIncremental_Injected");
		UpdateIncrementalTimed_InjectedDelegateField = IL2CPP.ResolveICall<UpdateIncrementalTimed_InjectedDelegate>("Unity.Hierarchy.Hierarchy::UpdateIncrementalTimed_Injected");
		GetOrCreateNodeTypeHandler_InjectedDelegateField = IL2CPP.ResolveICall<GetOrCreateNodeTypeHandler_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetOrCreateNodeTypeHandler_Injected");
		GetNodeTypeHandlerFromType_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeTypeHandlerFromType_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetNodeTypeHandlerFromType_Injected");
		GetNodeTypeHandlerFromNode_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeTypeHandlerFromNode_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetNodeTypeHandlerFromNode_Injected");
		GetNodeTypeHandlerFromName_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeTypeHandlerFromName_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetNodeTypeHandlerFromName_Injected");
		GetNodeTypeFromType_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeTypeFromType_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetNodeTypeFromType_Injected");
		AddNodeSpan_InjectedDelegateField = IL2CPP.ResolveICall<AddNodeSpan_InjectedDelegate>("Unity.Hierarchy.Hierarchy::AddNodeSpan_Injected");
		GetNodeChildrenSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeChildrenSpan_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetNodeChildrenSpan_Injected");
		SetPropertyString_InjectedDelegateField = IL2CPP.ResolveICall<SetPropertyString_InjectedDelegate>("Unity.Hierarchy.Hierarchy::SetPropertyString_Injected");
		GetPropertyString_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyString_InjectedDelegate>("Unity.Hierarchy.Hierarchy::GetPropertyString_Injected");
		ClearProperty_InjectedDelegateField = IL2CPP.ResolveICall<ClearProperty_InjectedDelegate>("Unity.Hierarchy.Hierarchy::ClearProperty_Injected");
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1242983, RefRangeEnd = 1242986, XrefRangeStart = 1242978, XrefRangeEnd = 1242983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hierarchy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242986, XrefRangeEnd = 1242987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hierarchy(System.IntPtr nativePtr, System.IntPtr rootPtr, System.IntPtr versionPtr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&nativePtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rootPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &versionPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242987, XrefRangeEnd = 1242992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1242998, RefRangeEnd = 1242999, XrefRangeStart = 1242992, XrefRangeEnd = 1242998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242999, XrefRangeEnd = 1243001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(60)]
	[CachedScanResults(RefRangeStart = 772969, RefRangeEnd = 773029, XrefRangeStart = 772969, XrefRangeEnd = 773029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumerateNodeTypeHandlersBase_Public_HierarchyNodeTypeHandlerBaseEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HierarchyNodeTypeHandlerBaseEnumerable(pointer);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1243005, RefRangeEnd = 1243013, XrefRangeStart = 1243001, XrefRangeEnd = 1243005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Exists([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exists_Public_Boolean_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243016, RefRangeEnd = 1243017, XrefRangeStart = 1243013, XrefRangeEnd = 1243016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyNode Add([In] ref HierarchyNode parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_HierarchyNode_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HierarchyNode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243021, RefRangeEnd = 1243022, XrefRangeStart = 1243017, XrefRangeEnd = 1243021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetParent([In] ref HierarchyNode node, [In] ref HierarchyNode parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParent_Public_Boolean_byref_HierarchyNode_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1243025, RefRangeEnd = 1243030, XrefRangeStart = 1243022, XrefRangeEnd = 1243025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyNode GetParent([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParent_Public_HierarchyNode_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HierarchyNode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243037, RefRangeEnd = 1243039, XrefRangeStart = 1243030, XrefRangeEnd = 1243037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<HierarchyNode> GetChildren([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildren_Public_Il2CppStructArray_1_HierarchyNode_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HierarchyNode>>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1243043, RefRangeEnd = 1243046, XrefRangeStart = 1243039, XrefRangeEnd = 1243043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyNodeChildren EnumerateChildren([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumerateChildren_Public_HierarchyNodeChildren_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HierarchyNodeChildren(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243050, RefRangeEnd = 1243051, XrefRangeStart = 1243046, XrefRangeEnd = 1243050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetChildrenCount([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildrenCount_Public_Int32_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1243055, RefRangeEnd = 1243059, XrefRangeStart = 1243051, XrefRangeEnd = 1243055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSortIndex([In] ref HierarchyNode node, int sortIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSortIndex_Public_Void_byref_HierarchyNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243063, RefRangeEnd = 1243064, XrefRangeStart = 1243059, XrefRangeEnd = 1243063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortChildren([In] ref HierarchyNode node, bool recurse = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortChildren_Public_Void_byref_HierarchyNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243067, RefRangeEnd = 1243069, XrefRangeStart = 1243064, XrefRangeEnd = 1243067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged<T>(string name, HierarchyPropertyStorageType type = HierarchyPropertyStorageType.Dense) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(HierarchyPropertyStorageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetOrCreatePropertyUnmanaged_Public_HierarchyPropertyUnmanaged_1_T_String_HierarchyPropertyStorageType_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HierarchyPropertyUnmanaged<T>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1243073, RefRangeEnd = 1243076, XrefRangeStart = 1243069, XrefRangeEnd = 1243073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243076, XrefRangeEnd = 1243083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hierarchy FromIntPtr(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIntPtr_Internal_Static_Hierarchy_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hierarchy>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243083, XrefRangeEnd = 1243085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create(System.IntPtr handlePtr, out System.IntPtr rootPtr, out System.IntPtr versionPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handlePtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rootPtr);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref versionPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Static_IntPtr_IntPtr_byref_IntPtr_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243085, XrefRangeEnd = 1243087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(System.IntPtr nativePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243087, XrefRangeEnd = 1243091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNodeTypeHandlersBaseCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeTypeHandlersBaseCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243091, XrefRangeEnd = 1243099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNodeTypeHandlersBaseSpan(Il2CppSystem.Span<System.IntPtr> outHandlers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)outHandlers));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeTypeHandlersBaseSpan_Internal_Int32_Span_1_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243016, RefRangeEnd = 1243017, XrefRangeStart = 1243016, XrefRangeEnd = 1243017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyNode AddNode([In] ref HierarchyNode parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNode_Private_HierarchyNode_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HierarchyNode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243099, XrefRangeEnd = 1243103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr EnumerateChildrenPtr([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumerateChildrenPtr_Private_IntPtr_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243118, RefRangeEnd = 1243119, XrefRangeStart = 1243103, XrefRangeEnd = 1243118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyPropertyId GetOrCreateProperty(string name, [In] ref HierarchyPropertyDescriptor descriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateProperty_Private_HierarchyPropertyId_String_byref_HierarchyPropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HierarchyPropertyId*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243123, RefRangeEnd = 1243124, XrefRangeStart = 1243119, XrefRangeEnd = 1243123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPropertyRaw([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, void* ptr, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr2 = stackalloc System.IntPtr[4];
		*ptr2 = (nint)Unsafe.AsPointer(ref property);
		*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr;
		*(int**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPropertyRaw_Internal_Void_byref_HierarchyPropertyId_byref_HierarchyNode_ptr_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243128, RefRangeEnd = 1243130, XrefRangeStart = 1243124, XrefRangeEnd = 1243128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void* GetPropertyRaw([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, out int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref property);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPropertyRaw_Internal_ptr_Void_byref_HierarchyPropertyId_byref_HierarchyNode_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243130, XrefRangeEnd = 1243136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateHierarchy(System.IntPtr nativePtr, System.IntPtr rootPtr, System.IntPtr versionPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&nativePtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rootPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &versionPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHierarchy_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243136, XrefRangeEnd = 1243138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_UpdateNeeded_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpdateNeeded_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243138, XrefRangeEnd = 1243140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Exists_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exists_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243140, XrefRangeEnd = 1243142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetParent_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, [In] ref HierarchyNode parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParent_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243142, XrefRangeEnd = 1243144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetParent_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out HierarchyNode ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParent_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243144, XrefRangeEnd = 1243146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetChildren_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildren_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243146, XrefRangeEnd = 1243148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetChildrenCount_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildrenCount_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243148, XrefRangeEnd = 1243150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSortIndex_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, int sortIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSortIndex_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243150, XrefRangeEnd = 1243152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortChildren_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, bool recurse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortChildren_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243152, XrefRangeEnd = 1243154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243154, XrefRangeEnd = 1243156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNodeTypeHandlersBaseCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeTypeHandlersBaseCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243156, XrefRangeEnd = 1243158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNodeTypeHandlersBaseSpan_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper outHandlers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outHandlers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeTypeHandlersBaseSpan_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243158, XrefRangeEnd = 1243160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode parent, out HierarchyNode ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parent);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243160, XrefRangeEnd = 1243162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr EnumerateChildrenPtr_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumerateChildrenPtr_Injected_Private_Static_IntPtr_IntPtr_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243162, XrefRangeEnd = 1243164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetOrCreateProperty_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, [In] ref HierarchyPropertyDescriptor descriptor, out HierarchyPropertyId ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateProperty_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_HierarchyPropertyDescriptor_byref_HierarchyPropertyId_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243164, XrefRangeEnd = 1243166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPropertyRaw_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, void* ptr, int size)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[5];
		*ptr2 = (nint)(&_unity_self);
		*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		*(void**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr;
		*(int**)((byte*)ptr2 + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPropertyRaw_Injected_Private_Static_Void_IntPtr_byref_HierarchyPropertyId_byref_HierarchyNode_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243166, XrefRangeEnd = 1243168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetPropertyRaw_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, out int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPropertyRaw_Injected_Private_Static_ptr_Void_IntPtr_byref_HierarchyPropertyId_byref_HierarchyNode_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	public Hierarchy(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public T GetOrCreateNodeTypeHandler<T>() where T : HierarchyNodeTypeHandlerBase
	{
		return ((Il2CppObjectBase)HierarchyNodeTypeHandlerBase.FromIntPtr(GetOrCreateNodeTypeHandler(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))).Cast<T>();
	}

	public T GetNodeTypeHandlerBase<T>() where T : HierarchyNodeTypeHandlerBase
	{
		return ((Il2CppObjectBase)HierarchyNodeTypeHandlerBase.FromIntPtr(GetNodeTypeHandlerFromType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))).Cast<T>();
	}

	public HierarchyNodeTypeHandlerBase GetNodeTypeHandlerBase([In] ref HierarchyNode node)
	{
		return HierarchyNodeTypeHandlerBase.FromIntPtr(GetNodeTypeHandlerFromNode(ref node));
	}

	public HierarchyNodeTypeHandlerBase GetNodeTypeHandlerBase(string nodeTypeName)
	{
		return HierarchyNodeTypeHandlerBase.FromIntPtr(GetNodeTypeHandlerFromName(nodeTypeName));
	}

	public HierarchyNodeType GetNodeType<T>() where T : HierarchyNodeTypeHandlerBase
	{
		return GetNodeTypeFromType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
	}

	public HierarchyNodeType GetNodeType([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetNodeType_Injected(intPtr, ref node, out var ret);
		return ret;
	}

	public void Reserve(int count)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Reserve_Injected(intPtr, count);
	}

	public void ReserveChildren([In] ref HierarchyNode node, int count)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ReserveChildren_Injected(intPtr, ref node, count);
	}

	public HierarchyNode GetNextSibling([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetNextSibling_Injected(intPtr, ref node, out var ret);
		return ret;
	}

	public int GetDepth([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetDepth_Injected(intPtr, ref node);
	}

	public Il2CppStructArray<HierarchyNode> Add([In] ref HierarchyNode parent, int count)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Add([In] ref HierarchyNode parent, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		AddNodeSpan(ref parent, outNodes);
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

	public void RemoveChildren([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveChildren_Injected(intPtr, ref node);
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

	public HierarchyNode GetChild([In] ref HierarchyNode node, int index)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetChild_Injected(intPtr, ref node, index, out var ret);
		return ret;
	}

	public int GetChildIndex([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetChildIndex_Injected(intPtr, ref node);
	}

	public int GetChildren([In] ref HierarchyNode node, Il2CppSystem.Span<HierarchyNode> outChildren)
	{
		return GetNodeChildrenSpan(ref node, outChildren);
	}

	public int GetChildrenCountRecursive([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetChildrenCountRecursive_Injected(intPtr, ref node);
	}

	public int GetSortIndex([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSortIndex_Injected(intPtr, ref node);
	}

	public bool DoesChildrenNeedsSorting([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return DoesChildrenNeedsSorting_Injected(intPtr, ref node);
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

	public string GetName([In] ref HierarchyNode node)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetName_Injected(intPtr, ref node, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public string GetPath([In] ref HierarchyNode node)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetPath_Injected(intPtr, ref node, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public bool UpdateIncremental()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return UpdateIncremental_Injected(intPtr);
	}

	public bool UpdateIncrementalTimed(double milliseconds)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return UpdateIncrementalTimed_Injected(intPtr, milliseconds);
	}

	public System.IntPtr GetOrCreateNodeTypeHandler(Il2CppSystem.Type type)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetOrCreateNodeTypeHandler_Injected(intPtr, type);
	}

	public System.IntPtr GetNodeTypeHandlerFromType(Il2CppSystem.Type type)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetNodeTypeHandlerFromType_Injected(intPtr, type);
	}

	public System.IntPtr GetNodeTypeHandlerFromNode([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetNodeTypeHandlerFromNode_Injected(intPtr, ref node);
	}

	public unsafe System.IntPtr GetNodeTypeHandlerFromName(string nodeTypeName)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(nodeTypeName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(nodeTypeName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetNodeTypeHandlerFromName_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return GetNodeTypeHandlerFromName_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public HierarchyNodeType GetNodeTypeFromType(Il2CppSystem.Type type)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetNodeTypeFromType_Injected(intPtr, type, out var ret);
		return ret;
	}

	public unsafe void AddNodeSpan([In] ref HierarchyNode parent, Il2CppSystem.Span<HierarchyNode> nodes)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<HierarchyNode> span = nodes;
		fixed (HierarchyNode* begin = &((Il2CppSystem.Span<HierarchyNode>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper nodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<HierarchyNode>)(&span)).Length);
			AddNodeSpan_Injected(intPtr, ref parent, ref nodes2);
		}
	}

	public unsafe int GetNodeChildrenSpan([In] ref HierarchyNode node, Il2CppSystem.Span<HierarchyNode> outChildren)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<HierarchyNode> span = outChildren;
		int nodeChildrenSpan_Injected;
		fixed (HierarchyNode* begin = &((Il2CppSystem.Span<HierarchyNode>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outChildren2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<HierarchyNode>)(&span)).Length);
			nodeChildrenSpan_Injected = GetNodeChildrenSpan_Injected(intPtr, ref node, ref outChildren2);
		}
		return nodeChildrenSpan_Injected;
	}

	public unsafe void SetPropertyString([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, string value)
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
					SetPropertyString_Injected(intPtr, ref property, ref node, ref managedSpanWrapper);
					return;
				}
			}
			SetPropertyString_Injected(intPtr, ref property, ref node, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public string GetPropertyString([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetPropertyString_Injected(intPtr, ref property, ref node, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public void ClearProperty([In] ref HierarchyPropertyId property, [In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearProperty_Injected(intPtr, ref property, ref node);
	}

	public T RegisterNodeTypeHandler<T>() where T : HierarchyNodeTypeHandlerBase
	{
		return ((Il2CppObjectBase)HierarchyNodeTypeHandlerBase.FromIntPtr(GetOrCreateNodeTypeHandler(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))).Cast<T>();
	}

	public void UnregisterNodeTypeHandler<T>() where T : HierarchyNodeTypeHandlerBase
	{
	}

	public int GetAllNodeTypeHandlersBaseCount()
	{
		return GetNodeTypeHandlersBaseCount();
	}

	public unsafe void GetAllNodeTypeHandlersBase(List<HierarchyNodeTypeHandlerBase> handlers)
	{
		//IL_0017: Expected O, but got Ref
		//IL_0042: Expected O, but got Ref
		//IL_0031: Expected O, but got Ref
		//IL_0021: Expected O, but got Ref
		handlers.Clear();
		HierarchyNodeTypeHandlerBaseEnumerable hierarchyNodeTypeHandlerBaseEnumerable = EnumerateNodeTypeHandlersBase();
		HierarchyNodeTypeHandlerBaseEnumerable.Enumerator enumerator = ((HierarchyNodeTypeHandlerBaseEnumerable)(&hierarchyNodeTypeHandlerBaseEnumerable)).GetEnumerator();
		try
		{
			while (((HierarchyNodeTypeHandlerBaseEnumerable.Enumerator)(&enumerator)).MoveNext())
			{
				HierarchyNodeTypeHandlerBase current = ((HierarchyNodeTypeHandlerBaseEnumerable.Enumerator)(&enumerator)).Current;
				handlers.Add(current);
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(HierarchyNodeTypeHandlerBaseEnumerable.Enumerator)(&enumerator)).Dispose();
		}
	}

	public static int get_Count_Injected(System.IntPtr _unity_self)
	{
		return get_Count_InjectedDelegateField(_unity_self);
	}

	public static bool get_Updating_Injected(System.IntPtr _unity_self)
	{
		return get_Updating_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetNodeType_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out HierarchyNodeType ret)
	{
		GetNodeType_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref ret));
	}

	public static void Reserve_Injected(System.IntPtr _unity_self, int count)
	{
		Reserve_InjectedDelegateField(_unity_self, count);
	}

	public unsafe static void ReserveChildren_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, int count)
	{
		ReserveChildren_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), count);
	}

	public unsafe static void GetNextSibling_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out HierarchyNode ret)
	{
		GetNextSibling_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetDepth_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetDepth_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static bool Remove_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return Remove_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static void RemoveChildren_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		RemoveChildren_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public static void Clear_Injected(System.IntPtr _unity_self)
	{
		Clear_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetChild_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, int index, out HierarchyNode ret)
	{
		GetChild_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), index, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetChildIndex_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetChildIndex_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static int GetChildrenCountRecursive_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetChildrenCountRecursive_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static int GetSortIndex_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetSortIndex_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static bool DoesChildrenNeedsSorting_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return DoesChildrenNeedsSorting_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static bool SetName_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, ref ManagedSpanWrapper name)
	{
		return SetName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static void GetName_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out ManagedSpanWrapper ret)
	{
		GetName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetPath_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out ManagedSpanWrapper ret)
	{
		GetPath_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool UpdateIncremental_Injected(System.IntPtr _unity_self)
	{
		return UpdateIncremental_InjectedDelegateField(_unity_self);
	}

	public static bool UpdateIncrementalTimed_Injected(System.IntPtr _unity_self, double milliseconds)
	{
		return UpdateIncrementalTimed_InjectedDelegateField(_unity_self, milliseconds);
	}

	public static System.IntPtr GetOrCreateNodeTypeHandler_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type)
	{
		return GetOrCreateNodeTypeHandler_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public static System.IntPtr GetNodeTypeHandlerFromType_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type)
	{
		return GetNodeTypeHandlerFromType_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public unsafe static System.IntPtr GetNodeTypeHandlerFromNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetNodeTypeHandlerFromNode_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static System.IntPtr GetNodeTypeHandlerFromName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper nodeTypeName)
	{
		return GetNodeTypeHandlerFromName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref nodeTypeName));
	}

	public unsafe static void GetNodeTypeFromType_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type, out HierarchyNodeType ret)
	{
		GetNodeTypeFromType_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void AddNodeSpan_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode parent, ref ManagedSpanWrapper nodes)
	{
		AddNodeSpan_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref parent), (nint)Unsafe.AsPointer(ref nodes));
	}

	public unsafe static int GetNodeChildrenSpan_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, ref ManagedSpanWrapper outChildren)
	{
		return GetNodeChildrenSpan_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref outChildren));
	}

	public unsafe static void SetPropertyString_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, ref ManagedSpanWrapper value)
	{
		SetPropertyString_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref property), (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void GetPropertyString_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node, out ManagedSpanWrapper ret)
	{
		GetPropertyString_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref property), (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ClearProperty_Injected(System.IntPtr _unity_self, [In] ref HierarchyPropertyId property, [In] ref HierarchyNode node)
	{
		ClearProperty_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref property), (nint)Unsafe.AsPointer(ref node));
	}
}
