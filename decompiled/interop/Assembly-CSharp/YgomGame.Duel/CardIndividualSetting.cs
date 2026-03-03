using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x200197C")]
public class CardIndividualSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200197D")]
	public class MrkPowerTable
	{
		[Token(Token = "0x400EC86")]
		[FieldOffset(Offset = "0x10")]
		public int mrk;

		[Token(Token = "0x400EC87")]
		[FieldOffset(Offset = "0x14")]
		public EffectTaskCardMove.LandingType power;

		[Token(Token = "0x600A38C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MrkPowerTable()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200197E")]
	public class MonsterCutinTable
	{
		[Token(Token = "0x400EC88")]
		[FieldOffset(Offset = "0x10")]
		public int mrk;

		[Token(Token = "0x400EC89")]
		[FieldOffset(Offset = "0x14")]
		public int cutin_mrk;

		[Token(Token = "0x600A38D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MonsterCutinTable()
		{
		}
	}

	[Token(Token = "0x400EC82")]
	[FieldOffset(Offset = "0x0")]
	private static CardIndividualSetting m_Instance;

	[Token(Token = "0x400EC83")]
	private const string assetPath = "Duel/ScriptableObject/CardIndividualData";

	[Token(Token = "0x400EC84")]
	[FieldOffset(Offset = "0x18")]
	public List<MrkPowerTable> mrkPowerTable;

	[Token(Token = "0x400EC85")]
	[FieldOffset(Offset = "0x20")]
	public List<MonsterCutinTable> monsterCutinTable;

	[Token(Token = "0x170018F9")]
	protected static CardIndividualSetting instance
	{
		[Token(Token = "0x600A385")]
		[Address(RVA = "0xF06850", Offset = "0xF05A50", VA = "0x180F06850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A386")]
	[Address(RVA = "0xF065F0", Offset = "0xF057F0", VA = "0x180F065F0")]
	public static void LoadSetting(Action<CardIndividualSetting> onFinished)
	{
	}

	[Token(Token = "0x600A387")]
	[Address(RVA = "0xF06740", Offset = "0xF05940", VA = "0x180F06740")]
	public static void UnloadSetting()
	{
	}

	[Token(Token = "0x600A388")]
	[Address(RVA = "0xF063A0", Offset = "0xF055A0", VA = "0x180F063A0")]
	public static EffectTaskCardMove.LandingType GetMonsterPower(int cardid)
	{
		return default(EffectTaskCardMove.LandingType);
	}

	[Token(Token = "0x600A389")]
	[Address(RVA = "0xF064F0", Offset = "0xF056F0", VA = "0x180F064F0")]
	public static bool IsMonsterCutin(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600A38A")]
	[Address(RVA = "0xF06260", Offset = "0xF05460", VA = "0x180F06260")]
	public static int GetMonsterCutinMRK(int cardID)
	{
		return default(int);
	}

	[Token(Token = "0x600A38B")]
	[Address(RVA = "0xF06790", Offset = "0xF05990", VA = "0x180F06790")]
	public CardIndividualSetting()
	{
	}
}
