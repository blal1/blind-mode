using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Btls;

[OriginalName("System.dll", "Mono.Btls", "MonoBtlsX509TrustKind")]
[Flags]
public enum MonoBtlsX509TrustKind
{
	DEFAULT = 0,
	TRUST_CLIENT = 1,
	TRUST_SERVER = 2,
	TRUST_ALL = 4,
	REJECT_CLIENT = 0x20,
	REJECT_SERVER = 0x40,
	REJECT_ALL = 0x80
}
