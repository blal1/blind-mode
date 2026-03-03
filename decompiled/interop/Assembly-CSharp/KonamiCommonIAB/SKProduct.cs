using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200011C")]
public struct SKProduct
{
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x0")]
	public string localizedDescription;

	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x8")]
	public string localizedTitle;

	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x10")]
	public float price;

	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x18")]
	public string currency;

	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x20")]
	public string productIdentifier;

	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x28")]
	public string displayedPrice;

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void print(string header)
	{
	}
}
