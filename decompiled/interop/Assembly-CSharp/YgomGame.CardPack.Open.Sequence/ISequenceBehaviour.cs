using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001554")]
public interface ISequenceBehaviour
{
	[Token(Token = "0x1700141A")]
	SequenceBehaviour.State state
	{
		[Token(Token = "0x60083D3")]
		get;
	}

	[Token(Token = "0x1700141B")]
	string name
	{
		[Token(Token = "0x60083D4")]
		get;
	}

	[Token(Token = "0x60083D5")]
	void Begin();

	[Token(Token = "0x60083D6")]
	bool Update();

	[Token(Token = "0x60083D7")]
	void End();

	[Token(Token = "0x60083D8")]
	bool OnBack();
}
