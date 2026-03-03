using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F12")]
public static class DuelLiveDef
{
	[Token(Token = "0x2000F13")]
	public class MenuID
	{
		[Token(Token = "0x400A5DC")]
		public const int None = 0;

		[Token(Token = "0x400A5DD")]
		public const int RankMatch = 1;

		[Token(Token = "0x400A5DE")]
		public const int FreeMatch = 2;

		[Token(Token = "0x400A5DF")]
		public const int WCS1stStage = 3;

		[Token(Token = "0x400A5E0")]
		public const int WCSTournament = 4;

		[Token(Token = "0x400A5E1")]
		public const int CardPack = 14;

		[Token(Token = "0x400A5E2")]
		public const int wcsGA = 17;

		[Token(Token = "0x400A5E3")]
		public const int wcsGB = 18;

		[Token(Token = "0x400A5E4")]
		public const int semiF1 = 19;

		[Token(Token = "0x400A5E5")]
		public const int semiF2 = 20;

		[Token(Token = "0x400A5E6")]
		public const int Final = 21;

		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MenuID()
		{
		}
	}

	[Token(Token = "0x2000F14")]
	public enum TemplateIdx
	{
		[Token(Token = "0x400A5E8")]
		ContainerTemplateIdx,
		[Token(Token = "0x400A5E9")]
		HeaderTemplateIdx,
		[Token(Token = "0x400A5EA")]
		EmptyTemplateIdx,
		[Token(Token = "0x400A5EB")]
		RandomTemplateIdx,
		[Token(Token = "0x400A5EC")]
		VsTemplateIdx,
		[Token(Token = "0x400A5ED")]
		EventTemplateIdx,
		[Token(Token = "0x400A5EE")]
		OfficialAccountTemplateIdx,
		[Token(Token = "0x400A5EF")]
		CommingSoonTemplateIdx,
		[Token(Token = "0x400A5F0")]
		GroupWCSTemplateIdx,
		[Token(Token = "0x400A5F1")]
		GroupWCSHeaderTemplateIdx,
		[Token(Token = "0x400A5F2")]
		GroupSubHeaderTemplateIdx,
		[Token(Token = "0x400A5F3")]
		GroupUrlButtonTemplateIdx,
		[Token(Token = "0x400A5F4")]
		GroupShopAreaHeader,
		[Token(Token = "0x400A5F5")]
		ProductWidget
	}

	[Token(Token = "0x2000F15")]
	public enum WidgetType
	{
		[Token(Token = "0x400A5F7")]
		Random = 1,
		[Token(Token = "0x400A5F8")]
		VS,
		[Token(Token = "0x400A5F9")]
		Event,
		[Token(Token = "0x400A5FA")]
		OfficialAccount,
		[Token(Token = "0x400A5FB")]
		CommingSoon,
		[Token(Token = "0x400A5FC")]
		VSNew
	}

	[Token(Token = "0x2000F16")]
	public enum MainTabButtonType
	{
		[Token(Token = "0x400A5FE")]
		Default,
		[Token(Token = "0x400A5FF")]
		PickUp,
		[Token(Token = "0x400A600")]
		WCS
	}

	[Token(Token = "0x6005B67")]
	[Address(RVA = "0xA08F80", Offset = "0xA08180", VA = "0x180A08F80")]
	public static bool isWCSMenu(int mid)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B68")]
	[Address(RVA = "0xA08F50", Offset = "0xA08150", VA = "0x180A08F50")]
	public static bool isCardPack(int mid)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B69")]
	[Address(RVA = "0xA08F70", Offset = "0xA08170", VA = "0x180A08F70")]
	public static bool isRecommendTab(int tid)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B6A")]
	[Address(RVA = "0xA08F60", Offset = "0xA08160", VA = "0x180A08F60")]
	public static bool isNewTemplateType(int widgetType)
	{
		return default(bool);
	}
}
