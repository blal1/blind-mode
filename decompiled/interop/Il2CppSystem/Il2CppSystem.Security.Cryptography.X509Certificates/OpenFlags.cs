using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "OpenFlags")]
[System.Flags]
public enum OpenFlags
{
	ReadOnly = 0,
	ReadWrite = 1,
	MaxAllowed = 2,
	OpenExistingOnly = 4,
	IncludeArchived = 8
}
