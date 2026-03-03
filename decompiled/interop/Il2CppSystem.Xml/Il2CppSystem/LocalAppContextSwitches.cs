using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

public static class LocalAppContextSwitches : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreEmptyKeySequences;

	public unsafe static bool IgnoreEmptyKeySequences
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IgnoreEmptyKeySequences, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IgnoreEmptyKeySequences, (void*)(&value));
		}
	}

	static LocalAppContextSwitches()
	{
		Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System", "LocalAppContextSwitches");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr);
		NativeFieldInfoPtr_IgnoreEmptyKeySequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, "IgnoreEmptyKeySequences");
	}

	public LocalAppContextSwitches(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
