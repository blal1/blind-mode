using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Security;

[OriginalName("System.dll", "System.Net.Security", "SslPolicyErrors")]
[System.Flags]
public enum SslPolicyErrors
{
	None = 0,
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4
}
