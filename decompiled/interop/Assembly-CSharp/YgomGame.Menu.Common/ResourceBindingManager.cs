using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200149E")]
public static class ResourceBindingManager
{
	[Token(Token = "0x400C707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly CardResourceBinder cardBinder;

	[Token(Token = "0x400C708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly RarityIconBinder rarityIconBinder;

	[Token(Token = "0x400C709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly CraftIconBinder craftIconBinder;

	[Token(Token = "0x400C70A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly OutGameBGResourceBinder outGameBGBinder;

	[Token(Token = "0x400C70B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly ShopResourceBinder shopResourceBinder;

	[Token(Token = "0x400C70C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly CardPackResourceBinder cardPackBinder;

	[Token(Token = "0x400C70D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly ConsumeItemBinder consumeBinder;

	[Token(Token = "0x400C70E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly DeckResourceBinder deckBinder;

	[Token(Token = "0x400C70F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly ReplayLimitBinder replayLimitBinder;

	[Token(Token = "0x400C710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static readonly BookmarkLimitBinder bookmarkLimitBinder;

	[Token(Token = "0x400C711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly RegulationIconBinder regulationIconBinder;

	[Token(Token = "0x400C712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static readonly PlayerIconResourceBinder playerIconBinder;

	[Token(Token = "0x400C713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static readonly AvatarResourceBinder avatarBinder;

	[Token(Token = "0x400C714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static readonly ProfileResourceBinder profileBinder;

	[Token(Token = "0x400C715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static readonly WallPaperResourceBinder wallPaperBinder;

	[Token(Token = "0x400C716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static readonly FieldResourceBinder fieldBinder;

	[Token(Token = "0x400C717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static readonly CardFileBinder cardFileBinder;

	[Token(Token = "0x400C718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static readonly CoinBinder coinBinder;

	[Token(Token = "0x400C719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static readonly EventLogoResourceBinder eventLogoBinder;

	[Token(Token = "0x400C71A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static readonly RegulationLogoResourceBinder regulationLogoBinder;

	[Token(Token = "0x400C71B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static readonly SoloResourceBinder soloResourceBinder;

	[Token(Token = "0x400C71C")]
	internal const string deluxebadgePath = "Prefabs/Profile/DeluxeBadge/DeluxeBadge";

	[Token(Token = "0x400C71D")]
	internal const string deluxebadgePath2 = "Prefabs/Profile/DeluxeBadge/DeluxeBadge2";

	[Token(Token = "0x400C71E")]
	internal const string deluxebadgePath2_L = "Prefabs/Profile/DeluxeBadge/DeluxeBadge2_L";

	[Token(Token = "0x6007FE6")]
	[Address(RVA = "0xC7C2B0", Offset = "0xC7B4B0", VA = "0x180C7C2B0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6007FE7")]
	[Address(RVA = "0xC7C000", Offset = "0xC7B200", VA = "0x180C7C000")]
	public static BindingItemThumb BindingItemThumb(GameObject target, bool isPeriod, int itemCategory, int itemId, bool isLarge = false, BindingItemThumb.DxBadgeMode dxBadgeMode = YgomGame.Menu.Common.BindingItemThumb.DxBadgeMode.None, bool isBoxScale = false, bool useLargeDeckCase = false, [Optional] Dictionary<string, object> itemArgs)
	{
		return null;
	}

	[Token(Token = "0x6007FE8")]
	[Address(RVA = "0xC7AFA0", Offset = "0xC7A1A0", VA = "0x180C7AFA0")]
	public static Component BindingItemThumbContent(GameObject target, bool isPeriod, int itemCategory, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007FE9")]
	[Address(RVA = "0xC7B780", Offset = "0xC7A980", VA = "0x180C7B780")]
	public static Component BindingItemThumbLargeContent(GameObject target, bool isPeriod, int itemCategory, int itemId, [Optional] Dictionary<string, object> m_ItemArgs)
	{
		return null;
	}

	[Token(Token = "0x6007FEA")]
	[Address(RVA = "0xC7C1D0", Offset = "0xC7B3D0", VA = "0x180C7C1D0")]
	private static string GetPeriodItemThumbPath(int pCategory, int pItemId, bool isLarge = false)
	{
		return null;
	}

	[Token(Token = "0x6007FEB")]
	[Address(RVA = "0xC7C030", Offset = "0xC7B230", VA = "0x180C7C030")]
	private static Component DummyBindingThumb(GameObject target, int itemId)
	{
		return null;
	}
}
