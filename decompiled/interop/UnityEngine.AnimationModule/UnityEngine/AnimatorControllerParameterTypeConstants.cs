using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class AnimatorControllerParameterTypeConstants : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidType;

	public unsafe static int InvalidType
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidType, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidType, (void*)(&value));
		}
	}

	static AnimatorControllerParameterTypeConstants()
	{
		Il2CppClassPointerStore<AnimatorControllerParameterTypeConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorControllerParameterTypeConstants");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorControllerParameterTypeConstants>.NativeClassPtr);
		NativeFieldInfoPtr_InvalidType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerParameterTypeConstants>.NativeClassPtr, "InvalidType");
	}

	public AnimatorControllerParameterTypeConstants(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
