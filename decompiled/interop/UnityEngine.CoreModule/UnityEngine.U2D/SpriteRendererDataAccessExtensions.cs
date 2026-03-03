using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine.U2D;

public static class SpriteRendererDataAccessExtensions : Il2CppSystem.Object
{
	private delegate void SetBoneTransforms_InjectedDelegate(System.IntPtr spriteRenderer, System.IntPtr src, int count);

	private delegate void SetupMaterialProperties_InjectedDelegate(System.IntPtr spriteRenderer);

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeformableBuffer_Internal_Static_Void_SpriteRenderer_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Internal_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoneTransformsArray_Internal_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingDeformableBuffer_Internal_Static_Boolean_SpriteRenderer_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateDeformableBuffer_Public_Static_Void_SpriteRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalAABB_Internal_Static_Void_SpriteRenderer_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeformableBuffer_Private_Static_Void_SpriteRenderer_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Private_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_ptr_Void_ptr_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingDeformableBuffer_Private_Static_Boolean_SpriteRenderer_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoneTransformsArray_Private_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_ptr_Void_ptr_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGPUSkinningEnabled_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSRPBatchingEnabled_Internal_Static_Boolean_SpriteRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateDeformableBuffer_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalAABB_Injected_Private_Static_Void_IntPtr_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeformableBuffer_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingDeformableBuffer_Injected_Private_Static_Boolean_IntPtr_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSRPBatchingEnabled_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly SetBoneTransforms_InjectedDelegate SetBoneTransforms_InjectedDelegateField;

	private static readonly SetupMaterialProperties_InjectedDelegate SetupMaterialProperties_InjectedDelegateField;

	static SpriteRendererDataAccessExtensions()
	{
		Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteRendererDataAccessExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SetDeformableBuffer_Internal_Static_Void_SpriteRenderer_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669023);
		NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Internal_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669024);
		NativeMethodInfoPtr_SetBoneTransformsArray_Internal_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669025);
		NativeMethodInfoPtr_IsUsingDeformableBuffer_Internal_Static_Boolean_SpriteRenderer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669026);
		NativeMethodInfoPtr_DeactivateDeformableBuffer_Public_Static_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669027);
		NativeMethodInfoPtr_SetLocalAABB_Internal_Static_Void_SpriteRenderer_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669028);
		NativeMethodInfoPtr_SetDeformableBuffer_Private_Static_Void_SpriteRenderer_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669029);
		NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Private_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_ptr_Void_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669030);
		NativeMethodInfoPtr_IsUsingDeformableBuffer_Private_Static_Boolean_SpriteRenderer_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669031);
		NativeMethodInfoPtr_SetBoneTransformsArray_Private_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_ptr_Void_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669032);
		NativeMethodInfoPtr_IsGPUSkinningEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669033);
		NativeMethodInfoPtr_IsSRPBatchingEnabled_Internal_Static_Boolean_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669034);
		NativeMethodInfoPtr_DeactivateDeformableBuffer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669035);
		NativeMethodInfoPtr_SetLocalAABB_Injected_Private_Static_Void_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669036);
		NativeMethodInfoPtr_SetDeformableBuffer_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669037);
		NativeMethodInfoPtr_IsUsingDeformableBuffer_Injected_Private_Static_Boolean_IntPtr_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669038);
		NativeMethodInfoPtr_IsSRPBatchingEnabled_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererDataAccessExtensions>.NativeClassPtr, 100669039);
		SetBoneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<SetBoneTransforms_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBoneTransforms_Injected");
		SetupMaterialProperties_InjectedDelegateField = IL2CPP.ResolveICall<SetupMaterialProperties_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetupMaterialProperties_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241628, RefRangeEnd = 1241629, XrefRangeStart = 1241588, XrefRangeEnd = 1241628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDeformableBuffer(this SpriteRenderer spriteRenderer, NativeArray<byte> src)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)src));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeformableBuffer_Internal_Static_Void_SpriteRenderer_NativeArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241647, RefRangeEnd = 1241648, XrefRangeStart = 1241629, XrefRangeEnd = 1241647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, NativeArray<System.IntPtr> buffers, NativeArray<int> bufferSizes, NativeArray<Bounds> bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffers));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bufferSizes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bounds));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Internal_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241666, RefRangeEnd = 1241667, XrefRangeStart = 1241648, XrefRangeEnd = 1241666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBoneTransformsArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, NativeArray<System.IntPtr> buffers, NativeArray<int> bufferSizes, NativeArray<Bounds> bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffers));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bufferSizes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bounds));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoneTransformsArray_Internal_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241677, RefRangeEnd = 1241678, XrefRangeStart = 1241667, XrefRangeEnd = 1241677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUsingDeformableBuffer(this SpriteRenderer spriteRenderer, System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsingDeformableBuffer_Internal_Static_Boolean_SpriteRenderer_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241687, RefRangeEnd = 1241689, XrefRangeStart = 1241678, XrefRangeEnd = 1241687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeactivateDeformableBuffer(this SpriteRenderer renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeactivateDeformableBuffer_Public_Static_Void_SpriteRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241695, RefRangeEnd = 1241696, XrefRangeStart = 1241689, XrefRangeEnd = 1241695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalAABB(this SpriteRenderer renderer, Bounds aabb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aabb;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalAABB_Internal_Static_Void_SpriteRenderer_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241696, XrefRangeEnd = 1241705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDeformableBuffer(SpriteRenderer spriteRenderer, void* src, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeformableBuffer_Private_Static_Void_SpriteRenderer_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241705, XrefRangeEnd = 1241707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderers);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffers;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = bufferSizes;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = bounds;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Private_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_ptr_Void_ptr_Void_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241707, XrefRangeEnd = 1241716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, void* buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsingDeformableBuffer_Private_Static_Boolean_SpriteRenderer_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241716, XrefRangeEnd = 1241718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBoneTransformsArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderers);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffers;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = bufferSizes;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = bounds;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoneTransformsArray_Private_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_ptr_Void_ptr_Void_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241720, RefRangeEnd = 1241721, XrefRangeStart = 1241718, XrefRangeEnd = 1241720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGPUSkinningEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGPUSkinningEnabled_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241730, RefRangeEnd = 1241731, XrefRangeStart = 1241721, XrefRangeEnd = 1241730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSRPBatchingEnabled(SpriteRenderer spriteRenderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSRPBatchingEnabled_Internal_Static_Boolean_SpriteRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241731, XrefRangeEnd = 1241733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeactivateDeformableBuffer_Injected(System.IntPtr renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeactivateDeformableBuffer_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241733, XrefRangeEnd = 1241735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalAABB_Injected(System.IntPtr renderer, [In] ref Bounds aabb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref aabb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalAABB_Injected_Private_Static_Void_IntPtr_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241735, XrefRangeEnd = 1241737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDeformableBuffer_Injected(System.IntPtr spriteRenderer, void* src, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&spriteRenderer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeformableBuffer_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241737, XrefRangeEnd = 1241739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUsingDeformableBuffer_Injected(System.IntPtr spriteRenderer, void* buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&spriteRenderer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsingDeformableBuffer_Injected_Private_Static_Boolean_IntPtr_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241739, XrefRangeEnd = 1241741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSRPBatchingEnabled_Injected(System.IntPtr spriteRenderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&spriteRenderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSRPBatchingEnabled_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SpriteRendererDataAccessExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void SetDeformableBuffer(SpriteRenderer spriteRenderer, NativeArray<Vector3> src)
	{
		//IL_0023: Expected O, but got Ref
		//IL_0071: Expected O, but got Ref
		//IL_0043: Expected O, but got Ref
		if (spriteRenderer.sprite == null)
		{
			throw new Il2CppSystem.InvalidOperationException("spriteRenderer does not have a valid sprite set.");
		}
		if (((NativeArray<Vector3>)(&src)).Length != spriteRenderer.sprite.GetVertexCount())
		{
			throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("The src length {0} must match the vertex count of source Sprite {1}.", (Il2CppSystem.Object)(object)((NativeArray<Vector3>)(&src)).Length, (Il2CppSystem.Object)(object)spriteRenderer.sprite.GetVertexCount()));
		}
		SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr(), ((NativeArray<Vector3>)(&src)).Length);
	}

	public unsafe static void SetBoneTransforms(SpriteRenderer spriteRenderer, NativeArray<Matrix4x4> src)
	{
		//IL_000f: Expected O, but got Ref
		SetBoneTransforms(spriteRenderer, src.GetUnsafeReadOnlyPtr(), ((NativeArray<Matrix4x4>)(&src)).Length);
	}

	public unsafe static void SetBoneTransforms(SpriteRenderer spriteRenderer, void* src, int count)
	{
		if ((object)spriteRenderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(spriteRenderer, "spriteRenderer");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(spriteRenderer);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(spriteRenderer, "spriteRenderer");
		}
		SetBoneTransforms_Injected(intPtr, src, count);
	}

	public static void SetupMaterialProperties(SpriteRenderer spriteRenderer)
	{
		if ((object)spriteRenderer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(spriteRenderer, "spriteRenderer");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(spriteRenderer);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(spriteRenderer, "spriteRenderer");
		}
		SetupMaterialProperties_Injected(intPtr);
	}

	public unsafe static void SetBoneTransforms_Injected(System.IntPtr spriteRenderer, void* src, int count)
	{
		SetBoneTransforms_InjectedDelegateField(spriteRenderer, (nint)src, count);
	}

	public static void SetupMaterialProperties_Injected(System.IntPtr spriteRenderer)
	{
		SetupMaterialProperties_InjectedDelegateField(spriteRenderer);
	}
}
