using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe;

public sealed class NativeContainerNeedsThreadIndexAttribute : Il2CppSystem.Attribute
{
	static NativeContainerNeedsThreadIndexAttribute()
	{
		Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerNeedsThreadIndexAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr);
	}

	public NativeContainerNeedsThreadIndexAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
