using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem;

[OriginalName("mscorlib.dll", "System", "ParseFailureKind")]
public enum ParseFailureKind
{
	None,
	ArgumentNull,
	Format,
	FormatWithParameter,
	FormatWithOriginalDateTime,
	FormatWithFormatSpecifier,
	FormatWithOriginalDateTimeAndParameter,
	FormatBadDateTimeCalendar
}
