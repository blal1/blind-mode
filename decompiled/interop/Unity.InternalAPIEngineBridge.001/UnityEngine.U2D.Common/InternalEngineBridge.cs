using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.U2D.Common;

public static class InternalEngineBridge : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalAABB_Public_Static_Void_SpriteRenderer_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeformableBuffer_Public_Static_Void_SpriteRenderer_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingDeformableBuffer_Public_Static_Boolean_SpriteRenderer_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGPUSkinningEnabled_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSRPBatchingEnabled_Public_Static_Boolean_SpriteRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Public_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBatchBoneTransformsAABBArray_Public_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFloatToInt_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertIntToFloat_Public_Static_Single_Int32_0;

	static InternalEngineBridge()
	{
		Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InternalAPIEngineBridge.001.dll", "UnityEngine.U2D.Common", "InternalEngineBridge");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr);
		NativeMethodInfoPtr_SetLocalAABB_Public_Static_Void_SpriteRenderer_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_SetDeformableBuffer_Public_Static_Void_SpriteRenderer_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_IsUsingDeformableBuffer_Public_Static_Boolean_SpriteRenderer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_IsGPUSkinningEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_IsSRPBatchingEnabled_Public_Static_Boolean_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Public_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_SetBatchBoneTransformsAABBArray_Public_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_ConvertFloatToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_ConvertIntToFloat_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEngineBridge>.NativeClassPtr, 100663305);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023099, RefRangeEnd = 1023101, XrefRangeStart = 1023098, XrefRangeEnd = 1023099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalAABB(SpriteRenderer spriteRenderer, Bounds aabb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aabb;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalAABB_Public_Static_Void_SpriteRenderer_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023102, RefRangeEnd = 1023103, XrefRangeStart = 1023101, XrefRangeEnd = 1023102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDeformableBuffer(SpriteRenderer spriteRenderer, NativeArray<byte> src)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)src));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeformableBuffer_Public_Static_Void_SpriteRenderer_NativeArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023104, RefRangeEnd = 1023105, XrefRangeStart = 1023103, XrefRangeEnd = 1023104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsingDeformableBuffer_Public_Static_Boolean_SpriteRenderer_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1023106, RefRangeEnd = 1023109, XrefRangeStart = 1023105, XrefRangeEnd = 1023106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGPUSkinningEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGPUSkinningEnabled_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023110, RefRangeEnd = 1023112, XrefRangeStart = 1023109, XrefRangeEnd = 1023110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSRPBatchingEnabled(SpriteRenderer spriteRenderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSRPBatchingEnabled_Public_Static_Boolean_SpriteRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023113, RefRangeEnd = 1023114, XrefRangeStart = 1023112, XrefRangeEnd = 1023113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, NativeArray<System.IntPtr> buffers, NativeArray<int> bufferSizes, NativeArray<Bounds> bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffers));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bufferSizes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bounds));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBatchDeformableBufferAndLocalAABBArray_Public_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023115, RefRangeEnd = 1023116, XrefRangeStart = 1023114, XrefRangeEnd = 1023115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBatchBoneTransformsAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, NativeArray<System.IntPtr> buffers, NativeArray<int> bufferSizes, NativeArray<Bounds> bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffers));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bufferSizes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bounds));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBatchBoneTransformsAABBArray_Public_Static_Void_Il2CppReferenceArray_1_SpriteRenderer_NativeArray_1_IntPtr_NativeArray_1_Int32_NativeArray_1_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1023117, RefRangeEnd = 1023124, XrefRangeStart = 1023116, XrefRangeEnd = 1023117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ConvertFloatToInt(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFloatToInt_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1023125, RefRangeEnd = 1023128, XrefRangeStart = 1023124, XrefRangeEnd = 1023125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertIntToFloat(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertIntToFloat_Public_Static_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InternalEngineBridge(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
