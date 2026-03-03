using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003EA")]
public class Locale
{
	[Token(Token = "0x4001395")]
	public const string Japanese = "ja-JP";

	[Token(Token = "0x4001396")]
	public const string English = "en-US";

	[Token(Token = "0x4001397")]
	public const string French = "fr-FR";

	[Token(Token = "0x4001398")]
	public const string Italian = "it-IT";

	[Token(Token = "0x4001399")]
	public const string German = "de-DE";

	[Token(Token = "0x400139A")]
	public const string Spanish = "es-ES";

	[Token(Token = "0x400139B")]
	public const string Portuguese = "pt-BR";

	[Token(Token = "0x400139C")]
	public const string Korean = "ko-KR";

	[Token(Token = "0x400139D")]
	public const string TCH = "zh-TW";

	[Token(Token = "0x400139E")]
	public const string SCH = "zh-CN";

	[Token(Token = "0x400139F")]
	public const string DefaultLanguage = "en-US";

	[Token(Token = "0x40013A0")]
	private const string DefaultLanguageName = "English";

	[Token(Token = "0x40013A1")]
	[FieldOffset(Offset = "0x0")]
	private static string language;

	[Token(Token = "0x40013A2")]
	[FieldOffset(Offset = "0x8")]
	private static CultureInfo cultureInfo;

	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0x10")]
	private static List<string> supportedLanguages;

	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x18")]
	private static List<string> supportedReadableLanguages;

	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x20")]
	private static List<string> supportedVoices;

	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x28")]
	private static List<string> supportedReadableVoices;

	[Token(Token = "0x6001919")]
	[Address(RVA = "0x5CFDC0", Offset = "0x5CEFC0", VA = "0x1805CFDC0")]
	private static string normalizeLanguage(string lang, bool useDefault)
	{
		return null;
	}

	[Token(Token = "0x600191A")]
	[Address(RVA = "0x5D0350", Offset = "0x5CF550", VA = "0x1805D0350")]
	private static void setupLang(List<object> langs, List<string> languages, List<string> readables)
	{
	}

	[Token(Token = "0x600191B")]
	[Address(RVA = "0x5D0520", Offset = "0x5CF720", VA = "0x1805D0520")]
	private static void setup()
	{
	}

	[Token(Token = "0x600191C")]
	[Address(RVA = "0x5CF880", Offset = "0x5CEA80", VA = "0x1805CF880")]
	public static List<string> GetSupportedLanguages()
	{
		return null;
	}

	[Token(Token = "0x600191D")]
	[Address(RVA = "0x5CF9B0", Offset = "0x5CEBB0", VA = "0x1805CF9B0")]
	public static bool IsSupportedLanguage(string lang)
	{
		return default(bool);
	}

	[Token(Token = "0x600191E")]
	[Address(RVA = "0x5CF8E0", Offset = "0x5CEAE0", VA = "0x1805CF8E0")]
	public static List<string> GetSupportedVoices()
	{
		return null;
	}

	[Token(Token = "0x600191F")]
	[Address(RVA = "0x5CFB30", Offset = "0x5CED30", VA = "0x1805CFB30")]
	public static void SetLanguage(string lang)
	{
	}

	[Token(Token = "0x6001920")]
	[Address(RVA = "0x5CFA40", Offset = "0x5CEC40", VA = "0x1805CFA40")]
	public static void SetInitLanguage(string lang)
	{
	}

	[Token(Token = "0x6001921")]
	[Address(RVA = "0x5CF940", Offset = "0x5CEB40", VA = "0x1805CF940")]
	public static string GetVoice()
	{
		return null;
	}

	[Token(Token = "0x6001922")]
	[Address(RVA = "0x5CF3E0", Offset = "0x5CE5E0", VA = "0x1805CF3E0")]
	public static string GetLanguage()
	{
		return null;
	}

	[Token(Token = "0x6001923")]
	[Address(RVA = "0x5CF1D0", Offset = "0x5CE3D0", VA = "0x1805CF1D0")]
	public static CultureInfo GetCultureInfo()
	{
		return null;
	}

	[Token(Token = "0x6001924")]
	[Address(RVA = "0x5CF560", Offset = "0x5CE760", VA = "0x1805CF560")]
	public static string GetReadableLanguage(string lang)
	{
		return null;
	}

	[Token(Token = "0x6001925")]
	[Address(RVA = "0x5CF690", Offset = "0x5CE890", VA = "0x1805CF690")]
	public static List<string> GetReadableLanguages()
	{
		return null;
	}

	[Token(Token = "0x6001926")]
	[Address(RVA = "0x5CF270", Offset = "0x5CE470", VA = "0x1805CF270")]
	public static string GetCurrentReadableLanguage()
	{
		return null;
	}

	[Token(Token = "0x6001927")]
	[Address(RVA = "0x5CF820", Offset = "0x5CEA20", VA = "0x1805CF820")]
	public static List<string> GetReadableVoices()
	{
		return null;
	}

	[Token(Token = "0x6001928")]
	[Address(RVA = "0x5CF6F0", Offset = "0x5CE8F0", VA = "0x1805CF6F0")]
	public static string GetReadableVoice(string lang)
	{
		return null;
	}

	[Token(Token = "0x6001929")]
	[Address(RVA = "0x5CF130", Offset = "0x5CE330", VA = "0x1805CF130")]
	public static bool EnableVoices()
	{
		return default(bool);
	}

	[Token(Token = "0x600192A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Locale()
	{
	}
}
