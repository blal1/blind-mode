using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x2000133")]
public struct ShowPhaseDataForAnalysis
{
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x0")]
	public Engine.Phase phase;

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
	public ShowPhaseDataForAnalysis(ShowPhaseData showPhaseData)
	{
	}
}
