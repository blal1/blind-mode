using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AC7")]
public class EffectTaskBattleAttack : EffectTask
{
	[Token(Token = "0x2001AC8")]
	private enum Step
	{
		[Token(Token = "0x400F59E")]
		WaitCardMove,
		[Token(Token = "0x400F59F")]
		WaitFinalBlow,
		[Token(Token = "0x400F5A0")]
		Finish
	}

	[Token(Token = "0x400F596")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F597")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F598")]
	[FieldOffset(Offset = "0x20")]
	private int srcTeam;

	[Token(Token = "0x400F599")]
	[FieldOffset(Offset = "0x24")]
	private int srcPosition;

	[Token(Token = "0x400F59A")]
	[FieldOffset(Offset = "0x28")]
	private int dstTeam;

	[Token(Token = "0x400F59B")]
	[FieldOffset(Offset = "0x2C")]
	private int dstPosition;

	[Token(Token = "0x400F59C")]
	[FieldOffset(Offset = "0x30")]
	private bool tutorialFinished;

	[Token(Token = "0x600AE10")]
	[Address(RVA = "0x439210", Offset = "0x438410", VA = "0x180439210")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE11")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE12")]
	[Address(RVA = "0x439020", Offset = "0x438220", VA = "0x180439020")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AE13")]
	[Address(RVA = "0x439380", Offset = "0x438580", VA = "0x180439380", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE14")]
	[Address(RVA = "0x4399A0", Offset = "0x438BA0", VA = "0x1804399A0")]
	public EffectTaskBattleAttack(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AE15")]
	[Address(RVA = "0x4393C0", Offset = "0x4385C0", VA = "0x1804393C0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AE16")]
	[Address(RVA = "0x439200", Offset = "0x438400", VA = "0x180439200")]
	private void FinishStep()
	{
	}
}
