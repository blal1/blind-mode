using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B23")]
public class EffectTaskHandOpen : EffectTask
{
	[Token(Token = "0x2001B24")]
	private enum Step
	{
		[Token(Token = "0x400F7C1")]
		None,
		[Token(Token = "0x400F7C2")]
		WaitCardMove,
		[Token(Token = "0x400F7C3")]
		WaitFrame,
		[Token(Token = "0x400F7C4")]
		WaitFlipTurn,
		[Token(Token = "0x400F7C5")]
		Finish
	}

	[Token(Token = "0x400F7B7")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F7B8")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F7B9")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F7BA")]
	[FieldOffset(Offset = "0x24")]
	private bool isOpen;

	[Token(Token = "0x400F7BB")]
	[FieldOffset(Offset = "0x28")]
	private int uniqueId;

	[Token(Token = "0x400F7BC")]
	[FieldOffset(Offset = "0x2C")]
	private bool isAll;

	[Token(Token = "0x400F7BD")]
	[FieldOffset(Offset = "0x30")]
	private int waitFrame;

	[Token(Token = "0x400F7BE")]
	[FieldOffset(Offset = "0x38")]
	private List<int> cardIds;

	[Token(Token = "0x400F7BF")]
	[FieldOffset(Offset = "0x40")]
	private List<bool> cardFaces;

	[Token(Token = "0x600AFB0")]
	[Address(RVA = "0x46E4B0", Offset = "0x46D6B0", VA = "0x18046E4B0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFB1")]
	[Address(RVA = "0x46E580", Offset = "0x46D780", VA = "0x18046E580")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFB2")]
	[Address(RVA = "0x46E2F0", Offset = "0x46D4F0", VA = "0x18046E2F0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AFB3")]
	[Address(RVA = "0x46F640", Offset = "0x46E840", VA = "0x18046F640")]
	public EffectTaskHandOpen(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AFB4")]
	[Address(RVA = "0x46E860", Offset = "0x46DA60", VA = "0x18046E860", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AFB5")]
	[Address(RVA = "0x46EFC0", Offset = "0x46E1C0", VA = "0x18046EFC0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AFB6")]
	[Address(RVA = "0x46F100", Offset = "0x46E300", VA = "0x18046F100")]
	private void WaitFrameStep()
	{
	}

	[Token(Token = "0x600AFB7")]
	[Address(RVA = "0x46E390", Offset = "0x46D590", VA = "0x18046E390")]
	private void FinishStep()
	{
	}
}
