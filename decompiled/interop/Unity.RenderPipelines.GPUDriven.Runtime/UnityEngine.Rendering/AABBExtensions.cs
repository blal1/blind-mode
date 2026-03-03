using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class AABBExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ToAABB_Public_Static_AABB_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBounds_Public_Static_Bounds_AABB_0;

	static AABBExtensions()
	{
		Il2CppClassPointerStore<AABBExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "AABBExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AABBExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_ToAABB_Public_Static_AABB_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABBExtensions>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_ToBounds_Public_Static_Bounds_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABBExtensions>.NativeClassPtr, 100663305);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1066474, RefRangeEnd = 1066475, XrefRangeStart = 1066472, XrefRangeEnd = 1066474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AABB ToAABB(this Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAABB_Public_Static_AABB_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AABB*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066475, XrefRangeEnd = 1066477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds ToBounds(this AABB aabb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aabb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBounds_Public_Static_Bounds_AABB_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AABBExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
