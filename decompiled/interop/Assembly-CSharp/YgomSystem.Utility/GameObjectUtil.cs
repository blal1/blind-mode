using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003D8")]
public static class GameObjectUtil
{
	[Token(Token = "0x4001362")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] legacy_names;

	[Token(Token = "0x600189B")]
	[Address(RVA = "0x5C4EC0", Offset = "0x5C40C0", VA = "0x1805C4EC0")]
	public static GameObject FindInChildren(GameObject parent, string name, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x600189C")]
	[Address(RVA = "0x5C4FB0", Offset = "0x5C41B0", VA = "0x1805C4FB0")]
	public static GameObject FindWithPathInChildren(GameObject root, string path, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x600189D")]
	[Address(RVA = "0x5C5050", Offset = "0x5C4250", VA = "0x1805C5050")]
	private static GameObject FindWithPathInChildren(GameObject currentGo, string[] paths, int findIdx, bool includeInactive)
	{
		return null;
	}

	[Token(Token = "0x600189E")]
	public static T FindInChildren<T>(GameObject parent, string name, bool includeInactive = false) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600189F")]
	public static T FindInParent<T>(GameObject go) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x5C52D0", Offset = "0x5C44D0", VA = "0x1805C52D0")]
	public static bool IsParent(GameObject go, GameObject parent)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x5C5A60", Offset = "0x5C4C60", VA = "0x1805C5A60")]
	public static void SetX(this Transform transform, float x)
	{
	}

	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x5C5AD0", Offset = "0x5C4CD0", VA = "0x1805C5AD0")]
	public static void SetY(this Transform transform, float y)
	{
	}

	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x5C5B40", Offset = "0x5C4D40", VA = "0x1805C5B40")]
	public static void SetZ(this Transform transform, float z)
	{
	}

	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x5C5A00", Offset = "0x5C4C00", VA = "0x1805C5A00")]
	public static void SetXY(this Transform transform, Vector2 position)
	{
	}

	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x5C5990", Offset = "0x5C4B90", VA = "0x1805C5990")]
	public static void SetXY(this Transform transform, float x, float y)
	{
	}

	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x5C5710", Offset = "0x5C4910", VA = "0x1805C5710")]
	public static void SetLocalX(this Transform transform, float x)
	{
	}

	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x5C5780", Offset = "0x5C4980", VA = "0x1805C5780")]
	public static void SetLocalY(this Transform transform, float y)
	{
	}

	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x5C57F0", Offset = "0x5C49F0", VA = "0x1805C57F0")]
	public static void SetLocalZ(this Transform transform, float z)
	{
	}

	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x5C56B0", Offset = "0x5C48B0", VA = "0x1805C56B0")]
	public static void SetLocalXY(this Transform transform, Vector2 position)
	{
	}

	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x5C5850", Offset = "0x5C4A50", VA = "0x1805C5850")]
	public static void SetScaleX(this Transform transform, float x)
	{
	}

	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x5C58C0", Offset = "0x5C4AC0", VA = "0x1805C58C0")]
	public static void SetScaleY(this Transform transform, float y)
	{
	}

	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x5C5930", Offset = "0x5C4B30", VA = "0x1805C5930")]
	public static void SetScaleZ(this Transform transform, float z)
	{
	}

	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x5C5640", Offset = "0x5C4840", VA = "0x1805C5640")]
	public static void SetLocalXY(this Transform transform, float x, float y)
	{
	}

	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x5C5440", Offset = "0x5C4640", VA = "0x1805C5440")]
	public static void SetAnchorX(this RectTransform rect, float x)
	{
	}

	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x5C5490", Offset = "0x5C4690", VA = "0x1805C5490")]
	public static void SetAnchorY(this RectTransform rect, float y)
	{
	}

	[Token(Token = "0x60018B0")]
	[Address(RVA = "0x5C54E0", Offset = "0x5C46E0", VA = "0x1805C54E0")]
	public static void SetAnchorZ(this RectTransform rect, float z)
	{
	}

	[Token(Token = "0x60018B1")]
	[Address(RVA = "0x5C53F0", Offset = "0x5C45F0", VA = "0x1805C53F0")]
	public static void SetActiveEx(this GameObject go, bool active)
	{
	}

	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x5C4D30", Offset = "0x5C3F30", VA = "0x1805C4D30")]
	public static void DestroyMaterials(GameObject go, bool includeinactive = false)
	{
	}

	[Token(Token = "0x60018B3")]
	[Address(RVA = "0x5C51F0", Offset = "0x5C43F0", VA = "0x1805C51F0")]
	public static string GetReplacedLegacyShaderName(string name)
	{
		return null;
	}

	[Token(Token = "0x60018B4")]
	[Address(RVA = "0x5C5540", Offset = "0x5C4740", VA = "0x1805C5540")]
	public static void SetLayer(GameObject target, int layer, bool recursive = false)
	{
	}
}
