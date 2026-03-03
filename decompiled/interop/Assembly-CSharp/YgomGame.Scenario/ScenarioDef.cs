using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC9")]
public class ScenarioDef
{
	[Token(Token = "0x2000ACA")]
	public enum BehaviourAsyncMode
	{
		[Token(Token = "0x40093AD")]
		None,
		[Token(Token = "0x40093AE")]
		ThroughAsync,
		[Token(Token = "0x40093AF")]
		BlockAsync,
		[Token(Token = "0x40093B0")]
		ChildAsync
	}

	[Token(Token = "0x6004245")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ScenarioDef()
	{
	}
}
