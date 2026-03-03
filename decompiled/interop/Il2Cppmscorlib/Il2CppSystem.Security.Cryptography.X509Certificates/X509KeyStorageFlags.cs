using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

[OriginalName("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509KeyStorageFlags")]
[System.Flags]
public enum X509KeyStorageFlags
{
	DefaultKeySet = 0,
	UserKeySet = 1,
	MachineKeySet = 2,
	Exportable = 4,
	UserProtected = 8,
	PersistKeySet = 0x10,
	EphemeralKeySet = 0x20
}
