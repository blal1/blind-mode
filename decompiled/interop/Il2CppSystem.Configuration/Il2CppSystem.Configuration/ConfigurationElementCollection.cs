using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Configuration;

public class ConfigurationElementCollection : ConfigurationElement
{
	static ConfigurationElementCollection()
	{
		Il2CppClassPointerStore<ConfigurationElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationElementCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationElementCollection>.NativeClassPtr);
	}

	public ConfigurationElementCollection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
