using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Home;

[Token(Token = "0x2000D41")]
public class BindingItemPrefabsUtil
{
	[Token(Token = "0x2000D42")]
	public enum BindingItemPrefabType
	{
		[Token(Token = "0x4009E5B")]
		ProfileIconRoot = 1,
		[Token(Token = "0x4009E5C")]
		ProtectorRoot,
		[Token(Token = "0x4009E5D")]
		DeckCaseRoot,
		[Token(Token = "0x4009E5E")]
		WallpaperRoot,
		[Token(Token = "0x4009E5F")]
		WallpaperAndIconFrame,
		[Token(Token = "0x4009E60")]
		CardFileRoot,
		[Token(Token = "0x4009E61")]
		CoinRoot,
		[Token(Token = "0x4009E62")]
		Pack10AndDeco,
		[Token(Token = "0x4009E63")]
		Pack20AndDeco,
		[Token(Token = "0x4009E64")]
		Pack30AndDeco,
		[Token(Token = "0x4009E65")]
		Spacer
	}

	[Token(Token = "0x600503C")]
	[Address(RVA = "0x9652F0", Offset = "0x9644F0", VA = "0x1809652F0")]
	public static List<string> GetItemPrefabTypeStringList()
	{
		return null;
	}

	[Token(Token = "0x600503D")]
	[Address(RVA = "0x9653B0", Offset = "0x9645B0", VA = "0x1809653B0")]
	public static List<string> GetParamFromType(BindingItemPrefabType type)
	{
		return null;
	}

	[Token(Token = "0x600503E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BindingItemPrefabsUtil()
	{
	}
}
