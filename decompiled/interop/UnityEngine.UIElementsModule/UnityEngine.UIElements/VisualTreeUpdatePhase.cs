using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000504")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal enum VisualTreeUpdatePhase
{
	[Token(Token = "0x4001080")]
	Bindings,
	[Token(Token = "0x4001081")]
	DataBinding,
	[Token(Token = "0x4001082")]
	Animation,
	[Token(Token = "0x4001083")]
	Styles,
	[Token(Token = "0x4001084")]
	Layout,
	[Token(Token = "0x4001085")]
	TransformClip,
	[Token(Token = "0x4001086")]
	Repaint,
	[Token(Token = "0x4001087")]
	Count
}
