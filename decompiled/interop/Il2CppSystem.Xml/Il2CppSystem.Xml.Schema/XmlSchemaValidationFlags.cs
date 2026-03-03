using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema;

[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaValidationFlags")]
[System.Flags]
public enum XmlSchemaValidationFlags
{
	None = 0,
	ProcessInlineSchema = 1,
	ProcessSchemaLocation = 2,
	ReportValidationWarnings = 4,
	ProcessIdentityConstraints = 8,
	AllowXmlAttributes = 0x10
}
