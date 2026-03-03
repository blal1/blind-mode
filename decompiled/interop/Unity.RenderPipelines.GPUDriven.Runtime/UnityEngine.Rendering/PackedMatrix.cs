using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct PackedMatrix
{
	private static readonly System.IntPtr NativeFieldInfoPtr_packed0;

	private static readonly System.IntPtr NativeFieldInfoPtr_packed1;

	private static readonly System.IntPtr NativeFieldInfoPtr_packed2;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromMatrix4x4_Public_Static_PackedMatrix_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromFloat4x4_Public_Static_PackedMatrix_byref_float4x4_0;

	[FieldOffset(0)]
	public float4 packed0;

	[FieldOffset(16)]
	public float4 packed1;

	[FieldOffset(32)]
	public float4 packed2;

	static PackedMatrix()
	{
		Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "PackedMatrix");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr);
		NativeFieldInfoPtr_packed0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr, "packed0");
		NativeFieldInfoPtr_packed1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr, "packed1");
		NativeFieldInfoPtr_packed2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr, "packed2");
		NativeMethodInfoPtr_FromMatrix4x4_Public_Static_PackedMatrix_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr, 100663812);
		NativeMethodInfoPtr_FromFloat4x4_Public_Static_PackedMatrix_byref_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr, 100663813);
	}

	[CallerCount(0)]
	public unsafe static PackedMatrix FromMatrix4x4([In] ref Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromMatrix4x4_Public_Static_PackedMatrix_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PackedMatrix*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PackedMatrix FromFloat4x4([In] ref float4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromFloat4x4_Public_Static_PackedMatrix_byref_float4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PackedMatrix*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PackedMatrix>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
