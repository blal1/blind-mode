using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001979")]
public class CardEffectWait : CardEffectBase
{
	[Token(Token = "0x400EC7A")]
	[FieldOffset(Offset = "0x28")]
	private Func<bool> waitFunc;

	[Token(Token = "0x600A371")]
	[Address(RVA = "0xF05C80", Offset = "0xF04E80", VA = "0x180F05C80")]
	public static CardEffectWait Create(Func<bool> waitFunc)
	{
		return null;
	}

	[Token(Token = "0x600A372")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A373")]
	[Address(RVA = "0x427B60", Offset = "0x426D60", VA = "0x180427B60", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A374")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectWait()
	{
	}
}
