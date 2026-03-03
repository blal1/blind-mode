using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache;

public class RequestCache : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LineSplits;

	public unsafe static Il2CppStructArray<char> LineSplits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LineSplits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LineSplits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RequestCache()
	{
		Il2CppClassPointerStore<RequestCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCache>.NativeClassPtr);
		NativeFieldInfoPtr_LineSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCache>.NativeClassPtr, "LineSplits");
	}

	public RequestCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
