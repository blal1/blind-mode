using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml;

[OriginalName("System.Xml.dll", "System.Xml", "XmlNodeType")]
public enum XmlNodeType
{
	None,
	Element,
	Attribute,
	Text,
	CDATA,
	EntityReference,
	Entity,
	ProcessingInstruction,
	Comment,
	Document,
	DocumentType,
	DocumentFragment,
	Notation,
	Whitespace,
	SignificantWhitespace,
	EndElement,
	EndEntity,
	XmlDeclaration
}
