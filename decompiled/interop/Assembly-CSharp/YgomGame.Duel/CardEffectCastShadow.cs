using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001966")]
public class CardEffectCastShadow : CardEffectBase
{
	[Token(Token = "0x400EC3B")]
	[FieldOffset(Offset = "0x28")]
	private bool isOn;

	[Token(Token = "0x600A326")]
	[Address(RVA = "0xF02130", Offset = "0xF01330", VA = "0x180F02130")]
	public static CardEffectCastShadow Create(CardRoot cardRoot, bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600A327")]
	[Address(RVA = "0xF021B0", Offset = "0xF013B0", VA = "0x180F021B0", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A328")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectCastShadow()
	{
	}
}
