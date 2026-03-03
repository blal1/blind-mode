using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000474")]
public class ColorContainerGraphic : ColorContainer
{
	[Token(Token = "0x40015D3")]
	[FieldOffset(Offset = "0xE8")]
	private Graphic _targetGraphic;

	[Token(Token = "0x170002C8")]
	public Graphic targetGraphic
	{
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x5FC420", Offset = "0x5FB620", VA = "0x1805FC420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x5FBC30", Offset = "0x5FAE30", VA = "0x1805FBC30", Slot = "4")]
	public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
	{
	}

	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x5FBEE0", Offset = "0x5FB0E0", VA = "0x1805FBEE0")]
	private void SetTargetGraphicColor(SelectMode select_mode, StatusMode status_mode, bool is_active)
	{
	}

	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0x5FBC60", Offset = "0x5FAE60", VA = "0x1805FBC60")]
	private void SetTargetGraphicColor(Color select_color, ColorMode select_color_mode, Color status_color, ColorMode status_color_mode, Color active_color, ColorMode active_color_mode)
	{
	}

	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0x5FBA70", Offset = "0x5FAC70", VA = "0x1805FBA70")]
	protected void GetSelectColorInfo(SelectMode selectMode, out Color color, out ColorMode colorMode)
	{
	}

	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x5FB890", Offset = "0x5FAA90", VA = "0x1805FB890")]
	protected void GetButtonStatusColorInfo(StatusMode status_mode, out Color outColor, out ColorMode outColorMode)
	{
	}

	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x5FB780", Offset = "0x5FA980", VA = "0x1805FB780")]
	protected void GetActiveColorInfo(bool is_active, out Color color, out ColorMode colorMode)
	{
	}

	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0x5FB770", Offset = "0x5FA970", VA = "0x1805FB770")]
	public ColorContainerGraphic()
	{
	}
}
