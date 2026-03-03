using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001989")]
public class CardMoveMotionSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200198A")]
	public class MotionInfo
	{
		[Token(Token = "0x400ECC7")]
		[FieldOffset(Offset = "0x10")]
		public TeamType teamType;

		[Token(Token = "0x400ECC8")]
		[FieldOffset(Offset = "0x14")]
		public PositionType fromPositon;

		[Token(Token = "0x400ECC9")]
		[FieldOffset(Offset = "0x18")]
		public PositionType toPosition;

		[Token(Token = "0x400ECCA")]
		[FieldOffset(Offset = "0x1C")]
		public CardType cardType;

		[Token(Token = "0x400ECCB")]
		[FieldOffset(Offset = "0x20")]
		public int cardPower;

		[Token(Token = "0x400ECCC")]
		[FieldOffset(Offset = "0x24")]
		public FaceType faceType;

		[Token(Token = "0x400ECCD")]
		[FieldOffset(Offset = "0x28")]
		public List<BezierMotionSetting> motionList;

		[Token(Token = "0x400ECCE")]
		[FieldOffset(Offset = "0x30")]
		public string seCode;

		[Token(Token = "0x600A407")]
		[Address(RVA = "0xF15130", Offset = "0xF14330", VA = "0x180F15130")]
		public MotionInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600A408")]
		[Address(RVA = "0xF15330", Offset = "0xF14530", VA = "0x180F15330")]
		public MotionInfo()
		{
		}
	}

	[Token(Token = "0x200198B")]
	public enum TeamType
	{
		[Token(Token = "0x400ECD0")]
		Both,
		[Token(Token = "0x400ECD1")]
		Myself,
		[Token(Token = "0x400ECD2")]
		Rival
	}

	[Token(Token = "0x200198C")]
	public enum PositionType
	{
		[Token(Token = "0x400ECD4")]
		Unknown,
		[Token(Token = "0x400ECD5")]
		Deck,
		[Token(Token = "0x400ECD6")]
		ExtraDeck,
		[Token(Token = "0x400ECD7")]
		Hand,
		[Token(Token = "0x400ECD8")]
		MonsterZone,
		[Token(Token = "0x400ECD9")]
		MagicZone,
		[Token(Token = "0x400ECDA")]
		Grave,
		[Token(Token = "0x400ECDB")]
		Exclude,
		[Token(Token = "0x400ECDC")]
		XyzMaterial
	}

	[Token(Token = "0x200198D")]
	public enum CardType
	{
		[Token(Token = "0x400ECDE")]
		Normal,
		[Token(Token = "0x400ECDF")]
		Soul,
		[Token(Token = "0x400ECE0")]
		Both
	}

	[Token(Token = "0x200198E")]
	public enum FaceType
	{
		[Token(Token = "0x400ECE2")]
		Face,
		[Token(Token = "0x400ECE3")]
		Back,
		[Token(Token = "0x400ECE4")]
		Both
	}

	[Token(Token = "0x400ECC4")]
	[FieldOffset(Offset = "0x18")]
	public List<MotionInfo> infoList;

	[Token(Token = "0x400ECC6")]
	private const string motionSettingPath = "Duel/ScriptableObject/BezierMotion/CardMoveMotion/CardMoveMotionSetting";

	[Token(Token = "0x17001912")]
	public static CardMoveMotionSetting instance
	{
		[Token(Token = "0x600A403")]
		[Address(RVA = "0xF0A7E0", Offset = "0xF099E0", VA = "0x180F0A7E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A404")]
		[Address(RVA = "0xF0A820", Offset = "0xF09A20", VA = "0x180F0A820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A3FB")]
	[Address(RVA = "0xF09F20", Offset = "0xF09120", VA = "0x180F09F20")]
	public MotionInfo GetInfo(SharedDefinition.Location fromLocation, int fromPosition, int fromIndex, SharedDefinition.Location toLocation, int toPosition, int toIndex, CardType cardType, int cardPower, FaceType faceType)
	{
		return null;
	}

	[Token(Token = "0x600A3FC")]
	[Address(RVA = "0xF0A740", Offset = "0xF09940", VA = "0x180F0A740")]
	private PositionType PositionToPositionType(int position, int index)
	{
		return default(PositionType);
	}

	[Token(Token = "0x600A3FD")]
	[Address(RVA = "0xF0A1F0", Offset = "0xF093F0", VA = "0x180F0A1F0")]
	public MotionInfo GetInfo(SharedDefinition.Location fromLocation, PositionType fromPosition, SharedDefinition.Location toLocation, PositionType toPosition, CardType cardType, int cardPower, FaceType faceType)
	{
		return null;
	}

	[Token(Token = "0x600A3FE")]
	[Address(RVA = "0xF0A060", Offset = "0xF09260", VA = "0x180F0A060")]
	public MotionInfo GetInfo(SharedDefinition.Location fromLocation, int fromPosition, int fromIndex, SharedDefinition.Location toLocation, int toPosition, int toIndex, bool toFace, CardType cardType, int cardPower = 0)
	{
		return null;
	}

	[Token(Token = "0x600A3FF")]
	[Address(RVA = "0xF0A310", Offset = "0xF09510", VA = "0x180F0A310")]
	public BezierMotionSetting[] GetMotion(SharedDefinition.Location fromLocation, int fromPosition, int fromIndex, SharedDefinition.Location toLocation, int toPosition, int toIndex, bool toFace, CardType cardType, int cardPower = 0)
	{
		return null;
	}

	[Token(Token = "0x600A400")]
	[Address(RVA = "0xF0A0D0", Offset = "0xF092D0", VA = "0x180F0A0D0")]
	public List<MotionInfo> GetInfo(PositionType fromPosition, PositionType toPosition)
	{
		return null;
	}

	[Token(Token = "0x600A401")]
	[Address(RVA = "0xF09E70", Offset = "0xF09070", VA = "0x180F09E70")]
	public int GetInfoIndex(MotionInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x600A402")]
	[Address(RVA = "0xF0A410", Offset = "0xF09610", VA = "0x180F0A410")]
	public static string GetMoveStartSE(string seCode)
	{
		return null;
	}

	[Token(Token = "0x600A405")]
	[Address(RVA = "0xF0A670", Offset = "0xF09870", VA = "0x180F0A670")]
	public static void Load(Action onFinished)
	{
	}

	[Token(Token = "0x600A406")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CardMoveMotionSetting()
	{
	}
}
