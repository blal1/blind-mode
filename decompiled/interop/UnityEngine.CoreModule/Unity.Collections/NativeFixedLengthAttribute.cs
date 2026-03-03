using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections;

public sealed class NativeFixedLengthAttribute : Il2CppSystem.Attribute
{
	static NativeFixedLengthAttribute()
	{
		Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeFixedLengthAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr);
	}

	public NativeFixedLengthAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
