using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x200156B")]
public class SequenceBehaviourSkipSection : SequenceBehaviour
{
	[Token(Token = "0x400CCAE")]
	[FieldOffset(Offset = "0x20")]
	private readonly bool m_Skippable;

	[Token(Token = "0x17001435")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x6008454")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001436")]
	public bool skippable
	{
		[Token(Token = "0x6008455")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008456")]
	[Address(RVA = "0xCE06B0", Offset = "0xCDF8B0", VA = "0x180CE06B0")]
	public SequenceBehaviourSkipSection(SequenceBehaviourWork sequenceBehaviourWork, bool skippable)
	{
	}

	[Token(Token = "0x6008457")]
	[Address(RVA = "0xCE0610", Offset = "0xCDF810", VA = "0x180CE0610", Slot = "11")]
	protected override void OnBegin()
	{
	}
}
