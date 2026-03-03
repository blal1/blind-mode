using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit;

public class EventBuilder : Object
{
	static EventBuilder()
	{
		Il2CppClassPointerStore<EventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "EventBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventBuilder>.NativeClassPtr);
	}

	public EventBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
