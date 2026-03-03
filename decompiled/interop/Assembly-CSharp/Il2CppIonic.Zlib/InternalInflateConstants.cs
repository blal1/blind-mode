using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public static class InternalInflateConstants : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InflateMask;

	public unsafe static Il2CppStructArray<int> InflateMask
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InflateMask, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InflateMask, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InternalInflateConstants()
	{
		Il2CppClassPointerStore<InternalInflateConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "InternalInflateConstants");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalInflateConstants>.NativeClassPtr);
		NativeFieldInfoPtr_InflateMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalInflateConstants>.NativeClassPtr, "InflateMask");
	}

	public InternalInflateConstants(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
