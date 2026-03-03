using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000562")]
[Flags]
internal enum RenderDataFlags
{
	[Token(Token = "0x40012FE")]
	IsInChain = 1,
	[Token(Token = "0x40012FF")]
	IsGroupTransform = 2,
	[Token(Token = "0x4001300")]
	IsIgnoringDynamicColorHint = 4,
	[Token(Token = "0x4001301")]
	HasExtraData = 8,
	[Token(Token = "0x4001302")]
	HasExtraMeshes = 0x10
}
