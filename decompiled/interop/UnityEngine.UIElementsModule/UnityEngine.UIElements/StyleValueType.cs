using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000445")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal enum StyleValueType
{
	[Token(Token = "0x4000DFF")]
	Invalid,
	[Token(Token = "0x4000E00")]
	Keyword,
	[Token(Token = "0x4000E01")]
	Float,
	[Token(Token = "0x4000E02")]
	Dimension,
	[Token(Token = "0x4000E03")]
	Color,
	[Token(Token = "0x4000E04")]
	ResourcePath,
	[Token(Token = "0x4000E05")]
	AssetReference,
	[Token(Token = "0x4000E06")]
	Enum,
	[Token(Token = "0x4000E07")]
	Variable,
	[Token(Token = "0x4000E08")]
	String,
	[Token(Token = "0x4000E09")]
	Function,
	[Token(Token = "0x4000E0A")]
	CommaSeparator,
	[Token(Token = "0x4000E0B")]
	ScalableImage,
	[Token(Token = "0x4000E0C")]
	MissingAssetReference
}
