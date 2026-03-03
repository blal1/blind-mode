using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200047B")]
public class RectSelectionItem : SelectionItem
{
	[Token(Token = "0x40015F2")]
	[FieldOffset(Offset = "0x150")]
	private Vector3[] rectWorldCorners;

	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0x158")]
	private Vector3[] boxWorldCorners;

	[Token(Token = "0x40015F4")]
	[FieldOffset(Offset = "0x160")]
	private Vector2[] viewPoints;

	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0x168")]
	public bool useWorldRectSetting;

	[Token(Token = "0x40015F6")]
	[FieldOffset(Offset = "0x16C")]
	public Vector2 worldRectHalfSize;

	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0x174")]
	public Vector3 worldRectCenter;

	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0x180")]
	public Vector3 worldRectAngle;

	[Token(Token = "0x170002D6")]
	public override Vector2 viewCenterPosition
	{
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x603070", Offset = "0x602270", VA = "0x180603070", Slot = "12")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6001CFC")]
	[Address(RVA = "0x6011A0", Offset = "0x6003A0", VA = "0x1806011A0", Slot = "13")]
	public override Vector2 GetClosestPoint(Vector2 base_position, Vector2 direction, bool contains_check = true)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001CFD")]
	[Address(RVA = "0x601A30", Offset = "0x600C30", VA = "0x180601A30", Slot = "26")]
	protected virtual void SetupViewPoints()
	{
	}

	[Token(Token = "0x6001CFE")]
	[Address(RVA = "0x601160", Offset = "0x600360", VA = "0x180601160")]
	private Vector3 ElementScale(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001CFF")]
	[Address(RVA = "0x6014D0", Offset = "0x6006D0", VA = "0x1806014D0", Slot = "15")]
	public override bool IsContainsPoint(Vector2 view_position)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D00")]
	[Address(RVA = "0x601870", Offset = "0x600A70", VA = "0x180601870", Slot = "14")]
	public override bool IsRectContains(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, bool containedComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x601A10", Offset = "0x600C10", VA = "0x180601A10")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x602EA0", Offset = "0x6020A0", VA = "0x180602EA0")]
	public void SetupWorldRect(bool use, Vector2 half_size, Vector3 center, Vector3 angle)
	{
	}

	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x6010C0", Offset = "0x6002C0", VA = "0x1806010C0")]
	public Vector2[] CloneViewPoints()
	{
		return null;
	}

	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x602EF0", Offset = "0x6020F0", VA = "0x180602EF0")]
	public RectSelectionItem()
	{
	}
}
