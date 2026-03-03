using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AOT;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.Duel;

[Token(Token = "0x20017D2")]
public sealed class Engine
{
	[Token(Token = "0x20017D3")]
	public enum PlayerType
	{
		[Token(Token = "0x400DF1B")]
		Human = 0,
		[Token(Token = "0x400DF1C")]
		CPU = 1,
		[Token(Token = "0x400DF1D")]
		Remote = 2,
		[Token(Token = "0x400DF1E")]
		Replay = 3,
		[Token(Token = "0x400DF1F")]
		Replay2 = 4,
		[Token(Token = "0x400DF20")]
		None = -1
	}

	[Token(Token = "0x20017D4")]
	public enum DuelType
	{
		[Token(Token = "0x400DF22")]
		Normal,
		[Token(Token = "0x400DF23")]
		Extra,
		[Token(Token = "0x400DF24")]
		Tag,
		[Token(Token = "0x400DF25")]
		Quick,
		[Token(Token = "0x400DF26")]
		Rush
	}

	[Token(Token = "0x20017D5")]
	public enum ResultType
	{
		[Token(Token = "0x400DF28")]
		None,
		[Token(Token = "0x400DF29")]
		Win,
		[Token(Token = "0x400DF2A")]
		Lose,
		[Token(Token = "0x400DF2B")]
		Draw,
		[Token(Token = "0x400DF2C")]
		Time
	}

	[Token(Token = "0x20017D6")]
	public enum FinishType
	{
		[Token(Token = "0x400DF2E")]
		None = 0,
		[Token(Token = "0x400DF2F")]
		Normal = 1,
		[Token(Token = "0x400DF30")]
		NoDeck = 2,
		[Token(Token = "0x400DF31")]
		TimeOut = 3,
		[Token(Token = "0x400DF32")]
		Surrender = 4,
		[Token(Token = "0x400DF33")]
		Failed = 5,
		[Token(Token = "0x400DF34")]
		Exodia = 6,
		[Token(Token = "0x400DF35")]
		Vija = 7,
		[Token(Token = "0x400DF36")]
		YataLock = 8,
		[Token(Token = "0x400DF37")]
		LastBattle = 9,
		[Token(Token = "0x400DF38")]
		CountDown = 10,
		[Token(Token = "0x400DF39")]
		Victory = 11,
		[Token(Token = "0x400DF3A")]
		Venom = 12,
		[Token(Token = "0x400DF3B")]
		Exodios = 13,
		[Token(Token = "0x400DF3C")]
		God = 14,
		[Token(Token = "0x400DF3D")]
		Gimmick = 15,
		[Token(Token = "0x400DF3E")]
		Gimmick2 = 16,
		[Token(Token = "0x400DF3F")]
		Jackpot7 = 17,
		[Token(Token = "0x400DF40")]
		Miracle = 18,
		[Token(Token = "0x400DF41")]
		RelaySoul = 19,
		[Token(Token = "0x400DF42")]
		Ghostrick = 20,
		[Token(Token = "0x400DF43")]
		Genohryu = 21,
		[Token(Token = "0x400DF44")]
		Winners = 22,
		[Token(Token = "0x400DF45")]
		Elephant = 23,
		[Token(Token = "0x400DF46")]
		Exodia2 = 24,
		[Token(Token = "0x400DF47")]
		Exodia3 = 25,
		[Token(Token = "0x400DF48")]
		CiNo1000 = 26,
		[Token(Token = "0x400DF49")]
		Sekitori = 27,
		[Token(Token = "0x400DF4A")]
		Shukudai = 28,
		[Token(Token = "0x400DF4B")]
		FinishError = 100,
		[Token(Token = "0x400DF4C")]
		FinishDisconnect = 101,
		[Token(Token = "0x400DF4D")]
		FinishNoContest = 102,
		[Token(Token = "0x400DF4E")]
		FinishEngineCrash = 105
	}

	[Token(Token = "0x20017D7")]
	public enum LimitedType
	{
		[Token(Token = "0x400DF50")]
		None = 0,
		[Token(Token = "0x400DF51")]
		NormalSummon = 1,
		[Token(Token = "0x400DF52")]
		SpecialSummon = 2,
		[Token(Token = "0x400DF53")]
		Set = 3,
		[Token(Token = "0x400DF54")]
		Tribute = 4,
		[Token(Token = "0x400DF55")]
		ChangePos = 5,
		[Token(Token = "0x400DF56")]
		Attack = 6,
		[Token(Token = "0x400DF57")]
		Draw2 = 7,
		[Token(Token = "0x400DF58")]
		Turn20 = 8,
		[Token(Token = "0x400DF59")]
		Damage = 9,
		[Token(Token = "0x400DF5A")]
		Beginner = 10,
		[Token(Token = "0x400DF5B")]
		Beginner2 = 11,
		[Token(Token = "0x400DF5C")]
		Vs2on1 = 12,
		[Token(Token = "0x400DF5D")]
		Vs2on1_Hand = 13,
		[Token(Token = "0x400DF5E")]
		FirstDraw = 14,
		[Token(Token = "0x400DF5F")]
		Vs3on1 = 15,
		[Token(Token = "0x400DF60")]
		Survival_1on3 = 256,
		[Token(Token = "0x400DF61")]
		Survival_3on3 = 257,
		[Token(Token = "0x400DF62")]
		Survival_1on2 = 258,
		[Token(Token = "0x400DF63")]
		NoRandom = 16,
		[Token(Token = "0x400DF64")]
		OldRule = 32,
		[Token(Token = "0x400DF65")]
		OldRule2 = 64,
		[Token(Token = "0x400DF66")]
		OldField = 128
	}

	[Token(Token = "0x20017D8")]
	public enum TagType
	{
		[Token(Token = "0x400DF68")]
		Single,
		[Token(Token = "0x400DF69")]
		Tag,
		[Token(Token = "0x400DF6A")]
		Team
	}

	[Token(Token = "0x20017D9")]
	public enum Phase
	{
		[Token(Token = "0x400DF6C")]
		Draw = 0,
		[Token(Token = "0x400DF6D")]
		Standby = 1,
		[Token(Token = "0x400DF6E")]
		Main1 = 2,
		[Token(Token = "0x400DF6F")]
		Battle = 3,
		[Token(Token = "0x400DF70")]
		Main2 = 4,
		[Token(Token = "0x400DF71")]
		End = 5,
		[Token(Token = "0x400DF72")]
		Null = 7
	}

	[Token(Token = "0x20017DA")]
	public enum StepType
	{
		[Token(Token = "0x400DF74")]
		Null,
		[Token(Token = "0x400DF75")]
		Start,
		[Token(Token = "0x400DF76")]
		Battle,
		[Token(Token = "0x400DF77")]
		Damage,
		[Token(Token = "0x400DF78")]
		End
	}

	[Token(Token = "0x20017DB")]
	public enum DmgStepType
	{
		[Token(Token = "0x400DF7A")]
		Null,
		[Token(Token = "0x400DF7B")]
		Start,
		[Token(Token = "0x400DF7C")]
		BeforeCalc,
		[Token(Token = "0x400DF7D")]
		DamageCalc,
		[Token(Token = "0x400DF7E")]
		AfterCalc,
		[Token(Token = "0x400DF7F")]
		End
	}

	[Token(Token = "0x20017DC")]
	public enum CounterType
	{
		[Token(Token = "0x400DF81")]
		Magic,
		[Token(Token = "0x400DF82")]
		Normal,
		[Token(Token = "0x400DF83")]
		Clock,
		[Token(Token = "0x400DF84")]
		Hyper,
		[Token(Token = "0x400DF85")]
		Gem,
		[Token(Token = "0x400DF86")]
		Chronicle,
		[Token(Token = "0x400DF87")]
		Bushido,
		[Token(Token = "0x400DF88")]
		D,
		[Token(Token = "0x400DF89")]
		Shine,
		[Token(Token = "0x400DF8A")]
		Gate,
		[Token(Token = "0x400DF8B")]
		Worm,
		[Token(Token = "0x400DF8C")]
		Deformer,
		[Token(Token = "0x400DF8D")]
		Flower,
		[Token(Token = "0x400DF8E")]
		Plant,
		[Token(Token = "0x400DF8F")]
		Psycho,
		[Token(Token = "0x400DF90")]
		EarthBind,
		[Token(Token = "0x400DF91")]
		Junk,
		[Token(Token = "0x400DF92")]
		Genex,
		[Token(Token = "0x400DF93")]
		Dragonic,
		[Token(Token = "0x400DF94")]
		Ocean,
		[Token(Token = "0x400DF95")]
		BF,
		[Token(Token = "0x400DF96")]
		Death,
		[Token(Token = "0x400DF97")]
		Karakuri,
		[Token(Token = "0x400DF98")]
		Stone,
		[Token(Token = "0x400DF99")]
		Thunder,
		[Token(Token = "0x400DF9A")]
		Donguri,
		[Token(Token = "0x400DF9B")]
		Greed,
		[Token(Token = "0x400DF9C")]
		Chaos,
		[Token(Token = "0x400DF9D")]
		Double,
		[Token(Token = "0x400DF9E")]
		Destiny,
		[Token(Token = "0x400DF9F")]
		Orbital,
		[Token(Token = "0x400DFA0")]
		Shark,
		[Token(Token = "0x400DFA1")]
		Pumpkin,
		[Token(Token = "0x400DFA2")]
		HopeSlash,
		[Token(Token = "0x400DFA3")]
		Kattobing,
		[Token(Token = "0x400DFA4")]
		Balloon,
		[Token(Token = "0x400DFA5")]
		Yosen,
		[Token(Token = "0x400DFA6")]
		Sound,
		[Token(Token = "0x400DFA7")]
		Em,
		[Token(Token = "0x400DFA8")]
		Kaiju,
		[Token(Token = "0x400DFA9")]
		Defect,
		[Token(Token = "0x400DFAA")]
		Athlete,
		[Token(Token = "0x400DFAB")]
		Barrel,
		[Token(Token = "0x400DFAC")]
		Summon,
		[Token(Token = "0x400DFAD")]
		FireStar,
		[Token(Token = "0x400DFAE")]
		Phantasm,
		[Token(Token = "0x400DFAF")]
		Otoshidama,
		[Token(Token = "0x400DFB0")]
		Ounokagi,
		[Token(Token = "0x400DFB1")]
		Piece,
		[Token(Token = "0x400DFB2")]
		Girl,
		[Token(Token = "0x400DFB3")]
		Gardna,
		[Token(Token = "0x400DFB4")]
		Alien,
		[Token(Token = "0x400DFB5")]
		Ice,
		[Token(Token = "0x400DFB6")]
		Venom,
		[Token(Token = "0x400DFB7")]
		Fog,
		[Token(Token = "0x400DFB8")]
		Guard,
		[Token(Token = "0x400DFB9")]
		Wedge,
		[Token(Token = "0x400DFBA")]
		Guard2,
		[Token(Token = "0x400DFBB")]
		String,
		[Token(Token = "0x400DFBC")]
		Houkai,
		[Token(Token = "0x400DFBD")]
		Zushin,
		[Token(Token = "0x400DFBE")]
		Predator,
		[Token(Token = "0x400DFBF")]
		Scales,
		[Token(Token = "0x400DFC0")]
		Police,
		[Token(Token = "0x400DFC1")]
		Signal,
		[Token(Token = "0x400DFC2")]
		Venemy,
		[Token(Token = "0x400DFC3")]
		Burn,
		[Token(Token = "0x400DFC4")]
		Illusion,
		[Token(Token = "0x400DFC5")]
		GG,
		[Token(Token = "0x400DFC6")]
		Rabbit,
		[Token(Token = "0x400DFC7")]
		Kyoumei,
		[Token(Token = "0x400DFC8")]
		Kyouai,
		[Token(Token = "0x400DFC9")]
		Access,
		[Token(Token = "0x400DFCA")]
		Shukudai,
		[Token(Token = "0x400DFCB")]
		Shiki,
		[Token(Token = "0x400DFCC")]
		Kyuzai,
		[Token(Token = "0x400DFCD")]
		C,
		[Token(Token = "0x400DFCE")]
		Osara,
		[Token(Token = "0x400DFCF")]
		T,
		[Token(Token = "0x400DFD0")]
		AAA,
		[Token(Token = "0x400DFD1")]
		BBB,
		[Token(Token = "0x400DFD2")]
		Max
	}

	[Token(Token = "0x20017DD")]
	public enum ViewType
	{
		[Token(Token = "0x400DFD4")]
		Noop = -1,
		[Token(Token = "0x400DFD5")]
		Null,
		[Token(Token = "0x400DFD6")]
		DuelStart,
		[Token(Token = "0x400DFD7")]
		DuelEnd,
		[Token(Token = "0x400DFD8")]
		WaitFrame,
		[Token(Token = "0x400DFD9")]
		WaitInput,
		[Token(Token = "0x400DFDA")]
		PhaseChange,
		[Token(Token = "0x400DFDB")]
		TurnChange,
		[Token(Token = "0x400DFDC")]
		FieldChange,
		[Token(Token = "0x400DFDD")]
		CursorSet,
		[Token(Token = "0x400DFDE")]
		BgmUpdate,
		[Token(Token = "0x400DFDF")]
		BattleInit,
		[Token(Token = "0x400DFE0")]
		BattleSelect,
		[Token(Token = "0x400DFE1")]
		BattleAttack,
		[Token(Token = "0x400DFE2")]
		BattleRun,
		[Token(Token = "0x400DFE3")]
		BattleEnd,
		[Token(Token = "0x400DFE4")]
		LifeSet,
		[Token(Token = "0x400DFE5")]
		LifeDamage,
		[Token(Token = "0x400DFE6")]
		LifeReset,
		[Token(Token = "0x400DFE7")]
		HandShuffle,
		[Token(Token = "0x400DFE8")]
		HandShow,
		[Token(Token = "0x400DFE9")]
		HandOpen,
		[Token(Token = "0x400DFEA")]
		DeckShuffle,
		[Token(Token = "0x400DFEB")]
		DeckReset,
		[Token(Token = "0x400DFEC")]
		DeckFlipTop,
		[Token(Token = "0x400DFED")]
		GraveTop,
		[Token(Token = "0x400DFEE")]
		CardLockon,
		[Token(Token = "0x400DFEF")]
		CardMove,
		[Token(Token = "0x400DFF0")]
		CardSwap,
		[Token(Token = "0x400DFF1")]
		CardFlipTurn,
		[Token(Token = "0x400DFF2")]
		CardCheat,
		[Token(Token = "0x400DFF3")]
		CardSet,
		[Token(Token = "0x400DFF4")]
		CardVanish,
		[Token(Token = "0x400DFF5")]
		CardBreak,
		[Token(Token = "0x400DFF6")]
		CardExplosion,
		[Token(Token = "0x400DFF7")]
		CardExclude,
		[Token(Token = "0x400DFF8")]
		CardHappen,
		[Token(Token = "0x400DFF9")]
		CardDisable,
		[Token(Token = "0x400DFFA")]
		CardEquip,
		[Token(Token = "0x400DFFB")]
		CardIncTurn,
		[Token(Token = "0x400DFFC")]
		CardUpdate,
		[Token(Token = "0x400DFFD")]
		ManaSet,
		[Token(Token = "0x400DFFE")]
		MonstDeathTurn,
		[Token(Token = "0x400DFFF")]
		MonstShuffle,
		[Token(Token = "0x400E000")]
		TributeSet,
		[Token(Token = "0x400E001")]
		TributeReset,
		[Token(Token = "0x400E002")]
		TributeRun,
		[Token(Token = "0x400E003")]
		MaterialSet,
		[Token(Token = "0x400E004")]
		MaterialReset,
		[Token(Token = "0x400E005")]
		MaterialRun,
		[Token(Token = "0x400E006")]
		TuningSet,
		[Token(Token = "0x400E007")]
		TuningReset,
		[Token(Token = "0x400E008")]
		TuningRun,
		[Token(Token = "0x400E009")]
		ChainSet,
		[Token(Token = "0x400E00A")]
		ChainRun,
		[Token(Token = "0x400E00B")]
		RunSurrender,
		[Token(Token = "0x400E00C")]
		RunDialog,
		[Token(Token = "0x400E00D")]
		RunList,
		[Token(Token = "0x400E00E")]
		RunSummon,
		[Token(Token = "0x400E00F")]
		RunSpSummon,
		[Token(Token = "0x400E010")]
		RunFusion,
		[Token(Token = "0x400E011")]
		RunDetail,
		[Token(Token = "0x400E012")]
		RunCoin,
		[Token(Token = "0x400E013")]
		RunDice,
		[Token(Token = "0x400E014")]
		RunYujyo,
		[Token(Token = "0x400E015")]
		RunSpecialWin,
		[Token(Token = "0x400E016")]
		RunVija,
		[Token(Token = "0x400E017")]
		RunExtra,
		[Token(Token = "0x400E018")]
		RunCommand,
		[Token(Token = "0x400E019")]
		CutinDraw,
		[Token(Token = "0x400E01A")]
		CutinSummon,
		[Token(Token = "0x400E01B")]
		CutinFusion,
		[Token(Token = "0x400E01C")]
		CutinChain,
		[Token(Token = "0x400E01D")]
		CutinActivate,
		[Token(Token = "0x400E01E")]
		CutinSet,
		[Token(Token = "0x400E01F")]
		CutinReverse,
		[Token(Token = "0x400E020")]
		CutinTurn,
		[Token(Token = "0x400E021")]
		CutinFlip,
		[Token(Token = "0x400E022")]
		CutinTurnEnd,
		[Token(Token = "0x400E023")]
		CutinDamage,
		[Token(Token = "0x400E024")]
		CutinBreak,
		[Token(Token = "0x400E025")]
		CpuThinking,
		[Token(Token = "0x400E026")]
		HandRundom,
		[Token(Token = "0x400E027")]
		OverlaySet,
		[Token(Token = "0x400E028")]
		OverlayReset,
		[Token(Token = "0x400E029")]
		OverlayRun,
		[Token(Token = "0x400E02A")]
		CutinSuccess,
		[Token(Token = "0x400E02B")]
		ChainEnd,
		[Token(Token = "0x400E02C")]
		LinkSet,
		[Token(Token = "0x400E02D")]
		LinkReset,
		[Token(Token = "0x400E02E")]
		LinkRun,
		[Token(Token = "0x400E02F")]
		RunJanken,
		[Token(Token = "0x400E030")]
		CutinCoinDice,
		[Token(Token = "0x400E031")]
		ChainStep,
		[Token(Token = "0x400E032")]
		RunSpecialefx
	}

	[Token(Token = "0x20017DE")]
	public enum FieldAnimeType
	{
		[Token(Token = "0x400E034")]
		Null,
		[Token(Token = "0x400E035")]
		CardMove,
		[Token(Token = "0x400E036")]
		CardWarp,
		[Token(Token = "0x400E037")]
		CardSwap
	}

	[Token(Token = "0x20017DF")]
	public enum CardMoveType
	{
		[Token(Token = "0x400E039")]
		Normal,
		[Token(Token = "0x400E03A")]
		Normal2,
		[Token(Token = "0x400E03B")]
		Summon,
		[Token(Token = "0x400E03C")]
		SpSummon,
		[Token(Token = "0x400E03D")]
		Activate,
		[Token(Token = "0x400E03E")]
		Set,
		[Token(Token = "0x400E03F")]
		Break,
		[Token(Token = "0x400E040")]
		Explosion,
		[Token(Token = "0x400E041")]
		Sacrifice,
		[Token(Token = "0x400E042")]
		Draw,
		[Token(Token = "0x400E043")]
		Drop,
		[Token(Token = "0x400E044")]
		Search,
		[Token(Token = "0x400E045")]
		Used,
		[Token(Token = "0x400E046")]
		Put,
		[Token(Token = "0x400E047")]
		Normal3,
		[Token(Token = "0x400E048")]
		Cost,
		[Token(Token = "0x400E049")]
		CostSacrifice,
		[Token(Token = "0x400E04A")]
		CostDrop
	}

	[Token(Token = "0x20017E0")]
	public struct CardProp
	{
		[Token(Token = "0x170016D5")]
		public ushort cardId
		{
			[Token(Token = "0x6009897")]
			[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x6009898")]
			[Address(RVA = "0xE360F0", Offset = "0xE352F0", VA = "0x180E360F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016D6")]
		public ushort uniqueId
		{
			[Token(Token = "0x6009899")]
			[Address(RVA = "0x9D5910", Offset = "0x9D4B10", VA = "0x1809D5910")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x600989A")]
			[Address(RVA = "0xE360D0", Offset = "0xE352D0", VA = "0x180E360D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016D7")]
		public ushort flags
		{
			[Token(Token = "0x600989B")]
			[Address(RVA = "0xE360C0", Offset = "0xE352C0", VA = "0x180E360C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x600989C")]
			[Address(RVA = "0xE36100", Offset = "0xE35300", VA = "0x180E36100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016D8")]
		public int CardID
		{
			[Token(Token = "0x600989D")]
			[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600989E")]
			[Address(RVA = "0xE360F0", Offset = "0xE352F0", VA = "0x180E360F0")]
			set
			{
			}
		}

		[Token(Token = "0x170016D9")]
		public int UniqueID
		{
			[Token(Token = "0x600989F")]
			[Address(RVA = "0x9D5910", Offset = "0x9D4B10", VA = "0x1809D5910")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098A0")]
			[Address(RVA = "0xE360D0", Offset = "0xE352D0", VA = "0x180E360D0")]
			set
			{
			}
		}

		[Token(Token = "0x170016DA")]
		public int Owner
		{
			[Token(Token = "0x60098A1")]
			[Address(RVA = "0xE363E0", Offset = "0xE355E0", VA = "0x180E363E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098A2")]
			[Address(RVA = "0xE36460", Offset = "0xE35660", VA = "0x180E36460")]
			set
			{
			}
		}

		[Token(Token = "0x170016DB")]
		public bool Correct
		{
			[Token(Token = "0x60098A3")]
			[Address(RVA = "0xE363C0", Offset = "0xE355C0", VA = "0x180E363C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098A4")]
			[Address(RVA = "0xE36440", Offset = "0xE35640", VA = "0x180E36440")]
			set
			{
			}
		}

		[Token(Token = "0x170016DC")]
		public bool ByBattle
		{
			[Token(Token = "0x60098A5")]
			[Address(RVA = "0xE363A0", Offset = "0xE355A0", VA = "0x180E363A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098A6")]
			[Address(RVA = "0xE36420", Offset = "0xE35620", VA = "0x180E36420")]
			set
			{
			}
		}

		[Token(Token = "0x170016DD")]
		public bool ByAnother
		{
			[Token(Token = "0x60098A7")]
			[Address(RVA = "0xE36390", Offset = "0xE35590", VA = "0x180E36390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098A8")]
			[Address(RVA = "0xE36410", Offset = "0xE35610", VA = "0x180E36410")]
			set
			{
			}
		}

		[Token(Token = "0x170016DE")]
		public bool ByBreak
		{
			[Token(Token = "0x60098A9")]
			[Address(RVA = "0xE363B0", Offset = "0xE355B0", VA = "0x180E363B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098AA")]
			[Address(RVA = "0xE36430", Offset = "0xE35630", VA = "0x180E36430")]
			set
			{
			}
		}

		[Token(Token = "0x170016DF")]
		public bool TurnPast
		{
			[Token(Token = "0x60098AB")]
			[Address(RVA = "0xE36400", Offset = "0xE35600", VA = "0x180E36400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098AC")]
			[Address(RVA = "0xE36480", Offset = "0xE35680", VA = "0x180E36480")]
			set
			{
			}
		}

		[Token(Token = "0x170016E0")]
		public bool Disabled
		{
			[Token(Token = "0x60098AD")]
			[Address(RVA = "0xE363D0", Offset = "0xE355D0", VA = "0x180E363D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098AE")]
			[Address(RVA = "0xE36450", Offset = "0xE35650", VA = "0x180E36450")]
			set
			{
			}
		}

		[Token(Token = "0x170016E1")]
		public bool TimingPast
		{
			[Token(Token = "0x60098AF")]
			[Address(RVA = "0xE363F0", Offset = "0xE355F0", VA = "0x180E363F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098B0")]
			[Address(RVA = "0xE36470", Offset = "0xE35670", VA = "0x180E36470")]
			set
			{
			}
		}

		[Token(Token = "0x60098B1")]
		[Address(RVA = "0xE36370", Offset = "0xE35570", VA = "0x180E36370")]
		public CardProp(uint param)
		{
		}
	}

	[Token(Token = "0x20017E1")]
	public struct CardStatus
	{
		[Token(Token = "0x400E04E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BitVector32.Section player;

		[Token(Token = "0x400E04F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private BitVector32.Section position;

		[Token(Token = "0x400E050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private BitVector32.Section index;

		[Token(Token = "0x400E051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private BitVector32.Section face;

		[Token(Token = "0x400E052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BitVector32.Section turn;

		[Token(Token = "0x400E053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private BitVector32 bitVec;

		[Token(Token = "0x170016E2")]
		public int Player
		{
			[Token(Token = "0x60098B2")]
			[Address(RVA = "0xE36540", Offset = "0xE35740", VA = "0x180E36540")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098B3")]
			[Address(RVA = "0xE365C0", Offset = "0xE357C0", VA = "0x180E365C0")]
			set
			{
			}
		}

		[Token(Token = "0x170016E3")]
		public int Position
		{
			[Token(Token = "0x60098B4")]
			[Address(RVA = "0xE36550", Offset = "0xE35750", VA = "0x180E36550")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098B5")]
			[Address(RVA = "0xE365E0", Offset = "0xE357E0", VA = "0x180E365E0")]
			set
			{
			}
		}

		[Token(Token = "0x170016E4")]
		public int Index
		{
			[Token(Token = "0x60098B6")]
			[Address(RVA = "0xE36530", Offset = "0xE35730", VA = "0x180E36530")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098B7")]
			[Address(RVA = "0xE365A0", Offset = "0xE357A0", VA = "0x180E365A0")]
			set
			{
			}
		}

		[Token(Token = "0x170016E5")]
		public bool Face
		{
			[Token(Token = "0x60098B8")]
			[Address(RVA = "0xE36510", Offset = "0xE35710", VA = "0x180E36510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098B9")]
			[Address(RVA = "0xE36580", Offset = "0xE35780", VA = "0x180E36580")]
			set
			{
			}
		}

		[Token(Token = "0x170016E6")]
		public bool Turn
		{
			[Token(Token = "0x60098BA")]
			[Address(RVA = "0xE36560", Offset = "0xE35760", VA = "0x180E36560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60098BB")]
			[Address(RVA = "0xE36600", Offset = "0xE35800", VA = "0x180E36600")]
			set
			{
			}
		}

		[Token(Token = "0x60098BC")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		public int ToInt()
		{
			return default(int);
		}

		[Token(Token = "0x60098BD")]
		[Address(RVA = "0xE36490", Offset = "0xE35690", VA = "0x180E36490")]
		public CardStatus(int param)
		{
		}
	}

	[Token(Token = "0x20017E2")]
	public struct BasicVal
	{
		[Token(Token = "0x400E054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short CardID;

		[Token(Token = "0x400E055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short EffectID;

		[Token(Token = "0x400E056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Atk;

		[Token(Token = "0x400E057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Def;

		[Token(Token = "0x400E058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int OrgAtk;

		[Token(Token = "0x400E059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int OrgDef;

		[Token(Token = "0x400E05A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public short Type;

		[Token(Token = "0x400E05B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public short Attr;

		[Token(Token = "0x400E05C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short Element;

		[Token(Token = "0x400E05D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public short Level;

		[Token(Token = "0x400E05E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public byte Rank;

		[Token(Token = "0x400E05F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public byte VoidMagic;

		[Token(Token = "0x400E060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public byte VoidTrap;

		[Token(Token = "0x400E061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public byte VoidMonst;
	}

	[Token(Token = "0x20017E3")]
	public struct AffectProp
	{
		[Token(Token = "0x170016E7")]
		public ushort player
		{
			[Token(Token = "0x60098BE")]
			[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x60098BF")]
			[Address(RVA = "0xE360F0", Offset = "0xE352F0", VA = "0x180E360F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016E8")]
		public ushort cardID
		{
			[Token(Token = "0x60098C0")]
			[Address(RVA = "0x9D5910", Offset = "0x9D4B10", VA = "0x1809D5910")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x60098C1")]
			[Address(RVA = "0xE360D0", Offset = "0xE352D0", VA = "0x180E360D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016E9")]
		public ushort type
		{
			[Token(Token = "0x60098C2")]
			[Address(RVA = "0xE360C0", Offset = "0xE352C0", VA = "0x180E360C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x60098C3")]
			[Address(RVA = "0xE36100", Offset = "0xE35300", VA = "0x180E36100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016EA")]
		public ushort param
		{
			[Token(Token = "0x60098C4")]
			[Address(RVA = "0xE360B0", Offset = "0xE352B0", VA = "0x180E360B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x60098C5")]
			[Address(RVA = "0xE360E0", Offset = "0xE352E0", VA = "0x180E360E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016EB")]
		public int Player
		{
			[Token(Token = "0x60098C6")]
			[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098C7")]
			[Address(RVA = "0xE360F0", Offset = "0xE352F0", VA = "0x180E360F0")]
			set
			{
			}
		}

		[Token(Token = "0x170016EC")]
		public int CardID
		{
			[Token(Token = "0x60098C8")]
			[Address(RVA = "0x9D5910", Offset = "0x9D4B10", VA = "0x1809D5910")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098C9")]
			[Address(RVA = "0xE360D0", Offset = "0xE352D0", VA = "0x180E360D0")]
			set
			{
			}
		}

		[Token(Token = "0x170016ED")]
		public int Type
		{
			[Token(Token = "0x60098CA")]
			[Address(RVA = "0xE360C0", Offset = "0xE352C0", VA = "0x180E360C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098CB")]
			[Address(RVA = "0xE36100", Offset = "0xE35300", VA = "0x180E36100")]
			set
			{
			}
		}

		[Token(Token = "0x170016EE")]
		public int Param
		{
			[Token(Token = "0x60098CC")]
			[Address(RVA = "0xE360B0", Offset = "0xE352B0", VA = "0x180E360B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60098CD")]
			[Address(RVA = "0xE360E0", Offset = "0xE352E0", VA = "0x180E360E0")]
			set
			{
			}
		}

		[Token(Token = "0x60098CE")]
		[Address(RVA = "0xE36080", Offset = "0xE35280", VA = "0x180E36080")]
		public AffectProp(ulong affectProp)
		{
		}
	}

	[Token(Token = "0x20017E4")]
	public enum MenuActType
	{
		[Token(Token = "0x400E067")]
		Null,
		[Token(Token = "0x400E068")]
		DrawPhase,
		[Token(Token = "0x400E069")]
		MainPhase,
		[Token(Token = "0x400E06A")]
		BattlePhase,
		[Token(Token = "0x400E06B")]
		CheckTiming,
		[Token(Token = "0x400E06C")]
		CheckChain,
		[Token(Token = "0x400E06D")]
		SummonChance,
		[Token(Token = "0x400E06E")]
		Location,
		[Token(Token = "0x400E06F")]
		Selection,
		[Token(Token = "0x400E070")]
		LockOn
	}

	[Token(Token = "0x20017E5")]
	public enum MenuParamType
	{
		[Token(Token = "0x400E072")]
		Force = -1,
		[Token(Token = "0x400E073")]
		Cancel,
		[Token(Token = "0x400E074")]
		Decide,
		[Token(Token = "0x400E075")]
		TrueCancel,
		[Token(Token = "0x400E076")]
		OnlyCancel,
		[Token(Token = "0x400E077")]
		DecideCancel
	}

	[Token(Token = "0x20017E6")]
	public enum CommandType
	{
		[Token(Token = "0x400E079")]
		Attack,
		[Token(Token = "0x400E07A")]
		Look,
		[Token(Token = "0x400E07B")]
		SummonSp,
		[Token(Token = "0x400E07C")]
		Action,
		[Token(Token = "0x400E07D")]
		Summon,
		[Token(Token = "0x400E07E")]
		Reverse,
		[Token(Token = "0x400E07F")]
		SetMonst,
		[Token(Token = "0x400E080")]
		Set,
		[Token(Token = "0x400E081")]
		Pendulum,
		[Token(Token = "0x400E082")]
		TurnAtk,
		[Token(Token = "0x400E083")]
		TurnDef,
		[Token(Token = "0x400E084")]
		Surrender,
		[Token(Token = "0x400E085")]
		Decide,
		[Token(Token = "0x400E086")]
		Draw
	}

	[Token(Token = "0x20017E7")]
	[Flags]
	public enum CommandBit
	{
		[Token(Token = "0x400E088")]
		Attack = 1,
		[Token(Token = "0x400E089")]
		Look = 2,
		[Token(Token = "0x400E08A")]
		SummonSp = 4,
		[Token(Token = "0x400E08B")]
		Action = 8,
		[Token(Token = "0x400E08C")]
		Summon = 0x10,
		[Token(Token = "0x400E08D")]
		Reverse = 0x20,
		[Token(Token = "0x400E08E")]
		SetMonst = 0x40,
		[Token(Token = "0x400E08F")]
		Set = 0x80,
		[Token(Token = "0x400E090")]
		Pendulum = 0x100,
		[Token(Token = "0x400E091")]
		TurnAtk = 0x200,
		[Token(Token = "0x400E092")]
		TurnDef = 0x400,
		[Token(Token = "0x400E093")]
		Surrender = 0x800,
		[Token(Token = "0x400E094")]
		Decide = 0x1000,
		[Token(Token = "0x400E095")]
		Draw = 0x2000
	}

	[Token(Token = "0x20017E8")]
	public enum CardLink
	{
		[Token(Token = "0x400E097")]
		UL,
		[Token(Token = "0x400E098")]
		U,
		[Token(Token = "0x400E099")]
		UR,
		[Token(Token = "0x400E09A")]
		L,
		[Token(Token = "0x400E09B")]
		R,
		[Token(Token = "0x400E09C")]
		DL,
		[Token(Token = "0x400E09D")]
		D,
		[Token(Token = "0x400E09E")]
		DR
	}

	[Token(Token = "0x20017E9")]
	[Flags]
	public enum CardLinkBit
	{
		[Token(Token = "0x400E0A0")]
		UL = 1,
		[Token(Token = "0x400E0A1")]
		U = 2,
		[Token(Token = "0x400E0A2")]
		UR = 4,
		[Token(Token = "0x400E0A3")]
		L = 8,
		[Token(Token = "0x400E0A4")]
		R = 0x10,
		[Token(Token = "0x400E0A5")]
		DL = 0x20,
		[Token(Token = "0x400E0A6")]
		D = 0x40,
		[Token(Token = "0x400E0A7")]
		DR = 0x80
	}

	[Token(Token = "0x20017EA")]
	public enum ShowParam
	{
		[Token(Token = "0x400E0A9")]
		Null,
		[Token(Token = "0x400E0AA")]
		Type,
		[Token(Token = "0x400E0AB")]
		Attr,
		[Token(Token = "0x400E0AC")]
		Card,
		[Token(Token = "0x400E0AD")]
		Num,
		[Token(Token = "0x400E0AE")]
		AttrMask,
		[Token(Token = "0x400E0AF")]
		Dlg
	}

	[Token(Token = "0x20017EB")]
	public enum DamageType
	{
		[Token(Token = "0x400E0B1")]
		ByEffect,
		[Token(Token = "0x400E0B2")]
		ByBattle,
		[Token(Token = "0x400E0B3")]
		ByCost,
		[Token(Token = "0x400E0B4")]
		ByLost,
		[Token(Token = "0x400E0B5")]
		Recover,
		[Token(Token = "0x400E0B6")]
		ByPay
	}

	[Token(Token = "0x20017EC")]
	[Flags]
	public enum BtlPropFlag
	{
		[Token(Token = "0x400E0B8")]
		Turn = 1,
		[Token(Token = "0x400E0B9")]
		Break = 2,
		[Token(Token = "0x400E0BA")]
		Damage = 4
	}

	[Token(Token = "0x20017ED")]
	public enum AffectType
	{
		[Token(Token = "0x400E0BC")]
		Null = 0,
		[Token(Token = "0x400E0BD")]
		Equip = 1,
		[Token(Token = "0x400E0BE")]
		Permanent = 2,
		[Token(Token = "0x400E0BF")]
		Field = 3,
		[Token(Token = "0x400E0C0")]
		Bind = 4,
		[Token(Token = "0x400E0C1")]
		Power = 5,
		[Token(Token = "0x400E0C2")]
		Target = 6,
		[Token(Token = "0x400E0C3")]
		Disable = 7,
		[Token(Token = "0x400E0C4")]
		Chain = 256
	}

	[Token(Token = "0x20017EE")]
	public enum SpSummonType
	{
		[Token(Token = "0x400E0C6")]
		Fusion,
		[Token(Token = "0x400E0C7")]
		SpFusion,
		[Token(Token = "0x400E0C8")]
		Synchro,
		[Token(Token = "0x400E0C9")]
		Ritual,
		[Token(Token = "0x400E0CA")]
		Xyz,
		[Token(Token = "0x400E0CB")]
		Pendulum,
		[Token(Token = "0x400E0CC")]
		Link,
		[Token(Token = "0x400E0CD")]
		Maximum
	}

	[Token(Token = "0x20017EF")]
	public enum CutinSummonType
	{
		[Token(Token = "0x400E0CF")]
		Normal,
		[Token(Token = "0x400E0D0")]
		Release1,
		[Token(Token = "0x400E0D1")]
		Release2,
		[Token(Token = "0x400E0D2")]
		Release3,
		[Token(Token = "0x400E0D3")]
		Reverse,
		[Token(Token = "0x400E0D4")]
		SpByEffect,
		[Token(Token = "0x400E0D5")]
		SpNormal,
		[Token(Token = "0x400E0D6")]
		ReSummon,
		[Token(Token = "0x400E0D7")]
		PreSynchro,
		[Token(Token = "0x400E0D8")]
		PreXyz,
		[Token(Token = "0x400E0D9")]
		PrePendulum,
		[Token(Token = "0x400E0DA")]
		Link
	}

	[Token(Token = "0x20017F0")]
	public enum CutinActivateType
	{
		[Token(Token = "0x400E0DC")]
		NoChain,
		[Token(Token = "0x400E0DD")]
		FromField,
		[Token(Token = "0x400E0DE")]
		FromHand,
		[Token(Token = "0x400E0DF")]
		Activate,
		[Token(Token = "0x400E0E0")]
		Effect,
		[Token(Token = "0x400E0E1")]
		FldGrave,
		[Token(Token = "0x400E0E2")]
		CostEffect
	}

	[Token(Token = "0x20017F1")]
	[Flags]
	public enum CpuParam : uint
	{
		[Token(Token = "0x400E0E4")]
		None = 0u,
		[Token(Token = "0x400E0E5")]
		Def = 0x80000000u,
		[Token(Token = "0x400E0E6")]
		Fool = 0x40000000u,
		[Token(Token = "0x400E0E7")]
		Light = 0x20000000u,
		[Token(Token = "0x400E0E8")]
		MyTurnOnly = 0x10000000u,
		[Token(Token = "0x400E0E9")]
		AttackOnly = 0x4000000u,
		[Token(Token = "0x400E0EA")]
		Simple = 0x2000000u,
		[Token(Token = "0x400E0EB")]
		Simple2 = 0x1000000u,
		[Token(Token = "0x400E0EC")]
		Simples = 0x3000000u
	}

	[Token(Token = "0x20017F2")]
	public enum RunCommandType
	{
		[Token(Token = "0x400E0EE")]
		Null,
		[Token(Token = "0x400E0EF")]
		PriWaitInput,
		[Token(Token = "0x400E0F0")]
		PriCpuThinking,
		[Token(Token = "0x400E0F1")]
		PriRunDialog,
		[Token(Token = "0x400E0F2")]
		PriRunList
	}

	[Token(Token = "0x20017F3")]
	[Flags]
	public enum AffectPropTypeFlag
	{
		[Token(Token = "0x400E0F4")]
		ShowMask = 0xF,
		[Token(Token = "0x400E0F5")]
		ShowEnd = 0x10,
		[Token(Token = "0x400E0F6")]
		ShowRival = 0x20,
		[Token(Token = "0x400E0F7")]
		ShowBoth = 0x40,
		[Token(Token = "0x400E0F8")]
		ShowSmn = 0x100,
		[Token(Token = "0x400E0F9")]
		ShowAct = 0x200,
		[Token(Token = "0x400E0FA")]
		ShowBtl = 0x400,
		[Token(Token = "0x400E0FB")]
		ShowAdd = 0x800,
		[Token(Token = "0x400E0FC")]
		ShowDmg = 0x1000,
		[Token(Token = "0x400E0FD")]
		ShowStat = 0x2000,
		[Token(Token = "0x400E0FE")]
		ShowEtc = 0x4000
	}

	[Token(Token = "0x20017F4")]
	public enum DialogType
	{
		[Token(Token = "0x400E100")]
		Ok,
		[Token(Token = "0x400E101")]
		Info,
		[Token(Token = "0x400E102")]
		Confirm,
		[Token(Token = "0x400E103")]
		YesNo,
		[Token(Token = "0x400E104")]
		Effect,
		[Token(Token = "0x400E105")]
		Sort,
		[Token(Token = "0x400E106")]
		Select,
		[Token(Token = "0x400E107")]
		Phase,
		[Token(Token = "0x400E108")]
		SelType,
		[Token(Token = "0x400E109")]
		SelAttr,
		[Token(Token = "0x400E10A")]
		SelStand,
		[Token(Token = "0x400E10B")]
		SelCoin,
		[Token(Token = "0x400E10C")]
		SelDice,
		[Token(Token = "0x400E10D")]
		SelNum,
		[Token(Token = "0x400E10E")]
		Final,
		[Token(Token = "0x400E10F")]
		Result,
		[Token(Token = "0x400E110")]
		Discard,
		[Token(Token = "0x400E111")]
		Ritual,
		[Token(Token = "0x400E112")]
		Update,
		[Token(Token = "0x400E113")]
		Close
	}

	[Token(Token = "0x20017F5")]
	public enum DialogInfo
	{
		[Token(Token = "0x400E115")]
		CardName,
		[Token(Token = "0x400E116")]
		CardName2,
		[Token(Token = "0x400E117")]
		SelectItem,
		[Token(Token = "0x400E118")]
		CardType,
		[Token(Token = "0x400E119")]
		CardAttr,
		[Token(Token = "0x400E11A")]
		CardLevel,
		[Token(Token = "0x400E11B")]
		Coin,
		[Token(Token = "0x400E11C")]
		Dice,
		[Token(Token = "0x400E11D")]
		Dice2,
		[Token(Token = "0x400E11E")]
		DiceChange,
		[Token(Token = "0x400E11F")]
		NotHappen,
		[Token(Token = "0x400E120")]
		CardAttr2,
		[Token(Token = "0x400E121")]
		Info,
		[Token(Token = "0x400E122")]
		Info2,
		[Token(Token = "0x400E123")]
		Confirm
	}

	[Token(Token = "0x20017F6")]
	public enum DialogOkType
	{
		[Token(Token = "0x400E125")]
		Stop,
		[Token(Token = "0x400E126")]
		Once,
		[Token(Token = "0x400E127")]
		Forever,
		[Token(Token = "0x400E128")]
		Sub
	}

	[Token(Token = "0x20017F7")]
	public enum DialogEffectType
	{
		[Token(Token = "0x400E12A")]
		None,
		[Token(Token = "0x400E12B")]
		All,
		[Token(Token = "0x400E12C")]
		More,
		[Token(Token = "0x400E12D")]
		Auto,
		[Token(Token = "0x400E12E")]
		Always
	}

	[Token(Token = "0x20017F8")]
	public enum DialogRitualType
	{
		[Token(Token = "0x400E130")]
		Ritual,
		[Token(Token = "0x400E131")]
		Multi,
		[Token(Token = "0x400E132")]
		Atk,
		[Token(Token = "0x400E133")]
		Sync,
		[Token(Token = "0x400E134")]
		Link
	}

	[Token(Token = "0x20017F9")]
	public enum DialogMixTextType
	{
		[Token(Token = "0x400E136")]
		Null,
		[Token(Token = "0x400E137")]
		AddString,
		[Token(Token = "0x400E138")]
		AddCr,
		[Token(Token = "0x400E139")]
		InsString,
		[Token(Token = "0x400E13A")]
		InsStringNoColor,
		[Token(Token = "0x400E13B")]
		InsCard,
		[Token(Token = "0x400E13C")]
		InsType,
		[Token(Token = "0x400E13D")]
		InsAttr,
		[Token(Token = "0x400E13E")]
		InsNum,
		[Token(Token = "0x400E13F")]
		InsStringIfable
	}

	[Token(Token = "0x20017FA")]
	private class CachedParam
	{
		[Token(Token = "0x400E140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int myself;

		[Token(Token = "0x400E141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayerType[] playerType;

		[Token(Token = "0x400E142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint[] cpuParam;

		[Token(Token = "0x60098CF")]
		[Address(RVA = "0xE36220", Offset = "0xE35420", VA = "0x180E36220")]
		public CachedParam()
		{
		}

		[Token(Token = "0x60098D0")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		public void SetMyPlayerNum(int player)
		{
		}

		[Token(Token = "0x60098D1")]
		[Address(RVA = "0xE36110", Offset = "0xE35310", VA = "0x180E36110")]
		public int GetMyPlayerNum()
		{
			return default(int);
		}

		[Token(Token = "0x60098D2")]
		[Address(RVA = "0xE361F0", Offset = "0xE353F0", VA = "0x180E361F0")]
		public void SetPlayerType(int player, PlayerType type)
		{
		}

		[Token(Token = "0x60098D3")]
		[Address(RVA = "0xE36140", Offset = "0xE35340", VA = "0x180E36140")]
		public int IsPlayerType(int player, PlayerType type)
		{
			return default(int);
		}

		[Token(Token = "0x60098D4")]
		[Address(RVA = "0xE361B0", Offset = "0xE353B0", VA = "0x180E361B0")]
		public int Myself()
		{
			return default(int);
		}

		[Token(Token = "0x60098D5")]
		[Address(RVA = "0xE361D0", Offset = "0xE353D0", VA = "0x180E361D0")]
		public int Rival()
		{
			return default(int);
		}

		[Token(Token = "0x60098D6")]
		[Address(RVA = "0xE36120", Offset = "0xE35320", VA = "0x180E36120")]
		public int IsMyself(int player)
		{
			return default(int);
		}

		[Token(Token = "0x60098D7")]
		[Address(RVA = "0xE36190", Offset = "0xE35390", VA = "0x180E36190")]
		public int IsRival(int player)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20017FB")]
	public delegate int RunEffect(int id, int param1, int param2, int param3);

	[Token(Token = "0x20017FC")]
	public delegate int IsBusyEffect(int id);

	[Token(Token = "0x20017FD")]
	public delegate void AddRecord(IntPtr ptr, int size);

	[Token(Token = "0x20017FE")]
	public delegate IntPtr NowRecord();

	[Token(Token = "0x20017FF")]
	public delegate void RecordNext();

	[Token(Token = "0x2001800")]
	public delegate void RecordBegin();

	[Token(Token = "0x2001801")]
	public delegate int IsRecordEnd();

	[Token(Token = "0x2001802")]
	public delegate int ThreadRunEffectDeleg(int id, int param1, int param2, int param3);

	[Token(Token = "0x2001803")]
	public delegate int ThreadIsBusyEffectDeleg(int id);

	[Token(Token = "0x2001804")]
	public delegate void ThreadAddRecordDeleg(IntPtr ptr, int size);

	[Token(Token = "0x2001805")]
	public delegate IntPtr ThreadNowRecordDeleg();

	[Token(Token = "0x2001806")]
	public delegate void ThreadRecordNextDeleg();

	[Token(Token = "0x2001807")]
	public delegate void ThreadRecordBeginDeleg();

	[Token(Token = "0x2001808")]
	public delegate int ThreadIsRecordEndDeleg();

	[Token(Token = "0x2001809")]
	public enum ListType
	{
		[Token(Token = "0x400E144")]
		Null = 0,
		[Token(Token = "0x400E145")]
		Fusion = 1,
		[Token(Token = "0x400E146")]
		Deck = 2,
		[Token(Token = "0x400E147")]
		Grave = 3,
		[Token(Token = "0x400E148")]
		Exclude = 4,
		[Token(Token = "0x400E149")]
		View = 5,
		[Token(Token = "0x400E14A")]
		Select = 6,
		[Token(Token = "0x400E14B")]
		SelectMax = 38,
		[Token(Token = "0x400E14C")]
		Selectable = 39,
		[Token(Token = "0x400E14D")]
		SelectableMax = 71,
		[Token(Token = "0x400E14E")]
		SelUpTo = 72,
		[Token(Token = "0x400E14F")]
		SelUpToMax = 104,
		[Token(Token = "0x400E150")]
		SelFree = 105,
		[Token(Token = "0x400E151")]
		SelFreeMax = 137,
		[Token(Token = "0x400E152")]
		BlindSelect = 138,
		[Token(Token = "0x400E153")]
		AutoSelect = 139,
		[Token(Token = "0x400E154")]
		SelAllCard = 140,
		[Token(Token = "0x400E155")]
		SelAllDeck = 141,
		[Token(Token = "0x400E156")]
		SelAllMonst = 142,
		[Token(Token = "0x400E157")]
		SelAllMonst2 = 143,
		[Token(Token = "0x400E158")]
		SelAllGadget = 144,
		[Token(Token = "0x400E159")]
		SelAllIndeck = 145,
		[Token(Token = "0x400E15A")]
		SelAllGunkan = 146,
		[Token(Token = "0x400E15B")]
		SelAllNormal = 147,
		[Token(Token = "0x400E15C")]
		SelAllNormal2 = 148,
		[Token(Token = "0x400E15D")]
		SelAllArtmage = 149
	}

	[Token(Token = "0x200180A")]
	[Flags]
	public enum ListAttribute
	{
		[Token(Token = "0x400E15F")]
		FromField = 1,
		[Token(Token = "0x400E160")]
		FromHand = 2,
		[Token(Token = "0x400E161")]
		FromDeck = 4,
		[Token(Token = "0x400E162")]
		FromGrave = 8,
		[Token(Token = "0x400E163")]
		FromExtra = 0x10,
		[Token(Token = "0x400E164")]
		FromExclude = 0x20,
		[Token(Token = "0x400E165")]
		DisableEffect = 0x40,
		[Token(Token = "0x400E166")]
		CantRevive = 0x80,
		[Token(Token = "0x400E167")]
		FusionMaterial = 0x100,
		[Token(Token = "0x400E168")]
		DemensionHole = 0x400,
		[Token(Token = "0x400E169")]
		LightForce = 0x800,
		[Token(Token = "0x400E16A")]
		Targeted = 0x1000,
		[Token(Token = "0x400E16B")]
		Tuning = 0x2000,
		[Token(Token = "0x400E16C")]
		ByBattle = 0x4000,
		[Token(Token = "0x400E16D")]
		Opponent = 0x8000,
		[Token(Token = "0x400E16E")]
		Activate = 0x10000,
		[Token(Token = "0x400E16F")]
		Cost = 0x20000,
		[Token(Token = "0x400E170")]
		End = 0x40000,
		[Token(Token = "0x400E171")]
		ExtraExclude = 0x80000,
		[Token(Token = "0x400E172")]
		FromMask = 0x3F
	}

	[Token(Token = "0x200180B")]
	private class PvpPosBase
	{
		[Token(Token = "0x400E173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint nComBit;

		[Token(Token = "0x400E174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ushort wMrk;

		[Token(Token = "0x400E175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public ushort wTurnCounter;

		[Token(Token = "0x400E176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte bTopIdx;

		[Token(Token = "0x400E177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public byte bEffectFlags;

		[Token(Token = "0x400E178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public byte bMonstOrgLevel;

		[Token(Token = "0x400E179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public byte bMonstOrgType;

		[Token(Token = "0x400E17A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public byte bZoneAvailable;

		[Token(Token = "0x400E17B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public byte bZoneAvailable2;

		[Token(Token = "0x400E17C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public byte bCardInBattle;

		[Token(Token = "0x400E17D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public byte bNormalMonster;

		[Token(Token = "0x400E17E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public sbyte bPendScale;

		[Token(Token = "0x400E17F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public sbyte bPendOrgScale;

		[Token(Token = "0x400E180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public sbyte bMonstRank;

		[Token(Token = "0x400E181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public sbyte bMonstOrgRank;

		[Token(Token = "0x400E182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public byte bTrapMonster;

		[Token(Token = "0x400E183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public byte bTunerMonster;

		[Token(Token = "0x400E184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public ushort wOverlayNum;

		[Token(Token = "0x400E185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ushort wCardNum;

		[Token(Token = "0x400E186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] bCounter;

		[Token(Token = "0x400E187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public byte bFightable;

		[Token(Token = "0x400E188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public ushort wEquip;

		[Token(Token = "0x400E189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ushort wContinuous;

		[Token(Token = "0x400E18A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public byte bIsMagic;

		[Token(Token = "0x400E18B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
		public byte bIsTrap;

		[Token(Token = "0x400E18C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte bIsMaximumMode;

		[Token(Token = "0x400E18D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint nComBitTextId;

		[Token(Token = "0x400E18E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int nShowParam;

		[Token(Token = "0x400E18F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint nCardParam;

		[Token(Token = "0x400E190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int nCardDirectFlag;

		[Token(Token = "0x400E191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int[] nOtherEffect;

		[Token(Token = "0x6009910")]
		[Address(RVA = "0xE3A910", Offset = "0xE39B10", VA = "0x180E3A910")]
		public PvpPosBase()
		{
		}
	}

	[Token(Token = "0x200180C")]
	private class PvpIconBase
	{
		[Token(Token = "0x400E192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte player;

		[Token(Token = "0x400E193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte pos;

		[Token(Token = "0x400E194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte to_player;

		[Token(Token = "0x400E195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public byte to_pos;

		[Token(Token = "0x400E196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public short icon;

		[Token(Token = "0x6009911")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PvpIconBase()
		{
		}
	}

	[Token(Token = "0x200180D")]
	private class PvpDuelInfo
	{
		[Token(Token = "0x400E197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isQuick;

		[Token(Token = "0x400E198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint nTurnNum;

		[Token(Token = "0x400E199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint nCurrentPhase;

		[Token(Token = "0x400E19A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint nCurrentStep;

		[Token(Token = "0x400E19B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint nCurrentDmgStep;

		[Token(Token = "0x400E19C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public byte bWhichTurnNow;

		[Token(Token = "0x400E19D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint nMovablePhase;

		[Token(Token = "0x400E19E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint[] nLP;

		[Token(Token = "0x400E19F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint[] nDoPutMonst;

		[Token(Token = "0x400E1A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool[] bDoSummon;

		[Token(Token = "0x400E1A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool[] bDoSpSummon;

		[Token(Token = "0x400E1A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PvpPosBase[,] Pos;

		[Token(Token = "0x400E1A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ushort wTblNum;

		[Token(Token = "0x400E1A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public ushort wIconNum;

		[Token(Token = "0x400E1A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public PvpIconBase[] IconBases;

		[Token(Token = "0x400E1A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool isDeckReverse;

		[Token(Token = "0x6009912")]
		[Address(RVA = "0xE3A310", Offset = "0xE39510", VA = "0x180E3A310")]
		public PvpDuelInfo()
		{
		}
	}

	[Token(Token = "0x200180E")]
	private class PvpUIDBase
	{
		[Token(Token = "0x400E1A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint nCom;

		[Token(Token = "0x400E1A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint nPos;

		[Token(Token = "0x400E1A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ushort wUid;

		[Token(Token = "0x400E1AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public CardProp stProp;

		[Token(Token = "0x400E1AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isFace;

		[Token(Token = "0x400E1AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isTurn;

		[Token(Token = "0x400E1AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public BasicVal stBasicVal;

		[Token(Token = "0x400E1AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint nComTextId;

		[Token(Token = "0x6009913")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PvpUIDBase()
		{
		}
	}

	[Token(Token = "0x200180F")]
	private class PvpEngineData
	{
		[Token(Token = "0x400E1AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PvpDuelInfo duelInfo;

		[Token(Token = "0x400E1B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<uint, ushort> posTbl;

		[Token(Token = "0x400E1B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<ushort, ushort> uidTbl;

		[Token(Token = "0x400E1B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PvpUIDBase[] uidBases;

		[Token(Token = "0x400E1B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public KeyValuePair<uint, ushort>[] originPos;

		[Token(Token = "0x400E1B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public KeyValuePair<ushort, ushort>[] originUid;

		[Token(Token = "0x400E1B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort[] attackFlags;

		[Token(Token = "0x400E1B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<int, uint> flipInfo;

		[Token(Token = "0x400E1B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Dictionary<ushort, int>[] cardAttribute;

		[Token(Token = "0x400E1B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool attackFinish;

		[Token(Token = "0x400E1B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public byte syncNeed;

		[Token(Token = "0x400E1BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Dictionary<int, int> tuningMonster;

		[Token(Token = "0x400E1BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dictionary<int, int> tuningLevel;

		[Token(Token = "0x400E1BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int effectIdAtChain;

		[Token(Token = "0x400E1BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int summoningUid;

		[Token(Token = "0x400E1BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, uint> posMask;

		[Token(Token = "0x400E1BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int recommendSide;

		[Token(Token = "0x400E1C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Dictionary<uint, uint> summonTextIDTable;

		[Token(Token = "0x400E1C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AffectProp[] attachedEffectList;

		[Token(Token = "0x6009914")]
		[Address(RVA = "0xE3A440", Offset = "0xE39640", VA = "0x180E3A440")]
		public PvpEngineData()
		{
		}
	}

	[Token(Token = "0x2001810")]
	private class PvpDialogData
	{
		[Token(Token = "0x400E1C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DialogType dlgType;

		[Token(Token = "0x400E1C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int player;

		[Token(Token = "0x400E1C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int selMax;

		[Token(Token = "0x400E1C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint[] sel;

		[Token(Token = "0x400E1C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint posMaskSummon;

		[Token(Token = "0x6009915")]
		[Address(RVA = "0xE3A2A0", Offset = "0xE394A0", VA = "0x180E3A2A0")]
		public PvpDialogData(int num)
		{
		}

		[Token(Token = "0x6009916")]
		[Address(RVA = "0xE3A260", Offset = "0xE39460", VA = "0x180E3A260")]
		public int GetSelectItemStr(int idx)
		{
			return default(int);
		}

		[Token(Token = "0x6009917")]
		[Address(RVA = "0xE3A220", Offset = "0xE39420", VA = "0x180E3A220")]
		public bool GetSelectItemEnable(int idx)
		{
			return default(bool);
		}

		[Token(Token = "0x6009918")]
		[Address(RVA = "0xE3A1E0", Offset = "0xE393E0", VA = "0x180E3A1E0")]
		public bool GetSelectItemDefault(int idx)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001811")]
	private class PvpListData
	{
		[Token(Token = "0x400E1C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ListType listType;

		[Token(Token = "0x400E1C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int selMax;

		[Token(Token = "0x400E1C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int selMin;

		[Token(Token = "0x400E1CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public short itemMax;

		[Token(Token = "0x400E1CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ushort[] itemUids;

		[Token(Token = "0x400E1CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint[] itemAttributes;

		[Token(Token = "0x400E1CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] itemFrom;

		[Token(Token = "0x400E1CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint[] itemIds;

		[Token(Token = "0x400E1CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public uint[] itemMsg;

		[Token(Token = "0x400E1D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public uint[] itemTargetUids;

		[Token(Token = "0x400E1D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MixedValue[] itemMixVal;

		[Token(Token = "0x6009919")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PvpListData()
		{
		}
	}

	[Token(Token = "0x2001812")]
	private class PvpFusionData
	{
		[Token(Token = "0x400E1D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] material;

		[Token(Token = "0x400E1D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] mrk;

		[Token(Token = "0x600991A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PvpFusionData()
		{
		}
	}

	[Token(Token = "0x2001813")]
	private enum PvpCommandType
	{
		[Token(Token = "0x400E1D5")]
		Input,
		[Token(Token = "0x400E1D6")]
		List,
		[Token(Token = "0x400E1D7")]
		Dialog,
		[Token(Token = "0x400E1D8")]
		Effect,
		[Token(Token = "0x400E1D9")]
		Field,
		[Token(Token = "0x400E1DA")]
		Data,
		[Token(Token = "0x400E1DB")]
		Fusion,
		[Token(Token = "0x400E1DC")]
		Time,
		[Token(Token = "0x400E1DD")]
		ListFrom,
		[Token(Token = "0x400E1DE")]
		FlipInfo,
		[Token(Token = "0x400E1DF")]
		FinishAttack,
		[Token(Token = "0x400E1E0")]
		MrkList,
		[Token(Token = "0x400E1E1")]
		FusionNeed,
		[Token(Token = "0x400E1E2")]
		TunerLevel,
		[Token(Token = "0x400E1E3")]
		CutinActivate
	}

	[Token(Token = "0x2001814")]
	private enum PvpFieldType
	{
		[Token(Token = "0x400E1E5")]
		Prop = 1,
		[Token(Token = "0x400E1E6")]
		Pos,
		[Token(Token = "0x400E1E7")]
		Uid,
		[Token(Token = "0x400E1E8")]
		Vals,
		[Token(Token = "0x400E1E9")]
		Icon,
		[Token(Token = "0x400E1EA")]
		Skill,
		[Token(Token = "0x400E1EB")]
		Rare,
		[Token(Token = "0x400E1EC")]
		Attack,
		[Token(Token = "0x400E1ED")]
		Show,
		[Token(Token = "0x400E1EE")]
		Step,
		[Token(Token = "0x400E1EF")]
		SummoningUid,
		[Token(Token = "0x400E1F0")]
		PosMask,
		[Token(Token = "0x400E1F1")]
		AffectProp,
		[Token(Token = "0x400E1F2")]
		End
	}

	[Token(Token = "0x2001815")]
	private class PvpCommand
	{
		[Token(Token = "0x400E1F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PvpCommandType type;

		[Token(Token = "0x400E1F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] param;

		[Token(Token = "0x400E1F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object data;

		[Token(Token = "0x600991B")]
		[Address(RVA = "0xE3A130", Offset = "0xE39330", VA = "0x180E3A130")]
		public PvpCommand(PvpCommandType t, int[] p, object o)
		{
		}
	}

	[Token(Token = "0x2001816")]
	private class MixedValue
	{
		[Token(Token = "0x400E1F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int mixNum;

		[Token(Token = "0x400E1F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint[] mixValue;

		[Token(Token = "0x600991C")]
		[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
		public MixedValue(int num, uint[] values)
		{
		}
	}

	[Token(Token = "0x2001817")]
	private class PvpWork
	{
		[Token(Token = "0x400E1F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Queue<PvpCommand> commandQueue;

		[Token(Token = "0x400E1F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PvpEngineData currentEngineData;

		[Token(Token = "0x400E1FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvpDialogData currentDialogData;

		[Token(Token = "0x400E1FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PvpListData currentListData;

		[Token(Token = "0x400E1FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PvpFusionData currentFusionData;

		[Token(Token = "0x400E1FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<ushort, ushort> rareTbl;

		[Token(Token = "0x400E1FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int mixNum;

		[Token(Token = "0x400E1FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public uint[] mixValue;

		[Token(Token = "0x400E200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ushort[] currentListMrk;

		[Token(Token = "0x400E201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Queue<MixedValue> mixvalQueue;

		[Token(Token = "0x400E204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int[] CurrentParam;

		[Token(Token = "0x400E208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private uint serializer;

		[Token(Token = "0x170016EF")]
		public ViewType RunningEffect
		{
			[Token(Token = "0x600991D")]
			[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880")]
			[CompilerGenerated]
			get
			{
				return default(ViewType);
			}
			[Token(Token = "0x600991E")]
			[Address(RVA = "0x4048C0", Offset = "0x403AC0", VA = "0x1804048C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F0")]
		public ViewType CurrentRunEffect
		{
			[Token(Token = "0x600991F")]
			[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510")]
			[CompilerGenerated]
			get
			{
				return default(ViewType);
			}
			[Token(Token = "0x6009920")]
			[Address(RVA = "0x91EA10", Offset = "0x91DC10", VA = "0x18091EA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F1")]
		public uint TimeLeft
		{
			[Token(Token = "0x6009921")]
			[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6009922")]
			[Address(RVA = "0x99DB50", Offset = "0x99CD50", VA = "0x18099DB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F2")]
		public uint TimeTotal
		{
			[Token(Token = "0x6009923")]
			[Address(RVA = "0x3EC970", Offset = "0x3EBB70", VA = "0x1803EC970")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6009924")]
			[Address(RVA = "0x3EC980", Offset = "0x3EBB80", VA = "0x1803EC980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F3")]
		public bool inputGuard
		{
			[Token(Token = "0x6009925")]
			[Address(RVA = "0x9B6370", Offset = "0x9B5570", VA = "0x1809B6370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6009926")]
			[Address(RVA = "0xE3AEF0", Offset = "0xE3A0F0", VA = "0x180E3AEF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6009927")]
		[Address(RVA = "0xE3AD50", Offset = "0xE39F50", VA = "0x180E3AD50")]
		public PvpWork()
		{
		}

		[Token(Token = "0x6009928")]
		[Address(RVA = "0xE3ACB0", Offset = "0xE39EB0", VA = "0x180E3ACB0")]
		public void Release()
		{
		}

		[Token(Token = "0x6009929")]
		[Address(RVA = "0xE3A9C0", Offset = "0xE39BC0", VA = "0x180E3A9C0")]
		public void AddCommand(PvpCommand cmd)
		{
		}

		[Token(Token = "0x600992A")]
		[Address(RVA = "0xE3AA20", Offset = "0xE39C20", VA = "0x180E3AA20")]
		public PvpCommand GetCommand()
		{
			return null;
		}

		[Token(Token = "0x600992B")]
		[Address(RVA = "0xE3AA90", Offset = "0xE39C90", VA = "0x180E3AA90")]
		public bool IsQueued()
		{
			return default(bool);
		}

		[Token(Token = "0x600992C")]
		[Address(RVA = "0xE3AC40", Offset = "0xE39E40", VA = "0x180E3AC40")]
		public PvpCommand Next()
		{
			return null;
		}

		[Token(Token = "0x600992D")]
		[Address(RVA = "0xE3AAF0", Offset = "0xE39CF0", VA = "0x180E3AAF0")]
		public ViewType NextEffect()
		{
			return default(ViewType);
		}

		[Token(Token = "0x600992E")]
		[Address(RVA = "0xE3AAE0", Offset = "0xE39CE0", VA = "0x180E3AAE0")]
		public bool IsRunningEffect()
		{
			return default(bool);
		}

		[Token(Token = "0x600992F")]
		[Address(RVA = "0xE3AD40", Offset = "0xE39F40", VA = "0x180E3AD40")]
		public uint Serial()
		{
			return default(uint);
		}
	}

	[Token(Token = "0x2001818")]
	public enum ToEngineActType
	{
		[Token(Token = "0x400E20A")]
		DoCommand,
		[Token(Token = "0x400E20B")]
		CancelCommand,
		[Token(Token = "0x400E20C")]
		MovePhase,
		[Token(Token = "0x400E20D")]
		DebugCommand,
		[Token(Token = "0x400E20E")]
		DoDebug,
		[Token(Token = "0x400E20F")]
		CheatCard,
		[Token(Token = "0x400E210")]
		DialogResult,
		[Token(Token = "0x400E211")]
		ListSendBlindIndex,
		[Token(Token = "0x400E212")]
		ListSendIndex,
		[Token(Token = "0x400E213")]
		ListSendSelectMulti,
		[Token(Token = "0x400E214")]
		ForceSurrender
	}

	[Serializable]
	[Token(Token = "0x2001819")]
	public class ThreadPosParam
	{
		[Token(Token = "0x400E215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nShowParam;

		[Token(Token = "0x400E216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint nCardParam;

		[Token(Token = "0x400E217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int nCardDirect;

		[Token(Token = "0x6009930")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ThreadPosParam()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200181A")]
	public class ThreadPosBase
	{
		[Token(Token = "0x400E218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint nComBit;

		[Token(Token = "0x400E219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int wMrk;

		[Token(Token = "0x400E21A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int wTurnCounter;

		[Token(Token = "0x400E21B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int bTopIdx;

		[Token(Token = "0x400E21C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int bEffectFlags;

		[Token(Token = "0x400E21D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int bMonstOrgLevel;

		[Token(Token = "0x400E21E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int bMonstOrgType;

		[Token(Token = "0x400E21F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int bZoneAvailable;

		[Token(Token = "0x400E220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int bZoneAvailable2;

		[Token(Token = "0x400E221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int bNormalMonster;

		[Token(Token = "0x400E222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int bPendScale;

		[Token(Token = "0x400E223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int bPendOrgScale;

		[Token(Token = "0x400E224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int bMonstRank;

		[Token(Token = "0x400E225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int bMonstOrgRank;

		[Token(Token = "0x400E226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bTrapMonster;

		[Token(Token = "0x400E227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int bTunerMonster;

		[Token(Token = "0x400E228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int bOverlayNum;

		[Token(Token = "0x400E229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int wCardNum;

		[Token(Token = "0x400E22A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int[] bCounter;

		[Token(Token = "0x400E22B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int[] otherEffect;

		[Token(Token = "0x400E22C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool Fightable;

		[Token(Token = "0x400E22D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int Equip;

		[Token(Token = "0x400E22E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int Continuous;

		[Token(Token = "0x400E22F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool IsMagic;

		[Token(Token = "0x400E230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool IsTrap;

		[Token(Token = "0x400E231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public bool IsMaximumMode;

		[Token(Token = "0x400E232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public uint nComBitTextId;

		[Token(Token = "0x6009931")]
		[Address(RVA = "0xE3D560", Offset = "0xE3C760", VA = "0x180E3D560")]
		public ThreadPosBase()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200181B")]
	public class ThreadIconBase
	{
		[Token(Token = "0x400E233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int player;

		[Token(Token = "0x400E234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int pos;

		[Token(Token = "0x400E235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int to_player;

		[Token(Token = "0x400E236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int to_pos;

		[Token(Token = "0x400E237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int icon;

		[Token(Token = "0x6009932")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ThreadIconBase()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200181C")]
	public class ThreadPlayerInfo
	{
		[Token(Token = "0x400E238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int LP;

		[Token(Token = "0x400E239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int DoPutMonst;

		[Token(Token = "0x400E23A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool DoSummon;

		[Token(Token = "0x400E23B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool DoSpSummon;

		[Token(Token = "0x6009933")]
		[Address(RVA = "0xE3D540", Offset = "0xE3C740", VA = "0x180E3D540")]
		public ThreadPlayerInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200181D")]
	public class ThreadDuelInfo
	{
		[Token(Token = "0x400E23C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint nTurnNum;

		[Token(Token = "0x400E23D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint nCurrentPhase;

		[Token(Token = "0x400E23E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int bWhichTurnNow;

		[Token(Token = "0x400E23F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint nMovablePhase;

		[Token(Token = "0x400E240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThreadPosBase[,] Pos;

		[Token(Token = "0x400E241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint nCurrentStep;

		[Token(Token = "0x400E242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint nCurrentDmgStep;

		[Token(Token = "0x400E243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ThreadPlayerInfo[] playerInfo;

		[Token(Token = "0x6009934")]
		[Address(RVA = "0xE3CD80", Offset = "0xE3BF80", VA = "0x180E3CD80")]
		public ThreadDuelInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200181E")]
	public class CardPropSerial
	{
		[Token(Token = "0x400E244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int CardID;

		[Token(Token = "0x400E245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int UniqueID;

		[Token(Token = "0x400E246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Owner;

		[Token(Token = "0x400E247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool Correct;

		[Token(Token = "0x400E248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool ByBattle;

		[Token(Token = "0x400E249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool ByAnother;

		[Token(Token = "0x400E24A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public bool ByBreak;

		[Token(Token = "0x400E24B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool TurnPast;

		[Token(Token = "0x400E24C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Disabled;

		[Token(Token = "0x400E24D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool TimingPast;

		[Token(Token = "0x6009935")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CardPropSerial()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200181F")]
	public class BasicValSerial
	{
		[Token(Token = "0x400E24E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public short CardID;

		[Token(Token = "0x400E24F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public short EffectID;

		[Token(Token = "0x400E250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Atk;

		[Token(Token = "0x400E251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Def;

		[Token(Token = "0x400E252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int OrgAtk;

		[Token(Token = "0x400E253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int OrgDef;

		[Token(Token = "0x400E254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public short Type;

		[Token(Token = "0x400E255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public short Attr;

		[Token(Token = "0x400E256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public short Element;

		[Token(Token = "0x400E257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public short Level;

		[Token(Token = "0x400E258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public byte Rank;

		[Token(Token = "0x400E259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public byte VoidMagic;

		[Token(Token = "0x400E25A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public byte VoidTrap;

		[Token(Token = "0x400E25B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		public byte VoidMonst;

		[Token(Token = "0x6009936")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BasicValSerial()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001820")]
	public class AffectPropSerial
	{
		[Token(Token = "0x400E25C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Player;

		[Token(Token = "0x400E25D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int CardID;

		[Token(Token = "0x400E25E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Type;

		[Token(Token = "0x400E25F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Param;

		[Token(Token = "0x6009937")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AffectPropSerial()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001821")]
	public class ToMainRunEffect
	{
		[Token(Token = "0x400E260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] param;

		[Token(Token = "0x400E261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ThreadEngineData engineData;

		[Token(Token = "0x400E262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThreadDialogData dialogData;

		[Token(Token = "0x400E263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThreadListData listData;

		[Token(Token = "0x400E264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ThreadFusionData fusionData;

		[Token(Token = "0x400E265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ThreadMixTextData mixTextData;

		[Token(Token = "0x400E266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Dictionary<string, int> attackFlags;

		[Token(Token = "0x400E267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ThreadIconBase[] IconBases;

		[Token(Token = "0x400E268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Dictionary<int, uint> flipInfo;

		[Token(Token = "0x400E269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ThreadPosParam[][] posParam;

		[Token(Token = "0x6009938")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ToMainRunEffect()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001822")]
	public class ToMainWork
	{
		[Token(Token = "0x400E26A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool finishedSysAct;

		[Token(Token = "0x400E26B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ToMainRunEffect runeffectData;

		[Token(Token = "0x6009939")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ToMainWork()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001823")]
	public class ToEngineWork
	{
		[Token(Token = "0x400E26C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ToEngineActType actType;

		[Token(Token = "0x400E26D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int player;

		[Token(Token = "0x400E26E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int position;

		[Token(Token = "0x400E26F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int index;

		[Token(Token = "0x400E270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int commandId;

		[Token(Token = "0x400E271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int phase;

		[Token(Token = "0x400E272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int cardId;

		[Token(Token = "0x400E273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int face;

		[Token(Token = "0x400E274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int turn;

		[Token(Token = "0x400E275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint dlgResult;

		[Token(Token = "0x400E276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int listIndex;

		[Token(Token = "0x400E277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int listNum;

		[Token(Token = "0x400E278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool decide;

		[Token(Token = "0x400E279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[] listSelect;

		[Token(Token = "0x600993A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ToEngineWork()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001824")]
	public class ThreadUIDBase
	{
		[Token(Token = "0x400E27A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint nCom;

		[Token(Token = "0x400E27B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint nPos;

		[Token(Token = "0x400E27C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int wUid;

		[Token(Token = "0x400E27D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardPropSerial stProp;

		[Token(Token = "0x400E27E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isFace;

		[Token(Token = "0x400E27F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isTurn;

		[Token(Token = "0x400E280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BasicValSerial stBasicVal;

		[Token(Token = "0x400E281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint nComTextId;

		[Token(Token = "0x600993B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ThreadUIDBase()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001825")]
	public class ThreadEngineData : IDisposable
	{
		[Token(Token = "0x400E282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ThreadDuelInfo duelInfo;

		[Token(Token = "0x400E283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<uint, int> posTbl;

		[Token(Token = "0x400E284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<int, int> uidTbl;

		[Token(Token = "0x400E285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThreadUIDBase[] uidBases;

		[Token(Token = "0x400E286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<int, int>[] cardAttribute;

		[Token(Token = "0x400E287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<string, uint> posMask;

		[Token(Token = "0x400E288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool attackFinish;

		[Token(Token = "0x400E289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int syncNeed;

		[Token(Token = "0x400E28A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[] tuningLevel;

		[Token(Token = "0x400E28B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int effectIdAtChain;

		[Token(Token = "0x400E28C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int summoningUid;

		[Token(Token = "0x400E28D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int recommendSide;

		[Token(Token = "0x400E28E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool flagDeckReverse;

		[Token(Token = "0x400E28F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Dictionary<uint, uint> summonTextIDTable;

		[Token(Token = "0x400E290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AffectPropSerial[] attachedEffectList;

		[Token(Token = "0x600993C")]
		[Address(RVA = "0xE3D010", Offset = "0xE3C210", VA = "0x180E3D010")]
		public ThreadEngineData()
		{
		}

		[Token(Token = "0x600993D")]
		[Address(RVA = "0xE3CF60", Offset = "0xE3C160", VA = "0x180E3CF60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001826")]
	public class ThreadDialogData : IDisposable
	{
		[Token(Token = "0x400E291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DialogType dlgType;

		[Token(Token = "0x400E292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int textId;

		[Token(Token = "0x400E293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int selNum;

		[Token(Token = "0x400E294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] selStr;

		[Token(Token = "0x400E295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool[] selEnable;

		[Token(Token = "0x400E296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool[] selDefault;

		[Token(Token = "0x400E297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool yesno;

		[Token(Token = "0x400E298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint posMaskSummon;

		[Token(Token = "0x600993E")]
		[Address(RVA = "0xE3CC70", Offset = "0xE3BE70", VA = "0x180E3CC70", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600993F")]
		[Address(RVA = "0xE3CCD0", Offset = "0xE3BED0", VA = "0x180E3CCD0")]
		public ThreadDialogData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001827")]
	public class ThreadListData : IDisposable
	{
		[Token(Token = "0x400E299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ListType listType;

		[Token(Token = "0x400E29A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int selMax;

		[Token(Token = "0x400E29B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int selMin;

		[Token(Token = "0x400E29C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int itemMax;

		[Token(Token = "0x400E29D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] itemUids;

		[Token(Token = "0x400E29E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] itemAttributes;

		[Token(Token = "0x400E29F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] itemFrom;

		[Token(Token = "0x400E2A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] itemIds;

		[Token(Token = "0x400E2A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] itemTargetUids;

		[Token(Token = "0x400E2A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[] itemMsg;

		[Token(Token = "0x400E2A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ThreadMixTextData[] itemMsgVal;

		[Token(Token = "0x6009940")]
		[Address(RVA = "0xE3D2C0", Offset = "0xE3C4C0", VA = "0x180E3D2C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009941")]
		[Address(RVA = "0xE3D350", Offset = "0xE3C550", VA = "0x180E3D350")]
		public ThreadListData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001828")]
	public class ThreadFusionData : IDisposable
	{
		[Token(Token = "0x400E2A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] material;

		[Token(Token = "0x400E2A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] mrk;

		[Token(Token = "0x6009942")]
		[Address(RVA = "0xE3D200", Offset = "0xE3C400", VA = "0x180E3D200", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009943")]
		[Address(RVA = "0xE3D240", Offset = "0xE3C440", VA = "0x180E3D240")]
		public ThreadFusionData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001829")]
	public class ThreadMixTextData : IDisposable
	{
		[Token(Token = "0x400E2A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int mixNum;

		[Token(Token = "0x400E2A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] mixType;

		[Token(Token = "0x400E2A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] mixData;

		[Token(Token = "0x6009944")]
		[Address(RVA = "0xE3D480", Offset = "0xE3C680", VA = "0x180E3D480", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009945")]
		[Address(RVA = "0xE3D4C0", Offset = "0xE3C6C0", VA = "0x180E3D4C0")]
		public ThreadMixTextData()
		{
		}
	}

	[Token(Token = "0x200182A")]
	private class ThreadWork
	{
		[Token(Token = "0x400E2A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ThreadEngineData currentEngineData;

		[Token(Token = "0x400E2AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ThreadDialogData currentDialogData;

		[Token(Token = "0x400E2AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThreadListData currentListData;

		[Token(Token = "0x400E2AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThreadFusionData currentFusionData;

		[Token(Token = "0x400E2AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ThreadMixTextData currentMixTextData;

		[Token(Token = "0x400E2AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> attackFlags;

		[Token(Token = "0x400E2AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ThreadIconBase[] IconBases;

		[Token(Token = "0x400E2B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<uint, object> affectsMgr;

		[Token(Token = "0x400E2B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AffectType[][] dummyAffects;

		[Token(Token = "0x400E2B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dictionary<int, uint> flipInfo;

		[Token(Token = "0x400E2B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ThreadPosParam[][] posParam;

		[Token(Token = "0x170016F4")]
		public ViewType RunningEffect
		{
			[Token(Token = "0x6009946")]
			[Address(RVA = "0x6A9360", Offset = "0x6A8560", VA = "0x1806A9360")]
			[CompilerGenerated]
			get
			{
				return default(ViewType);
			}
			[Token(Token = "0x6009947")]
			[Address(RVA = "0xB2E810", Offset = "0xB2DA10", VA = "0x180B2E810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F5")]
		public ViewType CurrentRunEffect
		{
			[Token(Token = "0x6009948")]
			[Address(RVA = "0x803CD0", Offset = "0x802ED0", VA = "0x180803CD0")]
			[CompilerGenerated]
			get
			{
				return default(ViewType);
			}
			[Token(Token = "0x6009949")]
			[Address(RVA = "0x91E9D0", Offset = "0x91DBD0", VA = "0x18091E9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F6")]
		public int thinkingPlayer
		{
			[Token(Token = "0x600994A")]
			[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600994B")]
			[Address(RVA = "0x99DB50", Offset = "0x99CD50", VA = "0x18099DB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F7")]
		public float startTime
		{
			[Token(Token = "0x600994C")]
			[Address(RVA = "0xE3D9A0", Offset = "0xE3CBA0", VA = "0x180E3D9A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600994D")]
			[Address(RVA = "0xE3D9C0", Offset = "0xE3CBC0", VA = "0x180E3D9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170016F8")]
		public float lastTime
		{
			[Token(Token = "0x600994E")]
			[Address(RVA = "0xE3D990", Offset = "0xE3CB90", VA = "0x180E3D990")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600994F")]
			[Address(RVA = "0xE3D9B0", Offset = "0xE3CBB0", VA = "0x180E3D9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6009950")]
		[Address(RVA = "0xE3D890", Offset = "0xE3CA90", VA = "0x180E3D890")]
		public ThreadWork()
		{
		}

		[Token(Token = "0x6009951")]
		[Address(RVA = "0xE3D640", Offset = "0xE3C840", VA = "0x180E3D640")]
		public void Release()
		{
		}

		[Token(Token = "0x6009952")]
		[Address(RVA = "0xE3D630", Offset = "0xE3C830", VA = "0x180E3D630")]
		public bool IsRunningEffect()
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x200182B")]
	public struct ThreadIconBuff
	{
		[Token(Token = "0x400E2B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int player;

		[Token(Token = "0x400E2BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int pos;

		[Token(Token = "0x400E2BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int to_player;

		[Token(Token = "0x400E2BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int to_pos;

		[Token(Token = "0x400E2BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int icon;
	}

	[Token(Token = "0x400DEB9")]
	public const int CardIdStart = 3000;

	[Token(Token = "0x400DEBA")]
	public const int MaxPlayer = 4;

	[Token(Token = "0x400DEBB")]
	public const int MaxDuelList = 300;

	[Token(Token = "0x400DEBC")]
	public const int PosMonster = 0;

	[Token(Token = "0x400DEBD")]
	public const int PosMonsterLL = 0;

	[Token(Token = "0x400DEBE")]
	public const int PosMonsterL = 1;

	[Token(Token = "0x400DEBF")]
	public const int PosMonsterC = 2;

	[Token(Token = "0x400DEC0")]
	public const int PosMonsterR = 3;

	[Token(Token = "0x400DEC1")]
	public const int PosMonsterRR = 4;

	[Token(Token = "0x400DEC2")]
	public const int PosMonsterMEnd = 4;

	[Token(Token = "0x400DEC3")]
	public const int PosExLMonster = 5;

	[Token(Token = "0x400DEC4")]
	public const int PosExRMonster = 6;

	[Token(Token = "0x400DEC5")]
	public const int PosMonsterEnd = 6;

	[Token(Token = "0x400DEC6")]
	public const int PosMagic = 7;

	[Token(Token = "0x400DEC7")]
	public const int PosMagicLL = 7;

	[Token(Token = "0x400DEC8")]
	public const int PosMagicL = 8;

	[Token(Token = "0x400DEC9")]
	public const int PosMagicC = 9;

	[Token(Token = "0x400DECA")]
	public const int PosMagicR = 10;

	[Token(Token = "0x400DECB")]
	public const int PosMagicRR = 11;

	[Token(Token = "0x400DECC")]
	public const int PosMagicEnd = 11;

	[Token(Token = "0x400DECD")]
	public const int PosPendulumLeft = 7;

	[Token(Token = "0x400DECE")]
	public const int PosPendulumRight = 11;

	[Token(Token = "0x400DECF")]
	public const int PosField = 12;

	[Token(Token = "0x400DED0")]
	public const int PosHand = 13;

	[Token(Token = "0x400DED1")]
	public const int PosExtra = 14;

	[Token(Token = "0x400DED2")]
	public const int PosDeck = 15;

	[Token(Token = "0x400DED3")]
	public const int PosGrave = 16;

	[Token(Token = "0x400DED4")]
	public const int PosExclude = 17;

	[Token(Token = "0x400DED5")]
	public const int PosSelect = 18;

	[Token(Token = "0x400DED6")]
	public const int PosNum = 18;

	[Token(Token = "0x400DED7")]
	public const int DialogTextMixed = 1;

	[Token(Token = "0x400DED8")]
	private const string LIBNAME = "duel";

	[Token(Token = "0x400DED9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private CachedParam cachedParam;

	[Token(Token = "0x400DEDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action onDuelFinish;

	[Token(Token = "0x400DEDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Engine s_instance;

	[Token(Token = "0x400DEDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RunEffect runEffectCallback;

	[Token(Token = "0x400DEDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IsBusyEffect isBusyEffectCallback;

	[Token(Token = "0x400DEDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private NowRecord nowRecordCallback;

	[Token(Token = "0x400DEDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RecordNext recordNextCallback;

	[Token(Token = "0x400DEE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RecordBegin recordBeginCallback;

	[Token(Token = "0x400DEE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IsRecordEnd isRecordEndCallback;

	[Token(Token = "0x400DEE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ThreadRunEffectDeleg threadRunEffectCallback;

	[Token(Token = "0x400DEE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ThreadIsBusyEffectDeleg threadIsBusyEffectCallback;

	[Token(Token = "0x400DEE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Action updateTimerCallback;

	[Token(Token = "0x400DEE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Action inputStartCallback;

	[Token(Token = "0x400DEE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Action noResponseCallback;

	[Token(Token = "0x400DEE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Action recoveryResponseCallback;

	[Token(Token = "0x400DEE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Action noResponseClosedCallback;

	[Token(Token = "0x400DEE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private IntPtr engineWork;

	[Token(Token = "0x400DEEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private IntPtr cardRareBufferPtr;

	[Token(Token = "0x400DEEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int cardRareBufferSize;

	[Token(Token = "0x400DEEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private IntPtr cardExistBuffer;

	[Token(Token = "0x400DEED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int cardExistBufferSize;

	[Token(Token = "0x400DEEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private IntPtr questionData;

	[Token(Token = "0x400DEEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Dictionary<PvP.Command, Queue<byte[]>> dicRemoteRecvQueue;

	[Token(Token = "0x400DEF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<PvP.Command, uint> dicRemoteRecvOrder;

	[Token(Token = "0x400DEF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private uint remoteRecvOrder;

	[Token(Token = "0x400DEF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float inputStartTime;

	[Token(Token = "0x400DEF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isInputNow;

	[Token(Token = "0x400DEF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	private bool isOnlineMode;

	[Token(Token = "0x400DEF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
	private bool inputTimerSetting;

	[Token(Token = "0x400DEF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Util.GameMode gameMode;

	[Token(Token = "0x400DEF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool isExitPvp;

	[Token(Token = "0x400DEF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int finishTypeOverrider;

	[Token(Token = "0x400DEF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int[] mat;

	[Token(Token = "0x400DEFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int[] sleeve;

	[Token(Token = "0x400DEFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int[] latency;

	[Token(Token = "0x400DEFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ReplayStream replayStream;

	[Token(Token = "0x400DEFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Dictionary<CounterType, int> dicCounterToId;

	[Token(Token = "0x400DEFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Dictionary<int, CounterType> dicIdToCounter;

	[Token(Token = "0x400DEFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int[] initialLP;

	[Token(Token = "0x400DF00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private PvpWork pvpWork;

	[Token(Token = "0x400DF01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool pvpFinished;

	[Token(Token = "0x400DF02")]
	public const int UNTIL_FIELD_ZONE_ONE = 13;

	[Token(Token = "0x400DF03")]
	public const int UNTIL_FIELD_ZONE_TWO = 26;

	[Token(Token = "0x400DF04")]
	public const int UNTIL_FIELD_ZONE_ALL = 676;

	[Token(Token = "0x400DF05")]
	public const int UNTIL_MONSTER_ZONE_ONE = 7;

	[Token(Token = "0x400DF06")]
	public const int MAX_SYSACT_LOOP = 30;

	[Token(Token = "0x400DF07")]
	public const float CPU_CHANGE_TIME_SIMPLE = 4f;

	[Token(Token = "0x400DF08")]
	public const float CPU_CHANGE_TIME_FOOL = 19f;

	[Token(Token = "0x400DF09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static float CpuChangeTimeSimple;

	[Token(Token = "0x400DF0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static float CpuChangeTimeFool;

	[Token(Token = "0x400DF0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static bool s_bSimple;

	[Token(Token = "0x400DF0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private static bool s_bFool;

	[Token(Token = "0x400DF0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static BlockingQueue<ToMainWork> ToMainQueue;

	[Token(Token = "0x400DF0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static BlockingQueue<ToEngineWork> ToEngineQueue;

	[Token(Token = "0x400DF0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static bool forceSurrender;

	[Token(Token = "0x400DF10")]
	private const int DUEL_ENGINE_MAX_STACK_SIZE = 1048576;

	[Token(Token = "0x400DF11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static Thread DuelEngineThread;

	[Token(Token = "0x400DF12")]
	private const int MIX_BUFF_SIZE_MAX = 8;

	[Token(Token = "0x400DF13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ThreadWork threadWork;

	[Token(Token = "0x400DF14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static bool isBusyCheck;

	[Token(Token = "0x400DF15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private static bool isThreadFinished;

	[Token(Token = "0x400DF16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private static bool isSurrender;

	[Token(Token = "0x400DF17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	private static bool isThreadRunEffectDuelEnd;

	[Token(Token = "0x400DF18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static ThreadIconBuff[] buffAffectIcon;

	[Token(Token = "0x400DF19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static ThreadPosParam[][] buffPosParam;

	[Token(Token = "0x170016CE")]
	private static bool IsNotOnline
	{
		[Token(Token = "0x60096E8")]
		[Address(RVA = "0xE32A00", Offset = "0xE31C00", VA = "0x180E32A00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016CF")]
	public static int CounterTypeMax
	{
		[Token(Token = "0x600975C")]
		[Address(RVA = "0xE32810", Offset = "0xE31A10", VA = "0x180E32810")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170016D0")]
	public static ReplayStream ReplayStream
	{
		[Token(Token = "0x6009763")]
		[Address(RVA = "0xE32F70", Offset = "0xE32170", VA = "0x180E32F70")]
		set
		{
		}
	}

	[Token(Token = "0x170016D1")]
	public static bool InputTimerSetting
	{
		[Token(Token = "0x6009764")]
		[Address(RVA = "0xE32970", Offset = "0xE31B70", VA = "0x180E32970")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009765")]
		[Address(RVA = "0xE32EE0", Offset = "0xE320E0", VA = "0x180E32EE0")]
		set
		{
		}
	}

	[Token(Token = "0x170016D2")]
	public static bool InputNow
	{
		[Token(Token = "0x6009766")]
		[Address(RVA = "0xE328E0", Offset = "0xE31AE0", VA = "0x180E328E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016D3")]
	public static Util.GameMode CachedGameMode
	{
		[Token(Token = "0x6009767")]
		[Address(RVA = "0xE32780", Offset = "0xE31980", VA = "0x180E32780")]
		get
		{
			return default(Util.GameMode);
		}
	}

	[Token(Token = "0x170016D4")]
	public static bool IsOnline
	{
		[Token(Token = "0x6009768")]
		[Address(RVA = "0xE32AB0", Offset = "0xE31CB0", VA = "0x180E32AB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600965D")]
	[Address(RVA = "0xDF1F00", Offset = "0xDF1100", VA = "0x180DF1F00")]
	public static bool CheckPosBit(uint mask, int player, int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600965E")]
	[Address(RVA = "0xE04220", Offset = "0xE03420", VA = "0x180E04220")]
	public static bool IsEnableBattleDamagePlayer(int prop, int player, BtlPropFlag flag)
	{
		return default(bool);
	}

	[Token(Token = "0x600965F")]
	[Address(RVA = "0xE01A10", Offset = "0xE00C10", VA = "0x180E01A10")]
	public static ShowParam GetShowParamOfAffectProp(AffectProp affectProp)
	{
		return default(ShowParam);
	}

	[Token(Token = "0x6009660")]
	[Address(RVA = "0xE048E0", Offset = "0xE03AE0", VA = "0x180E048E0")]
	public static bool IsThisAffectPropShowEnd(AffectProp affectProp)
	{
		return default(bool);
	}

	[Token(Token = "0x6009661")]
	[Address(RVA = "0xE048B0", Offset = "0xE03AB0", VA = "0x180E048B0")]
	public static bool IsThisAffectPropFlagSet(AffectProp affectProp, AffectPropTypeFlag flag)
	{
		return default(bool);
	}

	[PreserveSig]
	[Token(Token = "0x6009662")]
	[Address(RVA = "0xDF5110", Offset = "0xDF4310", VA = "0x180DF5110")]
	private static extern int DLL_DuelDlgGetMixNum();

	[PreserveSig]
	[Token(Token = "0x6009663")]
	[Address(RVA = "0xDF5180", Offset = "0xDF4380", VA = "0x180DF5180")]
	private static extern int DLL_DuelDlgGetMixType(int index);

	[PreserveSig]
	[Token(Token = "0x6009664")]
	[Address(RVA = "0xDF5090", Offset = "0xDF4290", VA = "0x180DF5090")]
	private static extern int DLL_DuelDlgGetMixData(int index);

	[PreserveSig]
	[Token(Token = "0x6009665")]
	[Address(RVA = "0xDF5460", Offset = "0xDF4660", VA = "0x180DF5460")]
	private static extern void DLL_DuelDlgSetResult(uint result);

	[PreserveSig]
	[Token(Token = "0x6009666")]
	[Address(RVA = "0xDF5020", Offset = "0xDF4220", VA = "0x180DF5020")]
	private static extern int DLL_DuelDlgCanYesNoSkip();

	[PreserveSig]
	[Token(Token = "0x6009667")]
	[Address(RVA = "0xDF5200", Offset = "0xDF4400", VA = "0x180DF5200")]
	private static extern int DLL_DuelDlgGetPosMaskOfThisSummon();

	[PreserveSig]
	[Token(Token = "0x6009668")]
	[Address(RVA = "0xDF5370", Offset = "0xDF4570", VA = "0x180DF5370")]
	private static extern int DLL_DuelDlgGetSelectItemNum();

	[PreserveSig]
	[Token(Token = "0x6009669")]
	[Address(RVA = "0xDF53E0", Offset = "0xDF45E0", VA = "0x180DF53E0")]
	private static extern int DLL_DuelDlgGetSelectItemStr(int index);

	[PreserveSig]
	[Token(Token = "0x600966A")]
	[Address(RVA = "0xDF52F0", Offset = "0xDF44F0", VA = "0x180DF52F0")]
	private static extern int DLL_DuelDlgGetSelectItemEnable(int index);

	[PreserveSig]
	[Token(Token = "0x600966B")]
	[Address(RVA = "0xDF5270", Offset = "0xDF4470", VA = "0x180DF5270")]
	private static extern int DLL_DuelDlgGetSelectItemDefault(int index);

	[PreserveSig]
	[Token(Token = "0x600966C")]
	[Address(RVA = "0xDF4900", Offset = "0xDF3B00", VA = "0x180DF4900")]
	private static extern int DLL_DlgProcGetSummoningMonsterUniqueID();

	[Token(Token = "0x600966D")]
	[Address(RVA = "0xDF93C0", Offset = "0xDF85C0", VA = "0x180DF93C0")]
	public static int DialogGetMixNum()
	{
		return default(int);
	}

	[Token(Token = "0x600966E")]
	[Address(RVA = "0xDF9650", Offset = "0xDF8850", VA = "0x180DF9650")]
	public static DialogMixTextType DialogGetMixType(int index)
	{
		return default(DialogMixTextType);
	}

	[Token(Token = "0x600966F")]
	[Address(RVA = "0xDF9210", Offset = "0xDF8410", VA = "0x180DF9210")]
	public static int DialogGetMixData(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009670")]
	[Address(RVA = "0xDF8CA0", Offset = "0xDF7EA0", VA = "0x180DF8CA0")]
	public static void DequeueDialogMixData()
	{
	}

	[Token(Token = "0x6009671")]
	[Address(RVA = "0xDFA530", Offset = "0xDF9730", VA = "0x180DFA530")]
	public static void DialogSetResult(uint result)
	{
	}

	[Token(Token = "0x6009672")]
	[Address(RVA = "0xDF8FA0", Offset = "0xDF81A0", VA = "0x180DF8FA0")]
	public static bool DialogCanYesNoSkip()
	{
		return default(bool);
	}

	[Token(Token = "0x6009673")]
	[Address(RVA = "0xDF9800", Offset = "0xDF8A00", VA = "0x180DF9800")]
	public static uint DialogGetPosMaskOfThisSummon()
	{
		return default(uint);
	}

	[Token(Token = "0x6009674")]
	[Address(RVA = "0xDF9EF0", Offset = "0xDF90F0", VA = "0x180DF9EF0")]
	public static int DialogGetSelectItemNum()
	{
		return default(int);
	}

	[Token(Token = "0x6009675")]
	[Address(RVA = "0xDFA110", Offset = "0xDF9310", VA = "0x180DFA110")]
	public static int DialogGetSelectItemStr(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009676")]
	[Address(RVA = "0xDF9CB0", Offset = "0xDF8EB0", VA = "0x180DF9CB0")]
	public static bool DialogGetSelectItemEnable(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6009677")]
	[Address(RVA = "0xDF9A70", Offset = "0xDF8C70", VA = "0x180DF9A70")]
	public static bool DialogGetSelectItemDefault(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6009678")]
	[Address(RVA = "0xDFA350", Offset = "0xDF9550", VA = "0x180DFA350")]
	public static int DialogGetSummoningMonsterUniqueID()
	{
		return default(int);
	}

	[PreserveSig]
	[Token(Token = "0x6009679")]
	[Address(RVA = "0xDF8770", Offset = "0xDF7970", VA = "0x180DF8770")]
	private static extern int DLL_GetRevision();

	[PreserveSig]
	[Token(Token = "0x600967A")]
	[Address(RVA = "0xDF8680", Offset = "0xDF7880", VA = "0x180DF8680")]
	private static extern int DLL_GetBinHash(int iIndex);

	[PreserveSig]
	[Token(Token = "0x600967B")]
	[Address(RVA = "0xDF8C20", Offset = "0xDF7E20", VA = "0x180DF8C20")]
	private static extern int DLL_SetWorkMemory(IntPtr pWork);

	[PreserveSig]
	[Token(Token = "0x600967C")]
	[Address(RVA = "0xDF8320", Offset = "0xDF7520", VA = "0x180DF8320")]
	private static extern int DLL_DuelSysInitRush();

	[PreserveSig]
	[Token(Token = "0x600967D")]
	[Address(RVA = "0xDF82A0", Offset = "0xDF74A0", VA = "0x180DF82A0")]
	private static extern int DLL_DuelSysInitQuestion(IntPtr pScript);

	[PreserveSig]
	[Token(Token = "0x600967E")]
	[Address(RVA = "0xDF81D0", Offset = "0xDF73D0", VA = "0x180DF81D0")]
	private static extern int DLL_DuelSysInitCustom(int fDuelType, bool tag, int life0, int life1, int hand0, int hand1, bool shuf);

	[PreserveSig]
	[Token(Token = "0x600967F")]
	[Address(RVA = "0xDF80F0", Offset = "0xDF72F0", VA = "0x180DF80F0")]
	private static extern int DLL_DuelSysAct();

	[PreserveSig]
	[Token(Token = "0x6009680")]
	[Address(RVA = "0xDF8160", Offset = "0xDF7360", VA = "0x180DF8160")]
	private static extern void DLL_DuelSysClearWork();

	[PreserveSig]
	[Token(Token = "0x6009681")]
	[Address(RVA = "0xDF8390", Offset = "0xDF7590", VA = "0x180DF8390")]
	private static extern void DLL_DuelSysSetDeck2(int player, int[] mainDeck, int mainNum, int[] extraDeck, int extraNum, int[] sideDeck, int sideNum);

	[PreserveSig]
	[Token(Token = "0x6009682")]
	[Address(RVA = "0xDF8070", Offset = "0xDF7270", VA = "0x180DF8070")]
	private static extern void DLL_DuelSetRandomSeed(uint seed);

	[PreserveSig]
	[Token(Token = "0x6009683")]
	[Address(RVA = "0xDF7F60", Offset = "0xDF7160", VA = "0x180DF7F60")]
	private static extern void DLL_DuelSetMyPlayerNum(int player);

	[PreserveSig]
	[Token(Token = "0x6009684")]
	[Address(RVA = "0xDF7FE0", Offset = "0xDF71E0", VA = "0x180DF7FE0")]
	private static extern void DLL_DuelSetPlayerType(int player, int type);

	[PreserveSig]
	[Token(Token = "0x6009685")]
	[Address(RVA = "0xDF6A50", Offset = "0xDF5C50", VA = "0x180DF6A50")]
	private static extern int DLL_DuelIsHuman(int player);

	[PreserveSig]
	[Token(Token = "0x6009686")]
	[Address(RVA = "0xDF7B50", Offset = "0xDF6D50", VA = "0x180DF7B50")]
	private static extern int DLL_DuelMyself();

	[PreserveSig]
	[Token(Token = "0x6009687")]
	[Address(RVA = "0xDF7CE0", Offset = "0xDF6EE0", VA = "0x180DF7CE0")]
	private static extern int DLL_DuelRival();

	[PreserveSig]
	[Token(Token = "0x6009688")]
	[Address(RVA = "0xDF6AD0", Offset = "0xDF5CD0", VA = "0x180DF6AD0")]
	private static extern int DLL_DuelIsMyself(int player);

	[PreserveSig]
	[Token(Token = "0x6009689")]
	[Address(RVA = "0xDF6BC0", Offset = "0xDF5DC0", VA = "0x180DF6BC0")]
	private static extern int DLL_DuelIsRival(int player);

	[PreserveSig]
	[Token(Token = "0x600968A")]
	[Address(RVA = "0xDF7DD0", Offset = "0xDF6FD0", VA = "0x180DF7DD0")]
	private static extern void DLL_DuelSetCpuParam(int player, uint param);

	[PreserveSig]
	[Token(Token = "0x600968B")]
	[Address(RVA = "0xDF7EE0", Offset = "0xDF70E0", VA = "0x180DF7EE0")]
	private static extern void DLL_DuelSetFirstPlayer(int player);

	[PreserveSig]
	[Token(Token = "0x600968C")]
	[Address(RVA = "0xDF5DA0", Offset = "0xDF4FA0", VA = "0x180DF5DA0")]
	private static extern int DLL_DuelGetDuelResult();

	[PreserveSig]
	[Token(Token = "0x600968D")]
	[Address(RVA = "0xDF5CC0", Offset = "0xDF4EC0", VA = "0x180DF5CC0")]
	private static extern int DLL_DuelGetDuelFinish();

	[PreserveSig]
	[Token(Token = "0x600968E")]
	[Address(RVA = "0xDF5C50", Offset = "0xDF4E50", VA = "0x180DF5C50")]
	private static extern int DLL_DuelGetDuelFinishCardID();

	[PreserveSig]
	[Token(Token = "0x600968F")]
	[Address(RVA = "0xDF7E60", Offset = "0xDF7060", VA = "0x180DF7E60")]
	private static extern void DLL_DuelSetDuelLimitedType(uint limitedType);

	[PreserveSig]
	[Token(Token = "0x6009690")]
	[Address(RVA = "0xDF8A20", Offset = "0xDF7C20", VA = "0x180DF8A20")]
	private static extern void DLL_SetEffectDelegate(ThreadRunEffectDeleg runEffct, ThreadIsBusyEffectDeleg isBusyEffect);

	[PreserveSig]
	[Token(Token = "0x6009691")]
	[Address(RVA = "0xDF7140", Offset = "0xDF6340", VA = "0x180DF7140")]
	private static extern int DLL_DuelIsThisQuickDuel();

	[PreserveSig]
	[Token(Token = "0x6009692")]
	[Address(RVA = "0xDF8870", Offset = "0xDF7A70", VA = "0x180DF8870")]
	private static extern void DLL_SetCardExistWork(IntPtr pWork, int size, int count);

	[PreserveSig]
	[Token(Token = "0x6009693")]
	[Address(RVA = "0xDF8700", Offset = "0xDF7900", VA = "0x180DF8700")]
	private static extern int DLL_GetCardExistNum();

	[PreserveSig]
	[Token(Token = "0x6009694")]
	[Address(RVA = "0xDF62A0", Offset = "0xDF54A0", VA = "0x180DF62A0")]
	private static extern int DLL_DuelGetLP(int player);

	[PreserveSig]
	[Token(Token = "0x6009695")]
	[Address(RVA = "0xDF8480", Offset = "0xDF7680", VA = "0x180DF8480")]
	private static extern int DLL_DuelWhichTurnNow();

	[PreserveSig]
	[Token(Token = "0x6009696")]
	[Address(RVA = "0xDF5B70", Offset = "0xDF4D70", VA = "0x180DF5B70")]
	private static extern uint DLL_DuelGetCurrentPhase();

	[PreserveSig]
	[Token(Token = "0x6009697")]
	[Address(RVA = "0xDF5BE0", Offset = "0xDF4DE0", VA = "0x180DF5BE0")]
	private static extern uint DLL_DuelGetCurrentStep();

	[PreserveSig]
	[Token(Token = "0x6009698")]
	[Address(RVA = "0xDF5B00", Offset = "0xDF4D00", VA = "0x180DF5B00")]
	private static extern uint DLL_DuelGetCurrentDmgStep();

	[PreserveSig]
	[Token(Token = "0x6009699")]
	[Address(RVA = "0xDF69E0", Offset = "0xDF5BE0", VA = "0x180DF69E0")]
	private static extern uint DLL_DuelGetTurnNum();

	[PreserveSig]
	[Token(Token = "0x600969A")]
	[Address(RVA = "0xDF54E0", Offset = "0xDF46E0", VA = "0x180DF54E0")]
	private static extern int DLL_DuelGetAttachedEffectList(IntPtr lpAffect);

	[PreserveSig]
	[Token(Token = "0x600969B")]
	[Address(RVA = "0xDF5960", Offset = "0xDF4B60", VA = "0x180DF5960")]
	private static extern IntPtr DLL_DuelGetCardPropByUniqueID(int uniqueId);

	[PreserveSig]
	[Token(Token = "0x600969C")]
	[Address(RVA = "0xDF5A70", Offset = "0xDF4C70", VA = "0x180DF5A70")]
	private static extern int DLL_DuelGetCardUniqueID(int player, int position, int index);

	[PreserveSig]
	[Token(Token = "0x600969D")]
	[Address(RVA = "0xDF59E0", Offset = "0xDF4BE0", VA = "0x180DF59E0")]
	private static extern int DLL_DuelGetCardTurn(int player, int position, int index);

	[PreserveSig]
	[Token(Token = "0x600969E")]
	[Address(RVA = "0xDF5740", Offset = "0xDF4940", VA = "0x180DF5740")]
	private static extern int DLL_DuelGetCardFace(int player, int position, int index);

	[PreserveSig]
	[Token(Token = "0x600969F")]
	[Address(RVA = "0xDF58D0", Offset = "0xDF4AD0", VA = "0x180DF58D0")]
	private static extern int DLL_DuelGetCardNum(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096A0")]
	[Address(RVA = "0xDF68C0", Offset = "0xDF5AC0", VA = "0x180DF68C0")]
	private static extern int DLL_DuelGetTopCardIndex(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096A1")]
	[Address(RVA = "0xDF6210", Offset = "0xDF5410", VA = "0x180DF6210")]
	private static extern bool DLL_DuelGetHandCardOpen(int player, int index);

	[PreserveSig]
	[Token(Token = "0x60096A2")]
	[Address(RVA = "0xDF7D50", Offset = "0xDF6F50", VA = "0x180DF7D50")]
	private static extern uint DLL_DuelSearchCardByUniqueID(int uniqueId);

	[PreserveSig]
	[Token(Token = "0x60096A3")]
	[Address(RVA = "0xDF57D0", Offset = "0xDF49D0", VA = "0x180DF57D0")]
	private static extern uint DLL_DuelGetCardIDByUniqueID2(int uniqueId);

	[PreserveSig]
	[Token(Token = "0x60096A4")]
	[Address(RVA = "0xDF4970", Offset = "0xDF3B70", VA = "0x180DF4970")]
	private static extern uint DLL_DuelCanIDoPutMonster(int player);

	[PreserveSig]
	[Token(Token = "0x60096A5")]
	[Address(RVA = "0xDF4A70", Offset = "0xDF3C70", VA = "0x180DF4A70")]
	private static extern bool DLL_DuelCanIDoSummonMonster(int player);

	[PreserveSig]
	[Token(Token = "0x60096A6")]
	[Address(RVA = "0xDF49F0", Offset = "0xDF3BF0", VA = "0x180DF49F0")]
	private static extern bool DLL_DuelCanIDoSpecialSummon(int player);

	[PreserveSig]
	[Token(Token = "0x60096A7")]
	[Address(RVA = "0xDF5850", Offset = "0xDF4A50", VA = "0x180DF5850")]
	private static extern uint DLL_DuelGetCardInHand(int player);

	[PreserveSig]
	[Token(Token = "0x60096A8")]
	[Address(RVA = "0xDF56A0", Offset = "0xDF48A0", VA = "0x180DF56A0")]
	private static extern void DLL_DuelGetCardBasicVal(int player, int pos, int index, ref BasicVal pVal);

	[PreserveSig]
	[Token(Token = "0x60096A9")]
	[Address(RVA = "0xDF6950", Offset = "0xDF5B50", VA = "0x180DF6950")]
	private static extern int DLL_DuelGetTrapMonstBasicVal(int cardId, ref BasicVal pVal);

	[PreserveSig]
	[Token(Token = "0x60096AA")]
	[Address(RVA = "0xDF65F0", Offset = "0xDF57F0", VA = "0x180DF65F0")]
	private static extern int DLL_DuelGetThisCardOverlayNum(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096AB")]
	[Address(RVA = "0xDF84F0", Offset = "0xDF76F0", VA = "0x180DF84F0")]
	private static extern int DLL_FusionGetMaterialList(int uniqueId, IntPtr list);

	[PreserveSig]
	[Token(Token = "0x60096AC")]
	[Address(RVA = "0xDF8600", Offset = "0xDF7800", VA = "0x180DF8600")]
	private static extern int DLL_FusionIsThisTunedMonsterInTuning(int wUniqueID);

	[PreserveSig]
	[Token(Token = "0x60096AD")]
	[Address(RVA = "0xDF8580", Offset = "0xDF7780", VA = "0x180DF8580")]
	private static extern int DLL_FusionGetMonsterLevelInTuning(int wUniqueID);

	[PreserveSig]
	[Token(Token = "0x60096AE")]
	[Address(RVA = "0xDF6C40", Offset = "0xDF5E40", VA = "0x180DF6C40")]
	private static extern int DLL_DuelIsThisCardExist(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096AF")]
	[Address(RVA = "0xDF64D0", Offset = "0xDF56D0", VA = "0x180DF64D0")]
	private static extern int DLL_DuelGetThisCardEffectIDAtChain(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096B0")]
	[Address(RVA = "0xDF5560", Offset = "0xDF4760", VA = "0x180DF5560")]
	private static extern int DLL_DuelGetAttackTargetMask(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096B1")]
	[Address(RVA = "0xDF63B0", Offset = "0xDF55B0", VA = "0x180DF63B0")]
	private static extern int DLL_DuelGetThisCardDirectFlag(int player, int index);

	[PreserveSig]
	[Token(Token = "0x60096B2")]
	[Address(RVA = "0xDF5E10", Offset = "0xDF5010", VA = "0x180DF5E10")]
	private static extern void DLL_DuelGetFldAffectIcon(int player, int locate, IntPtr ptr, int view_player);

	[PreserveSig]
	[Token(Token = "0x60096B3")]
	[Address(RVA = "0xDF55F0", Offset = "0xDF47F0", VA = "0x180DF55F0")]
	private static extern bool DLL_DuelGetCantActIcon(int player, int locate, int index, int flag);

	[PreserveSig]
	[Token(Token = "0x60096B4")]
	[Address(RVA = "0xDF6320", Offset = "0xDF5520", VA = "0x180DF6320")]
	private static extern int DLL_DuelGetThisCardCounter(int player, int locate, int counter);

	[PreserveSig]
	[Token(Token = "0x60096B5")]
	[Address(RVA = "0xDF67A0", Offset = "0xDF59A0", VA = "0x180DF67A0")]
	private static extern int DLL_DuelGetThisCardTurnCounter(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096B6")]
	[Address(RVA = "0xDF72D0", Offset = "0xDF64D0", VA = "0x180DF72D0")]
	private static extern int DLL_DuelIsThisTunerMonster(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096B7")]
	[Address(RVA = "0xDF70B0", Offset = "0xDF62B0", VA = "0x180DF70B0")]
	private static extern int DLL_DuelIsThisNormalMonster(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096B8")]
	[Address(RVA = "0xDF6D60", Offset = "0xDF5F60", VA = "0x180DF6D60")]
	private static extern bool DLL_DuelIsThisEffectiveMonster(int player, int index);

	[PreserveSig]
	[Token(Token = "0x60096B9")]
	[Address(RVA = "0xDF4870", Offset = "0xDF3A70", VA = "0x180DF4870")]
	private static extern bool DLL_DeulIsThisEffectiveMonsterWithDual(int player, int index);

	[PreserveSig]
	[Token(Token = "0x60096BA")]
	[Address(RVA = "0xDF6FA0", Offset = "0xDF61A0", VA = "0x180DF6FA0")]
	private static extern bool DLL_DuelIsThisNormalMonsterInGrave(int player, int index);

	[PreserveSig]
	[Token(Token = "0x60096BB")]
	[Address(RVA = "0xDF7030", Offset = "0xDF6230", VA = "0x180DF7030")]
	private static extern bool DLL_DuelIsThisNormalMonsterInHand(int wCardID);

	[PreserveSig]
	[Token(Token = "0x60096BC")]
	[Address(RVA = "0xDF71B0", Offset = "0xDF63B0", VA = "0x180DF71B0")]
	private static extern int DLL_DuelIsThisTrapMonster(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096BD")]
	[Address(RVA = "0xDF6440", Offset = "0xDF5640", VA = "0x180DF6440")]
	private static extern int DLL_DuelGetThisCardEffectFlags(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096BE")]
	[Address(RVA = "0xDF5EB0", Offset = "0xDF50B0", VA = "0x180DF5EB0")]
	private static extern int DLL_DuelGetFldMonstOrgLevel(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096BF")]
	[Address(RVA = "0xDF5FD0", Offset = "0xDF51D0", VA = "0x180DF5FD0")]
	private static extern int DLL_DuelGetFldMonstOrgType(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C0")]
	[Address(RVA = "0xDF6180", Offset = "0xDF5380", VA = "0x180DF6180")]
	private static extern int DLL_DuelGetFldPendScale(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C1")]
	[Address(RVA = "0xDF60F0", Offset = "0xDF52F0", VA = "0x180DF60F0")]
	private static extern int DLL_DuelGetFldPendOrgScale(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C2")]
	[Address(RVA = "0xDF6060", Offset = "0xDF5260", VA = "0x180DF6060")]
	private static extern int DLL_DuelGetFldMonstRank(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C3")]
	[Address(RVA = "0xDF5F40", Offset = "0xDF5140", VA = "0x180DF5F40")]
	private static extern int DLL_DuelGetFldMonstOrgRank(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C4")]
	[Address(RVA = "0xDF73F0", Offset = "0xDF65F0", VA = "0x180DF73F0")]
	private static extern int DLL_DuelIsThisZoneAvailable(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C5")]
	[Address(RVA = "0xDF7360", Offset = "0xDF6560", VA = "0x180DF7360")]
	private static extern int DLL_DuelIsThisZoneAvailable2(int player, int locate, bool visibleOnly);

	[PreserveSig]
	[Token(Token = "0x60096C6")]
	[Address(RVA = "0xDF6710", Offset = "0xDF5910", VA = "0x180DF6710")]
	private static extern int DLL_DuelGetThisCardShowParameter(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C7")]
	[Address(RVA = "0xDF6680", Offset = "0xDF5880", VA = "0x180DF6680")]
	private static extern uint DLL_DuelGetThisCardParameter(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096C8")]
	[Address(RVA = "0xDF6560", Offset = "0xDF5760", VA = "0x180DF6560")]
	private static extern uint DLL_DuelGetThisCardEffectList(int player, int locate, IntPtr list);

	[PreserveSig]
	[Token(Token = "0x60096C9")]
	[Address(RVA = "0xDF4770", Offset = "0xDF3970", VA = "0x180DF4770")]
	private static extern uint DLL_DUELCOMGetPosMaskOfThisHand(int player, int index, int commandId);

	[PreserveSig]
	[Token(Token = "0x60096CA")]
	[Address(RVA = "0xDF6CD0", Offset = "0xDF5ED0", VA = "0x180DF6CD0")]
	private static extern int DLL_DuelIsThisContinuousCard(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096CB")]
	[Address(RVA = "0xDF6DF0", Offset = "0xDF5FF0", VA = "0x180DF6DF0")]
	private static extern int DLL_DuelIsThisEquipCard(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096CC")]
	[Address(RVA = "0xDF6E80", Offset = "0xDF6080", VA = "0x180DF6E80")]
	private static extern bool DLL_DuelIsThisMagic(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096CD")]
	[Address(RVA = "0xDF7240", Offset = "0xDF6440", VA = "0x180DF7240")]
	private static extern bool DLL_DuelIsThisTrap(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096CE")]
	[Address(RVA = "0xDF6F10", Offset = "0xDF6110", VA = "0x180DF6F10")]
	private static extern bool DLL_DuelIsThisMaximumMode(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096CF")]
	[Address(RVA = "0xDF6830", Offset = "0xDF5A30", VA = "0x180DF6830")]
	private static extern bool DLL_DuelGetThisMonsterFightableOnEffect(int player, int locate);

	[PreserveSig]
	[Token(Token = "0x60096D0")]
	[Address(RVA = "0xDF4800", Offset = "0xDF3A00", VA = "0x180DF4800")]
	private static extern int DLL_DUELCOMGetRecommendSide();

	[PreserveSig]
	[Token(Token = "0x60096D1")]
	[Address(RVA = "0xDF5D30", Offset = "0xDF4F30", VA = "0x180DF5D30")]
	private static extern bool DLL_DuelGetDuelFlagDeckReverse();

	[PreserveSig]
	[Token(Token = "0x60096D2")]
	[Address(RVA = "0xDF4AF0", Offset = "0xDF3CF0", VA = "0x180DF4AF0")]
	private static extern void DLL_DuelChangeCardIDByUniqueID(int uniqueId, int cardId);

	[PreserveSig]
	[Token(Token = "0x60096D3")]
	[Address(RVA = "0xDF4D80", Offset = "0xDF3F80", VA = "0x180DF4D80")]
	private static extern uint DLL_DuelComGetCommandMask(int player, int position, int index);

	[PreserveSig]
	[Token(Token = "0x60096D4")]
	[Address(RVA = "0xDF4E80", Offset = "0xDF4080", VA = "0x180DF4E80")]
	private static extern uint DLL_DuelComGetTextIDOfThisCommand(int player, int position, int index);

	[PreserveSig]
	[Token(Token = "0x60096D5")]
	[Address(RVA = "0xDF4F10", Offset = "0xDF4110", VA = "0x180DF4F10")]
	private static extern uint DLL_DuelComGetTextIDOfThisSummon(int player, int position, int index);

	[PreserveSig]
	[Token(Token = "0x60096D6")]
	[Address(RVA = "0xDF4CE0", Offset = "0xDF3EE0", VA = "0x180DF4CE0")]
	private static extern void DLL_DuelComDoCommand(int player, int position, int index, int commandId);

	[PreserveSig]
	[Token(Token = "0x60096D7")]
	[Address(RVA = "0xDF4B80", Offset = "0xDF3D80", VA = "0x180DF4B80")]
	private static extern int DLL_DuelComCancelCommand2(bool decide);

	[PreserveSig]
	[Token(Token = "0x60096D8")]
	[Address(RVA = "0xDF4C70", Offset = "0xDF3E70", VA = "0x180DF4C70")]
	private static extern void DLL_DuelComDefaultLocation();

	[PreserveSig]
	[Token(Token = "0x60096D9")]
	[Address(RVA = "0xDF4E10", Offset = "0xDF4010", VA = "0x180DF4E10")]
	private static extern uint DLL_DuelComGetMovablePhase();

	[PreserveSig]
	[Token(Token = "0x60096DA")]
	[Address(RVA = "0xDF4FA0", Offset = "0xDF41A0", VA = "0x180DF4FA0")]
	private static extern void DLL_DuelComMovePhase(int phase);

	[PreserveSig]
	[Token(Token = "0x60096DB")]
	[Address(RVA = "0xDF4C00", Offset = "0xDF3E00", VA = "0x180DF4C00")]
	private static extern void DLL_DuelComDebugCommand();

	[PreserveSig]
	[Token(Token = "0x60096DC")]
	[Address(RVA = "0xDF4540", Offset = "0xDF3740", VA = "0x180DF4540")]
	private static extern uint DLL_CardRareGetBufferSize();

	[PreserveSig]
	[Token(Token = "0x60096DD")]
	[Address(RVA = "0xDF46B0", Offset = "0xDF38B0", VA = "0x180DF46B0")]
	private static extern void DLL_CardRareSetRare(IntPtr pBuf, IntPtr rare0, IntPtr rare1, IntPtr rare2, IntPtr rare3);

	[PreserveSig]
	[Token(Token = "0x60096DE")]
	[Address(RVA = "0xDF45B0", Offset = "0xDF37B0", VA = "0x180DF45B0")]
	private static extern int DLL_CardRareGetRareByUniqueID(int uniqueId);

	[PreserveSig]
	[Token(Token = "0x60096DF")]
	[Address(RVA = "0xDF4630", Offset = "0xDF3830", VA = "0x180DF4630")]
	private static extern void DLL_CardRareSetBuffer(IntPtr pBuf);

	[PreserveSig]
	[Token(Token = "0x60096E0")]
	[Address(RVA = "0xDF8B90", Offset = "0xDF7D90", VA = "0x180DF8B90")]
	private static extern void DLL_SetRareByUniqueID(int uniqueId, int rare);

	[PreserveSig]
	[Token(Token = "0x60096E1")]
	[Address(RVA = "0xDF7C50", Offset = "0xDF6E50", VA = "0x180DF7C50")]
	private static extern int DLL_DuelResultGetMemo(int player, IntPtr dst);

	[PreserveSig]
	[Token(Token = "0x60096E2")]
	[Address(RVA = "0xDF7BC0", Offset = "0xDF6DC0", VA = "0x180DF7BC0")]
	private static extern int DLL_DuelResultGetData(int player, IntPtr dst);

	[PreserveSig]
	[Token(Token = "0x60096E3")]
	[Address(RVA = "0xDF87E0", Offset = "0xDF79E0", VA = "0x180DF87E0")]
	private static extern void DLL_SetAddRecordDelegate(AddRecord addRecord);

	[PreserveSig]
	[Token(Token = "0x60096E4")]
	[Address(RVA = "0xDF8AC0", Offset = "0xDF7CC0", VA = "0x180DF8AC0")]
	private static extern void DLL_SetPlayRecordDelegate(NowRecord nowRecord, RecordNext recordNext, RecordBegin recordBegin, IsRecordEnd isRecordEnd);

	[PreserveSig]
	[Token(Token = "0x60096E5")]
	[Address(RVA = "0xDF6B50", Offset = "0xDF5D50", VA = "0x180DF6B50")]
	private static extern int DLL_DuelIsReplayMode();

	[PreserveSig]
	[Token(Token = "0x60096E6")]
	[Address(RVA = "0xDF89A0", Offset = "0xDF7BA0", VA = "0x180DF89A0")]
	private static extern void DLL_SetDuelChallenge(int flagbit);

	[PreserveSig]
	[Token(Token = "0x60096E7")]
	[Address(RVA = "0xDF8910", Offset = "0xDF7B10", VA = "0x180DF8910")]
	private static extern void DLL_SetDuelChallenge2(int player, int flagbit);

	[Token(Token = "0x60096E9")]
	[Address(RVA = "0xE1E700", Offset = "0xE1D900", VA = "0x180E1E700")]
	public static int Revision()
	{
		return default(int);
	}

	[Token(Token = "0x60096EA")]
	[Address(RVA = "0xDF1970", Offset = "0xDF0B70", VA = "0x180DF1970")]
	public static int BinHash(int iIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60096EB")]
	[Address(RVA = "0xE209B0", Offset = "0xE1FBB0", VA = "0x180E209B0")]
	public static int SetWorkMemory(IntPtr pWork)
	{
		return default(int);
	}

	[Token(Token = "0x60096EC")]
	[Address(RVA = "0xDFCBC0", Offset = "0xDFBDC0", VA = "0x180DFCBC0")]
	public static int GetCardOwnerByUniqueID(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x60096ED")]
	[Address(RVA = "0xE21940", Offset = "0xE20B40", VA = "0x180E21940")]
	public static bool SysInitQuestion(byte[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60096EE")]
	[Address(RVA = "0xE21810", Offset = "0xE20A10", VA = "0x180E21810")]
	public static bool SysInitCustom(int fDuelType = 0, bool tag = false, int life0 = -1, int life1 = -1, int hand0 = -1, int hand1 = -1, bool shuf = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60096EF")]
	[Address(RVA = "0xE32D50", Offset = "0xE31F50", VA = "0x180E32D50")]
	private void recvData()
	{
	}

	[Token(Token = "0x60096F0")]
	[Address(RVA = "0xE32BD0", Offset = "0xE31DD0", VA = "0x180E32BD0")]
	private void recvDataImpl(PvP.Event ev)
	{
	}

	[Token(Token = "0x60096F1")]
	[Address(RVA = "0xE20490", Offset = "0xE1F690", VA = "0x180E20490")]
	public static void SetPreRecvData(PvP.Event ev)
	{
	}

	[Token(Token = "0x60096F2")]
	[Address(RVA = "0xE21000", Offset = "0xE20200", VA = "0x180E21000")]
	public static bool SysAct()
	{
		return default(bool);
	}

	[Token(Token = "0x60096F3")]
	[Address(RVA = "0xE13270", Offset = "0xE12470", VA = "0x180E13270")]
	public static void PvpForceFinish()
	{
	}

	[Token(Token = "0x60096F4")]
	[Address(RVA = "0xE04740", Offset = "0xE03940", VA = "0x180E04740")]
	public static bool IsSysActLoopExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x60096F5")]
	[Address(RVA = "0xDF2040", Offset = "0xDF1240", VA = "0x180DF2040")]
	public static void ClearWork()
	{
	}

	[Token(Token = "0x60096F6")]
	[Address(RVA = "0xE21B20", Offset = "0xE20D20", VA = "0x180E21B20")]
	public static void SysSetDeck(int player, int[] mainDeck, int[] extraDeck, int[] sideDeck)
	{
	}

	[Token(Token = "0x60096F7")]
	[Address(RVA = "0xE20520", Offset = "0xE1F720", VA = "0x180E20520")]
	public static void SetRandomSeed(uint seed)
	{
	}

	[Token(Token = "0x60096F8")]
	[Address(RVA = "0xE1FF00", Offset = "0xE1F100", VA = "0x180E1FF00")]
	public static void SetMyPlayerNum(int player)
	{
	}

	[Token(Token = "0x60096F9")]
	[Address(RVA = "0xE20330", Offset = "0xE1F530", VA = "0x180E20330")]
	public static void SetPlayerType(int player, PlayerType type)
	{
	}

	[Token(Token = "0x60096FA")]
	[Address(RVA = "0xE04240", Offset = "0xE03440", VA = "0x180E04240")]
	public static bool IsHuman(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x60096FB")]
	[Address(RVA = "0xE082A0", Offset = "0xE074A0", VA = "0x180E082A0")]
	public static int Myself()
	{
		return default(int);
	}

	[Token(Token = "0x60096FC")]
	[Address(RVA = "0xE1E7A0", Offset = "0xE1D9A0", VA = "0x180E1E7A0")]
	public static int Rival()
	{
		return default(int);
	}

	[Token(Token = "0x60096FD")]
	[Address(RVA = "0xE04350", Offset = "0xE03550", VA = "0x180E04350")]
	public static bool IsMyself(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x60096FE")]
	[Address(RVA = "0xE045B0", Offset = "0xE037B0", VA = "0x180E045B0")]
	public static bool IsRival(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x60096FF")]
	[Address(RVA = "0xE08590", Offset = "0xE07790", VA = "0x180E08590")]
	public static int OtherSide(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009700")]
	[Address(RVA = "0xE04180", Offset = "0xE03380", VA = "0x180E04180")]
	public static void InitCpuParam(int player, uint param)
	{
	}

	[Token(Token = "0x6009701")]
	[Address(RVA = "0xE1F490", Offset = "0xE1E690", VA = "0x180E1F490")]
	public static void SetCpuParam(int player, uint param)
	{
	}

	[Token(Token = "0x6009702")]
	[Address(RVA = "0xE1FB20", Offset = "0xE1ED20", VA = "0x180E1FB20")]
	public static void SetFirstPlayer(int player)
	{
	}

	[Token(Token = "0x6009703")]
	[Address(RVA = "0xDFF2E0", Offset = "0xDFE4E0", VA = "0x180DFF2E0")]
	public static ResultType GetDuelResult()
	{
		return default(ResultType);
	}

	[Token(Token = "0x6009704")]
	[Address(RVA = "0xDFF1F0", Offset = "0xDFE3F0", VA = "0x180DFF1F0")]
	public static FinishType GetDuelFinish()
	{
		return default(FinishType);
	}

	[Token(Token = "0x6009705")]
	[Address(RVA = "0xDFF100", Offset = "0xDFE300", VA = "0x180DFF100")]
	public static int GetDuelFinishCardID()
	{
		return default(int);
	}

	[Token(Token = "0x6009706")]
	[Address(RVA = "0xE1F710", Offset = "0xE1E910", VA = "0x180E1F710")]
	public static void SetDuelLimitedType(uint limited)
	{
	}

	[Token(Token = "0x6009707")]
	[Address(RVA = "0xE1F800", Offset = "0xE1EA00", VA = "0x180E1F800")]
	public static void SetEffectDelegate(RunEffect runEffect, IsBusyEffect isBusyEffect)
	{
	}

	[Token(Token = "0x6009708")]
	[Address(RVA = "0xE1EFD0", Offset = "0xE1E1D0", VA = "0x180E1EFD0")]
	public static void SetCardExistWork(int size)
	{
	}

	[Token(Token = "0x6009709")]
	[Address(RVA = "0xE1E5C0", Offset = "0xE1D7C0", VA = "0x180E1E5C0")]
	public static void ResumeCardExistWork(byte[] data, int count)
	{
	}

	[Token(Token = "0x600970A")]
	[Address(RVA = "0xDFC410", Offset = "0xDFB610", VA = "0x180DFC410")]
	public static int GetCardExistNum()
	{
		return default(int);
	}

	[Token(Token = "0x600970B")]
	[Address(RVA = "0xDF2F10", Offset = "0xDF2110", VA = "0x180DF2F10")]
	public static bool CpuSysCheckFinishAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x600970C")]
	[Address(RVA = "0xE00C70", Offset = "0xDFFE70", VA = "0x180E00C70")]
	public static int GetLP(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600970D")]
	[Address(RVA = "0xE31900", Offset = "0xE30B00", VA = "0x180E31900")]
	public static int WhichTurnNow()
	{
		return default(int);
	}

	[Token(Token = "0x600970E")]
	[Address(RVA = "0xDFDF90", Offset = "0xDFD190", VA = "0x180DFDF90")]
	public static Phase GetCurrentPhase()
	{
		return default(Phase);
	}

	[Token(Token = "0x600970F")]
	[Address(RVA = "0xDFE220", Offset = "0xDFD420", VA = "0x180DFE220")]
	public static StepType GetCurrentStep()
	{
		return default(StepType);
	}

	[Token(Token = "0x6009710")]
	[Address(RVA = "0xDFDD00", Offset = "0xDFCF00", VA = "0x180DFDD00")]
	public static DmgStepType GetCurrentDmgStep()
	{
		return default(DmgStepType);
	}

	[Token(Token = "0x6009711")]
	[Address(RVA = "0xE03A60", Offset = "0xE02C60", VA = "0x180E03A60")]
	public static int GetTurnNum()
	{
		return default(int);
	}

	[Token(Token = "0x6009712")]
	[Address(RVA = "0xDFE8F0", Offset = "0xDFDAF0", VA = "0x180DFE8F0")]
	public static int GetDuelCanIDoPutMonster(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009713")]
	[Address(RVA = "0xDFEE50", Offset = "0xDFE050", VA = "0x180DFEE50")]
	public static bool GetDuelCanIDoSummonMonster(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x6009714")]
	[Address(RVA = "0xDFEBA0", Offset = "0xDFDDA0", VA = "0x180DFEBA0")]
	public static bool GetDuelCanIDoSpecialSummon(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x6009715")]
	[Address(RVA = "0xDFE6F0", Offset = "0xDFD8F0", VA = "0x180DFE6F0")]
	public static AffectProp[] GetDuelAttachedEffectList()
	{
		return null;
	}

	[Token(Token = "0x6009716")]
	[Address(RVA = "0xDFD300", Offset = "0xDFC500", VA = "0x180DFD300")]
	public static CardProp GetCardPropByUniqueID(int uniqueId)
	{
		return default(CardProp);
	}

	[Token(Token = "0x6009717")]
	[Address(RVA = "0xDFC7F0", Offset = "0xDFB9F0", VA = "0x180DFC7F0")]
	public static int GetCardID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009718")]
	[Address(RVA = "0xDFDA70", Offset = "0xDFCC70", VA = "0x180DFDA70")]
	public static int GetCardUniqueID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009719")]
	[Address(RVA = "0xDFD7E0", Offset = "0xDFC9E0", VA = "0x180DFD7E0")]
	public static bool GetCardTurn(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600971A")]
	[Address(RVA = "0xDFC4B0", Offset = "0xDFB6B0", VA = "0x180DFC4B0")]
	public static bool GetCardFace(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600971B")]
	[Address(RVA = "0xDFCAF0", Offset = "0xDFBCF0", VA = "0x180DFCAF0")]
	public static int GetCardNum(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600971C")]
	[Address(RVA = "0xE03660", Offset = "0xE02860", VA = "0x180E03660")]
	public static int GetTopCardIndex(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600971D")]
	[Address(RVA = "0xE1E910", Offset = "0xE1DB10", VA = "0x180E1E910")]
	public static int SearchCardByUniqueID(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x600971E")]
	[Address(RVA = "0xE00FF0", Offset = "0xE001F0", VA = "0x180E00FF0")]
	public static (int, int, int) GetParamsByUniqueId(int uniqueid)
	{
		return default((int, int, int));
	}

	[Token(Token = "0x600971F")]
	[Address(RVA = "0xDFBF40", Offset = "0xDFB140", VA = "0x180DFBF40")]
	public static BasicVal GetBasicValByUniqueId(int uniqueid)
	{
		return default(BasicVal);
	}

	[Token(Token = "0x6009720")]
	[Address(RVA = "0xDFC740", Offset = "0xDFB940", VA = "0x180DFC740")]
	public static int GetCardIDByUniqueID(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x6009721")]
	[Address(RVA = "0xDFCA30", Offset = "0xDFBC30", VA = "0x180DFCA30")]
	public static uint GetCardInHand(int player)
	{
		return default(uint);
	}

	[Token(Token = "0x6009722")]
	[Address(RVA = "0xDFC040", Offset = "0xDFB240", VA = "0x180DFC040")]
	public static void GetCardBasicVal(int player, int position, int index, ref BasicVal val)
	{
	}

	[Token(Token = "0x6009723")]
	[Address(RVA = "0xE039A0", Offset = "0xE02BA0", VA = "0x180E039A0")]
	public static bool GetTrapMonsterBasicVal(int cardId, ref BasicVal val)
	{
		return default(bool);
	}

	[Token(Token = "0x6009724")]
	[Address(RVA = "0xE02660", Offset = "0xE01860", VA = "0x180E02660")]
	public static int GetThisCardOverlayNum(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009725")]
	[Address(RVA = "0xE00B10", Offset = "0xDFFD10", VA = "0x180E00B10")]
	public static int[] GetFusionMaterialList(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6009726")]
	[Address(RVA = "0xDFB140", Offset = "0xDFA340", VA = "0x180DFB140")]
	public static bool FusionIsThisTunedMonsterInTuning()
	{
		return default(bool);
	}

	[Token(Token = "0x6009727")]
	[Address(RVA = "0xDFAFE0", Offset = "0xDFA1E0", VA = "0x180DFAFE0")]
	public static int FusionGetMonsterLevelInTuning()
	{
		return default(int);
	}

	[Token(Token = "0x6009728")]
	[Address(RVA = "0xE04940", Offset = "0xE03B40", VA = "0x180E04940")]
	public static bool IsThisCardExist(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009729")]
	[Address(RVA = "0xE02190", Offset = "0xE01390", VA = "0x180E02190")]
	public static int GetThisCardEffectIDAtChain(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600972A")]
	[Address(RVA = "0xDFBBD0", Offset = "0xDFADD0", VA = "0x180DFBBD0")]
	public static int GetAttackTargetMask(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600972B")]
	[Address(RVA = "0xDFF3D0", Offset = "0xDFE5D0", VA = "0x180DFF3D0")]
	public static AffectType[][] GetFieldAffectIcon(int player, int locate)
	{
		return null;
	}

	[Token(Token = "0x600972C")]
	[Address(RVA = "0xE1EB50", Offset = "0xE1DD50", VA = "0x180E1EB50")]
	public static CardStatus SearchCardStatusByUniqueID(int uniqueId)
	{
		return default(CardStatus);
	}

	[Token(Token = "0x600972D")]
	[Address(RVA = "0xE01A30", Offset = "0xE00C30", VA = "0x180E01A30")]
	public static int GetThisCardCounter(int player, int locate, CounterType counter)
	{
		return default(int);
	}

	[Token(Token = "0x600972E")]
	[Address(RVA = "0xE02FB0", Offset = "0xE021B0", VA = "0x180E02FB0")]
	public static int GetThisCardTurnCounter(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600972F")]
	[Address(RVA = "0xE063D0", Offset = "0xE055D0", VA = "0x180E063D0")]
	public static bool IsThisTunerMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009730")]
	[Address(RVA = "0xE059D0", Offset = "0xE04BD0", VA = "0x180E059D0")]
	public static bool IsThisNormalMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009731")]
	[Address(RVA = "0xE05D20", Offset = "0xE04F20", VA = "0x180E05D20")]
	public static bool IsThisTrapMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009732")]
	[Address(RVA = "0xE04C90", Offset = "0xE03E90", VA = "0x180E04C90")]
	public static int IsThisContinuousCard(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009733")]
	[Address(RVA = "0xE04FD0", Offset = "0xE041D0", VA = "0x180E04FD0")]
	public static int IsThisEquipCard(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009734")]
	[Address(RVA = "0xE05310", Offset = "0xE04510", VA = "0x180E05310")]
	public static bool IsThisMagic(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009735")]
	[Address(RVA = "0xE06070", Offset = "0xE05270", VA = "0x180E06070")]
	public static bool IsThisTrap(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009736")]
	[Address(RVA = "0xE05670", Offset = "0xE04870", VA = "0x180E05670")]
	public static bool IsThisMaximumMode(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009737")]
	[Address(RVA = "0xE03300", Offset = "0xE02500", VA = "0x180E03300")]
	public static bool GetThisMonsterFightableOnEffect(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009738")]
	[Address(RVA = "0xE01E50", Offset = "0xE01050", VA = "0x180E01E50")]
	public static int GetThisCardEffectFlags(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009739")]
	[Address(RVA = "0xDFF790", Offset = "0xDFE990", VA = "0x180DFF790")]
	public static int GetFldMonstOrgLevel(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600973A")]
	[Address(RVA = "0xDFFE10", Offset = "0xDFF010", VA = "0x180DFFE10")]
	public static int GetFldMonstOrgType(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600973B")]
	[Address(RVA = "0xE007D0", Offset = "0xDFF9D0", VA = "0x180E007D0")]
	public static int GetFldPendScale(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600973C")]
	[Address(RVA = "0xE00490", Offset = "0xDFF690", VA = "0x180E00490")]
	public static int GetFldPendOrgScale(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600973D")]
	[Address(RVA = "0xE00150", Offset = "0xDFF350", VA = "0x180E00150")]
	public static int GetFldMonstRank(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600973E")]
	[Address(RVA = "0xDFFAD0", Offset = "0xDFECD0", VA = "0x180DFFAD0")]
	public static int GetFldMonstOrgRank(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600973F")]
	[Address(RVA = "0xE06720", Offset = "0xE05920", VA = "0x180E06720")]
	public static bool IsThisZoneAvailable(int player, int locate, bool visibleOnly = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6009740")]
	[Address(RVA = "0xE02C90", Offset = "0xE01E90", VA = "0x180E02C90")]
	public static ShowParam GetThisCardShowParameter(int player, int locate)
	{
		return default(ShowParam);
	}

	[Token(Token = "0x6009741")]
	[Address(RVA = "0xE02970", Offset = "0xE01B70", VA = "0x180E02970")]
	public static uint GetThisCardParameter(int player, int locate)
	{
		return default(uint);
	}

	[Token(Token = "0x6009742")]
	[Address(RVA = "0xE01B20", Offset = "0xE00D20", VA = "0x180E01B20")]
	public static int GetThisCardDirectFlag(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009743")]
	[Address(RVA = "0xE02480", Offset = "0xE01680", VA = "0x180E02480")]
	public static int[] GetThisCardEffectList(int player, int locate)
	{
		return null;
	}

	[Token(Token = "0x6009744")]
	[Address(RVA = "0xE01090", Offset = "0xE00290", VA = "0x180E01090")]
	public static uint GetPosMaskOfThisHand(int player, int index, CommandType commandId)
	{
		return default(uint);
	}

	[Token(Token = "0x6009745")]
	[Address(RVA = "0xDF26D0", Offset = "0xDF18D0", VA = "0x180DF26D0")]
	public static uint ComGetCommandMask(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009746")]
	[Address(RVA = "0xDF2A90", Offset = "0xDF1C90", VA = "0x180DF2A90")]
	public static uint ComGetTextIDOfThisCommand(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009747")]
	[Address(RVA = "0xDF2B80", Offset = "0xDF1D80", VA = "0x180DF2B80")]
	public static uint ComGetTextIDOfThisSummon(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009748")]
	[Address(RVA = "0xDF2650", Offset = "0xDF1850", VA = "0x180DF2650")]
	public static uint ComGetCommandMaskEach(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009749")]
	[Address(RVA = "0xDF23C0", Offset = "0xDF15C0", VA = "0x180DF23C0")]
	public static void ComDoCommand(int player, int position, int index, CommandType commandId, bool checkCommand = true)
	{
	}

	[Token(Token = "0x600974A")]
	[Address(RVA = "0xDF1E60", Offset = "0xDF1060", VA = "0x180DF1E60")]
	private static bool CheckCommand(int player, int position, int index, CommandType commandId)
	{
		return default(bool);
	}

	[Token(Token = "0x600974B")]
	[Address(RVA = "0xDF20E0", Offset = "0xDF12E0", VA = "0x180DF20E0")]
	public static void ComCancelCommand(bool decide = true)
	{
	}

	[Token(Token = "0x600974C")]
	[Address(RVA = "0xDF27C0", Offset = "0xDF19C0", VA = "0x180DF27C0")]
	public static uint ComGetMovablePhase()
	{
		return default(uint);
	}

	[Token(Token = "0x600974D")]
	[Address(RVA = "0xDF2C70", Offset = "0xDF1E70", VA = "0x180DF2C70")]
	public static void ComMovePhase(Phase phase)
	{
	}

	[Token(Token = "0x600974E")]
	[Address(RVA = "0xE01440", Offset = "0xE00640", VA = "0x180E01440")]
	public static int GetRecommendSide()
	{
		return default(int);
	}

	[Token(Token = "0x600974F")]
	[Address(RVA = "0xDFF500", Offset = "0xDFE700", VA = "0x180DFF500")]
	public static bool GetFlagDeckReverse()
	{
		return default(bool);
	}

	[Token(Token = "0x6009750")]
	[Address(RVA = "0xDF2380", Offset = "0xDF1580", VA = "0x180DF2380")]
	public static void ComDebugCommand()
	{
	}

	[Token(Token = "0x6009751")]
	[Address(RVA = "0xDF1DA0", Offset = "0xDF0FA0", VA = "0x180DF1DA0")]
	public static int CardRareBufferSize()
	{
		return default(int);
	}

	[Token(Token = "0x6009752")]
	[Address(RVA = "0xE1F050", Offset = "0xE1E250", VA = "0x180E1F050")]
	public static void SetCardRare(int[] rare0, int[] rare1, [Optional] int[] rare2, [Optional] int[] rare3)
	{
	}

	[Token(Token = "0x6009753")]
	[Address(RVA = "0xDFD5D0", Offset = "0xDFC7D0", VA = "0x180DFD5D0")]
	public static int GetCardRareByUniqueID(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x6009754")]
	[Address(RVA = "0xE205F0", Offset = "0xE1F7F0", VA = "0x180E205F0")]
	public static void SetRareByUniqueID(int uniqueId, int rare)
	{
	}

	[Token(Token = "0x6009755")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void SetAddRecordDelegate(AddRecord addRecord)
	{
	}

	[Token(Token = "0x6009756")]
	[Address(RVA = "0xE20140", Offset = "0xE1F340", VA = "0x180E20140")]
	public static void SetPlayRecordDelegate(NowRecord nowRecord, RecordNext recordNext, RecordBegin recordBegin, IsRecordEnd isRecordEnd)
	{
	}

	[Token(Token = "0x6009757")]
	[Address(RVA = "0xE044E0", Offset = "0xE036E0", VA = "0x180E044E0")]
	public static bool IsReplayMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6009758")]
	[Address(RVA = "0xE01180", Offset = "0xE00380", VA = "0x180E01180")]
	public static uint GetPvpDuelInfoTimeLeft()
	{
		return default(uint);
	}

	[Token(Token = "0x6009759")]
	[Address(RVA = "0xE012E0", Offset = "0xE004E0", VA = "0x180E012E0")]
	public static uint GetPvpDuelInfoTimeTotal()
	{
		return default(uint);
	}

	[Token(Token = "0x600975A")]
	[Address(RVA = "0xE1F630", Offset = "0xE1E830", VA = "0x180E1F630")]
	public static void SetDuelChallenge(int flagbit)
	{
	}

	[Token(Token = "0x600975B")]
	[Address(RVA = "0xE1F550", Offset = "0xE1E750", VA = "0x180E1F550")]
	public static void SetDuelChallenge2(int player, int flagbit)
	{
	}

	[Token(Token = "0x600975D")]
	[Address(RVA = "0xDFDC30", Offset = "0xDFCE30", VA = "0x180DFDC30")]
	public static CounterType GetCounterType(int id)
	{
		return default(CounterType);
	}

	[Token(Token = "0x600975E")]
	[Address(RVA = "0xDFDB60", Offset = "0xDFCD60", VA = "0x180DFDB60")]
	public static int GetCounterId(CounterType type)
	{
		return default(int);
	}

	[Token(Token = "0x600975F")]
	[Address(RVA = "0xE316D0", Offset = "0xE308D0", VA = "0x180E316D0")]
	public static bool TransExMonsterPosition(int team, int pos, ref int oppTeam, ref int oppPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6009760")]
	[Address(RVA = "0xE31550", Offset = "0xE30750", VA = "0x180E31550")]
	public static bool TransExMonsterPositionUnAvailable(ref int team, ref int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6009761")]
	[Address(RVA = "0xDFAE60", Offset = "0xDFA060", VA = "0x180DFAE60")]
	private static void ForceSimpleCpu(int player, CpuParam param = CpuParam.Simple)
	{
	}

	[Token(Token = "0x6009762")]
	[Address(RVA = "0xE1E440", Offset = "0xE1D640", VA = "0x180E1E440")]
	private static void RestoreCpuParam(int player)
	{
	}

	[Token(Token = "0x6009769")]
	[Address(RVA = "0xDF1A20", Offset = "0xDF0C20", VA = "0x180DF1A20")]
	public static int CachedMatId_Get(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600976A")]
	[Address(RVA = "0xDF1B00", Offset = "0xDF0D00", VA = "0x180DF1B00")]
	public static void CachedMatId_Set(int player, int mid)
	{
	}

	[Token(Token = "0x600976B")]
	[Address(RVA = "0xDF1BE0", Offset = "0xDF0DE0", VA = "0x180DF1BE0")]
	public static int CachedSleeveId_Get(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600976C")]
	[Address(RVA = "0xDF1CC0", Offset = "0xDF0EC0", VA = "0x180DF1CC0")]
	public static void CachedSleeveId_Set(int player, int sid)
	{
	}

	[Token(Token = "0x600976D")]
	[Address(RVA = "0xE00BC0", Offset = "0xDFFDC0", VA = "0x180E00BC0")]
	public static int GetInitialLP(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600976E")]
	[Address(RVA = "0xE1FBD0", Offset = "0xE1EDD0", VA = "0x180E1FBD0")]
	public static void SetInitialLP(int player, int val)
	{
	}

	[Token(Token = "0x600976F")]
	[Address(RVA = "0xDF37A0", Offset = "0xDF29A0", VA = "0x180DF37A0")]
	public static void Create(Util.GameMode gamemode, bool isOnline = false)
	{
	}

	[Token(Token = "0x6009770")]
	[Address(RVA = "0xDF8E30", Offset = "0xDF8030", VA = "0x180DF8E30")]
	public static void Destroy()
	{
	}

	[Token(Token = "0x6009771")]
	[Address(RVA = "0xE1E040", Offset = "0xE1D240", VA = "0x180E1E040")]
	private void Release()
	{
	}

	[Token(Token = "0x6009772")]
	[Address(RVA = "0xE03CF0", Offset = "0xE02EF0", VA = "0x180E03CF0")]
	private void InitCounterDictionary(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x6009773")]
	[Address(RVA = "0xDF3510", Offset = "0xDF2710", VA = "0x180DF3510")]
	private void CreateCardRareBuffer()
	{
	}

	[Token(Token = "0x6009774")]
	[Address(RVA = "0xE1DF50", Offset = "0xE1D150", VA = "0x180E1DF50")]
	private void ReleaseCardRareBuffer()
	{
	}

	[Token(Token = "0x6009775")]
	[Address(RVA = "0xE017E0", Offset = "0xE009E0", VA = "0x180E017E0")]
	public static byte[] GetRecvData(PvP.Command cmd)
	{
		return null;
	}

	[Token(Token = "0x6009776")]
	[Address(RVA = "0xE016D0", Offset = "0xE008D0", VA = "0x180E016D0")]
	public static int GetRecvCount(PvP.Command cmd)
	{
		return default(int);
	}

	[Token(Token = "0x6009777")]
	[Address(RVA = "0xE01910", Offset = "0xE00B10", VA = "0x180E01910")]
	public static uint GetRecvOrder(PvP.Command cmd)
	{
		return default(uint);
	}

	[Token(Token = "0x6009778")]
	[Address(RVA = "0xDF1F30", Offset = "0xDF1130", VA = "0x180DF1F30")]
	public static void ClearRecvQueue(PvP.Command cmd)
	{
	}

	[Token(Token = "0x6009779")]
	[Address(RVA = "0xDF3390", Offset = "0xDF2590", VA = "0x180DF3390")]
	public static void CreateCardExistBuffer(int size)
	{
	}

	[Token(Token = "0x600977A")]
	[Address(RVA = "0xDFC290", Offset = "0xDFB490", VA = "0x180DFC290")]
	public static byte[] GetCardExistBuffer()
	{
		return null;
	}

	[Token(Token = "0x600977B")]
	[Address(RVA = "0xE1DED0", Offset = "0xE1D0D0", VA = "0x180E1DED0")]
	private void ReleaseCardExistBuffer()
	{
	}

	[Token(Token = "0x600977C")]
	[Address(RVA = "0xE20870", Offset = "0xE1FA70", VA = "0x180E20870")]
	public static void SetStartInputCallback(Action callback)
	{
	}

	[Token(Token = "0x600977D")]
	[Address(RVA = "0xE20910", Offset = "0xE1FB10", VA = "0x180E20910")]
	public static void SetUpdateTimerCallback(Action callback)
	{
	}

	[Token(Token = "0x600977E")]
	[Address(RVA = "0xE20A60", Offset = "0xE1FC60", VA = "0x180E20A60")]
	public static void StartInput()
	{
	}

	[Token(Token = "0x600977F")]
	[Address(RVA = "0xDFA7C0", Offset = "0xDF99C0", VA = "0x180DFA7C0")]
	public static void EndInput()
	{
	}

	[Token(Token = "0x6009780")]
	[Address(RVA = "0xE1ECB0", Offset = "0xE1DEB0", VA = "0x180E1ECB0")]
	public static void SendPvpTime()
	{
	}

	[Token(Token = "0x6009781")]
	[Address(RVA = "0xE20040", Offset = "0xE1F240", VA = "0x180E20040")]
	public static void SetNoResponseCallback(Action noResponse, Action recovery, Action closed)
	{
	}

	[Token(Token = "0x6009782")]
	[Address(RVA = "0xE084D0", Offset = "0xE076D0", VA = "0x180E084D0")]
	public static void NoResponse()
	{
	}

	[Token(Token = "0x6009783")]
	[Address(RVA = "0xE1DE10", Offset = "0xE1D010", VA = "0x180E1DE10")]
	public static void RecoveryResponse()
	{
	}

	[Token(Token = "0x6009784")]
	[Address(RVA = "0xE08410", Offset = "0xE07610", VA = "0x180E08410")]
	public static void NoResponseClosed()
	{
	}

	[Token(Token = "0x6009785")]
	[Address(RVA = "0xDF36A0", Offset = "0xDF28A0", VA = "0x180DF36A0")]
	private void CreateQuestionData(byte[] data)
	{
	}

	[Token(Token = "0x6009786")]
	[Address(RVA = "0xE1DFD0", Offset = "0xE1D1D0", VA = "0x180E1DFD0")]
	private void ReleaseQuestionData()
	{
	}

	[Token(Token = "0x6009787")]
	[Address(RVA = "0xE08260", Offset = "0xE07460", VA = "0x180E08260")]
	public static uint MakeCpuParam(int val, CpuParam param = CpuParam.None)
	{
		return default(uint);
	}

	[Token(Token = "0x6009788")]
	[Address(RVA = "0xE1FA20", Offset = "0xE1EC20", VA = "0x180E1FA20")]
	private void SetEngineWork()
	{
	}

	[Token(Token = "0x6009789")]
	[Address(RVA = "0xE1FC80", Offset = "0xE1EE80", VA = "0x180E1FC80")]
	public static void SetLatency(byte[] recvData)
	{
	}

	[Token(Token = "0x600978A")]
	[Address(RVA = "0xE00F40", Offset = "0xE00140", VA = "0x180E00F40")]
	public static int GetLatency(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600978B")]
	[Address(RVA = "0xDFF470", Offset = "0xDFE670", VA = "0x180DFF470")]
	public static int GetFinishTypeOverrider()
	{
		return default(int);
	}

	[Token(Token = "0x600978C")]
	[Address(RVA = "0xE1EE30", Offset = "0xE1E030", VA = "0x180E1EE30")]
	public static void SendSurrender(bool autoSurrender = false)
	{
	}

	[PreserveSig]
	[Token(Token = "0x600978D")]
	[Address(RVA = "0xDF79D0", Offset = "0xDF6BD0", VA = "0x180DF79D0")]
	private static extern int DLL_DuelListIsMultiMode();

	[PreserveSig]
	[Token(Token = "0x600978E")]
	[Address(RVA = "0xDF7960", Offset = "0xDF6B60", VA = "0x180DF7960")]
	private static extern void DLL_DuelListInitString();

	[PreserveSig]
	[Token(Token = "0x600978F")]
	[Address(RVA = "0xDF7880", Offset = "0xDF6A80", VA = "0x180DF7880")]
	private static extern int DLL_DuelListGetSelectMax();

	[PreserveSig]
	[Token(Token = "0x6009790")]
	[Address(RVA = "0xDF78F0", Offset = "0xDF6AF0", VA = "0x180DF78F0")]
	private static extern int DLL_DuelListGetSelectMin();

	[PreserveSig]
	[Token(Token = "0x6009791")]
	[Address(RVA = "0xDF7690", Offset = "0xDF6890", VA = "0x180DF7690")]
	private static extern int DLL_DuelListGetItemMax();

	[PreserveSig]
	[Token(Token = "0x6009792")]
	[Address(RVA = "0xDF7610", Offset = "0xDF6810", VA = "0x180DF7610")]
	private static extern int DLL_DuelListGetItemID(int index);

	[PreserveSig]
	[Token(Token = "0x6009793")]
	[Address(RVA = "0xDF7800", Offset = "0xDF6A00", VA = "0x180DF7800")]
	private static extern int DLL_DuelListGetItemUniqueID(int index);

	[PreserveSig]
	[Token(Token = "0x6009794")]
	[Address(RVA = "0xDF7590", Offset = "0xDF6790", VA = "0x180DF7590")]
	private static extern int DLL_DuelListGetItemFrom(int index);

	[PreserveSig]
	[Token(Token = "0x6009795")]
	[Address(RVA = "0xDF7700", Offset = "0xDF6900", VA = "0x180DF7700")]
	private static extern int DLL_DuelListGetItemMsg(int index);

	[PreserveSig]
	[Token(Token = "0x6009796")]
	[Address(RVA = "0xDF7510", Offset = "0xDF6710", VA = "0x180DF7510")]
	private static extern int DLL_DuelListGetItemAttribute(int index);

	[PreserveSig]
	[Token(Token = "0x6009797")]
	[Address(RVA = "0xDF7480", Offset = "0xDF6680", VA = "0x180DF7480")]
	private static extern int DLL_DuelListGetCardAttribute(int iLookPlayer, int wUniqueID);

	[PreserveSig]
	[Token(Token = "0x6009798")]
	[Address(RVA = "0xDF7AD0", Offset = "0xDF6CD0", VA = "0x180DF7AD0")]
	private static extern void DLL_DuelListSetIndex(int index);

	[PreserveSig]
	[Token(Token = "0x6009799")]
	[Address(RVA = "0xDF7A40", Offset = "0xDF6C40", VA = "0x180DF7A40")]
	private static extern void DLL_DuelListSetCardExData(int index, int data);

	[PreserveSig]
	[Token(Token = "0x600979A")]
	[Address(RVA = "0xDF7780", Offset = "0xDF6980", VA = "0x180DF7780")]
	private static extern int DLL_DuelListGetItemTargetUniqueID(int index);

	[Token(Token = "0x600979B")]
	[Address(RVA = "0xE076F0", Offset = "0xE068F0", VA = "0x180E076F0")]
	public static bool ListIsMultiMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600979C")]
	[Address(RVA = "0xE072D0", Offset = "0xE064D0", VA = "0x180E072D0")]
	public static int ListGetSelectMax()
	{
		return default(int);
	}

	[Token(Token = "0x600979D")]
	[Address(RVA = "0xE074E0", Offset = "0xE066E0", VA = "0x180E074E0")]
	public static int ListGetSelectMin()
	{
		return default(int);
	}

	[Token(Token = "0x600979E")]
	[Address(RVA = "0xE06C10", Offset = "0xE05E10", VA = "0x180E06C10")]
	public static int ListGetItemMax()
	{
		return default(int);
	}

	[Token(Token = "0x600979F")]
	[Address(RVA = "0xE06B80", Offset = "0xE05D80", VA = "0x180E06B80")]
	public static int ListGetItemID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097A0")]
	[Address(RVA = "0xE071B0", Offset = "0xE063B0", VA = "0x180E071B0")]
	public static int ListGetItemTargetUniqueID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097A1")]
	[Address(RVA = "0xE07240", Offset = "0xE06440", VA = "0x180E07240")]
	public static int ListGetItemUniqueID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097A2")]
	[Address(RVA = "0xE06AF0", Offset = "0xE05CF0", VA = "0x180E06AF0")]
	public static int ListGetItemFrom(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097A3")]
	[Address(RVA = "0xE07120", Offset = "0xE06320", VA = "0x180E07120")]
	public static int ListGetItemMsg(int listIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60097A4")]
	[Address(RVA = "0xE06EC0", Offset = "0xE060C0", VA = "0x180E06EC0")]
	public static int ListGetItemMixNum(int listIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60097A5")]
	[Address(RVA = "0xE07080", Offset = "0xE06280", VA = "0x180E07080")]
	public static DialogMixTextType ListGetItemMixType(int listIdx, int mixIdx)
	{
		return default(DialogMixTextType);
	}

	[Token(Token = "0x60097A6")]
	[Address(RVA = "0xE06E20", Offset = "0xE06020", VA = "0x180E06E20")]
	public static int ListGetItemMixData(int listIdx, int mixIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60097A7")]
	[Address(RVA = "0xE06A60", Offset = "0xE05C60", VA = "0x180E06A60")]
	public static int ListGetItemAttribute(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097A8")]
	[Address(RVA = "0xE07900", Offset = "0xE06B00", VA = "0x180E07900")]
	public static void ListSendBlindIndex(int index)
	{
	}

	[Token(Token = "0x60097A9")]
	[Address(RVA = "0xE07C10", Offset = "0xE06E10", VA = "0x180E07C10")]
	public static void ListSendIndex(int index)
	{
	}

	[Token(Token = "0x60097AA")]
	[Address(RVA = "0xE06860", Offset = "0xE05A60", VA = "0x180E06860")]
	public static int ListGetCardAttribute(int lookPlayer, int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x60097AB")]
	[Address(RVA = "0xE07F20", Offset = "0xE07120", VA = "0x180E07F20")]
	public static void ListSendSelectMulti(int num, List<int> selected)
	{
	}

	[Token(Token = "0x60097AC")]
	[Address(RVA = "0xE31BA0", Offset = "0xE30DA0", VA = "0x180E31BA0")]
	private static int _PosToIdx(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097AD")]
	[Address(RVA = "0xE31F90", Offset = "0xE31190", VA = "0x180E31F90")]
	private static int _PosToUniqueId(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097AE")]
	[Address(RVA = "0xE31DB0", Offset = "0xE30FB0", VA = "0x180E31DB0")]
	private static PvpUIDBase _PosToUIDBase(int player, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x60097AF")]
	[Address(RVA = "0xE32110", Offset = "0xE31310", VA = "0x180E32110")]
	private static PvpUIDBase _UniqueIdToUIDBase(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60097B0")]
	[Address(RVA = "0xE0C060", Offset = "0xE0B260", VA = "0x180E0C060")]
	private static int PVP_DuelGetLP(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60097B1")]
	[Address(RVA = "0xE08CF0", Offset = "0xE07EF0", VA = "0x180E08CF0")]
	private static int PVP_DuelCanIDoPutMonster(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60097B2")]
	[Address(RVA = "0xE08F70", Offset = "0xE08170", VA = "0x180E08F70")]
	private static bool PVP_DuelCanIDoSummonMonster(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x60097B3")]
	[Address(RVA = "0xE08E30", Offset = "0xE08030", VA = "0x180E08E30")]
	private static bool PVP_DuelCanIDoSpecialSummon(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x60097B4")]
	[Address(RVA = "0xE0FBC0", Offset = "0xE0EDC0", VA = "0x180E0FBC0")]
	private static int PVP_DuelWhichTurnNow()
	{
		return default(int);
	}

	[Token(Token = "0x60097B5")]
	[Address(RVA = "0xE0B400", Offset = "0xE0A600", VA = "0x180E0B400")]
	private static Phase PVP_DuelGetCurrentPhase()
	{
		return default(Phase);
	}

	[Token(Token = "0x60097B6")]
	[Address(RVA = "0xE0B520", Offset = "0xE0A720", VA = "0x180E0B520")]
	private static StepType PVP_DuelGetCurrentStep()
	{
		return default(StepType);
	}

	[Token(Token = "0x60097B7")]
	[Address(RVA = "0xE0B2E0", Offset = "0xE0A4E0", VA = "0x180E0B2E0")]
	private static DmgStepType PVP_DuelGetCurrentDmgStep()
	{
		return default(DmgStepType);
	}

	[Token(Token = "0x60097B8")]
	[Address(RVA = "0xE0D0D0", Offset = "0xE0C2D0", VA = "0x180E0D0D0")]
	private static int PVP_DuelGetTurnNum()
	{
		return default(int);
	}

	[Token(Token = "0x60097B9")]
	[Address(RVA = "0xE10400", Offset = "0xE0F600", VA = "0x180E10400")]
	private static CardProp PVP_GetCardPropByUniqueID(int uniqueId)
	{
		return default(CardProp);
	}

	[Token(Token = "0x60097BA")]
	[Address(RVA = "0xE0ACC0", Offset = "0xE09EC0", VA = "0x180E0ACC0")]
	private static int PVP_DuelGetCardID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097BB")]
	[Address(RVA = "0xE0B080", Offset = "0xE0A280", VA = "0x180E0B080")]
	private static int PVP_DuelGetCardUniqueID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097BC")]
	[Address(RVA = "0xE0AF60", Offset = "0xE0A160", VA = "0x180E0AF60")]
	private static bool PVP_DuelGetCardTurn(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60097BD")]
	[Address(RVA = "0xE0A9C0", Offset = "0xE09BC0", VA = "0x180E0A9C0")]
	private static bool PVP_DuelGetCardFace(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60097BE")]
	[Address(RVA = "0xE0ADE0", Offset = "0xE09FE0", VA = "0x180E0ADE0")]
	private static int PVP_DuelGetCardNum(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097BF")]
	[Address(RVA = "0xE0CDD0", Offset = "0xE0BFD0", VA = "0x180E0CDD0")]
	private static int PVP_DuelGetThisMonsterFightableOnEffect(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097C0")]
	[Address(RVA = "0xE0D7F0", Offset = "0xE0C9F0", VA = "0x180E0D7F0")]
	private static int PVP_DuelIsThisEquipCard(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097C1")]
	[Address(RVA = "0xE0D670", Offset = "0xE0C870", VA = "0x180E0D670")]
	private static int PVP_DuelIsThisContinuousCard(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097C2")]
	[Address(RVA = "0xE0D970", Offset = "0xE0CB70", VA = "0x180E0D970")]
	private static int PVP_DuelIsThisMagic(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097C3")]
	[Address(RVA = "0xE0DDF0", Offset = "0xE0CFF0", VA = "0x180E0DDF0")]
	private static int PVP_DuelIsThisTrap(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097C4")]
	[Address(RVA = "0xE0D370", Offset = "0xE0C570", VA = "0x180E0D370")]
	private static int PVP_DuelIsMaximumMode(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097C5")]
	[Address(RVA = "0xE0CF50", Offset = "0xE0C150", VA = "0x180E0CF50")]
	private static int PVP_DuelGetTopCardIndex(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097C6")]
	[Address(RVA = "0xE0FAD0", Offset = "0xE0ECD0", VA = "0x180E0FAD0")]
	private static int PVP_DuelSearchCardByUniqueID(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x60097C7")]
	[Address(RVA = "0xE0AAE0", Offset = "0xE09CE0", VA = "0x180E0AAE0")]
	private static uint PVP_DuelGetCardIDByUniqueID(int uniqueId)
	{
		return default(uint);
	}

	[Token(Token = "0x60097C8")]
	[Address(RVA = "0xE0A820", Offset = "0xE09A20", VA = "0x180E0A820")]
	private static void PVP_DuelGetCardBasicVal(int player, int position, int index, ref BasicVal val)
	{
	}

	[Token(Token = "0x60097C9")]
	[Address(RVA = "0xE0D4F0", Offset = "0xE0C6F0", VA = "0x180E0D4F0")]
	private static bool PVP_DuelIsThisCardExist(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x60097CA")]
	[Address(RVA = "0xE0C670", Offset = "0xE0B870", VA = "0x180E0C670")]
	private static int PVP_DuelGetThisCardEffectIDAtChain(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097CB")]
	[Address(RVA = "0xE0A6F0", Offset = "0xE098F0", VA = "0x180E0A6F0")]
	private static int PVP_DuelGetAttackTargetMask(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097CC")]
	[Address(RVA = "0xE10530", Offset = "0xE0F730", VA = "0x180E10530")]
	private static AffectType[][] PVP_GetFieldAffectIcon(int player, int locate)
	{
		return null;
	}

	[Token(Token = "0x60097CD")]
	[Address(RVA = "0xE0C1A0", Offset = "0xE0B3A0", VA = "0x180E0C1A0")]
	private static int PVP_DuelGetThisCardCounter(int player, int locate, CounterType type)
	{
		return default(int);
	}

	[Token(Token = "0x60097CE")]
	[Address(RVA = "0xE10A30", Offset = "0xE0FC30", VA = "0x180E10A30")]
	private static int[] PVP_GetThisCardEffectList(int player, int locate)
	{
		return null;
	}

	[Token(Token = "0x60097CF")]
	[Address(RVA = "0xE088B0", Offset = "0xE07AB0", VA = "0x180E088B0")]
	private static uint PVP_DUELCOMGetPosMaskOfThisHand(int player, int index, int commandId)
	{
		return default(uint);
	}

	[Token(Token = "0x60097D0")]
	[Address(RVA = "0xE0CC40", Offset = "0xE0BE40", VA = "0x180E0CC40")]
	private static int PVP_DuelGetThisCardTurnCounter(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097D1")]
	[Address(RVA = "0xE0DAF0", Offset = "0xE0CCF0", VA = "0x180E0DAF0")]
	private static bool PVP_DuelIsThisNormalMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x60097D2")]
	[Address(RVA = "0xE0DC70", Offset = "0xE0CE70", VA = "0x180E0DC70")]
	private static bool PVP_DuelIsThisTrapMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x60097D3")]
	[Address(RVA = "0xE0DF70", Offset = "0xE0D170", VA = "0x180E0DF70")]
	private static bool PVP_DuelIsThisTunerMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x60097D4")]
	[Address(RVA = "0xE0C4F0", Offset = "0xE0B6F0", VA = "0x180E0C4F0")]
	private static int PVP_DuelGetThisCardEffectFlags(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097D5")]
	[Address(RVA = "0xE0B760", Offset = "0xE0A960", VA = "0x180E0B760")]
	private static int PVP_DuelGetFldMonstOrgLevel(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097D6")]
	[Address(RVA = "0xE0BA60", Offset = "0xE0AC60", VA = "0x180E0BA60")]
	private static int PVP_DuelGetFldMonstOrgType(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097D7")]
	[Address(RVA = "0xE0BEE0", Offset = "0xE0B0E0", VA = "0x180E0BEE0")]
	private static int PVP_DuelGetFldPendScale(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097D8")]
	[Address(RVA = "0xE0BD60", Offset = "0xE0AF60", VA = "0x180E0BD60")]
	private static int PVP_DuelGetFldPendOrgScale(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097D9")]
	[Address(RVA = "0xE0BBE0", Offset = "0xE0ADE0", VA = "0x180E0BBE0")]
	private static int PVP_DuelGetFldMonstRank(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097DA")]
	[Address(RVA = "0xE0B8E0", Offset = "0xE0AAE0", VA = "0x180E0B8E0")]
	private static int PVP_DuelGetFldMonstOrgRank(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097DB")]
	[Address(RVA = "0xE0C7C0", Offset = "0xE0B9C0", VA = "0x180E0C7C0")]
	private static int PVP_DuelGetThisCardOverlayNum(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097DC")]
	[Address(RVA = "0xE0E330", Offset = "0xE0D530", VA = "0x180E0E330")]
	private static bool PVP_DuelIsThisZoneAvailable(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x60097DD")]
	[Address(RVA = "0xE0E0F0", Offset = "0xE0D2F0", VA = "0x180E0E0F0")]
	private static bool PVP_DuelIsThisZoneAvailable2(int player, int locate, bool visibleOnly)
	{
		return default(bool);
	}

	[Token(Token = "0x60097DE")]
	[Address(RVA = "0xE0CAC0", Offset = "0xE0BCC0", VA = "0x180E0CAC0")]
	private static ShowParam PVP_DuelGetThisCardShowParameter(int player, int locate)
	{
		return default(ShowParam);
	}

	[Token(Token = "0x60097DF")]
	[Address(RVA = "0xE0C940", Offset = "0xE0BB40", VA = "0x180E0C940")]
	private static uint PVP_DuelGetThisCardParameter(int player, int locate)
	{
		return default(uint);
	}

	[Token(Token = "0x60097E0")]
	[Address(RVA = "0xE0C370", Offset = "0xE0B570", VA = "0x180E0C370")]
	private static int PVP_DuelGetThisCardDirectFlag(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x60097E1")]
	[Address(RVA = "0xE090B0", Offset = "0xE082B0", VA = "0x180E090B0")]
	private static uint PVP_DuelComGetCommandMask(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x60097E2")]
	[Address(RVA = "0xE09860", Offset = "0xE08A60", VA = "0x180E09860")]
	private static uint PVP_DuelComGettextIDOfThisCommand(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x60097E3")]
	[Address(RVA = "0xE09600", Offset = "0xE08800", VA = "0x180E09600")]
	private static uint PVP_DuelComGetTextIDOfThisSummon(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x60097E4")]
	[Address(RVA = "0xE08690", Offset = "0xE07890", VA = "0x180E08690")]
	private static void PVP_ComDoCommand(int player, int position, int index, CommandType commandId)
	{
	}

	[Token(Token = "0x60097E5")]
	[Address(RVA = "0xE09390", Offset = "0xE08590", VA = "0x180E09390")]
	private static uint PVP_DuelComGetMovablePhase()
	{
		return default(uint);
	}

	[Token(Token = "0x60097E6")]
	[Address(RVA = "0xE085A0", Offset = "0xE077A0", VA = "0x180E085A0")]
	private static int PVP_CardRareGetRareByUniqueID(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x60097E7")]
	[Address(RVA = "0xE10CD0", Offset = "0xE0FED0", VA = "0x180E10CD0")]
	private static void PVP_SetRareByUniqueID(int uniqueId, int rare)
	{
	}

	[Token(Token = "0x60097E8")]
	[Address(RVA = "0xE08AE0", Offset = "0xE07CE0", VA = "0x180E08AE0")]
	private static void PVP_DequeDlgMixData()
	{
	}

	[Token(Token = "0x60097E9")]
	[Address(RVA = "0xE09E30", Offset = "0xE09030", VA = "0x180E09E30")]
	private static int PVP_DuelDlgGetMixNum()
	{
		return default(int);
	}

	[Token(Token = "0x60097EA")]
	[Address(RVA = "0xE09F70", Offset = "0xE09170", VA = "0x180E09F70")]
	private static DialogMixTextType PVP_DuelDlgGetMixType(int index)
	{
		return default(DialogMixTextType);
	}

	[Token(Token = "0x60097EB")]
	[Address(RVA = "0xE09CC0", Offset = "0xE08EC0", VA = "0x180E09CC0")]
	private static int PVP_DuelDlgGetMixData(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097EC")]
	[Address(RVA = "0xE0F2D0", Offset = "0xE0E4D0", VA = "0x180E0F2D0")]
	private static int PVP_DuelListGetItemMsg(int listIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60097ED")]
	[Address(RVA = "0xE0EEE0", Offset = "0xE0E0E0", VA = "0x180E0EEE0")]
	private static int PVP_DuelListGetItemMixNum(int listIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60097EE")]
	[Address(RVA = "0xE0F0C0", Offset = "0xE0E2C0", VA = "0x180E0F0C0")]
	private static DialogMixTextType PVP_DuelListGetItemMixType(int listIdx, int mixIdx)
	{
		return default(DialogMixTextType);
	}

	[Token(Token = "0x60097EF")]
	[Address(RVA = "0xE0ECD0", Offset = "0xE0DED0", VA = "0x180E0ECD0")]
	private static int PVP_DuelListGetItemMixData(int listIdx, int mixIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60097F0")]
	[Address(RVA = "0xE09B60", Offset = "0xE08D60", VA = "0x180E09B60")]
	private static bool PVP_DuelDlgCanYesNoSkip()
	{
		return default(bool);
	}

	[Token(Token = "0x60097F1")]
	[Address(RVA = "0xE0A0E0", Offset = "0xE092E0", VA = "0x180E0A0E0")]
	private static uint PVP_DuelDlgGetPosMaskOfThisSummon()
	{
		return default(uint);
	}

	[Token(Token = "0x60097F2")]
	[Address(RVA = "0xE0A3C0", Offset = "0xE095C0", VA = "0x180E0A3C0")]
	private static int PVP_DuelDlgGetSelectItemNum()
	{
		return default(int);
	}

	[Token(Token = "0x60097F3")]
	[Address(RVA = "0xE0A490", Offset = "0xE09690", VA = "0x180E0A490")]
	private static int PVP_DuelDlgGetSelectItemStr(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097F4")]
	[Address(RVA = "0xE0A2E0", Offset = "0xE094E0", VA = "0x180E0A2E0")]
	private static bool PVP_DuelDlgGetSelectItemEnable(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60097F5")]
	[Address(RVA = "0xE0A200", Offset = "0xE09400", VA = "0x180E0A200")]
	private static bool PVP_DuelDlgGetSelectItemDefault(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60097F6")]
	[Address(RVA = "0xE08C20", Offset = "0xE07E20", VA = "0x180E08C20")]
	private static int PVP_DlgProcGetSummoningMonsterUniqueID()
	{
		return default(int);
	}

	[Token(Token = "0x60097F7")]
	[Address(RVA = "0xE0F9E0", Offset = "0xE0EBE0", VA = "0x180E0F9E0")]
	private static bool PVP_DuelListIsMultiMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60097F8")]
	[Address(RVA = "0xE0F840", Offset = "0xE0EA40", VA = "0x180E0F840")]
	private static int PVP_DuelListGetSelectMax()
	{
		return default(int);
	}

	[Token(Token = "0x60097F9")]
	[Address(RVA = "0xE0F910", Offset = "0xE0EB10", VA = "0x180E0F910")]
	private static int PVP_DuelListGetSelectMin()
	{
		return default(int);
	}

	[Token(Token = "0x60097FA")]
	[Address(RVA = "0xE0EC00", Offset = "0xE0DE00", VA = "0x180E0EC00")]
	private static int PVP_DuelListGetItemMax()
	{
		return default(int);
	}

	[Token(Token = "0x60097FB")]
	[Address(RVA = "0xE0EA30", Offset = "0xE0DC30", VA = "0x180E0EA30")]
	private static int PVP_DuelListGetItemID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097FC")]
	[Address(RVA = "0xE0F670", Offset = "0xE0E870", VA = "0x180E0F670")]
	private static int PVP_DuelListGetItemUniqueID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097FD")]
	[Address(RVA = "0xE0E680", Offset = "0xE0D880", VA = "0x180E0E680")]
	private static int PVP_DuelListGetItemAttribute(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097FE")]
	[Address(RVA = "0xE0E850", Offset = "0xE0DA50", VA = "0x180E0E850")]
	private static int PVP_DuelListGetItemFrom(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60097FF")]
	[Address(RVA = "0xE0E4B0", Offset = "0xE0D6B0", VA = "0x180E0E4B0")]
	private static int PVP_DuelListGetCardAttribute(int lookPlayer, int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x6009800")]
	[Address(RVA = "0xE0F4A0", Offset = "0xE0E6A0", VA = "0x180E0F4A0")]
	private static int PVP_DuelListGetItemTargetUniqueID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009801")]
	[Address(RVA = "0xE0FCE0", Offset = "0xE0EEE0", VA = "0x180E0FCE0")]
	private static int[] PVP_FusionGetMaterialList()
	{
		return null;
	}

	[Token(Token = "0x6009802")]
	[Address(RVA = "0xE10220", Offset = "0xE0F420", VA = "0x180E10220")]
	private static int PVP_FusionIsThisTunedMonsterInTuning()
	{
		return default(int);
	}

	[Token(Token = "0x6009803")]
	[Address(RVA = "0xE10040", Offset = "0xE0F240", VA = "0x180E10040")]
	private static int PVP_FusionGetMonsterLevelInTuning()
	{
		return default(int);
	}

	[Token(Token = "0x6009804")]
	[Address(RVA = "0xE094F0", Offset = "0xE086F0", VA = "0x180E094F0")]
	private static int PVP_DuelComGetRecommendSide()
	{
		return default(int);
	}

	[Token(Token = "0x6009805")]
	[Address(RVA = "0xE0B640", Offset = "0xE0A840", VA = "0x180E0B640")]
	private static bool PVP_DuelGetDuelFlagDeckReverse()
	{
		return default(bool);
	}

	[Token(Token = "0x6009806")]
	[Address(RVA = "0xE0A570", Offset = "0xE09770", VA = "0x180E0A570")]
	private static AffectProp[] PVP_DuelGetAttachedEffectList()
	{
		return null;
	}

	[Token(Token = "0x6009807")]
	[Address(RVA = "0xE10C50", Offset = "0xE0FE50", VA = "0x180E10C50")]
	public static bool PVP_IsSysActLoopExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6009808")]
	[Address(RVA = "0xE0D1F0", Offset = "0xE0C3F0", VA = "0x180E0D1F0")]
	private static uint PVP_DuelInfoTimeLeft()
	{
		return default(uint);
	}

	[Token(Token = "0x6009809")]
	[Address(RVA = "0xE0D2B0", Offset = "0xE0C4B0", VA = "0x180E0D2B0")]
	private static uint PVP_DuelInfoTimeTotal()
	{
		return default(uint);
	}

	[Token(Token = "0x600980A")]
	[Address(RVA = "0xE10E30", Offset = "0xE10030", VA = "0x180E10E30")]
	public static bool PvpAct(bool init = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600980B")]
	[Address(RVA = "0xE2A080", Offset = "0xE29280", VA = "0x180E2A080")]
	private static ViewType getBusyCheckType(ViewType id)
	{
		return default(ViewType);
	}

	[Token(Token = "0x600980C")]
	[Address(RVA = "0xE325D0", Offset = "0xE317D0", VA = "0x180E325D0")]
	private static bool checkFlag(BinaryReader br, List<byte> updateFlag, ref int count)
	{
		return default(bool);
	}

	[Token(Token = "0x600980D")]
	[Address(RVA = "0xE32700", Offset = "0xE31900", VA = "0x180E32700")]
	private static bool checkFlag(List<byte> flags, ref int count)
	{
		return default(bool);
	}

	[Token(Token = "0x600980E")]
	[Address(RVA = "0xE15D80", Offset = "0xE14F80", VA = "0x180E15D80")]
	private static void PvpUpdateEngineData(PvpFieldType type, byte[] data, int n, int player)
	{
	}

	[Token(Token = "0x600980F")]
	[Address(RVA = "0xE13600", Offset = "0xE12800", VA = "0x180E13600")]
	private static PvpDialogData PvpParseDialogData(BinaryReader br)
	{
		return null;
	}

	[Token(Token = "0x6009810")]
	[Address(RVA = "0xE13BD0", Offset = "0xE12DD0", VA = "0x180E13BD0")]
	private static PvpListData PvpParseListData(BinaryReader br)
	{
		return null;
	}

	[Token(Token = "0x6009811")]
	[Address(RVA = "0xE139B0", Offset = "0xE12BB0", VA = "0x180E139B0")]
	private static PvpFusionData PvpParseFusionData(BinaryReader br)
	{
		return null;
	}

	[Token(Token = "0x6009812")]
	[Address(RVA = "0xE14310", Offset = "0xE13510", VA = "0x180E14310")]
	public static void PvpParseRecvData(byte[] recvData)
	{
	}

	[Token(Token = "0x6009813")]
	[Address(RVA = "0xE13400", Offset = "0xE12600", VA = "0x180E13400")]
	private void PvpInit()
	{
	}

	[Token(Token = "0x6009814")]
	[Address(RVA = "0xE15D40", Offset = "0xE14F40", VA = "0x180E15D40")]
	private void PvpRelease()
	{
	}

	[Token(Token = "0x6009815")]
	[Address(RVA = "0xE13530", Offset = "0xE12730", VA = "0x180E13530")]
	public static bool PvpIsQueued()
	{
		return default(bool);
	}

	[Token(Token = "0x6009816")]
	[Address(RVA = "0xE13470", Offset = "0xE12670", VA = "0x180E13470")]
	public static bool PvpInputGuard()
	{
		return default(bool);
	}

	[Token(Token = "0x6009817")]
	[Address(RVA = "0xE29E10", Offset = "0xE29010", VA = "0x180E29E10")]
	private static CardProp THREAD_ToCardPropNoSerial(CardPropSerial serialCard)
	{
		return default(CardProp);
	}

	[Token(Token = "0x6009818")]
	[Address(RVA = "0xE29D80", Offset = "0xE28F80", VA = "0x180E29D80")]
	private static BasicVal THREAD_ToBasicValNoSerial(BasicValSerial serialVal)
	{
		return default(BasicVal);
	}

	[Token(Token = "0x6009819")]
	[Address(RVA = "0xE29D10", Offset = "0xE28F10", VA = "0x180E29D10")]
	private static AffectProp THREAD_ToAffectPropNoSerial(AffectPropSerial serialVal)
	{
		return default(AffectProp);
	}

	[Token(Token = "0x600981A")]
	[Address(RVA = "0xE28E70", Offset = "0xE28070", VA = "0x180E28E70")]
	private static int THREAD_PosToIdx(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600981B")]
	[Address(RVA = "0xE291E0", Offset = "0xE283E0", VA = "0x180E291E0")]
	private static int THREAD_PosToUniqueId(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600981C")]
	[Address(RVA = "0xE29040", Offset = "0xE28240", VA = "0x180E29040")]
	private static ThreadUIDBase THREAD_PosToUIDBase(int player, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600981D")]
	[Address(RVA = "0xE29EF0", Offset = "0xE290F0", VA = "0x180E29EF0")]
	private static ThreadUIDBase THREAD_UniqueIdToUIDBase(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600981E")]
	[Address(RVA = "0xE28190", Offset = "0xE27390", VA = "0x180E28190")]
	private static int THREAD_DuelWhichTurnNow()
	{
		return default(int);
	}

	[Token(Token = "0x600981F")]
	[Address(RVA = "0xE24770", Offset = "0xE23970", VA = "0x180E24770")]
	private static Phase THREAD_DuelGetCurrentPhase()
	{
		return default(Phase);
	}

	[Token(Token = "0x6009820")]
	[Address(RVA = "0xE24850", Offset = "0xE23A50", VA = "0x180E24850")]
	private static StepType THREAD_DuelGetCurrentStep()
	{
		return default(StepType);
	}

	[Token(Token = "0x6009821")]
	[Address(RVA = "0xE24690", Offset = "0xE23890", VA = "0x180E24690")]
	private static DmgStepType THREAD_DuelGetCurrentDmgStep()
	{
		return default(DmgStepType);
	}

	[Token(Token = "0x6009822")]
	[Address(RVA = "0xE25F00", Offset = "0xE25100", VA = "0x180E25F00")]
	private static int THREAD_DuelGetTurnNum()
	{
		return default(int);
	}

	[Token(Token = "0x6009823")]
	[Address(RVA = "0xE25190", Offset = "0xE24390", VA = "0x180E25190")]
	private static int THREAD_DuelGetLP(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009824")]
	[Address(RVA = "0xE22230", Offset = "0xE21430", VA = "0x180E22230")]
	private static int THREAD_DuelCanIDoPutMonster(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009825")]
	[Address(RVA = "0xE23850", Offset = "0xE22A50", VA = "0x180E23850")]
	private static AffectProp[] THREAD_DuelGetAttachedEffectList()
	{
		return null;
	}

	[Token(Token = "0x6009826")]
	[Address(RVA = "0xE22450", Offset = "0xE21650", VA = "0x180E22450")]
	private static bool THREAD_DuelCanIDoSummonMonster(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x6009827")]
	[Address(RVA = "0xE22340", Offset = "0xE21540", VA = "0x180E22340")]
	private static bool THREAD_DuelCanIDoSpecialSummon(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x6009828")]
	[Address(RVA = "0xE28710", Offset = "0xE27910", VA = "0x180E28710")]
	private static CardProp THREAD_GetCardPropByUniqueID(int uniqueId)
	{
		return default(CardProp);
	}

	[Token(Token = "0x6009829")]
	[Address(RVA = "0xE24150", Offset = "0xE23350", VA = "0x180E24150")]
	private static int THREAD_DuelGetCardID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600982A")]
	[Address(RVA = "0xE244B0", Offset = "0xE236B0", VA = "0x180E244B0")]
	private static int THREAD_DuelGetCardUniqueID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600982B")]
	[Address(RVA = "0xE243D0", Offset = "0xE235D0", VA = "0x180E243D0")]
	private static bool THREAD_DuelGetCardTurn(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600982C")]
	[Address(RVA = "0xE23E90", Offset = "0xE23090", VA = "0x180E23E90")]
	private static bool THREAD_DuelGetCardFace(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600982D")]
	[Address(RVA = "0xE24290", Offset = "0xE23490", VA = "0x180E24290")]
	private static int THREAD_DuelGetCardNum(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600982E")]
	[Address(RVA = "0xE25C80", Offset = "0xE24E80", VA = "0x180E25C80")]
	private static bool THREAD_DuelGetThisMonsterFightableOnEffect(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x600982F")]
	[Address(RVA = "0xE263A0", Offset = "0xE255A0", VA = "0x180E263A0")]
	private static int THREAD_DuelIsThisEquipCard(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009830")]
	[Address(RVA = "0xE26260", Offset = "0xE25460", VA = "0x180E26260")]
	private static int THREAD_DuelIsThisContinuousCard(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009831")]
	[Address(RVA = "0xE264E0", Offset = "0xE256E0", VA = "0x180E264E0")]
	private static bool THREAD_DuelIsThisMagic(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009832")]
	[Address(RVA = "0xE268A0", Offset = "0xE25AA0", VA = "0x180E268A0")]
	private static bool THREAD_DuelIsThisTrap(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009833")]
	[Address(RVA = "0xE25FE0", Offset = "0xE251E0", VA = "0x180E25FE0")]
	private static bool THREAD_DuelIsMaximumMode(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009834")]
	[Address(RVA = "0xE25DC0", Offset = "0xE24FC0", VA = "0x180E25DC0")]
	private static int THREAD_DuelGetTopCardIndex(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009835")]
	[Address(RVA = "0xE280D0", Offset = "0xE272D0", VA = "0x180E280D0")]
	private static int THREAD_DuelSearchCardByUniqueID(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x6009836")]
	[Address(RVA = "0xE23F70", Offset = "0xE23170", VA = "0x180E23F70")]
	private static uint THREAD_DuelGetCardIDByUniqueID(int uniqueId)
	{
		return default(uint);
	}

	[Token(Token = "0x6009837")]
	[Address(RVA = "0xE23C90", Offset = "0xE22E90", VA = "0x180E23C90")]
	private static void THREAD_DuelGetCardBasicVal(int player, int position, int index, ref BasicVal val)
	{
	}

	[Token(Token = "0x6009838")]
	[Address(RVA = "0xE26120", Offset = "0xE25320", VA = "0x180E26120")]
	private static bool THREAD_DuelIsThisCardExist(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009839")]
	[Address(RVA = "0xE256B0", Offset = "0xE248B0", VA = "0x180E256B0")]
	private static int THREAD_DuelGetThisCardEffectIDAtChain(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600983A")]
	[Address(RVA = "0xE23B10", Offset = "0xE22D10", VA = "0x180E23B10")]
	private static int THREAD_DuelGetAttackTargetMask(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600983B")]
	[Address(RVA = "0xE28830", Offset = "0xE27A30", VA = "0x180E28830")]
	private static AffectType[][] THREAD_GetFieldAffectIcon(int player, int position)
	{
		return null;
	}

	[Token(Token = "0x600983C")]
	[Address(RVA = "0xE29330", Offset = "0xE28530", VA = "0x180E29330")]
	private static void THREAD_SetFieldAffectIcon()
	{
	}

	[Token(Token = "0x600983D")]
	[Address(RVA = "0xE252A0", Offset = "0xE244A0", VA = "0x180E252A0")]
	private static int THREAD_DuelGetThisCardCounter(int player, int locate, CounterType type)
	{
		return default(int);
	}

	[Token(Token = "0x600983E")]
	[Address(RVA = "0xE28A30", Offset = "0xE27C30", VA = "0x180E28A30")]
	private static int[] THREAD_GetThisCardEffectList(int player, int locate)
	{
		return null;
	}

	[Token(Token = "0x600983F")]
	[Address(RVA = "0xE21F60", Offset = "0xE21160", VA = "0x180E21F60")]
	private static uint THREAD_DUELCOMGetPosMaskOfThisHand(int player, int index, int commandId)
	{
		return default(uint);
	}

	[Token(Token = "0x6009840")]
	[Address(RVA = "0xE25B40", Offset = "0xE24D40", VA = "0x180E25B40")]
	private static int THREAD_DuelGetThisCardTurnCounter(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009841")]
	[Address(RVA = "0xE26620", Offset = "0xE25820", VA = "0x180E26620")]
	private static bool THREAD_DuelIsThisNormalMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009842")]
	[Address(RVA = "0xE26760", Offset = "0xE25960", VA = "0x180E26760")]
	private static bool THREAD_DuelIsThisTrapMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009843")]
	[Address(RVA = "0xE269E0", Offset = "0xE25BE0", VA = "0x180E269E0")]
	private static bool THREAD_DuelIsThisTunerMonster(int player, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x6009844")]
	[Address(RVA = "0xE25570", Offset = "0xE24770", VA = "0x180E25570")]
	private static int THREAD_DuelGetThisCardEffectFlags(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009845")]
	[Address(RVA = "0xE24A10", Offset = "0xE23C10", VA = "0x180E24A10")]
	private static int THREAD_DuelGetFldMonstOrgLevel(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009846")]
	[Address(RVA = "0xE24C90", Offset = "0xE23E90", VA = "0x180E24C90")]
	private static int THREAD_DuelGetFldMonstOrgType(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009847")]
	[Address(RVA = "0xE25050", Offset = "0xE24250", VA = "0x180E25050")]
	private static int THREAD_DuelGetFldPendScale(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009848")]
	[Address(RVA = "0xE24F10", Offset = "0xE24110", VA = "0x180E24F10")]
	private static int THREAD_DuelGetFldPendOrgScale(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009849")]
	[Address(RVA = "0xE24DD0", Offset = "0xE23FD0", VA = "0x180E24DD0")]
	private static int THREAD_DuelGetFldMonstRank(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600984A")]
	[Address(RVA = "0xE24B50", Offset = "0xE23D50", VA = "0x180E24B50")]
	private static int THREAD_DuelGetFldMonstOrgRank(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600984B")]
	[Address(RVA = "0xE257C0", Offset = "0xE249C0", VA = "0x180E257C0")]
	private static int THREAD_DuelGetThisCardOverlayNum(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x600984C")]
	[Address(RVA = "0xE26B20", Offset = "0xE25D20", VA = "0x180E26B20")]
	private static bool THREAD_DuelIsThisZoneAvailable(int player, int locate, bool visibleOnly = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600984D")]
	[Address(RVA = "0xE25A20", Offset = "0xE24C20", VA = "0x180E25A20")]
	private static ShowParam THREAD_DuelGetThisCardShowParameter(int player, int locate)
	{
		return default(ShowParam);
	}

	[Token(Token = "0x600984E")]
	[Address(RVA = "0xE25900", Offset = "0xE24B00", VA = "0x180E25900")]
	private static uint THREAD_DuelGetThisCardParameter(int player, int locate)
	{
		return default(uint);
	}

	[Token(Token = "0x600984F")]
	[Address(RVA = "0xE25450", Offset = "0xE24650", VA = "0x180E25450")]
	private static int THREAD_DuelGetThisCardDirectFlag(int player, int locate)
	{
		return default(int);
	}

	[Token(Token = "0x6009850")]
	[Address(RVA = "0xE22560", Offset = "0xE21760", VA = "0x180E22560")]
	private static uint THREAD_DuelComGetCommandMask(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009851")]
	[Address(RVA = "0xE22990", Offset = "0xE21B90", VA = "0x180E22990")]
	private static uint THREAD_DuelComGetTextIDOfThisCommand(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009852")]
	[Address(RVA = "0xE22C10", Offset = "0xE21E10", VA = "0x180E22C10")]
	private static uint THREAD_DuelComGetTextIDOfThisSummon(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009853")]
	[Address(RVA = "0xE21D40", Offset = "0xE20F40", VA = "0x180E21D40")]
	private static void THREAD_ComDoCommand(int player, int position, int index, int commandId)
	{
	}

	[Token(Token = "0x6009854")]
	[Address(RVA = "0xE21C80", Offset = "0xE20E80", VA = "0x180E21C80")]
	private static bool THREAD_ComCancelCommand(bool decide)
	{
		return default(bool);
	}

	[Token(Token = "0x6009855")]
	[Address(RVA = "0xE21EA0", Offset = "0xE210A0", VA = "0x180E21EA0")]
	private static void THREAD_ComMovePhase(int phase)
	{
	}

	[Token(Token = "0x6009856")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private static void THREAD_DuelComDebugCommand()
	{
	}

	[Token(Token = "0x6009857")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private static void THREAD_DuelComDoDebugCommand(int player, int position, int index, int commandId)
	{
	}

	[Token(Token = "0x6009858")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private static void THREAD_DuelComCheatCard(int player, int position, int index, int cardId, int face, int turn)
	{
	}

	[Token(Token = "0x6009859")]
	[Address(RVA = "0xE227D0", Offset = "0xE219D0", VA = "0x180E227D0")]
	private static uint THREAD_DuelComGetMovablePhase()
	{
		return default(uint);
	}

	[Token(Token = "0x600985A")]
	[Address(RVA = "0xE23790", Offset = "0xE22990", VA = "0x180E23790")]
	private static void THREAD_DuelDlgSetResult(uint result)
	{
	}

	[Token(Token = "0x600985B")]
	[Address(RVA = "0xE230B0", Offset = "0xE222B0", VA = "0x180E230B0")]
	private static int THREAD_DuelDlgGetMixNum()
	{
		return default(int);
	}

	[Token(Token = "0x600985C")]
	[Address(RVA = "0xE23190", Offset = "0xE22390", VA = "0x180E23190")]
	private static DialogMixTextType THREAD_DuelDlgGetMixType(int index)
	{
		return default(DialogMixTextType);
	}

	[Token(Token = "0x600985D")]
	[Address(RVA = "0xE22F70", Offset = "0xE22170", VA = "0x180E22F70")]
	private static int THREAD_DuelDlgGetMixData(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600985E")]
	[Address(RVA = "0xE279A0", Offset = "0xE26BA0", VA = "0x180E279A0")]
	private static int THREAD_DuelListGetItemMsg(int listIdx)
	{
		return default(int);
	}

	[Token(Token = "0x600985F")]
	[Address(RVA = "0xE27660", Offset = "0xE26860", VA = "0x180E27660")]
	private static int THREAD_DuelListGetItemMixNum(int listIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6009860")]
	[Address(RVA = "0xE277B0", Offset = "0xE269B0", VA = "0x180E277B0")]
	private static DialogMixTextType THREAD_DuelListGetItemMixType(int listIdx, int mixIdx)
	{
		return default(DialogMixTextType);
	}

	[Token(Token = "0x6009861")]
	[Address(RVA = "0xE27470", Offset = "0xE26670", VA = "0x180E27470")]
	private static int THREAD_DuelListGetItemMixData(int listIdx, int mixIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6009862")]
	[Address(RVA = "0xE228B0", Offset = "0xE21AB0", VA = "0x180E228B0")]
	private static int THREAD_DuelComGetRecommendSide()
	{
		return default(int);
	}

	[Token(Token = "0x6009863")]
	[Address(RVA = "0xE24930", Offset = "0xE23B30", VA = "0x180E24930")]
	private static bool THREAD_DuelGetDuelFlagDeckReverse()
	{
		return default(bool);
	}

	[Token(Token = "0x6009864")]
	[Address(RVA = "0xE22ED0", Offset = "0xE220D0", VA = "0x180E22ED0")]
	private static bool THREAD_DuelDlgCanYesNoSkip()
	{
		return default(bool);
	}

	[Token(Token = "0x6009865")]
	[Address(RVA = "0xE232D0", Offset = "0xE224D0", VA = "0x180E232D0")]
	private static uint THREAD_DuelDlgGetPosMaskOfThisSummon()
	{
		return default(uint);
	}

	[Token(Token = "0x6009866")]
	[Address(RVA = "0xE235B0", Offset = "0xE227B0", VA = "0x180E235B0")]
	private static int THREAD_DuelDlgGetSelectItemNum()
	{
		return default(int);
	}

	[Token(Token = "0x6009867")]
	[Address(RVA = "0xE23690", Offset = "0xE22890", VA = "0x180E23690")]
	private static int THREAD_DuelDlgGetSelectItemStr(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009868")]
	[Address(RVA = "0xE234B0", Offset = "0xE226B0", VA = "0x180E234B0")]
	private static bool THREAD_DuelDlgGetSelectItemEnable(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6009869")]
	[Address(RVA = "0xE233B0", Offset = "0xE225B0", VA = "0x180E233B0")]
	private static bool THREAD_DuelDlgGetSelectItemDefault(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600986A")]
	[Address(RVA = "0xE22190", Offset = "0xE21390", VA = "0x180E22190")]
	private static int THREAD_DlgProcGetSummoningMonsterUniqueID()
	{
		return default(int);
	}

	[Token(Token = "0x600986B")]
	[Address(RVA = "0xE28010", Offset = "0xE27210", VA = "0x180E28010")]
	private static bool THREAD_DuelListIsMultiMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600986C")]
	[Address(RVA = "0xE27E50", Offset = "0xE27050", VA = "0x180E27E50")]
	private static int THREAD_DuelListGetSelectMax()
	{
		return default(int);
	}

	[Token(Token = "0x600986D")]
	[Address(RVA = "0xE27F30", Offset = "0xE27130", VA = "0x180E27F30")]
	private static int THREAD_DuelListGetSelectMin()
	{
		return default(int);
	}

	[Token(Token = "0x600986E")]
	[Address(RVA = "0xE27390", Offset = "0xE26590", VA = "0x180E27390")]
	private static int THREAD_DuelListGetItemMax()
	{
		return default(int);
	}

	[Token(Token = "0x600986F")]
	[Address(RVA = "0xE27CC0", Offset = "0xE26EC0", VA = "0x180E27CC0")]
	private static int THREAD_DuelListGetItemUniqueID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009870")]
	[Address(RVA = "0xE26ED0", Offset = "0xE260D0", VA = "0x180E26ED0")]
	private static int THREAD_DuelListGetItemAttribute(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009871")]
	[Address(RVA = "0xE27060", Offset = "0xE26260", VA = "0x180E27060")]
	private static int THREAD_DuelListGetItemFrom(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009872")]
	[Address(RVA = "0xE27200", Offset = "0xE26400", VA = "0x180E27200")]
	private static int THREAD_DuelListGetItemID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009873")]
	[Address(RVA = "0xE27B30", Offset = "0xE26D30", VA = "0x180E27B30")]
	private static int THREAD_DuelListGetItemTargetUniqueID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6009874")]
	[Address(RVA = "0xE26D30", Offset = "0xE25F30", VA = "0x180E26D30")]
	private static int THREAD_DuelListGetCardAttribute(int lookPlayer, int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x6009875")]
	[Address(RVA = "0xE28BF0", Offset = "0xE27DF0", VA = "0x180E28BF0")]
	private static void THREAD_ListSendBlindIndex(int index)
	{
	}

	[Token(Token = "0x6009876")]
	[Address(RVA = "0xE28CB0", Offset = "0xE27EB0", VA = "0x180E28CB0")]
	private static void THREAD_ListSendIndex(int index)
	{
	}

	[Token(Token = "0x6009877")]
	[Address(RVA = "0xE28D70", Offset = "0xE27F70", VA = "0x180E28D70")]
	private static void THREAD_ListSendSelectMulti(int num, List<int> selected)
	{
	}

	[Token(Token = "0x6009878")]
	[Address(RVA = "0xE28270", Offset = "0xE27470", VA = "0x180E28270")]
	private static int[] THREAD_FusionGetMaterialList()
	{
		return null;
	}

	[Token(Token = "0x6009879")]
	[Address(RVA = "0xE28620", Offset = "0xE27820", VA = "0x180E28620")]
	private static int THREAD_FusionIsThisTunedMonsterInTuning()
	{
		return default(int);
	}

	[Token(Token = "0x600987A")]
	[Address(RVA = "0xE28530", Offset = "0xE27730", VA = "0x180E28530")]
	private static int THREAD_FusionGetMonsterLevelInTuning()
	{
		return default(int);
	}

	[Token(Token = "0x600987B")]
	[Address(RVA = "0xE22DE0", Offset = "0xE21FE0", VA = "0x180E22DE0")]
	private static bool THREAD_DuelCpuSysCheckFinishAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x600987C")]
	[Address(RVA = "0xE28B70", Offset = "0xE27D70", VA = "0x180E28B70")]
	public static bool THREAD_IsSysActLoopExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x600987D")]
	[Address(RVA = "0xE2B100", Offset = "0xE2A300", VA = "0x180E2B100")]
	public static bool ThreadAct(bool init = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600987E")]
	[Address(RVA = "0xE2A290", Offset = "0xE29490", VA = "0x180E2A290")]
	private static void ThreadActRunEffect(ToMainRunEffect runeffectData)
	{
	}

	[Token(Token = "0x600987F")]
	[Address(RVA = "0xE2A080", Offset = "0xE29280", VA = "0x180E2A080")]
	private static ViewType THREAD_getBusyCheckType(ViewType id)
	{
		return default(ViewType);
	}

	[Token(Token = "0x6009880")]
	[Address(RVA = "0xE2B4B0", Offset = "0xE2A6B0", VA = "0x180E2B4B0")]
	private void ThreadInit()
	{
	}

	[Token(Token = "0x6009881")]
	[Address(RVA = "0xE30FE0", Offset = "0xE301E0", VA = "0x180E30FE0")]
	public static void ThreadStart()
	{
	}

	[Token(Token = "0x6009882")]
	[Address(RVA = "0xE2B800", Offset = "0xE2AA00", VA = "0x180E2B800")]
	public static void ThreadJoin()
	{
	}

	[Token(Token = "0x6009883")]
	[Address(RVA = "0xE2A170", Offset = "0xE29370", VA = "0x180E2A170")]
	public static void ThreadAbort()
	{
	}

	[Token(Token = "0x6009884")]
	[Address(RVA = "0xE2BAC0", Offset = "0xE2ACC0", VA = "0x180E2BAC0")]
	private void ThreadRelease()
	{
	}

	[Token(Token = "0x6009885")]
	[Address(RVA = "0xE32B40", Offset = "0xE31D40", VA = "0x180E32B40")]
	private static bool isThreadActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6009886")]
	[Address(RVA = "0xE1F3D0", Offset = "0xE1E5D0", VA = "0x180E1F3D0")]
	public static void SetCpuChangeTimeFool(float time)
	{
	}

	[Token(Token = "0x6009887")]
	[Address(RVA = "0xE1F430", Offset = "0xE1E630", VA = "0x180E1F430")]
	public static void SetCpuChangeTimeSimple(float time)
	{
	}

	[Token(Token = "0x6009888")]
	[Address(RVA = "0xDF3080", Offset = "0xDF2280", VA = "0x180DF3080")]
	private static void CpuThinkUpdate()
	{
	}

	[Token(Token = "0x6009889")]
	[Address(RVA = "0xE31230", Offset = "0xE30430", VA = "0x180E31230")]
	private static void ThreadUpdate()
	{
	}

	[Token(Token = "0x600988A")]
	[Address(RVA = "0xDFA9F0", Offset = "0xDF9BF0", VA = "0x180DFA9F0")]
	private static void EngineCommandExecute()
	{
	}

	[Token(Token = "0x600988B")]
	[Address(RVA = "0xE20CB0", Offset = "0xE1FEB0", VA = "0x180E20CB0")]
	private static void SurrenderCPU()
	{
	}

	[Token(Token = "0x600988C")]
	[Address(RVA = "0xE06810", Offset = "0xE05A10", VA = "0x180E06810")]
	public static bool IsThreadRunEffectDuelEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x600988D")]
	[Address(RVA = "0xE30F10", Offset = "0xE30110", VA = "0x180E30F10")]
	[MonoPInvokeCallback(typeof(ThreadRunEffectDeleg))]
	public static int ThreadRunEffect(int id, int param1, int param2, int param3)
	{
		return default(int);
	}

	[Token(Token = "0x600988E")]
	[Address(RVA = "0xE2BCD0", Offset = "0xE2AED0", VA = "0x180E2BCD0")]
	private int ThreadRunEffectImpl(int id, int param1, int param2, int param3)
	{
		return default(int);
	}

	[Token(Token = "0x600988F")]
	[Address(RVA = "0xE2B740", Offset = "0xE2A940", VA = "0x180E2B740")]
	[MonoPInvokeCallback(typeof(ThreadIsBusyEffectDeleg))]
	public static int ThreadIsBusyEffect(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6009890")]
	[Address(RVA = "0xE2B6D0", Offset = "0xE2A8D0", VA = "0x180E2B6D0")]
	private int ThreadIsBusyEffectImpl(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6009891")]
	[Address(RVA = "0xDFE4B0", Offset = "0xDFD6B0", VA = "0x180DFE4B0")]
	private ThreadMixTextData GetDlgMixVal()
	{
		return null;
	}

	[Token(Token = "0x6009892")]
	[Address(RVA = "0xDFBA30", Offset = "0xDFAC30", VA = "0x180DFBA30")]
	private Dictionary<string, int> GetAttackFlags()
	{
		return null;
	}

	[Token(Token = "0x6009893")]
	[Address(RVA = "0xDFB2B0", Offset = "0xDFA4B0", VA = "0x180DFB2B0")]
	private ThreadIconBase[] GetAffectIcon()
	{
		return null;
	}

	[Token(Token = "0x6009894")]
	[Address(RVA = "0xDFCBD0", Offset = "0xDFBDD0", VA = "0x180DFCBD0")]
	private ThreadPosParam[][] GetCardParameter()
	{
		return null;
	}

	[Token(Token = "0x6009895")]
	[Address(RVA = "0xE32590", Offset = "0xE31790", VA = "0x180E32590")]
	public Engine()
	{
	}
}
