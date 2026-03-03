using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200197B")]
public class CardEffectZoneEffect : CardEffectBase
{
	[Token(Token = "0x400EC7D")]
	[FieldOffset(Offset = "0x28")]
	private bool zoneEffect;

	[Token(Token = "0x400EC80")]
	[FieldOffset(Offset = "0x34")]
	private bool isFace;

	[Token(Token = "0x400EC81")]
	[FieldOffset(Offset = "0x38")]
	private ZoneCard zoneCard;

	[Token(Token = "0x170018F7")]
	public ZoneCard.Zone zone
	{
		[Token(Token = "0x600A379")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		[CompilerGenerated]
		get
		{
			return default(ZoneCard.Zone);
		}
		[Token(Token = "0x600A37A")]
		[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018F8")]
	public ZoneCard.Mode mode
	{
		[Token(Token = "0x600A37B")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		[CompilerGenerated]
		get
		{
			return default(ZoneCard.Mode);
		}
		[Token(Token = "0x600A37C")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A37D")]
	[Address(RVA = "0xF05FB0", Offset = "0xF051B0", VA = "0x180F05FB0")]
	private static CardEffectZoneEffect Create(CardRoot cardRoot, ZoneCard.Zone zone, ZoneCard.Mode mode, bool isFace)
	{
		return null;
	}

	[Token(Token = "0x600A37E")]
	[Address(RVA = "0xF05EF0", Offset = "0xF050F0", VA = "0x180F05EF0")]
	private static CardEffectZoneEffect Create(CardRoot cardRoot, ZoneCard.Mode mode, bool isFace, ZoneCard zoneCard)
	{
		return null;
	}

	[Token(Token = "0x600A37F")]
	[Address(RVA = "0xF05CF0", Offset = "0xF04EF0", VA = "0x180F05CF0")]
	private static CardEffectZoneEffect CreateNoZoneEffect(CardRoot cardRoot)
	{
		return null;
	}

	[Token(Token = "0x600A380")]
	[Address(RVA = "0xF05D60", Offset = "0xF04F60", VA = "0x180F05D60")]
	public static CardEffectZoneEffect Create(CardRoot cardRoot, int position, bool getOut, bool isFace, ZoneCard zoneCard)
	{
		return null;
	}

	[Token(Token = "0x600A381")]
	[Address(RVA = "0xF06060", Offset = "0xF05260", VA = "0x180F06060", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A382")]
	[Address(RVA = "0xF06220", Offset = "0xF05420", VA = "0x180F06220", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A383")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectZoneEffect()
	{
	}
}
