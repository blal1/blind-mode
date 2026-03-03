using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B0A")]
public class EffectTaskCutinActivate : EffectTask
{
	[Token(Token = "0x2001B0B")]
	private enum Step
	{
		[Token(Token = "0x400F750")]
		Finish
	}

	[Token(Token = "0x400F747")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F748")]
	[FieldOffset(Offset = "0x1C")]
	private bool finished;

	[Token(Token = "0x400F749")]
	[FieldOffset(Offset = "0x20")]
	private int player;

	[Token(Token = "0x400F74A")]
	[FieldOffset(Offset = "0x24")]
	private int mixedId;

	[Token(Token = "0x400F74B")]
	[FieldOffset(Offset = "0x28")]
	private int owner;

	[Token(Token = "0x400F74C")]
	[FieldOffset(Offset = "0x2C")]
	private int state;

	[Token(Token = "0x400F74D")]
	[FieldOffset(Offset = "0x30")]
	private int cardId;

	[Token(Token = "0x400F74E")]
	[FieldOffset(Offset = "0x34")]
	private int type;

	[Token(Token = "0x600AF50")]
	[Address(RVA = "0x4691D0", Offset = "0x4683D0", VA = "0x1804691D0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF51")]
	[Address(RVA = "0x469290", Offset = "0x468490", VA = "0x180469290")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF52")]
	[Address(RVA = "0x469060", Offset = "0x468260", VA = "0x180469060")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AF53")]
	[Address(RVA = "0x469430", Offset = "0x468630", VA = "0x180469430")]
	public EffectTaskCutinActivate(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AF54")]
	[Address(RVA = "0x4693B0", Offset = "0x4685B0", VA = "0x1804693B0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF55")]
	[Address(RVA = "0x469170", Offset = "0x468370", VA = "0x180469170")]
	private void FinishStep()
	{
	}
}
