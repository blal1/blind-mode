using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001568")]
public class SequenceBehaviourPacksEntryNext : SequenceBehaviour, ISequencePackProgress
{
	[Token(Token = "0x400CCA2")]
	[FieldOffset(Offset = "0x20")]
	private readonly int m_PackTotal;

	[Token(Token = "0x400CCA3")]
	[FieldOffset(Offset = "0x24")]
	private readonly int m_PackIdx;

	[Token(Token = "0x400CCA4")]
	[FieldOffset(Offset = "0x28")]
	private readonly DrawPackData m_DrawPackData;

	[Token(Token = "0x17001430")]
	public int packIdx
	{
		[Token(Token = "0x6008443")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001431")]
	public int packTotal
	{
		[Token(Token = "0x6008444")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008445")]
	[Address(RVA = "0xCDF600", Offset = "0xCDE800", VA = "0x180CDF600")]
	public SequenceBehaviourPacksEntryNext(SequenceBehaviourWork sequenceBehaviourWork, int packTotal, int packIdx, DrawPackData drawPackData)
	{
	}

	[Token(Token = "0x6008446")]
	[Address(RVA = "0xCDF390", Offset = "0xCDE590", VA = "0x180CDF390", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x6008447")]
	[Address(RVA = "0xCC8CB0", Offset = "0xCC7EB0", VA = "0x180CC8CB0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x6008448")]
	[Address(RVA = "0xCDDD10", Offset = "0xCDCF10", VA = "0x180CDDD10", Slot = "15")]
	public override bool OnBack()
	{
		return default(bool);
	}
}
