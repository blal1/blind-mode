using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ED9")]
public class DuelpassProgressBarWidget
{
	[Token(Token = "0x400A503")]
	[FieldOffset(Offset = "0x10")]
	private TMP_Text currentGradeText;

	[Token(Token = "0x400A504")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text nextGradeText;

	[Token(Token = "0x400A505")]
	[FieldOffset(Offset = "0x20")]
	private Image progressBar;

	[Token(Token = "0x400A506")]
	[FieldOffset(Offset = "0x28")]
	private Image normalpassWallpaper;

	[Token(Token = "0x400A507")]
	[FieldOffset(Offset = "0x30")]
	private Image goldpassWallpaper;

	[Token(Token = "0x400A508")]
	[FieldOffset(Offset = "0x38")]
	private DuelpassProgressBarContext context;

	[Token(Token = "0x6005A02")]
	[Address(RVA = "0x9F0D40", Offset = "0x9EFF40", VA = "0x1809F0D40")]
	public DuelpassProgressBarWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005A03")]
	[Address(RVA = "0x9F0C10", Offset = "0x9EFE10", VA = "0x1809F0C10")]
	public void UpdateContents()
	{
	}

	[Token(Token = "0x6005A04")]
	[Address(RVA = "0x9F0BA0", Offset = "0x9EFDA0", VA = "0x1809F0BA0")]
	public void UnLockGoldPass()
	{
	}
}
