using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x200012C")]
public struct ShowActionDataForAnalysis
{
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x0")]
	public LogDataSideForAnalysis datal;

	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x8")]
	public LogDataSideForAnalysis datar;

	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x10")]
	public LogDataCenterForAnalysis datac;

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x9E5420", Offset = "0x9E4620", VA = "0x1809E5420")]
	public ShowActionDataForAnalysis(ShowActionData data)
	{
	}
}
