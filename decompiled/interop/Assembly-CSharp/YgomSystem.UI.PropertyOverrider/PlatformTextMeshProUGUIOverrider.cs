using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C7")]
[RequireComponent(typeof(TextMeshProUGUI))]
[AddComponentMenu("Ygom/UI/Platform Overrider/TextMeshProUGUI Overrider")]
public class PlatformTextMeshProUGUIOverrider : PlatformTextMeshProOverriderBase<TextMeshProUGUI>
{
	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x69D040", Offset = "0x69C240", VA = "0x18069D040")]
	public PlatformTextMeshProUGUIOverrider()
	{
	}
}
