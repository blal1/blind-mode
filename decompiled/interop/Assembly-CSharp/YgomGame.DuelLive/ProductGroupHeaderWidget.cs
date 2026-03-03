using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F3E")]
public class ProductGroupHeaderWidget : ElementWidgetBase
{
	[Token(Token = "0x400A6D5")]
	private const string k_ELabelLabel = "Label";

	[Token(Token = "0x400A6D6")]
	[FieldOffset(Offset = "0x20")]
	public readonly TMP_Text label;

	[Token(Token = "0x6005C5F")]
	[Address(RVA = "0xA206B0", Offset = "0xA1F8B0", VA = "0x180A206B0")]
	public ProductGroupHeaderWidget(ElementObjectManager eom)
	{
	}
}
