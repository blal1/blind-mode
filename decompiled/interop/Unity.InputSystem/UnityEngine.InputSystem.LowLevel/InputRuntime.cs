using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.LowLevel;

public static class InputRuntime : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentTimeOffsetToRealtimeSinceStartup;

	public unsafe static IInputRuntime s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInputRuntime>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static double s_CurrentTimeOffsetToRealtimeSinceStartup
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentTimeOffsetToRealtimeSinceStartup, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentTimeOffsetToRealtimeSinceStartup, (void*)(&value));
		}
	}

	static InputRuntime()
	{
		Il2CppClassPointerStore<InputRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputRuntime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRuntime>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRuntime>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_s_CurrentTimeOffsetToRealtimeSinceStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRuntime>.NativeClassPtr, "s_CurrentTimeOffsetToRealtimeSinceStartup");
	}

	public InputRuntime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
