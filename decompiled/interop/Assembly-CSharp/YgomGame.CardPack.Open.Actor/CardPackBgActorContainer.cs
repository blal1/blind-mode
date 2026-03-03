using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001571")]
public class CardPackBgActorContainer : ActorContainerBase<CardPackBgActorContainer>
{
	[Token(Token = "0x400CCD5")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelBGSmoke01;

	[Token(Token = "0x400CCD6")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelBGSmoke02;

	[Token(Token = "0x400CCD7")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelBGSmoke03;

	[Token(Token = "0x400CCD8")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelScrollBg;

	[Token(Token = "0x400CCD9")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelScrollBgSub;

	[Token(Token = "0x400CCDA")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelBottomBg;

	[Token(Token = "0x400CCDB")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelBottomBgSub;

	[Token(Token = "0x400CCDC")]
	[FieldOffset(Offset = "0x60")]
	private SpriteRenderer m_ScrollBgRenderer;

	[Token(Token = "0x400CCDD")]
	[FieldOffset(Offset = "0x68")]
	private SpriteRenderer m_ScrollBgSubRenderer;

	[Token(Token = "0x400CCDE")]
	[FieldOffset(Offset = "0x70")]
	private SpriteRenderer m_BottomBgRenderer;

	[Token(Token = "0x400CCDF")]
	[FieldOffset(Offset = "0x78")]
	private SpriteRenderer m_BottomBgSubRenderer;

	[Token(Token = "0x17001453")]
	public SpriteRenderer scrollBgRenderer
	{
		[Token(Token = "0x6008483")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001454")]
	public SpriteRenderer scrollBgSubRenderer
	{
		[Token(Token = "0x6008484")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001455")]
	public SpriteRenderer bottomBgRenderer
	{
		[Token(Token = "0x6008485")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001456")]
	public SpriteRenderer bottomBgSubRenderer
	{
		[Token(Token = "0x6008486")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008487")]
	[Address(RVA = "0xCD3C20", Offset = "0xCD2E20", VA = "0x180CD3C20")]
	public void SetSmokeType(int smokeType)
	{
	}

	[Token(Token = "0x6008488")]
	[Address(RVA = "0xCD3BE0", Offset = "0xCD2DE0", VA = "0x180CD3BE0")]
	public static CardPackBgActorContainer Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6008489")]
	[Address(RVA = "0xCD3AC0", Offset = "0xCD2CC0", VA = "0x180CD3AC0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x600848A")]
	[Address(RVA = "0xCD3990", Offset = "0xCD2B90", VA = "0x180CD3990", Slot = "5")]
	public override void Cleanup(bool keepInfo)
	{
	}

	[Token(Token = "0x600848B")]
	[Address(RVA = "0xCD3E70", Offset = "0xCD3070", VA = "0x180CD3E70")]
	public CardPackBgActorContainer()
	{
	}
}
