using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20017AA")]
public class Sound
{
	[Token(Token = "0x20017AB")]
	public enum DuelBGM
	{
		[Token(Token = "0x400DDA0")]
		DuelEarly = 0,
		[Token(Token = "0x400DDA1")]
		DuelMiddle = 1,
		[Token(Token = "0x400DDA2")]
		DuelLate = 2,
		[Token(Token = "0x400DDA3")]
		DuelStart = -1
	}

	[Token(Token = "0x20017AC")]
	internal class Work
	{
		[Token(Token = "0x400DDA4")]
		[FieldOffset(Offset = "0x10")]
		private string[] rawBgms;

		[Token(Token = "0x400DDA5")]
		[FieldOffset(Offset = "0x18")]
		private List<string> bgms;

		[Token(Token = "0x400DDA6")]
		[FieldOffset(Offset = "0x20")]
		public DuelBGM bgm_step;

		[Token(Token = "0x400DDA7")]
		[FieldOffset(Offset = "0x24")]
		public bool isSeLoaded;

		[Token(Token = "0x400DDA8")]
		[FieldOffset(Offset = "0x25")]
		public bool isBgmLoaded;

		[Token(Token = "0x170016AE")]
		public int bgmNum
		{
			[Token(Token = "0x60094F9")]
			[Address(RVA = "0xDF1260", Offset = "0xDF0460", VA = "0x180DF1260")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60094FA")]
		[Address(RVA = "0xDF10E0", Offset = "0xDF02E0", VA = "0x180DF10E0")]
		public Work(string[] bgms)
		{
		}

		[Token(Token = "0x60094FB")]
		[Address(RVA = "0xDF10C0", Offset = "0xDF02C0", VA = "0x180DF10C0")]
		public string GetBgmLabel(DuelBGM type)
		{
			return null;
		}

		[Token(Token = "0x60094FC")]
		[Address(RVA = "0xDF1010", Offset = "0xDF0210", VA = "0x180DF1010")]
		public string GetBgmLabel(int index)
		{
			return null;
		}
	}

	[Token(Token = "0x20017AD")]
	public enum BgmSituation
	{
		[Token(Token = "0x400DDAA")]
		PreDuel,
		[Token(Token = "0x400DDAB")]
		DuelStart,
		[Token(Token = "0x400DDAC")]
		MonsterCutin,
		[Token(Token = "0x400DDAD")]
		LowLP,
		[Token(Token = "0x400DDAE")]
		MonsterCutinTurn2,
		[Token(Token = "0x400DDAF")]
		BattlePhase,
		[Token(Token = "0x400DDB0")]
		ChangeTurn3
	}

	[Token(Token = "0x400DD9D")]
	private const string DefaultLabel = "BGM_DUEL_NORMAL_01";

	[Token(Token = "0x400DD9E")]
	[FieldOffset(Offset = "0x0")]
	private static Work s_work;

	[Token(Token = "0x60094E3")]
	[Address(RVA = "0xDED080", Offset = "0xDEC280", VA = "0x180DED080")]
	public static bool IsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60094E4")]
	[Address(RVA = "0xDED030", Offset = "0xDEC230", VA = "0x180DED030")]
	public static bool IsLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x60094E5")]
	[Address(RVA = "0xDECDB0", Offset = "0xDEBFB0", VA = "0x180DECDB0")]
	public static bool Init(string[] bgms)
	{
		return default(bool);
	}

	[Token(Token = "0x60094E6")]
	[Address(RVA = "0xDEDF80", Offset = "0xDED180", VA = "0x180DEDF80")]
	public static void Term()
	{
	}

	[Token(Token = "0x60094E7")]
	[Address(RVA = "0xDED590", Offset = "0xDEC790", VA = "0x180DED590")]
	public static void LoadSE()
	{
	}

	[Token(Token = "0x60094E8")]
	[Address(RVA = "0xDEE1B0", Offset = "0xDED3B0", VA = "0x180DEE1B0")]
	private static void UnloadSE()
	{
	}

	[Token(Token = "0x60094E9")]
	[Address(RVA = "0xDEDA70", Offset = "0xDECC70", VA = "0x180DEDA70")]
	public static int PlaySE(string label)
	{
		return default(int);
	}

	[Token(Token = "0x60094EA")]
	[Address(RVA = "0xDEDB40", Offset = "0xDECD40", VA = "0x180DEDB40")]
	public static int PlaySE(string label, Vector3 position)
	{
		return default(int);
	}

	[Token(Token = "0x60094EB")]
	[Address(RVA = "0xDED990", Offset = "0xDECB90", VA = "0x180DED990")]
	public static int PlaySE(string label, GameObject traceTarget)
	{
		return default(int);
	}

	[Token(Token = "0x60094EC")]
	[Address(RVA = "0xDEDEB0", Offset = "0xDED0B0", VA = "0x180DEDEB0")]
	public static void Stop(int instanceId, float fade = -1f)
	{
	}

	[Token(Token = "0x60094ED")]
	[Address(RVA = "0xDEDDE0", Offset = "0xDECFE0", VA = "0x180DEDDE0")]
	public static void Stop(string label, float fade = -1f)
	{
	}

	[Token(Token = "0x60094EE")]
	[Address(RVA = "0xDEDC40", Offset = "0xDECE40", VA = "0x180DEDC40")]
	public static void SetPan(int instanceID, float newPan, float moveTime = 0f)
	{
	}

	[Token(Token = "0x60094EF")]
	[Address(RVA = "0xDED240", Offset = "0xDEC440", VA = "0x180DED240")]
	public static void LoadBGM()
	{
	}

	[Token(Token = "0x60094F0")]
	[Address(RVA = "0xDEE1A0", Offset = "0xDED3A0", VA = "0x180DEE1A0")]
	private static void UnloadBGM()
	{
	}

	[Token(Token = "0x60094F1")]
	[Address(RVA = "0xDED720", Offset = "0xDEC920", VA = "0x180DED720")]
	public static void PlayBGM(DuelBGM idx, float delay = -1f)
	{
	}

	[Token(Token = "0x60094F2")]
	[Address(RVA = "0xDED830", Offset = "0xDECA30", VA = "0x180DED830")]
	public static void PlayBGM(BgmSituation situation, float delay = -1f)
	{
	}

	[Token(Token = "0x60094F3")]
	[Address(RVA = "0xDECC00", Offset = "0xDEBE00", VA = "0x180DECC00")]
	public static DuelBGM GetDuelBGM(BgmSituation situation, DuelBGM current = DuelBGM.DuelStart)
	{
		return default(DuelBGM);
	}

	[Token(Token = "0x60094F4")]
	[Address(RVA = "0xDECB30", Offset = "0xDEBD30", VA = "0x180DECB30")]
	public static string GetBGMLabel(DuelBGM type)
	{
		return null;
	}

	[Token(Token = "0x60094F5")]
	[Address(RVA = "0xDEDD20", Offset = "0xDECF20", VA = "0x180DEDD20")]
	public static void StopBGM(float fade = -1f)
	{
	}

	[Token(Token = "0x60094F6")]
	[Address(RVA = "0xDECBB0", Offset = "0xDEBDB0", VA = "0x180DECBB0")]
	public static DuelBGM GetCurrentBGM()
	{
		return default(DuelBGM);
	}

	[Token(Token = "0x60094F7")]
	[Address(RVA = "0xDED0C0", Offset = "0xDEC2C0", VA = "0x180DED0C0")]
	public static bool IsSameBGM(DuelBGM stepA, DuelBGM stepB)
	{
		return default(bool);
	}

	[Token(Token = "0x60094F8")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Sound()
	{
	}
}
