using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Extension;

[Token(Token = "0x200035D")]
public static class ImageExtension
{
	[Token(Token = "0x600150D")]
	[Address(RVA = "0x524280", Offset = "0x523480", VA = "0x180524280")]
	public static Vector2 SpriteNativeSize(this Image image)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600150E")]
	[Address(RVA = "0x5240F0", Offset = "0x5232F0", VA = "0x1805240F0")]
	public static Vector4 SpriteBorderNativeSize(this Image image)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600150F")]
	[Address(RVA = "0x523ED0", Offset = "0x5230D0", VA = "0x180523ED0")]
	public static Vector4 CalcBorderScale(this Image image)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6001510")]
	[Address(RVA = "0x523F90", Offset = "0x523190", VA = "0x180523F90")]
	public static Vector2 CalcTexRectScale(this Image image)
	{
		return default(Vector2);
	}
}
