using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC5")]
public class FollowerPlayerContext : PlayerContextBase
{
	[Token(Token = "0x400A05D")]
	[FieldOffset(Offset = "0x68")]
	private FollowState m_BaseFollowState;

	[Token(Token = "0x60052AB")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private new void Import(object followerPlayerData)
	{
	}

	[Token(Token = "0x60052AC")]
	[Address(RVA = "0x980BE0", Offset = "0x97FDE0", VA = "0x180980BE0")]
	public void Import(object followerPlayerData, FollowContextCollection followContextCollection)
	{
	}

	[Token(Token = "0x60052AD")]
	[Address(RVA = "0x980A80", Offset = "0x97FC80", VA = "0x180980A80")]
	public void ImportFollowPlayers(FollowContextCollection followContextCollection)
	{
	}

	[Token(Token = "0x60052AE")]
	[Address(RVA = "0x980B40", Offset = "0x97FD40", VA = "0x180980B40")]
	public new void ImportRefreshData(object playerRefreshData)
	{
	}

	[Token(Token = "0x60052AF")]
	[Address(RVA = "0x97E550", Offset = "0x97D750", VA = "0x18097E550")]
	public FollowerPlayerContext()
	{
	}
}
