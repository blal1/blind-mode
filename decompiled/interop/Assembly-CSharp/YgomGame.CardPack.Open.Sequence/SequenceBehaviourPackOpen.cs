using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001565")]
public class SequenceBehaviourPackOpen : SequenceBehaviour
{
	[Token(Token = "0x1700142E")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x6008437")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008438")]
	[Address(RVA = "0xCDF380", Offset = "0xCDE580", VA = "0x180CDF380")]
	public SequenceBehaviourPackOpen(SequenceBehaviourWork sequenceBehaviourWork)
	{
	}
}
