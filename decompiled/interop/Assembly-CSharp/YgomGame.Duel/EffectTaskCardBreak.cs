using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AD3")]
public class EffectTaskCardBreak : EffectTask
{
	[Token(Token = "0x2001AD4")]
	private enum Step
	{
		[Token(Token = "0x400F5F8")]
		WaitCardRunEffect,
		[Token(Token = "0x400F5F9")]
		Finish
	}

	[Token(Token = "0x400F5F2")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F5F3")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F5F4")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F5F5")]
	[FieldOffset(Offset = "0x24")]
	private int position;

	[Token(Token = "0x400F5F6")]
	[FieldOffset(Offset = "0x28")]
	private int index;

	[Token(Token = "0x600AE59")]
	[Address(RVA = "0x455960", Offset = "0x454B60", VA = "0x180455960")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE5A")]
	[Address(RVA = "0x4559F0", Offset = "0x454BF0", VA = "0x1804559F0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE5B")]
	[Address(RVA = "0x4558B0", Offset = "0x454AB0", VA = "0x1804558B0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AE5C")]
	[Address(RVA = "0x455B00", Offset = "0x454D00", VA = "0x180455B00")]
	public EffectTaskCardBreak(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AE5D")]
	[Address(RVA = "0x455AE0", Offset = "0x454CE0", VA = "0x180455AE0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE5E")]
	[Address(RVA = "0x4559D0", Offset = "0x454BD0", VA = "0x1804559D0")]
	private void PlayBreakEffect()
	{
	}

	[Token(Token = "0x600AE5F")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishStep()
	{
	}
}
