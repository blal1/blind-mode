using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Interface;

[OriginalName("Mono.Security.dll", "Mono.Security.Interface", "MonoSslPolicyErrors")]
[Flags]
public enum MonoSslPolicyErrors
{
	None = 0,
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4
}
