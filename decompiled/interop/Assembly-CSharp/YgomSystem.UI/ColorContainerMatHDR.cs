using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000477")]
public class ColorContainerMatHDR : ColorContainer
{
	[Token(Token = "0x40015E1")]
	[FieldOffset(Offset = "0xE8")]
	public string colorParamName;

	[Token(Token = "0x40015E2")]
	[FieldOffset(Offset = "0xF0")]
	private Renderer m_TargetRenderer;

	[Token(Token = "0x170002CF")]
	private Renderer targetRenderer
	{
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x5FCAC0", Offset = "0x5FBCC0", VA = "0x1805FCAC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001CD2")]
	[Address(RVA = "0x5FC700", Offset = "0x5FB900", VA = "0x1805FC700")]
	private Color GetColorByMode(SelectMode selectMode, StatusMode statusMode, bool isActive)
	{
		return default(Color);
	}

	[Token(Token = "0x6001CD3")]
	[Address(RVA = "0x5FC950", Offset = "0x5FBB50", VA = "0x1805FC950", Slot = "4")]
	public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
	{
	}

	[Token(Token = "0x6001CD4")]
	[Address(RVA = "0x5FCA60", Offset = "0x5FBC60", VA = "0x1805FCA60")]
	public ColorContainerMatHDR()
	{
	}
}
