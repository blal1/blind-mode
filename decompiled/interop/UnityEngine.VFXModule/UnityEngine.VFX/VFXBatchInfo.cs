using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX;

[StructLayout(LayoutKind.Explicit)]
public struct VFXBatchInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_capacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInstanceCount;

	[FieldOffset(0)]
	public uint capacity;

	[FieldOffset(4)]
	public uint activeInstanceCount;

	static VFXBatchInfo()
	{
		Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXBatchInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr);
		NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr, "capacity");
		NativeFieldInfoPtr_activeInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr, "activeInstanceCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
