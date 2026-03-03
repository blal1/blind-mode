using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Tutorial;

[Token(Token = "0x20007A5")]
public class TutorialManager
{
	[Token(Token = "0x20007A6")]
	private enum Step
	{
		[Token(Token = "0x4002639")]
		NOT_GET_DECK,
		[Token(Token = "0x400263A")]
		NO_INPUT_NAME,
		[Token(Token = "0x400263B")]
		NO_GUIDANCE
	}

	[Token(Token = "0x20007A7")]
	public enum FirstVisitMenu
	{
		[Token(Token = "0x400263D")]
		DUEL_STANDARD,
		[Token(Token = "0x400263E")]
		SHOP,
		[Token(Token = "0x400263F")]
		DECK_EDIT,
		[Token(Token = "0x4002640")]
		QUEST,
		[Token(Token = "0x4002641")]
		HOME_ENTER_ONCE,
		[Token(Token = "0x4002642")]
		RENTAL_CARD,
		[Token(Token = "0x4002643")]
		DUELLIVE,
		[Token(Token = "0x4002644")]
		SHOP_MONSTER_CUTIN,
		[Token(Token = "0x4002645")]
		DUEL_RATE,
		[Token(Token = "0x4002646")]
		CARDFILE,
		[Token(Token = "0x4002647")]
		LOTTERY,
		[Token(Token = "0x4002648")]
		SHOP_MARKET,
		[Token(Token = "0x4002649")]
		RESERVED13,
		[Token(Token = "0x400264A")]
		RESERVED14,
		[Token(Token = "0x400264B")]
		RESERVED15,
		[Token(Token = "0x400264C")]
		RESERVED16,
		[Token(Token = "0x400264D")]
		RESERVED17,
		[Token(Token = "0x400264E")]
		RESERVED18,
		[Token(Token = "0x400264F")]
		RESERVED19,
		[Token(Token = "0x4002650")]
		RESERVED20
	}

	[Token(Token = "0x4002636")]
	private const string FIRSTVISIT_SAVEPATH = "Tutorial_FirstVisit";

	[Token(Token = "0x4002637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<int, bool> s_FirstVisitFlag;

	[Token(Token = "0x60031F1")]
	[Address(RVA = "0x756B30", Offset = "0x755D30", VA = "0x180756B30")]
	public static bool IsHomeGuidancePassed()
	{
		return default(bool);
	}

	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x756830", Offset = "0x755A30", VA = "0x180756830")]
	public static void FetchInfo([Optional] Action onReceivedFunc)
	{
	}

	[Token(Token = "0x60031F3")]
	[Address(RVA = "0x756570", Offset = "0x755770", VA = "0x180756570")]
	public static void CheckGoingTutorial(Action onGoingTutorial, Action onGoingStructDeckSelect, Action onGoingNameEntry, Action onGoingHome)
	{
	}

	[Token(Token = "0x60031F4")]
	[Address(RVA = "0x756A60", Offset = "0x755C60", VA = "0x180756A60")]
	public static bool IsFirstVisit(FirstVisitMenu menu)
	{
		return default(bool);
	}

	[Token(Token = "0x60031F5")]
	[Address(RVA = "0x757190", Offset = "0x756390", VA = "0x180757190")]
	public static void Visited(FirstVisitMenu menu)
	{
	}

	[Token(Token = "0x60031F6")]
	[Address(RVA = "0x7570C0", Offset = "0x7562C0", VA = "0x1807570C0")]
	public static void ResetFirstVisitData(FirstVisitMenu menu)
	{
	}

	[Token(Token = "0x60031F7")]
	[Address(RVA = "0x756F20", Offset = "0x756120", VA = "0x180756F20")]
	public static void ResetFirstVisitData()
	{
	}

	[Token(Token = "0x60031F8")]
	[Address(RVA = "0x756BA0", Offset = "0x755DA0", VA = "0x180756BA0")]
	public static void LoadFirstVisitData()
	{
	}

	[Token(Token = "0x60031F9")]
	[Address(RVA = "0x756A00", Offset = "0x755C00", VA = "0x180756A00")]
	public static string GetTutorialDuelistName()
	{
		return null;
	}

	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TutorialManager()
	{
	}
}
