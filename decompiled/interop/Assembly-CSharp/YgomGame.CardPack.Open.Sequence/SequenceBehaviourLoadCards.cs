using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001564")]
public class SequenceBehaviourLoadCards : SequenceBehaviour
{
	[Token(Token = "0x400CC90")]
	[FieldOffset(Offset = "0x20")]
	private readonly GameObject m_Owner;

	[Token(Token = "0x400CC91")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<int> m_Mrks;

	[Token(Token = "0x400CC92")]
	[FieldOffset(Offset = "0x30")]
	private bool m_UnloadUnuseAssets;

	[Token(Token = "0x400CC93")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsDone;

	[Token(Token = "0x1700142D")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x6008431")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008432")]
	[Address(RVA = "0xCDED80", Offset = "0xCDDF80", VA = "0x180CDED80")]
	public SequenceBehaviourLoadCards(SequenceBehaviourWork sequenceBehaviourWork, GameObject owner, List<int> mrks, bool unloadUnuseAssets)
	{
	}

	[Token(Token = "0x6008433")]
	[Address(RVA = "0xCDEB20", Offset = "0xCDDD20", VA = "0x180CDEB20", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x6008434")]
	[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x6008435")]
	[Address(RVA = "0xCDED40", Offset = "0xCDDF40", VA = "0x180CDED40", Slot = "13")]
	protected override void OnEnd()
	{
	}
}
