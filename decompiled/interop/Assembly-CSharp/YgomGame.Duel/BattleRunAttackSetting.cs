using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;

namespace YgomGame.Duel;

[Token(Token = "0x2001945")]
public class BattleRunAttackSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001946")]
	public class DefaultMotionType
	{
		[Token(Token = "0x400EB8C")]
		[FieldOffset(Offset = "0x10")]
		public Content.Attribute keyAttribute;

		[Token(Token = "0x400EB8D")]
		[FieldOffset(Offset = "0x14")]
		public EffectTaskBattleRun.AttackType attackType;

		[Token(Token = "0x600A2D8")]
		[Address(RVA = "0xEED330", Offset = "0xEEC530", VA = "0x180EED330")]
		public DefaultMotionType Copy()
		{
			return null;
		}

		[Token(Token = "0x600A2D9")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DefaultMotionType()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001947")]
	public class CardMotionType
	{
		[Token(Token = "0x400EB8E")]
		[FieldOffset(Offset = "0x10")]
		public int cardID;

		[Token(Token = "0x400EB8F")]
		[FieldOffset(Offset = "0x14")]
		public EffectTaskBattleRun.AttackType attackType;

		[Token(Token = "0x400EB90")]
		[FieldOffset(Offset = "0x18")]
		public LethalEffect.EffectType lethalEffectType;

		[Token(Token = "0x600A2DA")]
		[Address(RVA = "0xEEC470", Offset = "0xEEB670", VA = "0x180EEC470")]
		public CardMotionType Copy()
		{
			return null;
		}

		[Token(Token = "0x600A2DB")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CardMotionType()
		{
		}
	}

	[Token(Token = "0x400EB8A")]
	[FieldOffset(Offset = "0x18")]
	public List<DefaultMotionType> defaultMotionSettings;

	[Token(Token = "0x400EB8B")]
	[FieldOffset(Offset = "0x20")]
	public List<CardMotionType> cardMotionSettings;

	[Token(Token = "0x600A2D4")]
	[Address(RVA = "0xEEA340", Offset = "0xEE9540", VA = "0x180EEA340")]
	public EffectTaskBattleRun.AttackType GetDefaultAttackType(Content.Attribute attribute)
	{
		return default(EffectTaskBattleRun.AttackType);
	}

	[Token(Token = "0x600A2D5")]
	[Address(RVA = "0xEEA1A0", Offset = "0xEE93A0", VA = "0x180EEA1A0")]
	public EffectTaskBattleRun.AttackType GetCardAttackType(int card_id)
	{
		return default(EffectTaskBattleRun.AttackType);
	}

	[Token(Token = "0x600A2D6")]
	[Address(RVA = "0xEEA270", Offset = "0xEE9470", VA = "0x180EEA270")]
	public LethalEffect.EffectType GetCardLethaEffectType(int card_id)
	{
		return default(LethalEffect.EffectType);
	}

	[Token(Token = "0x600A2D7")]
	[Address(RVA = "0xEEA410", Offset = "0xEE9610", VA = "0x180EEA410")]
	public BattleRunAttackSetting()
	{
	}
}
