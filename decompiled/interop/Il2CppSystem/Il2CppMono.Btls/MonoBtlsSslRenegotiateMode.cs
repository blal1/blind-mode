using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Btls;

[OriginalName("System.dll", "Mono.Btls", "MonoBtlsSslRenegotiateMode")]
[Flags]
public enum MonoBtlsSslRenegotiateMode
{
	NEVER = 0,
	ONCE = 1,
	FREELY = 2,
	IGNORE = 3
}
