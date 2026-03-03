using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200010E")]
public abstract class BillingConfig
{
	[Token(Token = "0x17000085")]
	public abstract string code
	{
		[Token(Token = "0x60006CC")]
		get;
	}

	[Token(Token = "0x60006CD")]
	public abstract string getCountryCode();

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BillingConfig()
	{
	}
}
