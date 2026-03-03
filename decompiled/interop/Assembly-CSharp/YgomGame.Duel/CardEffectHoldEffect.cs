using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200196E")]
public class CardEffectHoldEffect : CardEffectBase
{
	[Token(Token = "0x200196F")]
	public enum Mode
	{
		[Token(Token = "0x400EC52")]
		TracePosition,
		[Token(Token = "0x400EC53")]
		TracePosture,
		[Token(Token = "0x400EC54")]
		ChildPosture,
		[Token(Token = "0x400EC55")]
		ChildPosition
	}

	[Token(Token = "0x400EC4C")]
	[FieldOffset(Offset = "0x28")]
	private string label;

	[Token(Token = "0x400EC4D")]
	[FieldOffset(Offset = "0x30")]
	private DuelEffectPool.Type type;

	[Token(Token = "0x400EC4E")]
	[FieldOffset(Offset = "0x34")]
	private Mode mode;

	[Token(Token = "0x400EC4F")]
	[FieldOffset(Offset = "0x38")]
	private bool show;

	[Token(Token = "0x400EC50")]
	[FieldOffset(Offset = "0x39")]
	private bool quitImmediate;

	[Token(Token = "0x600A340")]
	[Address(RVA = "0xF031C0", Offset = "0xF023C0", VA = "0x180F031C0")]
	public static CardEffectHoldEffect CreateShowEffect(CardRoot cardRoot, string label, DuelEffectPool.Type type, Mode mode)
	{
		return null;
	}

	[Token(Token = "0x600A341")]
	[Address(RVA = "0xF03120", Offset = "0xF02320", VA = "0x180F03120")]
	public static CardEffectHoldEffect CreateHideEffect(CardRoot cardRoot, string label, bool quitImmediate)
	{
		return null;
	}

	[Token(Token = "0x600A342")]
	[Address(RVA = "0xF03270", Offset = "0xF02470", VA = "0x180F03270", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A343")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectHoldEffect()
	{
	}
}
