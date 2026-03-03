using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.ParticleSystemJobs;

[StructLayout(LayoutKind.Explicit)]
public struct NativeListData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_system;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_capacity;

	[FieldOffset(0)]
	public System.IntPtr system;

	[FieldOffset(8)]
	public int length;

	[FieldOffset(12)]
	public int capacity;

	static NativeListData()
	{
		Il2CppClassPointerStore<NativeListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine.ParticleSystemJobs", "NativeListData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeListData>.NativeClassPtr);
		NativeFieldInfoPtr_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeListData>.NativeClassPtr, "system");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeListData>.NativeClassPtr, "length");
		NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeListData>.NativeClassPtr, "capacity");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeListData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
