using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x20009D9")]
public interface IShopProductContainVC
{
	[Token(Token = "0x6003BFB")]
	bool ContainsProduct(int shopId, bool chkBuyAble = false);
}
