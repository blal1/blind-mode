using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using YgomGame.MDMarkup;

namespace YgomSystem.Home;

[Token(Token = "0x200038E")]
public class TopicsBannerParser
{
	[Token(Token = "0x200038F")]
	public enum ClientPattern
	{
		[Token(Token = "0x4001244")]
		SHOP = 1,
		[Token(Token = "0x4001245")]
		EVENT,
		[Token(Token = "0x4001246")]
		SOLO,
		[Token(Token = "0x4001247")]
		OTHER,
		[Token(Token = "0x4001248")]
		SPECIAL
	}

	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string k_AdditionalSettingPath;

	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string k_ExtraSettingPath;

	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string k_KeyClientId;

	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x18")]
	private static readonly string k_KeyClientPattern;

	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x20")]
	private static readonly string k_KeyClientExtra;

	[Token(Token = "0x400123D")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string k_KeyPrefPath;

	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string k_KeyBackImage;

	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string k_KeyCardTextureId;

	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string k_KeyEventLogo;

	[Token(Token = "0x4001241")]
	[FieldOffset(Offset = "0x48")]
	private static readonly string k_RegexLabel;

	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0x50")]
	private static readonly string k_RegexColor;

	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x52BD90", Offset = "0x52AF90", VA = "0x18052BD90")]
	public static MDMarkupBannerContext Merge(MDMarkupBannerContext bannerContext)
	{
		return null;
	}

	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x52E800", Offset = "0x52DA00", VA = "0x18052E800")]
	public static object TopicsTagConvert(string targetTxt, Dictionary<string, object> prefArgs)
	{
		return null;
	}

	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x52E3F0", Offset = "0x52D5F0", VA = "0x18052E3F0")]
	private static string TopicsTagConvertToLabel(string targetTxt, Dictionary<string, object> prefArgsJson, Regex tagTopicsRegex)
	{
		return null;
	}

	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x52EAF0", Offset = "0x52DCF0", VA = "0x18052EAF0")]
	private static bool TopicsTagReplaceAllToColor(object target, Regex tagTopicsRegex, out Dictionary<string, object> resultDic)
	{
		return default(bool);
	}

	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x52C9F0", Offset = "0x52BBF0", VA = "0x18052C9F0")]
	private static void Parse(int client_pattern, string client_id, List<object> client_extra, out string tmpPrefPath, out Dictionary<string, object> tmpPrefArgs)
	{
	}

	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
	private static void ParseExtra(List<object> client_extra, ref string tmpPrefPath, ref Dictionary<string, object> tmpPrefArgs)
	{
	}

	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x52E230", Offset = "0x52D430", VA = "0x18052E230")]
	private static int[] ReuseColosseumLogo(string client_id)
	{
		return null;
	}

	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TopicsBannerParser()
	{
	}
}
