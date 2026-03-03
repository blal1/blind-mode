using Il2CppDummyDll;
using YgomGame.CardPack.Open.Actor;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x200156C")]
public class SequenceBehaviourWork
{
	[Token(Token = "0x400CCAF")]
	[FieldOffset(Offset = "0x10")]
	public CardPackRootActorContainer rootActorContainer;

	[Token(Token = "0x400CCB0")]
	[FieldOffset(Offset = "0x18")]
	public bool toNextTrigger;

	[Token(Token = "0x400CCB1")]
	[FieldOffset(Offset = "0x19")]
	public bool informDirty;

	[Token(Token = "0x6008458")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SequenceBehaviourWork()
	{
	}
}
