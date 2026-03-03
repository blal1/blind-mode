using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F42")]
public class ProductGroupTextWidget : ElementWidgetBase
{
	[Token(Token = "0x400A6F3")]
	private const string k_ELabelText = "Label";

	[Token(Token = "0x6005C71")]
	[Address(RVA = "0x8847B0", Offset = "0x8839B0", VA = "0x1808847B0")]
	public ProductGroupTextWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005C72")]
	[Address(RVA = "0xA21530", Offset = "0xA20730", VA = "0x180A21530")]
	public static void EmbedText(ElementObjectManager templateEOM, string text)
	{
	}

	[Token(Token = "0x6005C73")]
	[Address(RVA = "0xA217D0", Offset = "0xA209D0", VA = "0x180A217D0")]
	public static void FixHeight(ElementObjectManager templateEOM)
	{
	}
}
