using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200190E")]
public struct ShowPhaseData
{
	[Token(Token = "0x400EA66")]
	[FieldOffset(Offset = "0x0")]
	public Engine.Phase phase;

	[Token(Token = "0x600A1A3")]
	[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
	public ShowPhaseData(Engine.Phase phase)
	{
	}
}
