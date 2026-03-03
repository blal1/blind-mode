using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.Utility;

[Token(Token = "0x2000920")]
public class TextTagConverter
{
	[Token(Token = "0x40089BF")]
	private const string k_CardQuestion = "?";

	[Token(Token = "0x40089C0")]
	private const string tagCardRegex = "<card(.+?)/>";

	[Token(Token = "0x40089C1")]
	private const string mrkRegex = "mrk\\s*=\\s*'\\d{4,5}'";

	[Token(Token = "0x40089C2")]
	private const string getCardRegex = "get\\s*=\\s*'.+'";

	[Token(Token = "0x40089C3")]
	private const string efxnoCardRegex = "efxno\\s*=\\s*'\\d{1,2}'";

	[Token(Token = "0x40089C4")]
	private const string paramMrkRegex = "'\\d{4,5}'";

	[Token(Token = "0x40089C5")]
	private const string paramGetCardRegex = "'.+'";

	[Token(Token = "0x40089C6")]
	private const string paramEfxnoCardRegex = "'\\d{1,2}'";

	[Token(Token = "0x40089C7")]
	private const string tagItemRegex = "<item(.+?)/>";

	[Token(Token = "0x40089C8")]
	private const string idRegex = "id\\s*=\\s*'\\d+'";

	[Token(Token = "0x40089C9")]
	private const string getItemRegex = "get\\s*=\\s*'(name|poss|type)'";

	[Token(Token = "0x40089CA")]
	private const string paramIdRegex = "'\\d+'";

	[Token(Token = "0x40089CB")]
	private const string paramGetItemRegex = "'(name|poss|type)'";

	[Token(Token = "0x40089CC")]
	private const string tagPeriodItemRegex = "<periodItem(.+?)/>";

	[Token(Token = "0x40089CD")]
	private const string categoryRegex = "category\\s*=\\s*'\\d+'";

	[Token(Token = "0x40089CE")]
	private const string tagCardPackRegex = "<cardpack(.+?)/>";

	[Token(Token = "0x40089CF")]
	private const string getCardPackRegex = "get\\s*=\\s*'name'";

	[Token(Token = "0x40089D0")]
	private const string paramGetCardPackRegex = "'name'";

	[Token(Token = "0x40089D1")]
	private const string idRegex2 = "id\\s*=\\s*'\\d{2}'";

	[Token(Token = "0x40089D2")]
	private const string idRegex3 = "id\\s*=\\s*'\\d{3}'";

	[Token(Token = "0x40089D3")]
	private const string tagModeRegex = "<mode(.+?)/>";

	[Token(Token = "0x40089D4")]
	private const string tagRankRegex = "<rank(.+?)/>";

	[Token(Token = "0x40089D5")]
	private const string tagTournamentRegex = "<tournament(.+?)/>";

	[Token(Token = "0x40089D6")]
	private const string tagExhibitionRegex = "<exhibition(.+?)/>";

	[Token(Token = "0x40089D7")]
	private const string tagRankEventRegex = "<(rankevent.+?)/>";

	[Token(Token = "0x40089D8")]
	private const string tagDuelistCupRegex = "<duelistcup(.+?)/>";

	[Token(Token = "0x40089D9")]
	private const string tagDuelTrialRegex = "<(dueltrial.+?)/>";

	[Token(Token = "0x40089DA")]
	private const string tagEventRegex = "<event(.+?)/>";

	[Token(Token = "0x40089DB")]
	private const string tagRarityRegex = "<rarity(.+?)/>";

	[Token(Token = "0x40089DC")]
	private const string tagPremiumRegex = "<prem(.+?)/>";

	[Token(Token = "0x40089DD")]
	private const string tagCategoryRegex = "<category(.+?)/>";

	[Token(Token = "0x40089DE")]
	private const string tagVoiceActorRegex = "<voiceactor(.+?)/>";

	[Token(Token = "0x40089DF")]
	private const string tagCwRegex = "<cw(.+?)/>";

	[Token(Token = "0x40089E0")]
	private const string pathRegex = "path\\s*=\\s*'(.+?)'";

	[Token(Token = "0x40089E1")]
	private const string paramRegex = "'(.+?)'";

	[Token(Token = "0x40089E2")]
	private const int startIdxComma = 1;

	[Token(Token = "0x40089E3")]
	private const int lengthComma = 2;

	[Token(Token = "0x1700068C")]
	private static Content cci
	{
		[Token(Token = "0x60036B3")]
		[Address(RVA = "0x7EA860", Offset = "0x7E9A60", VA = "0x1807EA860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60036B4")]
	[Address(RVA = "0x7E9B30", Offset = "0x7E8D30", VA = "0x1807E9B30")]
	public static string Convert(string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x60036B5")]
	[Address(RVA = "0x7EA0B0", Offset = "0x7E92B0", VA = "0x1807EA0B0")]
	public static void LoadDependencieTextDatas()
	{
	}

	[Token(Token = "0x60036B6")]
	[Address(RVA = "0x7EA700", Offset = "0x7E9900", VA = "0x1807EA700")]
	public static void UnloadDependencieTextDatas()
	{
	}

	[Token(Token = "0x60036B7")]
	[Address(RVA = "0x7E9EA0", Offset = "0x7E90A0", VA = "0x1807E9EA0")]
	private static int GetIdAsInt(string src)
	{
		return default(int);
	}

	[Token(Token = "0x60036B8")]
	[Address(RVA = "0x7E9DA0", Offset = "0x7E8FA0", VA = "0x1807E9DA0")]
	private static int GetCategoryAsInt(string src)
	{
		return default(int);
	}

	[Token(Token = "0x60036B9")]
	[Address(RVA = "0x7E9FA0", Offset = "0x7E91A0", VA = "0x1807E9FA0")]
	private static string GetPathStr(string src)
	{
		return null;
	}

	[Token(Token = "0x60036BA")]
	[Address(RVA = "0x7EA630", Offset = "0x7E9830", VA = "0x1807EA630")]
	private static void ReplaceMatch(ref string src, ref int diffIdx, Match match, string word)
	{
	}

	[Token(Token = "0x60036BB")]
	[Address(RVA = "0x7E7EB0", Offset = "0x7E70B0", VA = "0x1807E7EB0")]
	private static void ConvertNoBreakSpace(ref string src)
	{
	}

	[Token(Token = "0x60036BC")]
	[Address(RVA = "0x7E53A0", Offset = "0x7E45A0", VA = "0x1807E53A0")]
	private static void ConvertCardTag(ref string src)
	{
	}

	[Token(Token = "0x60036BD")]
	[Address(RVA = "0x7EA210", Offset = "0x7E9410", VA = "0x1807EA210")]
	private static string MakeDesc(int mrk, bool isAll = false)
	{
		return null;
	}

	[Token(Token = "0x60036BE")]
	[Address(RVA = "0x7EA520", Offset = "0x7E9720", VA = "0x1807EA520")]
	private static string MakeWithoutPendulumTag(int mrk)
	{
		return null;
	}

	[Token(Token = "0x60036BF")]
	[Address(RVA = "0x7E7980", Offset = "0x7E6B80", VA = "0x1807E7980")]
	private static void ConvertItemTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C0")]
	[Address(RVA = "0x7E8010", Offset = "0x7E7210", VA = "0x1807E8010")]
	private static void ConvertPeriodItemTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C1")]
	[Address(RVA = "0x7E4EB0", Offset = "0x7E40B0", VA = "0x1807E4EB0")]
	private static void ConvertCardPackTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C2")]
	[Address(RVA = "0x7E62C0", Offset = "0x7E54C0", VA = "0x1807E62C0")]
	private static void ConvertCategoryTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C3")]
	[Address(RVA = "0x7E6AC0", Offset = "0x7E5CC0", VA = "0x1807E6AC0")]
	private static void ConvertDuelModeTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C4")]
	[Address(RVA = "0x7E8C70", Offset = "0x7E7E70", VA = "0x1807E8C70")]
	private static void ConvertRankTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C5")]
	[Address(RVA = "0x7E93D0", Offset = "0x7E85D0", VA = "0x1807E93D0")]
	private static void ConvertTournamentNameTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C6")]
	[Address(RVA = "0x7E75D0", Offset = "0x7E67D0", VA = "0x1807E75D0")]
	private static void ConvertExhibitionNameTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C7")]
	[Address(RVA = "0x7E88C0", Offset = "0x7E7AC0", VA = "0x1807E88C0")]
	private static void ConvertRankEventNameTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C8")]
	[Address(RVA = "0x7E7220", Offset = "0x7E6420", VA = "0x1807E7220")]
	private static void ConvertDuelistCupNameTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036C9")]
	[Address(RVA = "0x7E6E70", Offset = "0x7E6070", VA = "0x1807E6E70")]
	private static void ConvertDuelTrialNameTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036CA")]
	[Address(RVA = "0x7E9020", Offset = "0x7E8220", VA = "0x1807E9020")]
	private static void ConvertRarityNameTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036CB")]
	[Address(RVA = "0x7E8510", Offset = "0x7E7710", VA = "0x1807E8510")]
	private static void ConvertPremiumNameTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036CC")]
	[Address(RVA = "0x7E6670", Offset = "0x7E5870", VA = "0x1807E6670")]
	private static void ConvertClientWorkPath(ref string src)
	{
	}

	[Token(Token = "0x60036CD")]
	[Address(RVA = "0x7E9780", Offset = "0x7E8980", VA = "0x1807E9780")]
	private static void ConvertVoiceActorTag(ref string src, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036CE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TextTagConverter()
	{
	}
}
