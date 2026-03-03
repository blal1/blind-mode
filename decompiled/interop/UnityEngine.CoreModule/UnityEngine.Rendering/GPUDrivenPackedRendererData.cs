using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenPackedRendererData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_staticShadowCaster_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lodMask_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightProbeUsage_Public_get_LightProbeUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_motionVecGenMode_Public_get_MotionVectorGenerationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPartOfStaticBatch_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasTree_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_smallMeshCulling_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[FieldOffset(0)]
	public uint data;

	public unsafe bool staticShadowCaster
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_staticShadowCaster_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe byte lodMask
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237820, RefRangeEnd = 1237822, XrefRangeStart = 1237820, XrefRangeEnd = 1237820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lodMask_Public_get_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ShadowCastingMode shadowCastingMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237822, RefRangeEnd = 1237823, XrefRangeStart = 1237822, XrefRangeEnd = 1237822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ShadowCastingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe LightProbeUsage lightProbeUsage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237823, RefRangeEnd = 1237824, XrefRangeStart = 1237823, XrefRangeEnd = 1237823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightProbeUsage_Public_get_LightProbeUsage_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightProbeUsage*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe MotionVectorGenerationMode motionVecGenMode
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionVecGenMode_Public_get_MotionVectorGenerationMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MotionVectorGenerationMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isPartOfStaticBatch
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237824, RefRangeEnd = 1237825, XrefRangeStart = 1237824, XrefRangeEnd = 1237824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPartOfStaticBatch_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasTree
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237825, RefRangeEnd = 1237826, XrefRangeStart = 1237825, XrefRangeEnd = 1237825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasTree_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool smallMeshCulling
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237826, RefRangeEnd = 1237827, XrefRangeStart = 1237826, XrefRangeEnd = 1237826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_smallMeshCulling_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public bool receiveShadows => (data & 1) != 0;

	public bool movedCurrentFrame => (data & 0x40000) != 0;

	public bool supportsIndirect => (data & 0x200000) != 0;

	static GPUDrivenPackedRendererData()
	{
		Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenPackedRendererData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr);
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, "data");
		NativeMethodInfoPtr_get_staticShadowCaster_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668393);
		NativeMethodInfoPtr_get_lodMask_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668394);
		NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668395);
		NativeMethodInfoPtr_get_lightProbeUsage_Public_get_LightProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668396);
		NativeMethodInfoPtr_get_motionVecGenMode_Public_get_MotionVectorGenerationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668397);
		NativeMethodInfoPtr_get_isPartOfStaticBatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668398);
		NativeMethodInfoPtr_get_hasTree_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668399);
		NativeMethodInfoPtr_get_smallMeshCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668400);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100668401);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713915, RefRangeEnd = 713916, XrefRangeStart = 713915, XrefRangeEnd = 713916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUDrivenPackedRendererData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
