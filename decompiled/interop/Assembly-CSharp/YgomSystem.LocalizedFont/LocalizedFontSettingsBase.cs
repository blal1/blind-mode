using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.LocalizedFont;

[Token(Token = "0x200028F")]
public abstract class LocalizedFontSettingsBase : ScriptableObject
{
	[Token(Token = "0x2000290")]
	public enum Locale
	{
		[Token(Token = "0x4000EAD")]
		Other,
		[Token(Token = "0x4000EAE")]
		Japanese,
		[Token(Token = "0x4000EAF")]
		Korean,
		[Token(Token = "0x4000EB0")]
		TraditionalChinese,
		[Token(Token = "0x4000EB1")]
		SimplifiedChinese
	}

	[Token(Token = "0x2000291")]
	public enum FontType
	{
		[Token(Token = "0x4000EB3")]
		Other,
		[Token(Token = "0x4000EB4")]
		Normal,
		[Token(Token = "0x4000EB5")]
		Card,
		[Token(Token = "0x4000EB6")]
		Bold,
		[Token(Token = "0x4000EB7")]
		Story,
		[Token(Token = "0x4000EB8")]
		BigMenu
	}

	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	protected LocalizedFontSettingsBase()
	{
	}
}
