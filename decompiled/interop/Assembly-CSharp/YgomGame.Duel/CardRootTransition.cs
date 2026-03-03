using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20019C9")]
public abstract class CardRootTransition
{
	[Token(Token = "0x400EE3E")]
	[FieldOffset(Offset = "0x10")]
	protected CardRoot cardRoot;

	[Token(Token = "0x400EE3F")]
	[FieldOffset(Offset = "0x18")]
	protected CardLocator fromLocator;

	[Token(Token = "0x400EE40")]
	[FieldOffset(Offset = "0x20")]
	protected CardLocator toLocator;

	[Token(Token = "0x400EE41")]
	[FieldOffset(Offset = "0x28")]
	private bool immediate;

	[Token(Token = "0x17001992")]
	public bool isFinished
	{
		[Token(Token = "0x600A64F")]
		[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A650")]
		[Address(RVA = "0x631700", Offset = "0x630900", VA = "0x180631700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A64A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	protected virtual void OnInitialize()
	{
	}

	[Token(Token = "0x600A64B")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "5")]
	protected virtual bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x600A64C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	protected virtual void OnImmediate()
	{
	}

	[Token(Token = "0x600A64D")]
	[Address(RVA = "0xF1C970", Offset = "0xF1BB70", VA = "0x180F1C970")]
	public void Initialize(CardRoot cardRoot, bool immediate)
	{
	}

	[Token(Token = "0x600A64E")]
	[Address(RVA = "0xF1C9C0", Offset = "0xF1BBC0", VA = "0x180F1C9C0", Slot = "7")]
	public virtual void SetCardLocator(CardLocator fromLocator, CardLocator toLocator)
	{
	}

	[Token(Token = "0x600A651")]
	[Address(RVA = "0xF1CA00", Offset = "0xF1BC00", VA = "0x180F1CA00")]
	public void Update()
	{
	}

	[Token(Token = "0x600A652")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected CardRootTransition()
	{
	}
}
