using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x2001556")]
public abstract class SequenceBehaviour : ISequenceBehaviour
{
	[Token(Token = "0x2001557")]
	public enum State
	{
		[Token(Token = "0x400CC5D")]
		None,
		[Token(Token = "0x400CC5E")]
		Active,
		[Token(Token = "0x400CC5F")]
		End
	}

	[Token(Token = "0x400CC5A")]
	[FieldOffset(Offset = "0x10")]
	protected readonly SequenceBehaviourWork m_Work;

	[Token(Token = "0x1700141E")]
	public State state
	{
		[Token(Token = "0x60083DB")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(State);
		}
		[Token(Token = "0x60083DC")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700141F")]
	public string name
	{
		[Token(Token = "0x60083DD")]
		[Address(RVA = "0xCCB3A0", Offset = "0xCCA5A0", VA = "0x180CCB3A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001420")]
	protected virtual bool isAcceptToSkipLoop
	{
		[Token(Token = "0x60083DE")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60083DF")]
	[Address(RVA = "0xCC8CE0", Offset = "0xCC7EE0", VA = "0x180CC8CE0")]
	public SequenceBehaviour(SequenceBehaviourWork sequenceBehaviourWork)
	{
	}

	[Token(Token = "0x60083E0")]
	[Address(RVA = "0xCCB150", Offset = "0xCCA350", VA = "0x180CCB150", Slot = "6")]
	public void Begin()
	{
	}

	[Token(Token = "0x60083E1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	protected virtual void OnBegin()
	{
	}

	[Token(Token = "0x60083E2")]
	[Address(RVA = "0x60A530", Offset = "0x609730", VA = "0x18060A530", Slot = "7")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x60083E3")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "12")]
	protected virtual bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x60083E4")]
	[Address(RVA = "0xCCB210", Offset = "0xCCA410", VA = "0x180CCB210", Slot = "8")]
	public void End()
	{
	}

	[Token(Token = "0x60083E5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	protected virtual void OnEnd()
	{
	}

	[Token(Token = "0x60083E6")]
	[Address(RVA = "0xCCB2D0", Offset = "0xCCA4D0", VA = "0x180CCB2D0", Slot = "14")]
	protected virtual void OnInputAccept()
	{
	}

	[Token(Token = "0x60083E7")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "15")]
	public virtual bool OnBack()
	{
		return default(bool);
	}
}
