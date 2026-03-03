using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageFlags")]
[System.Flags]
public enum X509KeyUsageFlags
{
	None = 0,
	EncipherOnly = 1,
	CrlSign = 2,
	KeyCertSign = 4,
	KeyAgreement = 8,
	DataEncipherment = 0x10,
	KeyEncipherment = 0x20,
	NonRepudiation = 0x40,
	DigitalSignature = 0x80,
	DecipherOnly = 0x8000
}
