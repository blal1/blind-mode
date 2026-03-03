using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001B2F")]
public class EffectTaskManaSet : EffectTask
{
	[Token(Token = "0x2001B30")]
	private enum Step
	{
		[Token(Token = "0x400F7EA")]
		WaitCardEffect,
		[Token(Token = "0x400F7EB")]
		WaitManaSet,
		[Token(Token = "0x400F7EC")]
		Finish
	}

	[Token(Token = "0x400F7E1")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 anchor;

	[Token(Token = "0x400F7E2")]
	[FieldOffset(Offset = "0x24")]
	private float timer;

	[Token(Token = "0x400F7E3")]
	private const float waitTime = 0.5f;

	[Token(Token = "0x400F7E4")]
	[FieldOffset(Offset = "0x28")]
	private Engine.CounterType counterType;

	[Token(Token = "0x400F7E5")]
	[FieldOffset(Offset = "0x2C")]
	private int dispCount;

	[Token(Token = "0x400F7E6")]
	[FieldOffset(Offset = "0x30")]
	private int targetCount;

	[Token(Token = "0x400F7E7")]
	[FieldOffset(Offset = "0x38")]
	private ManaSet manaSet;

	[Token(Token = "0x400F7E8")]
	[FieldOffset(Offset = "0x40")]
	private Step step;

	[Token(Token = "0x600AFD9")]
	[Address(RVA = "0x4713A0", Offset = "0x4705A0", VA = "0x1804713A0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFDA")]
	[Address(RVA = "0x471300", Offset = "0x470500", VA = "0x180471300")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AFDB")]
	[Address(RVA = "0x4716E0", Offset = "0x4708E0", VA = "0x1804716E0")]
	public EffectTaskManaSet(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AFDC")]
	[Address(RVA = "0x4714E0", Offset = "0x4706E0", VA = "0x1804714E0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AFDD")]
	[Address(RVA = "0x4715F0", Offset = "0x4707F0", VA = "0x1804715F0")]
	private void WaitCardEffectStep()
	{
	}

	[Token(Token = "0x600AFDE")]
	[Address(RVA = "0x471690", Offset = "0x470890", VA = "0x180471690")]
	private void WaitManaSetStep()
	{
	}
}
