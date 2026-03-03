using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x20009A4")]
public static class ShopDef
{
	[Token(Token = "0x20009A5")]
	public enum ProductType
	{
		[Token(Token = "0x4008D2A")]
		Pack = 1,
		[Token(Token = "0x4008D2B")]
		Structure,
		[Token(Token = "0x4008D2C")]
		Accessories,
		[Token(Token = "0x4008D2D")]
		Duelpass,
		[Token(Token = "0x4008D2E")]
		Card,
		[Token(Token = "0x4008D2F")]
		Prize,
		[Token(Token = "0x4008D30")]
		Exchange,
		[Token(Token = "0x4008D31")]
		Market
	}

	[Token(Token = "0x20009A6")]
	public enum ShowcaseCategory
	{
		[Token(Token = "0x4008D33")]
		Pickup = 5,
		[Token(Token = "0x4008D34")]
		Pack = 1,
		[Token(Token = "0x4008D35")]
		Structure = 2,
		[Token(Token = "0x4008D36")]
		Accessory = 3,
		[Token(Token = "0x4008D37")]
		Special = 4
	}

	[Token(Token = "0x20009A7")]
	public enum PackSubCategory
	{
		[Token(Token = "0x4008D39")]
		Normal = 1,
		[Token(Token = "0x4008D3A")]
		Secret,
		[Token(Token = "0x4008D3B")]
		Bonus
	}

	[Token(Token = "0x20009A8")]
	public enum SpecialSubCategory
	{
		[Token(Token = "0x4008D3D")]
		DuelPass = 1,
		[Token(Token = "0x4008D3E")]
		Set = 2,
		[Token(Token = "0x4008D3F")]
		DeckLimit = 3,
		[Token(Token = "0x4008D40")]
		Market = 9
	}

	[Token(Token = "0x20009A9")]
	public enum HighlightType
	{
		[Token(Token = "0x4008D42")]
		CardThumb = 1,
		[Token(Token = "0x4008D43")]
		WideThumb = 3
	}

	[Token(Token = "0x20009AA")]
	public enum ViewerType
	{
		[Token(Token = "0x4008D45")]
		Thumb = 1,
		[Token(Token = "0x4008D46")]
		PlaySummon,
		[Token(Token = "0x4008D47")]
		PlayCardEffectRun
	}

	[Token(Token = "0x20009AB")]
	public enum ListButtonType
	{
		[Token(Token = "0x4008D49")]
		Default,
		[Token(Token = "0x4008D4A")]
		Highlight
	}

	[Token(Token = "0x20009AC")]
	public enum ViewerLoopType
	{
		[Token(Token = "0x4008D4C")]
		Default,
		[Token(Token = "0x4008D4D")]
		None
	}

	[Token(Token = "0x4008D11")]
	internal const string k_ResourceHolderGroupLabel = "Shop";

	[Token(Token = "0x4008D12")]
	internal const string k_SettingKey_LimitAlertSec = "limitAlertSec";

	[Token(Token = "0x4008D13")]
	internal const string k_SettingKey_LimitConfirmSec = "limitConfirmSec";

	[Token(Token = "0x4008D14")]
	internal const string k_SettingKey_LimitConfirmMessage = "limitConfirmMessage";

	[Token(Token = "0x4008D15")]
	internal const string k_SettingKey_LimitConfirmSoonMessage = "limitConfirmSoonMessage";

	[Token(Token = "0x4008D16")]
	internal const string k_SettingKey_PickupStyle = "pickupStyle";

	[Token(Token = "0x4008D17")]
	internal const string k_SettingKey_HighlightStyleType = "highlightStyleType";

	[Token(Token = "0x4008D18")]
	internal const string k_SettingKey_ProductWidgetLabel = "productWidget";

	[Token(Token = "0x4008D19")]
	internal const string k_SettingKey_HeadLabelText = "headLabelText";

	[Token(Token = "0x4008D1A")]
	internal const string k_SettingKey_SpCpIcon = "spCpIcon";

	[Token(Token = "0x4008D1B")]
	internal const string k_SettingKey_DxBadge = "dxBadge";

	[Token(Token = "0x4008D1C")]
	internal const string k_SettingKey_SkipSoldoutSort = "skipSoldoutSort";

	[Token(Token = "0x4008D1D")]
	internal const string k_SettingKey_IsShortPayAmountSort = "isShortPayAmountSort";

	[Token(Token = "0x4008D1E")]
	internal const string k_SettingKey_IgnoreTurnoffBadge = "ignoreTurnoffBadge";

	[Token(Token = "0x4008D1F")]
	internal const string k_SettingKey_TabIcon = "tabIcon";

	[Token(Token = "0x4008D20")]
	internal const string k_SettingKey_BgId = "bgId";

	[Token(Token = "0x4008D21")]
	internal const string k_SettingKey_ListDesc = "listDesc";

	[Token(Token = "0x4008D22")]
	internal const string k_SettingKey_InformButtonLabel = "informButton";

	[Token(Token = "0x4008D23")]
	internal const string k_SettingKey_HighlightType = "HighlightType";

	[Token(Token = "0x4008D24")]
	internal const string k_SettingKey_DetailThumbFromIcon = "detailThumbFromIcon";

	[Token(Token = "0x4008D25")]
	internal const string k_SettingKey_ProductSubLabel = "productSubLabel";

	[Token(Token = "0x4008D26")]
	internal const string k_SettingKey_ViewerLoopType = "viewerLoopType";

	[Token(Token = "0x4008D27")]
	internal const string k_SettingKey_HideSummonPlay = "hideSummonPlay";

	[Token(Token = "0x4008D28")]
	internal const string k_SettingKey_HideListPriceLabel = "hideListPriceLabel";
}
