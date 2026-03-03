using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryHeaderEnum")]
public enum BinaryHeaderEnum
{
	SerializedStreamHeader,
	Object,
	ObjectWithMap,
	ObjectWithMapAssemId,
	ObjectWithMapTyped,
	ObjectWithMapTypedAssemId,
	ObjectString,
	Array,
	MemberPrimitiveTyped,
	MemberReference,
	ObjectNull,
	MessageEnd,
	Assembly,
	ObjectNullMultiple256,
	ObjectNullMultiple,
	ArraySinglePrimitive,
	ArraySingleObject,
	ArraySingleString,
	CrossAppDomainMap,
	CrossAppDomainString,
	CrossAppDomainAssembly,
	MethodCall,
	MethodReturn
}
