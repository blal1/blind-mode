using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B44")]
public class EffectTaskRunDialog : EffectTask
{
	[Token(Token = "0x2001B45")]
	private enum Step
	{
		[Token(Token = "0x400F83B")]
		WaitCardEffect,
		[Token(Token = "0x400F83C")]
		WaitTutorial,
		[Token(Token = "0x400F83D")]
		Finish
	}

	[Token(Token = "0x400F833")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F834")]
	[FieldOffset(Offset = "0x1C")]
	private bool finished;

	[Token(Token = "0x400F835")]
	[FieldOffset(Offset = "0x20")]
	private Engine.DialogType type;

	[Token(Token = "0x400F836")]
	[FieldOffset(Offset = "0x24")]
	private int textId;

	[Token(Token = "0x400F837")]
	[FieldOffset(Offset = "0x28")]
	private int dwParam;

	[Token(Token = "0x400F838")]
	[FieldOffset(Offset = "0x30")]
	private string text;

	[Token(Token = "0x400F839")]
	[FieldOffset(Offset = "0x0")]
	private static string activateCardSelectionText;

	[Token(Token = "0x600B019")]
	[Address(RVA = "0x474920", Offset = "0x473B20", VA = "0x180474920")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B01A")]
	[Address(RVA = "0x474720", Offset = "0x473920", VA = "0x180474720")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600B01B")]
	[Address(RVA = "0x477150", Offset = "0x476350", VA = "0x180477150")]
	public EffectTaskRunDialog(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600B01C")]
	[Address(RVA = "0x476EF0", Offset = "0x4760F0", VA = "0x180476EF0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B01D")]
	[Address(RVA = "0x476FB0", Offset = "0x4761B0", VA = "0x180476FB0")]
	private bool WaitCardEffectStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600B01E")]
	[Address(RVA = "0x4748A0", Offset = "0x473AA0", VA = "0x1804748A0")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600B01F")]
	[Address(RVA = "0x474D40", Offset = "0x473F40", VA = "0x180474D40")]
	private void RunDialog()
	{
	}

	[Token(Token = "0x600B020")]
	[Address(RVA = "0x476C50", Offset = "0x475E50", VA = "0x180476C50")]
	private void StartDialogInput()
	{
	}
}
