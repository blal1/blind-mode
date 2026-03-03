using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Protocol.Ntlm;

[OriginalName("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmFlags")]
[Flags]
public enum NtlmFlags
{
	NegotiateUnicode = 1,
	NegotiateOem = 2,
	RequestTarget = 4,
	NegotiateNtlm = 0x200,
	NegotiateDomainSupplied = 0x1000,
	NegotiateWorkstationSupplied = 0x2000,
	NegotiateAlwaysSign = 0x8000,
	NegotiateNtlm2Key = 0x80000,
	Negotiate128 = 0x20000000,
	Negotiate56 = int.MinValue
}
