using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml;

[OriginalName("System.Xml.dll", "System.Xml", "WriteState")]
public enum WriteState
{
	Start,
	Prolog,
	Element,
	Attribute,
	Content,
	Closed,
	Error
}
