using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005C5")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct StylePropertyValue
{
	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x0")]
	public StyleSheet sheet;

	[Token(Token = "0x4001553")]
	[FieldOffset(Offset = "0x8")]
	public StyleValueHandle handle;
}
