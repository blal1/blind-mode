using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x200156D")]
public interface IReadOnlySequenceController
{
	[Token(Token = "0x6008459")]
	void CalcPackProgressInfo(out int packIdxRes, out int packTotalRes);

	[Token(Token = "0x600845A")]
	int CalcTotalFoundedKey();
}
