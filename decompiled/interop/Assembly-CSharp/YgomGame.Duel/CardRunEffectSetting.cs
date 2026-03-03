using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019D9")]
public class CardRunEffectSetting : ScriptableObject
{
	[Token(Token = "0x20019DA")]
	public enum PlayType
	{
		[Token(Token = "0x400EE7A")]
		Timeline3D,
		[Token(Token = "0x400EE7B")]
		TimelineHUD,
		[Token(Token = "0x400EE7C")]
		SimpleEffect
	}

	[Token(Token = "0x20019DB")]
	public enum RunTiming
	{
		[Token(Token = "0x400EE7E")]
		ChainRun = 0,
		[Token(Token = "0x400EE7F")]
		CardBreak = 1,
		[Token(Token = "0x400EE80")]
		CardMove = 2,
		[Token(Token = "0x400EE81")]
		SpecialFx = 3,
		[Token(Token = "0x400EE82")]
		CardDisable = 4,
		[Token(Token = "0x400EE83")]
		Unknown = 65535
	}

	[Token(Token = "0x20019DC")]
	public enum Player
	{
		[Token(Token = "0x400EE85")]
		Myself,
		[Token(Token = "0x400EE86")]
		Rival,
		[Token(Token = "0x400EE87")]
		Any
	}

	[Token(Token = "0x20019DD")]
	[Flags]
	public enum Position
	{
		[Token(Token = "0x400EE89")]
		None = 0,
		[Token(Token = "0x400EE8A")]
		NearMonster = 1,
		[Token(Token = "0x400EE8B")]
		NearMagic = 2,
		[Token(Token = "0x400EE8C")]
		NearHand = 4,
		[Token(Token = "0x400EE8D")]
		NearGraveExclude = 8,
		[Token(Token = "0x400EE8E")]
		NearDeck = 0x10,
		[Token(Token = "0x400EE8F")]
		ExMonster = 0x20,
		[Token(Token = "0x400EE90")]
		FarMonster = 0x40,
		[Token(Token = "0x400EE91")]
		FarMagic = 0x80,
		[Token(Token = "0x400EE92")]
		FarHand = 0x100,
		[Token(Token = "0x400EE93")]
		FarGraveExclude = 0x200,
		[Token(Token = "0x400EE94")]
		FarDeck = 0x400,
		[Token(Token = "0x400EE95")]
		NearField = 0x800,
		[Token(Token = "0x400EE96")]
		FarField = 0x1000,
		[Token(Token = "0x400EE97")]
		NearAll = 0x81F,
		[Token(Token = "0x400EE98")]
		FarAll = 0x17C0,
		[Token(Token = "0x400EE99")]
		Any = 0x1FFF,
		[Token(Token = "0x400EE9A")]
		Unknown = 0xE000
	}

	[Token(Token = "0x20019DE")]
	public enum RotationType
	{
		[Token(Token = "0x400EE9C")]
		None,
		[Token(Token = "0x400EE9D")]
		PivotToTarget
	}

	[Token(Token = "0x20019DF")]
	public enum ExtraSetting
	{
		[Token(Token = "0x400EE9F")]
		None,
		[Token(Token = "0x400EEA0")]
		PositionActivation,
		[Token(Token = "0x400EEA1")]
		CardAttackPosition,
		[Token(Token = "0x400EEA2")]
		ChangeLayerMagic,
		[Token(Token = "0x400EEA3")]
		ChangeLayerOver3D,
		[Token(Token = "0x400EEA4")]
		TraceTargetCard,
		[Token(Token = "0x400EEA5")]
		MulcharmyFuwalos,
		[Token(Token = "0x400EEA6")]
		MulcharmyPurulia,
		[Token(Token = "0x400EEA7")]
		MulcharmyMeowls,
		[Token(Token = "0x400EEA8")]
		TraceRotatedTargetCard,
		[Token(Token = "0x400EEA9")]
		PlacePositionEffectOffset,
		[Token(Token = "0x400EEAA")]
		DrollAndLockBird,
		[Token(Token = "0x400EEAB")]
		DrollAndLockBirdAlt
	}

	[Serializable]
	[Token(Token = "0x20019E0")]
	public class PositionalEffectSetting
	{
		[Token(Token = "0x400EEAC")]
		[FieldOffset(Offset = "0x10")]
		public Position targetPosition;

		[Token(Token = "0x400EEAD")]
		[FieldOffset(Offset = "0x18")]
		public string effectPath;

		[Token(Token = "0x600A6C1")]
		[Address(RVA = "0xF2E020", Offset = "0xF2D220", VA = "0x180F2E020")]
		public PositionalEffectSetting()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20019E1")]
	public class CardRunEffectInfo
	{
		[Token(Token = "0x400EEAE")]
		[FieldOffset(Offset = "0x10")]
		public bool enable;

		[Token(Token = "0x400EEAF")]
		[FieldOffset(Offset = "0x14")]
		public int mrk;

		[Token(Token = "0x400EEB0")]
		[FieldOffset(Offset = "0x18")]
		public int effectNo;

		[Token(Token = "0x400EEB1")]
		[FieldOffset(Offset = "0x1C")]
		public Player player;

		[Token(Token = "0x400EEB2")]
		[FieldOffset(Offset = "0x20")]
		public RunTiming runTiming;

		[Token(Token = "0x400EEB3")]
		[FieldOffset(Offset = "0x24")]
		public bool useTargetEffect;

		[Token(Token = "0x400EEB4")]
		[FieldOffset(Offset = "0x28")]
		public PlayType playType;

		[Token(Token = "0x400EEB5")]
		[FieldOffset(Offset = "0x2C")]
		public int effectType;

		[Token(Token = "0x400EEB6")]
		[FieldOffset(Offset = "0x30")]
		public string effectPath;

		[Token(Token = "0x400EEB7")]
		[FieldOffset(Offset = "0x38")]
		public List<PositionalEffectSetting> positionalEffect;

		[Token(Token = "0x400EEB8")]
		[FieldOffset(Offset = "0x40")]
		public RotationType rotationType;

		[Token(Token = "0x400EEB9")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 pivot;

		[Token(Token = "0x400EEBA")]
		[FieldOffset(Offset = "0x50")]
		public float delay;

		[Token(Token = "0x400EEBB")]
		[FieldOffset(Offset = "0x54")]
		public ExtraSetting extraSettings;

		[Token(Token = "0x400EEBC")]
		[FieldOffset(Offset = "0x58")]
		public bool useCenterEffect;

		[Token(Token = "0x400EEBD")]
		[FieldOffset(Offset = "0x5C")]
		public PlayType centerPlayType;

		[Token(Token = "0x400EEBE")]
		[FieldOffset(Offset = "0x60")]
		public int centerEffectType;

		[Token(Token = "0x400EEBF")]
		[FieldOffset(Offset = "0x68")]
		public string centerEffectPath;

		[Token(Token = "0x400EEC0")]
		[FieldOffset(Offset = "0x70")]
		public float centerDelay;

		[Token(Token = "0x400EEC1")]
		[FieldOffset(Offset = "0x74")]
		public ExtraSetting centerExtraSettings;

		[Token(Token = "0x400EEC2")]
		[FieldOffset(Offset = "0x78")]
		public bool reserveCardMoveEffect;

		[Token(Token = "0x400EEC3")]
		[FieldOffset(Offset = "0x80")]
		public string cardMoveEffectLabel;

		[Token(Token = "0x400EEC4")]
		[FieldOffset(Offset = "0x88")]
		public List<int> cardMoveEffectTargetCardID;

		[Token(Token = "0x400EEC5")]
		[FieldOffset(Offset = "0x90")]
		public List<Engine.CardMoveType> cardMoveEffectMoveType;

		[Token(Token = "0x400EEC6")]
		[FieldOffset(Offset = "0x98")]
		public string seLabel;

		[Token(Token = "0x400EEC7")]
		[FieldOffset(Offset = "0xA0")]
		public bool is3Dse;

		[Token(Token = "0x400EEC8")]
		[FieldOffset(Offset = "0xA1")]
		public bool isNormalSe;

		[Token(Token = "0x400EEC9")]
		[FieldOffset(Offset = "0xA2")]
		public bool waitFinish;

		[Token(Token = "0x400EECA")]
		[FieldOffset(Offset = "0xA4")]
		public float finishSecond;

		[Token(Token = "0x400EECB")]
		[FieldOffset(Offset = "0xA8")]
		public bool blockInput;

		[Token(Token = "0x400EECC")]
		[FieldOffset(Offset = "0xB0")]
		public string cameraShakeType;

		[Token(Token = "0x400EECD")]
		[FieldOffset(Offset = "0xB8")]
		public string expandPath;

		[Token(Token = "0x400EECE")]
		[FieldOffset(Offset = "0xC0")]
		public bool essential;

		[Token(Token = "0x600A6C2")]
		[Address(RVA = "0xF221C0", Offset = "0xF213C0", VA = "0x180F221C0")]
		public CardRunEffectInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600A6C3")]
		[Address(RVA = "0xF22240", Offset = "0xF21440", VA = "0x180F22240")]
		public string GetEffectPath(Position targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600A6C4")]
		[Address(RVA = "0xF22390", Offset = "0xF21590", VA = "0x180F22390")]
		public string GetExpandPath()
		{
			return null;
		}

		[Token(Token = "0x600A6C5")]
		[Address(RVA = "0xF22400", Offset = "0xF21600", VA = "0x180F22400")]
		public CardRunEffectInfo()
		{
		}
	}

	[Token(Token = "0x400EE78")]
	[FieldOffset(Offset = "0x18")]
	public List<CardRunEffectInfo> infoList;

	[Token(Token = "0x600A6BE")]
	[Address(RVA = "0xF225E0", Offset = "0xF217E0", VA = "0x180F225E0")]
	public CardRunEffectInfo Get(int mrk, Player player, int effectNo = -1)
	{
		return null;
	}

	[Token(Token = "0x600A6BF")]
	[Address(RVA = "0xF22540", Offset = "0xF21740", VA = "0x180F22540")]
	public CardRunEffectInfo Get(int mrk)
	{
		return null;
	}

	[Token(Token = "0x600A6C0")]
	[Address(RVA = "0xF226D0", Offset = "0xF218D0", VA = "0x180F226D0")]
	public CardRunEffectSetting()
	{
	}
}
