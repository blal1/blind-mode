using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A6F")]
public class ResidualEffect
{
	[Token(Token = "0x2001A70")]
	public class EffectInfo
	{
		[Token(Token = "0x400F392")]
		[FieldOffset(Offset = "0x10")]
		public SimpleEffect effectObj;

		[Token(Token = "0x400F393")]
		[FieldOffset(Offset = "0x18")]
		public DuelEffectPool.Type type;

		[Token(Token = "0x400F394")]
		[FieldOffset(Offset = "0x1C")]
		public EngineApiUtil.Place place;

		[Token(Token = "0x600ABAD")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public EffectInfo()
		{
		}
	}

	[Token(Token = "0x2001A71")]
	public class PrepareInfo
	{
		[Token(Token = "0x400F395")]
		[FieldOffset(Offset = "0x10")]
		public DuelEffectPool.Type type;

		[Token(Token = "0x400F396")]
		[FieldOffset(Offset = "0x14")]
		public int player;

		[Token(Token = "0x400F397")]
		[FieldOffset(Offset = "0x18")]
		public int position;

		[Token(Token = "0x600ABAE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PrepareInfo()
		{
		}
	}

	[Token(Token = "0x400F38F")]
	[FieldOffset(Offset = "0x10")]
	private DuelEffectPool pool;

	[Token(Token = "0x400F390")]
	[FieldOffset(Offset = "0x18")]
	private List<EffectInfo> effects;

	[Token(Token = "0x400F391")]
	[FieldOffset(Offset = "0x20")]
	private List<PrepareInfo> prepareInfoList;

	[Token(Token = "0x600AB9F")]
	[Address(RVA = "0x4295A0", Offset = "0x4287A0", VA = "0x1804295A0")]
	public static ResidualEffect Create(DuelEffectPool pool)
	{
		return null;
	}

	[Token(Token = "0x600ABA0")]
	[Address(RVA = "0x429BF0", Offset = "0x428DF0", VA = "0x180429BF0")]
	public EffectInfo Play(DuelEffectPool.Type type, EngineApiUtil.Place place, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x600ABA1")]
	[Address(RVA = "0x4296B0", Offset = "0x4288B0", VA = "0x1804296B0")]
	private void ExtraOperation(EffectInfo info)
	{
	}

	[Token(Token = "0x600ABA2")]
	[Address(RVA = "0x429840", Offset = "0x428A40", VA = "0x180429840")]
	private bool IsAlreadyPlaying(DuelEffectPool.Type type, EngineApiUtil.Place place)
	{
		return default(bool);
	}

	[Token(Token = "0x600ABA3")]
	[Address(RVA = "0x4299E0", Offset = "0x428BE0", VA = "0x1804299E0")]
	public void OnTurnEnd()
	{
	}

	[Token(Token = "0x600ABA4")]
	[Address(RVA = "0x429F90", Offset = "0x429190", VA = "0x180429F90")]
	private void StopAllEffects()
	{
	}

	[Token(Token = "0x600ABA5")]
	[Address(RVA = "0x42A060", Offset = "0x429260", VA = "0x18042A060")]
	private void StopEffect(DuelEffectPool.Type type, int position)
	{
	}

	[Token(Token = "0x600ABA6")]
	[Address(RVA = "0x429930", Offset = "0x428B30", VA = "0x180429930")]
	private bool IsContainEffect(DuelEffectPool.Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x600ABA7")]
	[Address(RVA = "0x4299E0", Offset = "0x428BE0", VA = "0x1804299E0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600ABA8")]
	[Address(RVA = "0x429E80", Offset = "0x429080", VA = "0x180429E80")]
	public void Prepare(DuelEffectPool.Type type, int player, int position)
	{
	}

	[Token(Token = "0x600ABA9")]
	[Address(RVA = "0x4299F0", Offset = "0x428BF0", VA = "0x1804299F0")]
	public void PlayPreparedEffect(DuelFieldBase duelField)
	{
	}

	[Token(Token = "0x600ABAA")]
	[Address(RVA = "0x429540", Offset = "0x428740", VA = "0x180429540")]
	public void CancelPreareEffect()
	{
	}

	[Token(Token = "0x600ABAB")]
	[Address(RVA = "0x42A190", Offset = "0x429390", VA = "0x18042A190")]
	public void UpdateEffects()
	{
	}

	[Token(Token = "0x600ABAC")]
	[Address(RVA = "0x42A3C0", Offset = "0x4295C0", VA = "0x18042A3C0")]
	public ResidualEffect()
	{
	}
}
