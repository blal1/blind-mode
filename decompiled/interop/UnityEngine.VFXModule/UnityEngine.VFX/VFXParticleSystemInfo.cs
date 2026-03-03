using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX;

[StructLayout(LayoutKind.Explicit)]
public struct VFXParticleSystemInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_aliveCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_capacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleeping;

	private static readonly System.IntPtr NativeFieldInfoPtr_bounds;

	[FieldOffset(0)]
	public uint aliveCount;

	[FieldOffset(4)]
	public uint capacity;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool sleeping;

	[FieldOffset(12)]
	public Bounds bounds;

	static VFXParticleSystemInfo()
	{
		Il2CppClassPointerStore<VFXParticleSystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXParticleSystemInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXParticleSystemInfo>.NativeClassPtr);
		NativeFieldInfoPtr_aliveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXParticleSystemInfo>.NativeClassPtr, "aliveCount");
		NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXParticleSystemInfo>.NativeClassPtr, "capacity");
		NativeFieldInfoPtr_sleeping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXParticleSystemInfo>.NativeClassPtr, "sleeping");
		NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXParticleSystemInfo>.NativeClassPtr, "bounds");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXParticleSystemInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
