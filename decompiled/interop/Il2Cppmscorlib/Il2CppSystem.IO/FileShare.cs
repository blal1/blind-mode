using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO;

[OriginalName("mscorlib.dll", "System.IO", "FileShare")]
[System.Flags]
public enum FileShare
{
	None = 0,
	Read = 1,
	Write = 2,
	ReadWrite = 3,
	Delete = 4,
	Inheritable = 0x10
}
