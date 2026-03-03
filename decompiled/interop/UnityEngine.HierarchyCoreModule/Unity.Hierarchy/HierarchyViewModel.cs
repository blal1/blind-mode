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

public sealed class HierarchyViewModel : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyViewModel_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyViewModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663574);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(HierarchyViewModel viewModel)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)viewModel);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyViewModel_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class Enumerator : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_ViewModel;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_HierarchyFlattened;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_NodesPtr;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_NodesCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewModel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_byref_HierarchyNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

		public unsafe HierarchyViewModel m_ViewModel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewModel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyViewModel>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe HierarchyFlattened m_HierarchyFlattened
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyFlattened);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyFlattened>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyFlattened)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int* m_NodesPtr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesPtr);
				return *(int**)num;
			}
			set
			{
				*(int**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesPtr)) = value;
			}
		}

		public unsafe int m_NodesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesCount)) = value;
			}
		}

		public unsafe int m_Version
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		public unsafe int m_Index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		public unsafe ref HierarchyNode Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243731, XrefRangeEnd = 1243739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_byref_HierarchyNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return ref *(HierarchyNode*)intPtr2;
			}
		}

		static Enumerator()
		{
			Il2CppClassPointerStore<Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "Enumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerator>.NativeClassPtr);
			NativeFieldInfoPtr_m_ViewModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_ViewModel");
			NativeFieldInfoPtr_m_HierarchyFlattened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_HierarchyFlattened");
			NativeFieldInfoPtr_m_NodesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_NodesPtr");
			NativeFieldInfoPtr_m_NodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_NodesCount");
			NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Version");
			NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Index");
			NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663575);
			NativeMethodInfoPtr_get_Current_Public_get_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663576);
			NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663577);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243728, XrefRangeEnd = 1243731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Enumerator(HierarchyViewModel hierarchyViewModel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchyViewModel);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewModel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public Enumerator(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Enumerator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerator>.NativeClassPtr))
		{
		}
	}

	private delegate bool get_Updating_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_UpdateProgress_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_Query_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void GetParent_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, [Out] System.IntPtr ret);

	private delegate void GetNextSibling_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, [Out] System.IntPtr ret);

	private delegate int GetChildrenCountRecursive_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate int GetDepth_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate HierarchyNodeFlags GetFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node);

	private delegate int HasAllFlagsCount_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate int HasAnyFlagsCount_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate int DoesNotHaveAllFlagsCount_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate int DoesNotHaveAnyFlagsCount_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate bool UpdateIncremental_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool UpdateIncrementalTimed_InjectedDelegate(System.IntPtr _unity_self, double milliseconds);

	private delegate int SetFlagsNodes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr nodes, HierarchyNodeFlags flags);

	private delegate int SetFlagsIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indices, HierarchyNodeFlags flags);

	private delegate bool HasAllFlagsAny_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate bool HasAnyFlagsAny_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate bool HasAnyFlagsNode_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, HierarchyNodeFlags flags);

	private delegate bool DoesNotHaveAllFlagsAny_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate bool DoesNotHaveAnyFlagsAny_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate bool DoesNotHaveAllFlagsNode_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, HierarchyNodeFlags flags);

	private delegate bool DoesNotHaveAnyFlagsNode_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, HierarchyNodeFlags flags);

	private delegate void ClearFlagsAll_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate int ClearFlagsNodes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr nodes, HierarchyNodeFlags flags);

	private delegate int ClearFlagsIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indices, HierarchyNodeFlags flags);

	private delegate void ToggleFlagsAll_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags);

	private delegate void ToggleFlagsNode_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr node, HierarchyNodeFlags flags, bool recurse);

	private delegate int ToggleFlagsNodes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr nodes, HierarchyNodeFlags flags);

	private delegate int ToggleFlagsIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indices, HierarchyNodeFlags flags);

	private delegate int GetNodesWithAllFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outNodes);

	private delegate int GetNodesWithAnyFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outNodes);

	private delegate int GetIndicesWithAllFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outIndices);

	private delegate int GetIndicesWithAnyFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outIndices);

	private delegate int GetNodesWithoutAllFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outNodes);

	private delegate int GetNodesWithoutAnyFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outNodes);

	private delegate int GetIndicesWithoutAllFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outIndices);

	private delegate int GetIndicesWithoutAnyFlagsSpan_InjectedDelegate(System.IntPtr _unity_self, HierarchyNodeFlags flags, System.IntPtr outIndices);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hierarchy;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HierarchyFlattened;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NodesPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NodesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsOwner;

	private static readonly System.IntPtr NativeFieldInfoPtr__QueryParser_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdateNeeded_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HierarchyFlattened_Public_get_HierarchyFlattened_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_QueryParser_Internal_set_Void_IHierarchySearchQueryParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Query_Internal_get_HierarchySearchQueryDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HierarchyFlattened_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_IntPtr_HierarchyFlattened_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_HierarchyNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildrenCount_Public_Int32_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFlags_Public_Void_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFlags_Public_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAllFlags_Public_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFlags_Public_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateNodesWithAllFlags_Public_HierarchyViewNodesEnumerable_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyViewModel_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_IntPtr_HierarchyFlattened_HierarchyNodeFlags_byref_IntPtr_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFlagsAll_Private_Void_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFlagsNode_Private_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAllFlagsNode_Private_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFlagsNode_Private_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHierarchyViewModel_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHierarchyViewModel_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchBegin_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdateNeeded_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Query_Injected_Private_Static_HierarchySearchQueryDescriptor_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildrenCount_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_IntPtr_IntPtr_IntPtr_HierarchyNodeFlags_byref_IntPtr_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFlagsAll_Injected_Private_Static_Void_IntPtr_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFlagsNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAllFlagsNode_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFlagsNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0;

	private static readonly get_Updating_InjectedDelegate get_Updating_InjectedDelegateField;

	private static readonly get_UpdateProgress_InjectedDelegate get_UpdateProgress_InjectedDelegateField;

	private static readonly set_Query_InjectedDelegate set_Query_InjectedDelegateField;

	private static readonly GetParent_InjectedDelegate GetParent_InjectedDelegateField;

	private static readonly GetNextSibling_InjectedDelegate GetNextSibling_InjectedDelegateField;

	private static readonly GetChildrenCountRecursive_InjectedDelegate GetChildrenCountRecursive_InjectedDelegateField;

	private static readonly GetDepth_InjectedDelegate GetDepth_InjectedDelegateField;

	private static readonly GetFlags_InjectedDelegate GetFlags_InjectedDelegateField;

	private static readonly HasAllFlagsCount_InjectedDelegate HasAllFlagsCount_InjectedDelegateField;

	private static readonly HasAnyFlagsCount_InjectedDelegate HasAnyFlagsCount_InjectedDelegateField;

	private static readonly DoesNotHaveAllFlagsCount_InjectedDelegate DoesNotHaveAllFlagsCount_InjectedDelegateField;

	private static readonly DoesNotHaveAnyFlagsCount_InjectedDelegate DoesNotHaveAnyFlagsCount_InjectedDelegateField;

	private static readonly UpdateIncremental_InjectedDelegate UpdateIncremental_InjectedDelegateField;

	private static readonly UpdateIncrementalTimed_InjectedDelegate UpdateIncrementalTimed_InjectedDelegateField;

	private static readonly SetFlagsNodes_InjectedDelegate SetFlagsNodes_InjectedDelegateField;

	private static readonly SetFlagsIndices_InjectedDelegate SetFlagsIndices_InjectedDelegateField;

	private static readonly HasAllFlagsAny_InjectedDelegate HasAllFlagsAny_InjectedDelegateField;

	private static readonly HasAnyFlagsAny_InjectedDelegate HasAnyFlagsAny_InjectedDelegateField;

	private static readonly HasAnyFlagsNode_InjectedDelegate HasAnyFlagsNode_InjectedDelegateField;

	private static readonly DoesNotHaveAllFlagsAny_InjectedDelegate DoesNotHaveAllFlagsAny_InjectedDelegateField;

	private static readonly DoesNotHaveAnyFlagsAny_InjectedDelegate DoesNotHaveAnyFlagsAny_InjectedDelegateField;

	private static readonly DoesNotHaveAllFlagsNode_InjectedDelegate DoesNotHaveAllFlagsNode_InjectedDelegateField;

	private static readonly DoesNotHaveAnyFlagsNode_InjectedDelegate DoesNotHaveAnyFlagsNode_InjectedDelegateField;

	private static readonly ClearFlagsAll_InjectedDelegate ClearFlagsAll_InjectedDelegateField;

	private static readonly ClearFlagsNodes_InjectedDelegate ClearFlagsNodes_InjectedDelegateField;

	private static readonly ClearFlagsIndices_InjectedDelegate ClearFlagsIndices_InjectedDelegateField;

	private static readonly ToggleFlagsAll_InjectedDelegate ToggleFlagsAll_InjectedDelegateField;

	private static readonly ToggleFlagsNode_InjectedDelegate ToggleFlagsNode_InjectedDelegateField;

	private static readonly ToggleFlagsNodes_InjectedDelegate ToggleFlagsNodes_InjectedDelegateField;

	private static readonly ToggleFlagsIndices_InjectedDelegate ToggleFlagsIndices_InjectedDelegateField;

	private static readonly GetNodesWithAllFlagsSpan_InjectedDelegate GetNodesWithAllFlagsSpan_InjectedDelegateField;

	private static readonly GetNodesWithAnyFlagsSpan_InjectedDelegate GetNodesWithAnyFlagsSpan_InjectedDelegateField;

	private static readonly GetIndicesWithAllFlagsSpan_InjectedDelegate GetIndicesWithAllFlagsSpan_InjectedDelegateField;

	private static readonly GetIndicesWithAnyFlagsSpan_InjectedDelegate GetIndicesWithAnyFlagsSpan_InjectedDelegateField;

	private static readonly GetNodesWithoutAllFlagsSpan_InjectedDelegate GetNodesWithoutAllFlagsSpan_InjectedDelegateField;

	private static readonly GetNodesWithoutAnyFlagsSpan_InjectedDelegate GetNodesWithoutAnyFlagsSpan_InjectedDelegateField;

	private static readonly GetIndicesWithoutAllFlagsSpan_InjectedDelegate GetIndicesWithoutAllFlagsSpan_InjectedDelegateField;

	private static readonly GetIndicesWithoutAnyFlagsSpan_InjectedDelegate GetIndicesWithoutAnyFlagsSpan_InjectedDelegateField;

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

	public unsafe Hierarchy m_Hierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hierarchy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HierarchyFlattened m_HierarchyFlattened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyFlattened);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyFlattened>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyFlattened)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe System.IntPtr m_NodesPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesPtr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesPtr)) = value;
		}
	}

	public unsafe int m_NodesCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesCount)) = value;
		}
	}

	public unsafe int m_Version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version)) = value;
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

	public unsafe IHierarchySearchQueryParser _QueryParser_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__QueryParser_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IHierarchySearchQueryParser>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__QueryParser_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool IsCreated
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1242961, RefRangeEnd = 1242969, XrefRangeStart = 1242961, XrefRangeEnd = 1242969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe int Count
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool UpdateNeeded
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1243743, RefRangeEnd = 1243746, XrefRangeStart = 1243739, XrefRangeEnd = 1243743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe HierarchyFlattened HierarchyFlattened
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HierarchyFlattened_Public_get_HierarchyFlattened_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyFlattened>(intPtr2) : null;
		}
	}

	public unsafe int Version
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65293, RefRangeEnd = 65294, XrefRangeStart = 65293, XrefRangeEnd = 65294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe IHierarchySearchQueryParser QueryParser
	{
		get
		{
			return _QueryParser_k__BackingField;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_QueryParser_Internal_set_Void_IHierarchySearchQueryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe HierarchySearchQueryDescriptor Query
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243746, XrefRangeEnd = 1243750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Query_Internal_get_HierarchySearchQueryDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchySearchQueryDescriptor>(intPtr2) : null;
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_Query_Injected(intPtr, value);
		}
	}

	public unsafe ref HierarchyNode this[int index]
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1243796, RefRangeEnd = 1243809, XrefRangeStart = 1243787, XrefRangeEnd = 1243796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_byref_HierarchyNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(HierarchyNode*)intPtr2;
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

	public Hierarchy Hierarchy => m_Hierarchy;

	public unsafe int* NodesPtr => (int*)(void*)m_NodesPtr;

	public float UpdateProgress
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_UpdateProgress_Injected(intPtr);
		}
	}

	static HierarchyViewModel()
	{
		Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyViewModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_Hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "m_Hierarchy");
		NativeFieldInfoPtr_m_HierarchyFlattened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "m_HierarchyFlattened");
		NativeFieldInfoPtr_m_NodesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "m_NodesPtr");
		NativeFieldInfoPtr_m_NodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "m_NodesCount");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "m_Version");
		NativeFieldInfoPtr_m_IsOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "m_IsOwner");
		NativeFieldInfoPtr__QueryParser_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, "<QueryParser>k__BackingField");
		NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_get_UpdateNeeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_get_HierarchyFlattened_Public_get_HierarchyFlattened_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_set_QueryParser_Internal_set_Void_IHierarchySearchQueryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_get_Query_Internal_get_HierarchySearchQueryDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr__ctor_Public_Void_HierarchyFlattened_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr__ctor_Private_Void_IntPtr_HierarchyFlattened_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_get_Item_Public_get_byref_HierarchyNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_IndexOf_Public_Int32_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_Contains_Public_Boolean_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_GetChildrenCount_Public_Int32_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_SetFlags_Public_Void_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_SetFlags_Public_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_HasAllFlags_Public_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_ClearFlags_Public_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_EnumerateNodesWithAllFlags_Public_HierarchyViewNodesEnumerable_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyViewModel_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_Create_Private_Static_IntPtr_IntPtr_HierarchyFlattened_HierarchyNodeFlags_byref_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_SetFlagsAll_Private_Void_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_SetFlagsNode_Private_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_HasAllFlagsNode_Private_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_ClearFlagsNode_Private_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_CreateHierarchyViewModel_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_UpdateHierarchyViewModel_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_SearchBegin_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_get_UpdateNeeded_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_get_Query_Injected_Private_Static_HierarchySearchQueryDescriptor_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_IndexOf_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_GetChildrenCount_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_Update_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_Create_Injected_Private_Static_IntPtr_IntPtr_IntPtr_HierarchyNodeFlags_byref_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_SetFlagsAll_Injected_Private_Static_Void_IntPtr_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_SetFlagsNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_HasAllFlagsNode_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_ClearFlagsNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr, 100663573);
		get_Updating_InjectedDelegateField = IL2CPP.ResolveICall<get_Updating_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::get_Updating_Injected");
		get_UpdateProgress_InjectedDelegateField = IL2CPP.ResolveICall<get_UpdateProgress_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::get_UpdateProgress_Injected");
		set_Query_InjectedDelegateField = IL2CPP.ResolveICall<set_Query_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::set_Query_Injected");
		GetParent_InjectedDelegateField = IL2CPP.ResolveICall<GetParent_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetParent_Injected");
		GetNextSibling_InjectedDelegateField = IL2CPP.ResolveICall<GetNextSibling_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetNextSibling_Injected");
		GetChildrenCountRecursive_InjectedDelegateField = IL2CPP.ResolveICall<GetChildrenCountRecursive_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetChildrenCountRecursive_Injected");
		GetDepth_InjectedDelegateField = IL2CPP.ResolveICall<GetDepth_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetDepth_Injected");
		GetFlags_InjectedDelegateField = IL2CPP.ResolveICall<GetFlags_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetFlags_Injected");
		HasAllFlagsCount_InjectedDelegateField = IL2CPP.ResolveICall<HasAllFlagsCount_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::HasAllFlagsCount_Injected");
		HasAnyFlagsCount_InjectedDelegateField = IL2CPP.ResolveICall<HasAnyFlagsCount_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::HasAnyFlagsCount_Injected");
		DoesNotHaveAllFlagsCount_InjectedDelegateField = IL2CPP.ResolveICall<DoesNotHaveAllFlagsCount_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::DoesNotHaveAllFlagsCount_Injected");
		DoesNotHaveAnyFlagsCount_InjectedDelegateField = IL2CPP.ResolveICall<DoesNotHaveAnyFlagsCount_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::DoesNotHaveAnyFlagsCount_Injected");
		UpdateIncremental_InjectedDelegateField = IL2CPP.ResolveICall<UpdateIncremental_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::UpdateIncremental_Injected");
		UpdateIncrementalTimed_InjectedDelegateField = IL2CPP.ResolveICall<UpdateIncrementalTimed_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::UpdateIncrementalTimed_Injected");
		SetFlagsNodes_InjectedDelegateField = IL2CPP.ResolveICall<SetFlagsNodes_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::SetFlagsNodes_Injected");
		SetFlagsIndices_InjectedDelegateField = IL2CPP.ResolveICall<SetFlagsIndices_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::SetFlagsIndices_Injected");
		HasAllFlagsAny_InjectedDelegateField = IL2CPP.ResolveICall<HasAllFlagsAny_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::HasAllFlagsAny_Injected");
		HasAnyFlagsAny_InjectedDelegateField = IL2CPP.ResolveICall<HasAnyFlagsAny_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::HasAnyFlagsAny_Injected");
		HasAnyFlagsNode_InjectedDelegateField = IL2CPP.ResolveICall<HasAnyFlagsNode_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::HasAnyFlagsNode_Injected");
		DoesNotHaveAllFlagsAny_InjectedDelegateField = IL2CPP.ResolveICall<DoesNotHaveAllFlagsAny_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::DoesNotHaveAllFlagsAny_Injected");
		DoesNotHaveAnyFlagsAny_InjectedDelegateField = IL2CPP.ResolveICall<DoesNotHaveAnyFlagsAny_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::DoesNotHaveAnyFlagsAny_Injected");
		DoesNotHaveAllFlagsNode_InjectedDelegateField = IL2CPP.ResolveICall<DoesNotHaveAllFlagsNode_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::DoesNotHaveAllFlagsNode_Injected");
		DoesNotHaveAnyFlagsNode_InjectedDelegateField = IL2CPP.ResolveICall<DoesNotHaveAnyFlagsNode_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::DoesNotHaveAnyFlagsNode_Injected");
		ClearFlagsAll_InjectedDelegateField = IL2CPP.ResolveICall<ClearFlagsAll_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::ClearFlagsAll_Injected");
		ClearFlagsNodes_InjectedDelegateField = IL2CPP.ResolveICall<ClearFlagsNodes_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::ClearFlagsNodes_Injected");
		ClearFlagsIndices_InjectedDelegateField = IL2CPP.ResolveICall<ClearFlagsIndices_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::ClearFlagsIndices_Injected");
		ToggleFlagsAll_InjectedDelegateField = IL2CPP.ResolveICall<ToggleFlagsAll_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::ToggleFlagsAll_Injected");
		ToggleFlagsNode_InjectedDelegateField = IL2CPP.ResolveICall<ToggleFlagsNode_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::ToggleFlagsNode_Injected");
		ToggleFlagsNodes_InjectedDelegateField = IL2CPP.ResolveICall<ToggleFlagsNodes_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::ToggleFlagsNodes_Injected");
		ToggleFlagsIndices_InjectedDelegateField = IL2CPP.ResolveICall<ToggleFlagsIndices_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::ToggleFlagsIndices_Injected");
		GetNodesWithAllFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetNodesWithAllFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetNodesWithAllFlagsSpan_Injected");
		GetNodesWithAnyFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetNodesWithAnyFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetNodesWithAnyFlagsSpan_Injected");
		GetIndicesWithAllFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetIndicesWithAllFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetIndicesWithAllFlagsSpan_Injected");
		GetIndicesWithAnyFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetIndicesWithAnyFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetIndicesWithAnyFlagsSpan_Injected");
		GetNodesWithoutAllFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetNodesWithoutAllFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetNodesWithoutAllFlagsSpan_Injected");
		GetNodesWithoutAnyFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetNodesWithoutAnyFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetNodesWithoutAnyFlagsSpan_Injected");
		GetIndicesWithoutAllFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetIndicesWithoutAllFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetIndicesWithoutAllFlagsSpan_Injected");
		GetIndicesWithoutAnyFlagsSpan_InjectedDelegateField = IL2CPP.ResolveICall<GetIndicesWithoutAnyFlagsSpan_InjectedDelegate>("Unity.Hierarchy.HierarchyViewModel::GetIndicesWithoutAnyFlagsSpan_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243762, RefRangeEnd = 1243764, XrefRangeStart = 1243750, XrefRangeEnd = 1243762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyViewModel(HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags = HierarchyNodeFlags.None)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchyFlattened);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HierarchyFlattened_HierarchyNodeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243764, XrefRangeEnd = 1243773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyViewModel(System.IntPtr nativePtr, HierarchyFlattened hierarchyFlattened, System.IntPtr nodesPtr, int nodesCount, int version)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyViewModel>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&nativePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchyFlattened);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodesPtr;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodesCount;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_IntPtr_HierarchyFlattened_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243773, XrefRangeEnd = 1243778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243784, RefRangeEnd = 1243785, XrefRangeStart = 1243778, XrefRangeEnd = 1243784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243785, XrefRangeEnd = 1243787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243813, RefRangeEnd = 1243815, XrefRangeStart = 1243809, XrefRangeEnd = 1243813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243819, RefRangeEnd = 1243820, XrefRangeStart = 1243815, XrefRangeEnd = 1243819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_byref_HierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1243824, RefRangeEnd = 1243830, XrefRangeStart = 1243820, XrefRangeEnd = 1243824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243834, RefRangeEnd = 1243836, XrefRangeStart = 1243830, XrefRangeEnd = 1243834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFlags(HierarchyNodeFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlags_Public_Void_HierarchyNodeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1243840, RefRangeEnd = 1243843, XrefRangeStart = 1243836, XrefRangeEnd = 1243840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlags_Public_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243847, RefRangeEnd = 1243849, XrefRangeStart = 1243843, XrefRangeEnd = 1243847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasAllFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAllFlags_Public_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243853, RefRangeEnd = 1243855, XrefRangeStart = 1243849, XrefRangeEnd = 1243853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFlags_Public_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243866, RefRangeEnd = 1243867, XrefRangeStart = 1243855, XrefRangeEnd = 1243866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyViewNodesEnumerable EnumerateNodesWithAllFlags(HierarchyNodeFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumerateNodesWithAllFlags_Public_HierarchyViewNodesEnumerable_HierarchyNodeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HierarchyViewNodesEnumerable(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1243871, RefRangeEnd = 1243874, XrefRangeStart = 1243867, XrefRangeEnd = 1243871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1243877, RefRangeEnd = 1243880, XrefRangeStart = 1243874, XrefRangeEnd = 1243877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Enumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Enumerator(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243880, XrefRangeEnd = 1243887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HierarchyViewModel FromIntPtr(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyViewModel_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyViewModel>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243887, XrefRangeEnd = 1243890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create(System.IntPtr handlePtr, HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags, out System.IntPtr nodesPtr, out int nodesCount, out int version)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&handlePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchyFlattened);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultFlags;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nodesPtr);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nodesCount);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref version);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Static_IntPtr_IntPtr_HierarchyFlattened_HierarchyNodeFlags_byref_IntPtr_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243890, XrefRangeEnd = 1243892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(System.IntPtr nativePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243834, RefRangeEnd = 1243836, XrefRangeStart = 1243834, XrefRangeEnd = 1243836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFlagsAll(HierarchyNodeFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlagsAll_Private_Void_HierarchyNodeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1243840, RefRangeEnd = 1243843, XrefRangeStart = 1243840, XrefRangeEnd = 1243843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFlagsNode([In] ref HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlagsNode_Private_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243847, RefRangeEnd = 1243849, XrefRangeStart = 1243847, XrefRangeEnd = 1243849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasAllFlagsNode([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAllFlagsNode_Private_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243853, RefRangeEnd = 1243855, XrefRangeStart = 1243853, XrefRangeEnd = 1243855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFlagsNode([In] ref HierarchyNode node, HierarchyNodeFlags flags, bool recurse = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFlagsNode_Private_Void_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243892, XrefRangeEnd = 1243907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateHierarchyViewModel(System.IntPtr nativePtr, System.IntPtr flattenedPtr, System.IntPtr nodesPtr, int nodesCount, int version)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&nativePtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flattenedPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodesPtr;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodesCount;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHierarchyViewModel_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243907, XrefRangeEnd = 1243908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateHierarchyViewModel(System.IntPtr handlePtr, System.IntPtr nodesPtr, int nodesCount, int version)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&handlePtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodesPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodesCount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateHierarchyViewModel_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243908, XrefRangeEnd = 1243930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SearchBegin(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchBegin_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243930, XrefRangeEnd = 1243932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243932, XrefRangeEnd = 1243934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HierarchySearchQueryDescriptor get_Query_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Query_Injected_Private_Static_HierarchySearchQueryDescriptor_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchySearchQueryDescriptor>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243934, XrefRangeEnd = 1243936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Injected_Private_Static_Int32_IntPtr_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243936, XrefRangeEnd = 1243938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Contains_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243938, XrefRangeEnd = 1243940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243940, XrefRangeEnd = 1243942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243942, XrefRangeEnd = 1243944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create_Injected(System.IntPtr handlePtr, System.IntPtr hierarchyFlattened, HierarchyNodeFlags defaultFlags, out System.IntPtr nodesPtr, out int nodesCount, out int version)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&handlePtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hierarchyFlattened;
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultFlags;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nodesPtr);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nodesCount);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref version);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Injected_Private_Static_IntPtr_IntPtr_IntPtr_HierarchyNodeFlags_byref_IntPtr_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243944, XrefRangeEnd = 1243946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFlagsAll_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlagsAll_Injected_Private_Static_Void_IntPtr_HierarchyNodeFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243946, XrefRangeEnd = 1243948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFlagsNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags flags, bool recurse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlagsNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243948, XrefRangeEnd = 1243950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasAllFlagsNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAllFlagsNode_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243950, XrefRangeEnd = 1243952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearFlagsNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags flags, bool recurse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recurse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFlagsNode_Injected_Private_Static_Void_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HierarchyViewModel(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HierarchyNode GetParent([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetParent_Injected(intPtr, ref node, out var ret);
		return ret;
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

	public int GetChildrenCountRecursive([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetChildrenCountRecursive_Injected(intPtr, ref node);
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

	public HierarchyNodeFlags GetFlags([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetFlags_Injected(intPtr, ref node);
	}

	public int SetFlags(Il2CppSystem.ReadOnlySpan<HierarchyNode> nodes, HierarchyNodeFlags flags)
	{
		return SetFlagsNodes(nodes, flags);
	}

	public int SetFlags(Il2CppSystem.ReadOnlySpan<int> indices, HierarchyNodeFlags flags)
	{
		return SetFlagsIndices(indices, flags);
	}

	public bool HasAllFlags(HierarchyNodeFlags flags)
	{
		return HasAllFlagsAny(flags);
	}

	public bool HasAnyFlags(HierarchyNodeFlags flags)
	{
		return HasAnyFlagsAny(flags);
	}

	public bool HasAnyFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return HasAnyFlagsNode(ref node, flags);
	}

	public int HasAllFlagsCount(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasAllFlagsCount_Injected(intPtr, flags);
	}

	public int HasAnyFlagsCount(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasAnyFlagsCount_Injected(intPtr, flags);
	}

	public bool DoesNotHaveAllFlags(HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsAny(flags);
	}

	public bool DoesNotHaveAnyFlags(HierarchyNodeFlags flags)
	{
		return DoesNotHaveAnyFlagsAny(flags);
	}

	public bool DoesNotHaveAllFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsNode(ref node, flags);
	}

	public bool DoesNotHaveAnyFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAnyFlagsNode(ref node, flags);
	}

	public int DoesNotHaveAllFlagsCount(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return DoesNotHaveAllFlagsCount_Injected(intPtr, flags);
	}

	public int DoesNotHaveAnyFlagsCount(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return DoesNotHaveAnyFlagsCount_Injected(intPtr, flags);
	}

	public void ClearFlags(HierarchyNodeFlags flags)
	{
		ClearFlagsAll(flags);
	}

	public int ClearFlags(Il2CppSystem.ReadOnlySpan<HierarchyNode> nodes, HierarchyNodeFlags flags)
	{
		return ClearFlagsNodes(nodes, flags);
	}

	public int ClearFlags(Il2CppSystem.ReadOnlySpan<int> indices, HierarchyNodeFlags flags)
	{
		return ClearFlagsIndices(indices, flags);
	}

	public void ToggleFlags(HierarchyNodeFlags flags)
	{
		ToggleFlagsAll(flags);
	}

	public void ToggleFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags, [Optional] bool recurse)
	{
		ToggleFlagsNode(ref node, flags, recurse);
	}

	public int ToggleFlags(Il2CppSystem.ReadOnlySpan<HierarchyNode> nodes, HierarchyNodeFlags flags)
	{
		return ToggleFlagsNodes(nodes, flags);
	}

	public int ToggleFlags(Il2CppSystem.ReadOnlySpan<int> indices, HierarchyNodeFlags flags)
	{
		return ToggleFlagsIndices(indices, flags);
	}

	public int GetNodesWithAllFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		return GetNodesWithAllFlagsSpan(flags, outNodes);
	}

	public int GetNodesWithAnyFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		return GetNodesWithAnyFlagsSpan(flags, outNodes);
	}

	public Il2CppStructArray<HierarchyNode> GetNodesWithAllFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppStructArray<HierarchyNode> GetNodesWithAnyFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe HierarchyViewNodesEnumerable EnumerateNodesWithAnyFlags(HierarchyNodeFlags flags)
	{
		return new HierarchyViewNodesEnumerable(this, flags, new HierarchyViewNodesEnumerable.Predicate(this, (nint)__ldftn(HierarchyViewModel.HasAnyFlags)));
	}

	public int GetIndicesWithAllFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		return GetIndicesWithAllFlagsSpan(flags, outIndices);
	}

	public int GetIndicesWithAnyFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		return GetIndicesWithAnyFlagsSpan(flags, outIndices);
	}

	public Il2CppStructArray<int> GetIndicesWithAllFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppStructArray<int> GetIndicesWithAnyFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetNodesWithoutAllFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		return GetNodesWithoutAllFlagsSpan(flags, outNodes);
	}

	public int GetNodesWithoutAnyFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		return GetNodesWithoutAnyFlagsSpan(flags, outNodes);
	}

	public Il2CppStructArray<HierarchyNode> GetNodesWithoutAllFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppStructArray<HierarchyNode> GetNodesWithoutAnyFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe HierarchyViewNodesEnumerable EnumerateNodesWithoutAllFlags(HierarchyNodeFlags flags)
	{
		return new HierarchyViewNodesEnumerable(this, flags, new HierarchyViewNodesEnumerable.Predicate(this, (nint)__ldftn(HierarchyViewModel.DoesNotHaveAllFlags)));
	}

	public unsafe HierarchyViewNodesEnumerable EnumerateNodesWithoutAnyFlags(HierarchyNodeFlags flags)
	{
		return new HierarchyViewNodesEnumerable(this, flags, new HierarchyViewNodesEnumerable.Predicate(this, (nint)__ldftn(HierarchyViewModel.DoesNotHaveAnyFlags)));
	}

	public int GetIndicesWithoutAllFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		return GetIndicesWithoutAllFlagsSpan(flags, outIndices);
	}

	public int GetIndicesWithoutAnyFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		return GetIndicesWithoutAnyFlagsSpan(flags, outIndices);
	}

	public Il2CppStructArray<int> GetIndicesWithoutAllFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppStructArray<int> GetIndicesWithoutAnyFlags(HierarchyNodeFlags flags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetQuery(string query)
	{
		HierarchySearchQueryDescriptor hierarchySearchQueryDescriptor = QueryParser.ParseQuery(query);
		if (hierarchySearchQueryDescriptor != Query)
		{
			Query = hierarchySearchQueryDescriptor;
		}
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

	public unsafe int SetFlagsNodes(Il2CppSystem.ReadOnlySpan<HierarchyNode> nodes, HierarchyNodeFlags flags)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<HierarchyNode> readOnlySpan = nodes;
		int result;
		fixed (HierarchyNode* begin = &((Il2CppSystem.ReadOnlySpan<HierarchyNode>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper nodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<HierarchyNode>)(&readOnlySpan)).Length);
			result = SetFlagsNodes_Injected(intPtr, ref nodes2, flags);
		}
		return result;
	}

	public unsafe int SetFlagsIndices(Il2CppSystem.ReadOnlySpan<int> indices, HierarchyNodeFlags flags)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<int> readOnlySpan = indices;
		int result;
		fixed (int* begin = &((Il2CppSystem.ReadOnlySpan<int>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper indices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<int>)(&readOnlySpan)).Length);
			result = SetFlagsIndices_Injected(intPtr, ref indices2, flags);
		}
		return result;
	}

	public bool HasAllFlagsAny(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasAllFlagsAny_Injected(intPtr, flags);
	}

	public bool HasAnyFlagsAny(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasAnyFlagsAny_Injected(intPtr, flags);
	}

	public bool HasAnyFlagsNode([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasAnyFlagsNode_Injected(intPtr, ref node, flags);
	}

	public bool DoesNotHaveAllFlagsAny(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return DoesNotHaveAllFlagsAny_Injected(intPtr, flags);
	}

	public bool DoesNotHaveAnyFlagsAny(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return DoesNotHaveAnyFlagsAny_Injected(intPtr, flags);
	}

	public bool DoesNotHaveAllFlagsNode([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return DoesNotHaveAllFlagsNode_Injected(intPtr, ref node, flags);
	}

	public bool DoesNotHaveAnyFlagsNode([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return DoesNotHaveAnyFlagsNode_Injected(intPtr, ref node, flags);
	}

	public void ClearFlagsAll(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearFlagsAll_Injected(intPtr, flags);
	}

	public unsafe int ClearFlagsNodes(Il2CppSystem.ReadOnlySpan<HierarchyNode> nodes, HierarchyNodeFlags flags)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<HierarchyNode> readOnlySpan = nodes;
		int result;
		fixed (HierarchyNode* begin = &((Il2CppSystem.ReadOnlySpan<HierarchyNode>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper nodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<HierarchyNode>)(&readOnlySpan)).Length);
			result = ClearFlagsNodes_Injected(intPtr, ref nodes2, flags);
		}
		return result;
	}

	public unsafe int ClearFlagsIndices(Il2CppSystem.ReadOnlySpan<int> indices, HierarchyNodeFlags flags)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<int> readOnlySpan = indices;
		int result;
		fixed (int* begin = &((Il2CppSystem.ReadOnlySpan<int>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper indices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<int>)(&readOnlySpan)).Length);
			result = ClearFlagsIndices_Injected(intPtr, ref indices2, flags);
		}
		return result;
	}

	public void ToggleFlagsAll(HierarchyNodeFlags flags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ToggleFlagsAll_Injected(intPtr, flags);
	}

	public void ToggleFlagsNode([In] ref HierarchyNode node, HierarchyNodeFlags flags, [Optional] bool recurse)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ToggleFlagsNode_Injected(intPtr, ref node, flags, recurse);
	}

	public unsafe int ToggleFlagsNodes(Il2CppSystem.ReadOnlySpan<HierarchyNode> nodes, HierarchyNodeFlags flags)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<HierarchyNode> readOnlySpan = nodes;
		int result;
		fixed (HierarchyNode* begin = &((Il2CppSystem.ReadOnlySpan<HierarchyNode>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper nodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<HierarchyNode>)(&readOnlySpan)).Length);
			result = ToggleFlagsNodes_Injected(intPtr, ref nodes2, flags);
		}
		return result;
	}

	public unsafe int ToggleFlagsIndices(Il2CppSystem.ReadOnlySpan<int> indices, HierarchyNodeFlags flags)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<int> readOnlySpan = indices;
		int result;
		fixed (int* begin = &((Il2CppSystem.ReadOnlySpan<int>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper indices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<int>)(&readOnlySpan)).Length);
			result = ToggleFlagsIndices_Injected(intPtr, ref indices2, flags);
		}
		return result;
	}

	public unsafe int GetNodesWithAllFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<HierarchyNode> span = outNodes;
		int nodesWithAllFlagsSpan_Injected;
		fixed (HierarchyNode* begin = &((Il2CppSystem.Span<HierarchyNode>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outNodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<HierarchyNode>)(&span)).Length);
			nodesWithAllFlagsSpan_Injected = GetNodesWithAllFlagsSpan_Injected(intPtr, flags, ref outNodes2);
		}
		return nodesWithAllFlagsSpan_Injected;
	}

	public unsafe int GetNodesWithAnyFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<HierarchyNode> span = outNodes;
		int nodesWithAnyFlagsSpan_Injected;
		fixed (HierarchyNode* begin = &((Il2CppSystem.Span<HierarchyNode>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outNodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<HierarchyNode>)(&span)).Length);
			nodesWithAnyFlagsSpan_Injected = GetNodesWithAnyFlagsSpan_Injected(intPtr, flags, ref outNodes2);
		}
		return nodesWithAnyFlagsSpan_Injected;
	}

	public unsafe int GetIndicesWithAllFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<int> span = outIndices;
		int indicesWithAllFlagsSpan_Injected;
		fixed (int* begin = &((Il2CppSystem.Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outIndices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<int>)(&span)).Length);
			indicesWithAllFlagsSpan_Injected = GetIndicesWithAllFlagsSpan_Injected(intPtr, flags, ref outIndices2);
		}
		return indicesWithAllFlagsSpan_Injected;
	}

	public unsafe int GetIndicesWithAnyFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<int> span = outIndices;
		int indicesWithAnyFlagsSpan_Injected;
		fixed (int* begin = &((Il2CppSystem.Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outIndices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<int>)(&span)).Length);
			indicesWithAnyFlagsSpan_Injected = GetIndicesWithAnyFlagsSpan_Injected(intPtr, flags, ref outIndices2);
		}
		return indicesWithAnyFlagsSpan_Injected;
	}

	public unsafe int GetNodesWithoutAllFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<HierarchyNode> span = outNodes;
		int nodesWithoutAllFlagsSpan_Injected;
		fixed (HierarchyNode* begin = &((Il2CppSystem.Span<HierarchyNode>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outNodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<HierarchyNode>)(&span)).Length);
			nodesWithoutAllFlagsSpan_Injected = GetNodesWithoutAllFlagsSpan_Injected(intPtr, flags, ref outNodes2);
		}
		return nodesWithoutAllFlagsSpan_Injected;
	}

	public unsafe int GetNodesWithoutAnyFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<HierarchyNode> span = outNodes;
		int nodesWithoutAnyFlagsSpan_Injected;
		fixed (HierarchyNode* begin = &((Il2CppSystem.Span<HierarchyNode>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outNodes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<HierarchyNode>)(&span)).Length);
			nodesWithoutAnyFlagsSpan_Injected = GetNodesWithoutAnyFlagsSpan_Injected(intPtr, flags, ref outNodes2);
		}
		return nodesWithoutAnyFlagsSpan_Injected;
	}

	public unsafe int GetIndicesWithoutAllFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<int> span = outIndices;
		int indicesWithoutAllFlagsSpan_Injected;
		fixed (int* begin = &((Il2CppSystem.Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outIndices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<int>)(&span)).Length);
			indicesWithoutAllFlagsSpan_Injected = GetIndicesWithoutAllFlagsSpan_Injected(intPtr, flags, ref outIndices2);
		}
		return indicesWithoutAllFlagsSpan_Injected;
	}

	public unsafe int GetIndicesWithoutAnyFlagsSpan(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.Span<int> span = outIndices;
		int indicesWithoutAnyFlagsSpan_Injected;
		fixed (int* begin = &((Il2CppSystem.Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper outIndices2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<int>)(&span)).Length);
			indicesWithoutAnyFlagsSpan_Injected = GetIndicesWithoutAnyFlagsSpan_Injected(intPtr, flags, ref outIndices2);
		}
		return indicesWithoutAnyFlagsSpan_Injected;
	}

	public bool HasFlags(HierarchyNodeFlags flags)
	{
		return HasAllFlagsAny(flags);
	}

	public bool HasFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return HasAllFlagsNode(ref node, flags);
	}

	public int HasFlagsCount(HierarchyNodeFlags flags)
	{
		return HasAllFlagsCount(flags);
	}

	public bool DoesNotHaveFlags(HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsAny(flags);
	}

	public bool DoesNotHaveFlags([In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsNode(ref node, flags);
	}

	public int DoesNotHaveFlagsCount(HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsCount(flags);
	}

	public int GetNodesWithFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		return GetNodesWithAllFlagsSpan(flags, outNodes);
	}

	public Il2CppStructArray<HierarchyNode> GetNodesWithFlags(HierarchyNodeFlags flags)
	{
		return GetNodesWithAllFlags(flags);
	}

	public HierarchyViewNodesEnumerable EnumerateNodesWithFlags(HierarchyNodeFlags flags)
	{
		return EnumerateNodesWithAllFlags(flags);
	}

	public int GetIndicesWithFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		return GetIndicesWithAllFlagsSpan(flags, outIndices);
	}

	public Il2CppStructArray<int> GetIndicesWithFlags(HierarchyNodeFlags flags)
	{
		return GetIndicesWithAllFlags(flags);
	}

	public int GetNodesWithoutFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<HierarchyNode> outNodes)
	{
		return GetNodesWithoutAllFlagsSpan(flags, outNodes);
	}

	public Il2CppStructArray<HierarchyNode> GetNodesWithoutFlags(HierarchyNodeFlags flags)
	{
		return GetNodesWithoutAllFlags(flags);
	}

	public HierarchyViewNodesEnumerable EnumerateNodesWithoutFlags(HierarchyNodeFlags flags)
	{
		return EnumerateNodesWithoutAllFlags(flags);
	}

	public int GetIndicesWithoutFlags(HierarchyNodeFlags flags, Il2CppSystem.Span<int> outIndices)
	{
		return GetIndicesWithoutAllFlagsSpan(flags, outIndices);
	}

	public Il2CppStructArray<int> GetIndicesWithoutFlags(HierarchyNodeFlags flags)
	{
		return GetIndicesWithoutAllFlags(flags);
	}

	public static bool get_Updating_Injected(System.IntPtr _unity_self)
	{
		return get_Updating_InjectedDelegateField(_unity_self);
	}

	public static float get_UpdateProgress_Injected(System.IntPtr _unity_self)
	{
		return get_UpdateProgress_InjectedDelegateField(_unity_self);
	}

	public static void set_Query_Injected(System.IntPtr _unity_self, HierarchySearchQueryDescriptor value)
	{
		set_Query_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public unsafe static void GetParent_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out HierarchyNode ret)
	{
		GetParent_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetNextSibling_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, out HierarchyNode ret)
	{
		GetNextSibling_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetChildrenCountRecursive_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetChildrenCountRecursive_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static int GetDepth_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetDepth_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public unsafe static HierarchyNodeFlags GetFlags_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		return GetFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node));
	}

	public static int HasAllFlagsCount_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return HasAllFlagsCount_InjectedDelegateField(_unity_self, flags);
	}

	public static int HasAnyFlagsCount_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return HasAnyFlagsCount_InjectedDelegateField(_unity_self, flags);
	}

	public static int DoesNotHaveAllFlagsCount_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsCount_InjectedDelegateField(_unity_self, flags);
	}

	public static int DoesNotHaveAnyFlagsCount_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAnyFlagsCount_InjectedDelegateField(_unity_self, flags);
	}

	public static bool UpdateIncremental_Injected(System.IntPtr _unity_self)
	{
		return UpdateIncremental_InjectedDelegateField(_unity_self);
	}

	public static bool UpdateIncrementalTimed_Injected(System.IntPtr _unity_self, double milliseconds)
	{
		return UpdateIncrementalTimed_InjectedDelegateField(_unity_self, milliseconds);
	}

	public unsafe static int SetFlagsNodes_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper nodes, HierarchyNodeFlags flags)
	{
		return SetFlagsNodes_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref nodes), flags);
	}

	public unsafe static int SetFlagsIndices_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper indices, HierarchyNodeFlags flags)
	{
		return SetFlagsIndices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref indices), flags);
	}

	public static bool HasAllFlagsAny_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return HasAllFlagsAny_InjectedDelegateField(_unity_self, flags);
	}

	public static bool HasAnyFlagsAny_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return HasAnyFlagsAny_InjectedDelegateField(_unity_self, flags);
	}

	public unsafe static bool HasAnyFlagsNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return HasAnyFlagsNode_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), flags);
	}

	public static bool DoesNotHaveAllFlagsAny_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsAny_InjectedDelegateField(_unity_self, flags);
	}

	public static bool DoesNotHaveAnyFlagsAny_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAnyFlagsAny_InjectedDelegateField(_unity_self, flags);
	}

	public unsafe static bool DoesNotHaveAllFlagsNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAllFlagsNode_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), flags);
	}

	public unsafe static bool DoesNotHaveAnyFlagsNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags flags)
	{
		return DoesNotHaveAnyFlagsNode_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), flags);
	}

	public static void ClearFlagsAll_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		ClearFlagsAll_InjectedDelegateField(_unity_self, flags);
	}

	public unsafe static int ClearFlagsNodes_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper nodes, HierarchyNodeFlags flags)
	{
		return ClearFlagsNodes_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref nodes), flags);
	}

	public unsafe static int ClearFlagsIndices_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper indices, HierarchyNodeFlags flags)
	{
		return ClearFlagsIndices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref indices), flags);
	}

	public static void ToggleFlagsAll_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags)
	{
		ToggleFlagsAll_InjectedDelegateField(_unity_self, flags);
	}

	public unsafe static void ToggleFlagsNode_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags flags, bool recurse)
	{
		ToggleFlagsNode_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref node), flags, recurse);
	}

	public unsafe static int ToggleFlagsNodes_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper nodes, HierarchyNodeFlags flags)
	{
		return ToggleFlagsNodes_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref nodes), flags);
	}

	public unsafe static int ToggleFlagsIndices_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper indices, HierarchyNodeFlags flags)
	{
		return ToggleFlagsIndices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref indices), flags);
	}

	public unsafe static int GetNodesWithAllFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outNodes)
	{
		return GetNodesWithAllFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outNodes));
	}

	public unsafe static int GetNodesWithAnyFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outNodes)
	{
		return GetNodesWithAnyFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outNodes));
	}

	public unsafe static int GetIndicesWithAllFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outIndices)
	{
		return GetIndicesWithAllFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outIndices));
	}

	public unsafe static int GetIndicesWithAnyFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outIndices)
	{
		return GetIndicesWithAnyFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outIndices));
	}

	public unsafe static int GetNodesWithoutAllFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outNodes)
	{
		return GetNodesWithoutAllFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outNodes));
	}

	public unsafe static int GetNodesWithoutAnyFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outNodes)
	{
		return GetNodesWithoutAnyFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outNodes));
	}

	public unsafe static int GetIndicesWithoutAllFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outIndices)
	{
		return GetIndicesWithoutAllFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outIndices));
	}

	public unsafe static int GetIndicesWithoutAnyFlagsSpan_Injected(System.IntPtr _unity_self, HierarchyNodeFlags flags, ref ManagedSpanWrapper outIndices)
	{
		return GetIndicesWithoutAnyFlagsSpan_InjectedDelegateField(_unity_self, flags, (nint)Unsafe.AsPointer(ref outIndices));
	}
}
