using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A17")]
public class DuelEffectPool : MonoBehaviour
{
	[Token(Token = "0x2001A18")]
	private enum Step
	{
		[Token(Token = "0x400F0A8")]
		Initializing,
		[Token(Token = "0x400F0A9")]
		Idle,
		[Token(Token = "0x400F0AA")]
		Terminating
	}

	[Token(Token = "0x2001A19")]
	public enum Type
	{
		[Token(Token = "0x400F0AC")]
		AffectRelative = 2,
		[Token(Token = "0x400F0AD")]
		AttackDirect00 = 6,
		[Token(Token = "0x400F0AE")]
		AttackDirect01 = 7,
		[Token(Token = "0x400F0AF")]
		AttackGuard00 = 8,
		[Token(Token = "0x400F0B0")]
		TargetingAiming = 10,
		[Token(Token = "0x400F0B1")]
		CardActivate = 13,
		[Token(Token = "0x400F0B2")]
		CardExplosion = 17,
		[Token(Token = "0x400F0B3")]
		CardBreak = 18,
		[Token(Token = "0x400F0B4")]
		CardDecide2 = 20,
		[Token(Token = "0x400F0B5")]
		CardHappen = 21,
		[Token(Token = "0x400F0B6")]
		CardDisable = 22,
		[Token(Token = "0x400F0B7")]
		CardLockon00 = 23,
		[Token(Token = "0x400F0B8")]
		ActiveCardAuraMiddle00 = 24,
		[Token(Token = "0x400F0B9")]
		ActiveCardAuraMiddle01 = 25,
		[Token(Token = "0x400F0BA")]
		CardMoveTrail01 = 27,
		[Token(Token = "0x400F0BB")]
		DeckHighlight00 = 29,
		[Token(Token = "0x400F0BC")]
		DrawArrow00 = 30,
		[Token(Token = "0x400F0BD")]
		FieldIcon00 = 32,
		[Token(Token = "0x400F0BE")]
		Invalid00 = 34,
		[Token(Token = "0x400F0BF")]
		MaterialMonster = 35,
		[Token(Token = "0x400F0C0")]
		SacrificeRun = 41,
		[Token(Token = "0x400F0C1")]
		SacrificeTarget = 42,
		[Token(Token = "0x400F0C2")]
		SummonPlane = 45,
		[Token(Token = "0x400F0C3")]
		TapMonster = 49,
		[Token(Token = "0x400F0C4")]
		HitNullSmall = 50,
		[Token(Token = "0x400F0C5")]
		HitNullLargest = 53,
		[Token(Token = "0x400F0C6")]
		HitLightSmall = 54,
		[Token(Token = "0x400F0C7")]
		HitLightLargest = 57,
		[Token(Token = "0x400F0C8")]
		HitDarkSmall = 58,
		[Token(Token = "0x400F0C9")]
		HitDarkLargest = 61,
		[Token(Token = "0x400F0CA")]
		HitWaterSmall = 62,
		[Token(Token = "0x400F0CB")]
		HitWaterLargest = 65,
		[Token(Token = "0x400F0CC")]
		HitFireSmall = 66,
		[Token(Token = "0x400F0CD")]
		HitFireLargest = 69,
		[Token(Token = "0x400F0CE")]
		HitEarthSmall = 70,
		[Token(Token = "0x400F0CF")]
		HitEarthLargest = 73,
		[Token(Token = "0x400F0D0")]
		HitWindSmall = 74,
		[Token(Token = "0x400F0D1")]
		HitWindLargest = 77,
		[Token(Token = "0x400F0D2")]
		CardDecide00 = 85,
		[Token(Token = "0x400F0D3")]
		CardCrack00 = 86,
		[Token(Token = "0x400F0D4")]
		AttackTrailNullLow = 87,
		[Token(Token = "0x400F0D5")]
		AttackTrailNullHigh = 88,
		[Token(Token = "0x400F0D6")]
		AttackTrailLightLow = 89,
		[Token(Token = "0x400F0D7")]
		AttackTrailLightHigh = 90,
		[Token(Token = "0x400F0D8")]
		AttackTrailDarkLow = 91,
		[Token(Token = "0x400F0D9")]
		AttackTrailDarkHigh = 92,
		[Token(Token = "0x400F0DA")]
		AttackTrailWaterLow = 93,
		[Token(Token = "0x400F0DB")]
		AttackTrailWaterHigh = 94,
		[Token(Token = "0x400F0DC")]
		AttackTrailFireLow = 95,
		[Token(Token = "0x400F0DD")]
		AttackTrailFireHigh = 96,
		[Token(Token = "0x400F0DE")]
		AttackTrailEarthLow = 97,
		[Token(Token = "0x400F0DF")]
		AttackTrailEarthHigh = 98,
		[Token(Token = "0x400F0E0")]
		AttackTrailWindLow = 99,
		[Token(Token = "0x400F0E1")]
		AttackTrailWindHigh = 100,
		[Token(Token = "0x400F0E2")]
		AttackTrailGodLow = 101,
		[Token(Token = "0x400F0E3")]
		AttackTrailGodHigh = 102,
		[Token(Token = "0x400F0E4")]
		AttackNullLow = 103,
		[Token(Token = "0x400F0E5")]
		AttackNullHigh = 104,
		[Token(Token = "0x400F0E6")]
		AttackLightLow = 105,
		[Token(Token = "0x400F0E7")]
		AttackLightHigh = 106,
		[Token(Token = "0x400F0E8")]
		AttackDarkLow = 107,
		[Token(Token = "0x400F0E9")]
		AttackDarkHigh = 108,
		[Token(Token = "0x400F0EA")]
		AttackWaterLow = 109,
		[Token(Token = "0x400F0EB")]
		AttackWaterHigh = 110,
		[Token(Token = "0x400F0EC")]
		AttackFireLow = 111,
		[Token(Token = "0x400F0ED")]
		AttackFireHigh = 112,
		[Token(Token = "0x400F0EE")]
		AttackEarthLow = 113,
		[Token(Token = "0x400F0EF")]
		AttackEarthHigh = 114,
		[Token(Token = "0x400F0F0")]
		AttackWindLow = 115,
		[Token(Token = "0x400F0F1")]
		AttackWindHigh = 116,
		[Token(Token = "0x400F0F2")]
		AttackGodLow = 117,
		[Token(Token = "0x400F0F3")]
		AttackGodHigh = 118,
		[Token(Token = "0x400F0F4")]
		DrawDrag = 122,
		[Token(Token = "0x400F0F5")]
		DrawImpact = 123,
		[Token(Token = "0x400F0F6")]
		ActiveCardAuraLow00 = 124,
		[Token(Token = "0x400F0F7")]
		ActiveCardAuraLow01 = 125,
		[Token(Token = "0x400F0F8")]
		ActiveCardAuraHigh00 = 126,
		[Token(Token = "0x400F0F9")]
		ActiveCardAuraHigh01 = 127,
		[Token(Token = "0x400F0FA")]
		LinkTargetCard = 131,
		[Token(Token = "0x400F0FB")]
		SelectingCursorDeck = 132,
		[Token(Token = "0x400F0FC")]
		SelectingCursorMonster = 133,
		[Token(Token = "0x400F0FD")]
		SelectingCursorMagic = 134,
		[Token(Token = "0x400F0FE")]
		SelectingCursorField = 135,
		[Token(Token = "0x400F0FF")]
		ActiveMagicCardAuraHigh00 = 136,
		[Token(Token = "0x400F100")]
		ActiveMagicCardAuraHigh01 = 137,
		[Token(Token = "0x400F101")]
		CardExclude = 138,
		[Token(Token = "0x400F102")]
		CardExcludeTrail = 139,
		[Token(Token = "0x400F103")]
		CardBreakExcludeTrail = 140,
		[Token(Token = "0x400F104")]
		CardReleaseTrail = 141,
		[Token(Token = "0x400F105")]
		CardReleaseExcludeTrail = 142,
		[Token(Token = "0x400F106")]
		FusionTargetCard = 143,
		[Token(Token = "0x400F107")]
		SynchroTargetCard = 144,
		[Token(Token = "0x400F108")]
		RitualTargetCard = 145,
		[Token(Token = "0x400F109")]
		LandingLinkMiddle0 = 146,
		[Token(Token = "0x400F10A")]
		LandingLinkMiddle1 = 147,
		[Token(Token = "0x400F10B")]
		LandingLinkHigh0 = 148,
		[Token(Token = "0x400F10C")]
		LandingLinkHigh1 = 149,
		[Token(Token = "0x400F10D")]
		LandingFusionMiddle0 = 150,
		[Token(Token = "0x400F10E")]
		LandingFusionMiddle1 = 151,
		[Token(Token = "0x400F10F")]
		LandingFusionHigh0 = 152,
		[Token(Token = "0x400F110")]
		LandingFusionHigh1 = 153,
		[Token(Token = "0x400F111")]
		LandingPendulumMiddle0 = 154,
		[Token(Token = "0x400F112")]
		LandingPendulumMiddle1 = 155,
		[Token(Token = "0x400F113")]
		LandingPendulumHigh0 = 156,
		[Token(Token = "0x400F114")]
		LandingPendulumHigh1 = 157,
		[Token(Token = "0x400F115")]
		LandingAdvanceMiddle0 = 158,
		[Token(Token = "0x400F116")]
		LandingAdvanceMiddle1 = 159,
		[Token(Token = "0x400F117")]
		LandingAdvanceHigh0 = 160,
		[Token(Token = "0x400F118")]
		LandingAdvanceHigh1 = 161,
		[Token(Token = "0x400F119")]
		SelectTargetMonsterZone = 162,
		[Token(Token = "0x400F11A")]
		DecideTargetMonsterZone = 163,
		[Token(Token = "0x400F11B")]
		SelectTargetMagicZone = 164,
		[Token(Token = "0x400F11C")]
		DecideTargetMagicZone = 165,
		[Token(Token = "0x400F11D")]
		SelectTargetCard = 166,
		[Token(Token = "0x400F11E")]
		DecideTargetCard = 167,
		[Token(Token = "0x400F11F")]
		AttackTargetLine = 168,
		[Token(Token = "0x400F120")]
		LandingSpSummonMiddle0 = 169,
		[Token(Token = "0x400F121")]
		LandingSpSummonMiddle1 = 170,
		[Token(Token = "0x400F122")]
		LandingSpSummonHigh0 = 171,
		[Token(Token = "0x400F123")]
		LandingSpSummonHigh1 = 172,
		[Token(Token = "0x400F124")]
		LandingMagic = 173,
		[Token(Token = "0x400F125")]
		LandingSummonSmall = 174,
		[Token(Token = "0x400F126")]
		EquipTargetLine = 175,
		[Token(Token = "0x400F127")]
		LandingXyzMiddle0 = 176,
		[Token(Token = "0x400F128")]
		LandingXyzMiddle1 = 177,
		[Token(Token = "0x400F129")]
		LandingXyzHigh0 = 178,
		[Token(Token = "0x400F12A")]
		LandingXyzHigh1 = 179,
		[Token(Token = "0x400F12B")]
		LandingRitualMiddle0 = 180,
		[Token(Token = "0x400F12C")]
		LandingRitualMiddle1 = 181,
		[Token(Token = "0x400F12D")]
		LandingRitualHigh0 = 182,
		[Token(Token = "0x400F12E")]
		LandingRitualHigh1 = 183,
		[Token(Token = "0x400F12F")]
		LandingSynchroMiddle0 = 184,
		[Token(Token = "0x400F130")]
		LandingSynchroMiddle1 = 185,
		[Token(Token = "0x400F131")]
		LandingSynchroHigh0 = 186,
		[Token(Token = "0x400F132")]
		LandingSynchroHigh1 = 187,
		[Token(Token = "0x400F133")]
		DrawLimitedCardMove = 188,
		[Token(Token = "0x400F134")]
		DrawLimitedCardImpact = 189,
		[Token(Token = "0x400F135")]
		XyzMaterialIn = 190,
		[Token(Token = "0x400F136")]
		XyzMaterialOut = 191,
		[Token(Token = "0x400F137")]
		XyzMaterialTrail = 192,
		[Token(Token = "0x400F138")]
		ActivateEffectExDeck = 193,
		[Token(Token = "0x400F139")]
		ActivateEffectGrave = 194,
		[Token(Token = "0x400F13A")]
		ActivateEffectExclude = 195,
		[Token(Token = "0x400F13B")]
		SelectTargetDirectAttack = 196,
		[Token(Token = "0x400F13C")]
		DecideTargetDirectAttack = 197,
		[Token(Token = "0x400F13D")]
		HitGodSmall = 198,
		[Token(Token = "0x400F13E")]
		HitGodLargest = 199,
		[Token(Token = "0x400F13F")]
		CardVanish = 200,
		[Token(Token = "0x400F140")]
		XyzMaterialAppear = 201,
		[Token(Token = "0x400F141")]
		TutorialHighlight = 202,
		[Token(Token = "0x400F142")]
		TutorialArrow = 203,
		[Token(Token = "0x400F143")]
		TutorialUIHighlight = 204,
		[Token(Token = "0x400F144")]
		LethalEffectNear = 205,
		[Token(Token = "0x400F145")]
		LethalEffectFar = 206,
		[Token(Token = "0x400F146")]
		HandDragLine = 207,
		[Token(Token = "0x400F147")]
		CardRunEffectMugenHouyou = 208,
		[Token(Token = "0x400F148")]
		CardRunEffectSkillDrain = 209,
		[Token(Token = "0x400F149")]
		CardRunEffectSkillDrainCenter = 210,
		[Token(Token = "0x400F14A")]
		CardRunEffectLightningStorm = 211,
		[Token(Token = "0x400F14B")]
		CardRunEffectMugenHouyouCenter = 212,
		[Token(Token = "0x400F14C")]
		SpSummonEffect = 213,
		[Token(Token = "0x400F14D")]
		CardRunEffectHaruUrara = 214,
		[Token(Token = "0x400F14E")]
		LethalEffectDarkMagicianNear = 215,
		[Token(Token = "0x400F14F")]
		LethalEffectDarkMagicianFar = 216,
		[Token(Token = "0x400F150")]
		CardRunEffectEffectVeiler = 217,
		[Token(Token = "0x400F151")]
		LethalEffectBlueEyesNear = 218,
		[Token(Token = "0x400F152")]
		LethalEffectBlueEyesFar = 219,
		[Token(Token = "0x400F153")]
		LethalEffectRedEyesNear = 220,
		[Token(Token = "0x400F154")]
		LethalEffectRedEyesFar = 221,
		[Token(Token = "0x400F155")]
		AttackShootRedEyes = 222,
		[Token(Token = "0x400F156")]
		CardApply = 223,
		[Token(Token = "0x400F157")]
		ResidualEffectMugenHouyou = 224,
		[Token(Token = "0x400F158")]
		SuperFusionTargetCard = 225,
		[Token(Token = "0x400F159")]
		AttackShootRa = 226,
		[Token(Token = "0x400F15A")]
		LethalEffectRaNear = 227,
		[Token(Token = "0x400F15B")]
		LethalEffectRaFar = 228,
		[Token(Token = "0x400F15C")]
		LethalEffectObeliskNear = 229,
		[Token(Token = "0x400F15D")]
		LethalEffectObeliskFar = 230,
		[Token(Token = "0x400F15E")]
		LethalEffectSliferNear = 231,
		[Token(Token = "0x400F15F")]
		LethalEffectSliferFar = 232,
		[Token(Token = "0x400F160")]
		CardBuff = 233,
		[Token(Token = "0x400F161")]
		CardDebuff = 234,
		[Token(Token = "0x400F162")]
		CardChange = 235,
		[Token(Token = "0x400F163")]
		CardRunEffectYashikiWarashi = 236,
		[Token(Token = "0x400F164")]
		ActiveCardAuraHighMid00 = 237,
		[Token(Token = "0x400F165")]
		ActiveCardAuraHighMid01 = 238,
		[Token(Token = "0x400F166")]
		ResidualEffectMulcharmyFuwalos = 239,
		[Token(Token = "0x400F167")]
		ResidualEffectMulcharmyPurulia = 240,
		[Token(Token = "0x400F168")]
		ResidualEffectMulcharmyMeowls = 241,
		[Token(Token = "0x400F169")]
		ResidualEffectDrollAndLockBird = 242,
		[Token(Token = "0x400F16A")]
		ResidualEffectDrollAndLockBirdAlt = 243,
		[Token(Token = "0x400F16B")]
		Noop = 65535
	}

	[Token(Token = "0x400F09B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x400F09C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<Type, Queue<GameObject>> effects;

	[Token(Token = "0x400F09D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<Type, List<DuelEffectHandle>> usingEffects;

	[Token(Token = "0x400F09E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Type> remainTypes;

	[Token(Token = "0x400F09F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<Type, UnityEngine.Object> effSrcs;

	[Token(Token = "0x400F0A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<GameObject> allEffects;

	[Token(Token = "0x400F0A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<GameObject> usedEffects;

	[Token(Token = "0x400F0A2")]
	private const string parentDir = "Duel/Effects";

	[Token(Token = "0x400F0A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Type, object[]> srcPaths;

	[Token(Token = "0x170019FD")]
	public bool isInitialized
	{
		[Token(Token = "0x600A8AF")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A8B0")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019FE")]
	public bool isTerminated
	{
		[Token(Token = "0x600A8B2")]
		[Address(RVA = "0x453D40", Offset = "0x452F40", VA = "0x180453D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A8B3")]
		[Address(RVA = "0x453DA0", Offset = "0x452FA0", VA = "0x180453DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019FF")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600A8B4")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A8B5")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A8AB")]
	[Address(RVA = "0xF4AB90", Offset = "0xF49D90", VA = "0x180F4AB90")]
	public static DuelEffectPool Create(DuelGameObjectManager goManager, GameObject root, string name, bool loadAllEffects)
	{
		return null;
	}

	[Token(Token = "0x600A8AC")]
	[Address(RVA = "0xF4B100", Offset = "0xF4A300", VA = "0x180F4B100")]
	private void Initialize(bool loadAllEffects)
	{
	}

	[Token(Token = "0x600A8AD")]
	[Address(RVA = "0xF4B1D0", Offset = "0xF4A3D0", VA = "0x180F4B1D0")]
	private void LoadEffects(Dictionary<Type, object[]> paths, bool loadAllEffects)
	{
	}

	[Token(Token = "0x600A8AE")]
	[Address(RVA = "0xF4B440", Offset = "0xF4A640", VA = "0x180F4B440")]
	public void Load(Type type, bool allowLoadOnly, Action<bool> onLoaded, bool immediate = false)
	{
	}

	[Token(Token = "0x600A8B1")]
	[Address(RVA = "0xF4B810", Offset = "0xF4AA10", VA = "0x180F4B810")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A8B6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void Inactivate()
	{
	}

	[Token(Token = "0x600A8B7")]
	public T Use<T>(Type type, GameObject target, bool autoQuit, bool enableRestock = true, [Optional] Action onFinished) where T : DuelEffectHandle
	{
		return null;
	}

	[Token(Token = "0x600A8B8")]
	[Address(RVA = "0xF4BCF0", Offset = "0xF4AEF0", VA = "0x180F4BCF0")]
	public SimpleEffect UseSimple(Type type, GameObject target, bool autoQuit, bool enableRestock = true, [Optional] Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600A8B9")]
	[Address(RVA = "0xF4BB80", Offset = "0xF4AD80", VA = "0x180F4BB80")]
	public void Unuse(Type type, DuelEffectHandle eff)
	{
	}

	[Token(Token = "0x600A8BA")]
	[Address(RVA = "0xF4BC80", Offset = "0xF4AE80", VA = "0x180F4BC80")]
	private void Update()
	{
	}

	[Token(Token = "0x600A8BB")]
	[Address(RVA = "0xF4B180", Offset = "0xF4A380", VA = "0x180F4B180")]
	private void InitializingStep()
	{
	}

	[Token(Token = "0x600A8BC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600A8BD")]
	[Address(RVA = "0xF4BB70", Offset = "0xF4AD70", VA = "0x180F4BB70")]
	private void TerminatingStep()
	{
	}

	[Token(Token = "0x600A8BE")]
	[Address(RVA = "0xF4A780", Offset = "0xF49980", VA = "0x180F4A780")]
	private void Create(Type type, int numCreates)
	{
	}

	[Token(Token = "0x600A8BF")]
	[Address(RVA = "0xF4AFB0", Offset = "0xF4A1B0", VA = "0x180F4AFB0")]
	private void Enqueue(Type type, GameObject go)
	{
	}

	[Token(Token = "0x600A8C0")]
	[Address(RVA = "0xF4ACF0", Offset = "0xF49EF0", VA = "0x180F4ACF0")]
	private GameObject Dequeue(Type type, bool enableRestock, bool loadEffect)
	{
		return null;
	}

	[Token(Token = "0x600A8C1")]
	[Address(RVA = "0xF57A30", Offset = "0xF56C30", VA = "0x180F57A30")]
	public DuelEffectPool()
	{
	}
}
