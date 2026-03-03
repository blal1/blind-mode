using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C5")]
[RequireComponent(typeof(TextMeshPro))]
[AddComponentMenu("Ygom/UI/Platform Overrider/TextMeshPro Overrider")]
public class PlatformTextMeshProOverrider : PlatformTextMeshProOverriderBase<TextMeshPro>
{
	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x69D000", Offset = "0x69C200", VA = "0x18069D000")]
	public PlatformTextMeshProOverrider()
	{
	}
}
