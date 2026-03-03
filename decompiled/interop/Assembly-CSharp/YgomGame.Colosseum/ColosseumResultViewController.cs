using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CAA")]
public class ColosseumResultViewController : BaseMenuViewController
{
	[Token(Token = "0x2001CAB")]
	public enum AwardType
	{
		[Token(Token = "0x4010040")]
		NONE,
		[Token(Token = "0x4010041")]
		FIRST,
		[Token(Token = "0x4010042")]
		SECOND,
		[Token(Token = "0x4010043")]
		THIRD,
		[Token(Token = "0x4010044")]
		OTHER,
		[Token(Token = "0x4010045")]
		PARTICIPATE
	}

	[Token(Token = "0x4010026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BTN_CLOSE_LABEL;

	[Token(Token = "0x4010027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BTN_CLOSE_CENTER_LABEL;

	[Token(Token = "0x4010028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string ROOT_FIRST_LABEL;

	[Token(Token = "0x4010029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string ROOT_SECOND_LABEL;

	[Token(Token = "0x401002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_THIRD_LABEL;

	[Token(Token = "0x401002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string ROOT_RANKED_LABEL;

	[Token(Token = "0x401002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string ROOT_PARTICIPATE_LABEL;

	[Token(Token = "0x401002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x401002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected readonly string IMG_CUP_LABEL;

	[Token(Token = "0x401002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string IMG_LOGO_LABEL;

	[Token(Token = "0x4010030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x4010031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string TXT_TOURNAMENT_NAME_LABEL;

	[Token(Token = "0x4010032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string TXT_RANK_LABEL;

	[Token(Token = "0x4010033")]
	protected const string KEY_TOURNAMENT_NAME = "TournamentName";

	[Token(Token = "0x4010034")]
	protected const string KEY_TOURNAMENT_YEAR = "TournamentYear";

	[Token(Token = "0x4010035")]
	protected const string KEY_TOURNAMENT_MONTH = "TournamentMonth";

	[Token(Token = "0x4010036")]
	protected const string KEY_AWARD_TYPE = "AwardType";

	[Token(Token = "0x4010037")]
	protected const string KEY_ORDER = "Order";

	[Token(Token = "0x4010038")]
	private const string KEY_EXIST_NUM_LOGO = "ExistNumLogo";

	[Token(Token = "0x4010039")]
	protected const string KEY_FINISH_CALLBACK = "FinishCallback";

	[Token(Token = "0x401003A")]
	private const string KEY_LOGO_KIND_ID = "LogoKind";

	[Token(Token = "0x401003B")]
	private const string KEY_LOGO_ID = "LogoId";

	[Token(Token = "0x401003C")]
	private const string PATH_ATLAS = "Images/Colosseum/Result/All/Colosseum_ResultAtlasAll";

	[Token(Token = "0x401003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected BindingGameObjectEx backGroundBGO;

	[Token(Token = "0x401003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected AwardType awardType;

	[Token(Token = "0x17001BE6")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B9A4")]
		[Address(RVA = "0x54D530", Offset = "0x54C730", VA = "0x18054D530", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE7")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600B9A5")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600B9A6")]
	[Address(RVA = "0x54AEB0", Offset = "0x54A0B0", VA = "0x18054AEB0")]
	public static AwardType AwardIdToType(int awardId)
	{
		return default(AwardType);
	}

	[Token(Token = "0x600B9A7")]
	[Address(RVA = "0x54B5A0", Offset = "0x54A7A0", VA = "0x18054B5A0")]
	public static bool IsDispMyResult(AwardType awardType, int ranking)
	{
		return default(bool);
	}

	[Token(Token = "0x600B9A8")]
	[Address(RVA = "0x54B540", Offset = "0x54A740", VA = "0x18054B540")]
	public static string GetVCPath(ColosseumUtil.PlayMode playMode)
	{
		return null;
	}

	[Token(Token = "0x600B9A9")]
	[Address(RVA = "0x54AEF0", Offset = "0x54A0F0", VA = "0x18054AEF0")]
	public static Dictionary<string, object> GetArgs(ColosseumUtil.PlayMode playMode, string tournamentName, AwardType awardType, int dispOrder, [Optional] UnityAction onFinish, int logoId = -1, int tournamentYear = 0, int tournamentMonth = 0)
	{
		return null;
	}

	[Token(Token = "0x600B9AA")]
	[Address(RVA = "0x54B590", Offset = "0x54A790", VA = "0x18054B590")]
	private bool IsCloseCenterButton(AwardType awardType)
	{
		return default(bool);
	}

	[Token(Token = "0x600B9AB")]
	[Address(RVA = "0x54B300", Offset = "0x54A500", VA = "0x18054B300", Slot = "28")]
	protected virtual string GetBgPath()
	{
		return null;
	}

	[Token(Token = "0x600B9AC")]
	[Address(RVA = "0x54B5C0", Offset = "0x54A7C0", VA = "0x18054B5C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B9AD")]
	[Address(RVA = "0x54C550", Offset = "0x54B750", VA = "0x18054C550", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600B9AE")]
	[Address(RVA = "0x54B860", Offset = "0x54AA60", VA = "0x18054B860", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600B9AF")]
	[Address(RVA = "0x54B900", Offset = "0x54AB00", VA = "0x18054B900", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B9B0")]
	[Address(RVA = "0x54B420", Offset = "0x54A620", VA = "0x18054B420")]
	protected ElementObjectManager GetEomRootRank(AwardType awardType)
	{
		return null;
	}

	[Token(Token = "0x600B9B1")]
	[Address(RVA = "0x54C720", Offset = "0x54B920", VA = "0x18054C720", Slot = "29")]
	protected virtual void SetCupImage(ElementObjectManager targetEom, bool existNumLogo, AwardType awardType, ColosseumUtil.PlayMode kind, int logoId = -1)
	{
	}

	[Token(Token = "0x600B9B2")]
	[Address(RVA = "0x54B330", Offset = "0x54A530", VA = "0x18054B330", Slot = "30")]
	protected virtual string GetCupName(bool existNumLogo, AwardType awardType, int logoId = -1)
	{
		return null;
	}

	[Token(Token = "0x600B9B3")]
	[Address(RVA = "0x54D2B0", Offset = "0x54C4B0", VA = "0x18054D2B0")]
	public ColosseumResultViewController()
	{
	}
}
