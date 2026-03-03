using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class CameraExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetUniversalAdditionalCameraData_Public_Static_UniversalAdditionalCameraData_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVolumeFrameworkUpdateMode_Public_Static_VolumeFrameworkUpdateMode_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVolumeFrameworkUpdateMode_Public_Static_Void_Camera_VolumeFrameworkUpdateMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVolumeLayerMaskAndTrigger_Internal_Static_Void_Camera_UniversalAdditionalCameraData_byref_LayerMask_byref_Transform_0;

	static CameraExtensions()
	{
		Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CameraExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetUniversalAdditionalCameraData_Public_Static_UniversalAdditionalCameraData_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665646);
		NativeMethodInfoPtr_GetVolumeFrameworkUpdateMode_Public_Static_VolumeFrameworkUpdateMode_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665647);
		NativeMethodInfoPtr_SetVolumeFrameworkUpdateMode_Public_Static_Void_Camera_VolumeFrameworkUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665648);
		NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665649);
		NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665650);
		NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665651);
		NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665652);
		NativeMethodInfoPtr_GetVolumeLayerMaskAndTrigger_Internal_Static_Void_Camera_UniversalAdditionalCameraData_byref_LayerMask_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665653);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1101388, RefRangeEnd = 1101394, XrefRangeStart = 1101381, XrefRangeEnd = 1101388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(this Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniversalAdditionalCameraData_Public_Static_UniversalAdditionalCameraData_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalAdditionalCameraData>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101394, XrefRangeEnd = 1101402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(this Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVolumeFrameworkUpdateMode_Public_Static_VolumeFrameworkUpdateMode_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VolumeFrameworkUpdateMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101402, XrefRangeEnd = 1101413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVolumeFrameworkUpdateMode(this Camera camera, VolumeFrameworkUpdateMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(VolumeFrameworkUpdateMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVolumeFrameworkUpdateMode_Public_Static_Void_Camera_VolumeFrameworkUpdateMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101413, XrefRangeEnd = 1101422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateVolumeStack(this Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1101435, RefRangeEnd = 1101438, XrefRangeStart = 1101422, XrefRangeEnd = 1101435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101438, XrefRangeEnd = 1101451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyVolumeStack(this Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101456, RefRangeEnd = 1101458, XrefRangeStart = 1101451, XrefRangeEnd = 1101456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101485, RefRangeEnd = 1101487, XrefRangeStart = 1101458, XrefRangeEnd = 1101485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVolumeLayerMaskAndTrigger(this Camera camera, UniversalAdditionalCameraData cameraData, out LayerMask layerMask, out Transform trigger)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref layerMask);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVolumeLayerMaskAndTrigger_Internal_Static_Void_Camera_UniversalAdditionalCameraData_byref_LayerMask_byref_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		trigger = ((num3 == 0) ? null : new Transform(num3));
	}

	public CameraExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
