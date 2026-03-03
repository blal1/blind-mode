using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

public static class CompatibilitySwitches : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8;

	public unsafe static bool IsAppEarlierThanWindowsPhone8
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&value));
		}
	}

	static CompatibilitySwitches()
	{
		Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CompatibilitySwitches");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr);
		NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr, "IsAppEarlierThanWindowsPhone8");
	}

	public CompatibilitySwitches(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
