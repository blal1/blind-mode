using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B41")]
public interface IPromoCodeBehaviourSupportedFooter
{
	[Token(Token = "0x60044ED")]
	bool OnSetupFooter(ElementObjectManager footerEom, IPromoCodeBehaviourFooterHandler handler);
}
