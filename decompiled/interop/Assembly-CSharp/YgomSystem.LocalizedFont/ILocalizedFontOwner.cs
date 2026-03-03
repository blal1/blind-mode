using Il2CppDummyDll;

namespace YgomSystem.LocalizedFont;

[Token(Token = "0x200028E")]
public interface ILocalizedFontOwner
{
	[Token(Token = "0x17000184")]
	LocalizedFontSettingsBase.FontType localizedFontType
	{
		[Token(Token = "0x6000FA8")]
		get;
		[Token(Token = "0x6000FA9")]
		set;
	}

	[Token(Token = "0x17000185")]
	int localizedFontMaterialIndex
	{
		[Token(Token = "0x6000FAA")]
		get;
		[Token(Token = "0x6000FAB")]
		set;
	}
}
