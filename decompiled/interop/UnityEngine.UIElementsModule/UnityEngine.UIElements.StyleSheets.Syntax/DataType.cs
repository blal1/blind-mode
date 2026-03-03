using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x20005DB")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal enum DataType
{
	[Token(Token = "0x4001596")]
	None,
	[Token(Token = "0x4001597")]
	Number,
	[Token(Token = "0x4001598")]
	Integer,
	[Token(Token = "0x4001599")]
	Length,
	[Token(Token = "0x400159A")]
	Percentage,
	[Token(Token = "0x400159B")]
	Color,
	[Token(Token = "0x400159C")]
	Resource,
	[Token(Token = "0x400159D")]
	Url,
	[Token(Token = "0x400159E")]
	Time,
	[Token(Token = "0x400159F")]
	Angle,
	[Token(Token = "0x40015A0")]
	CustomIdent
}
