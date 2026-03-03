using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B20")]
public class EffectTaskGraveTop : EffectTask
{
	[Token(Token = "0x2001B21")]
	private enum Step
	{
		[Token(Token = "0x400F7B2")]
		WaitCardMove,
		[Token(Token = "0x400F7B3")]
		WaitCardLoad,
		[Token(Token = "0x400F7B4")]
		WaitDeckTopMove
	}

	[Token(Token = "0x400F7A5")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F7A6")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F7A7")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F7A8")]
	[FieldOffset(Offset = "0x24")]
	private int position;

	[Token(Token = "0x400F7A9")]
	[FieldOffset(Offset = "0x28")]
	private int index;

	[Token(Token = "0x400F7AA")]
	[FieldOffset(Offset = "0x2C")]
	private int uniqueId;

	[Token(Token = "0x400F7AB")]
	[FieldOffset(Offset = "0x30")]
	private int cardId;

	[Token(Token = "0x400F7AC")]
	[FieldOffset(Offset = "0x34")]
	private bool face;

	[Token(Token = "0x400F7AD")]
	[FieldOffset(Offset = "0x35")]
	private bool turn;

	[Token(Token = "0x400F7AE")]
	[FieldOffset(Offset = "0x38")]
	private CardPlace cardPlace;

	[Token(Token = "0x400F7AF")]
	[FieldOffset(Offset = "0x40")]
	private CardLocator noneLocator;

	[Token(Token = "0x400F7B0")]
	[FieldOffset(Offset = "0x48")]
	private CardRoot cardRoot;

	[Token(Token = "0x600AFA7")]
	[Address(RVA = "0x46DA40", Offset = "0x46CC40", VA = "0x18046DA40")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFA8")]
	[Address(RVA = "0x46D8D0", Offset = "0x46CAD0", VA = "0x18046D8D0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AFA9")]
	[Address(RVA = "0x46E1B0", Offset = "0x46D3B0", VA = "0x18046E1B0")]
	public EffectTaskGraveTop(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AFAA")]
	[Address(RVA = "0x46DC70", Offset = "0x46CE70", VA = "0x18046DC70", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AFAB")]
	[Address(RVA = "0x46DF70", Offset = "0x46D170", VA = "0x18046DF70")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AFAC")]
	[Address(RVA = "0x46DCB0", Offset = "0x46CEB0", VA = "0x18046DCB0")]
	private void WaitCardLoadStep()
	{
	}

	[Token(Token = "0x600AFAD")]
	[Address(RVA = "0x46A630", Offset = "0x469830", VA = "0x18046A630")]
	private void OnFinished()
	{
	}
}
