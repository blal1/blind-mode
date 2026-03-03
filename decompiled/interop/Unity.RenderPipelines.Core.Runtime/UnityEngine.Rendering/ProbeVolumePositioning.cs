using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class ProbeVolumePositioning : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Axes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AABBCorners;

	private static readonly System.IntPtr NativeMethodInfoPtr_OBBIntersect_Public_Static_Boolean_byref_Volume_byref_Volume_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OBBContains_Public_Static_Boolean_byref_Volume_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OBBAABBIntersect_Public_Static_Boolean_byref_Volume_byref_Bounds_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProjectOBB_Private_Static_Vector2_byref_Volume_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProjectAABB_Private_Static_Vector2_byref_Il2CppStructArray_1_Vector3_Vector3_0;

	public unsafe static Il2CppStructArray<Vector3> m_Axes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Axes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Axes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Vector3> m_AABBCorners
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_AABBCorners, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_AABBCorners, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ProbeVolumePositioning()
	{
		Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumePositioning");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr);
		NativeFieldInfoPtr_m_Axes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr, "m_Axes");
		NativeFieldInfoPtr_m_AABBCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr, "m_AABBCorners");
		NativeMethodInfoPtr_OBBIntersect_Public_Static_Boolean_byref_Volume_byref_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr, 100665850);
		NativeMethodInfoPtr_OBBContains_Public_Static_Boolean_byref_Volume_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr, 100665851);
		NativeMethodInfoPtr_OBBAABBIntersect_Public_Static_Boolean_byref_Volume_byref_Bounds_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr, 100665852);
		NativeMethodInfoPtr_ProjectOBB_Private_Static_Vector2_byref_Volume_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr, 100665853);
		NativeMethodInfoPtr_ProjectAABB_Private_Static_Vector2_byref_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePositioning>.NativeClassPtr, 100665854);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045094, XrefRangeEnd = 1045121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OBBIntersect([In] ref ProbeReferenceVolume.Volume a, [In] ref ProbeReferenceVolume.Volume b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref a);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OBBIntersect_Public_Static_Boolean_byref_Volume_byref_Volume_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045121, XrefRangeEnd = 1045122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OBBContains([In] ref ProbeReferenceVolume.Volume obb, Vector3 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref obb);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OBBContains_Public_Static_Boolean_byref_Volume_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045144, RefRangeEnd = 1045145, XrefRangeStart = 1045122, XrefRangeEnd = 1045144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OBBAABBIntersect([In] ref ProbeReferenceVolume.Volume a, [In] ref Bounds b, [In] ref Bounds aAABB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref a);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref b);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref aAABB);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OBBAABBIntersect_Public_Static_Boolean_byref_Volume_byref_Bounds_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1045146, RefRangeEnd = 1045149, XrefRangeStart = 1045145, XrefRangeEnd = 1045146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ProjectOBB([In] ref ProbeReferenceVolume.Volume a, Vector3 axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProjectOBB_Private_Static_Vector2_byref_Volume_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045149, XrefRangeEnd = 1045150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ProjectAABB([In] ref Il2CppStructArray<Vector3> corners, Vector3 axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)corners);
		*ptr = (nint)(&intPtr);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProjectAABB_Private_Static_Vector2_byref_Il2CppStructArray_1_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		corners = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3>(intPtr4));
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public ProbeVolumePositioning(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
