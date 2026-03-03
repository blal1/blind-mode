using Il2CppDummyDll;
using Steamworks;

[Token(Token = "0x20000A3")]
public class SteamDefine
{
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x0")]
	public static AppId_t AppId;

	[Token(Token = "0x4000325")]
	public const string CryptoHash = "ebab0f004f390d657255dc643e1f48d393127093";

	[Token(Token = "0x4000326")]
	public const string HashSalt = "fdf864a787741797688055b7b22eaab52ee255f5";

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SteamDefine()
	{
	}
}
