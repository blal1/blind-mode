using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO;

[OriginalName("mscorlib.dll", "System.IO", "MonoFileType")]
public enum MonoFileType
{
	Unknown = 0,
	Disk = 1,
	Char = 2,
	Pipe = 3,
	Remote = 32768
}
