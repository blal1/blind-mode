using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001975")]
public class CardEffectStoneMode : CardEffectBase
{
	[Token(Token = "0x400EC6E")]
	[FieldOffset(Offset = "0x28")]
	private CardRoot.ModelType modelType;

	[Token(Token = "0x600A354")]
	[Address(RVA = "0xF04960", Offset = "0xF03B60", VA = "0x180F04960")]
	public static CardEffectStoneMode Create(CardRoot cardRoot, int topos)
	{
		return null;
	}

	[Token(Token = "0x600A355")]
	[Address(RVA = "0xF049F0", Offset = "0xF03BF0", VA = "0x180F049F0")]
	public static CardEffectStoneMode Create(CardRoot cardRoot, CardRoot.ModelType mdoelType)
	{
		return null;
	}

	[Token(Token = "0x600A356")]
	[Address(RVA = "0xF04A70", Offset = "0xF03C70", VA = "0x180F04A70", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A357")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A358")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectStoneMode()
	{
	}
}
