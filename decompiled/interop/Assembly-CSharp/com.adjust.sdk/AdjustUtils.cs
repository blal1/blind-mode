using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DE8")]
public class AdjustUtils
{
	[Token(Token = "0x401061C")]
	[FieldOffset(Offset = "0x0")]
	public static string KeyAdid;

	[Token(Token = "0x401061D")]
	[FieldOffset(Offset = "0x8")]
	public static string KeyMessage;

	[Token(Token = "0x401061E")]
	[FieldOffset(Offset = "0x10")]
	public static string KeyNetwork;

	[Token(Token = "0x401061F")]
	[FieldOffset(Offset = "0x18")]
	public static string KeyAdgroup;

	[Token(Token = "0x4010620")]
	[FieldOffset(Offset = "0x20")]
	public static string KeyCampaign;

	[Token(Token = "0x4010621")]
	[FieldOffset(Offset = "0x28")]
	public static string KeyCreative;

	[Token(Token = "0x4010622")]
	[FieldOffset(Offset = "0x30")]
	public static string KeyWillRetry;

	[Token(Token = "0x4010623")]
	[FieldOffset(Offset = "0x38")]
	public static string KeyTimestamp;

	[Token(Token = "0x4010624")]
	[FieldOffset(Offset = "0x40")]
	public static string KeyCallbackId;

	[Token(Token = "0x4010625")]
	[FieldOffset(Offset = "0x48")]
	public static string KeyEventToken;

	[Token(Token = "0x4010626")]
	[FieldOffset(Offset = "0x50")]
	public static string KeyClickLabel;

	[Token(Token = "0x4010627")]
	[FieldOffset(Offset = "0x58")]
	public static string KeyTrackerName;

	[Token(Token = "0x4010628")]
	[FieldOffset(Offset = "0x60")]
	public static string KeyTrackerToken;

	[Token(Token = "0x4010629")]
	[FieldOffset(Offset = "0x68")]
	public static string KeyJsonResponse;

	[Token(Token = "0x401062A")]
	[FieldOffset(Offset = "0x70")]
	public static string KeyCostType;

	[Token(Token = "0x401062B")]
	[FieldOffset(Offset = "0x78")]
	public static string KeyCostAmount;

	[Token(Token = "0x401062C")]
	[FieldOffset(Offset = "0x80")]
	public static string KeyCostCurrency;

	[Token(Token = "0x401062D")]
	[FieldOffset(Offset = "0x88")]
	public static string KeyFbInstallReferrer;

	[Token(Token = "0x401062E")]
	[FieldOffset(Offset = "0x90")]
	public static string KeySkadConversionValue;

	[Token(Token = "0x401062F")]
	[FieldOffset(Offset = "0x98")]
	public static string KeySkadCoarseValue;

	[Token(Token = "0x4010630")]
	[FieldOffset(Offset = "0xA0")]
	public static string KeySkadLockWindow;

	[Token(Token = "0x4010631")]
	[FieldOffset(Offset = "0xA8")]
	public static string KeyTestOptionsBaseUrl;

	[Token(Token = "0x4010632")]
	[FieldOffset(Offset = "0xB0")]
	public static string KeyTestOptionsGdprUrl;

	[Token(Token = "0x4010633")]
	[FieldOffset(Offset = "0xB8")]
	public static string KeyTestOptionsSubscriptionUrl;

	[Token(Token = "0x4010634")]
	[FieldOffset(Offset = "0xC0")]
	public static string KeyTestOptionsExtraPath;

	[Token(Token = "0x4010635")]
	[FieldOffset(Offset = "0xC8")]
	public static string KeyTestOptionsBasePath;

	[Token(Token = "0x4010636")]
	[FieldOffset(Offset = "0xD0")]
	public static string KeyTestOptionsGdprPath;

	[Token(Token = "0x4010637")]
	[FieldOffset(Offset = "0xD8")]
	public static string KeyTestOptionsDeleteState;

	[Token(Token = "0x4010638")]
	[FieldOffset(Offset = "0xE0")]
	public static string KeyTestOptionsUseTestConnectionOptions;

	[Token(Token = "0x4010639")]
	[FieldOffset(Offset = "0xE8")]
	public static string KeyTestOptionsTimerIntervalInMilliseconds;

	[Token(Token = "0x401063A")]
	[FieldOffset(Offset = "0xF0")]
	public static string KeyTestOptionsTimerStartInMilliseconds;

	[Token(Token = "0x401063B")]
	[FieldOffset(Offset = "0xF8")]
	public static string KeyTestOptionsSessionIntervalInMilliseconds;

	[Token(Token = "0x401063C")]
	[FieldOffset(Offset = "0x100")]
	public static string KeyTestOptionsSubsessionIntervalInMilliseconds;

	[Token(Token = "0x401063D")]
	[FieldOffset(Offset = "0x108")]
	public static string KeyTestOptionsTeardown;

	[Token(Token = "0x401063E")]
	[FieldOffset(Offset = "0x110")]
	public static string KeyTestOptionsNoBackoffWait;

	[Token(Token = "0x401063F")]
	[FieldOffset(Offset = "0x118")]
	public static string KeyTestOptionsAdServicesFrameworkEnabled;

	[Token(Token = "0x600BFCB")]
	[Address(RVA = "0x5994A0", Offset = "0x5986A0", VA = "0x1805994A0")]
	public static int ConvertLogLevel(AdjustLogLevel? logLevel)
	{
		return default(int);
	}

	[Token(Token = "0x600BFCC")]
	[Address(RVA = "0x5990B0", Offset = "0x5982B0", VA = "0x1805990B0")]
	public static int ConvertBool(bool? value)
	{
		return default(int);
	}

	[Token(Token = "0x600BFCD")]
	[Address(RVA = "0x599120", Offset = "0x598320", VA = "0x180599120")]
	public static double ConvertDouble(double? value)
	{
		return default(double);
	}

	[Token(Token = "0x600BFCE")]
	[Address(RVA = "0x599180", Offset = "0x598380", VA = "0x180599180")]
	public static int ConvertInt(int? value)
	{
		return default(int);
	}

	[Token(Token = "0x600BFCF")]
	[Address(RVA = "0x599500", Offset = "0x598700", VA = "0x180599500")]
	public static long ConvertLong(long? value)
	{
		return default(long);
	}

	[Token(Token = "0x600BFD0")]
	[Address(RVA = "0x5991E0", Offset = "0x5983E0", VA = "0x1805991E0")]
	public static string ConvertListToJson(List<string> list)
	{
		return null;
	}

	[Token(Token = "0x600BFD1")]
	[Address(RVA = "0x599560", Offset = "0x598760", VA = "0x180599560")]
	public static string GetJsonResponseCompact(Dictionary<string, object> dictionary)
	{
		return null;
	}

	[Token(Token = "0x600BFD2")]
	[Address(RVA = "0x599A90", Offset = "0x598C90", VA = "0x180599A90")]
	public static string GetJsonString(JSONNode node, string key)
	{
		return null;
	}

	[Token(Token = "0x600BFD3")]
	[Address(RVA = "0x599E70", Offset = "0x599070", VA = "0x180599E70")]
	public static void WriteJsonResponseDictionary(JSONClass jsonObject, Dictionary<string, object> output)
	{
	}

	[Token(Token = "0x600BFD4")]
	[Address(RVA = "0x599DC0", Offset = "0x598FC0", VA = "0x180599DC0")]
	public static string TryGetValue(Dictionary<string, string> dictionary, string key)
	{
		return null;
	}

	[Token(Token = "0x600BFD5")]
	[Address(RVA = "0x599C40", Offset = "0x598E40", VA = "0x180599C40")]
	public static int GetSkad4ConversionValue(string conversionValueUpdate)
	{
		return default(int);
	}

	[Token(Token = "0x600BFD6")]
	[Address(RVA = "0x599BB0", Offset = "0x598DB0", VA = "0x180599BB0")]
	public static string GetSkad4CoarseValue(string conversionValueUpdate)
	{
		return null;
	}

	[Token(Token = "0x600BFD7")]
	[Address(RVA = "0x599D00", Offset = "0x598F00", VA = "0x180599D00")]
	public static bool GetSkad4LockWindow(string conversionValueUpdate)
	{
		return default(bool);
	}

	[Token(Token = "0x600BFD8")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AdjustUtils()
	{
	}
}
