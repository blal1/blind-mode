using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B52")]
public class EffectTaskRunJanken : EffectTask
{
	[Token(Token = "0x2001B53")]
	private enum HandType
	{
		[Token(Token = "0x400F881")]
		Rock,
		[Token(Token = "0x400F882")]
		Scissors,
		[Token(Token = "0x400F883")]
		Paper,
		[Token(Token = "0x400F884")]
		Num
	}

	[Token(Token = "0x2001B54")]
	private enum Result
	{
		[Token(Token = "0x400F886")]
		Win,
		[Token(Token = "0x400F887")]
		Lose,
		[Token(Token = "0x400F888")]
		Draw
	}

	[Token(Token = "0x400F87F")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600B05F")]
	[Address(RVA = "0x47CFE0", Offset = "0x47C1E0", VA = "0x18047CFE0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B060")]
	[Address(RVA = "0x47D2A0", Offset = "0x47C4A0", VA = "0x18047D2A0")]
	public EffectTaskRunJanken(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B061")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B062")]
	[Address(RVA = "0x47D250", Offset = "0x47C450", VA = "0x18047D250")]
	private Result Janken(HandType handMyself, HandType handRival)
	{
		return default(Result);
	}
}
