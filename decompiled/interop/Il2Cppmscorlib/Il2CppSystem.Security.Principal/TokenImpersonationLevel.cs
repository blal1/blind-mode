using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Principal;

[OriginalName("mscorlib.dll", "System.Security.Principal", "TokenImpersonationLevel")]
public enum TokenImpersonationLevel
{
	None,
	Anonymous,
	Identification,
	Impersonation,
	Delegation
}
