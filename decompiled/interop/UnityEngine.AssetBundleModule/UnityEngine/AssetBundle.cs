using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AssetBundle : Object
{
	private delegate void UnloadAllAssetBundlesDelegate(bool unloadAllObjects);

	private delegate System.IntPtr GetAllLoadedAssetBundles_NativeDelegate();

	private delegate System.IntPtr returnMainAsset_InjectedDelegate(System.IntPtr bundle);

	private delegate System.IntPtr LoadFromMemory_Internal_InjectedDelegate(System.IntPtr binary, uint crc);

	private delegate System.IntPtr LoadFromStreamAsyncInternal_InjectedDelegate(System.IntPtr stream, uint crc, uint managedReadBufferSize);

	private delegate System.IntPtr LoadFromStreamInternal_InjectedDelegate(System.IntPtr stream, uint crc, uint managedReadBufferSize);

	private delegate bool get_isStreamedSceneAssetBundle_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool Contains_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name);

	private delegate System.IntPtr LoadAsset_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name, System.IntPtr type);

	private delegate System.IntPtr LoadAssetAsync_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name, System.IntPtr type);

	private delegate System.IntPtr UnloadAsync_InjectedDelegate(System.IntPtr _unity_self, bool unloadAllLoadedObjects);

	private delegate System.IntPtr GetAllScenePaths_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFileAsync_Internal_Internal_Static_AssetBundleCreateRequest_String_UInt32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromMemoryAsync_Internal_Internal_Static_AssetBundleCreateRequest_Il2CppStructArray_1_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromMemoryAsync_Public_Static_AssetBundleCreateRequest_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssets_Public_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssets_Public_Il2CppReferenceArray_1_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAssetNames_Public_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Internal_Il2CppReferenceArray_1_Object_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Private_AssetBundleRequest_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFileAsync_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFile_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromMemoryAsync_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAssetNames_Injected_Private_Static_Il2CppStringArray_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Object_IntPtr_byref_ManagedSpanWrapper_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_Type_0;

	private static readonly UnloadAllAssetBundlesDelegate UnloadAllAssetBundlesDelegateField;

	private static readonly GetAllLoadedAssetBundles_NativeDelegate GetAllLoadedAssetBundles_NativeDelegateField;

	private static readonly returnMainAsset_InjectedDelegate returnMainAsset_InjectedDelegateField;

	private static readonly LoadFromMemory_Internal_InjectedDelegate LoadFromMemory_Internal_InjectedDelegateField;

	private static readonly LoadFromStreamAsyncInternal_InjectedDelegate LoadFromStreamAsyncInternal_InjectedDelegateField;

	private static readonly LoadFromStreamInternal_InjectedDelegate LoadFromStreamInternal_InjectedDelegateField;

	private static readonly get_isStreamedSceneAssetBundle_InjectedDelegate get_isStreamedSceneAssetBundle_InjectedDelegateField;

	private static readonly Contains_InjectedDelegate Contains_InjectedDelegateField;

	private static readonly LoadAsset_Internal_InjectedDelegate LoadAsset_Internal_InjectedDelegateField;

	private static readonly LoadAssetAsync_Internal_InjectedDelegate LoadAssetAsync_Internal_InjectedDelegateField;

	private static readonly UnloadAsync_InjectedDelegate UnloadAsync_InjectedDelegateField;

	private static readonly GetAllScenePaths_InjectedDelegate GetAllScenePaths_InjectedDelegateField;

	public Object mainAsset => returnMainAsset(this);

	public bool isStreamedSceneAssetBundle
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isStreamedSceneAssetBundle_Injected(intPtr);
		}
	}

	public static uint memoryBudgetKB
	{
		get
		{
			return AssetBundleLoadingCache.memoryBudgetKB;
		}
		set
		{
			AssetBundleLoadingCache.memoryBudgetKB = value;
		}
	}

	static AssetBundle()
	{
		Il2CppClassPointerStore<AssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_LoadFromFileAsync_Internal_Internal_Static_AssetBundleCreateRequest_String_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_LoadFromMemoryAsync_Internal_Internal_Static_AssetBundleCreateRequest_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_LoadFromMemoryAsync_Public_Static_AssetBundleCreateRequest_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_LoadAllAssets_Public_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_LoadAllAssets_Public_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_Unload_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_GetAllAssetNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Internal_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Private_AssetBundleRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_LoadFromFileAsync_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_LoadFromFile_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_LoadFromMemoryAsync_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_Unload_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_GetAllAssetNames_Injected_Private_Static_Il2CppStringArray_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Object_IntPtr_byref_ManagedSpanWrapper_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663318);
		UnloadAllAssetBundlesDelegateField = IL2CPP.ResolveICall<UnloadAllAssetBundlesDelegate>("UnityEngine.AssetBundle::UnloadAllAssetBundles");
		GetAllLoadedAssetBundles_NativeDelegateField = IL2CPP.ResolveICall<GetAllLoadedAssetBundles_NativeDelegate>("UnityEngine.AssetBundle::GetAllLoadedAssetBundles_Native");
		returnMainAsset_InjectedDelegateField = IL2CPP.ResolveICall<returnMainAsset_InjectedDelegate>("UnityEngine.AssetBundle::returnMainAsset_Injected");
		LoadFromMemory_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFromMemory_Internal_InjectedDelegate>("UnityEngine.AssetBundle::LoadFromMemory_Internal_Injected");
		LoadFromStreamAsyncInternal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFromStreamAsyncInternal_InjectedDelegate>("UnityEngine.AssetBundle::LoadFromStreamAsyncInternal_Injected");
		LoadFromStreamInternal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFromStreamInternal_InjectedDelegate>("UnityEngine.AssetBundle::LoadFromStreamInternal_Injected");
		get_isStreamedSceneAssetBundle_InjectedDelegateField = IL2CPP.ResolveICall<get_isStreamedSceneAssetBundle_InjectedDelegate>("UnityEngine.AssetBundle::get_isStreamedSceneAssetBundle_Injected");
		Contains_InjectedDelegateField = IL2CPP.ResolveICall<Contains_InjectedDelegate>("UnityEngine.AssetBundle::Contains_Injected");
		LoadAsset_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadAsset_Internal_InjectedDelegate>("UnityEngine.AssetBundle::LoadAsset_Internal_Injected");
		LoadAssetAsync_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadAssetAsync_Internal_InjectedDelegate>("UnityEngine.AssetBundle::LoadAssetAsync_Internal_Injected");
		UnloadAsync_InjectedDelegateField = IL2CPP.ResolveICall<UnloadAsync_InjectedDelegate>("UnityEngine.AssetBundle::UnloadAsync_Injected");
		GetAllScenePaths_InjectedDelegateField = IL2CPP.ResolveICall<GetAllScenePaths_InjectedDelegate>("UnityEngine.AssetBundle::GetAllScenePaths_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162586, XrefRangeEnd = 1162590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetBundle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162606, RefRangeEnd = 1162607, XrefRangeStart = 1162590, XrefRangeEnd = 1162606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crc;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFileAsync_Internal_Internal_Static_AssetBundleCreateRequest_String_UInt32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162607, XrefRangeEnd = 1162608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetBundleCreateRequest LoadFromFileAsync(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162626, RefRangeEnd = 1162627, XrefRangeStart = 1162608, XrefRangeEnd = 1162626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crc;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1162628, RefRangeEnd = 1162630, XrefRangeStart = 1162627, XrefRangeEnd = 1162628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetBundle LoadFromFile(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162630, XrefRangeEnd = 1162639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(Il2CppStructArray<byte> binary, uint crc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binary);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crc;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromMemoryAsync_Internal_Internal_Static_AssetBundleCreateRequest_Il2CppStructArray_1_Byte_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162648, RefRangeEnd = 1162649, XrefRangeStart = 1162639, XrefRangeEnd = 1162648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binary);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromMemoryAsync_Public_Static_AssetBundleCreateRequest_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1162666, RefRangeEnd = 1162668, XrefRangeStart = 1162649, XrefRangeEnd = 1162666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Object> LoadAllAssets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssets_Public_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162668, XrefRangeEnd = 1162680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Object> LoadAllAssets(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssets_Public_Il2CppReferenceArray_1_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1162697, RefRangeEnd = 1162699, XrefRangeStart = 1162680, XrefRangeEnd = 1162697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetBundleRequest LoadAllAssetsAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162699, XrefRangeEnd = 1162711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetBundleRequest LoadAllAssetsAsync(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1162716, RefRangeEnd = 1162720, XrefRangeStart = 1162711, XrefRangeEnd = 1162716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unload(bool unloadAllLoadedObjects)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unloadAllLoadedObjects);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unload_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162725, RefRangeEnd = 1162726, XrefRangeStart = 1162720, XrefRangeEnd = 1162725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetAllAssetNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAssetNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1162742, RefRangeEnd = 1162744, XrefRangeStart = 1162726, XrefRangeEnd = 1162742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Object> LoadAssetWithSubAssets_Internal(string name, Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Internal_Il2CppReferenceArray_1_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1162762, RefRangeEnd = 1162764, XrefRangeStart = 1162744, XrefRangeEnd = 1162762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Private_AssetBundleRequest_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162764, XrefRangeEnd = 1162766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr LoadFromFileAsync_Internal_Injected(ref ManagedSpanWrapper path, uint crc, ulong offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref path);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crc;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFileAsync_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162766, XrefRangeEnd = 1162768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr LoadFromFile_Internal_Injected(ref ManagedSpanWrapper path, uint crc, ulong offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref path);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crc;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFile_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162768, XrefRangeEnd = 1162770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr LoadFromMemoryAsync_Internal_Injected(ref ManagedSpanWrapper binary, uint crc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref binary);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crc;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromMemoryAsync_Internal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162770, XrefRangeEnd = 1162772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unload_Injected(System.IntPtr _unity_self, bool unloadAllLoadedObjects)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unloadAllLoadedObjects;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unload_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162772, XrefRangeEnd = 1162774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetAllAssetNames_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAssetNames_Injected_Private_Static_Il2CppStringArray_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162774, XrefRangeEnd = 1162776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> LoadAssetWithSubAssets_Internal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Injected_Private_Static_Il2CppReferenceArray_1_Object_IntPtr_byref_ManagedSpanWrapper_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162776, XrefRangeEnd = 1162778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr LoadAssetWithSubAssetsAsync_Internal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AssetBundle(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Object returnMainAsset(AssetBundle bundle)
	{
		if ((object)bundle == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(bundle, "bundle");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(bundle);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(bundle, "bundle");
		}
		return Unmarshal.UnmarshalUnityObject<Object>(returnMainAsset_Injected(intPtr));
	}

	public static void UnloadAllAssetBundles(bool unloadAllObjects)
	{
		UnloadAllAssetBundlesDelegateField(unloadAllObjects);
	}

	public static Il2CppReferenceArray<AssetBundle> GetAllLoadedAssetBundles_Native()
	{
		System.IntPtr intPtr = GetAllLoadedAssetBundles_NativeDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetBundle>>(intPtr) : null;
	}

	public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles()
	{
		return (IEnumerable<AssetBundle>)(object)GetAllLoadedAssetBundles_Native();
	}

	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc)
	{
		return LoadFromFileAsync_Internal(path, crc, 0uL);
	}

	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset)
	{
		return LoadFromFileAsync_Internal(path, crc, offset);
	}

	public static AssetBundle LoadFromFile(string path, uint crc)
	{
		return LoadFromFile_Internal(path, crc, 0uL);
	}

	public static AssetBundle LoadFromFile(string path, uint crc, ulong offset)
	{
		return LoadFromFile_Internal(path, crc, offset);
	}

	public static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary, uint crc)
	{
		return LoadFromMemoryAsync_Internal(binary, crc);
	}

	public unsafe static AssetBundle LoadFromMemory_Internal(Il2CppStructArray<byte> binary, uint crc)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)binary);
		AssetBundle result;
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper binary2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			result = Unmarshal.UnmarshalUnityObject<AssetBundle>(LoadFromMemory_Internal_Injected(ref binary2, crc));
		}
		return result;
	}

	public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary)
	{
		return LoadFromMemory_Internal(binary, 0u);
	}

	public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary, uint crc)
	{
		return LoadFromMemory_Internal(binary, crc);
	}

	public static void ValidateLoadFromStream(Stream stream)
	{
		if (stream == null)
		{
			throw new Il2CppSystem.ArgumentNullException("ManagedStream object must be non-null", "stream");
		}
		if (!stream.CanRead)
		{
			throw new Il2CppSystem.ArgumentException("ManagedStream object must be readable (stream.CanRead must return true)", "stream");
		}
		if (!stream.CanSeek)
		{
			throw new Il2CppSystem.ArgumentException("ManagedStream object must be seekable (stream.CanSeek must return true)", "stream");
		}
	}

	public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc, uint managedReadBufferSize)
	{
		ValidateLoadFromStream(stream);
		return LoadFromStreamAsyncInternal(stream, crc, managedReadBufferSize);
	}

	public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc)
	{
		ValidateLoadFromStream(stream);
		return LoadFromStreamAsyncInternal(stream, crc, 0u);
	}

	public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream)
	{
		ValidateLoadFromStream(stream);
		return LoadFromStreamAsyncInternal(stream, 0u, 0u);
	}

	public static AssetBundle LoadFromStream(Stream stream, uint crc, uint managedReadBufferSize)
	{
		ValidateLoadFromStream(stream);
		return LoadFromStreamInternal(stream, crc, managedReadBufferSize);
	}

	public static AssetBundle LoadFromStream(Stream stream, uint crc)
	{
		ValidateLoadFromStream(stream);
		return LoadFromStreamInternal(stream, crc, 0u);
	}

	public static AssetBundle LoadFromStream(Stream stream)
	{
		ValidateLoadFromStream(stream);
		return LoadFromStreamInternal(stream, 0u, 0u);
	}

	public static AssetBundleCreateRequest LoadFromStreamAsyncInternal(Stream stream, uint crc, uint managedReadBufferSize)
	{
		System.IntPtr intPtr = LoadFromStreamAsyncInternal_Injected(stream, crc, managedReadBufferSize);
		return (intPtr == (System.IntPtr)0) ? null : AssetBundleCreateRequest.BindingsMarshaller.ConvertToManaged(intPtr);
	}

	public static AssetBundle LoadFromStreamInternal(Stream stream, uint crc, uint managedReadBufferSize)
	{
		return Unmarshal.UnmarshalUnityObject<AssetBundle>(LoadFromStreamInternal_Injected(stream, crc, managedReadBufferSize));
	}

	public unsafe bool Contains(string name)
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
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Contains_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return Contains_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public Object Load(string name)
	{
		return null;
	}

	public Object Load<T>(string name)
	{
		return null;
	}

	public Object Load(string name, Il2CppSystem.Type type)
	{
		return null;
	}

	public AssetBundleRequest LoadAsync(string name, Il2CppSystem.Type type)
	{
		return null;
	}

	public Il2CppReferenceArray<Object> LoadAll(Il2CppSystem.Type type)
	{
		return null;
	}

	public Il2CppReferenceArray<Object> LoadAll()
	{
		return null;
	}

	public Il2CppArrayBase<T> LoadAll<T>() where T : Object
	{
		return null;
	}

	public Object LoadAsset(string name)
	{
		return LoadAsset(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
	}

	public T LoadAsset<T>(string name) where T : Object
	{
		return ((Il2CppObjectBase)LoadAsset(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()))).Cast<T>();
	}

	public Object LoadAsset(string name, Il2CppSystem.Type type)
	{
		if (name == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input asset name cannot be null.");
		}
		if (name.Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("The input asset name cannot be empty.");
		}
		if (type == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input type cannot be null.");
		}
		return LoadAsset_Internal(name, type);
	}

	public unsafe Object LoadAsset_Internal(string name, Il2CppSystem.Type type)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr gcHandlePtr);
		Object result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
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
					gcHandlePtr = LoadAsset_Internal_Injected(intPtr, ref managedSpanWrapper, type);
				}
			}
			else
			{
				gcHandlePtr = LoadAsset_Internal_Injected(intPtr, ref managedSpanWrapper, type);
			}
		}
		finally
		{
			result = Unmarshal.UnmarshalUnityObject<Object>(gcHandlePtr);
		}
		return result;
	}

	public AssetBundleRequest LoadAssetAsync(string name)
	{
		return LoadAssetAsync(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
	}

	public AssetBundleRequest LoadAssetAsync<T>(string name)
	{
		return LoadAssetAsync(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
	}

	public AssetBundleRequest LoadAssetAsync(string name, Il2CppSystem.Type type)
	{
		if (name == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input asset name cannot be null.");
		}
		if (name.Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("The input asset name cannot be empty.");
		}
		if (type == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input type cannot be null.");
		}
		return LoadAssetAsync_Internal(name, type);
	}

	public Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name)
	{
		return LoadAssetWithSubAssets(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
	}

	public static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppArrayBase<T> LoadAssetWithSubAssets<T>(string name) where T : Object
	{
		return ConvertObjects<T>(LoadAssetWithSubAssets(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
	}

	public Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name, Il2CppSystem.Type type)
	{
		if (name == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input asset name cannot be null.");
		}
		if (name.Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("The input asset name cannot be empty.");
		}
		if (type == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input type cannot be null.");
		}
		return LoadAssetWithSubAssets_Internal(name, type);
	}

	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
	{
		return LoadAssetWithSubAssetsAsync(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
	}

	public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
	{
		return LoadAssetWithSubAssetsAsync(name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
	}

	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Il2CppSystem.Type type)
	{
		if (name == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input asset name cannot be null.");
		}
		if (name.Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("The input asset name cannot be empty.");
		}
		if (type == null)
		{
			throw new Il2CppSystem.NullReferenceException("The input type cannot be null.");
		}
		return LoadAssetWithSubAssetsAsync_Internal(name, type);
	}

	public Il2CppStringArray AllAssetNames()
	{
		return GetAllAssetNames();
	}

	public unsafe AssetBundleRequest LoadAssetAsync_Internal(string name, Il2CppSystem.Type type)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		AssetBundleRequest result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
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
					intPtr2 = LoadAssetAsync_Internal_Injected(intPtr, ref managedSpanWrapper, type);
				}
			}
			else
			{
				intPtr2 = LoadAssetAsync_Internal_Injected(intPtr, ref managedSpanWrapper, type);
			}
		}
		finally
		{
			System.IntPtr intPtr3 = intPtr2;
			result = ((intPtr3 == (System.IntPtr)0) ? null : AssetBundleRequest.BindingsMarshaller.ConvertToManaged(intPtr3));
		}
		return result;
	}

	public AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = UnloadAsync_Injected(intPtr, unloadAllLoadedObjects);
		return (intPtr2 == (System.IntPtr)0) ? null : AssetBundleUnloadOperation.BindingsMarshaller.ConvertToManaged(intPtr2);
	}

	public Il2CppStringArray GetAllScenePaths()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAllScenePaths_Injected(intPtr);
	}

	public static System.IntPtr returnMainAsset_Injected(System.IntPtr bundle)
	{
		return returnMainAsset_InjectedDelegateField(bundle);
	}

	public unsafe static System.IntPtr LoadFromMemory_Internal_Injected(ref ManagedSpanWrapper binary, uint crc)
	{
		return LoadFromMemory_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref binary), crc);
	}

	public static System.IntPtr LoadFromStreamAsyncInternal_Injected(Stream stream, uint crc, uint managedReadBufferSize)
	{
		return LoadFromStreamAsyncInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream), crc, managedReadBufferSize);
	}

	public static System.IntPtr LoadFromStreamInternal_Injected(Stream stream, uint crc, uint managedReadBufferSize)
	{
		return LoadFromStreamInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream), crc, managedReadBufferSize);
	}

	public static bool get_isStreamedSceneAssetBundle_Injected(System.IntPtr _unity_self)
	{
		return get_isStreamedSceneAssetBundle_InjectedDelegateField(_unity_self);
	}

	public unsafe static bool Contains_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		return Contains_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static System.IntPtr LoadAsset_Internal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, Il2CppSystem.Type type)
	{
		return LoadAsset_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public unsafe static System.IntPtr LoadAssetAsync_Internal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, Il2CppSystem.Type type)
	{
		return LoadAssetAsync_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public static System.IntPtr UnloadAsync_Injected(System.IntPtr _unity_self, bool unloadAllLoadedObjects)
	{
		return UnloadAsync_InjectedDelegateField(_unity_self, unloadAllLoadedObjects);
	}

	public static Il2CppStringArray GetAllScenePaths_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetAllScenePaths_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}
}
