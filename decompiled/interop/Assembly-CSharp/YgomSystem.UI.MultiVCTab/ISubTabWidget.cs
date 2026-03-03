using Il2CppDummyDll;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005F1")]
public interface ISubTabWidget
{
	[Token(Token = "0x170004B1")]
	MultiVCTabGroupWidget parentGroup
	{
		[Token(Token = "0x60026FB")]
		get;
	}

	[Token(Token = "0x170004B2")]
	MultiVCTabWidget tabWidget
	{
		[Token(Token = "0x60026FC")]
		get;
	}
}
