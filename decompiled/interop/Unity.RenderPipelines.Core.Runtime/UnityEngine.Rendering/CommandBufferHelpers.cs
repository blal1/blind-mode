using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.VFX;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CommandBufferHelpers
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rasterCmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_computeCmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_unsafeCmd;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRasterCommandBuffer_Public_Static_RasterCommandBuffer_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeCommandBuffer_Public_Static_ComputeCommandBuffer_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnsafeCommandBuffer_Public_Static_UnsafeCommandBuffer_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeCommandBuffer_Public_Static_CommandBuffer_UnsafeCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VFXManager_ProcessCameraCommand_Public_Static_Void_Camera_UnsafeCommandBuffer_VFXCameraXRSettings_CullingResults_0;

	public unsafe static RasterCommandBuffer rasterCmd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rasterCmd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterCommandBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rasterCmd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ComputeCommandBuffer computeCmd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_computeCmd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeCommandBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_computeCmd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UnsafeCommandBuffer unsafeCmd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unsafeCmd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnsafeCommandBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unsafeCmd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CommandBufferHelpers()
	{
		Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CommandBufferHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr);
		NativeFieldInfoPtr_rasterCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, "rasterCmd");
		NativeFieldInfoPtr_computeCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, "computeCmd");
		NativeFieldInfoPtr_unsafeCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, "unsafeCmd");
		NativeMethodInfoPtr_GetRasterCommandBuffer_Public_Static_RasterCommandBuffer_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_GetComputeCommandBuffer_Public_Static_ComputeCommandBuffer_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_GetUnsafeCommandBuffer_Public_Static_UnsafeCommandBuffer_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_GetNativeCommandBuffer_Public_Static_CommandBuffer_UnsafeCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_VFXManager_ProcessCameraCommand_Public_Static_Void_Camera_UnsafeCommandBuffer_VFXCameraXRSettings_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, 100663501);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026717, XrefRangeEnd = 1026723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RasterCommandBuffer GetRasterCommandBuffer(CommandBuffer baseBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRasterCommandBuffer_Public_Static_RasterCommandBuffer_CommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterCommandBuffer>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026723, XrefRangeEnd = 1026729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ComputeCommandBuffer GetComputeCommandBuffer(CommandBuffer baseBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComputeCommandBuffer_Public_Static_ComputeCommandBuffer_CommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeCommandBuffer>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026729, XrefRangeEnd = 1026735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnsafeCommandBuffer GetUnsafeCommandBuffer(CommandBuffer baseBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnsafeCommandBuffer_Public_Static_UnsafeCommandBuffer_CommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnsafeCommandBuffer>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static CommandBuffer GetNativeCommandBuffer(UnsafeCommandBuffer baseBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNativeCommandBuffer_Public_Static_CommandBuffer_UnsafeCommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1026739, RefRangeEnd = 1026740, XrefRangeStart = 1026735, XrefRangeEnd = 1026739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void VFXManager_ProcessCameraCommand(Camera cam, UnsafeCommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(VFXCameraXRSettings**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &camXRSettings;
		*(CullingResults**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &results;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VFXManager_ProcessCameraCommand_Public_Static_Void_Camera_UnsafeCommandBuffer_VFXCameraXRSettings_CullingResults_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandBufferHelpers>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
