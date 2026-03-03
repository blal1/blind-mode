using Il2CppDummyDll;

namespace YgomSystem.Hash;

[Token(Token = "0x200029B")]
public class AES
{
	[Token(Token = "0x4000EDB")]
	private const string AES_IV_256 = "q:!;L$OzYh(quOoY";

	[Token(Token = "0x4000EDC")]
	private const string AES_Key_256 = "9[u@JHurt)WTk4TA@INcco4ryseNL6+=";

	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0xE68480", Offset = "0xE67680", VA = "0x180E68480")]
	public static string Encrypt(string str, string iv = "q:!;L$OzYh(quOoY", string key = "9[u@JHurt)WTk4TA@INcco4ryseNL6+=")
	{
		return null;
	}

	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0xE67FC0", Offset = "0xE671C0", VA = "0x180E67FC0")]
	public static string Decrypt(string str, string iv = "q:!;L$OzYh(quOoY", string key = "9[u@JHurt)WTk4TA@INcco4ryseNL6+=")
	{
		return null;
	}

	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AES()
	{
	}
}
