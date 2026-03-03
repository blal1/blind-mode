using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO;

[OriginalName("mscorlib.dll", "System.IO", "FileMode")]
public enum FileMode
{
	CreateNew = 1,
	Create,
	Open,
	OpenOrCreate,
	Truncate,
	Append
}
