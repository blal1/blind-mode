using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DE4")]
public class AdjustSessionSuccess
{
	[Token(Token = "0x17001C7B")]
	public string Adid
	{
		[Token(Token = "0x600BFBA")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFBB")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C7C")]
	public string Message
	{
		[Token(Token = "0x600BFBC")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFBD")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C7D")]
	public string Timestamp
	{
		[Token(Token = "0x600BFBE")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFBF")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C7E")]
	public Dictionary<string, object> JsonResponse
	{
		[Token(Token = "0x600BFC0")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFC1")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600BFC2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AdjustSessionSuccess()
	{
	}

	[Token(Token = "0x600BFC3")]
	[Address(RVA = "0x598860", Offset = "0x597A60", VA = "0x180598860")]
	public AdjustSessionSuccess(Dictionary<string, string> sessionSuccessDataMap)
	{
	}

	[Token(Token = "0x600BFC4")]
	[Address(RVA = "0x598A50", Offset = "0x597C50", VA = "0x180598A50")]
	public AdjustSessionSuccess(string jsonString)
	{
	}

	[Token(Token = "0x600BFC5")]
	[Address(RVA = "0x598720", Offset = "0x597920", VA = "0x180598720")]
	public void BuildJsonResponseFromString(string jsonResponseString)
	{
	}

	[Token(Token = "0x600BFC6")]
	[Address(RVA = "0x598810", Offset = "0x597A10", VA = "0x180598810")]
	public string GetJsonResponse()
	{
		return null;
	}
}
