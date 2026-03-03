using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x2000118")]
public abstract class Result
{
	[Token(Token = "0x40006A6")]
	public const int IAP_SUCCESS = 0;

	[Token(Token = "0x40006A7")]
	public const int IAP_FAILED = -1;

	[Token(Token = "0x40006A8")]
	public const int IAP_CANCEL = -2;

	[Token(Token = "0x40006A9")]
	public const int IAP_DEFERRED = -3;

	[Token(Token = "0x40006AA")]
	public const int IAP_REFUNDED = -4;

	[Token(Token = "0x1700008F")]
	public abstract int code
	{
		[Token(Token = "0x60006F5")]
		get;
	}

	[Token(Token = "0x60006F6")]
	public abstract int getResponse();

	[Token(Token = "0x60006F7")]
	public abstract string getMessage();

	[Token(Token = "0x60006F8")]
	public abstract bool isSuccess();

	[Token(Token = "0x60006F9")]
	public abstract bool isFailure();

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected Result()
	{
	}
}
