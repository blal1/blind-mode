using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Extension;

[Token(Token = "0x2000370")]
public static class TransformExtension
{
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x52F290", Offset = "0x52E490", VA = "0x18052F290")]
	public static bool ContainActiveChild(this Transform transform)
	{
		return default(bool);
	}

	[Token(Token = "0x600155D")]
	[Address(RVA = "0x52F450", Offset = "0x52E650", VA = "0x18052F450")]
	public static void DestroyChildren(this Transform transform)
	{
	}
}
