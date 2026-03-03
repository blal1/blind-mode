using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Btls;

[OriginalName("System.dll", "Mono.Btls", "MonoBtlsSslError")]
public enum MonoBtlsSslError
{
	None = 0,
	Ssl = 1,
	WantRead = 2,
	WantWrite = 3,
	WantX509Lookup = 4,
	Syscall = 5,
	ZeroReturn = 6,
	WantConnect = 7,
	WantAccept = 8,
	WantChannelIdLookup = 9,
	PendingSession = 11,
	PendingCertificate = 12,
	WantPrivateKeyOperation = 13
}
