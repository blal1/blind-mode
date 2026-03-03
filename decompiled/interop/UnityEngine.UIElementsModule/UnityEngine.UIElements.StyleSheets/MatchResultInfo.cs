using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005C9")]
internal struct MatchResultInfo
{
	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x0")]
	public readonly bool success;

	[Token(Token = "0x4001566")]
	[FieldOffset(Offset = "0x4")]
	public readonly PseudoStates triggerPseudoMask;

	[Token(Token = "0x4001567")]
	[FieldOffset(Offset = "0x8")]
	public readonly PseudoStates dependencyPseudoMask;

	[Token(Token = "0x600287F")]
	[Address(RVA = "0x16B5120", Offset = "0x16B4320", VA = "0x1816B5120")]
	public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask)
	{
	}
}
