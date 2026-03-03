using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.Deck;

[Token(Token = "0x2001105")]
public static class SearchFilter
{
	[Token(Token = "0x2001106")]
	public class Setting
	{
		[Token(Token = "0x2001107")]
		public enum OPTIONS
		{
			[Token(Token = "0x400B410")]
			NotOwned,
			[Token(Token = "0x400B411")]
			SIZE
		}

		[Token(Token = "0x2001108")]
		public enum FRAME
		{
			[Token(Token = "0x400B413")]
			Normal,
			[Token(Token = "0x400B414")]
			Effect,
			[Token(Token = "0x400B415")]
			Fusion,
			[Token(Token = "0x400B416")]
			Ritual,
			[Token(Token = "0x400B417")]
			Synchro,
			[Token(Token = "0x400B418")]
			Xyz,
			[Token(Token = "0x400B419")]
			Pendulum,
			[Token(Token = "0x400B41A")]
			Link,
			[Token(Token = "0x400B41B")]
			Magic,
			[Token(Token = "0x400B41C")]
			Trap,
			[Token(Token = "0x400B41D")]
			SIZE
		}

		[Token(Token = "0x2001109")]
		public enum ATTR
		{
			[Token(Token = "0x400B41F")]
			Light,
			[Token(Token = "0x400B420")]
			Dark,
			[Token(Token = "0x400B421")]
			Water,
			[Token(Token = "0x400B422")]
			Fire,
			[Token(Token = "0x400B423")]
			Earth,
			[Token(Token = "0x400B424")]
			Wind,
			[Token(Token = "0x400B425")]
			Divine,
			[Token(Token = "0x400B426")]
			SIZE
		}

		[Token(Token = "0x200110A")]
		public enum TRIBE
		{
			[Token(Token = "0x400B428")]
			SpellCaster,
			[Token(Token = "0x400B429")]
			Dragon,
			[Token(Token = "0x400B42A")]
			Zombie,
			[Token(Token = "0x400B42B")]
			Warrior,
			[Token(Token = "0x400B42C")]
			BeastWarrior,
			[Token(Token = "0x400B42D")]
			Beast,
			[Token(Token = "0x400B42E")]
			WingedBeast,
			[Token(Token = "0x400B42F")]
			Machine,
			[Token(Token = "0x400B430")]
			Fiend,
			[Token(Token = "0x400B431")]
			Fairy,
			[Token(Token = "0x400B432")]
			Insect,
			[Token(Token = "0x400B433")]
			Dinosaur,
			[Token(Token = "0x400B434")]
			Reptile,
			[Token(Token = "0x400B435")]
			Fish,
			[Token(Token = "0x400B436")]
			SeaSerpent,
			[Token(Token = "0x400B437")]
			Aqua,
			[Token(Token = "0x400B438")]
			Pyro,
			[Token(Token = "0x400B439")]
			Thunder,
			[Token(Token = "0x400B43A")]
			Rock,
			[Token(Token = "0x400B43B")]
			Plant,
			[Token(Token = "0x400B43C")]
			Psychic,
			[Token(Token = "0x400B43D")]
			Wyrm,
			[Token(Token = "0x400B43E")]
			Cyberse,
			[Token(Token = "0x400B43F")]
			Illusioner,
			[Token(Token = "0x400B440")]
			DivineBeast,
			[Token(Token = "0x400B441")]
			SIZE
		}

		[Token(Token = "0x200110B")]
		public enum LEVEL
		{
			[Token(Token = "0x400B443")]
			Lvl0,
			[Token(Token = "0x400B444")]
			Lvl1,
			[Token(Token = "0x400B445")]
			Lvl2,
			[Token(Token = "0x400B446")]
			Lvl3,
			[Token(Token = "0x400B447")]
			Lvl4,
			[Token(Token = "0x400B448")]
			Lvl5,
			[Token(Token = "0x400B449")]
			Lvl6,
			[Token(Token = "0x400B44A")]
			Lvl7,
			[Token(Token = "0x400B44B")]
			Lvl8,
			[Token(Token = "0x400B44C")]
			Lvl9,
			[Token(Token = "0x400B44D")]
			Lvl10,
			[Token(Token = "0x400B44E")]
			Lvl11,
			[Token(Token = "0x400B44F")]
			Lvl12,
			[Token(Token = "0x400B450")]
			Lvl13,
			[Token(Token = "0x400B451")]
			SIZE
		}

		[Token(Token = "0x200110C")]
		public enum LINK
		{
			[Token(Token = "0x400B453")]
			Link1,
			[Token(Token = "0x400B454")]
			Link2,
			[Token(Token = "0x400B455")]
			Link3,
			[Token(Token = "0x400B456")]
			Link4,
			[Token(Token = "0x400B457")]
			Link5,
			[Token(Token = "0x400B458")]
			Link6,
			[Token(Token = "0x400B459")]
			SIZE
		}

		[Token(Token = "0x200110D")]
		public enum NOTMONSTER
		{
			[Token(Token = "0x400B45B")]
			NormalSpell,
			[Token(Token = "0x400B45C")]
			FieldSpell,
			[Token(Token = "0x400B45D")]
			EquipSpell,
			[Token(Token = "0x400B45E")]
			ContinuousSpell,
			[Token(Token = "0x400B45F")]
			QuickPlaySpell,
			[Token(Token = "0x400B460")]
			RitualSpell,
			[Token(Token = "0x400B461")]
			NormalTrap,
			[Token(Token = "0x400B462")]
			ContinuousTrap,
			[Token(Token = "0x400B463")]
			CounterTrap,
			[Token(Token = "0x400B464")]
			SIZE
		}

		[Token(Token = "0x200110E")]
		public enum RARITY
		{
			[Token(Token = "0x400B466")]
			Normal,
			[Token(Token = "0x400B467")]
			Rare,
			[Token(Token = "0x400B468")]
			SuperRare,
			[Token(Token = "0x400B469")]
			UltraRare,
			[Token(Token = "0x400B46A")]
			SIZE
		}

		[Token(Token = "0x200110F")]
		public enum STYLE
		{
			[Token(Token = "0x400B46C")]
			Normal,
			[Token(Token = "0x400B46D")]
			Shine,
			[Token(Token = "0x400B46E")]
			Royal,
			[Token(Token = "0x400B46F")]
			SIZE
		}

		[Token(Token = "0x2001110")]
		public enum LIMIT
		{
			[Token(Token = "0x400B471")]
			Limit0,
			[Token(Token = "0x400B472")]
			Limit1,
			[Token(Token = "0x400B473")]
			Limit2,
			[Token(Token = "0x400B474")]
			Limit3,
			[Token(Token = "0x400B475")]
			SIZE
		}

		[Token(Token = "0x2001111")]
		public enum CUTIN
		{
			[Token(Token = "0x400B477")]
			Exist,
			[Token(Token = "0x400B478")]
			NotExist,
			[Token(Token = "0x400B479")]
			SIZE
		}

		[Token(Token = "0x2001112")]
		public enum LINKMARKER
		{
			[Token(Token = "0x400B47B")]
			UpLeft,
			[Token(Token = "0x400B47C")]
			Up,
			[Token(Token = "0x400B47D")]
			UpRight,
			[Token(Token = "0x400B47E")]
			Left,
			[Token(Token = "0x400B47F")]
			Right,
			[Token(Token = "0x400B480")]
			DownLeft,
			[Token(Token = "0x400B481")]
			Down,
			[Token(Token = "0x400B482")]
			DownRight,
			[Token(Token = "0x400B483")]
			SIZE
		}

		[Token(Token = "0x2001113")]
		public enum ATTACK
		{
			[Token(Token = "0x400B485")]
			Min,
			[Token(Token = "0x400B486")]
			Max,
			[Token(Token = "0x400B487")]
			SIZE
		}

		[Token(Token = "0x2001114")]
		public enum DEFENSE
		{
			[Token(Token = "0x400B489")]
			Min,
			[Token(Token = "0x400B48A")]
			Max,
			[Token(Token = "0x400B48B")]
			SIZE
		}

		[Token(Token = "0x2001115")]
		public enum ABILITY
		{
			[Token(Token = "0x400B48D")]
			Toon,
			[Token(Token = "0x400B48E")]
			Dual,
			[Token(Token = "0x400B48F")]
			Union,
			[Token(Token = "0x400B490")]
			Spirit,
			[Token(Token = "0x400B491")]
			Tuner,
			[Token(Token = "0x400B492")]
			Reverse,
			[Token(Token = "0x400B493")]
			SpSummon,
			[Token(Token = "0x400B494")]
			SIZE
		}

		[Token(Token = "0x2001116")]
		public enum REGULATION
		{
			[Token(Token = "0x400B496")]
			Forbidden,
			[Token(Token = "0x400B497")]
			Limited,
			[Token(Token = "0x400B498")]
			SemiLimited,
			[Token(Token = "0x400B499")]
			None,
			[Token(Token = "0x400B49A")]
			SIZE
		}

		[Token(Token = "0x400B3F6")]
		[FieldOffset(Offset = "0x10")]
		public BitArray Options;

		[Token(Token = "0x400B3F7")]
		[FieldOffset(Offset = "0x18")]
		public BitArray Frame;

		[Token(Token = "0x400B3F8")]
		[FieldOffset(Offset = "0x20")]
		public bool isAndFrame;

		[Token(Token = "0x400B3F9")]
		[FieldOffset(Offset = "0x28")]
		public BitArray Attr;

		[Token(Token = "0x400B3FA")]
		[FieldOffset(Offset = "0x30")]
		public BitArray Tribe;

		[Token(Token = "0x400B3FB")]
		[FieldOffset(Offset = "0x38")]
		public BitArray Level;

		[Token(Token = "0x400B3FC")]
		[FieldOffset(Offset = "0x40")]
		public BitArray Link;

		[Token(Token = "0x400B3FD")]
		[FieldOffset(Offset = "0x48")]
		public BitArray PendulumScale;

		[Token(Token = "0x400B3FE")]
		[FieldOffset(Offset = "0x50")]
		public BitArray NotMonster;

		[Token(Token = "0x400B3FF")]
		[FieldOffset(Offset = "0x58")]
		public BitArray Rarity;

		[Token(Token = "0x400B400")]
		[FieldOffset(Offset = "0x60")]
		public BitArray Style;

		[Token(Token = "0x400B401")]
		[FieldOffset(Offset = "0x68")]
		public BitArray Limit;

		[Token(Token = "0x400B402")]
		[FieldOffset(Offset = "0x70")]
		public BitArray Cutin;

		[Token(Token = "0x400B403")]
		[FieldOffset(Offset = "0x78")]
		public BitArray LinkMarker;

		[Token(Token = "0x400B404")]
		[FieldOffset(Offset = "0x80")]
		public bool isAndLinkMarker;

		[Token(Token = "0x400B405")]
		[FieldOffset(Offset = "0x88")]
		public BitArray Attack;

		[Token(Token = "0x400B406")]
		[FieldOffset(Offset = "0x90")]
		private int[] attackVal;

		[Token(Token = "0x400B407")]
		[FieldOffset(Offset = "0x98")]
		public BitArray Defense;

		[Token(Token = "0x400B408")]
		[FieldOffset(Offset = "0xA0")]
		private int[] defenseVal;

		[Token(Token = "0x400B409")]
		private const int sliderMin = -200;

		[Token(Token = "0x400B40A")]
		private const int sliderQ = -100;

		[Token(Token = "0x400B40B")]
		private const int monsterValMax = 5000;

		[Token(Token = "0x400B40C")]
		private const int sliderMax = 5100;

		[Token(Token = "0x400B40D")]
		[FieldOffset(Offset = "0xA8")]
		public BitArray Ability;

		[Token(Token = "0x400B40E")]
		[FieldOffset(Offset = "0xB0")]
		public BitArray Regulation;

		[Token(Token = "0x6006B1C")]
		[Address(RVA = "0xB376C0", Offset = "0xB368C0", VA = "0x180B376C0")]
		public Setting()
		{
		}

		[Token(Token = "0x6006B1D")]
		[Address(RVA = "0xB37230", Offset = "0xB36430", VA = "0x180B37230")]
		public bool IsFiltered()
		{
			return default(bool);
		}

		[Token(Token = "0x6006B1E")]
		[Address(RVA = "0xB37B30", Offset = "0xB36D30", VA = "0x180B37B30")]
		private static bool checkAny(BitArray ba)
		{
			return default(bool);
		}

		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0xB36180", Offset = "0xB35380", VA = "0x180B36180")]
		public bool CheckAnyBit(BitArray ba)
		{
			return default(bool);
		}

		[Token(Token = "0x6006B20")]
		[Address(RVA = "0x7BC420", Offset = "0x7BB620", VA = "0x1807BC420")]
		private static bool checkValue(int[] valueArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6006B21")]
		[Address(RVA = "0xB36190", Offset = "0xB35390", VA = "0x180B36190")]
		public bool CheckAttackVal()
		{
			return default(bool);
		}

		[Token(Token = "0x6006B22")]
		[Address(RVA = "0xB361E0", Offset = "0xB353E0", VA = "0x180B361E0")]
		public bool CheckDefenseVal()
		{
			return default(bool);
		}

		[Token(Token = "0x6006B23")]
		[Address(RVA = "0xB36D60", Offset = "0xB35F60", VA = "0x180B36D60")]
		public BitArray GetFrameSetting()
		{
			return null;
		}

		[Token(Token = "0x6006B24")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		public bool GetIsAndFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6006B25")]
		[Address(RVA = "0xB36BE0", Offset = "0xB35DE0", VA = "0x180B36BE0")]
		public BitArray GetAttrSetting()
		{
			return null;
		}

		[Token(Token = "0x6006B26")]
		[Address(RVA = "0xB371C0", Offset = "0xB363C0", VA = "0x180B371C0")]
		public BitArray GetTribeSetting()
		{
			return null;
		}

		[Token(Token = "0x6006B27")]
		[Address(RVA = "0xB36DD0", Offset = "0xB35FD0", VA = "0x180B36DD0")]
		public BitArray GetLevel()
		{
			return null;
		}

		[Token(Token = "0x6006B28")]
		[Address(RVA = "0xB36F20", Offset = "0xB36120", VA = "0x180B36F20")]
		public BitArray GetLink()
		{
			return null;
		}

		[Token(Token = "0x6006B29")]
		[Address(RVA = "0xB37000", Offset = "0xB36200", VA = "0x180B37000")]
		public BitArray GetPendulumScale()
		{
			return null;
		}

		[Token(Token = "0x6006B2A")]
		[Address(RVA = "0xB36F90", Offset = "0xB36190", VA = "0x180B36F90")]
		public BitArray GetNotMonster()
		{
			return null;
		}

		[Token(Token = "0x6006B2B")]
		[Address(RVA = "0xB37070", Offset = "0xB36270", VA = "0x180B37070")]
		public BitArray GetRarity()
		{
			return null;
		}

		[Token(Token = "0x6006B2C")]
		[Address(RVA = "0xB37150", Offset = "0xB36350", VA = "0x180B37150")]
		public BitArray GetStyle()
		{
			return null;
		}

		[Token(Token = "0x6006B2D")]
		[Address(RVA = "0xB36E40", Offset = "0xB36040", VA = "0x180B36E40")]
		public BitArray GetLimit()
		{
			return null;
		}

		[Token(Token = "0x6006B2E")]
		[Address(RVA = "0xB36C50", Offset = "0xB35E50", VA = "0x180B36C50")]
		public BitArray GetCutin()
		{
			return null;
		}

		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0xB36EB0", Offset = "0xB360B0", VA = "0x180B36EB0")]
		public BitArray GetLinkMark()
		{
			return null;
		}

		[Token(Token = "0x6006B30")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800")]
		public bool GetIsAndLinkMark()
		{
			return default(bool);
		}

		[Token(Token = "0x6006B31")]
		[Address(RVA = "0xB36B40", Offset = "0xB35D40", VA = "0x180B36B40")]
		public int[] GetAttackVal()
		{
			return null;
		}

		[Token(Token = "0x6006B32")]
		[Address(RVA = "0xB36CC0", Offset = "0xB35EC0", VA = "0x180B36CC0")]
		public int[] GetDefenseVal()
		{
			return null;
		}

		[Token(Token = "0x6006B33")]
		[Address(RVA = "0xB36AD0", Offset = "0xB35CD0", VA = "0x180B36AD0")]
		public BitArray GetAbility()
		{
			return null;
		}

		[Token(Token = "0x6006B34")]
		[Address(RVA = "0xB370E0", Offset = "0xB362E0", VA = "0x180B370E0")]
		public BitArray GetRegulation()
		{
			return null;
		}

		[Token(Token = "0x6006B35")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		public BitArray GetOption()
		{
			return null;
		}

		[Token(Token = "0x6006B36")]
		[Address(RVA = "0xB37660", Offset = "0xB36860", VA = "0x180B37660")]
		public void SetRarityFilter(RARITY val, bool b)
		{
		}

		[Token(Token = "0x6006B37")]
		[Address(RVA = "0xB37680", Offset = "0xB36880", VA = "0x180B37680")]
		public void SetStyleFilter(STYLE val, bool b)
		{
		}

		[Token(Token = "0x6006B38")]
		[Address(RVA = "0xB375A0", Offset = "0xB367A0", VA = "0x180B375A0")]
		public void SetLimitFilter(LIMIT val, bool b)
		{
		}

		[Token(Token = "0x6006B39")]
		[Address(RVA = "0xB374E0", Offset = "0xB366E0", VA = "0x180B374E0")]
		public void SetCutinFilter(CUTIN val, bool b)
		{
		}

		[Token(Token = "0x6006B3A")]
		[Address(RVA = "0xB375E0", Offset = "0xB367E0", VA = "0x180B375E0")]
		public void SetLinkMarkerFilter(LINKMARKER val, bool b)
		{
		}

		[Token(Token = "0x6006B3B")]
		[Address(RVA = "0xB37430", Offset = "0xB36630", VA = "0x180B37430")]
		public void SetAbilityFilter(ABILITY val, bool b)
		{
		}

		[Token(Token = "0x6006B3C")]
		[Address(RVA = "0xB37560", Offset = "0xB36760", VA = "0x180B37560")]
		public void SetFrameFilter(FRAME val, bool b)
		{
		}

		[Token(Token = "0x6006B3D")]
		[Address(RVA = "0xB37600", Offset = "0xB36800", VA = "0x180B37600")]
		public void SetNotMonsterFilter(NOTMONSTER val, bool b)
		{
		}

		[Token(Token = "0x6006B3E")]
		[Address(RVA = "0xB374C0", Offset = "0xB366C0", VA = "0x180B374C0")]
		public void SetAttrFilter(ATTR val, bool b)
		{
		}

		[Token(Token = "0x6006B3F")]
		[Address(RVA = "0xB376A0", Offset = "0xB368A0", VA = "0x180B376A0")]
		public void SetTribeFilter(TRIBE val, bool b)
		{
		}

		[Token(Token = "0x6006B40")]
		[Address(RVA = "0xB37580", Offset = "0xB36780", VA = "0x180B37580")]
		public void SetLevelFilter(LEVEL val, bool b)
		{
		}

		[Token(Token = "0x6006B41")]
		[Address(RVA = "0xB375C0", Offset = "0xB367C0", VA = "0x180B375C0")]
		public void SetLinkFilter(LINK val, bool b)
		{
		}

		[Token(Token = "0x6006B42")]
		[Address(RVA = "0xB37640", Offset = "0xB36840", VA = "0x180B37640")]
		public void SetPendulumScaleFilter(LEVEL val, bool b)
		{
		}

		[Token(Token = "0x6006B43")]
		[Address(RVA = "0xB37620", Offset = "0xB36820", VA = "0x180B37620")]
		public void SetOptionSetting(OPTIONS val, bool b)
		{
		}

		[Token(Token = "0x6006B44")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		public void SetIsAndFrame(bool b)
		{
		}

		[Token(Token = "0x6006B45")]
		[Address(RVA = "0x449850", Offset = "0x448A50", VA = "0x180449850")]
		public void SetIsAndLinkMarker(bool b)
		{
		}

		[Token(Token = "0x6006B46")]
		[Address(RVA = "0xB37490", Offset = "0xB36690", VA = "0x180B37490")]
		public void SetAttackFilterMin(int val)
		{
		}

		[Token(Token = "0x6006B47")]
		[Address(RVA = "0xB37460", Offset = "0xB36660", VA = "0x180B37460")]
		public void SetAttackFilterMax(int val)
		{
		}

		[Token(Token = "0x6006B48")]
		[Address(RVA = "0xB37530", Offset = "0xB36730", VA = "0x180B37530")]
		public void SetDefenseFilterMin(int val)
		{
		}

		[Token(Token = "0x6006B49")]
		[Address(RVA = "0xB37500", Offset = "0xB36700", VA = "0x180B37500")]
		public void SetDefenseFilterMax(int val)
		{
		}

		[Token(Token = "0x6006B4A")]
		[Address(RVA = "0xB36230", Offset = "0xB35430", VA = "0x180B36230")]
		public Setting Clone()
		{
			return null;
		}
	}

	[Token(Token = "0x2001117")]
	private enum FrameMask
	{
		[Token(Token = "0x400B49C")]
		Normal = 1,
		[Token(Token = "0x400B49D")]
		Effect = 2,
		[Token(Token = "0x400B49E")]
		Fusion = 4,
		[Token(Token = "0x400B49F")]
		Ritual = 8,
		[Token(Token = "0x400B4A0")]
		Synchro = 0x10,
		[Token(Token = "0x400B4A1")]
		Xyz = 0x20,
		[Token(Token = "0x400B4A2")]
		Pendulum = 0x40,
		[Token(Token = "0x400B4A3")]
		Link = 0x80,
		[Token(Token = "0x400B4A4")]
		Magic = 0x100,
		[Token(Token = "0x400B4A5")]
		Trap = 0x200
	}

	[Token(Token = "0x2001118")]
	private enum LinkMask
	{
		[Token(Token = "0x400B4A7")]
		UpLeft = 1,
		[Token(Token = "0x400B4A8")]
		Up = 2,
		[Token(Token = "0x400B4A9")]
		UpRight = 4,
		[Token(Token = "0x400B4AA")]
		Left = 8,
		[Token(Token = "0x400B4AB")]
		Right = 0x10,
		[Token(Token = "0x400B4AC")]
		DownLeft = 0x20,
		[Token(Token = "0x400B4AD")]
		Down = 0x40,
		[Token(Token = "0x400B4AE")]
		DownRight = 0x80
	}

	[Token(Token = "0x2001119")]
	private enum AbilityMask
	{
		[Token(Token = "0x400B4B0")]
		Toon = 1,
		[Token(Token = "0x400B4B1")]
		Dual = 2,
		[Token(Token = "0x400B4B2")]
		Union = 4,
		[Token(Token = "0x400B4B3")]
		Spirit = 8,
		[Token(Token = "0x400B4B4")]
		Tuner = 0x10,
		[Token(Token = "0x400B4B5")]
		Reverse = 0x20,
		[Token(Token = "0x400B4B6")]
		SpSummon = 0x40
	}

	[Token(Token = "0x400B3D4")]
	[FieldOffset(Offset = "0x0")]
	public static int nowRegulationID;

	[Token(Token = "0x400B3D5")]
	[FieldOffset(Offset = "0x8")]
	private static string[] searchKeywords;

	[Token(Token = "0x400B3D6")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<Content.Frame, int> frameMaskTbl;

	[Token(Token = "0x400B3D7")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<Content.Attribute, Setting.ATTR> attrTbl;

	[Token(Token = "0x400B3D8")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<Content.Type, Setting.TRIBE> tribeTbl;

	[Token(Token = "0x400B3D9")]
	[FieldOffset(Offset = "0x28")]
	private static Dictionary<int, Setting.LEVEL> levelTbl;

	[Token(Token = "0x400B3DA")]
	[FieldOffset(Offset = "0x30")]
	private static Dictionary<int, Setting.LINK> linkTbl;

	[Token(Token = "0x400B3DB")]
	[FieldOffset(Offset = "0x38")]
	private static Dictionary<Content.Icon, Setting.NOTMONSTER> spellTbl;

	[Token(Token = "0x400B3DC")]
	[FieldOffset(Offset = "0x40")]
	private static Dictionary<Content.Icon, Setting.NOTMONSTER> trapTbl;

	[Token(Token = "0x400B3DD")]
	[FieldOffset(Offset = "0x48")]
	private static Dictionary<CardCollectionInfo.Rarity, Setting.RARITY> rarityTbl;

	[Token(Token = "0x400B3DE")]
	[FieldOffset(Offset = "0x50")]
	private static Dictionary<CardCollectionInfo.Premium, Setting.STYLE> styleTbl;

	[Token(Token = "0x400B3DF")]
	[FieldOffset(Offset = "0x58")]
	private static Dictionary<int, Setting.LIMIT> limitTbl;

	[Token(Token = "0x400B3E0")]
	[FieldOffset(Offset = "0x60")]
	private static Dictionary<bool, Setting.CUTIN> cutinTbl;

	[Token(Token = "0x400B3E1")]
	[FieldOffset(Offset = "0x68")]
	private static Dictionary<LinkMask, Setting.LINKMARKER> linkMarkTbl;

	[Token(Token = "0x400B3E2")]
	[FieldOffset(Offset = "0x70")]
	private static Dictionary<AbilityMask, Setting.ABILITY> abilityTbl;

	[Token(Token = "0x400B3E3")]
	[FieldOffset(Offset = "0x78")]
	private static Dictionary<CardCollectionInfo.Regulation, Setting.REGULATION> regulationTbl;

	[Token(Token = "0x400B3E4")]
	private const int sliderQ = -100;

	[Token(Token = "0x400B3E5")]
	private const int monsterValMax = 5000;

	[Token(Token = "0x400B3E6")]
	private const int HAN_SPACE = 32;

	[Token(Token = "0x400B3E7")]
	private const int HAN_YEN = 92;

	[Token(Token = "0x400B3E8")]
	private const int HAN_ALPHA_START = 33;

	[Token(Token = "0x400B3E9")]
	private const int HAN_ALPHA_END = 126;

	[Token(Token = "0x400B3EA")]
	private const int ZEN_SPACE = 12288;

	[Token(Token = "0x400B3EB")]
	private const int ZEN_YEN = 65509;

	[Token(Token = "0x400B3EC")]
	private const int ZEN_ALPHA_START = 65281;

	[Token(Token = "0x400B3ED")]
	private const int ZEN_ALPHA_OFFSET = 65248;

	[Token(Token = "0x400B3EE")]
	private const int HIRA_START = 12352;

	[Token(Token = "0x400B3EF")]
	private const int HIRA_END = 12442;

	[Token(Token = "0x400B3F0")]
	private const int KATA_START = 12448;

	[Token(Token = "0x400B3F1")]
	private const int KATA_OFFSET = 96;

	[Token(Token = "0x400B3F2")]
	private const int ZAL_START = 65313;

	[Token(Token = "0x400B3F3")]
	private const int ZAL_END = 65338;

	[Token(Token = "0x400B3F4")]
	private const int ZAS_START = 65345;

	[Token(Token = "0x400B3F5")]
	private const int ZAS_OFFSET = 32;

	[Token(Token = "0x6006AFC")]
	[Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
	private static void getSetting(Setting setting, out BitArray frame, out bool isandframe, out BitArray attr, out BitArray tribe, out BitArray level, out BitArray link, out BitArray pendulumScale, out BitArray notmonster, out BitArray rarity, out BitArray style, out BitArray limit, out BitArray cutin, out BitArray linkmark, out bool isandlinkmark, out int[] attackVal, out int[] defenseVal, out BitArray ability, out BitArray regulation, out BitArray option)
	{
	}

	[Token(Token = "0x6006AFD")]
	[Address(RVA = "0xB32410", Offset = "0xB31610", VA = "0x180B32410")]
	private static void getRawSetting(Setting setting, out BitArray frame, out bool isandframe, out BitArray attr, out BitArray tribe, out BitArray level, out BitArray link, out BitArray pendulumScale, out BitArray notmonster, out BitArray rarity, out BitArray style, out BitArray limit, out BitArray cutin, out BitArray linkmarker, out bool isandlinkmarker, out int[] attackval, out int[] defenseval, out BitArray ability, out BitArray regulation, out BitArray option)
	{
	}

	[Token(Token = "0x6006AFE")]
	[Address(RVA = "0xB2F3C0", Offset = "0xB2E5C0", VA = "0x180B2F3C0")]
	public static List<CardBaseData> Filter(List<CardBaseData> list, Setting setting, string keyword, bool includeDesc = true)
	{
		return null;
	}

	[Token(Token = "0x6006AFF")]
	[Address(RVA = "0xB32BF0", Offset = "0xB31DF0", VA = "0x180B32BF0")]
	private static bool predicate(int cardID, BitArray frame, bool isAndFrame, BitArray attr, BitArray tribe, BitArray level, BitArray link, BitArray pendulumScale, BitArray notmonster, BitArray rarity, BitArray style, BitArray limit, BitArray cutin, BitArray linkmarker, bool isAndLinkMarker, int[] attackVal, int[] defenseVal, BitArray ability, BitArray regulation, BitArray option, int rareID = -1, int styleID = -1, bool includeDesc = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B00")]
	[Address(RVA = "0xB31260", Offset = "0xB30460", VA = "0x180B31260")]
	private static bool checkEmpty(BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B01")]
	[Address(RVA = "0xB31200", Offset = "0xB30400", VA = "0x180B31200")]
	private static bool checkEmptyValue(int[] array)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B02")]
	[Address(RVA = "0xB313C0", Offset = "0xB305C0", VA = "0x180B313C0")]
	private static bool checkFrameMask(Content.Frame val, int mask)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B03")]
	[Address(RVA = "0xB30890", Offset = "0xB2FA90", VA = "0x180B30890")]
	private static bool checkAndOrFrame(Content.Frame val, BitArray ba, bool isAnd)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B04")]
	[Address(RVA = "0xB30A20", Offset = "0xB2FC20", VA = "0x180B30A20")]
	private static bool checkAttr(Content.Attribute val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B05")]
	[Address(RVA = "0xB31FF0", Offset = "0xB311F0", VA = "0x180B31FF0")]
	private static bool checkTribe(Content.Type val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B06")]
	[Address(RVA = "0xB314C0", Offset = "0xB306C0", VA = "0x180B314C0")]
	private static bool checkLevel(int val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B07")]
	[Address(RVA = "0xB31850", Offset = "0xB30A50", VA = "0x180B31850")]
	private static bool checkLink(int val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B08")]
	[Address(RVA = "0xB31940", Offset = "0xB30B40", VA = "0x180B31940")]
	private static bool checkPendulumScale(int val, BitArray ba, Content.Frame frame)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B09")]
	[Address(RVA = "0xB31D20", Offset = "0xB30F20", VA = "0x180B31D20")]
	private static bool checkSpellIcon(Content.Icon val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B0A")]
	[Address(RVA = "0xB31F00", Offset = "0xB31100", VA = "0x180B31F00")]
	private static bool checkTrapIcon(Content.Icon val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B0B")]
	[Address(RVA = "0xB31B40", Offset = "0xB30D40", VA = "0x180B31B40")]
	private static bool checkRarity(CardCollectionInfo.Rarity val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B0C")]
	[Address(RVA = "0xB31E10", Offset = "0xB31010", VA = "0x180B31E10")]
	private static bool checkStyle(CardCollectionInfo.Premium val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B0D")]
	[Address(RVA = "0xB2F310", Offset = "0xB2E510", VA = "0x180B2F310")]
	public static bool CheckStyle(CardCollectionInfo.Premium val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B0E")]
	[Address(RVA = "0xB315B0", Offset = "0xB307B0", VA = "0x180B315B0")]
	private static bool checkLimit(int val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B0F")]
	[Address(RVA = "0xB31110", Offset = "0xB30310", VA = "0x180B31110")]
	private static bool checkCutin(bool val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B10")]
	[Address(RVA = "0xB316A0", Offset = "0xB308A0", VA = "0x180B316A0")]
	private static bool checkLinkMarker(int val, BitArray ba, bool isAnd)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B11")]
	[Address(RVA = "0xB320E0", Offset = "0xB312E0", VA = "0x180B320E0")]
	private static bool checkValue(int value, int[] valueArray)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B12")]
	[Address(RVA = "0xB30780", Offset = "0xB2F980", VA = "0x180B30780")]
	private static bool checkAbility(AbilityMask val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B13")]
	[Address(RVA = "0xB31C30", Offset = "0xB30E30", VA = "0x180B31C30")]
	private static bool checkRegulation(CardCollectionInfo.Regulation val, BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B14")]
	[Address(RVA = "0xB30D20", Offset = "0xB2FF20", VA = "0x180B30D20")]
	private static void checkCollectionSetting(string keywordsString)
	{
	}

	[Token(Token = "0x6006B15")]
	[Address(RVA = "0xB30E10", Offset = "0xB30010", VA = "0x180B30E10")]
	private static bool checkCollection(int mrk, bool includeDesc = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B16")]
	[Address(RVA = "0xB30B10", Offset = "0xB2FD10", VA = "0x180B30B10")]
	public static bool checkCollectionIDList(List<int> mrkList, string keywordsString, List<int> hitList, bool includeDesc = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B17")]
	[Address(RVA = "0xB32180", Offset = "0xB31380", VA = "0x180B32180")]
	private static string convertSearchText(string src)
	{
		return null;
	}

	[Token(Token = "0x6006B18")]
	[Address(RVA = "0xB2F370", Offset = "0xB2E570", VA = "0x180B2F370")]
	public static string ConvertSearchText(string src)
	{
		return null;
	}

	[Token(Token = "0x6006B19")]
	[Address(RVA = "0x7C9980", Offset = "0x7C8B80", VA = "0x1807C9980")]
	private static string toZenkaku(string src)
	{
		return null;
	}

	[Token(Token = "0x6006B1A")]
	[Address(RVA = "0xB33F50", Offset = "0xB33150", VA = "0x180B33F50")]
	private static string toKatakana_Komoji(string src)
	{
		return null;
	}
}
