using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A8A")]
public class SimpleEffect : DuelEffectHandle
{
	[Token(Token = "0x400F4AD")]
	[FieldOffset(Offset = "0x78")]
	private List<ParticleSystem> pss;

	[Token(Token = "0x400F4AE")]
	[FieldOffset(Offset = "0x80")]
	private List<TrailRenderer> trs;

	[Token(Token = "0x400F4AF")]
	[FieldOffset(Offset = "0x88")]
	private List<Animator> animators;

	[Token(Token = "0x400F4B0")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<string, float[]> trailW;

	[Token(Token = "0x400F4B1")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<ParticleSystem, float> defaultStartDelay;

	[Token(Token = "0x400F4B2")]
	[FieldOffset(Offset = "0xA0")]
	private float duration;

	[Token(Token = "0x400F4B3")]
	[FieldOffset(Offset = "0xA4")]
	private float time;

	[Token(Token = "0x400F4B4")]
	[FieldOffset(Offset = "0xA8")]
	private bool looping;

	[Token(Token = "0x17001ABA")]
	public override bool isPlaying
	{
		[Token(Token = "0x600AC9F")]
		[Address(RVA = "0x436900", Offset = "0x435B00", VA = "0x180436900", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001ABB")]
	public float delay
	{
		[Token(Token = "0x600ACA0")]
		[Address(RVA = "0x436C40", Offset = "0x435E40", VA = "0x180436C40")]
		set
		{
		}
	}

	[Token(Token = "0x600AC99")]
	[Address(RVA = "0x435720", Offset = "0x434920", VA = "0x180435720", Slot = "4")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x600AC9A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	protected virtual void OnInitializeImpl()
	{
	}

	[Token(Token = "0x600AC9B")]
	[Address(RVA = "0x4362D0", Offset = "0x4354D0", VA = "0x1804362D0", Slot = "5")]
	protected override void OnTerminate()
	{
	}

	[Token(Token = "0x600AC9C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	protected virtual void OnTerminateImpl()
	{
	}

	[Token(Token = "0x600AC9D")]
	[Address(RVA = "0x435F30", Offset = "0x435130", VA = "0x180435F30", Slot = "7")]
	protected override void OnPlay()
	{
	}

	[Token(Token = "0x600AC9E")]
	[Address(RVA = "0x436050", Offset = "0x435250", VA = "0x180436050", Slot = "8")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600ACA1")]
	[Address(RVA = "0x436630", Offset = "0x435830", VA = "0x180436630", Slot = "10")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600ACA2")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public SimpleEffect()
	{
	}
}
