using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200052E")]
internal enum CommandType
{
	[Token(Token = "0x4001151")]
	Draw,
	[Token(Token = "0x4001152")]
	ImmediateCull,
	[Token(Token = "0x4001153")]
	Immediate,
	[Token(Token = "0x4001154")]
	PushView,
	[Token(Token = "0x4001155")]
	PopView,
	[Token(Token = "0x4001156")]
	PushScissor,
	[Token(Token = "0x4001157")]
	PopScissor,
	[Token(Token = "0x4001158")]
	PushRenderTexture,
	[Token(Token = "0x4001159")]
	PopRenderTexture,
	[Token(Token = "0x400115A")]
	BlitToPreviousRT,
	[Token(Token = "0x400115B")]
	PushDefaultMaterial,
	[Token(Token = "0x400115C")]
	PopDefaultMaterial,
	[Token(Token = "0x400115D")]
	BeginDisable,
	[Token(Token = "0x400115E")]
	EndDisable,
	[Token(Token = "0x400115F")]
	CutRenderChain
}
