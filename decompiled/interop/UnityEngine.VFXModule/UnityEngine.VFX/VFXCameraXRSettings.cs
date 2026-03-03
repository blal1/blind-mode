using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX;

[StructLayout(LayoutKind.Explicit)]
public struct VFXCameraXRSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewTotal;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewOffset;

	[FieldOffset(0)]
	public uint viewTotal;

	[FieldOffset(4)]
	public uint viewCount;

	[FieldOffset(8)]
	public uint viewOffset;

	static VFXCameraXRSettings()
	{
		Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXCameraXRSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr);
		NativeFieldInfoPtr_viewTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, "viewTotal");
		NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, "viewCount");
		NativeFieldInfoPtr_viewOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, "viewOffset");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXCameraXRSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
