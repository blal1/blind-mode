using Il2CppDummyDll;
using YgomGame.CardPack.Open.Actor;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001566")]
public class SequenceBehaviourEntryOpenPack : SequenceBehaviour
{
	[Token(Token = "0x400CC94")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_LabelTrack;

	[Token(Token = "0x400CC95")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_CardPopLabelFormat;

	[Token(Token = "0x400CC96")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_CardPopFinishLabel;

	[Token(Token = "0x400CC97")]
	[FieldOffset(Offset = "0x38")]
	private readonly DrawPackData m_PackData;

	[Token(Token = "0x400CC98")]
	[FieldOffset(Offset = "0x40")]
	private CardPackPackActor m_BeforePackActor;

	[Token(Token = "0x400CC99")]
	[FieldOffset(Offset = "0x48")]
	private CardPackPackActor m_AfterPackActor;

	[Token(Token = "0x400CC9A")]
	[FieldOffset(Offset = "0x50")]
	private double m_CardPopEndTime;

	[Token(Token = "0x400CC9B")]
	[FieldOffset(Offset = "0x58")]
	private double m_CardPopFinishStartTime;

	[Token(Token = "0x400CC9C")]
	[FieldOffset(Offset = "0x60")]
	private int m_TMStep;

	[Token(Token = "0x6008439")]
	[Address(RVA = "0xCDEA50", Offset = "0xCDDC50", VA = "0x180CDEA50")]
	public SequenceBehaviourEntryOpenPack(SequenceBehaviourWork sequenceBehaviourWork, DrawPackData packData)
	{
	}

	[Token(Token = "0x600843A")]
	[Address(RVA = "0xCDDDD0", Offset = "0xCDCFD0", VA = "0x180CDDDD0", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x600843B")]
	[Address(RVA = "0xCDE980", Offset = "0xCDDB80", VA = "0x180CDE980", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x600843C")]
	[Address(RVA = "0xCDE880", Offset = "0xCDDA80", VA = "0x180CDE880", Slot = "13")]
	protected override void OnEnd()
	{
	}

	[Token(Token = "0x600843D")]
	[Address(RVA = "0xCDDD10", Offset = "0xCDCF10", VA = "0x180CDDD10", Slot = "15")]
	public override bool OnBack()
	{
		return default(bool);
	}
}
