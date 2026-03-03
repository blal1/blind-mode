using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct FrustumPlanes
{
	private static readonly System.IntPtr NativeFieldInfoPtr_left;

	private static readonly System.IntPtr NativeFieldInfoPtr_right;

	private static readonly System.IntPtr NativeFieldInfoPtr_bottom;

	private static readonly System.IntPtr NativeFieldInfoPtr_top;

	private static readonly System.IntPtr NativeFieldInfoPtr_zNear;

	private static readonly System.IntPtr NativeFieldInfoPtr_zFar;

	[FieldOffset(0)]
	public float left;

	[FieldOffset(4)]
	public float right;

	[FieldOffset(8)]
	public float bottom;

	[FieldOffset(12)]
	public float top;

	[FieldOffset(16)]
	public float zNear;

	[FieldOffset(20)]
	public float zFar;

	static FrustumPlanes()
	{
		Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrustumPlanes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr);
		NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "left");
		NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "right");
		NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "bottom");
		NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "top");
		NativeFieldInfoPtr_zNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zNear");
		NativeFieldInfoPtr_zFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zFar");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
