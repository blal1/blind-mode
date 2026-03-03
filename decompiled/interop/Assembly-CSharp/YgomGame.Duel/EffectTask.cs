using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AC6")]
public abstract class EffectTask
{
	[Token(Token = "0x400F595")]
	[FieldOffset(Offset = "0x10")]
	protected RunEffectWorker worker;

	[Token(Token = "0x600AE0D")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public virtual bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE0E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600AE0F")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public EffectTask(RunEffectWorker worker)
	{
	}
}
