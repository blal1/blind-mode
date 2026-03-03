using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Shop;

namespace YgomGame.Menu.Common;

[Token(Token = "0x20014A2")]
public class ShopResourceBinder : ResourceBinderBase
{
	[Token(Token = "0x400C72A")]
	[FieldOffset(Offset = "0x10")]
	public readonly string cardThumbSettingPath;

	[Token(Token = "0x400C72B")]
	[FieldOffset(Offset = "0x18")]
	private readonly string m_HighlightThumbImagePath;

	[Token(Token = "0x400C72C")]
	[FieldOffset(Offset = "0x20")]
	private readonly string m_HighlightThumbPrefPath;

	[Token(Token = "0x6008001")]
	[Address(RVA = "0x5484C0", Offset = "0x5476C0", VA = "0x1805484C0")]
	public ShopResourceBinder(string cardThumbSettingPath, string highlightThumbImagePath, string highlightThumbPrefPath)
	{
	}

	[Token(Token = "0x6008002")]
	[Address(RVA = "0xC7DF80", Offset = "0xC7D180", VA = "0x180C7DF80")]
	public BindingShopProductThumb BindPackThumb(RectTransform target, int thumbType, string thumbData, ShopCardThumbSettings.Format thumbFormat)
	{
		return null;
	}

	[Token(Token = "0x6008003")]
	[Address(RVA = "0xC71050", Offset = "0xC70250", VA = "0x180C71050")]
	public string GetHighlightThumbImagePath(string name)
	{
		return null;
	}

	[Token(Token = "0x6008004")]
	[Address(RVA = "0xC7E010", Offset = "0xC7D210", VA = "0x180C7E010")]
	public string GetHighlightThumbPrefPath(string name)
	{
		return null;
	}
}
