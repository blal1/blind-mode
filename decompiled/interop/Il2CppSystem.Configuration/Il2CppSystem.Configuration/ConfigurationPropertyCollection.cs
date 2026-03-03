using System;
using System.Reflection;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Configuration;

[DefaultMember("Item")]
public class ConfigurationPropertyCollection : Object
{
	static ConfigurationPropertyCollection()
	{
		Il2CppClassPointerStore<ConfigurationPropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationPropertyCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationPropertyCollection>.NativeClassPtr);
	}

	public ConfigurationPropertyCollection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
