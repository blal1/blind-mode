using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

public static class RenderingLayerUtils : Il2CppSystem.Object
{
	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "Event")]
	public enum Event
	{
		DepthNormalPrePass,
		Opaque
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "MaskSize")]
	public enum MaskSize
	{
		Bits8,
		Bits16,
		Bits24,
		Bits32
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineRendererEvents_Public_Static_Void_Boolean_Int32_Event_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRenderer_List_1_ScriptableRendererFeature_Int32_byref_Event_byref_MaskSize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequireRenderingLayers_Internal_Static_Boolean_List_1_ScriptableRendererFeature_RenderingMode_Boolean_Int32_byref_Event_byref_MaskSize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_MaskSize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupProperties_Internal_Static_Void_RasterCommandBuffer_MaskSize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Public_Static_GraphicsFormat_MaskSize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToValidRenderingLayers_Public_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaskSize_Private_Static_MaskSize_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBits_Private_Static_Int32_MaskSize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Private_Static_Event_Event_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Private_Static_MaskSize_MaskSize_MaskSize_0;

	static RenderingLayerUtils()
	{
		Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderingLayerUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr);
		NativeMethodInfoPtr_CombineRendererEvents_Public_Static_Void_Boolean_Int32_Event_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665295);
		NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRenderer_List_1_ScriptableRendererFeature_Int32_byref_Event_byref_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665296);
		NativeMethodInfoPtr_RequireRenderingLayers_Internal_Static_Boolean_List_1_ScriptableRendererFeature_RenderingMode_Boolean_Int32_byref_Event_byref_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665297);
		NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665298);
		NativeMethodInfoPtr_SetupProperties_Internal_Static_Void_RasterCommandBuffer_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665299);
		NativeMethodInfoPtr_GetFormat_Public_Static_GraphicsFormat_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665300);
		NativeMethodInfoPtr_ToValidRenderingLayers_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665301);
		NativeMethodInfoPtr_GetMaskSize_Private_Static_MaskSize_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665302);
		NativeMethodInfoPtr_GetBits_Private_Static_Int32_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665303);
		NativeMethodInfoPtr_Combine_Private_Static_Event_Event_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665304);
		NativeMethodInfoPtr_Combine_Private_Static_MaskSize_MaskSize_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerUtils>.NativeClassPtr, 100665305);
	}

	[CallerCount(0)]
	public unsafe static void CombineRendererEvents(bool isDeferred, int msaaSampleCount, Event rendererEvent, ref Event combinedEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&isDeferred);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSampleCount;
		*(Event**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rendererEvent;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref combinedEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineRendererEvents_Public_Static_Void_Boolean_Int32_Event_byref_Event_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1097783, RefRangeEnd = 1097785, XrefRangeStart = 1097780, XrefRangeEnd = 1097783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RequireRenderingLayers(UniversalRenderer universalRenderer, List<ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)universalRenderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererFeatures);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSampleCount;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref combinedEvent);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref combinedMaskSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequireRenderingLayers_Public_Static_Boolean_UniversalRenderer_List_1_ScriptableRendererFeature_Int32_byref_Event_byref_MaskSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1097815, RefRangeEnd = 1097816, XrefRangeStart = 1097785, XrefRangeEnd = 1097815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RequireRenderingLayers(List<ScriptableRendererFeature> rendererFeatures, RenderingMode renderingMode, bool accurateGbufferNormals, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererFeatures);
		*(RenderingMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderingMode;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &accurateGbufferNormals;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSampleCount;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref combinedEvent);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref combinedMaskSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequireRenderingLayers_Internal_Static_Boolean_List_1_ScriptableRendererFeature_RenderingMode_Boolean_Int32_byref_Event_byref_MaskSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1097836, RefRangeEnd = 1097837, XrefRangeStart = 1097816, XrefRangeEnd = 1097836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupProperties(CommandBuffer cmd, MaskSize maskSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(MaskSize**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_MaskSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1097853, RefRangeEnd = 1097855, XrefRangeStart = 1097837, XrefRangeEnd = 1097853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupProperties(RasterCommandBuffer cmd, MaskSize maskSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(MaskSize**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupProperties_Internal_Static_Void_RasterCommandBuffer_MaskSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1097855, RefRangeEnd = 1097857, XrefRangeStart = 1097855, XrefRangeEnd = 1097855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetFormat(MaskSize maskSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maskSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormat_Public_Static_GraphicsFormat_MaskSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1097868, RefRangeEnd = 1097876, XrefRangeStart = 1097857, XrefRangeEnd = 1097868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToValidRenderingLayers(uint renderingLayers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderingLayers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToValidRenderingLayers_Public_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static MaskSize GetMaskSize(int bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaskSize_Private_Static_MaskSize_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MaskSize*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetBits(MaskSize maskSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maskSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBits_Private_Static_Int32_MaskSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Event Combine(Event a, Event b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Event**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Static_Event_Event_Event_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Event*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static MaskSize Combine(MaskSize a, MaskSize b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(MaskSize**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Static_MaskSize_MaskSize_MaskSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MaskSize*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RenderingLayerUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
