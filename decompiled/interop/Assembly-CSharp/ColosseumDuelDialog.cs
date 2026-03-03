using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Colosseum;
using YgomGame.DiceRally;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

[Token(Token = "0x2000033")]
public class ColosseumDuelDialog : ColosseumDialog
{
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x60")]
	private readonly string BTN_BACK_LABEL;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x68")]
	private readonly string TXT_TITLE_LABEL;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x70")]
	private readonly string TXT_DETAIL_LABEL;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x78")]
	private readonly string IMG_REWARD_LABEL;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x80")]
	private readonly string IMG_ICON_START;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x88")]
	private readonly string IMG_ICON_CARD;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x90")]
	private readonly string IMG_ICON_CARDRARE;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x98")]
	private readonly string IMG_ICON_PREMIUM;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0xA0")]
	private readonly string IMG_ICON_PREMIUM_RARE;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0xA8")]
	private readonly string IMG_ICON_RARITYUP;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0xB0")]
	private readonly string IMG_ICON_HAND1;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0xB8")]
	private readonly string IMG_ICON_LPHALF;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0xC0")]
	private readonly string IMG_ICON_TIMEHALF;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0xC8")]
	private readonly string IMG_ICON_MIGHTY;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string IMG_OVERICON_N;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string IMG_OVERICON_R;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string IMG_OVERICON_SR;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string IMG_OVERICON_UR;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0xF0")]
	public readonly string KEY_DETAIL_TEXT;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0xF8")]
	public readonly string KEY_DETAIL_CARD;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x100")]
	public readonly string KEY_SPACE;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x108")]
	public bool isIdling;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x118")]
	private ExtendedTextMeshProUGUI titleText;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x120")]
	private ExtendedTextMeshProUGUI detailText;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x128")]
	private ElementObjectManager detailCard;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x130")]
	private ElementObjectManager effect;

	[Token(Token = "0x17000013")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x3D8390", Offset = "0x3D7590", VA = "0x1803D8390", Slot = "4")]
	public override void Initialize(ColosseumDialogMangaer manager)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3DA090", Offset = "0x3D9290", VA = "0x1803DA090", Slot = "5")]
	internal override void UpdateData(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3D8AC0", Offset = "0x3D7CC0", VA = "0x1803D8AC0")]
	private void SetEffectIcon(DiceRallySpace space)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3D8610", Offset = "0x3D7810", VA = "0x1803D8610")]
	private void SetCardRarity(ElementObjectManager eom, DiceRallyUtil.CardCategory rarity)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x3DA3D0", Offset = "0x3D95D0", VA = "0x1803DA3D0")]
	public ColosseumDuelDialog()
	{
	}
}
