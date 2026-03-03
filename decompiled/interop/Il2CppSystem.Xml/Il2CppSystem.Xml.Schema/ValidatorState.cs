using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema;

[OriginalName("System.Xml.dll", "System.Xml.Schema", "ValidatorState")]
public enum ValidatorState
{
	None,
	Start,
	TopLevelAttribute,
	TopLevelTextOrWS,
	Element,
	Attribute,
	EndOfAttributes,
	Text,
	Whitespace,
	EndElement,
	SkipToEndElement,
	Finish
}
