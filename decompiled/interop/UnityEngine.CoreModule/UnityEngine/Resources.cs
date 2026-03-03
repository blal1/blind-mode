using System;
using System.Runtime.CompilerServices;
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

namespace UnityEngine;

public sealed class Resources : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate bool IsInstanceLoadedDelegate(int instanceID);

	private delegate void InstanceIDToObjectListDelegate(System.IntPtr instanceIDs, int instanceCount, System.IntPtr objects);

	private delegate void InstanceIDsToValidArray_InternalDelegate(System.IntPtr instanceIDs, int instanceCount, System.IntPtr validArray, int validArrayCount);

	private delegate void UnloadAssetImplResourceManager_InjectedDelegate(System.IntPtr assetToUnload);

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToObject_Public_Static_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDIsValid_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltinResource_Injected_Private_Static_IntPtr_Type_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToObject_Injected_Private_Static_IntPtr_Int32_0;

	private static readonly IsInstanceLoadedDelegate IsInstanceLoadedDelegateField;

	private static readonly InstanceIDToObjectListDelegate InstanceIDToObjectListDelegateField;

	private static readonly InstanceIDsToValidArray_InternalDelegate InstanceIDsToValidArray_InternalDelegateField;

	private static readonly UnloadAssetImplResourceManager_InjectedDelegate UnloadAssetImplResourceManager_InjectedDelegateField;

	static Resources()
	{
		Il2CppClassPointerStore<Resources>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Resources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resources>.NativeClassPtr);
		NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666129);
		NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666130);
		NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666131);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666132);
		NativeMethodInfoPtr_Load_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666133);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666134);
		NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666135);
		NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666136);
		NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666137);
		NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666138);
		NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666139);
		NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666140);
		NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666141);
		NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666142);
		NativeMethodInfoPtr_InstanceIDToObject_Public_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666143);
		NativeMethodInfoPtr_InstanceIDIsValid_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666144);
		NativeMethodInfoPtr_GetBuiltinResource_Injected_Private_Static_IntPtr_Type_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666145);
		NativeMethodInfoPtr_UnloadUnusedAssets_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666146);
		NativeMethodInfoPtr_InstanceIDToObject_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666147);
		IsInstanceLoadedDelegateField = IL2CPP.ResolveICall<IsInstanceLoadedDelegate>("UnityEngine.Resources::IsInstanceLoaded");
		InstanceIDToObjectListDelegateField = IL2CPP.ResolveICall<InstanceIDToObjectListDelegate>("UnityEngine.Resources::InstanceIDToObjectList");
		InstanceIDsToValidArray_InternalDelegateField = IL2CPP.ResolveICall<InstanceIDsToValidArray_InternalDelegate>("UnityEngine.Resources::InstanceIDsToValidArray_Internal");
		UnloadAssetImplResourceManager_InjectedDelegateField = IL2CPP.ResolveICall<UnloadAssetImplResourceManager_InjectedDelegate>("UnityEngine.Resources::UnloadAssetImplResourceManager_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1154842, RefRangeEnd = 1154843, XrefRangeStart = 1154842, XrefRangeEnd = 1154843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawObjects);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1185668, RefRangeEnd = 1185670, XrefRangeStart = 1185663, XrefRangeEnd = 1185668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1185683, RefRangeEnd = 1185692, XrefRangeStart = 1185670, XrefRangeEnd = 1185683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> FindObjectsOfTypeAll<T>() where T : Object
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1185698, RefRangeEnd = 1185710, XrefRangeStart = 1185692, XrefRangeEnd = 1185698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Load(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1185716, RefRangeEnd = 1185734, XrefRangeStart = 1185710, XrefRangeEnd = 1185716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>(string path) where T : Object
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1185739, RefRangeEnd = 1185743, XrefRangeStart = 1185734, XrefRangeEnd = 1185739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Load(string path, Il2CppSystem.Type systemTypeInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)systemTypeInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1185753, RefRangeEnd = 1185754, XrefRangeStart = 1185743, XrefRangeEnd = 1185753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ResourceRequest LoadAsync(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1185759, RefRangeEnd = 1185760, XrefRangeStart = 1185754, XrefRangeEnd = 1185759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ResourceRequest LoadAsync(string path, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1185765, RefRangeEnd = 1185766, XrefRangeStart = 1185760, XrefRangeEnd = 1185765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> LoadAll(string path, Il2CppSystem.Type systemTypeInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)systemTypeInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1185776, RefRangeEnd = 1185778, XrefRangeStart = 1185766, XrefRangeEnd = 1185776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> LoadAll(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1185799, RefRangeEnd = 1185801, XrefRangeStart = 1185778, XrefRangeEnd = 1185799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object GetBuiltinResource(Il2CppSystem.Type type, string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1185807, RefRangeEnd = 1185810, XrefRangeStart = 1185801, XrefRangeEnd = 1185807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetBuiltinResource<T>(string path) where T : Object
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1185815, RefRangeEnd = 1185819, XrefRangeStart = 1185810, XrefRangeEnd = 1185815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnloadAsset(Object assetToUnload)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assetToUnload);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1185821, RefRangeEnd = 1185837, XrefRangeStart = 1185819, XrefRangeEnd = 1185821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncOperation UnloadUnusedAssets()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1185842, RefRangeEnd = 1185844, XrefRangeStart = 1185837, XrefRangeEnd = 1185842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object InstanceIDToObject(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceIDToObject_Public_Static_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1185846, RefRangeEnd = 1185848, XrefRangeStart = 1185844, XrefRangeEnd = 1185846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InstanceIDIsValid(int instanceId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceIDIsValid_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185848, XrefRangeEnd = 1185850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetBuiltinResource_Injected(Il2CppSystem.Type type, ref ManagedSpanWrapper path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuiltinResource_Injected_Private_Static_IntPtr_Type_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185850, XrefRangeEnd = 1185852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr UnloadUnusedAssets_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadUnusedAssets_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185852, XrefRangeEnd = 1185854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr InstanceIDToObject_Injected(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceIDToObject_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Resources(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void UnloadAssetImplResourceManager(Object assetToUnload)
	{
		UnloadAssetImplResourceManager_Injected(Object.MarshalledUnityObject.Marshal(assetToUnload));
	}

	public static bool IsInstanceLoaded(int instanceID)
	{
		return IsInstanceLoadedDelegateField(instanceID);
	}

	public static void InstanceIDToObjectList(System.IntPtr instanceIDs, int instanceCount, List<Object> objects)
	{
		InstanceIDToObjectListDelegateField(instanceIDs, instanceCount, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objects));
	}

	public unsafe static void InstanceIDToObjectList(NativeArray<int> instanceIDs, List<Object> objects)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0039: Expected O, but got Ref
		//IL_005c: Expected O, but got Ref
		if (!((NativeArray<int>)(&instanceIDs)).IsCreated)
		{
			throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", "instanceIDs");
		}
		if (objects == null)
		{
			throw new Il2CppSystem.ArgumentNullException("objects");
		}
		if (((NativeArray<int>)(&instanceIDs)).Length == 0)
		{
			objects.Clear();
		}
		else
		{
			InstanceIDToObjectList((System.IntPtr)instanceIDs.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&instanceIDs)).Length, objects);
		}
	}

	public static void InstanceIDsToValidArray_Internal(System.IntPtr instanceIDs, int instanceCount, System.IntPtr validArray, int validArrayCount)
	{
		InstanceIDsToValidArray_InternalDelegateField(instanceIDs, instanceCount, validArray, validArrayCount);
	}

	public unsafe static void InstanceIDsToValidArray(NativeArray<int> instanceIDs, NativeArray<bool> validArray)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_004b: Expected O, but got Ref
		//IL_0066: Expected O, but got Ref
		//IL_0081: Expected O, but got Ref
		//IL_0093: Expected O, but got Ref
		if (!((NativeArray<int>)(&instanceIDs)).IsCreated)
		{
			throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", "instanceIDs");
		}
		if (!((NativeArray<bool>)(&validArray)).IsCreated)
		{
			throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", "validArray");
		}
		if (((NativeArray<int>)(&instanceIDs)).Length != ((NativeArray<bool>)(&validArray)).Length)
		{
			throw new Il2CppSystem.ArgumentException("Size mismatch! Both arrays must be the same length.");
		}
		if (((NativeArray<int>)(&instanceIDs)).Length != 0)
		{
			InstanceIDsToValidArray_Internal((System.IntPtr)instanceIDs.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&instanceIDs)).Length, (System.IntPtr)validArray.GetUnsafePtr(), ((NativeArray<bool>)(&validArray)).Length);
		}
	}

	public unsafe static void InstanceIDsToValidArray(Il2CppSystem.ReadOnlySpan<int> instanceIDs, Il2CppSystem.Span<bool> validArray)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_005a: Expected O, but got Ref
		//IL_0068: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<int>)(&instanceIDs)).Length != ((Il2CppSystem.Span<bool>)(&validArray)).Length)
		{
			throw new Il2CppSystem.ArgumentException("Size mismatch! Both arrays must be the same length.");
		}
		if (((Il2CppSystem.ReadOnlySpan<int>)(&instanceIDs)).Length == 0)
		{
			return;
		}
		fixed (int* ptr = &((Il2CppSystem.ReadOnlySpan<int>)(&instanceIDs)).GetPinnableReference())
		{
			fixed (bool* ptr2 = &((Il2CppSystem.Span<bool>)(&validArray)).GetPinnableReference())
			{
				InstanceIDsToValidArray_Internal((System.IntPtr)(void*)ptr, ((Il2CppSystem.ReadOnlySpan<int>)(&instanceIDs)).Length, (System.IntPtr)(void*)ptr2, ((Il2CppSystem.Span<bool>)(&validArray)).Length);
			}
		}
	}

	public static void UnloadAssetImplResourceManager_Injected(System.IntPtr assetToUnload)
	{
		UnloadAssetImplResourceManager_InjectedDelegateField(assetToUnload);
	}
}
