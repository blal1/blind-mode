using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200047C")]
public class RectSelectionItemUntouchable : RectSelectionItem
{
	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "13")]
	public override Vector2 GetClosestPoint(Vector2 base_position, Vector2 direction, bool contains_check = true)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "15")]
	public override bool IsContainsPoint(Vector2 view_position)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "14")]
	public override bool IsRectContains(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, bool containedComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D08")]
	[Address(RVA = "0x601050", Offset = "0x600250", VA = "0x180601050")]
	public static SelectionButtonUntouchable Create(GameObject target)
	{
		return null;
	}

	[Token(Token = "0x6001D09")]
	[Address(RVA = "0x6010B0", Offset = "0x6002B0", VA = "0x1806010B0")]
	public RectSelectionItemUntouchable()
	{
	}
}
