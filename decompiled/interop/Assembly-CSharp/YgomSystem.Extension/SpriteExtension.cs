using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Extension;

[Token(Token = "0x200036D")]
public static class SpriteExtension
{
	[Token(Token = "0x600154B")]
	[Address(RVA = "0x52A8C0", Offset = "0x529AC0", VA = "0x18052A8C0")]
	public static Rect CalcUVRect(this Sprite sprite)
	{
		return default(Rect);
	}

	[Token(Token = "0x600154C")]
	[Address(RVA = "0x52A650", Offset = "0x529850", VA = "0x18052A650")]
	public static Vector4 CalcAtlasMinMax(this Sprite sprite)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600154D")]
	[Address(RVA = "0x52A760", Offset = "0x529960", VA = "0x18052A760")]
	public static Vector4 CalcSliceBorderScale(this Sprite sprite)
	{
		return default(Vector4);
	}
}
