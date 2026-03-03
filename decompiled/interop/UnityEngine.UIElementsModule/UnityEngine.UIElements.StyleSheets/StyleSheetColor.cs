using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005D0")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal static class StyleSheetColor
{
	[Token(Token = "0x4001571")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Color32> s_NameToColor;

	[Token(Token = "0x6002890")]
	[Address(RVA = "0x2A8B4A0", Offset = "0x2A8A6A0", VA = "0x182A8B4A0")]
	public static bool TryGetColor(string name, out Color color)
	{
		return default(bool);
	}

	[Token(Token = "0x6002891")]
	[Address(RVA = "0x2A8B480", Offset = "0x2A8A680", VA = "0x182A8B480")]
	private static Color32 HexToColor32(uint color)
	{
		return default(Color32);
	}
}
