using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.Internal;

public static class NormalReconstruction : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_NormalReconstructionMatrixID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_NormalReconstructionMatrix;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupProperties_Public_Static_Void_RasterCommandBuffer_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupProperties_Public_Static_Void_RasterCommandBuffer_byref_UniversalCameraData_0;

	public unsafe static int s_NormalReconstructionMatrixID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NormalReconstructionMatrixID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NormalReconstructionMatrixID, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_NormalReconstructionMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NormalReconstructionMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NormalReconstructionMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static NormalReconstruction()
	{
		Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "NormalReconstruction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr);
		NativeFieldInfoPtr_s_NormalReconstructionMatrixID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, "s_NormalReconstructionMatrixID");
		NativeFieldInfoPtr_s_NormalReconstructionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, "s_NormalReconstructionMatrix");
		NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, 100666297);
		NativeMethodInfoPtr_SetupProperties_Public_Static_Void_RasterCommandBuffer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, 100666298);
		NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, 100666299);
		NativeMethodInfoPtr_SetupProperties_Public_Static_Void_RasterCommandBuffer_byref_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, 100666300);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110702, XrefRangeEnd = 1110714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupProperties(CommandBuffer cmd, [In] ref CameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_byref_CameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110714, XrefRangeEnd = 1110719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupProperties(RasterCommandBuffer cmd, [In] ref CameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupProperties_Public_Static_Void_RasterCommandBuffer_byref_CameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110719, XrefRangeEnd = 1110727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupProperties(CommandBuffer cmd, UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1110744, RefRangeEnd = 1110749, XrefRangeStart = 1110727, XrefRangeEnd = 1110744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupProperties(RasterCommandBuffer cmd, [In] ref UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupProperties_Public_Static_Void_RasterCommandBuffer_byref_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		cameraData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalCameraData(intPtr4));
	}

	public NormalReconstruction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
