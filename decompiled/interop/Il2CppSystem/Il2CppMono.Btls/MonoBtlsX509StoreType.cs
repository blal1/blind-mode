using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Btls;

[OriginalName("System.dll", "Mono.Btls", "MonoBtlsX509StoreType")]
public enum MonoBtlsX509StoreType
{
	Custom,
	MachineTrustedRoots,
	MachineIntermediateCA,
	MachineUntrusted,
	UserTrustedRoots,
	UserIntermediateCA,
	UserUntrusted
}
