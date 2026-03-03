using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

[System.Serializable]
public class Header : Object
{
	static Header()
	{
		Il2CppClassPointerStore<Header>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "Header");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Header>.NativeClassPtr);
	}

	public Header(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
