using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F41")]
public class ProductGroupSubHeaderWidget : ElementWidgetBase
{
	[Token(Token = "0x400A6F1")]
	private const string k_ELabelLabel = "Label";

	[Token(Token = "0x400A6F2")]
	[FieldOffset(Offset = "0x20")]
	public readonly TMP_Text label;

	[Token(Token = "0x6005C70")]
	[Address(RVA = "0xA214A0", Offset = "0xA206A0", VA = "0x180A214A0")]
	public ProductGroupSubHeaderWidget(ElementObjectManager eom)
	{
	}
}
