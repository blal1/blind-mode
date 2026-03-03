using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.NetworkInformation;

[OriginalName("System.dll", "System.Net.NetworkInformation", "OperationalStatus")]
public enum OperationalStatus
{
	Up = 1,
	Down,
	Testing,
	Unknown,
	Dormant,
	NotPresent,
	LowerLayerDown
}
