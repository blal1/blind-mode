using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20012C5")]
public class HomeActionViewController : BaseMenuViewController, ICommonHeaderSupported, IGemSupported, IConfigButtonSupported, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x400BD3F")]
	public const string PREFAB_PATH = "Home/HomeAction";

	[Token(Token = "0x400BD40")]
	public const int P_HELP = 100;

	[Token(Token = "0x400BD41")]
	public const int P_TDY_CHAIN = 90;

	[Token(Token = "0x400BD42")]
	public const int P_ROOM_INVITE = 50;

	[Token(Token = "0x400BD43")]
	public const int P_WCS_DECK_REGIST = 41;

	[Token(Token = "0x400BD44")]
	public const int P_PARTICIPATION_CONFIRM = 40;

	[Token(Token = "0x400BD45")]
	public const int P_WCS_DEMAND = 39;

	[Token(Token = "0x400BD46")]
	public const int P_LOGIN_BONUS = 30;

	[Token(Token = "0x400BD47")]
	public const int P_CAMPAIGN_LOTTERY = 25;

	[Token(Token = "0x400BD48")]
	public const int P_FORCE_PANEL_MISSION = 19;

	[Token(Token = "0x400BD49")]
	public const int P_FORCE_ANNOUNCE = 18;

	[Token(Token = "0x400BD4A")]
	public const int P_EVENT_NOTIFY = 10;

	[Token(Token = "0x400BD4B")]
	public const int P_DEFAULT = 0;

	[Token(Token = "0x400BD4C")]
	private const string ARG_KEY_ACTIONS = "Actions";

	[Token(Token = "0x400BD4D")]
	[FieldOffset(Offset = "0xD0")]
	private List<HomeAction> actionList;

	[Token(Token = "0x400BD4E")]
	[FieldOffset(Offset = "0xD8")]
	private int isPlayingCount;

	[Token(Token = "0x400BD4F")]
	[FieldOffset(Offset = "0xDC")]
	private bool isAcceptedPop;

	[Token(Token = "0x400BD50")]
	[FieldOffset(Offset = "0xE0")]
	private int currentActionIndex;

	[Token(Token = "0x1700125B")]
	private bool IsPlaying
	{
		[Token(Token = "0x6007496")]
		[Address(RVA = "0xBA5AE0", Offset = "0xBA4CE0", VA = "0x180BA5AE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700125C")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007497")]
		[Address(RVA = "0xBA5AF0", Offset = "0xBA4CF0", VA = "0x180BA5AF0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700125D")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6007498")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007499")]
	[Address(RVA = "0xBA57C0", Offset = "0xBA49C0", VA = "0x180BA57C0")]
	public static void Open(List<HomeAction> actionList)
	{
	}

	[Token(Token = "0x600749A")]
	[Address(RVA = "0xBA59F0", Offset = "0xBA4BF0", VA = "0x180BA59F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600749B")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600749C")]
	[Address(RVA = "0xBA54C0", Offset = "0xBA46C0", VA = "0x180BA54C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600749D")]
	[Address(RVA = "0xBA58A0", Offset = "0xBA4AA0", VA = "0x180BA58A0")]
	private void PlayHomeAction()
	{
	}

	[Token(Token = "0x600749E")]
	[Address(RVA = "0xBA5230", Offset = "0xBA4430", VA = "0x180BA5230", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x600749F")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public HomeActionViewController()
	{
	}
}
