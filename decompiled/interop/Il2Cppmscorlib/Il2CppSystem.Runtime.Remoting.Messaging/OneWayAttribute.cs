using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

public class OneWayAttribute : Attribute
{
	static OneWayAttribute()
	{
		Il2CppClassPointerStore<OneWayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "OneWayAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneWayAttribute>.NativeClassPtr);
	}

	public OneWayAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
