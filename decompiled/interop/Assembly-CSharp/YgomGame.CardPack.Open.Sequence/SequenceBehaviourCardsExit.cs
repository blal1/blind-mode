using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x200155B")]
public class SequenceBehaviourCardsExit : SequenceBehaviour
{
	[Token(Token = "0x17001423")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x60083F2")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60083F3")]
	[Address(RVA = "0xCC8CE0", Offset = "0xCC7EE0", VA = "0x180CC8CE0")]
	public SequenceBehaviourCardsExit(SequenceBehaviourWork sequenceBehaviourWork)
	{
	}

	[Token(Token = "0x60083F4")]
	[Address(RVA = "0xCC8CB0", Offset = "0xCC7EB0", VA = "0x180CC8CB0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}
}
