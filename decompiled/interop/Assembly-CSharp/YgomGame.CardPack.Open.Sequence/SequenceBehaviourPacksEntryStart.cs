using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001569")]
public class SequenceBehaviourPacksEntryStart : SequenceBehaviour, ISequencePackProgress
{
	[Token(Token = "0x400CCA5")]
	[FieldOffset(Offset = "0x20")]
	private readonly bool m_isBegin;

	[Token(Token = "0x400CCA6")]
	[FieldOffset(Offset = "0x24")]
	private readonly int m_PackTotal;

	[Token(Token = "0x400CCA7")]
	[FieldOffset(Offset = "0x28")]
	private readonly int m_PackIdx;

	[Token(Token = "0x400CCA8")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<DrawPackData> m_DrawPackDatas;

	[Token(Token = "0x400CCA9")]
	[FieldOffset(Offset = "0x38")]
	private readonly int m_SmokeType;

	[Token(Token = "0x400CCAA")]
	[FieldOffset(Offset = "0x3C")]
	private readonly bool m_IsPickup;

	[Token(Token = "0x400CCAB")]
	[FieldOffset(Offset = "0x40")]
	private readonly int m_LabelType;

	[Token(Token = "0x400CCAC")]
	[FieldOffset(Offset = "0x48")]
	private readonly string m_LabelText;

	[Token(Token = "0x17001432")]
	public int packIdx
	{
		[Token(Token = "0x6008449")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001433")]
	public int packTotal
	{
		[Token(Token = "0x600844A")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600844B")]
	[Address(RVA = "0xCE04F0", Offset = "0xCDF6F0", VA = "0x180CE04F0")]
	public SequenceBehaviourPacksEntryStart(SequenceBehaviourWork sequenceBehaviourWork, bool isBegin, int packTotal, int packIdx, List<DrawPackData> drawPackDatas, int smokeType, bool isPickup, int labelType, string labelText)
	{
	}

	[Token(Token = "0x600844C")]
	[Address(RVA = "0xCDF650", Offset = "0xCDE850", VA = "0x180CDF650", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x600844D")]
	[Address(RVA = "0xCC8CB0", Offset = "0xCC7EB0", VA = "0x180CC8CB0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x600844E")]
	[Address(RVA = "0xCE0480", Offset = "0xCDF680", VA = "0x180CE0480", Slot = "13")]
	protected override void OnEnd()
	{
	}

	[Token(Token = "0x600844F")]
	[Address(RVA = "0xCDDD10", Offset = "0xCDCF10", VA = "0x180CDDD10", Slot = "15")]
	public override bool OnBack()
	{
		return default(bool);
	}
}
