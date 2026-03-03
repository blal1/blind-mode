using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000475")]
public class ColorContainerGraphicOrderable : ColorContainerGraphic
{
	[Token(Token = "0x40015D4")]
	private const int k_SelectTypeId = 0;

	[Token(Token = "0x40015D5")]
	private const int k_ButtonStatusTypeId = 1;

	[Token(Token = "0x40015D6")]
	private const int k_InactiveTypeId = 2;

	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private int m_SelectPriority;

	[Token(Token = "0x40015D8")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	private int m_ButtonStatusPriority;

	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private int m_InactivePriority;

	[Token(Token = "0x40015DA")]
	[FieldOffset(Offset = "0x100")]
	private List<int> m_OrderedTypeIds;

	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x5FAF30", Offset = "0x5FA130", VA = "0x1805FAF30")]
	private int GetDefaultPriority(int typeId)
	{
		return default(int);
	}

	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x5FAF60", Offset = "0x5FA160", VA = "0x1805FAF60")]
	private int GetOverridePriority(int typeId)
	{
		return default(int);
	}

	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0x5FB400", Offset = "0x5FA600", VA = "0x1805FB400")]
	public void SetupOrder(bool force = false)
	{
	}

	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90", Slot = "4")]
	public override void SetColor(SelectMode select_mode, StatusMode status_mode, bool is_active = true)
	{
	}

	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0x5FADA0", Offset = "0x5F9FA0", VA = "0x1805FADA0")]
	private void GetColorInfo(int typeId, SelectMode select_mode, StatusMode status_mode, bool is_active, out Color color, out ColorMode colorMode)
	{
	}

	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0x5FAD00", Offset = "0x5F9F00", VA = "0x1805FAD00")]
	private Color ApplyColorInfo(Color baseColor, Color setColor, ColorMode setColorMode)
	{
		return default(Color);
	}

	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x5FB770", Offset = "0x5FA970", VA = "0x1805FB770")]
	public ColorContainerGraphicOrderable()
	{
	}
}
