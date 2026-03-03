using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema;

[OriginalName("System.Xml.dll", "System.Xml.Schema", "AttributeMatchState")]
public enum AttributeMatchState
{
	AttributeFound,
	AnyIdAttributeFound,
	UndeclaredElementAndAttribute,
	UndeclaredAttribute,
	AnyAttributeLax,
	AnyAttributeSkip,
	ProhibitedAnyAttribute,
	ProhibitedAttribute,
	AttributeNameMismatch,
	ValidateAttributeInvalidCall
}
