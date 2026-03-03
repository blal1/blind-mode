using System;
using System.Collections;
using Il2CppDummyDll;
using YgomGame.Menu.Common;

namespace YgomGame.Shop.ProductViewer;

[Token(Token = "0x20009E8")]
public interface IThumbPlayer
{
	[Token(Token = "0x170007F6")]
	bool enabled
	{
		[Token(Token = "0x6003C52")]
		get;
	}

	[Token(Token = "0x170007F7")]
	IAsyncProgressContent asyncProgressContent
	{
		[Token(Token = "0x6003C53")]
		get;
	}

	[Token(Token = "0x170007F8")]
	HighlightContext context
	{
		[Token(Token = "0x6003C54")]
		get;
	}

	[Token(Token = "0x170007F9")]
	ShopDef.ViewerType viewerType
	{
		[Token(Token = "0x6003C57")]
		get;
	}

	[Token(Token = "0x14000046")]
	event Action<bool> onRequestedFadeInInfo;

	[Token(Token = "0x14000047")]
	event Action<bool> onRequestedFadeOutInfo;

	[Token(Token = "0x6003C55")]
	IEnumerator yPlay(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub);

	[Token(Token = "0x6003C56")]
	void SetImmediate(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub);
}
