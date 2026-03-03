using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B6D")]
public class EffectTaskWaitInput : EffectTask
{
	[Token(Token = "0x2001B6E")]
	private enum Step
	{
		[Token(Token = "0x400F8E0")]
		WaitCardEffect,
		[Token(Token = "0x400F8E1")]
		WaitTutorial,
		[Token(Token = "0x400F8E2")]
		WaitInput,
		[Token(Token = "0x400F8E3")]
		WaitInputStart,
		[Token(Token = "0x400F8E4")]
		Finish
	}

	[Token(Token = "0x400F8D7")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F8D8")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F8D9")]
	[FieldOffset(Offset = "0x20")]
	private Engine.MenuActType menuActType;

	[Token(Token = "0x400F8DA")]
	[FieldOffset(Offset = "0x24")]
	private int param1;

	[Token(Token = "0x400F8DB")]
	[FieldOffset(Offset = "0x28")]
	private int param2;

	[Token(Token = "0x400F8DC")]
	[FieldOffset(Offset = "0x2C")]
	private int param3;

	[Token(Token = "0x400F8DD")]
	[FieldOffset(Offset = "0x30")]
	private string text;

	[Token(Token = "0x400F8DE")]
	public const uint cmdBitHighlight = 2045u;

	[Token(Token = "0x600B0BB")]
	[Address(RVA = "0x483270", Offset = "0x482470", VA = "0x180483270")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B0BC")]
	[Address(RVA = "0x482CE0", Offset = "0x481EE0", VA = "0x180482CE0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600B0BD")]
	[Address(RVA = "0x4858F0", Offset = "0x484AF0", VA = "0x1804858F0")]
	public EffectTaskWaitInput(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600B0BE")]
	[Address(RVA = "0x483D80", Offset = "0x482F80", VA = "0x180483D80", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B0BF")]
	[Address(RVA = "0x4831C0", Offset = "0x4823C0", VA = "0x1804831C0")]
	private void OnDrawPhase(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B0C0")]
	[Address(RVA = "0x482D80", Offset = "0x481F80", VA = "0x180482D80")]
	private void OnBattlePhase(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B0C1")]
	[Address(RVA = "0x483DF0", Offset = "0x482FF0", VA = "0x180483DF0")]
	private bool WaitCardEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600B0C2")]
	[Address(RVA = "0x4841F0", Offset = "0x4833F0", VA = "0x1804841F0")]
	private void WaitInput()
	{
	}
}
