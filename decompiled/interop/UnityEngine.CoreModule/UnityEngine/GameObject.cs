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
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public sealed class GameObject : Object
{
	private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddComponent_Public_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate void SetGameObjectsActiveDelegate(System.IntPtr instanceIds, int instanceCount, bool active);

	private delegate System.IntPtr CreatePrimitive_InjectedDelegate(PrimitiveType type);

	private delegate System.IntPtr GetComponentByNameWithCase_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr type, bool caseSensitive);

	private delegate void FindGameObjectsWithTagForListInternal_InjectedDelegate(System.IntPtr tag, System.IntPtr results);

	private delegate System.IntPtr AddComponentInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr className);

	private delegate int GetComponentCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr QueryComponentAtIndex_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate int GetComponentIndex_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr component);

	private delegate bool get_active_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_active_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void SetActiveRecursively_InjectedDelegate(System.IntPtr _unity_self, bool state);

	private delegate bool get_isStatic_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_isStatic_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_isStaticBatchable_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_tag_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void SendMessageUpwards_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr methodName, System.IntPtr value, SendMessageOptions options);

	private delegate void BroadcastMessage_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr methodName, System.IntPtr parameter, SendMessageOptions options);

	private delegate void InstantiateGameObjects_InjectedDelegate(int sourceInstanceID, System.IntPtr newInstanceIDs, System.IntPtr newTransformInstanceIDs, int count, [In] System.IntPtr destinationScene);

	private delegate void GetScene_InjectedDelegate(int instanceID, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentByName_Internal_Component_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindWithTag_Public_Static_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Component_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_layer_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTag_Internal_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scene_Public_get_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Injected_Private_Static_IntPtr_IntPtr_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentByName_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Injected_Private_Static_IntPtr_IntPtr_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParent_Injected_Private_Static_IntPtr_IntPtr_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInternal_Injected_Private_Static_Array_IntPtr_Type_Boolean_Boolean_Boolean_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponentInternal_Injected_Private_Static_IntPtr_IntPtr_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_AddComponentWithType_Injected_Private_Static_IntPtr_IntPtr_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_transform_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_layer_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_layer_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeSelf_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeInHierarchy_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_tag_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTag_Internal_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindGameObjectWithTag_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindGameObjectsWithTag_Injected_Private_Static_Il2CppReferenceArray_1_GameObject_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Object_SendMessageOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateGameObject_Injected_Private_Static_Void_GameObject_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Find_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scene_Injected_Private_Static_Void_IntPtr_byref_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sceneCullingMask_Injected_Private_Static_UInt64_IntPtr_0;

	private static readonly SetGameObjectsActiveDelegate SetGameObjectsActiveDelegateField;

	private static readonly CreatePrimitive_InjectedDelegate CreatePrimitive_InjectedDelegateField;

	private static readonly GetComponentByNameWithCase_InjectedDelegate GetComponentByNameWithCase_InjectedDelegateField;

	private static readonly FindGameObjectsWithTagForListInternal_InjectedDelegate FindGameObjectsWithTagForListInternal_InjectedDelegateField;

	private static readonly AddComponentInternal_InjectedDelegate AddComponentInternal_InjectedDelegateField;

	private static readonly GetComponentCount_InjectedDelegate GetComponentCount_InjectedDelegateField;

	private static readonly QueryComponentAtIndex_InjectedDelegate QueryComponentAtIndex_InjectedDelegateField;

	private static readonly GetComponentIndex_InjectedDelegate GetComponentIndex_InjectedDelegateField;

	private static readonly get_active_InjectedDelegate get_active_InjectedDelegateField;

	private static readonly set_active_InjectedDelegate set_active_InjectedDelegateField;

	private static readonly SetActiveRecursively_InjectedDelegate SetActiveRecursively_InjectedDelegateField;

	private static readonly get_isStatic_InjectedDelegate get_isStatic_InjectedDelegateField;

	private static readonly set_isStatic_InjectedDelegate set_isStatic_InjectedDelegateField;

	private static readonly get_isStaticBatchable_InjectedDelegate get_isStaticBatchable_InjectedDelegateField;

	private static readonly get_tag_InjectedDelegate get_tag_InjectedDelegateField;

	private static readonly SendMessageUpwards_InjectedDelegate SendMessageUpwards_InjectedDelegateField;

	private static readonly BroadcastMessage_InjectedDelegate BroadcastMessage_InjectedDelegateField;

	private static readonly InstantiateGameObjects_InjectedDelegate InstantiateGameObjects_InjectedDelegateField;

	private static readonly GetScene_InjectedDelegate GetScene_InjectedDelegateField;

	public unsafe Transform transform
	{
		[CallerCount(1001)]
		[CachedScanResults(RefRangeStart = 1198361, RefRangeEnd = 1199362, XrefRangeStart = 1198353, XrefRangeEnd = 1198361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
	}

	public unsafe int layer
	{
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1199367, RefRangeEnd = 1199424, XrefRangeStart = 1199362, XrefRangeEnd = 1199367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1199429, RefRangeEnd = 1199455, XrefRangeStart = 1199424, XrefRangeEnd = 1199429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool activeSelf
	{
		[CallerCount(328)]
		[CachedScanResults(RefRangeStart = 1202103, RefRangeEnd = 1202431, XrefRangeStart = 1202098, XrefRangeEnd = 1202103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool activeInHierarchy
	{
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 1202436, RefRangeEnd = 1202544, XrefRangeStart = 1202431, XrefRangeEnd = 1202436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string tag
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
				get_tag_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1202557, RefRangeEnd = 1202559, XrefRangeStart = 1202544, XrefRangeEnd = 1202557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Scene scene
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1202866, RefRangeEnd = 1202867, XrefRangeStart = 1202863, XrefRangeEnd = 1202866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scene_Public_get_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Scene*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ulong sceneCullingMask
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1202872, RefRangeEnd = 1202873, XrefRangeStart = 1202867, XrefRangeEnd = 1202872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe GameObject gameObject
	{
		[CallerCount(607)]
		[CachedScanResults(RefRangeStart = 761994, RefRangeEnd = 762601, XrefRangeStart = 761994, XrefRangeEnd = 762601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
	}

	public bool active
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_active_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_active_Injected(intPtr, value);
		}
	}

	public bool isStatic
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isStatic_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_isStatic_Injected(intPtr, value);
		}
	}

	public bool isStaticBatchable
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isStaticBatchable_Injected(intPtr);
		}
	}

	static GameObject()
	{
		Il2CppClassPointerStore<GameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GameObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObject>.NativeClassPtr);
		NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666309);
		NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666310);
		NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666311);
		NativeMethodInfoPtr_GetComponentByName_Internal_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666312);
		NativeMethodInfoPtr_GetComponent_Public_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666313);
		NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666314);
		NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666315);
		NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666316);
		NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666317);
		NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666318);
		NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666319);
		NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666320);
		NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666321);
		NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666322);
		NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666323);
		NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666324);
		NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666325);
		NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666326);
		NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666327);
		NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666328);
		NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666329);
		NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666330);
		NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666331);
		NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666332);
		NativeMethodInfoPtr_FindWithTag_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666333);
		NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666334);
		NativeMethodInfoPtr_AddComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666335);
		NativeMethodInfoPtr_AddComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666336);
		NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666337);
		NativeMethodInfoPtr_get_layer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666338);
		NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666339);
		NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666340);
		NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666343);
		NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666344);
		NativeMethodInfoPtr_CompareTag_Internal_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666346);
		NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666347);
		NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666348);
		NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666353);
		NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666354);
		NativeMethodInfoPtr_get_scene_Public_get_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666355);
		NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666356);
		NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666357);
		NativeMethodInfoPtr_GetComponent_Injected_Private_Static_IntPtr_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666358);
		NativeMethodInfoPtr_GetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666359);
		NativeMethodInfoPtr_GetComponentByName_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666360);
		NativeMethodInfoPtr_GetComponentInChildren_Injected_Private_Static_IntPtr_IntPtr_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666361);
		NativeMethodInfoPtr_GetComponentInParent_Injected_Private_Static_IntPtr_IntPtr_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666362);
		NativeMethodInfoPtr_GetComponentsInternal_Injected_Private_Static_Array_IntPtr_Type_Boolean_Boolean_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666363);
		NativeMethodInfoPtr_TryGetComponentInternal_Injected_Private_Static_IntPtr_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666364);
		NativeMethodInfoPtr_TryGetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666365);
		NativeMethodInfoPtr_Internal_AddComponentWithType_Injected_Private_Static_IntPtr_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666366);
		NativeMethodInfoPtr_get_transform_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666367);
		NativeMethodInfoPtr_get_layer_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666368);
		NativeMethodInfoPtr_set_layer_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666369);
		NativeMethodInfoPtr_SetActive_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666370);
		NativeMethodInfoPtr_get_activeSelf_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666371);
		NativeMethodInfoPtr_get_activeInHierarchy_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666372);
		NativeMethodInfoPtr_set_tag_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666373);
		NativeMethodInfoPtr_CompareTag_Internal_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666374);
		NativeMethodInfoPtr_FindGameObjectWithTag_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666375);
		NativeMethodInfoPtr_FindGameObjectsWithTag_Injected_Private_Static_Il2CppReferenceArray_1_GameObject_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666376);
		NativeMethodInfoPtr_SendMessage_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666377);
		NativeMethodInfoPtr_Internal_CreateGameObject_Injected_Private_Static_Void_GameObject_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666378);
		NativeMethodInfoPtr_Find_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666379);
		NativeMethodInfoPtr_get_scene_Injected_Private_Static_Void_IntPtr_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666380);
		NativeMethodInfoPtr_get_sceneCullingMask_Injected_Private_Static_UInt64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666381);
		SetGameObjectsActiveDelegateField = IL2CPP.ResolveICall<SetGameObjectsActiveDelegate>("UnityEngine.GameObject::SetGameObjectsActive");
		CreatePrimitive_InjectedDelegateField = IL2CPP.ResolveICall<CreatePrimitive_InjectedDelegate>("UnityEngine.GameObject::CreatePrimitive_Injected");
		GetComponentByNameWithCase_InjectedDelegateField = IL2CPP.ResolveICall<GetComponentByNameWithCase_InjectedDelegate>("UnityEngine.GameObject::GetComponentByNameWithCase_Injected");
		FindGameObjectsWithTagForListInternal_InjectedDelegateField = IL2CPP.ResolveICall<FindGameObjectsWithTagForListInternal_InjectedDelegate>("UnityEngine.GameObject::FindGameObjectsWithTagForListInternal_Injected");
		AddComponentInternal_InjectedDelegateField = IL2CPP.ResolveICall<AddComponentInternal_InjectedDelegate>("UnityEngine.GameObject::AddComponentInternal_Injected");
		GetComponentCount_InjectedDelegateField = IL2CPP.ResolveICall<GetComponentCount_InjectedDelegate>("UnityEngine.GameObject::GetComponentCount_Injected");
		QueryComponentAtIndex_InjectedDelegateField = IL2CPP.ResolveICall<QueryComponentAtIndex_InjectedDelegate>("UnityEngine.GameObject::QueryComponentAtIndex_Injected");
		GetComponentIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetComponentIndex_InjectedDelegate>("UnityEngine.GameObject::GetComponentIndex_Injected");
		get_active_InjectedDelegateField = IL2CPP.ResolveICall<get_active_InjectedDelegate>("UnityEngine.GameObject::get_active_Injected");
		set_active_InjectedDelegateField = IL2CPP.ResolveICall<set_active_InjectedDelegate>("UnityEngine.GameObject::set_active_Injected");
		SetActiveRecursively_InjectedDelegateField = IL2CPP.ResolveICall<SetActiveRecursively_InjectedDelegate>("UnityEngine.GameObject::SetActiveRecursively_Injected");
		get_isStatic_InjectedDelegateField = IL2CPP.ResolveICall<get_isStatic_InjectedDelegate>("UnityEngine.GameObject::get_isStatic_Injected");
		set_isStatic_InjectedDelegateField = IL2CPP.ResolveICall<set_isStatic_InjectedDelegate>("UnityEngine.GameObject::set_isStatic_Injected");
		get_isStaticBatchable_InjectedDelegateField = IL2CPP.ResolveICall<get_isStaticBatchable_InjectedDelegate>("UnityEngine.GameObject::get_isStaticBatchable_Injected");
		get_tag_InjectedDelegateField = IL2CPP.ResolveICall<get_tag_InjectedDelegate>("UnityEngine.GameObject::get_tag_Injected");
		SendMessageUpwards_InjectedDelegateField = IL2CPP.ResolveICall<SendMessageUpwards_InjectedDelegate>("UnityEngine.GameObject::SendMessageUpwards_Injected");
		BroadcastMessage_InjectedDelegateField = IL2CPP.ResolveICall<BroadcastMessage_InjectedDelegate>("UnityEngine.GameObject::BroadcastMessage_Injected");
		InstantiateGameObjects_InjectedDelegateField = IL2CPP.ResolveICall<InstantiateGameObjects_InjectedDelegate>("UnityEngine.GameObject::InstantiateGameObjects_Injected");
		GetScene_InjectedDelegateField = IL2CPP.ResolveICall<GetScene_InjectedDelegate>("UnityEngine.GameObject::GetScene_Injected");
	}

	[CallerCount(1264)]
	[CachedScanResults(RefRangeStart = 1196222, RefRangeEnd = 1197486, XrefRangeStart = 1196217, XrefRangeEnd = 1196222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetComponent<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1197494, RefRangeEnd = 1197495, XrefRangeStart = 1197486, XrefRangeEnd = 1197494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component GetComponent(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1197500, RefRangeEnd = 1197502, XrefRangeStart = 1197495, XrefRangeEnd = 1197500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetComponentFastPath(Il2CppSystem.Type type, System.IntPtr oneFurtherThanResultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oneFurtherThanResultValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1197519, RefRangeEnd = 1197520, XrefRangeStart = 1197502, XrefRangeEnd = 1197519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component GetComponentByName(string type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentByName_Internal_Component_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1197521, RefRangeEnd = 1197522, XrefRangeStart = 1197520, XrefRangeEnd = 1197521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component GetComponent(string type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponent_Public_Component_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1197530, RefRangeEnd = 1197534, XrefRangeStart = 1197522, XrefRangeEnd = 1197530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component GetComponentInChildren(Il2CppSystem.Type type, bool includeInactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(59)]
	[CachedScanResults(RefRangeStart = 1197541, RefRangeEnd = 1197600, XrefRangeStart = 1197534, XrefRangeEnd = 1197541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetComponentInChildren<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1197606, RefRangeEnd = 1197611, XrefRangeStart = 1197600, XrefRangeEnd = 1197606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetComponentInChildren<T>(bool includeInactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeInactive);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1197619, RefRangeEnd = 1197622, XrefRangeStart = 1197611, XrefRangeEnd = 1197619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component GetComponentInParent(Il2CppSystem.Type type, bool includeInactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1197629, RefRangeEnd = 1197637, XrefRangeStart = 1197622, XrefRangeEnd = 1197629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetComponentInParent<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1197643, RefRangeEnd = 1197654, XrefRangeStart = 1197637, XrefRangeEnd = 1197643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetComponentInParent<T>(bool includeInactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeInactive);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1197659, RefRangeEnd = 1197665, XrefRangeStart = 1197654, XrefRangeEnd = 1197659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Array GetComponentsInternal(Il2CppSystem.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, Il2CppSystem.Object resultList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useSearchTypeAsArrayReturnType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &reverse;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Array>(intPtr2) : null;
	}

	[CallerCount(50)]
	[CachedScanResults(RefRangeStart = 1197672, RefRangeEnd = 1197722, XrefRangeStart = 1197665, XrefRangeEnd = 1197672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppArrayBase<T> GetComponents<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1197727, RefRangeEnd = 1197729, XrefRangeStart = 1197722, XrefRangeEnd = 1197727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetComponents<T>(List<T> results)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1197735, RefRangeEnd = 1197737, XrefRangeStart = 1197729, XrefRangeEnd = 1197735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Component> GetComponentsInChildren(Il2CppSystem.Type type, bool includeInactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr2) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1197744, RefRangeEnd = 1197760, XrefRangeStart = 1197737, XrefRangeEnd = 1197744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeInactive);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1197765, RefRangeEnd = 1197769, XrefRangeStart = 1197760, XrefRangeEnd = 1197765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&includeInactive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 1197771, RefRangeEnd = 1197807, XrefRangeStart = 1197769, XrefRangeEnd = 1197771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1197812, RefRangeEnd = 1197821, XrefRangeStart = 1197807, XrefRangeEnd = 1197812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetComponentsInParent<T>(bool includeInactive, List<T> results)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&includeInactive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1197828, RefRangeEnd = 1197830, XrefRangeStart = 1197821, XrefRangeEnd = 1197828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeInactive);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1197836, RefRangeEnd = 1197857, XrefRangeStart = 1197830, XrefRangeEnd = 1197836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetComponent<T>(out T component)
	{
		//IL_002d->IL002f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		Unsafe.SkipInit(out nint num);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num = 0;
			reference = ref *(_003F*)(&num);
		}
		else
		{
			reference = ref component;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(T).IsValueType)
		{
			nint num2 = num;
			Unsafe.As<T, object>(ref component) = ((num2 == 0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num2, false, false));
		}
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1197873, RefRangeEnd = 1197874, XrefRangeStart = 1197857, XrefRangeEnd = 1197873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetComponent(Il2CppSystem.Type type, out Component component)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		component = ((num3 == 0) ? null : new Component(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197874, XrefRangeEnd = 1197882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component TryGetComponentInternal(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1197887, RefRangeEnd = 1197888, XrefRangeStart = 1197882, XrefRangeEnd = 1197887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryGetComponentFastPath(Il2CppSystem.Type type, System.IntPtr oneFurtherThanResultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oneFurtherThanResultValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1197889, RefRangeEnd = 1197891, XrefRangeStart = 1197888, XrefRangeEnd = 1197889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindWithTag(string tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindWithTag_Public_Static_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1197899, RefRangeEnd = 1197901, XrefRangeStart = 1197891, XrefRangeEnd = 1197899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component Internal_AddComponentWithType(Il2CppSystem.Type componentType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)componentType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1197899, RefRangeEnd = 1197901, XrefRangeStart = 1197899, XrefRangeEnd = 1197901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Component AddComponent(Il2CppSystem.Type componentType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)componentType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(432)]
	[CachedScanResults(RefRangeStart = 1197921, RefRangeEnd = 1198353, XrefRangeStart = 1197901, XrefRangeEnd = 1197921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T AddComponent<T>() where T : Component
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(2638)]
	[CachedScanResults(RefRangeStart = 1199460, RefRangeEnd = 1202098, XrefRangeStart = 1199455, XrefRangeEnd = 1199460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActive(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1202560, RefRangeEnd = 1202561, XrefRangeStart = 1202559, XrefRangeEnd = 1202560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareTag(string tag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1202574, RefRangeEnd = 1202575, XrefRangeStart = 1202561, XrefRangeEnd = 1202574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareTag_Internal(string tag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTag_Internal_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1202591, RefRangeEnd = 1202592, XrefRangeStart = 1202575, XrefRangeEnd = 1202591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindGameObjectWithTag(string tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1202604, RefRangeEnd = 1202607, XrefRangeStart = 1202592, XrefRangeEnd = 1202604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<GameObject> FindGameObjectsWithTag(string tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1202620, RefRangeEnd = 1202628, XrefRangeStart = 1202607, XrefRangeEnd = 1202620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendMessage(string methodName, Il2CppSystem.Object value, SendMessageOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(SendMessageOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1202629, RefRangeEnd = 1202630, XrefRangeStart = 1202628, XrefRangeEnd = 1202629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendMessage(string methodName, Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(118)]
	[CachedScanResults(RefRangeStart = 1202635, RefRangeEnd = 1202753, XrefRangeStart = 1202630, XrefRangeEnd = 1202635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1202758, RefRangeEnd = 1202765, XrefRangeStart = 1202753, XrefRangeEnd = 1202758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 1202777, RefRangeEnd = 1202822, XrefRangeStart = 1202765, XrefRangeEnd = 1202777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject(string name, [Optional] Il2CppReferenceArray<Il2CppSystem.Type> components)
	{
		if (components == null)
		{
			components = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)components);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1202834, RefRangeEnd = 1202837, XrefRangeStart = 1202822, XrefRangeEnd = 1202834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CreateGameObject(GameObject self, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1202853, RefRangeEnd = 1202863, XrefRangeStart = 1202837, XrefRangeEnd = 1202853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject Find(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202873, XrefRangeEnd = 1202875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetComponent_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponent_Injected_Private_Static_IntPtr_IntPtr_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202875, XrefRangeEnd = 1202877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetComponentFastPath_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type, System.IntPtr oneFurtherThanResultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oneFurtherThanResultValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202877, XrefRangeEnd = 1202879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetComponentByName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentByName_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202879, XrefRangeEnd = 1202881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetComponentInChildren_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type, bool includeInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentInChildren_Injected_Private_Static_IntPtr_IntPtr_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202881, XrefRangeEnd = 1202883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetComponentInParent_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type, bool includeInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentInParent_Injected_Private_Static_IntPtr_IntPtr_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202883, XrefRangeEnd = 1202885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Array GetComponentsInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, Il2CppSystem.Object resultList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useSearchTypeAsArrayReturnType;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &reverse;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentsInternal_Injected_Private_Static_Array_IntPtr_Type_Boolean_Boolean_Boolean_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Array>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202885, XrefRangeEnd = 1202887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr TryGetComponentInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetComponentInternal_Injected_Private_Static_IntPtr_IntPtr_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202887, XrefRangeEnd = 1202889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TryGetComponentFastPath_Injected(System.IntPtr _unity_self, Il2CppSystem.Type type, System.IntPtr oneFurtherThanResultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oneFurtherThanResultValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202889, XrefRangeEnd = 1202891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_AddComponentWithType_Injected(System.IntPtr _unity_self, Il2CppSystem.Type componentType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)componentType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_AddComponentWithType_Injected_Private_Static_IntPtr_IntPtr_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202891, XrefRangeEnd = 1202893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_transform_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transform_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202893, XrefRangeEnd = 1202895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_layer_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layer_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202895, XrefRangeEnd = 1202897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_layer_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_layer_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202897, XrefRangeEnd = 1202899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActive_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202899, XrefRangeEnd = 1202901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_activeSelf_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeSelf_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202901, XrefRangeEnd = 1202903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_activeInHierarchy_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeInHierarchy_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202903, XrefRangeEnd = 1202905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_tag_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_tag_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202905, XrefRangeEnd = 1202907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareTag_Internal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTag_Internal_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202907, XrefRangeEnd = 1202909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FindGameObjectWithTag_Injected(ref ManagedSpanWrapper tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindGameObjectWithTag_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202909, XrefRangeEnd = 1202911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<GameObject> FindGameObjectsWithTag_Injected(ref ManagedSpanWrapper tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindGameObjectsWithTag_Injected_Private_Static_Il2CppReferenceArray_1_GameObject_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202911, XrefRangeEnd = 1202913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMessage_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper methodName, Il2CppSystem.Object value, SendMessageOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(SendMessageOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessage_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Object_SendMessageOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202913, XrefRangeEnd = 1202915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CreateGameObject_Injected(GameObject self, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateGameObject_Injected_Private_Static_Void_GameObject_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202915, XrefRangeEnd = 1202917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Find_Injected(ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Find_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202917, XrefRangeEnd = 1202919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_scene_Injected(System.IntPtr _unity_self, out Scene ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scene_Injected_Private_Static_Void_IntPtr_byref_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202919, XrefRangeEnd = 1202921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong get_sceneCullingMask_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sceneCullingMask_Injected_Private_Static_UInt64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GameObject(string name, params Il2CppSystem.Type[] components)
		: this(name, new Il2CppReferenceArray<Il2CppSystem.Type>(components))
	{
	}

	public GameObject(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static GameObject CreatePrimitive(PrimitiveType type)
	{
		return Unmarshal.UnmarshalUnityObject<GameObject>(CreatePrimitive_Injected(type));
	}

	public unsafe Component GetComponentByNameWithCase(string type, bool caseSensitive)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr componentByNameWithCase_Injected);
		Component result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(type, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(type);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					componentByNameWithCase_Injected = GetComponentByNameWithCase_Injected(intPtr, ref managedSpanWrapper, caseSensitive);
				}
			}
			else
			{
				componentByNameWithCase_Injected = GetComponentByNameWithCase_Injected(intPtr, ref managedSpanWrapper, caseSensitive);
			}
		}
		finally
		{
			result = Unmarshal.UnmarshalUnityObject<Component>(componentByNameWithCase_Injected);
		}
		return result;
	}

	public Component GetComponentInChildren(Il2CppSystem.Type type)
	{
		return GetComponentInChildren(type, includeInactive: false);
	}

	public Component GetComponentInParent(Il2CppSystem.Type type)
	{
		return GetComponentInParent(type, includeInactive: false);
	}

	public Il2CppReferenceArray<Component> GetComponents(Il2CppSystem.Type type)
	{
		return ((Il2CppObjectBase)GetComponentsInternal(type, useSearchTypeAsArrayReturnType: false, recursive: false, includeInactive: true, reverse: false, null)).Cast<Il2CppReferenceArray<Component>>();
	}

	public void GetComponents(Il2CppSystem.Type type, List<Component> results)
	{
		GetComponentsInternal(type, useSearchTypeAsArrayReturnType: false, recursive: false, includeInactive: true, reverse: false, results);
	}

	public Il2CppReferenceArray<Component> GetComponentsInChildren(Il2CppSystem.Type type)
	{
		bool includeInactive = false;
		return GetComponentsInChildren(type, includeInactive);
	}

	public void GetComponentsInChildren<T>(List<T> results)
	{
		GetComponentsInChildren(includeInactive: false, results);
	}

	public Il2CppReferenceArray<Component> GetComponentsInParent(Il2CppSystem.Type type)
	{
		bool includeInactive = false;
		return GetComponentsInParent(type, includeInactive);
	}

	public Il2CppReferenceArray<Component> GetComponentsInParent(Il2CppSystem.Type type, bool includeInactive)
	{
		return ((Il2CppObjectBase)GetComponentsInternal(type, useSearchTypeAsArrayReturnType: false, recursive: true, includeInactive, reverse: true, null)).Cast<Il2CppReferenceArray<Component>>();
	}

	public Il2CppArrayBase<T> GetComponentsInParent<T>()
	{
		return GetComponentsInParent<T>(includeInactive: false);
	}

	public unsafe static void FindGameObjectsWithTagForListInternal(string tag, Il2CppSystem.Object results)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(tag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(tag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					FindGameObjectsWithTagForListInternal_Injected(ref managedSpanWrapper, results);
					return;
				}
			}
			FindGameObjectsWithTagForListInternal_Injected(ref managedSpanWrapper, results);
		}
		finally
		{
		}
	}

	public static void FindGameObjectsWithTag(string tag, List<GameObject> results)
	{
		FindGameObjectsWithTagForListInternal(tag, results);
	}

	public void SendMessageUpwards(string methodName, SendMessageOptions options)
	{
		SendMessageUpwards(methodName, null, options);
	}

	public void SendMessage(string methodName, SendMessageOptions options)
	{
		SendMessage(methodName, null, options);
	}

	public void BroadcastMessage(string methodName, SendMessageOptions options)
	{
		BroadcastMessage(methodName, null, options);
	}

	public unsafe Component AddComponentInternal(string className)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr gcHandlePtr);
		Component result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(className, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(className);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					gcHandlePtr = AddComponentInternal_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			else
			{
				gcHandlePtr = AddComponentInternal_Injected(intPtr, ref managedSpanWrapper);
			}
		}
		finally
		{
			result = Unmarshal.UnmarshalUnityObject<Component>(gcHandlePtr);
		}
		return result;
	}

	public int GetComponentCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetComponentCount_Injected(intPtr);
	}

	public Component QueryComponentAtIndex(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Component>(QueryComponentAtIndex_Injected(intPtr, index));
	}

	public Component GetComponentAtIndex(int index)
	{
		if (index < 0 || index >= GetComponentCount())
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", "Valid range is 0 to GetComponentCount() - 1.");
		}
		return QueryComponentAtIndex(index);
	}

	public T GetComponentAtIndex<T>(int index) where T : Component
	{
		T val = ((Il2CppObjectBase)GetComponentAtIndex(index)).Cast<T>();
		if (val == null)
		{
			throw new Il2CppSystem.InvalidCastException();
		}
		return val;
	}

	public int GetComponentIndex(Component component)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetComponentIndex_Injected(intPtr, MarshalledUnityObject.Marshal(component));
	}

	public void SetActiveRecursively(bool state)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetActiveRecursively_Injected(intPtr, state);
	}

	public unsafe void SendMessageUpwards(string methodName, Il2CppSystem.Object value, SendMessageOptions options)
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
			if (!StringMarshaller.TryMarshalEmptyOrNullString(methodName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(methodName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SendMessageUpwards_Injected(intPtr, ref managedSpanWrapper, value, options);
					return;
				}
			}
			SendMessageUpwards_Injected(intPtr, ref managedSpanWrapper, value, options);
		}
		finally
		{
		}
	}

	public void SendMessageUpwards(string methodName, Il2CppSystem.Object value)
	{
		SendMessageOptions options = SendMessageOptions.RequireReceiver;
		SendMessageUpwards(methodName, value, options);
	}

	public void SendMessageUpwards(string methodName)
	{
		SendMessageOptions options = SendMessageOptions.RequireReceiver;
		Il2CppSystem.Object value = null;
		SendMessageUpwards(methodName, value, options);
	}

	public void SendMessage(string methodName)
	{
		SendMessageOptions options = SendMessageOptions.RequireReceiver;
		Il2CppSystem.Object value = null;
		SendMessage(methodName, value, options);
	}

	public unsafe void BroadcastMessage(string methodName, Il2CppSystem.Object parameter, SendMessageOptions options)
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
			if (!StringMarshaller.TryMarshalEmptyOrNullString(methodName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(methodName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					BroadcastMessage_Injected(intPtr, ref managedSpanWrapper, parameter, options);
					return;
				}
			}
			BroadcastMessage_Injected(intPtr, ref managedSpanWrapper, parameter, options);
		}
		finally
		{
		}
	}

	public void BroadcastMessage(string methodName, Il2CppSystem.Object parameter)
	{
		SendMessageOptions options = SendMessageOptions.RequireReceiver;
		BroadcastMessage(methodName, parameter, options);
	}

	public void BroadcastMessage(string methodName)
	{
		SendMessageOptions options = SendMessageOptions.RequireReceiver;
		Il2CppSystem.Object parameter = null;
		BroadcastMessage(methodName, parameter, options);
	}

	public static void SetGameObjectsActive(System.IntPtr instanceIds, int instanceCount, bool active)
	{
		SetGameObjectsActiveDelegateField(instanceIds, instanceCount, active);
	}

	public unsafe static void SetGameObjectsActive(NativeArray<int> instanceIDs, bool active)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//IL_0041: Expected O, but got Ref
		if (!((NativeArray<int>)(&instanceIDs)).IsCreated)
		{
			throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", "instanceIDs");
		}
		if (((NativeArray<int>)(&instanceIDs)).Length != 0)
		{
			SetGameObjectsActive((System.IntPtr)instanceIDs.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&instanceIDs)).Length, active);
		}
	}

	public unsafe static void SetGameObjectsActive(Il2CppSystem.ReadOnlySpan<int> instanceIDs, bool active)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<int>)(&instanceIDs)).Length != 0)
		{
			fixed (int* ptr = &((Il2CppSystem.ReadOnlySpan<int>)(&instanceIDs)).GetPinnableReference())
			{
				SetGameObjectsActive((System.IntPtr)(void*)ptr, ((Il2CppSystem.ReadOnlySpan<int>)(&instanceIDs)).Length, active);
			}
		}
	}

	public static void InstantiateGameObjects(int sourceInstanceID, System.IntPtr newInstanceIDs, System.IntPtr newTransformInstanceIDs, int count, Scene destinationScene)
	{
		InstantiateGameObjects_Injected(sourceInstanceID, newInstanceIDs, newTransformInstanceIDs, count, ref destinationScene);
	}

	public unsafe static void InstantiateGameObjects(int sourceInstanceID, int count, NativeArray<int> newInstanceIDs, NativeArray<int> newTransformInstanceIDs, [Optional] Scene destinationScene)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//IL_004f: Expected O, but got Ref
		//IL_0059: Expected O, but got Ref
		//IL_008e: Expected O, but got Ref
		if (!((NativeArray<int>)(&newInstanceIDs)).IsCreated)
		{
			throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", "newInstanceIDs");
		}
		if (!((NativeArray<int>)(&newTransformInstanceIDs)).IsCreated)
		{
			throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", "newTransformInstanceIDs");
		}
		if (count != 0)
		{
			if (count != ((NativeArray<int>)(&newInstanceIDs)).Length || count != ((NativeArray<int>)(&newTransformInstanceIDs)).Length)
			{
				throw new Il2CppSystem.ArgumentException("Size mismatch! Both arrays must already be the size of count.");
			}
			InstantiateGameObjects(sourceInstanceID, (System.IntPtr)newInstanceIDs.GetUnsafeReadOnlyPtr(), (System.IntPtr)newTransformInstanceIDs.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&newInstanceIDs)).Length, destinationScene);
		}
	}

	public static Scene GetScene(int instanceID)
	{
		GetScene_Injected(instanceID, out var ret);
		return ret;
	}

	public static System.IntPtr CreatePrimitive_Injected(PrimitiveType type)
	{
		return CreatePrimitive_InjectedDelegateField(type);
	}

	public unsafe static System.IntPtr GetComponentByNameWithCase_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper type, bool caseSensitive)
	{
		return GetComponentByNameWithCase_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref type), caseSensitive);
	}

	public unsafe static void FindGameObjectsWithTagForListInternal_Injected(ref ManagedSpanWrapper tag, Il2CppSystem.Object results)
	{
		FindGameObjectsWithTagForListInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref tag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static System.IntPtr AddComponentInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper className)
	{
		return AddComponentInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref className));
	}

	public static int GetComponentCount_Injected(System.IntPtr _unity_self)
	{
		return GetComponentCount_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr QueryComponentAtIndex_Injected(System.IntPtr _unity_self, int index)
	{
		return QueryComponentAtIndex_InjectedDelegateField(_unity_self, index);
	}

	public static int GetComponentIndex_Injected(System.IntPtr _unity_self, System.IntPtr component)
	{
		return GetComponentIndex_InjectedDelegateField(_unity_self, component);
	}

	public static bool get_active_Injected(System.IntPtr _unity_self)
	{
		return get_active_InjectedDelegateField(_unity_self);
	}

	public static void set_active_Injected(System.IntPtr _unity_self, bool value)
	{
		set_active_InjectedDelegateField(_unity_self, value);
	}

	public static void SetActiveRecursively_Injected(System.IntPtr _unity_self, bool state)
	{
		SetActiveRecursively_InjectedDelegateField(_unity_self, state);
	}

	public static bool get_isStatic_Injected(System.IntPtr _unity_self)
	{
		return get_isStatic_InjectedDelegateField(_unity_self);
	}

	public static void set_isStatic_Injected(System.IntPtr _unity_self, bool value)
	{
		set_isStatic_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isStaticBatchable_Injected(System.IntPtr _unity_self)
	{
		return get_isStaticBatchable_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_tag_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_tag_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SendMessageUpwards_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper methodName, Il2CppSystem.Object value, SendMessageOptions options)
	{
		SendMessageUpwards_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref methodName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value), options);
	}

	public unsafe static void BroadcastMessage_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper methodName, Il2CppSystem.Object parameter, SendMessageOptions options)
	{
		BroadcastMessage_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref methodName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameter), options);
	}

	public unsafe static void InstantiateGameObjects_Injected(int sourceInstanceID, System.IntPtr newInstanceIDs, System.IntPtr newTransformInstanceIDs, int count, [In] ref Scene destinationScene)
	{
		InstantiateGameObjects_InjectedDelegateField(sourceInstanceID, newInstanceIDs, newTransformInstanceIDs, count, (nint)Unsafe.AsPointer(ref destinationScene));
	}

	public unsafe static void GetScene_Injected(int instanceID, out Scene ret)
	{
		GetScene_InjectedDelegateField(instanceID, (nint)Unsafe.AsPointer(ref ret));
	}
}
