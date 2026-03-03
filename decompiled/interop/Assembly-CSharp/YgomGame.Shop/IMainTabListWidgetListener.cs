using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x2000954")]
public interface IMainTabListWidgetListener
{
	[Token(Token = "0x60038DF")]
	void OnInputLeftMainTab();

	[Token(Token = "0x60038E0")]
	void OnInputRightMainTab();

	[Token(Token = "0x60038E1")]
	void OnInputUpMainTab();

	[Token(Token = "0x60038E2")]
	void OnInputDownMainTab();

	[Token(Token = "0x60038E3")]
	void OnClickMainTab(int idx);
}
