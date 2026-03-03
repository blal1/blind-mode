using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001976")]
public class CardEffectSummonMaterial : CardEffectBase
{
	[Token(Token = "0x400EC6F")]
	[FieldOffset(Offset = "0x28")]
	private SharedDefinition.SummonMaterialType type;

	[Token(Token = "0x600A359")]
	[Address(RVA = "0xF04AA0", Offset = "0xF03CA0", VA = "0x180F04AA0")]
	public static CardEffectSummonMaterial Create(CardRoot cardRoot, SharedDefinition.SummonMaterialType type)
	{
		return null;
	}

	[Token(Token = "0x600A35A")]
	[Address(RVA = "0xF04B20", Offset = "0xF03D20", VA = "0x180F04B20", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A35B")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A35C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectSummonMaterial()
	{
	}
}
