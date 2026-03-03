using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B6A")]
public class EffectTaskTurnChange : EffectTask
{
	[Token(Token = "0x2001B6B")]
	private enum Step
	{
		[Token(Token = "0x400F8D1")]
		WaitCardMove,
		[Token(Token = "0x400F8D2")]
		WaitEffects,
		[Token(Token = "0x400F8D3")]
		WaitFinish
	}

	[Token(Token = "0x400F8CA")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F8CB")]
	[FieldOffset(Offset = "0x1C")]
	private int team;

	[Token(Token = "0x400F8CC")]
	[FieldOffset(Offset = "0x20")]
	private int player;

	[Token(Token = "0x400F8CD")]
	[FieldOffset(Offset = "0x24")]
	private bool finished;

	[Token(Token = "0x400F8CE")]
	[FieldOffset(Offset = "0x25")]
	private bool finishedAnime;

	[Token(Token = "0x400F8CF")]
	[FieldOffset(Offset = "0x28")]
	private DuelStatusViewer.DuelStatusInfo statusInfo;

	[Token(Token = "0x600B0AF")]
	[Address(RVA = "0x482430", Offset = "0x481630", VA = "0x180482430")]
	public static void MinimumEffect(RunEffectWorker worker)
	{
	}

	[Token(Token = "0x600B0B0")]
	[Address(RVA = "0x4824D0", Offset = "0x4816D0", VA = "0x1804824D0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B0B1")]
	[Address(RVA = "0x482390", Offset = "0x481590", VA = "0x180482390")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600B0B2")]
	[Address(RVA = "0x4829A0", Offset = "0x481BA0", VA = "0x1804829A0")]
	public EffectTaskTurnChange(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600B0B3")]
	[Address(RVA = "0x482630", Offset = "0x481830", VA = "0x180482630", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B0B4")]
	[Address(RVA = "0x4827E0", Offset = "0x4819E0", VA = "0x1804827E0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600B0B5")]
	[Address(RVA = "0x4828F0", Offset = "0x481AF0", VA = "0x1804828F0")]
	private void WaitEffectsStep()
	{
	}
}
