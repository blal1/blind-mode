using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct Line
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m;

	private static readonly System.IntPtr NativeFieldInfoPtr_t;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineOfPlaneIntersectingPlane_Internal_Static_Line_float4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaneContainingLineAndPoint_Internal_Static_float4_Line_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaneContainingLineWithNormalPerpendicularToVector_Internal_Static_float4_Line_float3_0;

	[FieldOffset(0)]
	public float3 m;

	[FieldOffset(12)]
	public float3 t;

	static Line()
	{
		Il2CppClassPointerStore<Line>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "Line");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Line>.NativeClassPtr);
		NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Line>.NativeClassPtr, "m");
		NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Line>.NativeClassPtr, "t");
		NativeMethodInfoPtr_LineOfPlaneIntersectingPlane_Internal_Static_Line_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_PlaneContainingLineAndPoint_Internal_Static_float4_Line_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_PlaneContainingLineWithNormalPerpendicularToVector_Internal_Static_float4_Line_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100663412);
	}

	[CallerCount(0)]
	public unsafe static Line LineOfPlaneIntersectingPlane(float4 a, float4 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineOfPlaneIntersectingPlane_Internal_Static_Line_float4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Line*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 PlaneContainingLineAndPoint(Line a, float3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaneContainingLineAndPoint_Internal_Static_float4_Line_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 PlaneContainingLineWithNormalPerpendicularToVector(Line a, float3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaneContainingLineWithNormalPerpendicularToVector_Internal_Static_float4_Line_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Line>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
