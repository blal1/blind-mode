using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001B4A")]
public class EffectTaskRunDice : EffectTask
{
	[Token(Token = "0x2001B4B")]
	private enum Step
	{
		[Token(Token = "0x400F852")]
		WaitCardEffect,
		[Token(Token = "0x400F853")]
		WaitDice,
		[Token(Token = "0x400F854")]
		Finish
	}

	[Token(Token = "0x400F847")]
	[FieldOffset(Offset = "0x18")]
	private int team;

	[Token(Token = "0x400F848")]
	[FieldOffset(Offset = "0x1C")]
	private int numThrows;

	[Token(Token = "0x400F849")]
	[FieldOffset(Offset = "0x20")]
	private int number;

	[Token(Token = "0x400F84A")]
	[FieldOffset(Offset = "0x28")]
	private ScreenSelector selector;

	[Token(Token = "0x400F84B")]
	[FieldOffset(Offset = "0x30")]
	private bool isSkip;

	[Token(Token = "0x400F84C")]
	[FieldOffset(Offset = "0x31")]
	private bool isTimelineLoaded;

	[Token(Token = "0x400F84D")]
	[FieldOffset(Offset = "0x34")]
	private int param1;

	[Token(Token = "0x400F84E")]
	[FieldOffset(Offset = "0x38")]
	private int param2;

	[Token(Token = "0x400F84F")]
	[FieldOffset(Offset = "0x3C")]
	private int param3;

	[Token(Token = "0x400F850")]
	[FieldOffset(Offset = "0x40")]
	private Step step;

	[Token(Token = "0x600B02F")]
	[Address(RVA = "0x477460", Offset = "0x476660", VA = "0x180477460")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B030")]
	[Address(RVA = "0x4772A0", Offset = "0x4764A0", VA = "0x1804772A0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B031")]
	[Address(RVA = "0x477970", Offset = "0x476B70", VA = "0x180477970")]
	public EffectTaskRunDice(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B032")]
	[Address(RVA = "0x477540", Offset = "0x476740", VA = "0x180477540", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B033")]
	[Address(RVA = "0x477640", Offset = "0x476840", VA = "0x180477640")]
	private void WaitCardEffectStep()
	{
	}

	[Token(Token = "0x600B034")]
	[Address(RVA = "0x4778B0", Offset = "0x476AB0", VA = "0x1804778B0")]
	private void WaitDiceStep()
	{
	}

	[Token(Token = "0x600B035")]
	[Address(RVA = "0x4774C0", Offset = "0x4766C0", VA = "0x1804774C0", Slot = "5")]
	public override void OnDestroy()
	{
	}
}
