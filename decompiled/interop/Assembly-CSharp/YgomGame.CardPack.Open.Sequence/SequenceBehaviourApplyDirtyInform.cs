using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001558")]
public class SequenceBehaviourApplyDirtyInform : SequenceBehaviour
{
	[Token(Token = "0x400CC60")]
	[FieldOffset(Offset = "0x20")]
	private readonly bool m_Skippable;

	[Token(Token = "0x400CC61")]
	[FieldOffset(Offset = "0x28")]
	private IReadOnlySequenceController m_SequenceController;

	[Token(Token = "0x17001421")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x60083E8")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60083E9")]
	[Address(RVA = "0xCC80A0", Offset = "0xCC72A0", VA = "0x180CC80A0")]
	public SequenceBehaviourApplyDirtyInform(SequenceBehaviourWork sequenceBehaviourWork, IReadOnlySequenceController sequenceController)
	{
	}

	[Token(Token = "0x60083EA")]
	[Address(RVA = "0xCC7E40", Offset = "0xCC7040", VA = "0x180CC7E40", Slot = "11")]
	protected override void OnBegin()
	{
	}
}
