using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct OccluderHandles
{
	private static readonly System.IntPtr NativeFieldInfoPtr_occluderDepthPyramid;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionDebugOverlay;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseForOcclusionTest_Public_Void_IBaseRenderGraphBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseForOccluderUpdate_Public_Void_IBaseRenderGraphBuilder_0;

	[FieldOffset(0)]
	public TextureHandle occluderDepthPyramid;

	[FieldOffset(16)]
	public BufferHandle occlusionDebugOverlay;

	static OccluderHandles()
	{
		Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OccluderHandles");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr);
		NativeFieldInfoPtr_occluderDepthPyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr, "occluderDepthPyramid");
		NativeFieldInfoPtr_occlusionDebugOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr, "occlusionDebugOverlay");
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_UseForOcclusionTest_Public_Void_IBaseRenderGraphBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr, 100663891);
		NativeMethodInfoPtr_UseForOccluderUpdate_Public_Void_IBaseRenderGraphBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr, 100663892);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073639, RefRangeEnd = 1073640, XrefRangeStart = 1073635, XrefRangeEnd = 1073639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073649, RefRangeEnd = 1073650, XrefRangeStart = 1073640, XrefRangeEnd = 1073649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseForOcclusionTest(IBaseRenderGraphBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseForOcclusionTest_Public_Void_IBaseRenderGraphBuilder_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073650, XrefRangeEnd = 1073659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseForOccluderUpdate(IBaseRenderGraphBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseForOccluderUpdate_Public_Void_IBaseRenderGraphBuilder_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OccluderHandles>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
