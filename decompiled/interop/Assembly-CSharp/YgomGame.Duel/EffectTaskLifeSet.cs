using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B29")]
public class EffectTaskLifeSet : EffectTask
{
	[Token(Token = "0x2001B2A")]
	private enum Step
	{
		[Token(Token = "0x400F7DA")]
		WaitCardEffectToBreakAllCards,
		[Token(Token = "0x400F7DB")]
		WaitBreakAllCards,
		[Token(Token = "0x400F7DC")]
		Finish
	}

	[Token(Token = "0x400F7D6")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F7D7")]
	[FieldOffset(Offset = "0x1C")]
	private int team;

	[Token(Token = "0x400F7D8")]
	[FieldOffset(Offset = "0x20")]
	private bool isLethal;

	[Token(Token = "0x600AFC9")]
	[Address(RVA = "0x4708B0", Offset = "0x46FAB0", VA = "0x1804708B0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFCA")]
	[Address(RVA = "0x470820", Offset = "0x46FA20", VA = "0x180470820")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFCB")]
	[Address(RVA = "0x470A60", Offset = "0x46FC60", VA = "0x180470A60")]
	public EffectTaskLifeSet(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFCC")]
	[Address(RVA = "0x4708E0", Offset = "0x46FAE0", VA = "0x1804708E0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
