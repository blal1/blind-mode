using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x200092A")]
public interface IShopProductGruopData
{
	[Token(Token = "0x17000717")]
	int groupId
	{
		[Token(Token = "0x6003793")]
		get;
	}

	[Token(Token = "0x17000718")]
	string labelTextId
	{
		[Token(Token = "0x6003794")]
		get;
	}

	[Token(Token = "0x17000719")]
	string labelText
	{
		[Token(Token = "0x6003795")]
		get;
	}

	[Token(Token = "0x1700071A")]
	bool constant
	{
		[Token(Token = "0x6003796")]
		get;
	}

	[Token(Token = "0x6003797")]
	bool IsMatchProduct(ProductContext product);

	[Token(Token = "0x6003798")]
	int FindIntData(string key, int defaultValue = 0);

	[Token(Token = "0x6003799")]
	string FindStringData(string key, [Optional] string defaultValue);
}
