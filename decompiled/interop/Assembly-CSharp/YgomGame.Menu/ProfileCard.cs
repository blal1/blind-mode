using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.HeaderFooter;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x2001305")]
public class ProfileCard
{
	[Token(Token = "0x400BEC7")]
	public const string IMG_ICON_LABEL = "ImageIcon";

	[Token(Token = "0x400BEC8")]
	public const string IMG_LEVELGAUGE_LABEL = "LevelGauge";

	[Token(Token = "0x400BEC9")]
	public const string IMG_RANK_LABEL = "ImageRank";

	[Token(Token = "0x400BECA")]
	public const string IMG_AVATAR_LABEL = "ImageAvatar";

	[Token(Token = "0x400BECB")]
	public const string IMG_WALLPAPER_LABEL = "ImageWallPaper";

	[Token(Token = "0x400BECC")]
	public const string IMG_BACK_BG_LABEL = "BackBG";

	[Token(Token = "0x400BECD")]
	public const string TXT_FOLLOW_LABEL = "TextFollow";

	[Token(Token = "0x400BECE")]
	public const string TXT_FOLLOWER_LABEL = "TextFollower";

	[Token(Token = "0x400BECF")]
	public const string TXT_ID_LABEL = "TextID";

	[Token(Token = "0x400BED0")]
	public const string TXT_LEVEL_LABEL = "TextLevel";

	[Token(Token = "0x400BED1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string TXT_PLATFORM_NAME_LABEL;

	[Token(Token = "0x400BED2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string TXT_PLATFORM_ICON_LABEL;

	[Token(Token = "0x400BED3")]
	public const string ArgsKey_Name = "name";

	[Token(Token = "0x400BED4")]
	public const string ArgsKey_PlayerCode = "pcode";

	[Token(Token = "0x400BED5")]
	public const string ArgsKey_FollowNum = "follow_num";

	[Token(Token = "0x400BED6")]
	public const string ArgsKey_FollowerNum = "follower_num";

	[Token(Token = "0x400BED7")]
	public const string ArgsKey_Level = "level";

	[Token(Token = "0x400BED8")]
	public const string ArgsKey_Rank = "rank";

	[Token(Token = "0x400BED9")]
	public const string ArgsKey_Rate = "rate";

	[Token(Token = "0x400BEDA")]
	public const string ArgsKey_IconID = "icon_id";

	[Token(Token = "0x400BEDB")]
	public const string ArgsKey_FrameID = "icon_frame_id";

	[Token(Token = "0x400BEDC")]
	public const string ArgsKey_TagID = "tag";

	[Token(Token = "0x400BEDD")]
	public const string ArgsKey_AvatarID = "avatar_id";

	[Token(Token = "0x400BEDE")]
	public const string ArgsKey_WallPaperID = "wallpaper";

	[Token(Token = "0x400BEDF")]
	public const string ArgsKey_CardFileID = "card_file";

	[Token(Token = "0x400BEE0")]
	public const string ArgsKey_CardFileOpenEnable = "card_file_open_enable";

	[Token(Token = "0x400BEE1")]
	public const string ArgsKey_Exp = "exp";

	[Token(Token = "0x400BEE2")]
	public const string ArgsKey_ExpNeed = "need_exp";

	[Token(Token = "0x400BEE3")]
	public const string ArgsKey_OnlineId = "online_id";

	[Token(Token = "0x400BEE4")]
	public const string ArgsKey_IsSameOS = "is_same_os";

	[Token(Token = "0x400BEE5")]
	public const string ArgsKey_Xuid = "xuid";

	[Token(Token = "0x400BEE6")]
	public const string ArgsKey_Edit = "edit";

	[Token(Token = "0x400BEE7")]
	public const string ArgsKey_RankEvent = "rank_event";

	[Token(Token = "0x400BEE8")]
	public const string ArgsKey_Official = "official";

	[Token(Token = "0x400BEE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BindingGameObjectEx bgoEX;

	[Token(Token = "0x400BEEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ElementObjectManager eom;

	[Token(Token = "0x400BEEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelButtonGamerCard;

	[Token(Token = "0x400BEEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SelectionButton m_ButtonGamerCard;

	[Token(Token = "0x400BEED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OutGameFooter m_OutGameFooter;

	[Token(Token = "0x400BEEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isMine;

	[Token(Token = "0x400BEEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ulong xuid;

	[Token(Token = "0x400BEF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Selector m_Selector;

	[Token(Token = "0x400BEF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isEditButtonActive;

	[Token(Token = "0x400BEF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isCardFileActive;

	[Token(Token = "0x400BEF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x400BEF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<string, object> m_ProfileDic;

	[Token(Token = "0x17001270")]
	public Selector selector
	{
		[Token(Token = "0x600761C")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600761D")]
	[Address(RVA = "0xBCA200", Offset = "0xBC9400", VA = "0x180BCA200")]
	public ProfileCard(GameObject parent, Dictionary<string, object> args, bool playTween = true, [Optional] TextGroupLoadHolder textGroupLoadHolder, [Optional] Transform footer)
	{
	}

	[Token(Token = "0x600761E")]
	[Address(RVA = "0xBCA470", Offset = "0xBC9670", VA = "0x180BCA470")]
	public ProfileCard(GameObject parent, long pcode, bool playTween = true)
	{
	}

	[Token(Token = "0x600761F")]
	[Address(RVA = "0xBC91C0", Offset = "0xBC83C0", VA = "0x180BC91C0")]
	public void UpdateProfile(Dictionary<string, object> profileDic, ProfileEditViewController.EditType editType = ProfileEditViewController.EditType.USER_PROFILE)
	{
	}

	[Token(Token = "0x6007620")]
	[Address(RVA = "0xBC8660", Offset = "0xBC7860", VA = "0x180BC8660")]
	public void SetName(string name, ProfileEditViewController.EditType editType, [Optional] string platformName, bool isSamePlatform = false)
	{
	}

	[Token(Token = "0x6007621")]
	[Address(RVA = "0xBC8850", Offset = "0xBC7A50", VA = "0x180BC8850")]
	public void SetOfficialIcon(int iconType)
	{
	}

	[Token(Token = "0x6007622")]
	[Address(RVA = "0xBC7EA0", Offset = "0xBC70A0", VA = "0x180BC7EA0")]
	public void HidePcode()
	{
	}

	[Token(Token = "0x6007623")]
	[Address(RVA = "0xBC89D0", Offset = "0xBC7BD0", VA = "0x180BC89D0")]
	public void SetProfileIcon(int baseId, int frameId, ProfileEditViewController.EditType editType)
	{
	}

	[Token(Token = "0x6007624")]
	[Address(RVA = "0xBC85A0", Offset = "0xBC77A0", VA = "0x180BC85A0")]
	public void SetIconFrame(int id)
	{
	}

	[Token(Token = "0x6007625")]
	[Address(RVA = "0xBC84E0", Offset = "0xBC76E0", VA = "0x180BC84E0")]
	public void SetIconBase(int id)
	{
	}

	[Token(Token = "0x6007626")]
	[Address(RVA = "0xBC8BC0", Offset = "0xBC7DC0", VA = "0x180BC8BC0")]
	public void SetTag(List<object> list, ProfileEditViewController.EditType editType)
	{
	}

	[Token(Token = "0x6007627")]
	[Address(RVA = "0xBC8180", Offset = "0xBC7380", VA = "0x180BC8180")]
	public void SetAvatar(int id, ProfileEditViewController.EditType editType)
	{
	}

	[Token(Token = "0x6007628")]
	[Address(RVA = "0xBC9000", Offset = "0xBC8200", VA = "0x180BC9000")]
	public void SetWallPaper(int id, ProfileEditViewController.EditType editType)
	{
	}

	[Token(Token = "0x6007629")]
	[Address(RVA = "0xBC8310", Offset = "0xBC7510", VA = "0x180BC8310")]
	public void SetCardFile(Dictionary<string, object> dict, ProfileEditViewController.EditType editType)
	{
	}

	[Token(Token = "0x600762A")]
	[Address(RVA = "0xBC8420", Offset = "0xBC7620", VA = "0x180BC8420")]
	public void SetFooter(bool isDisp)
	{
	}

	[Token(Token = "0x600762B")]
	[Address(RVA = "0xBC7CD0", Offset = "0xBC6ED0", VA = "0x180BC7CD0")]
	public void CreateFooter([Optional] Dictionary<SelectorManager.KeyType, string> shortcuts, [Optional] Transform transform, [Optional] Action onFinished)
	{
	}

	[Token(Token = "0x600762C")]
	[Address(RVA = "0xBC7F60", Offset = "0xBC7160", VA = "0x180BC7F60")]
	public void OpenGamerCard()
	{
	}
}
