using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000480")]
public class SelectionButtonFullScreen : SelectionButton
{
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "13")]
	public override Vector2 GetClosestPoint(Vector2 base_position, Vector2 direction, bool contains_check = true)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "15")]
	public override bool IsContainsPoint(Vector2 view_position)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D54")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "14")]
	public override bool IsRectContains(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, bool containedComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x605D10", Offset = "0x604F10", VA = "0x180605D10")]
	public SelectionButtonFullScreen()
	{
	}
}
