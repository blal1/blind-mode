using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ED4")]
public class DuelpassHomeBannerWidget
{
	[Token(Token = "0x400A4E9")]
	[FieldOffset(Offset = "0x10")]
	private ElementObjectManager eom;

	[Token(Token = "0x400A4EA")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text currentGradeText;

	[Token(Token = "0x400A4EB")]
	[FieldOffset(Offset = "0x20")]
	private TMP_Text nextGradeText;

	[Token(Token = "0x400A4EC")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text limitEmphasisText;

	[Token(Token = "0x400A4ED")]
	[FieldOffset(Offset = "0x30")]
	private Image progressBar;

	[Token(Token = "0x400A4EE")]
	[FieldOffset(Offset = "0x38")]
	private Image normalpassWallpaper;

	[Token(Token = "0x400A4EF")]
	[FieldOffset(Offset = "0x40")]
	private Image goldpassWallpaper;

	[Token(Token = "0x400A4F0")]
	[FieldOffset(Offset = "0x48")]
	private Transform clockIcon;

	[Token(Token = "0x400A4F1")]
	[FieldOffset(Offset = "0x50")]
	private Transform clockIconEmphasis;

	[Token(Token = "0x400A4F2")]
	[FieldOffset(Offset = "0x58")]
	private DuelpassProgressBarContext context;

	[Token(Token = "0x60059E9")]
	[Address(RVA = "0x9EDD20", Offset = "0x9ECF20", VA = "0x1809EDD20")]
	public DuelpassHomeBannerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60059EA")]
	[Address(RVA = "0x9ED280", Offset = "0x9EC480", VA = "0x1809ED280")]
	private void InitializeComponents()
	{
	}

	[Token(Token = "0x60059EB")]
	[Address(RVA = "0x9ED980", Offset = "0x9ECB80", VA = "0x1809ED980")]
	private void OnLimitGettingCloser(TMP_Text countdownText)
	{
	}

	[Token(Token = "0x60059EC")]
	[Address(RVA = "0x9EDB70", Offset = "0x9ECD70", VA = "0x1809EDB70")]
	private void OnLimitNotClose(TMP_Text countdownText)
	{
	}
}
