using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x200157B")]
public class CardPackPackActor : ActorBase<CardPackPackActor>
{
	[Token(Token = "0x400CD49")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelPackSprite;

	[Token(Token = "0x400CD4A")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelPackSpriteAdd;

	[Token(Token = "0x400CD4B")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelPackCutUpperSprite;

	[Token(Token = "0x400CD4C")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelPackCutLowerSprite;

	[Token(Token = "0x400CD4D")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelPackRefrectionSprite;

	[Token(Token = "0x1700147A")]
	public SpriteRenderer packSprite
	{
		[Token(Token = "0x6008529")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600852A")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700147B")]
	public SpriteRenderer packSpriteAdd
	{
		[Token(Token = "0x600852B")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600852C")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700147C")]
	public SpriteRenderer packCutUpperSprite
	{
		[Token(Token = "0x600852D")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600852E")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700147D")]
	public SpriteRenderer packCutLowerSprite
	{
		[Token(Token = "0x600852F")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008530")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700147E")]
	public SpriteRenderer packRefrectionSprite
	{
		[Token(Token = "0x6008531")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008532")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6008533")]
	[Address(RVA = "0xCD98A0", Offset = "0xCD8AA0", VA = "0x180CD98A0")]
	public static CardPackPackActor Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6008534")]
	[Address(RVA = "0xCD9740", Offset = "0xCD8940", VA = "0x180CD9740", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6008535")]
	[Address(RVA = "0xCD9980", Offset = "0xCD8B80", VA = "0x180CD9980")]
	public CardPackPackActor()
	{
	}
}
