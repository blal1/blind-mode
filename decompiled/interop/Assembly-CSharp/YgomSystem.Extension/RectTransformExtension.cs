using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Extension;

[Token(Token = "0x200036B")]
public static class RectTransformExtension
{
	[Token(Token = "0x40011DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3[] s_Corners;

	[Token(Token = "0x6001536")]
	[Address(RVA = "0x5282C0", Offset = "0x5274C0", VA = "0x1805282C0")]
	public static void ToStretch(this RectTransform rectTransform)
	{
	}

	[Token(Token = "0x6001537")]
	[Address(RVA = "0x527E70", Offset = "0x527070", VA = "0x180527E70")]
	public static void ToNeutral(this RectTransform rectTransform)
	{
	}

	[Token(Token = "0x6001538")]
	[Address(RVA = "0x528120", Offset = "0x527320", VA = "0x180528120")]
	public static void ToRight(this RectTransform rectTransform)
	{
	}

	[Token(Token = "0x6001539")]
	[Address(RVA = "0x527FB0", Offset = "0x5271B0", VA = "0x180527FB0")]
	public static void ToRightStretch(this RectTransform rectTransform)
	{
	}

	[Token(Token = "0x600153A")]
	[Address(RVA = "0x527860", Offset = "0x526A60", VA = "0x180527860")]
	public static void ScaleEnvelopeParent(this RectTransform rectTransform, [Optional] RectTransform parent)
	{
	}

	[Token(Token = "0x600153B")]
	[Address(RVA = "0x5279D0", Offset = "0x526BD0", VA = "0x1805279D0")]
	public static void ScaleFitInParent(this RectTransform rectTransform, [Optional] RectTransform parent)
	{
	}

	[Token(Token = "0x600153C")]
	[Address(RVA = "0x526AA0", Offset = "0x525CA0", VA = "0x180526AA0")]
	public static void CaptureTo(this RectTransform rectTransform, RectTransform target)
	{
	}

	[Token(Token = "0x600153D")]
	[Address(RVA = "0x526DB0", Offset = "0x525FB0", VA = "0x180526DB0")]
	public static Camera GetCamera(this RectTransform rectTransform)
	{
		return null;
	}

	[Token(Token = "0x600153E")]
	[Address(RVA = "0x526E10", Offset = "0x526010", VA = "0x180526E10")]
	public static RectTransform GetParentRect(this RectTransform rectTransform)
	{
		return null;
	}

	[Token(Token = "0x600153F")]
	[Address(RVA = "0x526E70", Offset = "0x526070", VA = "0x180526E70")]
	public static Vector3 GetScreenPosition(this RectTransform rectTransform)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001540")]
	[Address(RVA = "0x527B40", Offset = "0x526D40", VA = "0x180527B40")]
	public static Vector3 ScreenToWorldPoint(this RectTransform rectTransform, Vector3 screenPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001541")]
	[Address(RVA = "0x527220", Offset = "0x526420", VA = "0x180527220")]
	public static bool IsContainRect(this RectTransform rectTransform, RectTransform checkRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6001542")]
	[Address(RVA = "0x527030", Offset = "0x526230", VA = "0x180527030")]
	public static bool IsContainRect(this RectTransform rectTransform, Canvas canvas, RectTransform checkRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6001543")]
	[Address(RVA = "0x527470", Offset = "0x526670", VA = "0x180527470")]
	public static bool IsInnerRect(this RectTransform rectTransform, RectTransform checkRect, bool onScreenPt = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001544")]
	[Address(RVA = "0x527520", Offset = "0x526720", VA = "0x180527520")]
	public static bool IsInnerRect(this RectTransform rectTransform, Canvas canvas, RectTransform checkRect, bool onScreenPt = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001545")]
	[Address(RVA = "0x526BE0", Offset = "0x525DE0", VA = "0x180526BE0")]
	private static Vector3[] ConvertWorldCornerToScreenCorner(Vector3[] worldCorner)
	{
		return null;
	}

	[Token(Token = "0x6001546")]
	[Address(RVA = "0x5266A0", Offset = "0x5258A0", VA = "0x1805266A0")]
	public static Bounds CalculateRelativeRectTransformBounds(this RectTransform root, RectTransform child, bool nest = false)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6001547")]
	[Address(RVA = "0x526F70", Offset = "0x526170", VA = "0x180526F70")]
	public static Vector2 GetSizeDeltaWithPlatformOverrider(this RectTransform rectTransform)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001548")]
	[Address(RVA = "0x527D60", Offset = "0x526F60", VA = "0x180527D60")]
	public static void SetSizeDeltaWithPlatformOverrider(this RectTransform rectTransform, Vector2 sizeDelta)
	{
	}
}
