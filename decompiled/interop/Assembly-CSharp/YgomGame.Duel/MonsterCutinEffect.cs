using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Card;

namespace YgomGame.Duel;

[Token(Token = "0x2001A64")]
public class MonsterCutinEffect
{
	[Token(Token = "0x2001A65")]
	public enum LevelType
	{
		[Token(Token = "0x400F322")]
		Level,
		[Token(Token = "0x400F323")]
		Rank,
		[Token(Token = "0x400F324")]
		Link
	}

	[Token(Token = "0x400F302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool isMyself;

	[Token(Token = "0x400F303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int loadCounter;

	[Token(Token = "0x400F304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int playCount;

	[Token(Token = "0x400F305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool changeBGM;

	[Token(Token = "0x400F306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Sprite textureLinkNum;

	[Token(Token = "0x400F307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PlayableDirector monsterTimeline;

	[Token(Token = "0x400F308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PlayableDirector bgTimeline;

	[Token(Token = "0x400F309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PlayableDirector nameTimeline;

	[Token(Token = "0x400F30A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PlayableDirector effectTimeline;

	[Token(Token = "0x400F30B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int cardID;

	[Token(Token = "0x400F30C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string cardName;

	[Token(Token = "0x400F30D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Content.Attribute attribute;

	[Token(Token = "0x400F30E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int level;

	[Token(Token = "0x400F30F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LevelType levelType;

	[Token(Token = "0x400F310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int attack;

	[Token(Token = "0x400F311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int defense;

	[Token(Token = "0x400F312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool startCardInvoked;

	[Token(Token = "0x400F313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	private bool ready;

	[Token(Token = "0x400F314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Action loadedCallback;

	[Token(Token = "0x400F315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool reqPlayBGM;

	[Token(Token = "0x400F316")]
	private const string SUMMON_STRONG_BG_DARK = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgdak_S2";

	[Token(Token = "0x400F317")]
	private const string SUMMON_STRONG_BG_LIGHT = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bglit_S2";

	[Token(Token = "0x400F318")]
	private const string SUMMON_STRONG_BG_EARTH = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgeah_S2";

	[Token(Token = "0x400F319")]
	private const string SUMMON_STRONG_BG_FIRE = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgfie_S2";

	[Token(Token = "0x400F31A")]
	private const string SUMMON_STRONG_BG_WIND = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgwid_S2";

	[Token(Token = "0x400F31B")]
	private const string SUMMON_STRONG_BG_WATER = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgwtr_S2";

	[Token(Token = "0x400F31C")]
	private const string SUMMON_STRONG_BG_GOD = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/04BackEff/SummonMonster_Bgdve_S2";

	[Token(Token = "0x400F31D")]
	private const string SUMMON_STRONG_NAME_NEAR = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/01Text/SummonMonster_Name_near";

	[Token(Token = "0x400F31E")]
	private const string SUMMON_STRONG_NAME_FAR = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/01Text/SummonMonster_Name_far";

	[Token(Token = "0x400F31F")]
	private const string SUMMON_STRONG_EFFECT_HIGH = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/02FrontEff/SummonMonster_Thunder_power";

	[Token(Token = "0x400F320")]
	private const string SUMMON_STRONG_EFFECT_MIDDLE = "Duel/Timeline/Duel/Universal/Summon/SummonMonster/02FrontEff/SummonMonster_Thunder_normal";

	[Token(Token = "0x17001A79")]
	public bool isLoaded
	{
		[Token(Token = "0x600AB4C")]
		[Address(RVA = "0x425580", Offset = "0x424780", VA = "0x180425580")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A7A")]
	public bool finished
	{
		[Token(Token = "0x600AB4D")]
		[Address(RVA = "0x425570", Offset = "0x424770", VA = "0x180425570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AB4E")]
	[Address(RVA = "0x423530", Offset = "0x422730", VA = "0x180423530")]
	public static bool IsStrongSummonTarget(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600AB4F")]
	[Address(RVA = "0x4234E0", Offset = "0x4226E0", VA = "0x1804234E0")]
	public static MonsterCutinEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600AB50")]
	[Address(RVA = "0x424510", Offset = "0x423710", VA = "0x180424510")]
	public void Setup(int cardID, int rareID, bool isMyself, bool changeBGM, Action loadedCallback)
	{
	}

	[Token(Token = "0x600AB51")]
	[Address(RVA = "0x424A10", Offset = "0x423C10", VA = "0x180424A10")]
	public void Setup(int cardID, int rareID, bool isMyself, string cardName, Content.Attribute attribute, LevelType levelType, int level, int attack, int defense, bool changeBGM, Action loadedCallback)
	{
	}

	[Token(Token = "0x600AB52")]
	[Address(RVA = "0x423540", Offset = "0x422740", VA = "0x180423540")]
	private void OnLoaded(bool result)
	{
	}

	[Token(Token = "0x600AB53")]
	[Address(RVA = "0x423620", Offset = "0x422820", VA = "0x180423620")]
	public void Play(Action finishCallback, Action onStartCard, double playOffset = 0.0, bool mute = false)
	{
	}

	[Token(Token = "0x600AB54")]
	[Address(RVA = "0x423570", Offset = "0x422770", VA = "0x180423570")]
	private void OnPlayFinished(Action onFinished)
	{
	}

	[Token(Token = "0x600AB55")]
	[Address(RVA = "0x425100", Offset = "0x424300", VA = "0x180425100")]
	public void Stop()
	{
	}

	[Token(Token = "0x600AB56")]
	[Address(RVA = "0x425270", Offset = "0x424470", VA = "0x180425270")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600AB57")]
	[Address(RVA = "0x424EC0", Offset = "0x4240C0", VA = "0x180424EC0")]
	private void StopSE(PlayableDirector timeline)
	{
	}

	[Token(Token = "0x600AB58")]
	[Address(RVA = "0x424380", Offset = "0x423580", VA = "0x180424380")]
	public void SetScreenSize(float screenWidth, float screenHeight, [Optional] Camera targetCamera)
	{
	}

	[Token(Token = "0x600AB59")]
	[Address(RVA = "0x424430", Offset = "0x423630", VA = "0x180424430")]
	private void SetScreenSize(PlayableDirector target, float screenWidth, float screenHeight, [Optional] Camera targetCamera)
	{
	}

	[Token(Token = "0x600AB5A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MonsterCutinEffect()
	{
	}
}
