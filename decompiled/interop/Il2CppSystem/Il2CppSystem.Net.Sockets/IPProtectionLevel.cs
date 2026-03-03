using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets;

[OriginalName("System.dll", "System.Net.Sockets", "IPProtectionLevel")]
public enum IPProtectionLevel
{
	Unspecified = -1,
	Unrestricted = 10,
	EdgeRestricted = 20,
	Restricted = 30
}
