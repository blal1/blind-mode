using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration;

public sealed class ConnectionManagementElement : ConfigurationElement
{
	static ConnectionManagementElement()
	{
		Il2CppClassPointerStore<ConnectionManagementElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementElement>.NativeClassPtr);
	}

	public ConnectionManagementElement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
