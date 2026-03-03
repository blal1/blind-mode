using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.Menu;

[Token(Token = "0x2001358")]
public class ProfileUtil
{
	[Token(Token = "0x400C110")]
	private const string AVATARICON_PATH = "Images/Menu/AvatarIcon/{0}";

	[Token(Token = "0x400C111")]
	private const string WALLPAPER_THUMB_PATH = "WallPaper/WallPaper{0:D4}/<_CARD_ILLUST_>/WallPaperThumb{1}";

	[Token(Token = "0x400C112")]
	public const int MYTAG_QUANTITY = 4;

	[Token(Token = "0x400C113")]
	public const int FAV_HOME_WP_QUANTITY = 5;

	[Token(Token = "0x6007818")]
	[Address(RVA = "0xBF62D0", Offset = "0xBF54D0", VA = "0x180BF62D0")]
	public static void CallFriendFollowOtherRoutes(long pcode, int route, [Optional] Action<FriendCode> endAction, [Optional] Action<FriendCode> errorAction)
	{
	}

	[Token(Token = "0x6007819")]
	[Address(RVA = "0xBF64A0", Offset = "0xBF56A0", VA = "0x180BF64A0")]
	public static string GetAvatarIconPath(int id)
	{
		return null;
	}

	[Token(Token = "0x600781A")]
	[Address(RVA = "0xBF6500", Offset = "0xBF5700", VA = "0x180BF6500")]
	public static string GetWallPaperThumbPath(int id)
	{
		return null;
	}

	[Token(Token = "0x600781B")]
	[Address(RVA = "0xBF66B0", Offset = "0xBF58B0", VA = "0x180BF66B0")]
	public static void PushProfileViewPlayer(int player)
	{
	}

	[Token(Token = "0x600781C")]
	[Address(RVA = "0xBF6580", Offset = "0xBF5780", VA = "0x180BF6580")]
	public static void PushProfileViewPcode(long pcode)
	{
	}

	[Token(Token = "0x600781D")]
	[Address(RVA = "0xBF6100", Offset = "0xBF5300", VA = "0x180BF6100")]
	public static void CallBlockAPI(long pcode, int delete, [Optional] Action endAction, [Optional] Action errorAction)
	{
	}

	[Token(Token = "0x600781E")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
	public static bool CheckFriendIsBlock(long pcode)
	{
		return default(bool);
	}

	[Token(Token = "0x600781F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ProfileUtil()
	{
	}
}
