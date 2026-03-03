using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000478")]
public class ColorContainerSprite : ColorContainer
{
	[Token(Token = "0x40015E3")]
	[FieldOffset(Offset = "0xE8")]
	private SpriteRenderer _targetSpriteRenderer;

	[Token(Token = "0x170002D0")]
	public SpriteRenderer targetSpriteRenderer
	{
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x5FD310", Offset = "0x5FC510", VA = "0x1805FD310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001CD6")]
	[Address(RVA = "0x5FCB60", Offset = "0x5FBD60", VA = "0x1805FCB60", Slot = "4")]
	public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
	{
	}

	[Token(Token = "0x6001CD7")]
	[Address(RVA = "0x5FCB90", Offset = "0x5FBD90", VA = "0x1805FCB90")]
	private void SetTargetGraphicColor(SelectMode select_mode, StatusMode status_mode, bool is_active)
	{
	}

	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0x5FD0D0", Offset = "0x5FC2D0", VA = "0x1805FD0D0")]
	private void SetTargetGraphicColor(Color select_color, ColorMode select_color_mode, Color status_color, ColorMode status_color_mode, Color active_color, ColorMode active_color_mode)
	{
	}

	[Token(Token = "0x6001CD9")]
	[Address(RVA = "0x5FB770", Offset = "0x5FA970", VA = "0x1805FB770")]
	public ColorContainerSprite()
	{
	}
}
