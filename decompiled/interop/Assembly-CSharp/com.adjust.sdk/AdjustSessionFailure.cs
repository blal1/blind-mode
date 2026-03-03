using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DE3")]
public class AdjustSessionFailure
{
	[Token(Token = "0x17001C76")]
	public string Adid
	{
		[Token(Token = "0x600BFAB")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFAC")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C77")]
	public string Message
	{
		[Token(Token = "0x600BFAD")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFAE")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C78")]
	public string Timestamp
	{
		[Token(Token = "0x600BFAF")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFB0")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C79")]
	public bool WillRetry
	{
		[Token(Token = "0x600BFB1")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600BFB2")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C7A")]
	public Dictionary<string, object> JsonResponse
	{
		[Token(Token = "0x600BFB3")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BFB4")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600BFB5")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AdjustSessionFailure()
	{
	}

	[Token(Token = "0x600BFB6")]
	[Address(RVA = "0x598260", Offset = "0x597460", VA = "0x180598260")]
	public AdjustSessionFailure(Dictionary<string, string> sessionFailureDataMap)
	{
	}

	[Token(Token = "0x600BFB7")]
	[Address(RVA = "0x5984C0", Offset = "0x5976C0", VA = "0x1805984C0")]
	public AdjustSessionFailure(string jsonString)
	{
	}

	[Token(Token = "0x600BFB8")]
	[Address(RVA = "0x598120", Offset = "0x597320", VA = "0x180598120")]
	public void BuildJsonResponseFromString(string jsonResponseString)
	{
	}

	[Token(Token = "0x600BFB9")]
	[Address(RVA = "0x598210", Offset = "0x597410", VA = "0x180598210")]
	public string GetJsonResponse()
	{
		return null;
	}
}
