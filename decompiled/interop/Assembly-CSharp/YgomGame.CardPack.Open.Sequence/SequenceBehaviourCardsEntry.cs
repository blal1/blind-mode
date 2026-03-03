using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001559")]
public class SequenceBehaviourCardsEntry : SequenceBehaviour
{
	[Token(Token = "0x400CC62")]
	[FieldOffset(Offset = "0x20")]
	private readonly DrawPackData m_DrawPackData;

	[Token(Token = "0x400CC63")]
	[FieldOffset(Offset = "0x28")]
	private double m_WaitSec;

	[Token(Token = "0x400CC64")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_ExistsPosList;

	[Token(Token = "0x17001422")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x60083EB")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60083EC")]
	[Address(RVA = "0xCC8BF0", Offset = "0xCC7DF0", VA = "0x180CC8BF0")]
	public SequenceBehaviourCardsEntry(SequenceBehaviourWork sequenceBehaviourWork, DrawPackData drawPackData)
	{
	}

	[Token(Token = "0x60083ED")]
	[Address(RVA = "0xCC8100", Offset = "0xCC7300", VA = "0x180CC8100", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x60083EE")]
	[Address(RVA = "0xCC8BB0", Offset = "0xCC7DB0", VA = "0x180CC8BB0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}
}
