using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B15")]
public class EffectTaskDeckReset : EffectTask
{
	[Token(Token = "0x2001B16")]
	private enum Step
	{
		[Token(Token = "0x400F775")]
		WaitCardMove,
		[Token(Token = "0x400F776")]
		Wait
	}

	[Token(Token = "0x400F76E")]
	[FieldOffset(Offset = "0x18")]
	private bool isFinished;

	[Token(Token = "0x400F76F")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F770")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F771")]
	[FieldOffset(Offset = "0x24")]
	private int position;

	[Token(Token = "0x400F772")]
	[FieldOffset(Offset = "0x28")]
	private int deckNum;

	[Token(Token = "0x400F773")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, object> immediateWork;

	[Token(Token = "0x600AF75")]
	[Address(RVA = "0x46A680", Offset = "0x469880", VA = "0x18046A680")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF76")]
	[Address(RVA = "0x46A590", Offset = "0x469790", VA = "0x18046A590")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AF77")]
	[Address(RVA = "0x46ABD0", Offset = "0x469DD0", VA = "0x18046ABD0")]
	public EffectTaskDeckReset(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AF78")]
	[Address(RVA = "0x46A500", Offset = "0x469700", VA = "0x18046A500")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF79")]
	[Address(RVA = "0x46AB80", Offset = "0x469D80", VA = "0x18046AB80")]
	public EffectTaskDeckReset(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF7A")]
	[Address(RVA = "0x46A8F0", Offset = "0x469AF0", VA = "0x18046A8F0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF7B")]
	[Address(RVA = "0x46A920", Offset = "0x469B20", VA = "0x18046A920")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AF7C")]
	[Address(RVA = "0x46A630", Offset = "0x469830", VA = "0x18046A630")]
	private void OnFinished()
	{
	}
}
