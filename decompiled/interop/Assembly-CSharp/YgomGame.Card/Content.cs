using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomGame.Card;

[Token(Token = "0x20015ED")]
public sealed class Content
{
	[Token(Token = "0x20015EE")]
	public struct Property
	{
		[Token(Token = "0x400D0A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort mrk;

		[Token(Token = "0x400D0A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private BitVector32.Section kind;

		[Token(Token = "0x400D0A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private BitVector32.Section attr;

		[Token(Token = "0x400D0A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private BitVector32.Section level;

		[Token(Token = "0x400D0A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		private BitVector32.Section lvtype;

		[Token(Token = "0x400D0A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private BitVector32.Section attack;

		[Token(Token = "0x400D0A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		private BitVector32.Section defence;

		[Token(Token = "0x400D0AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private BitVector32.Section icon;

		[Token(Token = "0x400D0AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		private BitVector32.Section type;

		[Token(Token = "0x400D0AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private BitVector32.Section scaleL;

		[Token(Token = "0x400D0AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		private BitVector32.Section exist;

		[Token(Token = "0x400D0AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BitVector32 bit1;

		[Token(Token = "0x400D0AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BitVector32 bit2;

		[Token(Token = "0x170014EC")]
		public int MRK
		{
			[Token(Token = "0x60088DC")]
			[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170014ED")]
		public Kind Kind
		{
			[Token(Token = "0x60088DD")]
			[Address(RVA = "0xD57750", Offset = "0xD56950", VA = "0x180D57750")]
			get
			{
				return default(Kind);
			}
		}

		[Token(Token = "0x170014EE")]
		public Attribute Attr
		{
			[Token(Token = "0x60088DE")]
			[Address(RVA = "0xD57700", Offset = "0xD56900", VA = "0x180D57700")]
			get
			{
				return default(Attribute);
			}
		}

		[Token(Token = "0x170014EF")]
		public int Level
		{
			[Token(Token = "0x60088DF")]
			[Address(RVA = "0xD57760", Offset = "0xD56960", VA = "0x180D57760")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170014F0")]
		public LvType LvType
		{
			[Token(Token = "0x60088E0")]
			[Address(RVA = "0xD57770", Offset = "0xD56970", VA = "0x180D57770")]
			get
			{
				return default(LvType);
			}
		}

		[Token(Token = "0x170014F1")]
		public int Atk
		{
			[Token(Token = "0x60088E1")]
			[Address(RVA = "0xD576F0", Offset = "0xD568F0", VA = "0x180D576F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170014F2")]
		public int Def
		{
			[Token(Token = "0x60088E2")]
			[Address(RVA = "0xD57710", Offset = "0xD56910", VA = "0x180D57710")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170014F3")]
		public Icon Icon
		{
			[Token(Token = "0x60088E3")]
			[Address(RVA = "0xD57740", Offset = "0xD56940", VA = "0x180D57740")]
			get
			{
				return default(Icon);
			}
		}

		[Token(Token = "0x170014F4")]
		public Type Type
		{
			[Token(Token = "0x60088E4")]
			[Address(RVA = "0xD57790", Offset = "0xD56990", VA = "0x180D57790")]
			get
			{
				return default(Type);
			}
		}

		[Token(Token = "0x170014F5")]
		public int ScaleL
		{
			[Token(Token = "0x60088E5")]
			[Address(RVA = "0xD57780", Offset = "0xD56980", VA = "0x180D57780")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170014F6")]
		public bool Exist
		{
			[Token(Token = "0x60088E6")]
			[Address(RVA = "0xD57720", Offset = "0xD56920", VA = "0x180D57720")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60088E7")]
		[Address(RVA = "0xD57610", Offset = "0xD56810", VA = "0x180D57610")]
		public Property(int param1, int param2)
		{
		}
	}

	[Token(Token = "0x20015EF")]
	public enum Rarity
	{
		[Token(Token = "0x400D0B1")]
		None,
		[Token(Token = "0x400D0B2")]
		Normal,
		[Token(Token = "0x400D0B3")]
		Rare,
		[Token(Token = "0x400D0B4")]
		SuperRare,
		[Token(Token = "0x400D0B5")]
		UltraRare
	}

	[Token(Token = "0x20015F0")]
	public enum Kirarity
	{
		[Token(Token = "0x400D0B7")]
		None,
		[Token(Token = "0x400D0B8")]
		Normal,
		[Token(Token = "0x400D0B9")]
		Gold,
		[Token(Token = "0x400D0BA")]
		Kira,
		[Token(Token = "0x400D0BB")]
		Holo
	}

	[Token(Token = "0x20015F1")]
	public enum Attribute
	{
		[Token(Token = "0x400D0BD")]
		Null,
		[Token(Token = "0x400D0BE")]
		Light,
		[Token(Token = "0x400D0BF")]
		Dark,
		[Token(Token = "0x400D0C0")]
		Water,
		[Token(Token = "0x400D0C1")]
		Fire,
		[Token(Token = "0x400D0C2")]
		Earth,
		[Token(Token = "0x400D0C3")]
		Wind,
		[Token(Token = "0x400D0C4")]
		God,
		[Token(Token = "0x400D0C5")]
		Magic,
		[Token(Token = "0x400D0C6")]
		Trap
	}

	[Token(Token = "0x20015F2")]
	public enum Type
	{
		[Token(Token = "0x400D0C8")]
		Null = 0,
		[Token(Token = "0x400D0C9")]
		Dragon = 1,
		[Token(Token = "0x400D0CA")]
		Undead = 2,
		[Token(Token = "0x400D0CB")]
		Devil = 3,
		[Token(Token = "0x400D0CC")]
		Flame = 4,
		[Token(Token = "0x400D0CD")]
		Poseidon = 5,
		[Token(Token = "0x400D0CE")]
		Sandrock = 6,
		[Token(Token = "0x400D0CF")]
		Machine = 7,
		[Token(Token = "0x400D0D0")]
		Fish = 8,
		[Token(Token = "0x400D0D1")]
		Dinosaurs = 9,
		[Token(Token = "0x400D0D2")]
		Insect = 10,
		[Token(Token = "0x400D0D3")]
		Beast = 11,
		[Token(Token = "0x400D0D4")]
		BeastBtl = 12,
		[Token(Token = "0x400D0D5")]
		Botanical = 13,
		[Token(Token = "0x400D0D6")]
		Aquarius = 14,
		[Token(Token = "0x400D0D7")]
		Soldier = 15,
		[Token(Token = "0x400D0D8")]
		Bird = 16,
		[Token(Token = "0x400D0D9")]
		Angel = 17,
		[Token(Token = "0x400D0DA")]
		Wizard = 18,
		[Token(Token = "0x400D0DB")]
		Thunder = 19,
		[Token(Token = "0x400D0DC")]
		Reptiles = 20,
		[Token(Token = "0x400D0DD")]
		Psychic = 21,
		[Token(Token = "0x400D0DE")]
		Mystdragon = 22,
		[Token(Token = "0x400D0DF")]
		Cyverse = 23,
		[Token(Token = "0x400D0E0")]
		God = 24,
		[Token(Token = "0x400D0E1")]
		Illusioner = 25,
		[Token(Token = "0x400D0E2")]
		Creator = 26,
		[Token(Token = "0x400D0E3")]
		Magic = 0,
		[Token(Token = "0x400D0E4")]
		Trap = 0
	}

	[Token(Token = "0x20015F3")]
	public enum Icon
	{
		[Token(Token = "0x400D0E6")]
		Null,
		[Token(Token = "0x400D0E7")]
		Counter,
		[Token(Token = "0x400D0E8")]
		Field,
		[Token(Token = "0x400D0E9")]
		Equip,
		[Token(Token = "0x400D0EA")]
		Continuous,
		[Token(Token = "0x400D0EB")]
		QuickPlay,
		[Token(Token = "0x400D0EC")]
		Ritual,
		[Token(Token = "0x400D0ED")]
		Ritual_R
	}

	[Token(Token = "0x20015F4")]
	public enum Frame
	{
		[Token(Token = "0x400D0EF")]
		Normal,
		[Token(Token = "0x400D0F0")]
		Effect,
		[Token(Token = "0x400D0F1")]
		Ritual,
		[Token(Token = "0x400D0F2")]
		Fusion,
		[Token(Token = "0x400D0F3")]
		Oberisk,
		[Token(Token = "0x400D0F4")]
		Osiris,
		[Token(Token = "0x400D0F5")]
		Ra,
		[Token(Token = "0x400D0F6")]
		Magic,
		[Token(Token = "0x400D0F7")]
		Trap,
		[Token(Token = "0x400D0F8")]
		Token,
		[Token(Token = "0x400D0F9")]
		Sync,
		[Token(Token = "0x400D0FA")]
		Dsync,
		[Token(Token = "0x400D0FB")]
		Xyz,
		[Token(Token = "0x400D0FC")]
		Pend,
		[Token(Token = "0x400D0FD")]
		PendFx,
		[Token(Token = "0x400D0FE")]
		XyzPend,
		[Token(Token = "0x400D0FF")]
		SyncPend,
		[Token(Token = "0x400D100")]
		FusionPend,
		[Token(Token = "0x400D101")]
		Link,
		[Token(Token = "0x400D102")]
		RitualPend
	}

	[Token(Token = "0x20015F5")]
	public enum Kind
	{
		[Token(Token = "0x400D104")]
		Normal,
		[Token(Token = "0x400D105")]
		Effect,
		[Token(Token = "0x400D106")]
		Fusion,
		[Token(Token = "0x400D107")]
		FusionFx,
		[Token(Token = "0x400D108")]
		Ritual,
		[Token(Token = "0x400D109")]
		RitualFx,
		[Token(Token = "0x400D10A")]
		Toon,
		[Token(Token = "0x400D10B")]
		Spirit,
		[Token(Token = "0x400D10C")]
		Union,
		[Token(Token = "0x400D10D")]
		Dual,
		[Token(Token = "0x400D10E")]
		Token,
		[Token(Token = "0x400D10F")]
		God,
		[Token(Token = "0x400D110")]
		Dummy,
		[Token(Token = "0x400D111")]
		Magic,
		[Token(Token = "0x400D112")]
		Trap,
		[Token(Token = "0x400D113")]
		Tuner,
		[Token(Token = "0x400D114")]
		TunerFx,
		[Token(Token = "0x400D115")]
		Sync,
		[Token(Token = "0x400D116")]
		SyncFx,
		[Token(Token = "0x400D117")]
		SyncTuner,
		[Token(Token = "0x400D118")]
		Dtuner,
		[Token(Token = "0x400D119")]
		Dsync,
		[Token(Token = "0x400D11A")]
		Xyz,
		[Token(Token = "0x400D11B")]
		XyzFx,
		[Token(Token = "0x400D11C")]
		Flip,
		[Token(Token = "0x400D11D")]
		Pend,
		[Token(Token = "0x400D11E")]
		PendFx,
		[Token(Token = "0x400D11F")]
		SpEffect,
		[Token(Token = "0x400D120")]
		SpToon,
		[Token(Token = "0x400D121")]
		SpSpirit,
		[Token(Token = "0x400D122")]
		SpTuner,
		[Token(Token = "0x400D123")]
		SpDtuner,
		[Token(Token = "0x400D124")]
		FlipTuner,
		[Token(Token = "0x400D125")]
		PendTuner,
		[Token(Token = "0x400D126")]
		XyzPend,
		[Token(Token = "0x400D127")]
		PendFlip,
		[Token(Token = "0x400D128")]
		SyncPend,
		[Token(Token = "0x400D129")]
		UnionTuner,
		[Token(Token = "0x400D12A")]
		RitualSpirit,
		[Token(Token = "0x400D12B")]
		FusionTuner,
		[Token(Token = "0x400D12C")]
		SpPend,
		[Token(Token = "0x400D12D")]
		FusionPend,
		[Token(Token = "0x400D12E")]
		Link,
		[Token(Token = "0x400D12F")]
		LinkFx,
		[Token(Token = "0x400D130")]
		PendNTuner,
		[Token(Token = "0x400D131")]
		PendSpirit,
		[Token(Token = "0x400D132")]
		Maximum,
		[Token(Token = "0x400D133")]
		RirualTunerFX,
		[Token(Token = "0x400D134")]
		FusionTunerFX,
		[Token(Token = "0x400D135")]
		TokenTuner,
		[Token(Token = "0x400D136")]
		R_Fusion,
		[Token(Token = "0x400D137")]
		R_FusionFX,
		[Token(Token = "0x400D138")]
		RitualPend,
		[Token(Token = "0x400D139")]
		RitualFlip
	}

	[Token(Token = "0x20015F6")]
	public enum SubKind
	{
		[Token(Token = "0x400D13B")]
		Null,
		[Token(Token = "0x400D13C")]
		NoFx,
		[Token(Token = "0x400D13D")]
		Normal,
		[Token(Token = "0x400D13E")]
		Effect,
		[Token(Token = "0x400D13F")]
		Flip,
		[Token(Token = "0x400D140")]
		Toon,
		[Token(Token = "0x400D141")]
		Spirit,
		[Token(Token = "0x400D142")]
		Union,
		[Token(Token = "0x400D143")]
		Dual,
		[Token(Token = "0x400D144")]
		Maximum
	}

	[Token(Token = "0x20015F7")]
	public enum LvType
	{
		[Token(Token = "0x400D146")]
		Null = 0,
		[Token(Token = "0x400D147")]
		Level = 1,
		[Token(Token = "0x400D148")]
		Rank = 2,
		[Token(Token = "0x400D149")]
		Link = 3,
		[Token(Token = "0x400D14A")]
		LvMax = 12,
		[Token(Token = "0x400D14B")]
		LvMask = 8190,
		[Token(Token = "0x400D14C")]
		RankMax = 13,
		[Token(Token = "0x400D14D")]
		RankMask = 16382,
		[Token(Token = "0x400D14E")]
		LinkMax = 8
	}

	[Token(Token = "0x20015F8")]
	public enum LinkMarker
	{
		[Token(Token = "0x400D150")]
		UpLeft,
		[Token(Token = "0x400D151")]
		Up,
		[Token(Token = "0x400D152")]
		UpRight,
		[Token(Token = "0x400D153")]
		Left,
		[Token(Token = "0x400D154")]
		Right,
		[Token(Token = "0x400D155")]
		DownLeft,
		[Token(Token = "0x400D156")]
		Down,
		[Token(Token = "0x400D157")]
		DownRight
	}

	[Token(Token = "0x20015F9")]
	[Flags]
	public enum LinkMarkerBit
	{
		[Token(Token = "0x400D159")]
		UpLeft = 1,
		[Token(Token = "0x400D15A")]
		Up = 2,
		[Token(Token = "0x400D15B")]
		UpRight = 4,
		[Token(Token = "0x400D15C")]
		Left = 8,
		[Token(Token = "0x400D15D")]
		Right = 0x10,
		[Token(Token = "0x400D15E")]
		DownLeft = 0x20,
		[Token(Token = "0x400D15F")]
		Down = 0x40,
		[Token(Token = "0x400D160")]
		DownRight = 0x80
	}

	[Token(Token = "0x20015FA")]
	public enum Genre
	{
		[Token(Token = "0x400D162")]
		LpUp,
		[Token(Token = "0x400D163")]
		LpDown,
		[Token(Token = "0x400D164")]
		Draw,
		[Token(Token = "0x400D165")]
		SpSummon,
		[Token(Token = "0x400D166")]
		Disable,
		[Token(Token = "0x400D167")]
		DeckSearch,
		[Token(Token = "0x400D168")]
		UseGrave,
		[Token(Token = "0x400D169")]
		Power,
		[Token(Token = "0x400D16A")]
		Position,
		[Token(Token = "0x400D16B")]
		Control,
		[Token(Token = "0x400D16C")]
		BreakMonst,
		[Token(Token = "0x400D16D")]
		BreakMagic,
		[Token(Token = "0x400D16E")]
		HandDes,
		[Token(Token = "0x400D16F")]
		DeckDes,
		[Token(Token = "0x400D170")]
		RemoveCard,
		[Token(Token = "0x400D171")]
		CardBack,
		[Token(Token = "0x400D172")]
		Spear,
		[Token(Token = "0x400D173")]
		DirectAtk,
		[Token(Token = "0x400D174")]
		ManyAtk,
		[Token(Token = "0x400D175")]
		Unbreak,
		[Token(Token = "0x400D176")]
		LimitAtk,
		[Token(Token = "0x400D177")]
		CantSummon,
		[Token(Token = "0x400D178")]
		Reverse,
		[Token(Token = "0x400D179")]
		Toon,
		[Token(Token = "0x400D17A")]
		Spirit,
		[Token(Token = "0x400D17B")]
		Union,
		[Token(Token = "0x400D17C")]
		Dual,
		[Token(Token = "0x400D17D")]
		LevelUp,
		[Token(Token = "0x400D17E")]
		Original,
		[Token(Token = "0x400D17F")]
		Fusion,
		[Token(Token = "0x400D180")]
		Ritual,
		[Token(Token = "0x400D181")]
		Token,
		[Token(Token = "0x400D182")]
		Counter,
		[Token(Token = "0x400D183")]
		Gamble,
		[Token(Token = "0x400D184")]
		Attribute,
		[Token(Token = "0x400D185")]
		Type,
		[Token(Token = "0x400D186")]
		Tuner,
		[Token(Token = "0x400D187")]
		Sync,
		[Token(Token = "0x400D188")]
		DropGrave,
		[Token(Token = "0x400D189")]
		Normal,
		[Token(Token = "0x400D18A")]
		AttrLight,
		[Token(Token = "0x400D18B")]
		AttrDark,
		[Token(Token = "0x400D18C")]
		AttrEarth,
		[Token(Token = "0x400D18D")]
		AttrWater,
		[Token(Token = "0x400D18E")]
		AttrFire,
		[Token(Token = "0x400D18F")]
		AttrWind,
		[Token(Token = "0x400D190")]
		Xyz,
		[Token(Token = "0x400D191")]
		LvUpDown,
		[Token(Token = "0x400D192")]
		Pendulum,
		[Token(Token = "0x400D193")]
		Link,
		[Token(Token = "0x400D194")]
		HalfDamage
	}

	[Token(Token = "0x20015FB")]
	public enum NameType
	{
		[Token(Token = "0x400D196")]
		Null,
		[Token(Token = "0x400D197")]
		Toon,
		[Token(Token = "0x400D198")]
		Demon,
		[Token(Token = "0x400D199")]
		GraveKeeper,
		[Token(Token = "0x400D19A")]
		Guardian,
		[Token(Token = "0x400D19B")]
		DarkScorpion,
		[Token(Token = "0x400D19C")]
		Amazoness,
		[Token(Token = "0x400D19D")]
		Ninja,
		[Token(Token = "0x400D19E")]
		Level,
		[Token(Token = "0x400D19F")]
		EHero,
		[Token(Token = "0x400D1A0")]
		DHero,
		[Token(Token = "0x400D1A1")]
		NeosFusion,
		[Token(Token = "0x400D1A2")]
		Neos,
		[Token(Token = "0x400D1A3")]
		Ojama,
		[Token(Token = "0x400D1A4")]
		Battery,
		[Token(Token = "0x400D1A5")]
		DarkWorld,
		[Token(Token = "0x400D1A6")]
		BES,
		[Token(Token = "0x400D1A7")]
		Antique,
		[Token(Token = "0x400D1A8")]
		Sphinx,
		[Token(Token = "0x400D1A9")]
		Machiners,
		[Token(Token = "0x400D1AA")]
		Harpie,
		[Token(Token = "0x400D1AB")]
		Roid,
		[Token(Token = "0x400D1AC")]
		Vehicloid,
		[Token(Token = "0x400D1AD")]
		NeoSpacian,
		[Token(Token = "0x400D1AE")]
		Cocoon,
		[Token(Token = "0x400D1AF")]
		Alien,
		[Token(Token = "0x400D1B0")]
		MythicalBeast,
		[Token(Token = "0x400D1B1")]
		Hero,
		[Token(Token = "0x400D1B2")]
		AllureQueen,
		[Token(Token = "0x400D1B3")]
		Gadget,
		[Token(Token = "0x400D1B4")]
		SixSamurai,
		[Token(Token = "0x400D1B5")]
		Jewel,
		[Token(Token = "0x400D1B6")]
		Volcanic,
		[Token(Token = "0x400D1B7")]
		BlazeCanon,
		[Token(Token = "0x400D1B8")]
		Venom,
		[Token(Token = "0x400D1B9")]
		Cloudian,
		[Token(Token = "0x400D1BA")]
		Gladial,
		[Token(Token = "0x400D1BB")]
		Weapon,
		[Token(Token = "0x400D1BC")]
		Takemitsu,
		[Token(Token = "0x400D1BD")]
		EvHero,
		[Token(Token = "0x400D1BE")]
		Drunk,
		[Token(Token = "0x400D1BF")]
		Arcana,
		[Token(Token = "0x400D1C0")]
		Fossil,
		[Token(Token = "0x400D1C1")]
		Gunner,
		[Token(Token = "0x400D1C2")]
		Forbidden,
		[Token(Token = "0x400D1C3")]
		Rainbow,
		[Token(Token = "0x400D1C4")]
		CyberFusion,
		[Token(Token = "0x400D1C5")]
		IceBarrier,
		[Token(Token = "0x400D1C6")]
		AOJ,
		[Token(Token = "0x400D1C7")]
		Saber,
		[Token(Token = "0x400D1C8")]
		Worm,
		[Token(Token = "0x400D1C9")]
		LightLord,
		[Token(Token = "0x400D1CA")]
		Frog,
		[Token(Token = "0x400D1CB")]
		Nitro,
		[Token(Token = "0x400D1CC")]
		Genex,
		[Token(Token = "0x400D1CD")]
		MistValley,
		[Token(Token = "0x400D1CE")]
		Flamebell,
		[Token(Token = "0x400D1CF")]
		NeosNHero,
		[Token(Token = "0x400D1D0")]
		Deformer,
		[Token(Token = "0x400D1D1")]
		Chain,
		[Token(Token = "0x400D1D2")]
		Natul,
		[Token(Token = "0x400D1D3")]
		Multi,
		[Token(Token = "0x400D1D4")]
		RedEyes,
		[Token(Token = "0x400D1D5")]
		BlackFeather,
		[Token(Token = "0x400D1D6")]
		SlashBuster,
		[Token(Token = "0x400D1D7")]
		Roaring,
		[Token(Token = "0x400D1D8")]
		Jurac,
		[Token(Token = "0x400D1D9")]
		RealGenex,
		[Token(Token = "0x400D1DA")]
		EarthBindGod,
		[Token(Token = "0x400D1DB")]
		Koakimail,
		[Token(Token = "0x400D1DC")]
		Infernity,
		[Token(Token = "0x400D1DD")]
		XSaber,
		[Token(Token = "0x400D1DE")]
		FortuneLady,
		[Token(Token = "0x400D1DF")]
		Dragnity,
		[Token(Token = "0x400D1E0")]
		FortuneWitch,
		[Token(Token = "0x400D1E1")]
		Synchron,
		[Token(Token = "0x400D1E2")]
		Saviour,
		[Token(Token = "0x400D1E3")]
		Reptiles,
		[Token(Token = "0x400D1E4")]
		Shien,
		[Token(Token = "0x400D1E5")]
		Junk,
		[Token(Token = "0x400D1E6")]
		Tomabo,
		[Token(Token = "0x400D1E7")]
		Sin,
		[Token(Token = "0x400D1E8")]
		Gem,
		[Token(Token = "0x400D1E9")]
		GemKnight,
		[Token(Token = "0x400D1EA")]
		Laval,
		[Token(Token = "0x400D1EB")]
		Vailon,
		[Token(Token = "0x400D1EC")]
		Scrap,
		[Token(Token = "0x400D1ED")]
		Eleki,
		[Token(Token = "0x400D1EE")]
		Fusion,
		[Token(Token = "0x400D1EF")]
		Infinity,
		[Token(Token = "0x400D1F0")]
		Wisel,
		[Token(Token = "0x400D1F1")]
		TG,
		[Token(Token = "0x400D1F2")]
		Karakuri,
		[Token(Token = "0x400D1F3")]
		Ritua,
		[Token(Token = "0x400D1F4")]
		Gusta,
		[Token(Token = "0x400D1F5")]
		Invelds,
		[Token(Token = "0x400D1F6")]
		Reactor,
		[Token(Token = "0x400D1F7")]
		Agent,
		[Token(Token = "0x400D1F8")]
		PoleStar,
		[Token(Token = "0x400D1F9")]
		PoleStarBeast,
		[Token(Token = "0x400D1FA")]
		PoleStarGhost,
		[Token(Token = "0x400D1FB")]
		PoleStarAngel,
		[Token(Token = "0x400D1FC")]
		PoleStarItem,
		[Token(Token = "0x400D1FD")]
		PoleGod,
		[Token(Token = "0x400D1FE")]
		SoundWarrior,
		[Token(Token = "0x400D1FF")]
		Resonator,
		[Token(Token = "0x400D200")]
		MHero,
		[Token(Token = "0x400D201")]
		VHero,
		[Token(Token = "0x400D202")]
		MeklordEmperor,
		[Token(Token = "0x400D203")]
		MeklordSoldier,
		[Token(Token = "0x400D204")]
		Meklord,
		[Token(Token = "0x400D205")]
		Zenmai,
		[Token(Token = "0x400D206")]
		Penguin,
		[Token(Token = "0x400D207")]
		Evold,
		[Token(Token = "0x400D208")]
		Evolder,
		[Token(Token = "0x400D209")]
		TrapHole,
		[Token(Token = "0x400D20A")]
		TimeGod,
		[Token(Token = "0x400D20B")]
		Sacred,
		[Token(Token = "0x400D20C")]
		Velds,
		[Token(Token = "0x400D20D")]
		Numbers,
		[Token(Token = "0x400D20E")]
		Gagaga,
		[Token(Token = "0x400D20F")]
		Gogogo,
		[Token(Token = "0x400D210")]
		Photon,
		[Token(Token = "0x400D211")]
		Ninjutsu,
		[Token(Token = "0x400D212")]
		Inzector,
		[Token(Token = "0x400D213")]
		Invasion,
		[Token(Token = "0x400D214")]
		Bouncer,
		[Token(Token = "0x400D215")]
		Butterfly,
		[Token(Token = "0x400D216")]
		HolySeal,
		[Token(Token = "0x400D217")]
		Majin,
		[Token(Token = "0x400D218")]
		Heroic,
		[Token(Token = "0x400D219")]
		Ooparts,
		[Token(Token = "0x400D21A")]
		SpellBook,
		[Token(Token = "0x400D21B")]
		MaDolce,
		[Token(Token = "0x400D21C")]
		GearGear,
		[Token(Token = "0x400D21D")]
		Xyz,
		[Token(Token = "0x400D21E")]
		Poseidon,
		[Token(Token = "0x400D21F")]
		Mermail,
		[Token(Token = "0x400D220")]
		Abyss,
		[Token(Token = "0x400D221")]
		Magical,
		[Token(Token = "0x400D222")]
		Nimble,
		[Token(Token = "0x400D223")]
		Duston,
		[Token(Token = "0x400D224")]
		Medallion,
		[Token(Token = "0x400D225")]
		NobleKnight,
		[Token(Token = "0x400D226")]
		FireKing,
		[Token(Token = "0x400D227")]
		Galaxy,
		[Token(Token = "0x400D228")]
		HolySword,
		[Token(Token = "0x400D229")]
		FireStar,
		[Token(Token = "0x400D22A")]
		FireDance,
		[Token(Token = "0x400D22B")]
		HazeBeast,
		[Token(Token = "0x400D22C")]
		Haze,
		[Token(Token = "0x400D22D")]
		ZexalWeapon,
		[Token(Token = "0x400D22E")]
		Hope,
		[Token(Token = "0x400D22F")]
		GimmickPuppet,
		[Token(Token = "0x400D230")]
		Dododo,
		[Token(Token = "0x400D231")]
		BK,
		[Token(Token = "0x400D232")]
		PhantomMek,
		[Token(Token = "0x400D233")]
		FireKingBeast,
		[Token(Token = "0x400D234")]
		ChaosNumbers,
		[Token(Token = "0x400D235")]
		ChaosXyz,
		[Token(Token = "0x400D236")]
		GearGearno,
		[Token(Token = "0x400D237")]
		SDRobo,
		[Token(Token = "0x400D238")]
		SDRobo2,
		[Token(Token = "0x400D239")]
		Umbral,
		[Token(Token = "0x400D23A")]
		HolyLightning,
		[Token(Token = "0x400D23B")]
		Bujin,
		[Token(Token = "0x400D23C")]
		Kowakuma,
		[Token(Token = "0x400D23D")]
		Hole,
		[Token(Token = "0x400D23E")]
		CNo39,
		[Token(Token = "0x400D23F")]
		HChallenger,
		[Token(Token = "0x400D240")]
		MaliceBolus,
		[Token(Token = "0x400D241")]
		Ghostrick,
		[Token(Token = "0x400D242")]
		Vampire,
		[Token(Token = "0x400D243")]
		Cat,
		[Token(Token = "0x400D244")]
		CyberDragon,
		[Token(Token = "0x400D245")]
		Cybernetic,
		[Token(Token = "0x400D246")]
		Shinra,
		[Token(Token = "0x400D247")]
		Necrovalley,
		[Token(Token = "0x400D248")]
		Zubaba,
		[Token(Token = "0x400D249")]
		Fishborg,
		[Token(Token = "0x400D24A")]
		RUM,
		[Token(Token = "0x400D24B")]
		Medallion2,
		[Token(Token = "0x400D24C")]
		Artifact,
		[Token(Token = "0x400D24D")]
		EvolKaiser,
		[Token(Token = "0x400D24E")]
		GalaxyEyes,
		[Token(Token = "0x400D24F")]
		TachyonDragon,
		[Token(Token = "0x400D250")]
		Over100,
		[Token(Token = "0x400D251")]
		Wizard,
		[Token(Token = "0x400D252")]
		OddEyes,
		[Token(Token = "0x400D253")]
		LegendDragon,
		[Token(Token = "0x400D254")]
		LegendKnight,
		[Token(Token = "0x400D255")]
		WingedKuriboh,
		[Token(Token = "0x400D256")]
		Stardust,
		[Token(Token = "0x400D257")]
		Sprout,
		[Token(Token = "0x400D258")]
		Artorius,
		[Token(Token = "0x400D259")]
		Lancelot,
		[Token(Token = "0x400D25A")]
		SuperHeavy,
		[Token(Token = "0x400D25B")]
		Genso,
		[Token(Token = "0x400D25C")]
		TellarKnight,
		[Token(Token = "0x400D25D")]
		Shadoll,
		[Token(Token = "0x400D25E")]
		DragonStar,
		[Token(Token = "0x400D25F")]
		EM,
		[Token(Token = "0x400D260")]
		Change,
		[Token(Token = "0x400D261")]
		Higan,
		[Token(Token = "0x400D262")]
		UA,
		[Token(Token = "0x400D263")]
		DD,
		[Token(Token = "0x400D264")]
		DDD,
		[Token(Token = "0x400D265")]
		Furnimal,
		[Token(Token = "0x400D266")]
		DeathToy,
		[Token(Token = "0x400D267")]
		Qliphot,
		[Token(Token = "0x400D268")]
		Bunborg,
		[Token(Token = "0x400D269")]
		Goblin,
		[Token(Token = "0x400D26A")]
		Cthulhu,
		[Token(Token = "0x400D26B")]
		Contract,
		[Token(Token = "0x400D26C")]
		Gottoms,
		[Token(Token = "0x400D26D")]
		Yosen,
		[Token(Token = "0x400D26E")]
		Necroth,
		[Token(Token = "0x400D26F")]
		SpiritAll,
		[Token(Token = "0x400D270")]
		SpiritTamer,
		[Token(Token = "0x400D271")]
		SpiritBeast,
		[Token(Token = "0x400D272")]
		RR,
		[Token(Token = "0x400D273")]
		Infernoid,
		[Token(Token = "0x400D274")]
		Jinzo,
		[Token(Token = "0x400D275")]
		Gaia,
		[Token(Token = "0x400D276")]
		Monarch,
		[Token(Token = "0x400D277")]
		Charmer,
		[Token(Token = "0x400D278")]
		Possessed,
		[Token(Token = "0x400D279")]
		Crystal,
		[Token(Token = "0x400D27A")]
		Warrior,
		[Token(Token = "0x400D27B")]
		PowerTool,
		[Token(Token = "0x400D27C")]
		BMG,
		[Token(Token = "0x400D27D")]
		EdgeImp,
		[Token(Token = "0x400D27E")]
		Sephira,
		[Token(Token = "0x400D27F")]
		GensoPrincess,
		[Token(Token = "0x400D280")]
		SpiritRider,
		[Token(Token = "0x400D281")]
		StellarKnight,
		[Token(Token = "0x400D282")]
		Void,
		[Token(Token = "0x400D283")]
		Em,
		[Token(Token = "0x400D284")]
		DragonSword,
		[Token(Token = "0x400D285")]
		IgKnight,
		[Token(Token = "0x400D286")]
		Aroma,
		[Token(Token = "0x400D287")]
		Empowered,
		[Token(Token = "0x400D288")]
		AetherWeapon,
		[Token(Token = "0x400D289")]
		FortunePrincess,
		[Token(Token = "0x400D28A")]
		AquaActress,
		[Token(Token = "0x400D28B")]
		Aquarium,
		[Token(Token = "0x400D28C")]
		ChaosSoldier,
		[Token(Token = "0x400D28D")]
		Majespecter,
		[Token(Token = "0x400D28E")]
		Gradle,
		[Token(Token = "0x400D28F")]
		Kozmo,
		[Token(Token = "0x400D290")]
		Kaiju,
		[Token(Token = "0x400D291")]
		SR,
		[Token(Token = "0x400D292")]
		PsyFrame,
		[Token(Token = "0x400D293")]
		RedDemon,
		[Token(Token = "0x400D294")]
		Burgestoma,
		[Token(Token = "0x400D295")]
		Dante,
		[Token(Token = "0x400D296")]
		BusterBlader,
		[Token(Token = "0x400D297")]
		BusterSword,
		[Token(Token = "0x400D298")]
		Dynamist,
		[Token(Token = "0x400D299")]
		Shiranui,
		[Token(Token = "0x400D29A")]
		DragonDevil,
		[Token(Token = "0x400D29B")]
		Exodia,
		[Token(Token = "0x400D29C")]
		PhantomKnight,
		[Token(Token = "0x400D29D")]
		Phantom,
		[Token(Token = "0x400D29E")]
		Super,
		[Token(Token = "0x400D29F")]
		SuperQuantum,
		[Token(Token = "0x400D2A0")]
		SuperMachine,
		[Token(Token = "0x400D2A1")]
		BlueEyes,
		[Token(Token = "0x400D2A2")]
		HopeX,
		[Token(Token = "0x400D2A3")]
		Moonlight,
		[Token(Token = "0x400D2A4")]
		Amorphage,
		[Token(Token = "0x400D2A5")]
		ElfSwordsman,
		[Token(Token = "0x400D2A6")]
		MagicianGirl,
		[Token(Token = "0x400D2A7")]
		BlackMagic,
		[Token(Token = "0x400D2A8")]
		Metalphose,
		[Token(Token = "0x400D2A9")]
		Tramid,
		[Token(Token = "0x400D2AA")]
		ABF,
		[Token(Token = "0x400D2AB")]
		Houkai,
		[Token(Token = "0x400D2AC")]
		Chaos,
		[Token(Token = "0x400D2AD")]
		CyberAngel,
		[Token(Token = "0x400D2AE")]
		Cypher,
		[Token(Token = "0x400D2AF")]
		Cardian,
		[Token(Token = "0x400D2B0")]
		SilentSword,
		[Token(Token = "0x400D2B1")]
		SilentMagic,
		[Token(Token = "0x400D2B2")]
		MagnetWarrior,
		[Token(Token = "0x400D2B3")]
		BlackMagic2,
		[Token(Token = "0x400D2B4")]
		Kuriboh,
		[Token(Token = "0x400D2B5")]
		Crystron,
		[Token(Token = "0x400D2B6")]
		Kagoju,
		[Token(Token = "0x400D2B7")]
		ApoQliphot,
		[Token(Token = "0x400D2B8")]
		SubTerror,
		[Token(Token = "0x400D2B9")]
		SubTerrorMalice,
		[Token(Token = "0x400D2BA")]
		Spyral,
		[Token(Token = "0x400D2BB")]
		SpyralGear,
		[Token(Token = "0x400D2BC")]
		MakaiGekidan,
		[Token(Token = "0x400D2BD")]
		MakaiDaihon,
		[Token(Token = "0x400D2BE")]
		FallenAngel,
		[Token(Token = "0x400D2BF")]
		WW,
		[Token(Token = "0x400D2C0")]
		Beast12,
		[Token(Token = "0x400D2C1")]
		PendDragon,
		[Token(Token = "0x400D2C2")]
		SpyralMission,
		[Token(Token = "0x400D2C3")]
		Predator,
		[Token(Token = "0x400D2C4")]
		PredatorPlants,
		[Token(Token = "0x400D2C5")]
		SuperHeavySoul,
		[Token(Token = "0x400D2C6")]
		SummonBeast,
		[Token(Token = "0x400D2C7")]
		XyzDragon,
		[Token(Token = "0x400D2C8")]
		SyncDragon,
		[Token(Token = "0x400D2C9")]
		FusionDragon,
		[Token(Token = "0x400D2CA")]
		PendulumGraph,
		[Token(Token = "0x400D2CB")]
		SkyScraper,
		[Token(Token = "0x400D2CC")]
		WizardSpell,
		[Token(Token = "0x400D2CD")]
		LL,
		[Token(Token = "0x400D2CE")]
		HaohGate,
		[Token(Token = "0x400D2CF")]
		HaohKenRyu,
		[Token(Token = "0x400D2D0")]
		TrueDragon,
		[Token(Token = "0x400D2D1")]
		GenOhRyu,
		[Token(Token = "0x400D2D2")]
		Pendulum,
		[Token(Token = "0x400D2D3")]
		Gandra,
		[Token(Token = "0x400D2D4")]
		TrickStar,
		[Token(Token = "0x400D2D5")]
		Gouki,
		[Token(Token = "0x400D2D6")]
		Chalice,
		[Token(Token = "0x400D2D7")]
		Relics,
		[Token(Token = "0x400D2D8")]
		ClearWing,
		[Token(Token = "0x400D2D9")]
		StarveVenom,
		[Token(Token = "0x400D2DA")]
		CyberDark,
		[Token(Token = "0x400D2DB")]
		Bonding,
		[Token(Token = "0x400D2DC")]
		CodeTalker,
		[Token(Token = "0x400D2DD")]
		Bullet,
		[Token(Token = "0x400D2DE")]
		AlterGeist,
		[Token(Token = "0x400D2DF")]
		Crawler,
		[Token(Token = "0x400D2E0")]
		Metaphys,
		[Token(Token = "0x400D2E1")]
		VenDead,
		[Token(Token = "0x400D2E2")]
		FA,
		[Token(Token = "0x400D2E3")]
		Madan,
		[Token(Token = "0x400D2E4")]
		Weather,
		[Token(Token = "0x400D2E5")]
		Parshath,
		[Token(Token = "0x400D2E6")]
		ShadowSix,
		[Token(Token = "0x400D2E7")]
		Tindangle,
		[Token(Token = "0x400D2E8")]
		JackKnights,
		[Token(Token = "0x400D2E9")]
		MagicBeast,
		[Token(Token = "0x400D2EA")]
		EvolutionPill,
		[Token(Token = "0x400D2EB")]
		Barrel,
		[Token(Token = "0x400D2EC")]
		EyesSacrifice,
		[Token(Token = "0x400D2ED")]
		ArmedDragon,
		[Token(Token = "0x400D2EE")]
		AntiqueCard,
		[Token(Token = "0x400D2EF")]
		Troymare,
		[Token(Token = "0x400D2F0")]
		ElementSaber,
		[Token(Token = "0x400D2F1")]
		ElementLord,
		[Token(Token = "0x400D2F2")]
		KugaDan,
		[Token(Token = "0x400D2F3")]
		SentouKi,
		[Token(Token = "0x400D2F4")]
		Sentou,
		[Token(Token = "0x400D2F5")]
		Paradion,
		[Token(Token = "0x400D2F6")]
		DeviRitual,
		[Token(Token = "0x400D2F7")]
		BlueEyesMagic,
		[Token(Token = "0x400D2F8")]
		GoldenCastle,
		[Token(Token = "0x400D2F9")]
		CyberNet,
		[Token(Token = "0x400D2FA")]
		SalamanGreat,
		[Token(Token = "0x400D2FB")]
		DinoWrestler,
		[Token(Token = "0x400D2FC")]
		Orphgoal,
		[Token(Token = "0x400D2FD")]
		ThunderDragon,
		[Token(Token = "0x400D2FE")]
		ForbiddenMagic,
		[Token(Token = "0x400D2FF")]
		Danger,
		[Token(Token = "0x400D300")]
		PhotonGalaxy,
		[Token(Token = "0x400D301")]
		Nephthys,
		[Token(Token = "0x400D302")]
		PlanKids,
		[Token(Token = "0x400D303")]
		Mayakashi,
		[Token(Token = "0x400D304")]
		Valkyrie,
		[Token(Token = "0x400D305")]
		Youtou,
		[Token(Token = "0x400D306")]
		NeosMagic,
		[Token(Token = "0x400D307")]
		HarpieMagic,
		[Token(Token = "0x400D308")]
		MachineAngel,
		[Token(Token = "0x400D309")]
		RoseDragon,
		[Token(Token = "0x400D30A")]
		Sanctuary,
		[Token(Token = "0x400D30B")]
		Bushido,
		[Token(Token = "0x400D30C")]
		Smile,
		[Token(Token = "0x400D30D")]
		BusterMode,
		[Token(Token = "0x400D30E")]
		ChronoDiver,
		[Token(Token = "0x400D30F")]
		MugenKidou,
		[Token(Token = "0x400D310")]
		WitchCraft,
		[Token(Token = "0x400D311")]
		EvilEye,
		[Token(Token = "0x400D312")]
		Endymion,
		[Token(Token = "0x400D313")]
		Marincess,
		[Token(Token = "0x400D314")]
		TenI,
		[Token(Token = "0x400D315")]
		Simorgh,
		[Token(Token = "0x400D316")]
		BeeForce,
		[Token(Token = "0x400D317")]
		Message,
		[Token(Token = "0x400D318")]
		DarkFusion,
		[Token(Token = "0x400D319")]
		Destroy,
		[Token(Token = "0x400D31A")]
		DestroyGod,
		[Token(Token = "0x400D31B")]
		DreamMirror,
		[Token(Token = "0x400D31C")]
		Zanki,
		[Token(Token = "0x400D31D")]
		DragonMaid,
		[Token(Token = "0x400D31E")]
		Generade,
		[Token(Token = "0x400D31F")]
		Ignister,
		[Token(Token = "0x400D320")]
		Ai,
		[Token(Token = "0x400D321")]
		SenKa,
		[Token(Token = "0x400D322")]
		Megalith,
		[Token(Token = "0x400D323")]
		Oracle,
		[Token(Token = "0x400D324")]
		Onomato,
		[Token(Token = "0x400D325")]
		Future,
		[Token(Token = "0x400D326")]
		Rose,
		[Token(Token = "0x400D327")]
		Rebellion,
		[Token(Token = "0x400D328")]
		CodeBreaker,
		[Token(Token = "0x400D329")]
		Nemesis,
		[Token(Token = "0x400D32A")]
		Barbaros,
		[Token(Token = "0x400D32B")]
		Pirates,
		[Token(Token = "0x400D32C")]
		Adamassiah,
		[Token(Token = "0x400D32D")]
		Rikka,
		[Token(Token = "0x400D32E")]
		Eldlich,
		[Token(Token = "0x400D32F")]
		Eldlixir,
		[Token(Token = "0x400D330")]
		GoldenLand,
		[Token(Token = "0x400D331")]
		Phantasm,
		[Token(Token = "0x400D332")]
		PhantasmCard,
		[Token(Token = "0x400D333")]
		GaiaCard,
		[Token(Token = "0x400D334")]
		Dragma,
		[Token(Token = "0x400D335")]
		Melfy,
		[Token(Token = "0x400D336")]
		Potan,
		[Token(Token = "0x400D337")]
		Roland,
		[Token(Token = "0x400D338")]
		KoakimailCard,
		[Token(Token = "0x400D339")]
		RaCard,
		[Token(Token = "0x400D33A")]
		MeklordGod,
		[Token(Token = "0x400D33B")]
		JinzoCard,
		[Token(Token = "0x400D33C")]
		FossilCard,
		[Token(Token = "0x400D33D")]
		Numeron,
		[Token(Token = "0x400D33E")]
		GateOfNumeron,
		[Token(Token = "0x400D33F")]
		Kikai,
		[Token(Token = "0x400D340")]
		Hyoui,
		[Token(Token = "0x400D341")]
		SpiritEarth,
		[Token(Token = "0x400D342")]
		SpiritWater,
		[Token(Token = "0x400D343")]
		SpiritFire,
		[Token(Token = "0x400D344")]
		SpiritWind,
		[Token(Token = "0x400D345")]
		ToonCard,
		[Token(Token = "0x400D346")]
		TriBrigade,
		[Token(Token = "0x400D347")]
		DennoKai,
		[Token(Token = "0x400D348")]
		DennoKaiMon,
		[Token(Token = "0x400D349")]
		SouTen,
		[Token(Token = "0x400D34A")]
		Magistus,
		[Token(Token = "0x400D34B")]
		KissKill,
		[Token(Token = "0x400D34C")]
		LeeLa,
		[Token(Token = "0x400D34D")]
		LiveTwin,
		[Token(Token = "0x400D34E")]
		EvilTwin,
		[Token(Token = "0x400D34F")]
		Drytron,
		[Token(Token = "0x400D350")]
		Myutant,
		[Token(Token = "0x400D351")]
		Spriggans,
		[Token(Token = "0x400D352")]
		SForce,
		[Token(Token = "0x400D353")]
		WightCard,
		[Token(Token = "0x400D354")]
		Sacrifice,
		[Token(Token = "0x400D355")]
		CypherDragon,
		[Token(Token = "0x400D356")]
		SaintAvalon,
		[Token(Token = "0x400D357")]
		SaintVine,
		[Token(Token = "0x400D358")]
		HolyKnights,
		[Token(Token = "0x400D359")]
		Amazement,
		[Token(Token = "0x400D35A")]
		Attraction,
		[Token(Token = "0x400D35B")]
		Brand,
		[Token(Token = "0x400D35C")]
		ZexalServus,
		[Token(Token = "0x400D35D")]
		Zexal,
		[Token(Token = "0x400D35E")]
		RDM,
		[Token(Token = "0x400D35F")]
		WarCry,
		[Token(Token = "0x400D360")]
		Matereactor,
		[Token(Token = "0x400D361")]
		DollMonster,
		[Token(Token = "0x400D362")]
		BlackRoseCard,
		[Token(Token = "0x400D363")]
		Underworld,
		[Token(Token = "0x400D364")]
		DoReMiCode,
		[Token(Token = "0x400D365")]
		Bearkuty,
		[Token(Token = "0x400D366")]
		Despear,
		[Token(Token = "0x400D367")]
		ForestSpirit,
		[Token(Token = "0x400D368")]
		MagicKey,
		[Token(Token = "0x400D369")]
		StardustCard,
		[Token(Token = "0x400D36A")]
		GunKan,
		[Token(Token = "0x400D36B")]
		Cyber,
		[Token(Token = "0x400D36C")]
		Kragen,
		[Token(Token = "0x400D36D")]
		Numeronius,
		[Token(Token = "0x400D36E")]
		ArcanaCard,
		[Token(Token = "0x400D36F")]
		ACounter,
		[Token(Token = "0x400D370")]
		KuribohMagic,
		[Token(Token = "0x400D371")]
		NumbersCard,
		[Token(Token = "0x400D372")]
		SouKen,
		[Token(Token = "0x400D373")]
		HiSui,
		[Token(Token = "0x400D374")]
		Fuwandaries,
		[Token(Token = "0x400D375")]
		Topologic,
		[Token(Token = "0x400D376")]
		AlbazCard,
		[Token(Token = "0x400D377")]
		DHeroMagic,
		[Token(Token = "0x400D378")]
		DualMagic,
		[Token(Token = "0x400D379")]
		SaintSeed,
		[Token(Token = "0x400D37A")]
		BeeTrooper,
		[Token(Token = "0x400D37B")]
		Hyperion,
		[Token(Token = "0x400D37C")]
		PUNK,
		[Token(Token = "0x400D37D")]
		ExoSister,
		[Token(Token = "0x400D37E")]
		BraveToken,
		[Token(Token = "0x400D37F")]
		Dinorfear,
		[Token(Token = "0x400D380")]
		DevilLady,
		[Token(Token = "0x400D381")]
		BlueEyesCard,
		[Token(Token = "0x400D382")]
		Seventh,
		[Token(Token = "0x400D383")]
		Barians,
		[Token(Token = "0x400D384")]
		Leviathan,
		[Token(Token = "0x400D385")]
		SeaStealth,
		[Token(Token = "0x400D386")]
		Umi,
		[Token(Token = "0x400D387")]
		Puppet,
		[Token(Token = "0x400D388")]
		Libromancer,
		[Token(Token = "0x400D389")]
		Serions,
		[Token(Token = "0x400D38A")]
		Scarecrow,
		[Token(Token = "0x400D38B")]
		Barbarian,
		[Token(Token = "0x400D38C")]
		Variants,
		[Token(Token = "0x400D38D")]
		Labryrinth,
		[Token(Token = "0x400D38E")]
		Welcome,
		[Token(Token = "0x400D38F")]
		Rune,
		[Token(Token = "0x400D390")]
		EHeroMagic,
		[Token(Token = "0x400D391")]
		Sprite,
		[Token(Token = "0x400D392")]
		Tiaraments,
		[Token(Token = "0x400D393")]
		HaruKeSho,
		[Token(Token = "0x400D394")]
		Wingman,
		[Token(Token = "0x400D395")]
		MokeyMokey,
		[Token(Token = "0x400D396")]
		ExchangeCard,
		[Token(Token = "0x400D397")]
		AJewel,
		[Token(Token = "0x400D398")]
		DoodleBeast,
		[Token(Token = "0x400D399")]
		DoodleBook,
		[Token(Token = "0x400D39A")]
		GGolem,
		[Token(Token = "0x400D39B")]
		Bridge,
		[Token(Token = "0x400D39C")]
		Ghotis,
		[Token(Token = "0x400D39D")]
		Beasted,
		[Token(Token = "0x400D39E")]
		Ksatrira,
		[Token(Token = "0x400D39F")]
		BFDCard,
		[Token(Token = "0x400D3A0")]
		RAce,
		[Token(Token = "0x400D3A1")]
		Purely,
		[Token(Token = "0x400D3A2")]
		Mikanko,
		[Token(Token = "0x400D3A3")]
		ChaosSync,
		[Token(Token = "0x400D3A4")]
		AquaMirror,
		[Token(Token = "0x400D3A5")]
		InferNobleKnight,
		[Token(Token = "0x400D3A6")]
		VisasCard,
		[Token(Token = "0x400D3A7")]
		LabyrinthWall,
		[Token(Token = "0x400D3A8")]
		MashinCard,
		[Token(Token = "0x400D3A9")]
		GateGuardian,
		[Token(Token = "0x400D3AA")]
		GP,
		[Token(Token = "0x400D3AB")]
		FireWall,
		[Token(Token = "0x400D3AC")]
		ManaDoom,
		[Token(Token = "0x400D3AD")]
		Nemreria,
		[Token(Token = "0x400D3AE")]
		GranDoReMiCode,
		[Token(Token = "0x400D3AF")]
		Favorite,
		[Token(Token = "0x400D3B0")]
		VS,
		[Token(Token = "0x400D3B1")]
		Nouvellez,
		[Token(Token = "0x400D3B2")]
		Recipe,
		[Token(Token = "0x400D3B3")]
		Visas,
		[Token(Token = "0x400D3B4")]
		InferHolySword,
		[Token(Token = "0x400D3B5")]
		Sync,
		[Token(Token = "0x400D3B6")]
		RedDragonCard,
		[Token(Token = "0x400D3B7")]
		ChimeraCard,
		[Token(Token = "0x400D3B8")]
		CharlesCard,
		[Token(Token = "0x400D3B9")]
		Counter,
		[Token(Token = "0x400D3BA")]
		BurningKnuckle,
		[Token(Token = "0x400D3BB")]
		EarthBind,
		[Token(Token = "0x400D3BC")]
		RedDemonCard,
		[Token(Token = "0x400D3BD")]
		Tystina,
		[Token(Token = "0x400D3BE")]
		Zaihou,
		[Token(Token = "0x400D3BF")]
		SnakeEye,
		[Token(Token = "0x400D3C0")]
		Horus,
		[Token(Token = "0x400D3C1")]
		ArmoredXyz,
		[Token(Token = "0x400D3C2")]
		Veda,
		[Token(Token = "0x400D3C3")]
		Diavelstar,
		[Token(Token = "0x400D3C4")]
		Patissciel,
		[Token(Token = "0x400D3C5")]
		Heart,
		[Token(Token = "0x400D3C6")]
		SpiritMagic,
		[Token(Token = "0x400D3C7")]
		ZarcCard,
		[Token(Token = "0x400D3C8")]
		Memento,
		[Token(Token = "0x400D3C9")]
		Centurion,
		[Token(Token = "0x400D3CA")]
		Varmonica,
		[Token(Token = "0x400D3CB")]
		Yubel,
		[Token(Token = "0x400D3CC")]
		YubelCard,
		[Token(Token = "0x400D3CD")]
		GoblinRider,
		[Token(Token = "0x400D3CE")]
		Purge,
		[Token(Token = "0x400D3CF")]
		LowGuardian,
		[Token(Token = "0x400D3D0")]
		TuningFish,
		[Token(Token = "0x400D3D1")]
		WhiteAura,
		[Token(Token = "0x400D3D2")]
		FireKnightCard,
		[Token(Token = "0x400D3D3")]
		Salamandra,
		[Token(Token = "0x400D3D4")]
		Toy,
		[Token(Token = "0x400D3D5")]
		Kaimetsu,
		[Token(Token = "0x400D3D6")]
		SarcophagusCard,
		[Token(Token = "0x400D3D7")]
		Raika,
		[Token(Token = "0x400D3D8")]
		TenPaiRyu,
		[Token(Token = "0x400D3D9")]
		SanGen,
		[Token(Token = "0x400D3DA")]
		Millennium,
		[Token(Token = "0x400D3DB")]
		WhiteForest,
		[Token(Token = "0x400D3DC")]
		DemonSmith,
		[Token(Token = "0x400D3DD")]
		Emblema,
		[Token(Token = "0x400D3DE")]
		Exxod,
		[Token(Token = "0x400D3DF")]
		PuppetTrap,
		[Token(Token = "0x400D3E0")]
		Mulcharmy,
		[Token(Token = "0x400D3E1")]
		Tachyon,
		[Token(Token = "0x400D3E2")]
		UnionMagic,
		[Token(Token = "0x400D3E3")]
		BlueTears,
		[Token(Token = "0x400D3E4")]
		Sekiban,
		[Token(Token = "0x400D3E5")]
		ClearWorld,
		[Token(Token = "0x400D3E6")]
		Mimiguru,
		[Token(Token = "0x400D3E7")]
		Shark,
		[Token(Token = "0x400D3E8")]
		SharkDrake,
		[Token(Token = "0x400D3E9")]
		Metalmorph,
		[Token(Token = "0x400D3EA")]
		MetalCard,
		[Token(Token = "0x400D3EB")]
		Genseki,
		[Token(Token = "0x400D3EC")]
		Azamina,
		[Token(Token = "0x400D3ED")]
		SixStrike,
		[Token(Token = "0x400D3EE")]
		Morganite,
		[Token(Token = "0x400D3EF")]
		Shukudai,
		[Token(Token = "0x400D3F0")]
		Raizeol,
		[Token(Token = "0x400D3F1")]
		Malice,
		[Token(Token = "0x400D3F2")]
		RyuGe,
		[Token(Token = "0x400D3F3")]
		Multi2,
		[Token(Token = "0x400D3F4")]
		Gladial2,
		[Token(Token = "0x400D3F5")]
		Diavel,
		[Token(Token = "0x400D3F6")]
		ARGStarS,
		[Token(Token = "0x400D3F7")]
		AquaJet,
		[Token(Token = "0x400D3F8")]
		DragonRuler,
		[Token(Token = "0x400D3F9")]
		KingTempleCard,
		[Token(Token = "0x400D3FA")]
		Apophis,
		[Token(Token = "0x400D3FB")]
		Serket,
		[Token(Token = "0x400D3FC")]
		Mitsurugi,
		[Token(Token = "0x400D3FD")]
		MoterTokenCard,
		[Token(Token = "0x400D3FE")]
		ReGenesis,
		[Token(Token = "0x400D3FF")]
		AncientFairyCard,
		[Token(Token = "0x400D400")]
		Dominus,
		[Token(Token = "0x400D401")]
		DragonTail,
		[Token(Token = "0x400D402")]
		Yummy,
		[Token(Token = "0x400D403")]
		K9,
		[Token(Token = "0x400D404")]
		Teleport,
		[Token(Token = "0x400D405")]
		Altmegia,
		[Token(Token = "0x400D406")]
		Gokushin,
		[Token(Token = "0x400D407")]
		DoomZ,
		[Token(Token = "0x400D408")]
		Kenran,
		[Token(Token = "0x400D409")]
		CEO,
		[Token(Token = "0x400D40A")]
		RB,
		[Token(Token = "0x400D40B")]
		Koala,
		[Token(Token = "0x400D40C")]
		MacroCosmosCard,
		[Token(Token = "0x400D40D")]
		Hecatoncheir,
		[Token(Token = "0x400D40E")]
		EnneaCraft,
		[Token(Token = "0x400D40F")]
		KillerTune,
		[Token(Token = "0x400D410")]
		JunkWarriorCard,
		[Token(Token = "0x400D411")]
		BossRushCard,
		[Token(Token = "0x400D412")]
		Ecclesia,
		[Token(Token = "0x400D413")]
		ElfenNotes,
		[Token(Token = "0x400D414")]
		Magnet,
		[Token(Token = "0x400D415")]
		RegulusCard,
		[Token(Token = "0x400D416")]
		GMX,
		[Token(Token = "0x400D417")]
		LivingDeadCard,
		[Token(Token = "0x400D418")]
		CrownCran,
		[Token(Token = "0x400D419")]
		FairyTail,
		[Token(Token = "0x400D41A")]
		HChampion,
		[Token(Token = "0x400D41B")]
		DT,
		[Token(Token = "0x400D41C")]
		ChaosRitualCard,
		[Token(Token = "0x400D41D")]
		_3Phantasm,
		[Token(Token = "0x400D41E")]
		Blitzkrieg,
		[Token(Token = "0x400D41F")]
		Aleister,
		[Token(Token = "0x400D420")]
		InvocationCard,
		[Token(Token = "0x400D421")]
		Theorealize,
		[Token(Token = "0x400D422")]
		Max
	}

	[Token(Token = "0x20015FC")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		[Token(Token = "0x400D423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] data;

		[Token(Token = "0x60088E8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass57_0()
		{
		}

		[Token(Token = "0x60088E9")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CLoadBinaryAsync_003Eb__6(byte[] d)
		{
		}
	}

	[Token(Token = "0x20015FD")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_1
	{
		[Token(Token = "0x400D424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] data;

		[Token(Token = "0x60088EA")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass57_1()
		{
		}

		[Token(Token = "0x60088EB")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CLoadBinaryAsync_003Eb__7(byte[] d)
		{
		}
	}

	[Token(Token = "0x20015FF")]
	[CompilerGenerated]
	private sealed class _003CGetBytesDecryptionDataAsync_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Content _003C_003E4__this;

		[Token(Token = "0x400D42A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x400D42B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<byte[]> resultCallback;

		[Token(Token = "0x400D42C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Task<byte[]> _003Ctask_003E5__2;

		[Token(Token = "0x170014F7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60088F1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014F8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60088F3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60088EE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetBytesDecryptionDataAsync_003Ed__64(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60088EF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60088F0")]
		[Address(RVA = "0xD59200", Offset = "0xD58400", VA = "0x180D59200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60088F2")]
		[Address(RVA = "0xD593C0", Offset = "0xD585C0", VA = "0x180D593C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001600")]
	[CompilerGenerated]
	private sealed class _003CLoadBinaryAsync_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D42D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D42E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D42F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Content _003C_003E4__this;

		[Token(Token = "0x400D430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

		[Token(Token = "0x400D431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass57_1 _003C_003E8__2;

		[Token(Token = "0x400D432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _003Cfailed_003E5__2;

		[Token(Token = "0x400D433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x400D434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _003CLangDataPath_003E5__4;

		[Token(Token = "0x170014F9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60088F7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014FA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60088F9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60088F4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadBinaryAsync_003Ed__57(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60088F5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60088F6")]
		[Address(RVA = "0xD59400", Offset = "0xD58600", VA = "0x180D59400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60088F8")]
		[Address(RVA = "0xD5A730", Offset = "0xD59930", VA = "0x180D5A730", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001601")]
	[CompilerGenerated]
	private sealed class _003CLoadCardRarityBinaryAsync_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Content _003C_003E4__this;

		[Token(Token = "0x170014FB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60088FD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014FC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60088FF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60088FA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadCardRarityBinaryAsync_003Ed__59(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60088FB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60088FC")]
		[Address(RVA = "0xD5A770", Offset = "0xD59970", VA = "0x180D5A770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60088FE")]
		[Address(RVA = "0xD5ABB0", Offset = "0xD59DB0", VA = "0x180D5ABB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001602")]
	[CompilerGenerated]
	private sealed class _003CcoCreateCardList_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D43A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Content _003C_003E4__this;

		[Token(Token = "0x400D43B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<int> _003Clist_003E5__2;

		[Token(Token = "0x400D43C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] _003Cbytes_003E5__3;

		[Token(Token = "0x400D43D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003Cnum_003E5__4;

		[Token(Token = "0x400D43E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _003CperFrame_003E5__5;

		[Token(Token = "0x400D43F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003Cc_003E5__6;

		[Token(Token = "0x170014FD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008903")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014FE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008905")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008900")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcoCreateCardList_003Ed__107(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008901")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008902")]
		[Address(RVA = "0xD5C6C0", Offset = "0xD5B8C0", VA = "0x180D5C6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008904")]
		[Address(RVA = "0xD5C8D0", Offset = "0xD5BAD0", VA = "0x180D5C8D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Content s_instance;

	[Token(Token = "0x400D063")]
	private const int Streams_CardIndex = 0;

	[Token(Token = "0x400D064")]
	private const int Streams_CardName = 1;

	[Token(Token = "0x400D065")]
	private const int Streams_CardDesc = 2;

	[Token(Token = "0x400D066")]
	private const int Streams_WordIndex = 3;

	[Token(Token = "0x400D067")]
	private const int Streams_WordText = 4;

	[Token(Token = "0x400D068")]
	private const int Streams_DialogIndex = 5;

	[Token(Token = "0x400D069")]
	private const int Streams_DialogText = 6;

	[Token(Token = "0x400D06A")]
	private const int Streams_CardPidx = 7;

	[Token(Token = "0x400D06B")]
	private const int Streams_CardPart = 8;

	[Token(Token = "0x400D06C")]
	private const int Streams_RubyIndex = 9;

	[Token(Token = "0x400D06D")]
	private const int Streams_RubyName = 10;

	[Token(Token = "0x400D06E")]
	private const int Streams_Length = 11;

	[Token(Token = "0x400D06F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string[] DataPathForStream;

	[Token(Token = "0x400D070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Stream[] cardStreams;

	[Token(Token = "0x400D071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string IntIdPath;

	[Token(Token = "0x400D072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string PropPath;

	[Token(Token = "0x400D073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string SamePath;

	[Token(Token = "0x400D074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string GenrePath;

	[Token(Token = "0x400D075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string NamedPath;

	[Token(Token = "0x400D076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string LinkPath;

	[Token(Token = "0x400D077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string SearchNamePath;

	[Token(Token = "0x400D078")]
	public const string NEWLINE_TAG = "\n";

	[Token(Token = "0x400D079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private byte[] cardIntIds;

	[Token(Token = "0x400D07A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private byte[] cardProps;

	[Token(Token = "0x400D07B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private byte[] cardSame;

	[Token(Token = "0x400D07C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private byte[] cardGenre;

	[Token(Token = "0x400D07D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private byte[] cardNamed;

	[Token(Token = "0x400D07E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private byte[] cardLink;

	[Token(Token = "0x400D07F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string CardRarityData;

	[Token(Token = "0x400D080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public string DeclaraCardAllPath;

	[Token(Token = "0x400D081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string DeclaraCardDeckPath;

	[Token(Token = "0x400D082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string DeclaraCardMonstPath;

	[Token(Token = "0x400D083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string DeclaraCardMonst2Path;

	[Token(Token = "0x400D084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string DeclaraCardGadgetPath;

	[Token(Token = "0x400D085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string DeclaraCardGunkanSushipPath;

	[Token(Token = "0x400D086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string DeclaraCardNormalMonsterPath;

	[Token(Token = "0x400D087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public string DeclaraCardArtmageMonsterPath;

	[Token(Token = "0x400D088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Dictionary<string, int[]> dicDeclaraCard;

	[Token(Token = "0x400D089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Dictionary<int, string> dicSearchName;

	[Token(Token = "0x400D08A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int cardNum;

	[Token(Token = "0x400D08B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private bool isReady;

	[Token(Token = "0x400D08C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
	private bool isLoadSuccess;

	[Token(Token = "0x400D08D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE6")]
	private bool m_AdditionalChangeLineTag;

	[Token(Token = "0x400D08E")]
	private const string dclsymbol = "\n\n";

	[Token(Token = "0x400D08F")]
	private const string clsymbol = "\n";

	[Token(Token = "0x400D090")]
	private const string periodsymbol = "。";

	[Token(Token = "0x400D091")]
	private const string periodclsymbol = "。\n";

	[Token(Token = "0x400D092")]
	private const string periodclsymbolblacket = "。\n）";

	[Token(Token = "0x400D093")]
	private const string periodblacket = "。）";

	[Token(Token = "0x400D094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string[] spiltTags;

	[Token(Token = "0x400D095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string[] spiltTags_Korean;

	[Token(Token = "0x400D096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private List<int> allCardList;

	[Token(Token = "0x400D097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Dictionary<int, int> sortIdx;

	[Token(Token = "0x400D098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int m_iCryptoKey;

	[Token(Token = "0x400D099")]
	public const float Witdh = 5.9f;

	[Token(Token = "0x400D09A")]
	public const float Height = 8.6f;

	[Token(Token = "0x400D09B")]
	public const float Aspect = 0.6860465f;

	[Token(Token = "0x400D09C")]
	public const int AttributeWordStart = 10;

	[Token(Token = "0x400D09D")]
	public const int TypeWordStart = 100;

	[Token(Token = "0x400D09E")]
	public const int IconWordStart = 50;

	[Token(Token = "0x400D09F")]
	public const int FrameNum = 20;

	[Token(Token = "0x400D0A0")]
	public const int KindWordStart = 200;

	[Token(Token = "0x400D0A1")]
	public const int GenreMax = 49;

	[Token(Token = "0x400D0A2")]
	private const string LIBNAME = "duel";

	[Token(Token = "0x170014E9")]
	public static Content Instance
	{
		[Token(Token = "0x6008844")]
		[Address(RVA = "0xD16F10", Offset = "0xD16110", VA = "0x180D16F10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014EA")]
	public static bool IsReady
	{
		[Token(Token = "0x6008847")]
		[Address(RVA = "0xD16FF0", Offset = "0xD161F0", VA = "0x180D16FF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014EB")]
	public static bool IsLoadSuccess
	{
		[Token(Token = "0x6008848")]
		[Address(RVA = "0xD16F60", Offset = "0xD16160", VA = "0x180D16F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008841")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void DebugPrintDataPath(string path)
	{
	}

	[Token(Token = "0x6008842")]
	[Address(RVA = "0xD140A0", Offset = "0xD132A0", VA = "0x180D140A0")]
	private void InitializeDataPath()
	{
	}

	[Token(Token = "0x6008843")]
	[Address(RVA = "0x9FA490", Offset = "0x9F9690", VA = "0x1809FA490")]
	private void TerminateDataPath()
	{
	}

	[Token(Token = "0x6008845")]
	[Address(RVA = "0xD0E700", Offset = "0xD0D900", VA = "0x180D0E700")]
	public static void Create()
	{
	}

	[Token(Token = "0x6008846")]
	[Address(RVA = "0xD103C0", Offset = "0xD0F5C0", VA = "0x180D103C0")]
	public static void Destroy()
	{
	}

	[Token(Token = "0x6008849")]
	[Address(RVA = "0xD13E70", Offset = "0xD13070", VA = "0x180D13E70")]
	public void Init()
	{
	}

	[Token(Token = "0x600884A")]
	[Address(RVA = "0xD14F20", Offset = "0xD14120", VA = "0x180D14F20")]
	[IteratorStateMachine(typeof(_003CLoadBinaryAsync_003Ed__57))]
	private IEnumerator LoadBinaryAsync()
	{
		return null;
	}

	[Token(Token = "0x600884B")]
	[Address(RVA = "0xD15000", Offset = "0xD14200", VA = "0x180D15000")]
	public void LoadCardRarityBinary()
	{
	}

	[Token(Token = "0x600884C")]
	[Address(RVA = "0xD14F90", Offset = "0xD14190", VA = "0x180D14F90")]
	[IteratorStateMachine(typeof(_003CLoadCardRarityBinaryAsync_003Ed__59))]
	private IEnumerator LoadCardRarityBinaryAsync()
	{
		return null;
	}

	[Token(Token = "0x600884D")]
	[Address(RVA = "0xD0FAC0", Offset = "0xD0ECC0", VA = "0x180D0FAC0")]
	public static void DeclaraCardCheckOpenCard(Dictionary<string, object> dicOpenCard)
	{
	}

	[Token(Token = "0x600884E")]
	[Address(RVA = "0xD15110", Offset = "0xD14310", VA = "0x180D15110")]
	public void Release()
	{
	}

	[Token(Token = "0x600884F")]
	[Address(RVA = "0xD15300", Offset = "0xD14500", VA = "0x180D15300")]
	public void Reload()
	{
	}

	[Token(Token = "0x6008850")]
	[Address(RVA = "0xD10BE0", Offset = "0xD0FDE0", VA = "0x180D10BE0")]
	private byte[] GetBytesDecryptionData(string path)
	{
		return null;
	}

	[Token(Token = "0x6008851")]
	[Address(RVA = "0xD10A70", Offset = "0xD0FC70", VA = "0x180D10A70")]
	[IteratorStateMachine(typeof(_003CGetBytesDecryptionDataAsync_003Ed__64))]
	private IEnumerator GetBytesDecryptionDataAsync(string path, Action<byte[]> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6008852")]
	[Address(RVA = "0xD10B20", Offset = "0xD0FD20", VA = "0x180D10B20")]
	private byte[] GetBytesDecryptionDataCore(byte[] outData)
	{
		return null;
	}

	[Token(Token = "0x6008853")]
	[Address(RVA = "0xD12A00", Offset = "0xD11C00", VA = "0x180D12A00")]
	public string GetName(int cardId, bool replaceAlnum = true)
	{
		return null;
	}

	[Token(Token = "0x6008854")]
	[Address(RVA = "0xD13470", Offset = "0xD12670", VA = "0x180D13470")]
	public string GetRubyName(int cardId, bool replaceAlnum = true)
	{
		return null;
	}

	[Token(Token = "0x6008855")]
	[Address(RVA = "0xD11750", Offset = "0xD10950", VA = "0x180D11750")]
	public string GetDesc(int cardId, bool replaceAlnum = true)
	{
		return null;
	}

	[Token(Token = "0x6008856")]
	[Address(RVA = "0xD13080", Offset = "0xD12280", VA = "0x180D13080")]
	public string GetRawDesc(int cardId)
	{
		return null;
	}

	[Token(Token = "0x6008857")]
	[Address(RVA = "0xD11610", Offset = "0xD10810", VA = "0x180D11610")]
	public string GetDescWithoutPendulum(int cardId, bool replaceAlnum = true)
	{
		return null;
	}

	[Token(Token = "0x6008858")]
	[Address(RVA = "0xD11300", Offset = "0xD10500", VA = "0x180D11300")]
	public string GetDescOfPendulum(int cardId, bool replaceAlnum = true)
	{
		return null;
	}

	[Token(Token = "0x6008859")]
	[Address(RVA = "0xD11440", Offset = "0xD10640", VA = "0x180D11440")]
	public string GetDescWithoutPendulumForCardInfo(int cardId, bool replaceAlnum = true)
	{
		return null;
	}

	[Token(Token = "0x600885A")]
	[Address(RVA = "0xD11170", Offset = "0xD10370", VA = "0x180D11170")]
	public string GetDescOfPendulumForCardInfo(int cardId, bool replaceAlnum = true)
	{
		return null;
	}

	[Token(Token = "0x600885B")]
	[Address(RVA = "0xD0E350", Offset = "0xD0D550", VA = "0x180D0E350")]
	private void AddChangeLineTag(ref string str)
	{
	}

	[Token(Token = "0x600885C")]
	[Address(RVA = "0xD0DF20", Offset = "0xD0D120", VA = "0x180D0DF20")]
	private void AddChangeLineTagByEffectText(ref string str, int cardId, bool isPendulum)
	{
	}

	[Token(Token = "0x600885D")]
	[Address(RVA = "0xD16A20", Offset = "0xD15C20", VA = "0x180D16A20")]
	private string getString(int id, Stream indexStream, Stream textStream)
	{
		return null;
	}

	[Token(Token = "0x600885E")]
	[Address(RVA = "0xD15320", Offset = "0xD14520", VA = "0x180D15320")]
	public static string ReplaceAlnum(string str)
	{
		return null;
	}

	[Token(Token = "0x600885F")]
	[Address(RVA = "0xD11BB0", Offset = "0xD10DB0", VA = "0x180D11BB0")]
	public string GetDialogText(int dlgtextId)
	{
		return null;
	}

	[Token(Token = "0x6008860")]
	[Address(RVA = "0xD13DE0", Offset = "0xD12FE0", VA = "0x180D13DE0")]
	public string GetWordText(int wordId)
	{
		return null;
	}

	[Token(Token = "0x6008861")]
	[Address(RVA = "0xD16390", Offset = "0xD15590", VA = "0x180D16390")]
	private string getDescActiveEffect(int cardId, int numOfEfx)
	{
		return null;
	}

	[Token(Token = "0x6008862")]
	[Address(RVA = "0xD13C50", Offset = "0xD12E50", VA = "0x180D13C50")]
	public int GetTextIDOfActiveEffect(int cardId, int numOfEfx)
	{
		return default(int);
	}

	[Token(Token = "0x6008863")]
	[Address(RVA = "0xD10470", Offset = "0xD0F670", VA = "0x180D10470")]
	public (int, int) GetActiveEffectPosInText(int textId)
	{
		return default((int, int));
	}

	[Token(Token = "0x6008864")]
	[Address(RVA = "0xD10DF0", Offset = "0xD0FFF0", VA = "0x180D10DF0")]
	public int GetCardIdFromTextId(int textId)
	{
		return default(int);
	}

	[Token(Token = "0x6008865")]
	[Address(RVA = "0xD12FC0", Offset = "0xD121C0", VA = "0x180D12FC0")]
	public string GetPendulumTag()
	{
		return null;
	}

	[Token(Token = "0x6008866")]
	[Address(RVA = "0xD10950", Offset = "0xD0FB50", VA = "0x180D10950")]
	public string GetAttributeText(Attribute attr)
	{
		return null;
	}

	[Token(Token = "0x6008867")]
	[Address(RVA = "0xD108F0", Offset = "0xD0FAF0", VA = "0x180D108F0")]
	public string GetAttributeRuby(Attribute attr)
	{
		return null;
	}

	[Token(Token = "0x6008868")]
	[Address(RVA = "0xD13CD0", Offset = "0xD12ED0", VA = "0x180D13CD0")]
	public string GetTypeText(Type type)
	{
		return null;
	}

	[Token(Token = "0x6008869")]
	[Address(RVA = "0xD11F50", Offset = "0xD11150", VA = "0x180D11F50")]
	public string GetIconText(Icon icon)
	{
		return null;
	}

	[Token(Token = "0x600886A")]
	[Address(RVA = "0xD11CF0", Offset = "0xD10EF0", VA = "0x180D11CF0")]
	public string GetIconFullText(int cardId)
	{
		return null;
	}

	[Token(Token = "0x600886B")]
	[Address(RVA = "0xD11EB0", Offset = "0xD110B0", VA = "0x180D11EB0")]
	public string GetIconFullText(Attribute attr, Icon icon)
	{
		return null;
	}

	[Token(Token = "0x600886C")]
	[Address(RVA = "0xD129A0", Offset = "0xD11BA0", VA = "0x180D129A0")]
	public string GetMagicFullText(Icon icon)
	{
		return null;
	}

	[Token(Token = "0x600886D")]
	[Address(RVA = "0xD13C70", Offset = "0xD12E70", VA = "0x180D13C70")]
	public string GetTrapFullText(Icon icon)
	{
		return null;
	}

	[Token(Token = "0x600886E")]
	[Address(RVA = "0xD12060", Offset = "0xD11260", VA = "0x180D12060")]
	public string GetKindText(Kind kind)
	{
		return null;
	}

	[Token(Token = "0x600886F")]
	[Address(RVA = "0xD13B10", Offset = "0xD12D10", VA = "0x180D13B10")]
	public string GetSortName(int mrk)
	{
		return null;
	}

	[Token(Token = "0x6008870")]
	[Address(RVA = "0xD10550", Offset = "0xD0F750", VA = "0x180D10550")]
	public List<int> GetAllCardList()
	{
		return null;
	}

	[Token(Token = "0x6008871")]
	[Address(RVA = "0xD148D0", Offset = "0xD13AD0", VA = "0x180D148D0")]
	public bool IsExists(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x6008872")]
	[Address(RVA = "0xD14ED0", Offset = "0xD140D0", VA = "0x180D14ED0")]
	public bool IsValid(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x6008873")]
	[Address(RVA = "0xD15FE0", Offset = "0xD151E0", VA = "0x180D15FE0")]
	[IteratorStateMachine(typeof(_003CcoCreateCardList_003Ed__107))]
	private IEnumerator coCreateCardList()
	{
		return null;
	}

	[Token(Token = "0x6008874")]
	[Address(RVA = "0xD17270", Offset = "0xD16470", VA = "0x180D17270")]
	private void releaseAllCardList()
	{
	}

	[Token(Token = "0x6008875")]
	[Address(RVA = "0xD10CB0", Offset = "0xD0FEB0", VA = "0x180D10CB0")]
	public long GetCardGenre(int mrk)
	{
		return default(long);
	}

	[Token(Token = "0x6008876")]
	[Address(RVA = "0xD17240", Offset = "0xD16440", VA = "0x180D17240")]
	private int readInt8(byte[] bytes, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6008877")]
	[Address(RVA = "0xD17080", Offset = "0xD16280", VA = "0x180D17080")]
	private int readInt16(byte[] bytes, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6008878")]
	[Address(RVA = "0xD170C0", Offset = "0xD162C0", VA = "0x180D170C0")]
	private int readInt32(byte[] bytes, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6008879")]
	[Address(RVA = "0xD17130", Offset = "0xD16330", VA = "0x180D17130")]
	private long readInt64(byte[] bytes, int pos)
	{
		return default(long);
	}

	[Token(Token = "0x600887A")]
	[Address(RVA = "0xD15840", Offset = "0xD14A40", VA = "0x180D15840")]
	private void SetSearchName(byte[] data)
	{
	}

	[Token(Token = "0x600887B")]
	[Address(RVA = "0xD16050", Offset = "0xD15250", VA = "0x180D16050")]
	private int[] createDeclarationCard(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600887C")]
	[Address(RVA = "0xD10F10", Offset = "0xD10110", VA = "0x180D10F10")]
	public List<int> GetDeclarationCard(string path)
	{
		return null;
	}

	[Token(Token = "0x600887D")]
	[Address(RVA = "0xD150C0", Offset = "0xD142C0", VA = "0x180D150C0")]
	public void ReleaseDeclarationCard()
	{
	}

	[Token(Token = "0x600887E")]
	[Address(RVA = "0xD16120", Offset = "0xD15320", VA = "0x180D16120")]
	private void createSortIdxList(byte[] bin)
	{
	}

	[Token(Token = "0x600887F")]
	[Address(RVA = "0xD17290", Offset = "0xD16490", VA = "0x180D17290")]
	private void releaseSortIdxList()
	{
	}

	[Token(Token = "0x6008880")]
	[Address(RVA = "0xD13A80", Offset = "0xD12C80", VA = "0x180D13A80")]
	public int GetSortIndexFromMRK(int mrk)
	{
		return default(int);
	}

	[Token(Token = "0x6008881")]
	[Address(RVA = "0xD14930", Offset = "0xD13B30", VA = "0x180D14930")]
	public bool IsExtraDeckCard(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x6008882")]
	[Address(RVA = "0xD149B0", Offset = "0xD13BB0", VA = "0x180D149B0")]
	public bool IsMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008883")]
	[Address(RVA = "0xD14AF0", Offset = "0xD13CF0", VA = "0x180D14AF0")]
	public bool IsNormalMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008884")]
	[Address(RVA = "0xD14870", Offset = "0xD13A70", VA = "0x180D14870")]
	public bool IsEffectMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008885")]
	[Address(RVA = "0xD14EA0", Offset = "0xD140A0", VA = "0x180D14EA0")]
	public bool IsTokenCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008886")]
	[Address(RVA = "0xD14B60", Offset = "0xD13D60", VA = "0x180D14B60")]
	public bool IsRitualMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008887")]
	[Address(RVA = "0xD14990", Offset = "0xD13B90", VA = "0x180D14990")]
	public bool IsLinkMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008888")]
	[Address(RVA = "0xD14B30", Offset = "0xD13D30", VA = "0x180D14B30")]
	public bool IsPendulumMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008889")]
	[Address(RVA = "0xD14EF0", Offset = "0xD140F0", VA = "0x180D14EF0")]
	public bool IsXyzMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x600888A")]
	[Address(RVA = "0xD14B90", Offset = "0xD13D90", VA = "0x180D14B90")]
	public bool IsSyncMonsterCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x600888B")]
	[Address(RVA = "0xD14960", Offset = "0xD13B60", VA = "0x180D14960")]
	public bool IsFusionMonsterCard(int cardId)
	{
		return default(bool);
	}

	[PreserveSig]
	[Token(Token = "0x600888C")]
	[Address(RVA = "0xD0F8F0", Offset = "0xD0EAF0", VA = "0x180D0F8F0")]
	private static extern int DLL_SetCardProperty(byte[] data, int size);

	[PreserveSig]
	[Token(Token = "0x600888D")]
	[Address(RVA = "0xD0FA30", Offset = "0xD0EC30", VA = "0x180D0FA30")]
	private static extern void DLL_SetInternalID(byte[] data);

	[PreserveSig]
	[Token(Token = "0x600888E")]
	[Address(RVA = "0xD0F990", Offset = "0xD0EB90", VA = "0x180D0F990")]
	private static extern void DLL_SetCardSame(byte[] data, int size);

	[PreserveSig]
	[Token(Token = "0x600888F")]
	[Address(RVA = "0xD0F860", Offset = "0xD0EA60", VA = "0x180D0F860")]
	private static extern void DLL_SetCardNamed(byte[] data);

	[PreserveSig]
	[Token(Token = "0x6008890")]
	[Address(RVA = "0xD0F7C0", Offset = "0xD0E9C0", VA = "0x180D0F7C0")]
	private static extern void DLL_SetCardLink(byte[] data, int size);

	[PreserveSig]
	[Token(Token = "0x6008891")]
	[Address(RVA = "0xD0F730", Offset = "0xD0E930", VA = "0x180D0F730")]
	private static extern void DLL_SetCardGenre(byte[] data);

	[PreserveSig]
	[Token(Token = "0x6008892")]
	[Address(RVA = "0xD0EE00", Offset = "0xD0E000", VA = "0x180D0EE00")]
	private static extern int DLL_CardGetInternalID(int cardId);

	[PreserveSig]
	[Token(Token = "0x6008893")]
	[Address(RVA = "0xD0F490", Offset = "0xD0E690", VA = "0x180D0F490")]
	private static extern int DLL_CardGetType(int cardId);

	[PreserveSig]
	[Token(Token = "0x6008894")]
	[Address(RVA = "0xD0EAF0", Offset = "0xD0DCF0", VA = "0x180D0EAF0")]
	private static extern int DLL_CardGetAttr(int cardId);

	[PreserveSig]
	[Token(Token = "0x6008895")]
	[Address(RVA = "0xD0F410", Offset = "0xD0E610", VA = "0x180D0F410")]
	private static extern int DLL_CardGetStar(int cardId);

	[PreserveSig]
	[Token(Token = "0x6008896")]
	[Address(RVA = "0xD0EF00", Offset = "0xD0E100", VA = "0x180D0EF00")]
	private static extern int DLL_CardGetLevel(int cardId);

	[PreserveSig]
	[Token(Token = "0x6008897")]
	[Address(RVA = "0xD0F290", Offset = "0xD0E490", VA = "0x180D0F290")]
	private static extern int DLL_CardGetRank(int cardId);

	[PreserveSig]
	[Token(Token = "0x6008898")]
	[Address(RVA = "0xD0F310", Offset = "0xD0E510", VA = "0x180D0F310")]
	private static extern int DLL_CardGetScaleL(int cardId);

	[PreserveSig]
	[Token(Token = "0x6008899")]
	[Address(RVA = "0xD0F390", Offset = "0xD0E590", VA = "0x180D0F390")]
	private static extern int DLL_CardGetScaleR(int cardId);

	[PreserveSig]
	[Token(Token = "0x600889A")]
	[Address(RVA = "0xD0F110", Offset = "0xD0E310", VA = "0x180D0F110")]
	private static extern int DLL_CardGetLinkNum(int cardId);

	[PreserveSig]
	[Token(Token = "0x600889B")]
	[Address(RVA = "0xD0F090", Offset = "0xD0E290", VA = "0x180D0F090")]
	private static extern int DLL_CardGetLinkMask(int cardId);

	[PreserveSig]
	[Token(Token = "0x600889C")]
	[Address(RVA = "0xD0ED80", Offset = "0xD0DF80", VA = "0x180D0ED80")]
	private static extern int DLL_CardGetIcon(int cardId);

	[PreserveSig]
	[Token(Token = "0x600889D")]
	[Address(RVA = "0xD0ED00", Offset = "0xD0DF00", VA = "0x180D0ED00")]
	private static extern int DLL_CardGetFrame(int cardId);

	[PreserveSig]
	[Token(Token = "0x600889E")]
	[Address(RVA = "0xD0EE80", Offset = "0xD0E080", VA = "0x180D0EE80")]
	private static extern int DLL_CardGetKind(int cardId);

	[PreserveSig]
	[Token(Token = "0x600889F")]
	[Address(RVA = "0xD0EA70", Offset = "0xD0DC70", VA = "0x180D0EA70")]
	private static extern int DLL_CardGetAtk(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A0")]
	[Address(RVA = "0xD0EC80", Offset = "0xD0DE80", VA = "0x180D0EC80")]
	private static extern int DLL_CardGetDef(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A1")]
	[Address(RVA = "0xD0E9F0", Offset = "0xD0DBF0", VA = "0x180D0E9F0")]
	private static extern int DLL_CardGetAtk2(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A2")]
	[Address(RVA = "0xD0EC00", Offset = "0xD0DE00", VA = "0x180D0EC00")]
	private static extern int DLL_CardGetDef2(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A3")]
	[Address(RVA = "0xD0EF80", Offset = "0xD0E180", VA = "0x180D0EF80")]
	private static extern int DLL_CardGetLimitation(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A4")]
	[Address(RVA = "0xD0F510", Offset = "0xD0E710", VA = "0x180D0F510")]
	private static extern int DLL_CardIsThisCardGenre(int cardId, int genreId);

	[PreserveSig]
	[Token(Token = "0x60088A5")]
	[Address(RVA = "0xD0F620", Offset = "0xD0E820", VA = "0x180D0F620")]
	private static extern int DLL_CardIsThisSameCard(int cardA, int cardB);

	[PreserveSig]
	[Token(Token = "0x60088A6")]
	[Address(RVA = "0xD0F210", Offset = "0xD0E410", VA = "0x180D0F210")]
	private static extern int DLL_CardGetOriginalID(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A7")]
	[Address(RVA = "0xD0F190", Offset = "0xD0E390", VA = "0x180D0F190")]
	private static extern int DLL_CardGetOriginalID2(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A8")]
	[Address(RVA = "0xD0E970", Offset = "0xD0DB70", VA = "0x180D0E970")]
	private static extern int DLL_CardGetAlterID(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088A9")]
	[Address(RVA = "0xD0E8E0", Offset = "0xD0DAE0", VA = "0x180D0E8E0")]
	private static extern int DLL_CardGetAltCardID(int cardId, int alterID);

	[PreserveSig]
	[Token(Token = "0x60088AA")]
	[Address(RVA = "0xD0E850", Offset = "0xD0DA50", VA = "0x180D0E850")]
	private static extern int DLL_CardCheckName(int cardId, int nameType);

	[PreserveSig]
	[Token(Token = "0x60088AB")]
	[Address(RVA = "0xD0F000", Offset = "0xD0E200", VA = "0x180D0F000")]
	private static extern int DLL_CardGetLinkCards(int cardId, IntPtr pLinkID);

	[PreserveSig]
	[Token(Token = "0x60088AC")]
	[Address(RVA = "0xD0EB70", Offset = "0xD0DD70", VA = "0x180D0EB70")]
	private static extern int DLL_CardGetBasicVal(int cardId, ref Engine.BasicVal pVal);

	[PreserveSig]
	[Token(Token = "0x60088AD")]
	[Address(RVA = "0xD0F6B0", Offset = "0xD0E8B0", VA = "0x180D0F6B0")]
	private static extern int DLL_CardIsThisTunerMonster(int cardId);

	[PreserveSig]
	[Token(Token = "0x60088AE")]
	[Address(RVA = "0xD0F5A0", Offset = "0xD0E7A0", VA = "0x180D0F5A0")]
	private static extern int DLL_CardIsThisMaxMonster(int cardId);

	[Token(Token = "0x60088AF")]
	[Address(RVA = "0xD17500", Offset = "0xD16700", VA = "0x180D17500")]
	private int setCardProperty(byte[] data)
	{
		return default(int);
	}

	[Token(Token = "0x60088B0")]
	[Address(RVA = "0xD176A0", Offset = "0xD168A0", VA = "0x180D176A0")]
	private void setInternalID(byte[] data)
	{
	}

	[Token(Token = "0x60088B1")]
	[Address(RVA = "0xD16970", Offset = "0xD15B70", VA = "0x180D16970")]
	private int getInternalID(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088B2")]
	[Address(RVA = "0xD175D0", Offset = "0xD167D0", VA = "0x180D175D0")]
	private void setCardSame(byte[] data)
	{
	}

	[Token(Token = "0x60088B3")]
	[Address(RVA = "0xD17440", Offset = "0xD16640", VA = "0x180D17440")]
	private void setCardNamed(byte[] data)
	{
	}

	[Token(Token = "0x60088B4")]
	[Address(RVA = "0xD17370", Offset = "0xD16570", VA = "0x180D17370")]
	private void setCardLink(byte[] data)
	{
	}

	[Token(Token = "0x60088B5")]
	[Address(RVA = "0xD172B0", Offset = "0xD164B0", VA = "0x180D172B0")]
	private void setCardGenre(byte[] data)
	{
	}

	[Token(Token = "0x60088B6")]
	[Address(RVA = "0xD13D30", Offset = "0xD12F30", VA = "0x180D13D30")]
	public Type GetType(int cardId)
	{
		return default(Type);
	}

	[Token(Token = "0x60088B7")]
	[Address(RVA = "0xD10840", Offset = "0xD0FA40", VA = "0x180D10840")]
	public Attribute GetAttr(int cardId)
	{
		return default(Attribute);
	}

	[Token(Token = "0x60088B8")]
	[Address(RVA = "0xD13BA0", Offset = "0xD12DA0", VA = "0x180D13BA0")]
	public int GetStar(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088B9")]
	[Address(RVA = "0xD10E10", Offset = "0xD10010", VA = "0x180D10E10")]
	public int GetCardStar(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088BA")]
	[Address(RVA = "0xD14AA0", Offset = "0xD13CA0", VA = "0x180D14AA0")]
	public bool IsNoStarCard(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x60088BB")]
	[Address(RVA = "0xD121B0", Offset = "0xD113B0", VA = "0x180D121B0")]
	public int GetLevel(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088BC")]
	[Address(RVA = "0xD12FD0", Offset = "0xD121D0", VA = "0x180D12FD0")]
	public int GetRank(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088BD")]
	[Address(RVA = "0xD13920", Offset = "0xD12B20", VA = "0x180D13920")]
	public int GetScaleL(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088BE")]
	[Address(RVA = "0xD139D0", Offset = "0xD12BD0", VA = "0x180D139D0")]
	public int GetScaleR(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088BF")]
	[Address(RVA = "0xD128F0", Offset = "0xD11AF0", VA = "0x180D128F0")]
	public int GetLinkNum(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088C0")]
	[Address(RVA = "0xD12840", Offset = "0xD11A40", VA = "0x180D12840")]
	public int GetLinkMask(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088C1")]
	[Address(RVA = "0xD11FB0", Offset = "0xD111B0", VA = "0x180D11FB0")]
	public Icon GetIcon(int cardId)
	{
		return default(Icon);
	}

	[Token(Token = "0x60088C2")]
	[Address(RVA = "0xD11C40", Offset = "0xD10E40", VA = "0x180D11C40")]
	public Frame GetFrame(int cardId)
	{
		return default(Frame);
	}

	[Token(Token = "0x60088C3")]
	[Address(RVA = "0xD12100", Offset = "0xD11300", VA = "0x180D12100")]
	public Kind GetKind(int cardId)
	{
		return default(Kind);
	}

	[Token(Token = "0x60088C4")]
	[Address(RVA = "0xD10790", Offset = "0xD0F990", VA = "0x180D10790")]
	public int GetAtk(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088C5")]
	[Address(RVA = "0xD110C0", Offset = "0xD102C0", VA = "0x180D110C0")]
	public int GetDef(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088C6")]
	[Address(RVA = "0xD106E0", Offset = "0xD0F8E0", VA = "0x180D106E0")]
	public int GetAtk2(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088C7")]
	[Address(RVA = "0xD11010", Offset = "0xD10210", VA = "0x180D11010")]
	public int GetDef2(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088C8")]
	[Address(RVA = "0xD14BC0", Offset = "0xD13DC0", VA = "0x180D14BC0")]
	public bool IsThisCardGenre(int cardId, Genre genre)
	{
		return default(bool);
	}

	[Token(Token = "0x60088C9")]
	[Address(RVA = "0xD14D30", Offset = "0xD13F30", VA = "0x180D14D30")]
	public bool IsThisSameCard(int cardA, int cardB)
	{
		return default(bool);
	}

	[Token(Token = "0x60088CA")]
	[Address(RVA = "0xD14DF0", Offset = "0xD13FF0", VA = "0x180D14DF0")]
	public bool IsThisTunerMonster(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x60088CB")]
	[Address(RVA = "0xD14C80", Offset = "0xD13E80", VA = "0x180D14C80")]
	public bool IsThisMaxMonster(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x60088CC")]
	[Address(RVA = "0xD12F10", Offset = "0xD12110", VA = "0x180D12F10")]
	public int GetOriginalID(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088CD")]
	[Address(RVA = "0xD12E60", Offset = "0xD12060", VA = "0x180D12E60")]
	public int GetOriginalID2(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088CE")]
	[Address(RVA = "0xD10630", Offset = "0xD0F830", VA = "0x180D10630")]
	public int GetAlterID(int cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60088CF")]
	[Address(RVA = "0xD10570", Offset = "0xD0F770", VA = "0x180D10570")]
	public int GetAltCardID(int cardId, int altId)
	{
		return default(int);
	}

	[Token(Token = "0x60088D0")]
	[Address(RVA = "0xD0E640", Offset = "0xD0D840", VA = "0x180D0E640")]
	public bool CheckCardName(int cardId, NameType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60088D1")]
	[Address(RVA = "0xD12520", Offset = "0xD11720", VA = "0x180D12520")]
	public List<int> GetLinkCards(int cardId)
	{
		return null;
	}

	[Token(Token = "0x60088D2")]
	[Address(RVA = "0xD12260", Offset = "0xD11460", VA = "0x180D12260")]
	public List<int> GetLinkCardsOfAvailable(int cardId)
	{
		return null;
	}

	[Token(Token = "0x60088D3")]
	[Address(RVA = "0xD109B0", Offset = "0xD0FBB0", VA = "0x180D109B0")]
	public static void GetBasicVal(int cardId, ref Engine.BasicVal val)
	{
	}

	[Token(Token = "0x60088D4")]
	[Address(RVA = "0xD15F50", Offset = "0xD15150", VA = "0x180D15F50")]
	public Content()
	{
	}
}
