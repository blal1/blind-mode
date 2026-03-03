using Il2CppDummyDll;

namespace YgomSystem.Extension;

[Token(Token = "0x2000362")]
public static class NumberExtension
{
	[Token(Token = "0x6001518")]
	[Address(RVA = "0x524C90", Offset = "0x523E90", VA = "0x180524C90")]
	public static string ToCommaString(this int number)
	{
		return null;
	}

	[Token(Token = "0x6001519")]
	[Address(RVA = "0x524C80", Offset = "0x523E80", VA = "0x180524C80")]
	public static string ToCommaString(this long number)
	{
		return null;
	}

	[Token(Token = "0x600151A")]
	[Address(RVA = "0x525010", Offset = "0x524210", VA = "0x180525010")]
	public static string ToPcodeFormatString(this long pcode)
	{
		return null;
	}

	[Token(Token = "0x600151B")]
	[Address(RVA = "0x524CA0", Offset = "0x523EA0", VA = "0x180524CA0")]
	public static string ToItemNumString(this int itemNum, bool isPeriod, int itemCategory, int itemId, bool trySkipNum = false)
	{
		return null;
	}

	[Token(Token = "0x600151C")]
	[Address(RVA = "0x525070", Offset = "0x524270", VA = "0x180525070")]
	public static string ToUnitFormatString(this long number, string lang = "")
	{
		return null;
	}

	[Token(Token = "0x600151D")]
	[Address(RVA = "0x524C60", Offset = "0x523E60", VA = "0x180524C60")]
	public static float DivideByZeroChecks(float top, float bottom, float failedValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x600151E")]
	[Address(RVA = "0x524E70", Offset = "0x524070", VA = "0x180524E70")]
	public static string ToOrdinal(this int number)
	{
		return null;
	}

	[Token(Token = "0x600151F")]
	[Address(RVA = "0x524D80", Offset = "0x523F80", VA = "0x180524D80")]
	public static string ToMonthName(this int month, bool isShort = false)
	{
		return null;
	}
}
