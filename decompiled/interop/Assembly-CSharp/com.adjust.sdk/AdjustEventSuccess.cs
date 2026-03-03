using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DDF")]
public class AdjustEventSuccess
{
	[Token(Token = "0x17001C70")]
	public string Adid
	{
		[Token(Token = "0x600BF94")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF95")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C71")]
	public string Message
	{
		[Token(Token = "0x600BF96")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF97")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C72")]
	public string Timestamp
	{
		[Token(Token = "0x600BF98")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF99")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C73")]
	public string EventToken
	{
		[Token(Token = "0x600BF9A")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF9B")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C74")]
	public string CallbackId
	{
		[Token(Token = "0x600BF9C")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF9D")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C75")]
	public Dictionary<string, object> JsonResponse
	{
		[Token(Token = "0x600BF9E")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BF9F")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600BFA0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AdjustEventSuccess()
	{
	}

	[Token(Token = "0x600BFA1")]
	[Address(RVA = "0x597270", Offset = "0x596470", VA = "0x180597270")]
	public AdjustEventSuccess(Dictionary<string, string> eventSuccessDataMap)
	{
	}

	[Token(Token = "0x600BFA2")]
	[Address(RVA = "0x5974C0", Offset = "0x5966C0", VA = "0x1805974C0")]
	public AdjustEventSuccess(string jsonString)
	{
	}

	[Token(Token = "0x600BFA3")]
	[Address(RVA = "0x597130", Offset = "0x596330", VA = "0x180597130")]
	public void BuildJsonResponseFromString(string jsonResponseString)
	{
	}

	[Token(Token = "0x600BFA4")]
	[Address(RVA = "0x597220", Offset = "0x596420", VA = "0x180597220")]
	public string GetJsonResponse()
	{
		return null;
	}
}
