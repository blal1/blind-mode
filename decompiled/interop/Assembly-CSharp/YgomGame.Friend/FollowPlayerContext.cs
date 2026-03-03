using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC6")]
public class FollowPlayerContext : PlayerContextBase
{
	[Token(Token = "0x60052B0")]
	[Address(RVA = "0x97FA40", Offset = "0x97EC40", VA = "0x18097FA40")]
	public new void Import(object followPlayerData)
	{
	}

	[Token(Token = "0x60052B1")]
	[Address(RVA = "0x97F9A0", Offset = "0x97EBA0", VA = "0x18097F9A0")]
	public new void ImportRefreshData(object playerRefreshData)
	{
	}

	[Token(Token = "0x60052B2")]
	[Address(RVA = "0x97E550", Offset = "0x97D750", VA = "0x18097E550")]
	public FollowPlayerContext()
	{
	}
}
