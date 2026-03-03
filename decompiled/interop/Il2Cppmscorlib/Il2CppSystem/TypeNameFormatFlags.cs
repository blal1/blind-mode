using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem;

[OriginalName("mscorlib.dll", "System", "TypeNameFormatFlags")]
public enum TypeNameFormatFlags
{
	FormatBasic = 0,
	FormatNamespace = 1,
	FormatFullInst = 2,
	FormatAssembly = 4,
	FormatSignature = 8,
	FormatNoVersion = 16,
	FormatAngleBrackets = 64,
	FormatStubInfo = 128,
	FormatGenericParam = 256,
	FormatSerialization = 259
}
