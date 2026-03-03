using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem;

public static class KeyEx : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IMESelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemappedIMESelected;

	public unsafe static Key IMESelected
	{
		get
		{
			Unsafe.SkipInit(out Key result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IMESelected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IMESelected, (void*)(&value));
		}
	}

	public unsafe static Key RemappedIMESelected
	{
		get
		{
			Unsafe.SkipInit(out Key result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RemappedIMESelected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RemappedIMESelected, (void*)(&value));
		}
	}

	static KeyEx()
	{
		Il2CppClassPointerStore<KeyEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "KeyEx");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyEx>.NativeClassPtr);
		NativeFieldInfoPtr_IMESelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyEx>.NativeClassPtr, "IMESelected");
		NativeFieldInfoPtr_RemappedIMESelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyEx>.NativeClassPtr, "RemappedIMESelected");
	}

	public KeyEx(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
