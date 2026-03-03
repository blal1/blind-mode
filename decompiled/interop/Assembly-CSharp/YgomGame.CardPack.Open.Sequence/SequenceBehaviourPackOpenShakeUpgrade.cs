using Il2CppDummyDll;
using YgomGame.Card;
using YgomGame.CardPack.Open.Actor;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001567")]
public class SequenceBehaviourPackOpenShakeUpgrade : SequenceBehaviour
{
	[Token(Token = "0x400CC9D")]
	[FieldOffset(Offset = "0x20")]
	private readonly CardCollectionInfo.Rarity m_FromPackType;

	[Token(Token = "0x400CC9E")]
	[FieldOffset(Offset = "0x24")]
	private readonly CardCollectionInfo.Rarity m_DstPackType;

	[Token(Token = "0x400CC9F")]
	[FieldOffset(Offset = "0x28")]
	private string m_PackImagePath;

	[Token(Token = "0x400CCA0")]
	[FieldOffset(Offset = "0x30")]
	private CardPackPackActor m_BeforePackActor;

	[Token(Token = "0x400CCA1")]
	[FieldOffset(Offset = "0x38")]
	private CardPackPackActor m_AfterActor;

	[Token(Token = "0x1700142F")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x600843E")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600843F")]
	[Address(RVA = "0xCDF330", Offset = "0xCDE530", VA = "0x180CDF330")]
	public SequenceBehaviourPackOpenShakeUpgrade(SequenceBehaviourWork sequenceBehaviourWork, string packImagePath, CardCollectionInfo.Rarity fromPackType, CardCollectionInfo.Rarity dstPackType)
	{
	}

	[Token(Token = "0x6008440")]
	[Address(RVA = "0xCDEDE0", Offset = "0xCDDFE0", VA = "0x180CDEDE0", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x6008441")]
	[Address(RVA = "0xCC8CB0", Offset = "0xCC7EB0", VA = "0x180CC8CB0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x6008442")]
	[Address(RVA = "0xCDF1B0", Offset = "0xCDE3B0", VA = "0x180CDF1B0", Slot = "13")]
	protected override void OnEnd()
	{
	}
}
