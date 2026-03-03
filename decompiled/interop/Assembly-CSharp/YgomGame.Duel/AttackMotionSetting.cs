using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001933")]
public class AttackMotionSetting : ScriptableObject
{
	[Token(Token = "0x2001934")]
	public enum EffectTiming
	{
		[Token(Token = "0x400EB02")]
		OnStart,
		[Token(Token = "0x400EB03")]
		OnFinish
	}

	[Serializable]
	[Token(Token = "0x2001935")]
	public class MotionInfo
	{
		[Token(Token = "0x400EB04")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400EB05")]
		[FieldOffset(Offset = "0x18")]
		public List<MotionList> motionList;

		[Token(Token = "0x400EB06")]
		[FieldOffset(Offset = "0x20")]
		public string startSoundLabel;

		[Token(Token = "0x400EB07")]
		[FieldOffset(Offset = "0x28")]
		public bool useTrailEffect;

		[Token(Token = "0x400EB08")]
		[FieldOffset(Offset = "0x2C")]
		public DuelEffectPool.Type trailEffect;

		[Token(Token = "0x400EB09")]
		[FieldOffset(Offset = "0x30")]
		public EffectTiming trailTiming;

		[Token(Token = "0x400EB0A")]
		[FieldOffset(Offset = "0x34")]
		public float trailTimingOffset;

		[Token(Token = "0x400EB0B")]
		[FieldOffset(Offset = "0x38")]
		public bool useAttackEffect;

		[Token(Token = "0x400EB0C")]
		[FieldOffset(Offset = "0x3C")]
		public DuelEffectPool.Type attackEffect;

		[Token(Token = "0x400EB0D")]
		[FieldOffset(Offset = "0x40")]
		public string attackSoundLabel;

		[Token(Token = "0x400EB0E")]
		[FieldOffset(Offset = "0x48")]
		public EffectTiming attackTiming;

		[Token(Token = "0x400EB0F")]
		[FieldOffset(Offset = "0x4C")]
		public float attackTimingOffset;

		[Token(Token = "0x400EB10")]
		[FieldOffset(Offset = "0x50")]
		public bool useHitEffect;

		[Token(Token = "0x400EB11")]
		[FieldOffset(Offset = "0x54")]
		public DuelEffectPool.Type hitEffect;

		[Token(Token = "0x400EB12")]
		[FieldOffset(Offset = "0x58")]
		public string hitSoundLabel;

		[Token(Token = "0x400EB13")]
		[FieldOffset(Offset = "0x60")]
		public EffectTiming hitTiming;

		[Token(Token = "0x400EB14")]
		[FieldOffset(Offset = "0x64")]
		public float hitTimingOffset;

		[Token(Token = "0x400EB15")]
		[FieldOffset(Offset = "0x68")]
		public bool forceHitEffect;

		[Token(Token = "0x400EB16")]
		[FieldOffset(Offset = "0x69")]
		public bool useShootEffect;

		[Token(Token = "0x400EB17")]
		[FieldOffset(Offset = "0x6C")]
		public DuelEffectPool.Type shootEffect;

		[Token(Token = "0x400EB18")]
		[FieldOffset(Offset = "0x70")]
		public string shootSoundLabel;

		[Token(Token = "0x400EB19")]
		[FieldOffset(Offset = "0x78")]
		public EffectTiming shootTiming;

		[Token(Token = "0x400EB1A")]
		[FieldOffset(Offset = "0x7C")]
		public float shootTimingOffset;

		[Token(Token = "0x400EB1B")]
		[FieldOffset(Offset = "0x80")]
		public BezierMotionContainer shootMotionSetting;

		[Token(Token = "0x400EB1C")]
		[FieldOffset(Offset = "0x88")]
		public List<TimelineInfo> timelineInfoList;

		[Token(Token = "0x400EB1D")]
		[FieldOffset(Offset = "0x90")]
		public bool forLethalAttack;

		[Token(Token = "0x400EB1E")]
		[FieldOffset(Offset = "0x91")]
		public bool fieldCenterLethal;

		[Token(Token = "0x400EB1F")]
		[FieldOffset(Offset = "0x92")]
		public bool changeCardLayerToOver3D;

		[Token(Token = "0x600A282")]
		[Address(RVA = "0xEF5CA0", Offset = "0xEF4EA0", VA = "0x180EF5CA0")]
		public MotionInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600A283")]
		[Address(RVA = "0xEF62B0", Offset = "0xEF54B0", VA = "0x180EF62B0")]
		private float GetStartTime(EffectTiming timing, float offset, int motionIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600A284")]
		[Address(RVA = "0xEF6460", Offset = "0xEF5660", VA = "0x180EF6460")]
		public float GetTrailStartTime(int motionIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600A285")]
		[Address(RVA = "0xEF6220", Offset = "0xEF5420", VA = "0x180EF6220")]
		public float GetAttackStartTime(int motionIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600A286")]
		[Address(RVA = "0xEF6250", Offset = "0xEF5450", VA = "0x180EF6250")]
		public float GetHitStartTime(int motionIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600A287")]
		[Address(RVA = "0xEF6280", Offset = "0xEF5480", VA = "0x180EF6280")]
		public float GetShootStartTime(int motionIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600A288")]
		[Address(RVA = "0xEF63D0", Offset = "0xEF55D0", VA = "0x180EF63D0")]
		public float GetTimelineStartTime(int motionIndex, int timelineIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600A289")]
		[Address(RVA = "0xEF6490", Offset = "0xEF5690", VA = "0x180EF6490")]
		public MotionInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001936")]
	public class TimelineInfo
	{
		[Token(Token = "0x2001937")]
		public enum PlayTarget
		{
			[Token(Token = "0x400EB2C")]
			Attacker,
			[Token(Token = "0x400EB2D")]
			Defender,
			[Token(Token = "0x400EB2E")]
			Origin
		}

		[Token(Token = "0x2001938")]
		public enum RotationMode
		{
			[Token(Token = "0x400EB30")]
			None,
			[Token(Token = "0x400EB31")]
			LookTarget,
			[Token(Token = "0x400EB32")]
			LookTargetRotOffset
		}

		[Token(Token = "0x400EB20")]
		[FieldOffset(Offset = "0x10")]
		public PlayTarget playTarget;

		[Token(Token = "0x400EB21")]
		[FieldOffset(Offset = "0x14")]
		public bool line;

		[Token(Token = "0x400EB22")]
		[FieldOffset(Offset = "0x15")]
		public bool trace;

		[Token(Token = "0x400EB23")]
		[FieldOffset(Offset = "0x18")]
		public RotationMode rotationMode;

		[Token(Token = "0x400EB24")]
		[FieldOffset(Offset = "0x1C")]
		public bool onlyRotationY;

		[Token(Token = "0x400EB25")]
		[FieldOffset(Offset = "0x1D")]
		public bool reverseIfRival;

		[Token(Token = "0x400EB26")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x400EB27")]
		[FieldOffset(Offset = "0x28")]
		public EffectTiming timing;

		[Token(Token = "0x400EB28")]
		[FieldOffset(Offset = "0x2C")]
		public float timingOffset;

		[Token(Token = "0x400EB29")]
		[FieldOffset(Offset = "0x30")]
		public string soundLabel;

		[Token(Token = "0x400EB2A")]
		[FieldOffset(Offset = "0x38")]
		public bool changeLayerToOver3D;

		[Token(Token = "0x600A28A")]
		[Address(RVA = "0xEFD650", Offset = "0xEFC850", VA = "0x180EFD650")]
		public TimelineInfo Clone()
		{
			return null;
		}

		[Token(Token = "0x600A28B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TimelineInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001939")]
	public class MotionList
	{
		[Token(Token = "0x400EB33")]
		[FieldOffset(Offset = "0x10")]
		public List<BezierMotionSetting> settingList;

		[Token(Token = "0x170018E7")]
		public float animationTime
		{
			[Token(Token = "0x600A28C")]
			[Address(RVA = "0xEF6610", Offset = "0xEF5810", VA = "0x180EF6610")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600A28D")]
		[Address(RVA = "0xEF6590", Offset = "0xEF5790", VA = "0x180EF6590")]
		public MotionList()
		{
		}
	}

	[Token(Token = "0x400EB00")]
	[FieldOffset(Offset = "0x18")]
	public List<MotionInfo> infoList;

	[Token(Token = "0x600A280")]
	[Address(RVA = "0xEE7180", Offset = "0xEE6380", VA = "0x180EE7180")]
	public MotionInfo Get(string label)
	{
		return null;
	}

	[Token(Token = "0x600A281")]
	[Address(RVA = "0xEE7250", Offset = "0xEE6450", VA = "0x180EE7250")]
	public AttackMotionSetting()
	{
	}
}
