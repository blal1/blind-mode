using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class OcclusionTestMethods : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetBatchLayerMask_Public_Static_UInt32_OcclusionTest_0;

	static OcclusionTestMethods()
	{
		Il2CppClassPointerStore<OcclusionTestMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OcclusionTestMethods");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionTestMethods>.NativeClassPtr);
		NativeMethodInfoPtr_GetBatchLayerMask_Public_Static_UInt32_OcclusionTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionTestMethods>.NativeClassPtr, 100663534);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069237, RefRangeEnd = 1069239, XrefRangeStart = 1069237, XrefRangeEnd = 1069237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetBatchLayerMask(this OcclusionTest occlusionTest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&occlusionTest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBatchLayerMask_Public_Static_UInt32_OcclusionTest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public OcclusionTestMethods(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
