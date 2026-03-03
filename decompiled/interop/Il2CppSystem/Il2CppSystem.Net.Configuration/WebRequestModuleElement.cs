using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration;

public sealed class WebRequestModuleElement : ConfigurationElement
{
	static WebRequestModuleElement()
	{
		Il2CppClassPointerStore<WebRequestModuleElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebRequestModuleElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestModuleElement>.NativeClassPtr);
	}

	public WebRequestModuleElement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
