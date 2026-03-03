using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

public static class Timeout : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InfiniteTimeSpan;

	public unsafe static TimeSpan InfiniteTimeSpan
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&value));
		}
	}

	static Timeout()
	{
		Il2CppClassPointerStore<Timeout>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Timeout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timeout>.NativeClassPtr);
		NativeFieldInfoPtr_InfiniteTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timeout>.NativeClassPtr, "InfiniteTimeSpan");
	}

	public Timeout(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
