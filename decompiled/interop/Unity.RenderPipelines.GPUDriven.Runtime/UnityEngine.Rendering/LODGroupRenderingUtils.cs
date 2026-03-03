using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class LODGroupRenderingUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFOVHalfAngle_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateScreenRelativeMetric_Public_Static_Single_LODParameters_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSqrPerspectiveDistance_Public_Static_Single_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLODDistance_Public_Static_Single_Single_Single_0;

	static LODGroupRenderingUtils()
	{
		Il2CppClassPointerStore<LODGroupRenderingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "LODGroupRenderingUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODGroupRenderingUtils>.NativeClassPtr);
		NativeMethodInfoPtr_CalculateFOVHalfAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupRenderingUtils>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_CalculateScreenRelativeMetric_Public_Static_Single_LODParameters_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupRenderingUtils>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_CalculateSqrPerspectiveDistance_Public_Static_Single_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupRenderingUtils>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_CalculateLODDistance_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupRenderingUtils>.NativeClassPtr, 100663968);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074329, XrefRangeEnd = 1074330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalculateFOVHalfAngle(float fieldOfView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fieldOfView);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFOVHalfAngle_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074333, RefRangeEnd = 1074334, XrefRangeStart = 1074330, XrefRangeEnd = 1074333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalculateScreenRelativeMetric(LODParameters lodParams, float lodBias)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lodParams);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lodBias;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateScreenRelativeMetric_Public_Static_Single_LODParameters_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074334, RefRangeEnd = 1074336, XrefRangeStart = 1074334, XrefRangeEnd = 1074334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalculateSqrPerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&objPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camPosition;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sqrScreenRelativeMetric;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSqrPerspectiveDistance_Public_Static_Single_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074336, RefRangeEnd = 1074338, XrefRangeStart = 1074336, XrefRangeEnd = 1074336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalculateLODDistance(float relativeScreenHeight, float size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&relativeScreenHeight);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLODDistance_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LODGroupRenderingUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
