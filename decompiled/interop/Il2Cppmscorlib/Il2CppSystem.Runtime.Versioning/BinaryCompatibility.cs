using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Versioning;

public static class BinaryCompatibility : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5;

	private static readonly System.IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1;

	public unsafe static bool TargetsAtLeast_Desktop_V4_5
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&value));
		}
	}

	public unsafe static bool TargetsAtLeast_Desktop_V4_5_1
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&value));
		}
	}

	static BinaryCompatibility()
	{
		Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Versioning", "BinaryCompatibility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
		NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5");
		NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5_1");
	}

	public BinaryCompatibility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
