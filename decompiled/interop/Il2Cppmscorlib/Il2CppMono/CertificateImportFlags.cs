using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono;

[OriginalName("mscorlib.dll", "Mono", "CertificateImportFlags")]
[Flags]
public enum CertificateImportFlags
{
	None = 0,
	DisableNativeBackend = 1,
	DisableAutomaticFallback = 2
}
