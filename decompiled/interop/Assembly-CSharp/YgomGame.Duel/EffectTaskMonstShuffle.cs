using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B35")]
public class EffectTaskMonstShuffle : EffectTask
{
	[Token(Token = "0x2001B36")]
	private enum Step
	{
		[Token(Token = "0x400F7F8")]
		WaitCardMove,
		[Token(Token = "0x400F7F9")]
		Wait
	}

	[Token(Token = "0x400F7F2")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F7F3")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F7F4")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F7F5")]
	[FieldOffset(Offset = "0x24")]
	private int flag;

	[Token(Token = "0x400F7F6")]
	[FieldOffset(Offset = "0x28")]
	private int callCounter;

	[Token(Token = "0x600AFEA")]
	[Address(RVA = "0x4720D0", Offset = "0x4712D0", VA = "0x1804720D0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFEB")]
	[Address(RVA = "0x472920", Offset = "0x471B20", VA = "0x180472920")]
	public EffectTaskMonstShuffle(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFEC")]
	[Address(RVA = "0x4722C0", Offset = "0x4714C0", VA = "0x1804722C0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AFED")]
	[Address(RVA = "0x472150", Offset = "0x471350", VA = "0x180472150")]
	private void FlagToEachPlaces(int team, int flag, out List<BasicCardPlace> basicPlaces)
	{
	}

	[Token(Token = "0x600AFEE")]
	[Address(RVA = "0x4722A0", Offset = "0x4714A0", VA = "0x1804722A0")]
	private void OnFinishedSwap()
	{
	}

	[Token(Token = "0x600AFEF")]
	[Address(RVA = "0x4722F0", Offset = "0x4714F0", VA = "0x1804722F0")]
	private void WaitCardMoveStep()
	{
	}
}
