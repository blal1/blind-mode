using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200197A")]
public class CardEffectWaitForSecond : CardEffectBase
{
	[Token(Token = "0x400EC7B")]
	[FieldOffset(Offset = "0x28")]
	private float second;

	[Token(Token = "0x400EC7C")]
	[FieldOffset(Offset = "0x2C")]
	private float timer;

	[Token(Token = "0x600A375")]
	[Address(RVA = "0xF05BC0", Offset = "0xF04DC0", VA = "0x180F05BC0")]
	public static CardEffectWaitForSecond Create(float second)
	{
		return null;
	}

	[Token(Token = "0x600A376")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A377")]
	[Address(RVA = "0xF05C30", Offset = "0xF04E30", VA = "0x180F05C30", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A378")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectWaitForSecond()
	{
	}
}
