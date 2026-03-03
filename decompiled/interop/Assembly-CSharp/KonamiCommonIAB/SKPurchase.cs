using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200011D")]
public struct SKPurchase
{
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x0")]
	public int result;

	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x8")]
	public string productIdentifier;

	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x10")]
	public string transactionId;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x18")]
	public string jws;

	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x20")]
	public string appUsername;
}
