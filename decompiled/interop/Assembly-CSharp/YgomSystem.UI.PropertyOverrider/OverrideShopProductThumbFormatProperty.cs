using System;
using Il2CppDummyDll;
using YgomGame.Shop;

namespace YgomSystem.UI.PropertyOverrider;

[Serializable]
[Token(Token = "0x20005A5")]
public class OverrideShopProductThumbFormatProperty : OverridePropertyBase<ShopCardThumbSettings.Format>
{
	[Token(Token = "0x6002570")]
	[Address(RVA = "0x699470", Offset = "0x698670", VA = "0x180699470")]
	public OverrideShopProductThumbFormatProperty()
	{
	}
}
