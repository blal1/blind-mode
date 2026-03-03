using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.Utility;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B3F")]
public interface IPromoCodeBehaviourHandler
{
	[Token(Token = "0x1700092D")]
	AssetLinker assetLinker
	{
		[Token(Token = "0x60044E9")]
		get;
	}

	[Token(Token = "0x1700092E")]
	TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x60044EA")]
		get;
	}

	[Token(Token = "0x60044EB")]
	bool TryInvokeFooter(string footerName);
}
