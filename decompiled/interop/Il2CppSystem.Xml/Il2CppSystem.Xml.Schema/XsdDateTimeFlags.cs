using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema;

[OriginalName("System.Xml.dll", "System.Xml.Schema", "XsdDateTimeFlags")]
[System.Flags]
public enum XsdDateTimeFlags
{
	DateTime = 1,
	Time = 2,
	Date = 4,
	GYearMonth = 8,
	GYear = 0x10,
	GMonthDay = 0x20,
	GDay = 0x40,
	GMonth = 0x80,
	XdrDateTimeNoTz = 0x100,
	XdrDateTime = 0x200,
	XdrTimeNoTz = 0x400,
	AllXsd = 0xFF
}
