using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RenderersBatchersContextDesc
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceNumInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportDitheringCrossFade;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableBoundingSpheresInstanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallMeshScreenPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCullerDebugStats;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewDefault_Public_Static_RenderersBatchersContextDesc_0;

	[FieldOffset(0)]
	public InstanceNumInfo instanceNumInfo;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool supportDitheringCrossFade;

	[FieldOffset(9)]
	[MarshalAs(UnmanagedType.U1)]
	public bool enableBoundingSpheresInstanceData;

	[FieldOffset(12)]
	public float smallMeshScreenPercentage;

	[FieldOffset(16)]
	[MarshalAs(UnmanagedType.U1)]
	public bool enableCullerDebugStats;

	static RenderersBatchersContextDesc()
	{
		Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "RenderersBatchersContextDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr);
		NativeFieldInfoPtr_instanceNumInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr, "instanceNumInfo");
		NativeFieldInfoPtr_supportDitheringCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr, "supportDitheringCrossFade");
		NativeFieldInfoPtr_enableBoundingSpheresInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr, "enableBoundingSpheresInstanceData");
		NativeFieldInfoPtr_smallMeshScreenPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr, "smallMeshScreenPercentage");
		NativeFieldInfoPtr_enableCullerDebugStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr, "enableCullerDebugStats");
		NativeMethodInfoPtr_NewDefault_Public_Static_RenderersBatchersContextDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr, 100664010);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075104, RefRangeEnd = 1075105, XrefRangeStart = 1075104, XrefRangeEnd = 1075104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderersBatchersContextDesc NewDefault()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewDefault_Public_Static_RenderersBatchersContextDesc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderersBatchersContextDesc*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderersBatchersContextDesc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
