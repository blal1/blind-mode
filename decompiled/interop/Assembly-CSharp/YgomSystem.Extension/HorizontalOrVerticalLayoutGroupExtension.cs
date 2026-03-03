using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Extension;

[Token(Token = "0x200035A")]
public static class HorizontalOrVerticalLayoutGroupExtension
{
	[Token(Token = "0x6001500")]
	[Address(RVA = "0x523D50", Offset = "0x522F50", VA = "0x180523D50")]
	public static RectOffset GetPaddingWithPlatformOverrider(this HorizontalOrVerticalLayoutGroup lg)
	{
		return null;
	}

	[Token(Token = "0x6001501")]
	[Address(RVA = "0x523E10", Offset = "0x523010", VA = "0x180523E10")]
	public static float GetSpacingWithPlatformOverrider(this HorizontalOrVerticalLayoutGroup lg)
	{
		return default(float);
	}
}
