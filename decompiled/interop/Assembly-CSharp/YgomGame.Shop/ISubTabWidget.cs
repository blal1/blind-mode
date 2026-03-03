using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x2000972")]
public interface ISubTabWidget
{
	[Token(Token = "0x1700078C")]
	SubTabGroupWidget parentGroup
	{
		[Token(Token = "0x60039A2")]
		get;
	}

	[Token(Token = "0x1700078D")]
	ShopTabWidget tabWidget
	{
		[Token(Token = "0x60039A3")]
		get;
	}
}
