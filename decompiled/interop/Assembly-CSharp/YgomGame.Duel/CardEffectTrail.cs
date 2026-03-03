using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001978")]
public class CardEffectTrail : CardEffectBase
{
	[Token(Token = "0x400EC77")]
	[FieldOffset(Offset = "0x28")]
	private bool show;

	[Token(Token = "0x400EC78")]
	[FieldOffset(Offset = "0x2C")]
	private DuelEffectPool.Type trailType;

	[Token(Token = "0x400EC79")]
	[FieldOffset(Offset = "0x30")]
	private bool persistentVision;

	[Token(Token = "0x600A36B")]
	[Address(RVA = "0xF05A40", Offset = "0xF04C40", VA = "0x180F05A40")]
	public static CardEffectTrail Create(CardRoot cardRoot, CardPlane.MoveTrailType trailType, bool persistentVision)
	{
		return null;
	}

	[Token(Token = "0x600A36C")]
	[Address(RVA = "0xF059B0", Offset = "0xF04BB0", VA = "0x180F059B0")]
	public static CardEffectTrail CreateShowTrail(CardRoot cardRoot, DuelEffectPool.Type type, bool persistentVision)
	{
		return null;
	}

	[Token(Token = "0x600A36D")]
	[Address(RVA = "0xF05940", Offset = "0xF04B40", VA = "0x180F05940")]
	public static CardEffectTrail CreateHideTrail(CardRoot cardRoot)
	{
		return null;
	}

	[Token(Token = "0x600A36E")]
	[Address(RVA = "0xF05B40", Offset = "0xF04D40", VA = "0x180F05B40", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A36F")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A370")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectTrail()
	{
	}
}
