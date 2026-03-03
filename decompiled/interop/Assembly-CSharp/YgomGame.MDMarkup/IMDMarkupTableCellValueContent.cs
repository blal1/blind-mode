using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C9E")]
public interface IMDMarkupTableCellValueContent : IMDMarkupTableContent, IMDMarkupSourceRequireTextData, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x17000A99")]
	TextAlignmentOptions alignment
	{
		[Token(Token = "0x6004C6B")]
		get;
		[Token(Token = "0x6004C6C")]
		set;
	}

	[Token(Token = "0x17000A9A")]
	GlobalTextData text
	{
		[Token(Token = "0x6004C6D")]
		get;
	}

	[Token(Token = "0x17000A9B")]
	string imagePath
	{
		[Token(Token = "0x6004C6E")]
		get;
		[Token(Token = "0x6004C6F")]
		set;
	}

	[Token(Token = "0x17000A9C")]
	float overrideHeight
	{
		[Token(Token = "0x6004C70")]
		get;
	}

	[Token(Token = "0x17000A9D")]
	float overrideWidth
	{
		[Token(Token = "0x6004C71")]
		get;
	}

	[Token(Token = "0x17000A9E")]
	bool usePrefferedSize
	{
		[Token(Token = "0x6004C72")]
		get;
	}

	[Token(Token = "0x17000A9F")]
	bool detailEnabled
	{
		[Token(Token = "0x6004C73")]
		get;
	}

	[Token(Token = "0x17000AA0")]
	int mrk
	{
		[Token(Token = "0x6004C74")]
		get;
		[Token(Token = "0x6004C75")]
		set;
	}

	[Token(Token = "0x17000AA1")]
	int premiere
	{
		[Token(Token = "0x6004C76")]
		get;
	}

	[Token(Token = "0x17000AA2")]
	MDMarkupDef.CardSize cardSize
	{
		[Token(Token = "0x6004C77")]
		get;
	}

	[Token(Token = "0x17000AA3")]
	bool rarityVisible
	{
		[Token(Token = "0x6004C78")]
		get;
	}

	[Token(Token = "0x17000AA4")]
	int rarity
	{
		[Token(Token = "0x6004C79")]
		get;
	}

	[Token(Token = "0x17000AA5")]
	int limitRegId
	{
		[Token(Token = "0x6004C7A")]
		get;
	}

	[Token(Token = "0x17000AA6")]
	bool limitVisible
	{
		[Token(Token = "0x6004C7B")]
		get;
	}

	[Token(Token = "0x17000AA7")]
	bool limitNoneVisible
	{
		[Token(Token = "0x6004C7C")]
		get;
	}

	[Token(Token = "0x17000AA8")]
	int limitStatus
	{
		[Token(Token = "0x6004C7D")]
		get;
	}

	[Token(Token = "0x17000AA9")]
	bool prevLimitVisible
	{
		[Token(Token = "0x6004C7E")]
		get;
	}

	[Token(Token = "0x17000AAA")]
	int prevLimitStatus
	{
		[Token(Token = "0x6004C7F")]
		get;
	}

	[Token(Token = "0x17000AAB")]
	bool isPeriod
	{
		[Token(Token = "0x6004C80")]
		get;
	}

	[Token(Token = "0x17000AAC")]
	int itemCategory
	{
		[Token(Token = "0x6004C81")]
		get;
	}

	[Token(Token = "0x17000AAD")]
	int itemId
	{
		[Token(Token = "0x6004C82")]
		get;
	}

	[Token(Token = "0x17000AAE")]
	MDMarkupDef.ItemSize itemSize
	{
		[Token(Token = "0x6004C83")]
		get;
	}

	[Token(Token = "0x17000AAF")]
	MDMarkupBannerContext banner
	{
		[Token(Token = "0x6004C84")]
		get;
	}

	[Token(Token = "0x17000AB0")]
	string link
	{
		[Token(Token = "0x6004C85")]
		get;
	}

	[Token(Token = "0x17000AB1")]
	bool interactable
	{
		[Token(Token = "0x6004C86")]
		get;
	}

	[Token(Token = "0x17000AB2")]
	GlobalTextData desc
	{
		[Token(Token = "0x6004C87")]
		get;
	}

	[Token(Token = "0x17000AB3")]
	MDMarkupDef.ButtonStyle buttonStyle
	{
		[Token(Token = "0x6004C88")]
		get;
	}

	[Token(Token = "0x17000AB4")]
	IMDMarkupTableDataContent childTable
	{
		[Token(Token = "0x6004C89")]
		get;
	}

	[Token(Token = "0x17000AB5")]
	Sprite imageSprite
	{
		[Token(Token = "0x6004C8A")]
		get;
	}

	[Token(Token = "0x17000AB6")]
	MDMarkupDef.TableCellValueType valueType
	{
		[Token(Token = "0x6004C8B")]
		get;
		[Token(Token = "0x6004C8C")]
		set;
	}

	[Token(Token = "0x6004C8D")]
	void OnFormatByArgsModifier(object[] formatParams);
}
