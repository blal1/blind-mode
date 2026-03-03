using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x2000233")]
public static class TMP_FontAssetExtension
{
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0xD3A9B0", Offset = "0xD39BB0", VA = "0x180D3A9B0")]
	public static bool CheckClearDynamicGriph(this TMP_FontAsset self)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D13")]
	[Address(RVA = "0xD3AA20", Offset = "0xD39C20", VA = "0x180D3AA20")]
	public static void SearchDependencieFonts(this TMP_FontAsset self, List<TMP_FontAsset> searchList)
	{
	}

	[Token(Token = "0x6000D14")]
	[Address(RVA = "0xD3AD70", Offset = "0xD39F70", VA = "0x180D3AD70")]
	public static bool TryAddCharactersDependencies(this TMP_FontAsset self, List<TMP_FontAsset> searchList, string characters)
	{
		return default(bool);
	}
}
