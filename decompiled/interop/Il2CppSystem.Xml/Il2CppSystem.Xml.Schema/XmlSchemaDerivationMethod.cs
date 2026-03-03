using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema;

[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDerivationMethod")]
[System.Flags]
public enum XmlSchemaDerivationMethod
{
	Empty = 0,
	Substitution = 1,
	Extension = 2,
	Restriction = 4,
	List = 8,
	Union = 0x10,
	All = 0xFF,
	None = 0x100
}
