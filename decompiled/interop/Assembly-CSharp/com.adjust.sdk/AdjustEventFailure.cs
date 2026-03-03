using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DDE")]
public class AdjustEventFailure
{
	[Token(Token = "0x17001C69")]
	public string Adid
	{
		[Token(Token = "0x600BF81")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF82")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C6A")]
	public string Message
	{
		[Token(Token = "0x600BF83")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF84")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C6B")]
	public string Timestamp
	{
		[Token(Token = "0x600BF85")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF86")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C6C")]
	public string EventToken
	{
		[Token(Token = "0x600BF87")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF88")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C6D")]
	public string CallbackId
	{
		[Token(Token = "0x600BF89")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF8A")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C6E")]
	public bool WillRetry
	{
		[Token(Token = "0x600BF8B")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600BF8C")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C6F")]
	public Dictionary<string, object> JsonResponse
	{
		[Token(Token = "0x600BF8D")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF8E")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600BF8F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AdjustEventFailure()
	{
	}

	[Token(Token = "0x600BF90")]
	[Address(RVA = "0x596BB0", Offset = "0x595DB0", VA = "0x180596BB0")]
	public AdjustEventFailure(Dictionary<string, string> eventFailureDataMap)
	{
	}

	[Token(Token = "0x600BF91")]
	[Address(RVA = "0x596E70", Offset = "0x596070", VA = "0x180596E70")]
	public AdjustEventFailure(string jsonString)
	{
	}

	[Token(Token = "0x600BF92")]
	[Address(RVA = "0x596A70", Offset = "0x595C70", VA = "0x180596A70")]
	public void BuildJsonResponseFromString(string jsonResponseString)
	{
	}

	[Token(Token = "0x600BF93")]
	[Address(RVA = "0x596B60", Offset = "0x595D60", VA = "0x180596B60")]
	public string GetJsonResponse()
	{
		return null;
	}
}
