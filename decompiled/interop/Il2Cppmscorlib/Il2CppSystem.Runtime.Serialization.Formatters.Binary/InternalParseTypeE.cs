using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalParseTypeE")]
public enum InternalParseTypeE
{
	Empty,
	SerializedStreamHeader,
	Object,
	Member,
	ObjectEnd,
	MemberEnd,
	Headers,
	HeadersEnd,
	SerializedStreamHeaderEnd,
	Envelope,
	EnvelopeEnd,
	Body,
	BodyEnd
}
