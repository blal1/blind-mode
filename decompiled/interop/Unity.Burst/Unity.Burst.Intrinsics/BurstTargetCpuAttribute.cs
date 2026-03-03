using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics;

public sealed class BurstTargetCpuAttribute : Il2CppSystem.Attribute
{
	static BurstTargetCpuAttribute()
	{
		Il2CppClassPointerStore<BurstTargetCpuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "BurstTargetCpuAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstTargetCpuAttribute>.NativeClassPtr);
	}

	public BurstTargetCpuAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
