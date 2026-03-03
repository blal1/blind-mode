using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC0")]
public class BlockPlayerContext : PlayerContextBase
{
	[Token(Token = "0x400A04D")]
	[FieldOffset(Offset = "0x68")]
	private long m_BlockDateTs;

	[Token(Token = "0x6005283")]
	[Address(RVA = "0x97E480", Offset = "0x97D680", VA = "0x18097E480")]
	public new void Import(object blockPlayerData)
	{
	}

	[Token(Token = "0x6005284")]
	[Address(RVA = "0x97E380", Offset = "0x97D580", VA = "0x18097E380", Slot = "23")]
	public override int CompareTo(IPlayerContext other)
	{
		return default(int);
	}

	[Token(Token = "0x6005285")]
	[Address(RVA = "0x97E550", Offset = "0x97D750", VA = "0x18097E550")]
	public BlockPlayerContext()
	{
	}
}
