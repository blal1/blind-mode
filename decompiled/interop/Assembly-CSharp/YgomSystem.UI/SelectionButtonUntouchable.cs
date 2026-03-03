using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000481")]
public class SelectionButtonUntouchable : SelectionButton
{
	[Token(Token = "0x6001D56")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "13")]
	public override Vector2 GetClosestPoint(Vector2 base_position, Vector2 direction, bool contains_check = true)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "15")]
	public override bool IsContainsPoint(Vector2 view_position)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D58")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "14")]
	public override bool IsRectContains(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, bool containedComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D59")]
	[Address(RVA = "0x605D20", Offset = "0x604F20", VA = "0x180605D20")]
	public static SelectionButtonUntouchable Create(GameObject target)
	{
		return null;
	}

	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "26")]
	protected override void SetupViewPoints()
	{
	}

	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0x605D10", Offset = "0x604F10", VA = "0x180605D10")]
	public SelectionButtonUntouchable()
	{
	}
}
