using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.LocalizedFont;

[Token(Token = "0x2000299")]
[CreateAssetMenu(menuName = "Scriptable Object/TMPフォントローカライズ設定")]
public class LocalizedTMPFontSettings : LocalizedFontSettings<TMP_FontAsset>
{
	[Token(Token = "0x4000ED7")]
	private const string SETTING_PATH = "ScriptableObjects/LocalizedFont/LocalizedTMPFontSettings";

	[Token(Token = "0x4000ED8")]
	[FieldOffset(Offset = "0x0")]
	private static LocalizedTMPFontSettings s_instance;

	[Token(Token = "0x17000186")]
	public static LocalizedTMPFontSettings Instance
	{
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0xE6FB50", Offset = "0xE6ED50", VA = "0x180E6FB50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000187")]
	public static bool isReady
	{
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0xE6FCA0", Offset = "0xE6EEA0", VA = "0x180E6FCA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0xE6FAF0", Offset = "0xE6ECF0", VA = "0x180E6FAF0", Slot = "4")]
	protected override string GetFontName(TMP_FontAsset font)
	{
		return null;
	}

	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0xE6FAD0", Offset = "0xE6ECD0", VA = "0x180E6FAD0", Slot = "5")]
	protected override Material GetFontMaterial(TMP_FontAsset font)
	{
		return null;
	}

	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0xE6FB10", Offset = "0xE6ED10", VA = "0x180E6FB10")]
	public LocalizedTMPFontSettings()
	{
	}
}
