using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001555")]
public interface ISequencePackProgress
{
	[Token(Token = "0x1700141C")]
	int packIdx
	{
		[Token(Token = "0x60083D9")]
		get;
	}

	[Token(Token = "0x1700141D")]
	int packTotal
	{
		[Token(Token = "0x60083DA")]
		get;
	}
}
