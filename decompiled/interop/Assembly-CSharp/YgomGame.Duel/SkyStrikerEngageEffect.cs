using System;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001988")]
public class SkyStrikerEngageEffect : CardMoveEffectBase
{
	[Token(Token = "0x400ECC1")]
	private const string TimelinePath = "Duel/Timeline/Card/<_CARD_ILLUST_>/Ef13671/Ef13671";

	[Token(Token = "0x400ECC2")]
	private const string TimelinePathAlt = "Duel/Timeline/Card/<_CARD_ILLUST_>/Ef03434/Ef03434";

	[Token(Token = "0x400ECC3")]
	[FieldOffset(Offset = "0xB0")]
	private bool isAlternative;

	[Token(Token = "0x600A3F4")]
	[Address(RVA = "0xF15530", Offset = "0xF14730", VA = "0x180F15530")]
	public static SkyStrikerEngageEffect Create(bool isAlternative)
	{
		return null;
	}

	[Token(Token = "0x600A3F5")]
	[Address(RVA = "0xF155F0", Offset = "0xF147F0", VA = "0x180F155F0", Slot = "4")]
	public override void Load(int moveCardID, int moveCardSleeveID, int moveCardRareID, int fromPlayer, int fromPosition)
	{
	}

	[Token(Token = "0x600A3F6")]
	[Address(RVA = "0xF158C0", Offset = "0xF14AC0", VA = "0x180F158C0", Slot = "5")]
	protected override bool PlayEffect(RunEffectWorker worker, Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3F7")]
	[Address(RVA = "0xF15D30", Offset = "0xF14F30", VA = "0x180F15D30")]
	private void SetupDestCardTexture(ElementObjectManager manager)
	{
	}

	[Token(Token = "0x600A3F8")]
	[Address(RVA = "0xF15E40", Offset = "0xF15040", VA = "0x180F15E40", Slot = "7")]
	public override bool Skip()
	{
		return default(bool);
	}

	[Token(Token = "0x600A3F9")]
	[Address(RVA = "0xF08490", Offset = "0xF07690", VA = "0x180F08490", Slot = "6")]
	protected override void Finish()
	{
	}

	[Token(Token = "0x600A3FA")]
	[Address(RVA = "0xF09DA0", Offset = "0xF08FA0", VA = "0x180F09DA0")]
	public SkyStrikerEngageEffect()
	{
	}
}
