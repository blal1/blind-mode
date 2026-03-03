using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class RTHandleResourcePool : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ResourcePool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RemoveList;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentStaleResourceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_StaleResourceLifetime;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_StaleResourceMaxCapacity;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_staleResourceCapacity_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_staleResourceCapacity_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddResourceToPool_Internal_Boolean_byref_TextureDesc_RTHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetResource_Internal_Boolean_byref_TextureDesc_byref_RTHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PurgeUnusedResources_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCodeWithNameHash_Internal_Int32_byref_TextureDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTextureDesc_Internal_Static_TextureDesc_RenderTextureDescriptor_TextureSizeMode_Int32_Single_FilterMode_TextureWrapMode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<int, SortedList<int, Il2CppSystem.ValueTuple<RTHandle, int>>> m_ResourcePool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResourcePool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, SortedList<int, Il2CppSystem.ValueTuple<RTHandle, int>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResourcePool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> m_RemoveList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RemoveList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RemoveList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_CurrentStaleResourceCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentStaleResourceCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentStaleResourceCount, (void*)(&value));
		}
	}

	public unsafe static int s_StaleResourceLifetime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_StaleResourceLifetime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_StaleResourceLifetime, (void*)(&value));
		}
	}

	public unsafe static int s_StaleResourceMaxCapacity
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_StaleResourceMaxCapacity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_StaleResourceMaxCapacity, (void*)(&value));
		}
	}

	public unsafe int staleResourceCapacity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099035, XrefRangeEnd = 1099039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_staleResourceCapacity_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099039, XrefRangeEnd = 1099046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_staleResourceCapacity_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RTHandleResourcePool()
	{
		Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RTHandleResourcePool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr);
		NativeFieldInfoPtr_m_ResourcePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "m_ResourcePool");
		NativeFieldInfoPtr_m_RemoveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "m_RemoveList");
		NativeFieldInfoPtr_s_CurrentStaleResourceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "s_CurrentStaleResourceCount");
		NativeFieldInfoPtr_s_StaleResourceLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "s_StaleResourceLifetime");
		NativeFieldInfoPtr_s_StaleResourceMaxCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "s_StaleResourceMaxCapacity");
		NativeMethodInfoPtr_get_staleResourceCapacity_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665448);
		NativeMethodInfoPtr_set_staleResourceCapacity_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665449);
		NativeMethodInfoPtr_AddResourceToPool_Internal_Boolean_byref_TextureDesc_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665450);
		NativeMethodInfoPtr_TryGetResource_Internal_Boolean_byref_TextureDesc_byref_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665451);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665452);
		NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665453);
		NativeMethodInfoPtr_PurgeUnusedResources_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665454);
		NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665455);
		NativeMethodInfoPtr_GetHashCodeWithNameHash_Internal_Int32_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665456);
		NativeMethodInfoPtr_CreateTextureDesc_Internal_Static_TextureDesc_RenderTextureDescriptor_TextureSizeMode_Int32_Single_FilterMode_TextureWrapMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665457);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665458);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099076, RefRangeEnd = 1099077, XrefRangeStart = 1099046, XrefRangeEnd = 1099076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddResourceToPool([In] ref TextureDesc texDesc, RTHandle resource, int currentFrameIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)texDesc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resource);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentFrameIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddResourceToPool_Internal_Boolean_byref_TextureDesc_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1099098, RefRangeEnd = 1099104, XrefRangeStart = 1099077, XrefRangeEnd = 1099098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetResource([In] ref TextureDesc texDesc, out RTHandle resource, bool usepool = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)texDesc);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &usepool;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetResource_Internal_Boolean_byref_TextureDesc_byref_RTHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		resource = ((num3 == 0) ? null : new RTHandle(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1099144, RefRangeEnd = 1099147, XrefRangeStart = 1099104, XrefRangeEnd = 1099144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099151, RefRangeEnd = 1099152, XrefRangeStart = 1099147, XrefRangeEnd = 1099151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lastUsedFrameIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentFrameIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099210, RefRangeEnd = 1099211, XrefRangeStart = 1099152, XrefRangeEnd = 1099210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PurgeUnusedResources(int currentFrameIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentFrameIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PurgeUnusedResources_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099211, XrefRangeEnd = 1099285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogDebugInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099286, RefRangeEnd = 1099288, XrefRangeStart = 1099285, XrefRangeEnd = 1099286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHashCodeWithNameHash([In] ref TextureDesc texDesc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)texDesc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCodeWithNameHash_Internal_Int32_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1099297, RefRangeEnd = 1099310, XrefRangeStart = 1099288, XrefRangeEnd = 1099297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureDesc CreateTextureDesc(RenderTextureDescriptor desc, TextureSizeMode textureSizeMode = TextureSizeMode.Explicit, int anisoLevel = 1, float mipMapBias = 0f, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&desc);
		*(TextureSizeMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureSizeMode;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(FilterMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTextureDesc_Internal_Static_TextureDesc_RenderTextureDescriptor_TextureSizeMode_Int32_Single_FilterMode_TextureWrapMode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TextureDesc(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099325, RefRangeEnd = 1099326, XrefRangeStart = 1099310, XrefRangeEnd = 1099325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandleResourcePool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RTHandleResourcePool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
