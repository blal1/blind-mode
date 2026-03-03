using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct TimeUpdate
{
	[StructLayout(LayoutKind.Explicit)]
	public struct WaitForLastPresentationAndUpdateTime
	{
		static WaitForLastPresentationAndUpdateTime()
		{
			Il2CppClassPointerStore<WaitForLastPresentationAndUpdateTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, "WaitForLastPresentationAndUpdateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForLastPresentationAndUpdateTime>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WaitForLastPresentationAndUpdateTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public struct ProfilerStartFrame
	{
	}

	static TimeUpdate()
	{
		Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "TimeUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
