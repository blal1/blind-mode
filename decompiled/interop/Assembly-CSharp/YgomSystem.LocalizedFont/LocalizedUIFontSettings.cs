using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.LocalizedFont;

[Token(Token = "0x200029A")]
[CreateAssetMenu(menuName = "Scriptable Object/旧フォントローカライズ設定")]
public class LocalizedUIFontSettings : LocalizedFontSettings<Font>
{
	[Token(Token = "0x4000ED9")]
	private const string SETTING_PATH = "ScriptableObjects/LocalizedFont/LocalizedUIFontSettings";

	[Token(Token = "0x4000EDA")]
	[FieldOffset(Offset = "0x0")]
	private static LocalizedUIFontSettings s_instance;

	[Token(Token = "0x17000188")]
	public static LocalizedUIFontSettings Instance
	{
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0xE6FD90", Offset = "0xE6EF90", VA = "0x180E6FD90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000189")]
	public static bool isReady
	{
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0xE6FEE0", Offset = "0xE6F0E0", VA = "0x180E6FEE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0xE6FAF0", Offset = "0xE6ECF0", VA = "0x180E6FAF0", Slot = "4")]
	protected override string GetFontName(Font font)
	{
		return null;
	}

	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0xE6FD50", Offset = "0xE6EF50", VA = "0x180E6FD50")]
	public LocalizedUIFontSettings()
	{
	}
}
