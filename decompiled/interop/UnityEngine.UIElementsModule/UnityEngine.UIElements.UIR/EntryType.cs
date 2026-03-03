using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000537")]
internal enum EntryType : ushort
{
	[Token(Token = "0x40011B0")]
	DrawSolidMesh,
	[Token(Token = "0x40011B1")]
	DrawTexturedMesh,
	[Token(Token = "0x40011B2")]
	DrawTexturedMeshSkipAtlas,
	[Token(Token = "0x40011B3")]
	DrawTextMesh,
	[Token(Token = "0x40011B4")]
	DrawGradients,
	[Token(Token = "0x40011B5")]
	DrawImmediate,
	[Token(Token = "0x40011B6")]
	DrawImmediateCull,
	[Token(Token = "0x40011B7")]
	DrawChildren,
	[Token(Token = "0x40011B8")]
	BeginStencilMask,
	[Token(Token = "0x40011B9")]
	EndStencilMask,
	[Token(Token = "0x40011BA")]
	PopStencilMask,
	[Token(Token = "0x40011BB")]
	PushClippingRect,
	[Token(Token = "0x40011BC")]
	PopClippingRect,
	[Token(Token = "0x40011BD")]
	PushScissors,
	[Token(Token = "0x40011BE")]
	PopScissors,
	[Token(Token = "0x40011BF")]
	PushGroupMatrix,
	[Token(Token = "0x40011C0")]
	PopGroupMatrix,
	[Token(Token = "0x40011C1")]
	PushRenderTexture,
	[Token(Token = "0x40011C2")]
	BlitAndPopRenderTexture,
	[Token(Token = "0x40011C3")]
	PushDefaultMaterial,
	[Token(Token = "0x40011C4")]
	PopDefaultMaterial,
	[Token(Token = "0x40011C5")]
	CutRenderChain,
	[Token(Token = "0x40011C6")]
	DedicatedPlaceholder
}
