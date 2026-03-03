using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001974")]
public class CardEffectSE : CardEffectBase
{
	[Token(Token = "0x400EC6B")]
	[FieldOffset(Offset = "0x28")]
	private string seLabel;

	[Token(Token = "0x400EC6C")]
	[FieldOffset(Offset = "0x30")]
	private bool play;

	[Token(Token = "0x400EC6D")]
	[FieldOffset(Offset = "0x31")]
	private bool is3D;

	[Token(Token = "0x600A34F")]
	[Address(RVA = "0xF04770", Offset = "0xF03970", VA = "0x180F04770")]
	public static CardEffectSE CreatePlay(CardRoot cardRoot, string seLabel, bool is3D)
	{
		return null;
	}

	[Token(Token = "0x600A350")]
	[Address(RVA = "0xF04810", Offset = "0xF03A10", VA = "0x180F04810")]
	public static CardEffectSE CreateStop(CardRoot cardRoot, string seLabel)
	{
		return null;
	}

	[Token(Token = "0x600A351")]
	[Address(RVA = "0xF048A0", Offset = "0xF03AA0", VA = "0x180F048A0", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A352")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A353")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectSE()
	{
	}
}
