using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.X509;

[Serializable]
[OriginalName("Mono.Security.dll", "Mono.Security.X509", "X509ChainStatusFlags")]
[Flags]
public enum X509ChainStatusFlags
{
	InvalidBasicConstraints = 0x400,
	NoError = 0,
	NotSignatureValid = 8,
	NotTimeNested = 2,
	NotTimeValid = 1,
	PartialChain = 0x10000,
	UntrustedRoot = 0x20
}
