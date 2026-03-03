using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct AABB
{
	private static readonly System.IntPtr NativeFieldInfoPtr_center;

	private static readonly System.IntPtr NativeFieldInfoPtr_extents;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_min_Public_get_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_max_Public_get_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateExtents_Private_Static_float3_float3_float3_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Transform_Public_Static_AABB_float4x4_AABB_0;

	[FieldOffset(0)]
	public float3 center;

	[FieldOffset(12)]
	public float3 extents;

	public unsafe float3 min
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066460, RefRangeEnd = 1066461, XrefRangeStart = 1066460, XrefRangeEnd = 1066460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_min_Public_get_float3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float3 max
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066461, RefRangeEnd = 1066462, XrefRangeStart = 1066461, XrefRangeEnd = 1066461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_max_Public_get_float3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AABB()
	{
		Il2CppClassPointerStore<AABB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "AABB");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AABB>.NativeClassPtr);
		NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AABB>.NativeClassPtr, "center");
		NativeFieldInfoPtr_extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AABB>.NativeClassPtr, "extents");
		NativeMethodInfoPtr_get_min_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_get_max_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_RotateExtents_Private_Static_float3_float3_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_Transform_Public_Static_AABB_float4x4_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100663303);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066462, XrefRangeEnd = 1066470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 RotateExtents(float3 extents, float3 m0, float3 m1, float3 m2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&extents);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &m0;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &m1;
		*(float3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &m2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateExtents_Private_Static_float3_float3_float3_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1066470, RefRangeEnd = 1066472, XrefRangeStart = 1066470, XrefRangeEnd = 1066470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AABB Transform(float4x4 transform, AABB localBounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&transform);
		*(AABB**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localBounds;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Transform_Public_Static_AABB_float4x4_AABB_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AABB*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AABB>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
