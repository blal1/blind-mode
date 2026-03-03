using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Protocol.Ntlm;

[OriginalName("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmAuthLevel")]
public enum NtlmAuthLevel
{
	LM_and_NTLM,
	LM_and_NTLM_and_try_NTLMv2_Session,
	NTLM_only,
	NTLMv2_only
}
