using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20019D0")]
public abstract class CardRootTransitionTimeBase : CardRootTransition
{
	[Token(Token = "0x400EE57")]
	[FieldOffset(Offset = "0x30")]
	private float time;

	[Token(Token = "0x17001996")]
	protected virtual float dulation
	{
		[Token(Token = "0x600A663")]
		[Address(RVA = "0xF1C930", Offset = "0xF1BB30", VA = "0x180F1C930", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600A662")]
	protected abstract void UpdateTransition(float t);

	[Token(Token = "0x600A664")]
	[Address(RVA = "0xF1C860", Offset = "0xF1BA60", VA = "0x180F1C860", Slot = "5")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x600A665")]
	[Address(RVA = "0xF1C840", Offset = "0xF1BA40", VA = "0x180F1C840", Slot = "6")]
	protected override void OnImmediate()
	{
	}

	[Token(Token = "0x600A666")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected CardRootTransitionTimeBase()
	{
	}
}
