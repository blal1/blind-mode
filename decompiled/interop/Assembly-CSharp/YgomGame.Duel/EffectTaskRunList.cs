using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B56")]
public class EffectTaskRunList : EffectTask
{
	[Token(Token = "0x2001B57")]
	private enum Step
	{
		[Token(Token = "0x400F891")]
		WaitCardMove,
		[Token(Token = "0x400F892")]
		WaitTutorial,
		[Token(Token = "0x400F893")]
		Finish
	}

	[Token(Token = "0x400F88A")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F88B")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F88C")]
	[FieldOffset(Offset = "0x20")]
	private int param1;

	[Token(Token = "0x400F88D")]
	[FieldOffset(Offset = "0x24")]
	private int param2;

	[Token(Token = "0x400F88E")]
	[FieldOffset(Offset = "0x28")]
	private int param3;

	[Token(Token = "0x400F88F")]
	[FieldOffset(Offset = "0x30")]
	private string text;

	[Token(Token = "0x600B066")]
	[Address(RVA = "0x47D620", Offset = "0x47C820", VA = "0x18047D620")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B067")]
	[Address(RVA = "0x47D4F0", Offset = "0x47C6F0", VA = "0x18047D4F0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600B068")]
	[Address(RVA = "0x47E610", Offset = "0x47D810", VA = "0x18047E610")]
	public EffectTaskRunList(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600B069")]
	[Address(RVA = "0x47E2B0", Offset = "0x47D4B0", VA = "0x18047E2B0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B06A")]
	[Address(RVA = "0x47E480", Offset = "0x47D680", VA = "0x18047E480")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600B06B")]
	[Address(RVA = "0x47D750", Offset = "0x47C950", VA = "0x18047D750")]
	private void RunList(int iPlayer, int iType, int param)
	{
	}

	[Token(Token = "0x600B06C")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishStep()
	{
	}
}
