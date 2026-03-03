using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class GeometryUtility : Il2CppSystem.Object
{
	private delegate void Internal_CalculateBounds_InjectedDelegate(System.IntPtr positions, [In] System.IntPtr transform, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_byref_BlittableArrayWrapper_byref_Matrix4x4_0;

	private static readonly Internal_CalculateBounds_InjectedDelegate Internal_CalculateBounds_InjectedDelegateField;

	static GeometryUtility()
	{
		Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GeometryUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr);
		NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_byref_BlittableArrayWrapper_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664162);
		Internal_CalculateBounds_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CalculateBounds_InjectedDelegate>("UnityEngine.GeometryUtility::Internal_CalculateBounds_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1171282, RefRangeEnd = 1171283, XrefRangeStart = 1171272, XrefRangeEnd = 1171282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateFrustumPlanes(Camera camera, Il2CppStructArray<Plane> planes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)planes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1171284, RefRangeEnd = 1171285, XrefRangeStart = 1171283, XrefRangeEnd = 1171284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Il2CppStructArray<Plane> planes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&worldToProjectionMatrix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)planes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1171294, RefRangeEnd = 1171296, XrefRangeStart = 1171285, XrefRangeEnd = 1171294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TestPlanesAABB(Il2CppStructArray<Plane> planes, Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)planes);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bounds;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1171302, RefRangeEnd = 1171304, XrefRangeStart = 1171296, XrefRangeEnd = 1171302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ExtractPlanes([Out] Il2CppStructArray<Plane> planes, Matrix4x4 worldToProjectionMatrix)
	{
		//IL_0045: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldToProjectionMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)planes, (num2 == 0) ? null : new Il2CppStructArray<Plane>((System.IntPtr)num2));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171304, XrefRangeEnd = 1171306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TestPlanesAABB_Injected(ref ManagedSpanWrapper planes, [In] ref Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref planes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171306, XrefRangeEnd = 1171308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ExtractPlanes_Injected(out BlittableArrayWrapper planes, [In] ref Matrix4x4 worldToProjectionMatrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref planes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref worldToProjectionMatrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_byref_BlittableArrayWrapper_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GeometryUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Camera camera)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Bounds CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
	{
		if (positions == null)
		{
			throw new Il2CppSystem.ArgumentNullException("positions");
		}
		if (((Il2CppArrayBase)positions).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("Zero-sized array is not allowed.", "positions");
		}
		return Internal_CalculateBounds(positions, transform);
	}

	public static bool TryCreatePlaneFromPolygon(Il2CppStructArray<Vector3> vertices, out Plane plane)
	{
		if (vertices == null || ((Il2CppArrayBase)vertices).Length < 3)
		{
			plane = new Plane(Vector3.up, 0f);
			return false;
		}
		if (((Il2CppArrayBase)vertices).Length == 3)
		{
			Vector3 a = ((Il2CppArrayBase<Vector3>)(object)vertices)[0];
			Vector3 b = ((Il2CppArrayBase<Vector3>)(object)vertices)[1];
			Vector3 c = ((Il2CppArrayBase<Vector3>)(object)vertices)[2];
			plane = new Plane(a, b, c);
			return plane.normal.sqrMagnitude > 0f;
		}
		Vector3 zero = Vector3.zero;
		int num = ((Il2CppArrayBase)vertices).Length - 1;
		Vector3 vector = ((Il2CppArrayBase<Vector3>)(object)vertices)[num];
		for (int i = 0; i < ((Il2CppArrayBase)vertices).Length; i++)
		{
			Vector3 vector2 = ((Il2CppArrayBase<Vector3>)(object)vertices)[i];
			zero.x += (vector.y - vector2.y) * (vector.z + vector2.z);
			zero.y += (vector.z - vector2.z) * (vector.x + vector2.x);
			zero.z += (vector.x - vector2.x) * (vector.y + vector2.y);
			vector = vector2;
		}
		zero.Normalize();
		float num2 = 0f;
		for (int j = 0; j < ((Il2CppArrayBase)vertices).Length; j++)
		{
			Vector3 rhs = ((Il2CppArrayBase<Vector3>)(object)vertices)[j];
			num2 -= Vector3.Dot(zero, rhs);
		}
		num2 /= (float)((Il2CppArrayBase)vertices).Length;
		plane = new Plane(zero, num2);
		return plane.normal.sqrMagnitude > 0f;
	}

	public unsafe static Bounds Internal_CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector3> span);
		((Il2CppSystem.Span<Vector3>)(&span))._002Ector((Il2CppArrayBase<Vector3>)(object)positions);
		Bounds ret;
		fixed (Vector3* begin = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper positions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
			Internal_CalculateBounds_Injected(ref positions2, ref transform, out ret);
		}
		return ret;
	}

	public unsafe static void Internal_CalculateBounds_Injected(ref ManagedSpanWrapper positions, [In] ref Matrix4x4 transform, out Bounds ret)
	{
		Internal_CalculateBounds_InjectedDelegateField((nint)Unsafe.AsPointer(ref positions), (nint)Unsafe.AsPointer(ref transform), (nint)Unsafe.AsPointer(ref ret));
	}
}
