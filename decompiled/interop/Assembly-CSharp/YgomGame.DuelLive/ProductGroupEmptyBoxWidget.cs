using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F3D")]
public class ProductGroupEmptyBoxWidget : ElementWidgetBase
{
	[Token(Token = "0x400A6D3")]
	private const string k_ELabelLabel = "Label";

	[Token(Token = "0x400A6D4")]
	[FieldOffset(Offset = "0x20")]
	private TMP_Text m_label;

	[Token(Token = "0x6005C5D")]
	[Address(RVA = "0xA20620", Offset = "0xA1F820", VA = "0x180A20620")]
	public ProductGroupEmptyBoxWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005C5E")]
	[Address(RVA = "0xA205F0", Offset = "0xA1F7F0", VA = "0x180A205F0")]
	public void SetView(string text)
	{
	}
}
