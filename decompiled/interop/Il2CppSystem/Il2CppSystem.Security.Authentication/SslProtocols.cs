using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Authentication;

[OriginalName("System.dll", "System.Security.Authentication", "SslProtocols")]
[System.Flags]
public enum SslProtocols
{
	None = 0,
	Ssl2 = 0xC,
	Ssl3 = 0x30,
	Tls = 0xC0,
	Tls11 = 0x300,
	Tls12 = 0xC00,
	Tls13 = 0x3000,
	Default = 0xF0
}
