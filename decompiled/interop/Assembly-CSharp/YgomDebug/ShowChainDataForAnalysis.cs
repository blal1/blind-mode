using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x2000130")]
public struct ShowChainDataForAnalysis
{
	[Token(Token = "0x2000131")]
	public enum ChainDataTypeForAnalysis
	{
		[Token(Token = "0x4000767")]
		SET,
		[Token(Token = "0x4000768")]
		RUN,
		[Token(Token = "0x4000769")]
		STEP,
		[Token(Token = "0x400076A")]
		END
	}

	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0x0")]
	public short cardid;

	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x2")]
	public short chainnum;

	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x4")]
	public bool team;

	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x8")]
	public ChainDataTypeForAnalysis type;

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x9E5520", Offset = "0x9E4720", VA = "0x1809E5520")]
	public ShowChainDataForAnalysis(ShowChainData showChainData)
	{
	}
}
