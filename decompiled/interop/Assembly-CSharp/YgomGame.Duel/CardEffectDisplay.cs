using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200196D")]
public class CardEffectDisplay : CardEffectBase
{
	[Token(Token = "0x400EC4B")]
	[FieldOffset(Offset = "0x28")]
	private bool disp;

	[Token(Token = "0x600A33D")]
	[Address(RVA = "0xF03060", Offset = "0xF02260", VA = "0x180F03060")]
	public static CardEffectDisplay Create(CardRoot cardRoot, bool disp)
	{
		return null;
	}

	[Token(Token = "0x600A33E")]
	[Address(RVA = "0xF030E0", Offset = "0xF022E0", VA = "0x180F030E0", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A33F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectDisplay()
	{
	}
}
