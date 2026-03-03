using Il2CppInterop.Common.Attributes;

namespace Il2CppMicrosoft.Win32;

[OriginalName("mscorlib.dll", "Microsoft.Win32", "RegistryHive")]
public enum RegistryHive
{
	ClassesRoot = int.MinValue,
	CurrentUser,
	LocalMachine,
	Users,
	PerformanceData,
	CurrentConfig,
	DynData
}
