using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct OcclusionCullingSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceMultiplier;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_OcclusionTest_0;

	[FieldOffset(0)]
	public int viewInstanceID;

	[FieldOffset(4)]
	public OcclusionTest occlusionTest;

	[FieldOffset(8)]
	public int instanceMultiplier;

	static OcclusionCullingSettings()
	{
		Il2CppClassPointerStore<OcclusionCullingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OcclusionCullingSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionCullingSettings>.NativeClassPtr);
		NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingSettings>.NativeClassPtr, "viewInstanceID");
		NativeFieldInfoPtr_occlusionTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingSettings>.NativeClassPtr, "occlusionTest");
		NativeFieldInfoPtr_instanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingSettings>.NativeClassPtr, "instanceMultiplier");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_OcclusionTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingSettings>.NativeClassPtr, 100663535);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069239, RefRangeEnd = 1069240, XrefRangeStart = 1069239, XrefRangeEnd = 1069239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OcclusionCullingSettings(int viewInstanceID, OcclusionTest occlusionTest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&viewInstanceID);
		*(OcclusionTest**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &occlusionTest;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_OcclusionTest_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OcclusionCullingSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
