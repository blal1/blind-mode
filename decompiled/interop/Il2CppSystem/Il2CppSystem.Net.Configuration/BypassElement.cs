using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration;

public sealed class BypassElement : ConfigurationElement
{
	static BypassElement()
	{
		Il2CppClassPointerStore<BypassElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "BypassElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassElement>.NativeClassPtr);
	}

	public BypassElement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
