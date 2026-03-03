using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net;

[OriginalName("System.dll", "System.Net", "SecurityProtocolType")]
[System.Flags]
public enum SecurityProtocolType
{
	SystemDefault = 0,
	Ssl3 = 0x30,
	Tls = 0xC0,
	Tls11 = 0x300,
	Tls12 = 0xC00,
	Tls13 = 0x3000
}
