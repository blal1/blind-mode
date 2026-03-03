using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000009")]
public enum VisitReturnCode
{
	[Token(Token = "0x400000E")]
	Ok,
	[Token(Token = "0x400000F")]
	NullContainer,
	[Token(Token = "0x4000010")]
	InvalidContainerType,
	[Token(Token = "0x4000011")]
	MissingPropertyBag,
	[Token(Token = "0x4000012")]
	InvalidPath,
	[Token(Token = "0x4000013")]
	InvalidCast,
	[Token(Token = "0x4000014")]
	AccessViolation
}
