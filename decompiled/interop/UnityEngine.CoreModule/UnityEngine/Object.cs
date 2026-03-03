using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public class Object : Il2CppSystem.Object
{
	public static class MarshalledUnityObject : Il2CppSystem.Object
	{
		private sealed class MethodInfoStoreGeneric_Marshal_Public_Static_IntPtr_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Marshal_Public_Static_IntPtr_T_0, Il2CppClassPointerStore<MarshalledUnityObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private sealed class MethodInfoStoreGeneric_MarshalNotNull_Public_Static_IntPtr_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MarshalNotNull_Public_Static_IntPtr_T_0, Il2CppClassPointerStore<MarshalledUnityObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Marshal_Public_Static_IntPtr_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MarshalNotNull_Public_Static_IntPtr_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryThrowEditorNullExceptionObject_Public_Static_Void_Object_String_0;

		static MarshalledUnityObject()
		{
			Il2CppClassPointerStore<MarshalledUnityObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Object>.NativeClassPtr, "MarshalledUnityObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalledUnityObject>.NativeClassPtr);
			NativeMethodInfoPtr_Marshal_Public_Static_IntPtr_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalledUnityObject>.NativeClassPtr, 100666563);
			NativeMethodInfoPtr_MarshalNotNull_Public_Static_IntPtr_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalledUnityObject>.NativeClassPtr, 100666564);
			NativeMethodInfoPtr_TryThrowEditorNullExceptionObject_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalledUnityObject>.NativeClassPtr, 100666565);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204418, XrefRangeEnd = 1204419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr Marshal<T>(T obj) where T : Object
		{
			//IL_0045->IL0048: Incompatible stack types: I vs Ref
			//IL_0038->IL0048: Incompatible stack types: I vs Ref
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = obj;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref obj;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Marshal_Public_Static_IntPtr_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr MarshalNotNull<T>(T obj) where T : Object
		{
			//IL_0045->IL0048: Incompatible stack types: I vs Ref
			//IL_0038->IL0048: Incompatible stack types: I vs Ref
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = obj;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref obj;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MarshalNotNull_Public_Static_IntPtr_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryThrowEditorNullExceptionObject(Object unityObj, string paramterName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityObj);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(paramterName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryThrowEditorNullExceptionObject_Public_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MarshalledUnityObject(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindAnyObjectByType_Public_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate System.IntPtr FindObjectsOfTypeDelegate(System.IntPtr type, bool includeInactive);

	private delegate System.IntPtr FindObjectsOfTypeIncludingAssetsDelegate(System.IntPtr type);

	private delegate bool CurrentThreadIsMainThreadDelegate();

	private delegate bool DoesObjectWithInstanceIDExistDelegate(int instanceID);

	private delegate System.IntPtr GetPtrFromInstanceIDDelegate(int instanceID, System.IntPtr objectType, [Out] System.IntPtr isMonoBehaviour);

	private delegate System.IntPtr Internal_CloneSingleWithScene_InjectedDelegate(System.IntPtr data, [In] System.IntPtr scene);

	private delegate System.IntPtr Internal_InstantiateSingle_InjectedDelegate(System.IntPtr data, [In] System.IntPtr pos, [In] System.IntPtr rot);

	private delegate System.IntPtr Internal_InstantiateSingleWithParent_InjectedDelegate(System.IntPtr data, System.IntPtr parent, [In] System.IntPtr pos, [In] System.IntPtr rot);

	private delegate void MarkDirty_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_kInstanceID_None;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectIsNullMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloneDestroyedMessage;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsInactive_FindObjectsSortMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_FindObjectsInactive_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_FindObjectsInactive_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Private_Static_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPersistent_Internal_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyImmediate_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DontDestroyOnLoad_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hideFlags_Injected_Private_Static_HideFlags_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hideFlags_Injected_Private_Static_Void_IntPtr_HideFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CloneSingle_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParent_Injected_Private_Static_IntPtr_IntPtr_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPersistent_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectFromInstanceID_Injected_Private_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceLoadFromInstanceID_Injected_Private_Static_IntPtr_Int32_0;

	private static readonly FindObjectsOfTypeDelegate FindObjectsOfTypeDelegateField;

	private static readonly FindObjectsOfTypeIncludingAssetsDelegate FindObjectsOfTypeIncludingAssetsDelegateField;

	private static readonly CurrentThreadIsMainThreadDelegate CurrentThreadIsMainThreadDelegateField;

	private static readonly DoesObjectWithInstanceIDExistDelegate DoesObjectWithInstanceIDExistDelegateField;

	private static readonly GetPtrFromInstanceIDDelegate GetPtrFromInstanceIDDelegateField;

	private static readonly Internal_CloneSingleWithScene_InjectedDelegate Internal_CloneSingleWithScene_InjectedDelegateField;

	private static readonly Internal_InstantiateSingle_InjectedDelegate Internal_InstantiateSingle_InjectedDelegateField;

	private static readonly Internal_InstantiateSingleWithParent_InjectedDelegate Internal_InstantiateSingleWithParent_InjectedDelegateField;

	private static readonly MarkDirty_InjectedDelegate MarkDirty_InjectedDelegateField;

	public unsafe static int kInstanceID_None
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kInstanceID_None, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kInstanceID_None, (void*)(&value));
		}
	}

	public unsafe System.IntPtr m_CachedPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedPtr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedPtr)) = value;
		}
	}

	public unsafe static int OffsetOfInstanceIDInCPlusPlusObject
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&value));
		}
	}

	public unsafe static string objectIsNullMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_objectIsNullMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_objectIsNullMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string cloneDestroyedMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloneDestroyedMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloneDestroyedMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string name
	{
		[CallerCount(379)]
		[CachedScanResults(RefRangeStart = 1206462, RefRangeEnd = 1206841, XrefRangeStart = 1206461, XrefRangeEnd = 1206462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 1206842, RefRangeEnd = 1206968, XrefRangeStart = 1206841, XrefRangeEnd = 1206842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe HideFlags hideFlags
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1208094, RefRangeEnd = 1208105, XrefRangeStart = 1208086, XrefRangeEnd = 1208094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HideFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 1208113, RefRangeEnd = 1208171, XrefRangeStart = 1208105, XrefRangeEnd = 1208113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Object()
	{
		Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Object");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
		NativeFieldInfoPtr_kInstanceID_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "kInstanceID_None");
		NativeFieldInfoPtr_m_CachedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "m_CachedPtr");
		NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "OffsetOfInstanceIDInCPlusPlusObject");
		NativeFieldInfoPtr_objectIsNullMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "objectIsNullMessage");
		NativeFieldInfoPtr_cloneDestroyedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "cloneDestroyedMessage");
		NativeMethodInfoPtr_GetInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666506);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666507);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666508);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666509);
		NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666510);
		NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666511);
		NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666512);
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666513);
		NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666514);
		NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666515);
		NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666516);
		NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666517);
		NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666518);
		NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666519);
		NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666520);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666521);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666522);
		NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666523);
		NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666524);
		NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsInactive_FindObjectsSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666525);
		NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666526);
		NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666527);
		NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666528);
		NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666529);
		NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666530);
		NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666531);
		NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666532);
		NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666533);
		NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_FindObjectsInactive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666534);
		NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_FindObjectsInactive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666535);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666536);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666537);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666538);
		NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666539);
		NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666540);
		NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666541);
		NativeMethodInfoPtr_ToString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666542);
		NativeMethodInfoPtr_GetName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666543);
		NativeMethodInfoPtr_IsPersistent_Internal_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666544);
		NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666545);
		NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666546);
		NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666547);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666548);
		NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666550);
		NativeMethodInfoPtr_DestroyImmediate_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666551);
		NativeMethodInfoPtr_DontDestroyOnLoad_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666552);
		NativeMethodInfoPtr_get_hideFlags_Injected_Private_Static_HideFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666553);
		NativeMethodInfoPtr_set_hideFlags_Injected_Private_Static_Void_IntPtr_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666554);
		NativeMethodInfoPtr_Internal_CloneSingle_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666555);
		NativeMethodInfoPtr_Internal_CloneSingleWithParent_Injected_Private_Static_IntPtr_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666556);
		NativeMethodInfoPtr_ToString_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666557);
		NativeMethodInfoPtr_GetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666558);
		NativeMethodInfoPtr_IsPersistent_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666559);
		NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666560);
		NativeMethodInfoPtr_FindObjectFromInstanceID_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666561);
		NativeMethodInfoPtr_ForceLoadFromInstanceID_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666562);
		FindObjectsOfTypeDelegateField = IL2CPP.ResolveICall<FindObjectsOfTypeDelegate>("UnityEngine.Object::FindObjectsOfType");
		FindObjectsOfTypeIncludingAssetsDelegateField = IL2CPP.ResolveICall<FindObjectsOfTypeIncludingAssetsDelegate>("UnityEngine.Object::FindObjectsOfTypeIncludingAssets");
		CurrentThreadIsMainThreadDelegateField = IL2CPP.ResolveICall<CurrentThreadIsMainThreadDelegate>("UnityEngine.Object::CurrentThreadIsMainThread");
		DoesObjectWithInstanceIDExistDelegateField = IL2CPP.ResolveICall<DoesObjectWithInstanceIDExistDelegate>("UnityEngine.Object::DoesObjectWithInstanceIDExist");
		GetPtrFromInstanceIDDelegateField = IL2CPP.ResolveICall<GetPtrFromInstanceIDDelegate>("UnityEngine.Object::GetPtrFromInstanceID");
		Internal_CloneSingleWithScene_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CloneSingleWithScene_InjectedDelegate>("UnityEngine.Object::Internal_CloneSingleWithScene_Injected");
		Internal_InstantiateSingle_InjectedDelegateField = IL2CPP.ResolveICall<Internal_InstantiateSingle_InjectedDelegate>("UnityEngine.Object::Internal_InstantiateSingle_Injected");
		Internal_InstantiateSingleWithParent_InjectedDelegateField = IL2CPP.ResolveICall<Internal_InstantiateSingleWithParent_InjectedDelegate>("UnityEngine.Object::Internal_InstantiateSingleWithParent_Injected");
		MarkDirty_InjectedDelegateField = IL2CPP.ResolveICall<MarkDirty_InjectedDelegate>("UnityEngine.Object::MarkDirty_Injected");
	}

	[CallerCount(252)]
	[CachedScanResults(RefRangeStart = 1204424, RefRangeEnd = 1204676, XrefRangeStart = 1204419, XrefRangeEnd = 1204424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204676, XrefRangeEnd = 1204677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204677, XrefRangeEnd = 1204689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1765)]
	[CachedScanResults(RefRangeStart = 1204695, RefRangeEnd = 1206460, XrefRangeStart = 1204689, XrefRangeEnd = 1204695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator bool(Object exists)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exists);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206460, XrefRangeEnd = 1206461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareBaseObjects(Object lhs, Object rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsNativeObjectAlive(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(200)]
	[CachedScanResults(RefRangeStart = 1156232, RefRangeEnd = 1156432, XrefRangeStart = 1156232, XrefRangeEnd = 1156432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetCachedPtr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1206989, RefRangeEnd = 1207000, XrefRangeStart = 1206968, XrefRangeEnd = 1206989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Instantiate(Object original)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)original);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1207004, RefRangeEnd = 1207025, XrefRangeStart = 1207000, XrefRangeEnd = 1207004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Instantiate(Object original, Transform parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)original);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1207060, RefRangeEnd = 1207072, XrefRangeStart = 1207025, XrefRangeEnd = 1207060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)original);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &instantiateInWorldSpace;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(61)]
	[CachedScanResults(RefRangeStart = 1207084, RefRangeEnd = 1207145, XrefRangeStart = 1207072, XrefRangeEnd = 1207084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Instantiate<T>(T original) where T : Object
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = original;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref original;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(209)]
	[CachedScanResults(RefRangeStart = 1207155, RefRangeEnd = 1207364, XrefRangeStart = 1207145, XrefRangeEnd = 1207155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Instantiate<T>(T original, Transform parent) where T : Object
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = original;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref original;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(153)]
	[CachedScanResults(RefRangeStart = 1207370, RefRangeEnd = 1207523, XrefRangeStart = 1207364, XrefRangeEnd = 1207370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = original;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref original;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPositionStays;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1207531, RefRangeEnd = 1207532, XrefRangeStart = 1207523, XrefRangeEnd = 1207531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(Object obj, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(452)]
	[CachedScanResults(RefRangeStart = 1207543, RefRangeEnd = 1207995, XrefRangeStart = 1207532, XrefRangeEnd = 1207543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1208003, RefRangeEnd = 1208004, XrefRangeStart = 1207995, XrefRangeEnd = 1208003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyImmediate(Object obj, bool allowDestroyingAssets)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowDestroyingAssets;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 1208015, RefRangeEnd = 1208051, XrefRangeStart = 1208004, XrefRangeEnd = 1208015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyImmediate(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1208053, RefRangeEnd = 1208054, XrefRangeStart = 1208051, XrefRangeEnd = 1208053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> FindObjectsByType(Il2CppSystem.Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(FindObjectsInactive**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &findObjectsInactive;
		*(FindObjectsSortMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsInactive_FindObjectsSortMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1208065, RefRangeEnd = 1208086, XrefRangeStart = 1208054, XrefRangeEnd = 1208065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DontDestroyOnLoad(Object target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1208180, RefRangeEnd = 1208183, XrefRangeStart = 1208171, XrefRangeEnd = 1208180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsSortMode sortMode) where T : Object
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sortMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1208192, RefRangeEnd = 1208195, XrefRangeStart = 1208183, XrefRangeEnd = 1208192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindFirstObjectByType<T>() where T : Object
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1208204, RefRangeEnd = 1208207, XrefRangeStart = 1208195, XrefRangeEnd = 1208204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindAnyObjectByType<T>() where T : Object
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindAnyObjectByType_Public_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1208216, RefRangeEnd = 1208217, XrefRangeStart = 1208207, XrefRangeEnd = 1208216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&findObjectsInactive);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1208222, RefRangeEnd = 1208223, XrefRangeStart = 1208217, XrefRangeEnd = 1208222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckNullArgument(Il2CppSystem.Object arg, string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1208228, RefRangeEnd = 1208230, XrefRangeStart = 1208223, XrefRangeEnd = 1208228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object FindFirstObjectByType(Il2CppSystem.Type type, FindObjectsInactive findObjectsInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(FindObjectsInactive**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &findObjectsInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_FindObjectsInactive_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1208235, RefRangeEnd = 1208236, XrefRangeStart = 1208230, XrefRangeEnd = 1208235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object FindAnyObjectByType(Il2CppSystem.Type type, FindObjectsInactive findObjectsInactive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(FindObjectsInactive**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &findObjectsInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_FindObjectsInactive_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1208240, RefRangeEnd = 1208241, XrefRangeStart = 1208236, XrefRangeEnd = 1208240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2954)]
	[CachedScanResults(RefRangeStart = 1208247, RefRangeEnd = 1211201, XrefRangeStart = 1208241, XrefRangeEnd = 1208247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Object x, Object y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3622)]
	[CachedScanResults(RefRangeStart = 1211207, RefRangeEnd = 1214829, XrefRangeStart = 1211201, XrefRangeEnd = 1211207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Object x, Object y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214829, XrefRangeEnd = 1214831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetOffsetOfInstanceIDInCPlusPlusObject()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1214845, RefRangeEnd = 1214846, XrefRangeStart = 1214831, XrefRangeEnd = 1214845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Internal_CloneSingle(Object data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214846, XrefRangeEnd = 1214866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPositionStays;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1214877, RefRangeEnd = 1214878, XrefRangeStart = 1214866, XrefRangeEnd = 1214877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Private_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1214887, RefRangeEnd = 1214888, XrefRangeStart = 1214878, XrefRangeEnd = 1214887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1214899, RefRangeEnd = 1214900, XrefRangeStart = 1214888, XrefRangeEnd = 1214899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPersistent(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPersistent_Internal_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1214916, RefRangeEnd = 1214917, XrefRangeStart = 1214900, XrefRangeEnd = 1214916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1214925, RefRangeEnd = 1214930, XrefRangeStart = 1214917, XrefRangeEnd = 1214925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object FindObjectFromInstanceID(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1214938, RefRangeEnd = 1214942, XrefRangeStart = 1214930, XrefRangeEnd = 1214938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object ForceLoadFromInstanceID(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214942, XrefRangeEnd = 1214944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy_Injected(System.IntPtr obj, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&obj);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214944, XrefRangeEnd = 1214946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyImmediate_Injected(System.IntPtr obj, bool allowDestroyingAssets)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowDestroyingAssets;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyImmediate_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214946, XrefRangeEnd = 1214948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DontDestroyOnLoad_Injected(System.IntPtr target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DontDestroyOnLoad_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214948, XrefRangeEnd = 1214950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HideFlags get_hideFlags_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hideFlags_Injected_Private_Static_HideFlags_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HideFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214950, XrefRangeEnd = 1214952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_hideFlags_Injected(System.IntPtr _unity_self, HideFlags value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(HideFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hideFlags_Injected_Private_Static_Void_IntPtr_HideFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214952, XrefRangeEnd = 1214954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_CloneSingle_Injected(System.IntPtr data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CloneSingle_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214954, XrefRangeEnd = 1214956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_CloneSingleWithParent_Injected(System.IntPtr data, System.IntPtr parent, bool worldPositionStays)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&data);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parent;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPositionStays;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CloneSingleWithParent_Injected_Private_Static_IntPtr_IntPtr_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214956, XrefRangeEnd = 1214958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ToString_Injected(System.IntPtr obj, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&obj);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214958, XrefRangeEnd = 1214960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214960, XrefRangeEnd = 1214962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPersistent_Injected(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPersistent_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214962, XrefRangeEnd = 1214964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214964, XrefRangeEnd = 1214966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FindObjectFromInstanceID_Injected(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindObjectFromInstanceID_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214966, XrefRangeEnd = 1214968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ForceLoadFromInstanceID_Injected(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceLoadFromInstanceID_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Object(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void EnsureRunningOnMainThread()
	{
		if (!CurrentThreadIsMainThread())
		{
			throw new Il2CppSystem.InvalidOperationException("EnsureRunningOnMainThread can only be called from the main thread");
		}
	}

	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
	{
		CheckNullArgument(original, "The Object you want to instantiate is null.");
		if ((object)((Il2CppObjectBase)original).TryCast<ScriptableObject>() != null)
		{
			throw new Il2CppSystem.ArgumentException("Cannot instantiate a ScriptableObject with a position and rotation");
		}
		Object @object = Internal_InstantiateSingle(original, position, rotation);
		if (@object == null)
		{
			throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
		}
		return @object;
	}

	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
	{
		if (parent == null)
		{
			return Instantiate(original, position, rotation);
		}
		CheckNullArgument(original, "The Object you want to instantiate is null.");
		Object @object = Internal_InstantiateSingleWithParent(original, parent, position, rotation);
		if (@object == null)
		{
			throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
		}
		return @object;
	}

	public static Object Instantiate(Object original, Scene scene)
	{
		CheckNullArgument(original, "The Object you want to instantiate is null.");
		Object @object = Internal_CloneSingleWithScene(original, scene);
		if (@object == null)
		{
			throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
		}
		return @object;
	}

	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
	{
		return ((Il2CppObjectBase)Instantiate((Object)original, position, rotation)).Cast<T>();
	}

	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
	{
		return ((Il2CppObjectBase)Instantiate((Object)original, position, rotation, parent)).Cast<T>();
	}

	public static Il2CppReferenceArray<Object> FindObjectsOfType(Il2CppSystem.Type type)
	{
		return FindObjectsOfType(type, includeInactive: false);
	}

	public static Il2CppReferenceArray<Object> FindObjectsOfType(Il2CppSystem.Type type, bool includeInactive)
	{
		System.IntPtr intPtr = FindObjectsOfTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type), includeInactive);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<Object> FindObjectsByType(Il2CppSystem.Type type, FindObjectsSortMode sortMode)
	{
		return FindObjectsByType(type, FindObjectsInactive.Exclude, sortMode);
	}

	public static void DestroyObject(Object obj, float t)
	{
		Destroy(obj, t);
	}

	public static void DestroyObject(Object obj)
	{
		float t = 0f;
		Destroy(obj, t);
	}

	public static Il2CppReferenceArray<Object> FindSceneObjectsOfType(Il2CppSystem.Type type)
	{
		return FindObjectsOfType(type);
	}

	public static Il2CppReferenceArray<Object> FindObjectsOfTypeIncludingAssets(Il2CppSystem.Type type)
	{
		System.IntPtr intPtr = FindObjectsOfTypeIncludingAssetsDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
	}

	public static Il2CppArrayBase<T> FindObjectsOfType<T>() where T : Object
	{
		return Resources.ConvertObjects<T>(FindObjectsOfType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive: false));
	}

	public static Il2CppArrayBase<T> FindObjectsOfType<T>(bool includeInactive) where T : Object
	{
		return Resources.ConvertObjects<T>(FindObjectsOfType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive));
	}

	public static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) where T : Object
	{
		return Resources.ConvertObjects<T>(FindObjectsByType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive, sortMode));
	}

	public static T FindObjectOfType<T>() where T : Object
	{
		return ((Il2CppObjectBase)FindObjectOfType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive: false)).Cast<T>();
	}

	public static T FindObjectOfType<T>(bool includeInactive) where T : Object
	{
		return ((Il2CppObjectBase)FindObjectOfType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive)).Cast<T>();
	}

	public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
	{
		return ((Il2CppObjectBase)FindAnyObjectByType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive)).Cast<T>();
	}

	public static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Il2CppSystem.Type type)
	{
		return Resources.FindObjectsOfTypeAll(type);
	}

	public static Object FindObjectOfType(Il2CppSystem.Type type)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Object FindFirstObjectByType(Il2CppSystem.Type type)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Object FindAnyObjectByType(Il2CppSystem.Type type)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Object FindObjectOfType(Il2CppSystem.Type type, bool includeInactive)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool CurrentThreadIsMainThread()
	{
		return CurrentThreadIsMainThreadDelegateField();
	}

	public static Object Internal_CloneSingleWithScene(Object data, Scene scene)
	{
		if ((object)data == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(data, "data");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(data);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(data, "data");
		}
		return Unmarshal.UnmarshalUnityObject<Object>(Internal_CloneSingleWithScene_Injected(intPtr, ref scene));
	}

	public static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
	{
		if ((object)data == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(data, "data");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(data);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(data, "data");
		}
		return Unmarshal.UnmarshalUnityObject<Object>(Internal_InstantiateSingle_Injected(intPtr, ref pos, ref rot));
	}

	public static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot)
	{
		if ((object)data == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(data, "data");
		}
		if ((object)parent == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(parent, "parent");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(data);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(data, "data");
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(parent);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(parent, "parent");
		}
		return Unmarshal.UnmarshalUnityObject<Object>(Internal_InstantiateSingleWithParent_Injected(intPtr, intPtr2, ref pos, ref rot));
	}

	public static bool DoesObjectWithInstanceIDExist(int instanceID)
	{
		return DoesObjectWithInstanceIDExistDelegateField(instanceID);
	}

	public unsafe static System.IntPtr GetPtrFromInstanceID(int instanceID, Il2CppSystem.Type objectType, out bool isMonoBehaviour)
	{
		return GetPtrFromInstanceIDDelegateField(instanceID, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectType), (nint)Unsafe.AsPointer(ref isMonoBehaviour));
	}

	public void MarkDirty()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MarkDirty_Injected(intPtr);
	}

	public unsafe static System.IntPtr Internal_CloneSingleWithScene_Injected(System.IntPtr data, [In] ref Scene scene)
	{
		return Internal_CloneSingleWithScene_InjectedDelegateField(data, (nint)Unsafe.AsPointer(ref scene));
	}

	public unsafe static System.IntPtr Internal_InstantiateSingle_Injected(System.IntPtr data, [In] ref Vector3 pos, [In] ref Quaternion rot)
	{
		return Internal_InstantiateSingle_InjectedDelegateField(data, (nint)Unsafe.AsPointer(ref pos), (nint)Unsafe.AsPointer(ref rot));
	}

	public unsafe static System.IntPtr Internal_InstantiateSingleWithParent_Injected(System.IntPtr data, System.IntPtr parent, [In] ref Vector3 pos, [In] ref Quaternion rot)
	{
		return Internal_InstantiateSingleWithParent_InjectedDelegateField(data, parent, (nint)Unsafe.AsPointer(ref pos), (nint)Unsafe.AsPointer(ref rot));
	}

	public static void MarkDirty_Injected(System.IntPtr _unity_self)
	{
		MarkDirty_InjectedDelegateField(_unity_self);
	}
}
