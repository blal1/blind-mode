using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Solo;

[Token(Token = "0x20008A2")]
public class SoloModeUtil
{
	[Token(Token = "0x20008A3")]
	public enum DialogType
	{
		[Token(Token = "0x4008758")]
		DUEL,
		[Token(Token = "0x4008759")]
		SCENARIO,
		[Token(Token = "0x400875A")]
		LOCK,
		[Token(Token = "0x400875B")]
		REWARD,
		[Token(Token = "0x400875C")]
		TUTORIAL
	}

	[Token(Token = "0x20008A4")]
	public enum DeckType
	{
		[Token(Token = "0x400875E")]
		POSSESSION,
		[Token(Token = "0x400875F")]
		STORY
	}

	[Token(Token = "0x20008A5")]
	public enum ChapterStatus
	{
		[Token(Token = "0x4008761")]
		UNOPEN = -1,
		[Token(Token = "0x4008762")]
		OPEN,
		[Token(Token = "0x4008763")]
		RENTAL_CLEAR,
		[Token(Token = "0x4008764")]
		MYDECK_CLEAR,
		[Token(Token = "0x4008765")]
		COMPLETE
	}

	[Token(Token = "0x20008A6")]
	public enum RewardType
	{
		[Token(Token = "0x4008767")]
		STORY_CLEAR = 1,
		[Token(Token = "0x4008768")]
		MYDECK_CLEAR
	}

	[Token(Token = "0x20008A7")]
	public enum UnlockType
	{
		[Token(Token = "0x400876A")]
		USER_LEVEL = 1,
		[Token(Token = "0x400876B")]
		CHAPTER_OR,
		[Token(Token = "0x400876C")]
		ITEM,
		[Token(Token = "0x400876D")]
		CHAPTER_AND,
		[Token(Token = "0x400876E")]
		HAS_ITEM
	}

	[Token(Token = "0x20008A8")]
	public enum EntranceType
	{
		[Token(Token = "0x4008770")]
		PORTAL,
		[Token(Token = "0x4008771")]
		LIST,
		[Token(Token = "0x4008772")]
		SKIP
	}

	[Token(Token = "0x20008A9")]
	public enum PortalButton
	{
		[Token(Token = "0x4008774")]
		RECOMMEND1,
		[Token(Token = "0x4008775")]
		RECOMMEND2,
		[Token(Token = "0x4008776")]
		LASTPLAY,
		[Token(Token = "0x4008777")]
		STORYLIST,
		[Token(Token = "0x4008778")]
		TRAININGLIST
	}

	[Token(Token = "0x400874C")]
	public const int MAX_DIFFICULTY = 5;

	[Token(Token = "0x400874D")]
	public const int k_TutorialGateId = 1;

	[Token(Token = "0x400874E")]
	public const int k_TutorialListCategory = 2;

	[Token(Token = "0x400874F")]
	public const string k_ArgKey_IsExit = "IsExit";

	[Token(Token = "0x4008750")]
	public const string k_ArgKey_IsBack = "IsBack";

	[Token(Token = "0x4008751")]
	public const string k_ArgKey_GateId = "GateId";

	[Token(Token = "0x4008752")]
	public const string k_ArgKey_EntranceType = "EntranceType";

	[Token(Token = "0x4008753")]
	public const string k_ArgKey_ListCategory = "category";

	[Token(Token = "0x4008754")]
	public const string k_ArgKey_PortalButton = "PortalButton";

	[Token(Token = "0x4008755")]
	public const string BGM_TUTORIAL = "BGM_TUTORIAL_01";

	[Token(Token = "0x4008756")]
	public const string BGM_SOLO = "BGM_SOLO_GATE";

	[Token(Token = "0x6003442")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void OpenTransitionView(ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003443")]
	[Address(RVA = "0x775BA0", Offset = "0x774DA0", VA = "0x180775BA0")]
	public static void OpenPortalView(ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003444")]
	[Address(RVA = "0x775B40", Offset = "0x774D40", VA = "0x180775B40")]
	public static void OpenGateListView(ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003445")]
	[Address(RVA = "0x775930", Offset = "0x774B30", VA = "0x180775930")]
	public static void CallAPISoloInfo(bool back = false, [Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x6003446")]
	[Address(RVA = "0x775860", Offset = "0x774A60", VA = "0x180775860")]
	public static void CallAPISoloGateEntry(int gateId, [Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x6003447")]
	[Address(RVA = "0x775A10", Offset = "0x774C10", VA = "0x180775A10")]
	public static void HandleResultCode(Handle handle, [Optional] Action onSuccess, [Optional] Action<SoloCode> onFailed)
	{
	}

	[Token(Token = "0x6003448")]
	[Address(RVA = "0x775A80", Offset = "0x774C80", VA = "0x180775A80")]
	public static bool IsRelatedTransitionView(ViewController vc)
	{
		return default(bool);
	}

	[Token(Token = "0x6003449")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SoloModeUtil()
	{
	}
}
